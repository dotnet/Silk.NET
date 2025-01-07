// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.FindSymbols;
using static Microsoft.CodeAnalysis.CSharp.SyntaxFactory;
using System.Diagnostics;
using System.Reflection.Metadata;
using Microsoft.CodeAnalysis.Editing;
using System.Xml.Linq;
using Microsoft.Extensions.Logging;
using Silk.NET.SilkTouch.Clang;
using Microsoft.Extensions.Options;
using System.Reflection;

namespace Silk.NET.SilkTouch.Mods
{
    /// <summary>
    /// A mod to modify COM interface structs into opaque structs that act like ComPtr objects
    /// </summary>
    /// <param name="logger">The logger to use.</param>
    /// <param name="config">The configuration to use.</param>
    [ModConfiguration<Configuration>]
    public class TransformCOM(
        ILogger<TransformCOM> logger,
        IOptionsSnapshot<TransformCOM.Configuration> config) : Mod
    {
        /// <summary>
        /// The configuration for the <see cref="TransformCOM"/> mod.
        /// </summary>
        public class Configuration
        {
            /// <summary>
            /// The base types to consider the base of the com tree
            /// Usually this is IUknown.Interface
            /// </summary>
            public string[]? BaseTypes { get; init; }

            /// <summary>
            /// Additional Com Types which are not in this job but referenced by it
            /// </summary>
            public string[]? AdditionalCOMTypes { get; init; }
        }

        /// <inheritdoc />
        public override async Task ExecuteAsync(IModContext ctx, CancellationToken ct = default)
        {
            await base.ExecuteAsync(ctx, ct);

            var firstPass = new TypeDiscoverer(config.Value.BaseTypes ?? ["IUnknown.Interface"]);
            var proj = ctx.SourceProject;

            if (proj is null)
            {
                return;
            }

            int count = proj?.DocumentIds.Count ?? 0;

            logger.LogInformation("Starting COM Object Collection");
            foreach (var docId in proj?.DocumentIds ?? [])
            {
                var doc =
                    proj?.GetDocument(docId) ?? throw new InvalidOperationException("Document missing");
                if (await doc.GetSyntaxRootAsync(ct) is not { } root)
                {
                    continue;
                }

                firstPass.Visit(root);
            }

            firstPass.FoundCOMTypes = firstPass.FoundCOMTypes.Where(val => val.Item2).ToList();

            foreach (string comType in config.Value.AdditionalCOMTypes ?? [])
            {
                firstPass.FoundCOMTypes.Add((comType, true));
            }

            int index = 0;

            var compilation = await proj!.GetCompilationAsync();
            if (compilation is null)
            {
                logger.LogWarning("project was unable to compile, some usages may not be properly updated");
            }

            logger.LogInformation("Starting COM Object Usage Update");
            foreach (var docId in proj?.DocumentIds ?? [])
            {
                index++;
                var doc =
                    proj?.GetDocument(docId) ?? throw new InvalidOperationException("Document missing");
                if (await doc.GetSyntaxRootAsync(ct) is not { } root)
                {
                    continue;
                }

                var editor = new SyntaxEditor(root, proj.Solution.Workspace.Services);
                // Replace pointer member access -> with regular member access .
                var memberAccesses = root.DescendantNodes()
                    .OfType<MemberAccessExpressionSyntax>()
                    .Where(m => m.IsKind(SyntaxKind.PointerMemberAccessExpression));

                var nullAssignments = root.DescendantNodes()
                    .OfType<AssignmentExpressionSyntax>()
                    .Where(aes => aes.Right.IsKind(SyntaxKind.NullLiteralExpression));

                var invocationsWithNullArgs = root.DescendantNodes()
                    .OfType<InvocationExpressionSyntax>()
                    .Where(ies => ies.ArgumentList.Arguments.Any(arg => arg.Expression.IsKind(SyntaxKind.NullLiteralExpression)));

                var nullExpressions = root.DescendantNodes()
                    .OfType<BinaryExpressionSyntax>()
                    .Where(bes => bes.Left.IsKind(SyntaxKind.NullLiteralExpression) || bes.Right.IsKind(SyntaxKind.NullLiteralExpression));

                var nullInstantiations = root.DescendantNodes()
                    .OfType<VariableDeclarationSyntax>()
                    .Where(vds => vds.Variables.Any(var => var.Initializer is not null && var.Initializer.Value is LiteralExpressionSyntax lit && lit.IsKind(SyntaxKind.NullLiteralExpression)));

                if (memberAccesses.Count() == 0 && nullAssignments.Count() == 0 &&
                    invocationsWithNullArgs.Count() == 0 && nullExpressions.Count() == 0 &&
                    nullInstantiations.Count() == 0)
                {
                    logger.LogInformation("COM Object Usage Update for {0} Skipped ({1}/{2})", doc.Name, index, count);

                    continue;
                }

                var syntaxTree = await doc.GetSyntaxTreeAsync();
                if (syntaxTree is null)
                {
                    logger.LogWarning("unable to retrieve Semantic Model for {}", doc.Name);
                }
                var semanticModel = compilation is not null ? compilation.GetSemanticModel(syntaxTree!) : await doc.GetSemanticModelAsync();

                foreach (var memberAccess in memberAccesses)
                {
                    var typeInfo = semanticModel.GetTypeInfo(memberAccess.Expression);
                    var name = GetTypeName(typeInfo.Type?.ToString() ?? string.Empty);

                    // Check if the type is a ComType

                    if (typeInfo.Type != null && firstPass.FoundCOMTypes.Any(type => $"{type.Item1}*" == name))
                    {
                        var newMemberAccess = MemberAccessExpression(SyntaxKind.SimpleMemberAccessExpression, memberAccess.Expression, memberAccess.Name);
                        editor.ReplaceNode(memberAccess, newMemberAccess);
                    }
                }

                foreach (var nullAssignment in nullAssignments)
                {
                    var typeInfo = semanticModel.GetTypeInfo(nullAssignment);
                    var name = GetTypeName(typeInfo.Type?.ToString() ?? string.Empty);
                    // Check if the type is a ComType
                    if (typeInfo.Type != null && firstPass.FoundCOMTypes.Any(type => $"{type.Item1}*" == name))
                    {
                        var newNullAssignment = AssignmentExpression(nullAssignment.Kind(), nullAssignment.Left, LiteralExpression(SyntaxKind.DefaultExpression));
                        editor.ReplaceNode(nullAssignment, newNullAssignment);
                    }
                }

                foreach (var invocation in invocationsWithNullArgs)
                {
                    var symbolInfo = semanticModel.GetSymbolInfo(invocation);
                    var newInvocation = invocation;
                    if (symbolInfo.Symbol is IMethodSymbol methodSymbol)
                    {
                        var arguments = invocation.ArgumentList.Arguments;
                        for (int i = 0; i < arguments.Count; i++)
                        {
                            var argument = arguments[i];
                            // Check if the argument is a null literal
                            if (argument.Expression.IsKind(SyntaxKind.NullLiteralExpression))
                            {
                                // Get the corresponding parameter type
                                var parameterType = methodSymbol.Parameters[i].Type;
                                var name = GetTypeName(parameterType?.ToString() ?? string.Empty);

                                // Check if the parameter type is ComType
                                if (firstPass.FoundCOMTypes.Any(type => $"{type.Item1}*" == name))
                                {
                                    var newDefaultArg = Argument(LiteralExpression(SyntaxKind.DefaultLiteralExpression));
                                    newInvocation = newInvocation.ReplaceNode(argument, newDefaultArg);
                                }
                            }
                        }
                    }
                    editor.ReplaceNode(invocation, newInvocation);
                }

                foreach (var nullExpression in nullExpressions)
                {
                    var typeInfoR = semanticModel.GetTypeInfo(nullExpression.Right);
                    var typeInfoL = semanticModel.GetTypeInfo(nullExpression.Left);
                    var nameR = GetTypeName(typeInfoR.Type?.ToString() ?? string.Empty);
                    var nameL = GetTypeName(typeInfoL.Type?.ToString() ?? string.Empty);


                    if (nullExpression.Left.IsKind(SyntaxKind.NullLiteralExpression))
                    {
                        // Check if the type is a ComType
                        if (typeInfoR.Type != null && firstPass.FoundCOMTypes.Any(type => $"{type.Item1}*" == nameR))
                        {
                            var newExpression = BinaryExpression(nullExpression.Kind(), nullExpression.Left, IdentifierName($"{nullExpression.Right.ToFullString()}.lpVtbl"));
                            editor.ReplaceNode(nullExpression, newExpression);
                        }
                    }
                    else
                    {
                        // Check if the type is a ComType
                        if (typeInfoL.Type != null && firstPass.FoundCOMTypes.Any(type => $"{type.Item1}*" == nameL))
                        {
                            var newExpression = BinaryExpression(nullExpression.Kind(), IdentifierName($"{nullExpression.Left.ToFullString()}.lpVtbl"), nullExpression.Right);
                            editor.ReplaceNode(nullExpression, newExpression);
                        }
                    }

                }

                foreach (var instantiation in nullInstantiations)
                {
                    // Get the corresponding parameter type
                    var variableType = instantiation.Type;
                    var name = GetTypeName(variableType?.ToString() ?? string.Empty);

                    // Check if the parameter type is ComType
                    if (!firstPass.FoundCOMTypes.Any(type => $"{type.Item1}*" == name))
                    {
                        continue;
                    }

                    var newInstantiation = instantiation;
                    var variables = instantiation.Variables;
                    for (int i = 0; i < variables.Count; i++)
                    {
                        var variableExpression = variables[i].Initializer?.Value as LiteralExpressionSyntax;
                        // Check if the variable is instantiated to a null literal
                        if (variableExpression is not null && variableExpression.IsKind(SyntaxKind.NullLiteralExpression))
                        {
                            var newDefaultArg = LiteralExpression(SyntaxKind.DefaultLiteralExpression);
                            newInstantiation = newInstantiation.ReplaceNode(variableExpression, newDefaultArg);
                        }
                    }
                    editor.ReplaceNode(instantiation, newInstantiation);
                }

                doc = doc.WithSyntaxRoot(editor.GetChangedRoot().NormalizeWhitespace());

                proj = doc.Project;

                logger.LogInformation("COM Object Usage Update for {0} Complete ({1}/{2})", doc.Name, index, count);
            }


            var rewriter = new Rewriter(firstPass.FoundCOMTypes);
            index = 0;
            logger.LogInformation("Starting COM Object Rewrite");
            foreach (var docId in proj?.DocumentIds ?? [])
            {
                index++;
                var doc =
                    proj?.GetDocument(docId) ?? throw new InvalidOperationException("Document missing");
                if (await doc.GetSyntaxRootAsync(ct) is not { } root)
                {
                    continue;
                }

                doc = doc.WithSyntaxRoot(rewriter.Visit(root).NormalizeWhitespace());

                proj = doc.Project;

                logger.LogInformation("COM Object Rewrite for {0} Complete ({1}/{2})", doc.Name, index, count);
            }

            
            ctx.SourceProject = proj;
        }

        class TypeDiscoverer(string[] BaseTypes) : CSharpSyntaxWalker
        {
            private Dictionary<string, List<(string, bool)>> _interfaceParenting = new Dictionary<string, List<(string, bool)>>();

            /// <summary>
            /// The list of known COM interface types
            /// (name of type, is it a struct?)
            /// </summary>
            public List<(string, bool)> FoundCOMTypes = [];

            public override void VisitStructDeclaration(StructDeclarationSyntax node)
            {
                base.VisitStructDeclaration(node);

                var bases = node.BaseList;

                if (bases is null)
                {
                    return;
                }

                var className = $"{node.Identifier}";

                CheckBases((className, true), bases);
            }


            public override void VisitInterfaceDeclaration(InterfaceDeclarationSyntax node)
            {
                base.VisitInterfaceDeclaration(node);

                var bases = node.BaseList;

                if (bases is null)
                {
                    return;
                }

                string name = $"{node.Identifier}";
                if (name == "Interface")
                {
                    var parent = node.Parent as StructDeclarationSyntax;
                    if (parent is not null)
                        name = $"{parent.Identifier}.{name}";
                }

                CheckBases((name, false), bases);
            }

            private void CheckBases((string, bool) className, BaseListSyntax bases)
            {
                if (bases.Types.Any(baseType => BaseTypes.Any(BaseType => baseType.Type.ToString() == BaseType) || FoundCOMTypes.Any(val => val.Item1 == $"{baseType.Type}")))
                {
                    COMTypeValidated(className);
                    return;
                }

                foreach (BaseTypeSyntax baseType in bases.Types)
                {
                    string fullName = $"{baseType.Type}";
                    if (!_interfaceParenting.ContainsKey(fullName))
                        _interfaceParenting.Add(fullName, new());

                    _interfaceParenting[fullName].Add(className);
                }
            }

            private void COMTypeValidated((string, bool) typeName)
            {
                if (FoundCOMTypes.Contains(typeName))
                {
                    return;
                }

                FoundCOMTypes.Add(typeName);

                if (!_interfaceParenting.TryGetValue(typeName.Item1, out List<(string, bool)>? children))
                    return;

                foreach ((string, bool) childName in children)
                {
                    COMTypeValidated(childName);
                }
            }
        }

        class Rewriter(List<(string, bool)> ComTypes)
            : CSharpSyntaxRewriter
        {
            public override SyntaxNode? VisitPointerType(PointerTypeSyntax node)
            {
                for (int i = 0; i < ComTypes.Count; i++)
                {
                    (string, bool) val = ComTypes[i];

                    if (val.Item1 == node.ElementType.ToString())
                    {
                        return IdentifierName(val.Item1);
                    }
                }

                return base.VisitPointerType(node);
            }

            public override SyntaxNode VisitGenericName(GenericNameSyntax node) => node;

            public override SyntaxNode? VisitIdentifierName(IdentifierNameSyntax node)
            {
                if (node.Identifier.ToString() == "lpVtbl")
                {
                    return ParenthesizedExpression(PrefixUnaryExpression(SyntaxKind.PointerIndirectionExpression, node));
                }

                return base.VisitIdentifierName(node);
            }

            public override SyntaxNode? VisitVariableDeclaration(VariableDeclarationSyntax node)
            {
                if (node.Type.ToString() == "void**" && node.Variables.First().Identifier.ToString() == "lpVtbl")
                {
                    return VariableDeclaration(PointerType(PointerType(PointerType(IdentifierName("void")))))
                        .AddVariables(VariableDeclarator("lpVtbl"));
                }

                return base.VisitVariableDeclaration(node);
            }

            public override SyntaxNode? VisitInterfaceDeclaration(InterfaceDeclarationSyntax node)
            {
                var ret = base.VisitInterfaceDeclaration(node);

                if (ret is InterfaceDeclarationSyntax inter && inter.BaseList is not null && inter.BaseList.Types.Any(baseType => baseType.Type.ToString().StartsWith("I") && baseType.Type.ToString().EndsWith(".Interface")))
                {
                    List<BaseTypeSyntax> baseTypes = [];
                    foreach (BaseTypeSyntax baseType in inter.BaseList.Types)
                    {
                        if (ComTypes.Any(com => $"{com.Item1}.Interface" == baseType.Type.ToString()))
                        {
                            baseTypes.Add(SimpleBaseType(IdentifierName(baseType.Type.ToString())));
                        }
                        else
                        {
                            baseTypes.Add(baseType);
                        }
                    }

                    ret = inter.WithBaseList(BaseList(SeparatedList(baseTypes)));
                }

                return ret;
            }

            public override SyntaxNode? VisitCastExpression(CastExpressionSyntax node)
            {
                var castType = node.Type.ToString();

                var expression = node.Expression.ToString();

                if (expression != "Unsafe.AsPointer(ref this)")
                {
                    return base.VisitCastExpression(node);
                }

                for (int i = 0; i < ComTypes.Count; i++)
                {
                    (string, bool) val = ComTypes[i];

                    if (castType == $"{val.Item1}*")
                    {
                        return ThisExpression();
                    }
                }

                return base.VisitCastExpression(node);
            }

            public override SyntaxNode? VisitParameter(ParameterSyntax node)
            {
                var visited = base.VisitParameter(node);
                var visitedParameter = visited as ParameterSyntax;
                if (visitedParameter is null || visitedParameter.Default is null || visitedParameter.Type is null ||
                    !visitedParameter.Default.Value.IsKind(SyntaxKind.NullLiteralExpression) ||
                    !ComTypes.Any(com => visitedParameter.Type?.ToString() == com.Item1))
                {
                    return visited;
                }

                return Parameter(visitedParameter.AttributeLists, visitedParameter.Modifiers, visitedParameter.Type, visitedParameter.Identifier, EqualsValueClause(LiteralExpression(SyntaxKind.DefaultLiteralExpression)));
            }
        }

        private string GetTypeName(string fullTypeName)
        {
            int dot = fullTypeName.LastIndexOf('.');

            if (dot != -1)
            {
                return fullTypeName.Substring(dot + 1);
            }

            return fullTypeName;
        }
    }
}
