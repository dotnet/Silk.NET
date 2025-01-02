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

namespace Silk.NET.SilkTouch.Mods
{
    /// <summary>
    /// A mod to modify COM interface structs into opaque structs that act like ComPtr objects
    /// </summary>
    /// <param name="logger">The logger to use.</param>
    [ModConfiguration<Config>]
    public class TransformCOM(ILogger<TransformCOM> logger) : Mod
    {
        /// <summary>
        /// The configuration for the <see cref="TransformCOM"/> mod.
        /// </summary>
        public class Config
        {

        }

        /// <inheritdoc />
        public override async Task ExecuteAsync(IModContext ctx, CancellationToken ct = default)
        {
            await base.ExecuteAsync(ctx, ct);

            var firstPass = new TypeDiscoverer();
            var proj = ctx.SourceProject;
            if (proj is null)
            {
                return;
            }

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

            var rewriter = new Rewriter(firstPass.FoundCOMTypes);
            int index = 0;
            int count = proj?.DocumentIds.Count ?? 0;
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

            index = 0;
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
                    .Where(m => m.Expression is PrefixUnaryExpressionSyntax pues && pues.IsKind(SyntaxKind.PointerMemberAccessExpression));

                if (memberAccesses.Count() == 0)
                {
                    continue;
                }

                var semanticModel = await doc.GetSemanticModelAsync();

                foreach (var memberAccess in memberAccesses)
                {
                    var pointerIndirection = (PrefixUnaryExpressionSyntax)memberAccess.Expression;
                    var typeInfo = semanticModel.GetTypeInfo(pointerIndirection.Operand);
                    // Check if the type is a ComType
                    if (typeInfo.Type != null && firstPass.FoundCOMTypes.Any(type => type.Item1 == typeInfo.Type.ToDisplayString()))
                    {
                        var newMemberAccess = SyntaxFactory.MemberAccessExpression(SyntaxKind.SimpleMemberAccessExpression, pointerIndirection.Operand, memberAccess.Name);
                        editor.ReplaceNode(memberAccess, newMemberAccess);
                    }
                }

                proj = doc.Project;

                logger.LogInformation("COM Object Usage Update for {0} Complete ({1}/{2})", doc.Name, index, count);
            }

            ctx.SourceProject = proj;
        }

        class TypeDiscoverer : CSharpSyntaxWalker
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
                if (bases.Types.Any(baseType => baseType.Type.ToString() == "IUnknown.Interface" || FoundCOMTypes.Any(val => val.Item1 == $"{baseType.Type}")))
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
        }
    }
}
