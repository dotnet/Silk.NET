// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis;
using static Microsoft.CodeAnalysis.CSharp.SyntaxFactory;
using Microsoft.CodeAnalysis.Editing;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System.Reflection;
using Silk.NET.SilkTouch.Utility;
using Silk.NET.SilkTouch.Sources;
using Microsoft.CodeAnalysis.Differencing;
using System.Diagnostics;
using System.CommandLine;
using ClangSharp;
using ClangSharp.Interop;

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
            /// The base type names and their full namespace definition to consider the base of the com tree
            /// Usually this is (IUnknown.Interface, Silk.NET.Windows.IUnknown.Interface)
            /// </summary>
            public Dictionary<string, string>? BaseTypes { get; init; }

            /// <summary>
            /// Additional Com Types which are not in this job but referenced by it
            /// No cast statements will be generated for these types
            /// </summary>
            public string[]? AdditionalCOMTypes { get; init; }
        }

        /// <inheritdoc />
        public override async Task ExecuteAsync(IModContext ctx, CancellationToken ct = default)
        {
            await base.ExecuteAsync(ctx, ct);

            // Read the configuration.
            var cfg = config.Get(ctx.JobKey);
            var proj = ctx.SourceProject;

            if (proj is null)
            {
                return;
            }

            Stopwatch timer = new Stopwatch();
            TimeSpan[] times = new TimeSpan[4];
            timer.Start();

            var firstPass = new TypeDiscoverer(cfg.BaseTypes ?? new() { { "IUnknown.Interface", "Silk.NET.Windows.IUnknown.Interface" } }, logger);

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

            //Cleanup our lists
            firstPass.FoundCOMTypes = firstPass.FoundCOMTypes.Where(val => val.Value.Item1).ToDictionary();
            firstPass.SupportedOSTypes = firstPass.SupportedOSTypes.Where(val => firstPass.FoundCOMTypes.ContainsKey(val)).ToList();

            foreach (string comType in cfg.AdditionalCOMTypes ?? [])
            {
                firstPass.FoundCOMTypes.Add(comType, (true, null));
            }

            timer.Stop();
            times[0] = timer.Elapsed;
            timer.Restart();

            int index = 0;

            logger.LogInformation("Starting Project Compilation");
            var compilation = await proj!.GetCompilationAsync();
            if (compilation is null)
            {
                logger.LogWarning("project was unable to compile, some usages may not be properly updated");
            }

            timer.Stop();
            times[1] = timer.Elapsed;
            timer.Restart();

            logger.LogInformation("Starting COM Object Usage Update");
            UsageUpdater updater = new(firstPass.FoundCOMTypes);
            foreach (var docId in proj?.DocumentIds ?? [])
            {
                index++;
                var doc =
                    proj?.GetDocument(docId) ?? throw new InvalidOperationException("Document missing");
                if (await doc.GetSyntaxRootAsync(ct) is not { } root)
                {
                    continue;
                }

                var syntaxTree = await doc.GetSyntaxTreeAsync();
                if (syntaxTree is null)
                {
                    logger.LogWarning("unable to retrieve Semantic Model for {}", doc.Name);
                    continue;
                }
                updater.SemanticModel = compilation is not null ? compilation.GetSemanticModel(syntaxTree!) : await doc.GetSemanticModelAsync();

                doc = doc.WithSyntaxRoot(updater.Visit(root).NormalizeWhitespace());

                proj = doc.Project;

                logger.LogInformation("COM Object Usage Update for {0} Complete ({1}/{2})", doc.Name, index, count);
            }

            timer.Stop();
            times[2] = timer.Elapsed;
            timer.Restart();

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

            timer.Stop();
            times[3] = timer.Elapsed;

            logger.LogInformation("TransformCOM Phase Timings");
            logger.LogInformation("--------------------------");
            logger.LogInformation("COM Object Collection : {}s ({})", times[0].TotalSeconds, times[0].ToString());
            logger.LogInformation("Project Compilation   : {}s ({})", times[1].TotalSeconds, times[1].ToString());
            logger.LogInformation("COM Usage Updates     : {}s ({})", times[2].TotalSeconds, times[2].ToString());
            logger.LogInformation("COM Object Rewrite    : {}s ({})", times[3].TotalSeconds, times[3].ToString());
            logger.LogInformation("--------------------------");

            ctx.SourceProject = proj;
        }

        class TypeDiscoverer : CSharpSyntaxWalker
        {
            private Dictionary<string, List<(string, bool)>> _interfaceParenting = new Dictionary<string, List<(string, bool)>>();

            /// <summary>
            /// The list of known COM interface types
            /// (name of type, is it a struct?, InheritanceTree)
            /// </summary>
            public Dictionary<string, (bool, KeyedStringTree?)> FoundCOMTypes = [];

            public List<string> SupportedOSTypes = [];

            private readonly Dictionary<string, string> _baseTypes;
            private ILogger<TransformCOM> _logger;

            private List<string> _Namespace = [];

            public TypeDiscoverer(Dictionary<string, string> BaseTypes, ILogger<TransformCOM> logger)
            {
                _logger = logger;
                _baseTypes = BaseTypes;
                InheritanceTrees = new KeyedStringTree[_baseTypes.Count];

                int i = 0;
                foreach (var baseType in BaseTypes)
                {
                    InheritanceTrees[i] = new(baseType.Key, baseType.Value);
                    i++;
                }
            }

            public KeyedStringTree[] InheritanceTrees;

            public override void VisitNamespaceDeclaration(NamespaceDeclarationSyntax node)
            {
                _Namespace.Add(node.Name.ToString());
                base.VisitNamespaceDeclaration(node);
                _Namespace.RemoveAt(_Namespace.Count - 1);
            }

            public override void VisitFileScopedNamespaceDeclaration(FileScopedNamespaceDeclarationSyntax node)
            {
                _Namespace.Add(node.Name.ToString());
                base.VisitFileScopedNamespaceDeclaration(node);
                _Namespace.RemoveAt(_Namespace.Count - 1);
            }

            public override void VisitStructDeclaration(StructDeclarationSyntax node)
            {
                base.VisitStructDeclaration(node);

                var bases = node.BaseList;

                var fields = node.DescendantNodes().OfType<FieldDeclarationSyntax>();

                if (bases is null ||
                    fields
                        .Any(fds => !fds.Modifiers.Contains(Token(SyntaxKind.StaticKeyword)) &&
                                    fds.Declaration.Variables.Count > 1 &&
                                    fds.Declaration.Type.ToString() != "void**" &&
                                    !fds.Declaration.Type.ToString().StartsWith("delegate") &&
                                    fds.Declaration.Variables[0].Identifier.Text != "lpVtbl"))
                {
                    return;
                }

                var className = $"{node.Identifier}";

                if (node.AttributeLists.Any(attrList => attrList.Attributes.Any(attr => attr.Name.ToString() == "SupportedOSPlatform")))
                {
                    SupportedOSTypes.Add(className);
                }

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
                    {
                        name = $"{parent.Identifier}.{name}";

                        if (parent.AttributeLists.Any(attrList => attrList.Attributes.Any(attr => attr.Name.ToString() == "SupportedOSPlatform")))
                        {
                            SupportedOSTypes.Add(name);
                        }
                    }
                    else
                    {
                        if (node.AttributeLists.Any(attrList => attrList.Attributes.Any(attr => attr.Name.ToString() == "SupportedOSPlatform")))
                        {
                            SupportedOSTypes.Add(name);
                        }
                    }
                }

                CheckBases((name, false), bases);
            }

            private void CheckBases((string, bool) className, BaseListSyntax bases)
            {
                foreach (BaseTypeSyntax baseType in bases.Types)
                {
                    string type = baseType.Type.ToString();
                    bool found = false;

                    int i = 0;
                    foreach (var BaseType in _baseTypes)
                    {
                        if (BaseType.Key == type)
                        {
                            COMTypeValidated(className.Item1, (className.Item2, InheritanceTrees[i]), BaseType.Key);
                            found = true;
                            break;
                        }
                    }

                    if (found)
                        break;

                    foreach (var val in FoundCOMTypes)
                    {
                        if (val.Key == type)
                        {
                            COMTypeValidated(className.Item1, (className.Item2, val.Value.Item2), val.Key);
                            break;
                        }
                    }
                }

                foreach (BaseTypeSyntax baseType in bases.Types)
                {
                    string fullName = $"{baseType.Type}";
                    if (!_interfaceParenting.ContainsKey(fullName))
                        _interfaceParenting.Add(fullName, new());

                    _interfaceParenting[fullName].Add(className);
                }
            }

            private void COMTypeValidated(string typeName, (bool, KeyedStringTree?) value, string parentName)
            {
                if (FoundCOMTypes.ContainsKey(typeName))
                {
                    return;
                }

                FoundCOMTypes.Add(typeName, value);

                if (!value.Item2?.TryAddNode(parentName, typeName, $"{string.Join('.',_Namespace)}.{typeName}") ?? true)
                {
                    _logger.LogWarning("Failed to add {} to its Inheritence tree, casts will not generate properly", typeName);
                }

                if (!_interfaceParenting.TryGetValue(typeName, out List<(string, bool)>? children))
                    return;

                foreach ((string, bool) childName in children)
                {
                    COMTypeValidated(childName.Item1, (childName.Item2, value.Item2), typeName);
                }
            }
        }

        class UsageUpdater(
            Dictionary<string, (bool, KeyedStringTree?)> ComTypes)
            : CSharpSyntaxRewriter
        {
            public SemanticModel? SemanticModel;
            List<MemberDeclarationSyntax> _newMethods = [];
            public override SyntaxNode? VisitMemberAccessExpression(MemberAccessExpressionSyntax node)
            {
                if (!node.IsKind(SyntaxKind.PointerMemberAccessExpression))
                    return base.VisitMemberAccessExpression(node);

                var typeInfo = SemanticModel.GetTypeInfo(node.Expression);
                if (typeInfo.Type is null || GetPointerDepth(typeInfo.Type, out ITypeSymbol innerType) > 1)
                    return base.VisitMemberAccessExpression(node);
                var name = GetTypeName(innerType.ToString() ?? string.Empty);

                // Check if the type is a ComType
                if (typeInfo.Type != null && ComTypes.ContainsKey(name))
                {
                    return MemberAccessExpression(SyntaxKind.SimpleMemberAccessExpression, node.Expression, node.Name);
                }
                return base.VisitMemberAccessExpression(node);
            }

            public override SyntaxNode? VisitAssignmentExpression(AssignmentExpressionSyntax node)
            {
                if (!node.Right.IsKind(SyntaxKind.NullLiteralExpression))
                    return base.VisitAssignmentExpression(node);

                var typeInfo = SemanticModel.GetTypeInfo(node);
                if (typeInfo.Type is null || GetPointerDepth(typeInfo.Type, out ITypeSymbol innerType) > 1)
                    return base.VisitAssignmentExpression(node);

                var name = GetTypeName(innerType.ToString() ?? string.Empty);
                // Check if the type is a ComType
                if (typeInfo.Type != null && ComTypes.ContainsKey(name))
                {
                    return AssignmentExpression(node.Kind(), node.Left, LiteralExpression(SyntaxKind.DefaultExpression));
                }
                return base.VisitAssignmentExpression(node);
            }

            public override SyntaxNode? VisitInvocationExpression(InvocationExpressionSyntax node)
            {
                var symbolInfo = SemanticModel.GetSymbolInfo(node);
                ExpressionSyntax newInvocation = node;
                bool changed = false;
                string type = symbolInfo.Symbol?.GetType().ToString() ?? "";
                if (symbolInfo.Symbol is IMethodSymbol methodSymbol)
                {
                    var arguments = node.ArgumentList.Arguments;
                    for (int i = 0; i < arguments.Count; i++)
                    {
                        var argument = arguments[i];

                        // Get the corresponding parameter type
                        int pointerDepth = GetPointerDepth(methodSymbol.Parameters[i].Type, out ITypeSymbol parameterType);

                        if (pointerDepth > 1)
                            continue;

                        var name = GetTypeName(parameterType?.ToString() ?? string.Empty);

                        // Check if the argument is a null literal
                        if (argument.Expression.IsKind(SyntaxKind.NullLiteralExpression))
                        {
                            // Check if the parameter type is ComType
                            if (ComTypes.ContainsKey(name))
                            {
                                changed = true;
                                var newDefaultArg = Argument(LiteralExpression(SyntaxKind.DefaultLiteralExpression));
                                newInvocation = newInvocation.ReplaceNode(argument, newDefaultArg);
                            }
                        }
                    }
                }
                else if (symbolInfo.Symbol is IFunctionPointerTypeSymbol functionPointerSymbol)
                {
                    var arguments = node.ArgumentList.Arguments;
                    int pointerDepth = 0;
                    ITypeSymbol parameterType;
                    string? name;
                    int i;
                    TypeSyntax castType;
                    for (i = 0; i < arguments.Count; i++)
                    {
                        var argument = arguments[i];

                        // Get the corresponding parameter type
                        pointerDepth = GetPointerDepth(functionPointerSymbol.Signature.Parameters[i].Type, out parameterType);

                        if (pointerDepth > 1)
                        {
                            castType = PointerType(ParseTypeName("Ptr2D"));
                            for (pointerDepth--; pointerDepth > 0; pointerDepth--)
                            {
                                castType = PointerType(castType);
                            }

                            changed = true;
                            var newArg = Argument(CastExpression(castType, argument.Expression));
                            newInvocation = newInvocation.ReplaceNode(argument, newArg);

                            continue;
                        }

                        name = GetTypeName(parameterType?.ToString() ?? string.Empty);

                        // Check if the argument is a null literal
                        if (argument.Expression.IsKind(SyntaxKind.NullLiteralExpression))
                        {
                            // Check if the parameter type is ComType
                            if (ComTypes.ContainsKey(name))
                            {
                                changed = true;
                                var newDefaultArg = Argument(LiteralExpression(SyntaxKind.DefaultLiteralExpression));
                                newInvocation = newInvocation.ReplaceNode(argument, newDefaultArg);
                            }
                        }
                        else
                        {
                            if (ComTypes.ContainsKey(name))
                            {
                                changed = true;
                                var newArg = Argument(MemberAccessExpression(SyntaxKind.SimpleMemberAccessExpression, argument.Expression, IdentifierName("lpVtbl")));
                                newInvocation = newInvocation.ReplaceNode(argument, newArg);
                            }
                        }
                    }

                    pointerDepth = GetPointerDepth(functionPointerSymbol.Signature.ReturnType, out parameterType);
                    name = GetTypeName(parameterType?.ToString() ?? string.Empty);

                    castType = ParseTypeName(name);
                    for (pointerDepth--; pointerDepth > 0; pointerDepth--)
                    {
                        castType = PointerType(castType);
                    }

                    if (ComTypes.ContainsKey(name))
                    {
                        changed = true;
                        newInvocation = CastExpression(castType, newInvocation);
                    }

                }
                return changed ? newInvocation : base.VisitInvocationExpression(node);
            }

            public override SyntaxNode? VisitBinaryExpression(BinaryExpressionSyntax node)
            {
                if (!node.Left.IsKind(SyntaxKind.NullLiteralExpression) && !node.Right.IsKind(SyntaxKind.NullLiteralExpression))
                    return base.VisitBinaryExpression(node);

                var typeInfoR = SemanticModel.GetTypeInfo(node.Right);
                var typeInfoL = SemanticModel.GetTypeInfo(node.Left);

                ITypeSymbol? innerTypeR = null;
                ITypeSymbol? innerTypeL = null;
                int depthR = 0;
                int depthL = 0;

                if ((typeInfoR.Type is null || (depthR = GetPointerDepth(typeInfoR.Type, out innerTypeR)) > 1)&&
                    (typeInfoL.Type is null || (depthL = GetPointerDepth(typeInfoL.Type, out innerTypeL)) > 1))
                    return base.VisitBinaryExpression(node);

                var nameR = GetTypeName(innerTypeR?.ToString() ?? string.Empty);
                var nameL = GetTypeName(innerTypeL?.ToString() ?? string.Empty);

                if (node.Left.IsKind(SyntaxKind.NullLiteralExpression))
                {
                    // Check if the type is a ComType
                    if (depthR <= 1 && typeInfoR.Type != null && ComTypes.ContainsKey(nameR))
                    {
                        return BinaryExpression(node.Kind(), node.Left, IdentifierName($"{node.Right.ToFullString()}.lpVtbl"));
                    }
                }
                else
                {
                    // Check if the type is a ComType
                    if (depthL <= 1 && typeInfoL.Type != null && ComTypes.ContainsKey(nameL))
                    {
                        return BinaryExpression(node.Kind(), IdentifierName($"{node.Left.ToFullString()}.lpVtbl"), node.Right);
                    }
                }

                return base.VisitBinaryExpression(node);
            }

            public override SyntaxNode? VisitVariableDeclaration(VariableDeclarationSyntax node)
            {
                if (!node.Variables.Any(var => var.Initializer is not null && var.Initializer.Value is LiteralExpressionSyntax lit && lit.IsKind(SyntaxKind.NullLiteralExpression)))
                    return base.VisitVariableDeclaration(node);

                // Get the corresponding parameter type
                var variableType = node.Type;
                if (variableType is null || GetPointerDepth(variableType, out var innerType) > 1)
                    return base.VisitVariableDeclaration(node);
                var name = GetTypeName(innerType.ToString() ?? string.Empty);

                // Check if the parameter type is ComType
                if (!ComTypes.ContainsKey(name))
                {
                    return base.VisitVariableDeclaration(node);
                }

                var newInstantiation = node;
                var variables = node.Variables;
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
                return newInstantiation;
            }

            public override SyntaxNode? VisitMethodDeclaration(MethodDeclarationSyntax node)
            {
                var orig = node;
                if (node.Modifiers.Any(token => token.IsKind(SyntaxKind.ExternKeyword)))
                {
                    var pointerDepth = GetPointerDepth(node.ReturnType, out var innerType);
                    var name = innerType.ToString();
                    var shouldEditReturnType = ComTypes.ContainsKey(name);
                    if (shouldEditReturnType || node.ParameterList.Parameters.Any(param => {
                        if (param.Type is null)
                            return false;
                        pointerDepth = GetPointerDepth(param.Type, out var innerType);
                        name = innerType.ToString();
                        return ComTypes.ContainsKey(name);
                    }))
                    {
                        var returnType = shouldEditReturnType ? PointerType(ParseTypeName("Ptr2D")) : orig.ReturnType;
                        if (shouldEditReturnType)
                        {
                            pointerDepth = GetPointerDepth(node.ReturnType, out _);
                            
                            for (pointerDepth--; pointerDepth > 0; pointerDepth--)
                            {
                                returnType = PointerType(returnType);
                            }
                        }

                        node = node.WithIdentifier(Identifier($"_{node.Identifier}")).
                            WithReturnType(returnType).
                            WithModifiers(TokenList(node.Modifiers.Where(modifier => !modifier.IsKind(SyntaxKind.PublicKeyword)))).
                            AddModifiers(Token(SyntaxKind.PrivateKeyword).WithLeadingTrivia());

                        var InvocationExp = InvocationExpression(
                                            IdentifierName(node.Identifier.Text),
                                            ArgumentList(
                                                SeparatedList(node.ParameterList.Parameters.Select(param => Argument(IdentifierName(param.Identifier.Text))))));

                        _newMethods.Add(MethodDeclaration(orig.ReturnType, orig.Identifier).
                            WithParameterList(orig.ParameterList).
                            WithModifiers(
                                TokenList(orig.Modifiers.Where(modifier => !modifier.IsKind(SyntaxKind.ExternKeyword)))).
                            WithExpressionBody(
                                ArrowExpressionClause( shouldEditReturnType ? 
                                    CastExpression(orig.ReturnType, InvocationExp ) : InvocationExp)).
                            WithSemicolonToken(
                                Token(SyntaxKind.SemicolonToken)));
                    }
                }

                return base.VisitMethodDeclaration(node);
            }

            public override SyntaxNode? VisitPropertyDeclaration(PropertyDeclarationSyntax node)
            {
                if (node.Type is FunctionPointerTypeSyntax funcPtrType && node.ExpressionBody is not null &&
                    node.ExpressionBody.Expression is PrefixUnaryExpressionSyntax pues &&
                    funcPtrType.ParameterList.Parameters.Any(param => {
                        var pointerDepth = GetPointerDepth(param.Type, out var innerType);
                        var name = innerType.ToString();
                        return ComTypes.ContainsKey(name);
                    }))
                {
                    node = node.WithExpressionBody(
                            ArrowExpressionClause(
                                PrefixUnaryExpression(SyntaxKind.AddressOfExpression, IdentifierName($"_{pues.Operand.ToString()}"))));
                }
                return base.VisitPropertyDeclaration(node);
            }

            public override SyntaxNode? VisitStructDeclaration(StructDeclarationSyntax node) => MethodAddDeclaration(() => base.VisitStructDeclaration(node));

            public override SyntaxNode? VisitClassDeclaration(ClassDeclarationSyntax node) => MethodAddDeclaration(() => base.VisitClassDeclaration(node));

            private SyntaxNode? MethodAddDeclaration(Func<SyntaxNode?> typeVisit)
            {
                var parentNewMehods = _newMethods;
                _newMethods = _newMethods.Count > 0 ? [] : _newMethods;
                var newNode = typeVisit();

                if (newNode is not TypeDeclarationSyntax typeNode)
                    return newNode;
                if (_newMethods.Count > 0)
                    typeNode = typeNode.AddMembers(_newMethods.ToArray());
                _newMethods.Clear();
                _newMethods = parentNewMehods;

                return typeNode;
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

        class Rewriter(Dictionary<string, (bool, KeyedStringTree?)> ComTypes)
            : CSharpSyntaxRewriter
        {
            bool isInComType = false;
            public override SyntaxNode? VisitPointerType(PointerTypeSyntax node)
            {
                var name = node.ElementType.ToString();
                return ComTypes.TryGetValue(name, out _) ? IdentifierName(name) : base.VisitPointerType(node);
            }

            public override SyntaxNode? VisitIdentifierName(IdentifierNameSyntax node)
            {
                if (isInComType && node.Identifier.ToString() == "lpVtbl" && node.Parent is not MemberAccessExpressionSyntax)
                {
                    return ParenthesizedExpression(PrefixUnaryExpression(SyntaxKind.PointerIndirectionExpression, node));
                }

                return base.VisitIdentifierName(node);
            }

            public override SyntaxNode? VisitVariableDeclaration(VariableDeclarationSyntax node)
            {
                if (isInComType && node.Type.ToString() == "void**" && node.Variables.First().Identifier.ToString() == "lpVtbl")
                {
                    return VariableDeclaration((PointerType(IdentifierName("Ptr2D"))))
                        .AddVariables(VariableDeclarator("lpVtbl"));
                }

                return base.VisitVariableDeclaration(node);
            }

            //public override SyntaxNode? VisitInterfaceDeclaration(InterfaceDeclarationSyntax node)
            //{
            //    var ret = base.VisitInterfaceDeclaration(node);

            //    if (ret is InterfaceDeclarationSyntax inter && inter.BaseList is not null && inter.BaseList.Types.Any(baseType => baseType.Type.ToString().EndsWith(".Interface")))
            //    {
            //        List<BaseTypeSyntax> baseTypes = [];
            //        foreach (BaseTypeSyntax baseType in inter.BaseList.Types)
            //        {
            //            if (ComTypes.Any(com => $"{com.Key}.Interface" == baseType.Type.ToString()))
            //            {
            //                baseTypes.Add(SimpleBaseType(IdentifierName(baseType.Type.ToString())));
            //            }
            //            else
            //            {
            //                baseTypes.Add(baseType);
            //            }
            //        }

            //        ret = inter.WithBaseList(BaseList(SeparatedList(baseTypes)));
            //    }

            //    return ret;
            //}

            public override SyntaxNode? VisitCastExpression(CastExpressionSyntax node)
            {
                int depth = GetPointerDepth(node.Type, out var innerType);
                var castType = innerType.ToString();

                var expression = node.Expression.ToString();

                if (node.Type is not PointerTypeSyntax || expression != "Unsafe.AsPointer(ref this)" ||
                    !ComTypes.ContainsKey(castType))
                {
                    return base.VisitCastExpression(node);
                }

                return node.Parent is MemberAccessExpressionSyntax ? ThisExpression() :
                            MemberAccessExpression(SyntaxKind.SimpleMemberAccessExpression, ThisExpression(), IdentifierName("lpVtbl"));
            }

            public override SyntaxNode? VisitParameter(ParameterSyntax node)
            {
                var visited = base.VisitParameter(node);
                var visitedParameter = visited as ParameterSyntax;
                if (visitedParameter is null || visitedParameter.Default is null || visitedParameter.Type is null ||
                    !visitedParameter.Default.Value.IsKind(SyntaxKind.NullLiteralExpression) ||
                    !ComTypes.ContainsKey(visitedParameter.Type?.ToString() ?? string.Empty))
                {
                    return visited;
                }

                return Parameter(visitedParameter.AttributeLists, visitedParameter.Modifiers, visitedParameter.Type, visitedParameter.Identifier, EqualsValueClause(LiteralExpression(SyntaxKind.DefaultLiteralExpression)));
            }

            public override SyntaxNode? VisitFunctionPointerType(FunctionPointerTypeSyntax node)
            {
                var parameters = node.ParameterList.Parameters;
                var newParamType = PointerType(IdentifierName("Ptr2D"));
                List<FunctionPointerParameterSyntax> newParams = [];
                for (var j = 0; j < parameters.Count; j++)
                {
                    var param = parameters[j];
                    int depth = GetPointerDepth(param.Type, out var innerType);
                    var type = innerType.ToString();
                    if (param.Type is not PointerTypeSyntax ||
                        !ComTypes.ContainsKey(type))
                    {
                        newParams.Add(param);
                        continue;
                    }

                    var paramType = newParamType;
                    for (depth--; depth > 0; depth--)
                    {
                        paramType = PointerType(paramType);
                    }

                    newParams.Add(FunctionPointerParameter(paramType));
                }
                node = node.ReplaceNode(node.ParameterList, FunctionPointerParameterList(SeparatedList(newParams)));
                return base.VisitFunctionPointerType(node);
            }

            public override SyntaxNode? VisitStructDeclaration(StructDeclarationSyntax node)
            {
                string name = node.Identifier.ToString();

                if (ComTypes.TryGetValue(name, out var Value) && Value.Item2 is not null && Value.Item2.FindNode(name, out KeyedStringTree.Node? treeNode) && treeNode.Parent is not null)
                {
                    isInComType = true;
                    //visit and modify ComType Variables and internal usages first
                    node = (base.VisitStructDeclaration(node) as StructDeclarationSyntax)!;

                    //Correct to the .Interface version which will always be our parent
                    treeNode = treeNode.Parent;

                    //Add vtbl constructor to ComType
                    node = node.AddMembers(
                                        ConstructorDeclaration(name).
                                           WithModifiers(
                                            TokenList(
                                                Token(SyntaxKind.PublicKeyword))).
                                           WithParameterList(
                                            ParameterList(
                                                SingletonSeparatedList(
                                                    Parameter(
                                                        Identifier("vtbl")).
                                                    WithType(
                                                        PointerType(ParseTypeName("Ptr2D")))))).
                                           WithExpressionBody(
                                            ArrowExpressionClause(
                                                AssignmentExpression(
                                                    SyntaxKind.SimpleAssignmentExpression,
                                                    IdentifierName("lpVtbl"),
                                                    IdentifierName("vtbl")))).
                                           WithSemicolonToken(
                                            Token(SyntaxKind.SemicolonToken)).
                                           WithLeadingTrivia(
                                            TriviaList(
                                                Trivia(
                                                    DocumentationCommentTrivia(
                                                        SyntaxKind.SingleLineDocumentationCommentTrivia)
                                                    .WithContent(
                                                        List(
                                                            new XmlNodeSyntax[]
                                                            {
                                                                    XmlText().WithTextTokens(
                                                                        TokenList(
                                                                            XmlTextLiteral(
                                                                                TriviaList(DocumentationCommentExterior("/// ")), " ", " ", TriviaList()))),
                                                                    XmlElement(
                                                                        XmlElementStartTag(
                                                                            XmlName("summary")),
                                                                        List(new XmlNodeSyntax[]
                                                                        {
                                                                            XmlText("Initializes a new instance of the "),
                                                                            XmlEmptyElement(XmlName("see"),  List<XmlAttributeSyntax>(new [] { XmlCrefAttribute(NameMemberCref(IdentifierName(name))) })),
                                                                            XmlText(" struct with the specified virtual table pointer.")
                                                                        }),
                                                                        XmlElementEndTag(
                                                                            XmlName("summary"))),
                                                                    XmlText().WithTextTokens(
                                                                        TokenList(
                                                                            XmlTextNewLine(TriviaList(), "\n", "\n", TriviaList()))),
                                                                    XmlText().WithTextTokens(
                                                                        TokenList(
                                                                            XmlTextLiteral(
                                                                                TriviaList(DocumentationCommentExterior("/// ")), " ", " ", TriviaList()))),
                                                                    XmlElement(
                                                                        XmlElementStartTag(
                                                                            XmlName("param")).WithAttributes(
                                                                                SingletonList<XmlAttributeSyntax>(
                                                                                    XmlNameAttribute(
                                                                                        XmlName("name"),
                                                                                        Token(SyntaxKind.DoubleQuoteToken),
                                                                                        IdentifierName("vtbl"),
                                                                                        Token(SyntaxKind.DoubleQuoteToken)))),
                                                                        SingletonList<XmlNodeSyntax>(
                                                                            XmlText("The pointer to virtual table.")),
                                                                        XmlElementEndTag(
                                                                            XmlName("param"))),
                                                                    XmlText().WithTextTokens(
                                                                        TokenList(
                                                                            XmlTextNewLine(TriviaList(), "\n", "\n", TriviaList())))
                                                            }))))));
                    //add Ptr2D* casts
                    node = node.AddMembers(
                        ConversionOperatorDeclaration(Token(SyntaxKind.ExplicitKeyword),
                            ParseTypeName(name)).
                        WithModifiers(
                            TokenList(
                                Token(SyntaxKind.PublicKeyword),
                                Token(SyntaxKind.StaticKeyword))).
                        WithParameterList(
                            ParameterList(
                                SingletonSeparatedList(
                                    Parameter(Identifier("value")).
                                    WithType(PointerType(ParseTypeName("Ptr2D")))))).
                        WithExpressionBody(
                            ArrowExpressionClause(
                                        ObjectCreationExpression(
                                            IdentifierName(name)).
                                        WithArgumentList(
                                            ArgumentList(
                                                SingletonSeparatedList(
                                                    Argument(
                                                        IdentifierName("value"))))))).
                        WithSemicolonToken(
                            Token(SyntaxKind.SemicolonToken)).
                        WithLeadingTrivia(
                            TriviaList(
                                Trivia(
                                    DocumentationCommentTrivia(
                                        SyntaxKind.SingleLineDocumentationCommentTrivia)
                                    .WithContent(
                                        List(
                                            new XmlNodeSyntax[]
                                            {
                                                    XmlText().WithTextTokens(
                                                        TokenList(
                                                            XmlTextLiteral(
                                                                TriviaList(DocumentationCommentExterior("/// ")), " ", " ", TriviaList()))),
                                                    XmlElement(
                                                        XmlElementStartTag(
                                                            XmlName("summary")),
                                                        List(new XmlNodeSyntax[]
                                                        {
                                                            XmlText("casts "),
                                                            XmlEmptyElement(XmlName("see"),  List<XmlAttributeSyntax>(new [] { XmlCrefAttribute(NameMemberCref(ParseTypeName("Ptr2D"))) })),
                                                            XmlText(" to "),
                                                            XmlEmptyElement(XmlName("see"), List<XmlAttributeSyntax>(new [] { XmlCrefAttribute(NameMemberCref(IdentifierName(name))) })),
                                                            XmlText(".")
                                                        }),
                                                        XmlElementEndTag(
                                                            XmlName("summary"))),
                                                    XmlText().WithTextTokens(
                                                        TokenList(
                                                            XmlTextNewLine(TriviaList(), "\n", "\n", TriviaList()))),
                                                    XmlText().WithTextTokens(
                                                        TokenList(
                                                            XmlTextLiteral(
                                                                TriviaList(DocumentationCommentExterior("/// ")), " ", " ", TriviaList()))),
                                                    XmlElement(
                                                        XmlElementStartTag(
                                                            XmlName("param")).WithAttributes(
                                                                SingletonList<XmlAttributeSyntax>(
                                                                    XmlNameAttribute(
                                                                        XmlName("name"),
                                                                        Token(SyntaxKind.DoubleQuoteToken),
                                                                        IdentifierName("value"),
                                                                        Token(SyntaxKind.DoubleQuoteToken)))),
                                                        List(new XmlNodeSyntax[]
                                                        {
                                                            XmlText("The "),
                                                            XmlEmptyElement(XmlName("see"),  List<XmlAttributeSyntax>(new [] { XmlCrefAttribute(NameMemberCref(ParseTypeName("Ptr2D"))) })),
                                                            XmlText(" instance to be converted ")
                                                        }),
                                                        XmlElementEndTag(
                                                            XmlName("param"))),
                                                    XmlText().WithTextTokens(
                                                        TokenList(
                                                            XmlTextNewLine(TriviaList(), "\n", "\n", TriviaList())))
                                            }))))),
                        ConversionOperatorDeclaration(Token(SyntaxKind.ImplicitKeyword),
                            PointerType(ParseTypeName("Ptr2D"))).
                        WithModifiers(
                            TokenList(
                                Token(SyntaxKind.PublicKeyword),
                                Token(SyntaxKind.StaticKeyword))).
                        WithParameterList(
                            ParameterList(
                                SingletonSeparatedList(
                                    Parameter(Identifier("value")).
                                    WithType(IdentifierName(name))))).
                        WithExpressionBody(
                            ArrowExpressionClause(
                                MemberAccessExpression(SyntaxKind.SimpleMemberAccessExpression, IdentifierName("value"), IdentifierName("lpVtbl")))).
                        WithSemicolonToken(
                            Token(SyntaxKind.SemicolonToken)).
                        WithLeadingTrivia(
                            TriviaList(
                                Trivia(
                                    DocumentationCommentTrivia(
                                        SyntaxKind.SingleLineDocumentationCommentTrivia)
                                    .WithContent(
                                        List(
                                            new XmlNodeSyntax[]
                                            {
                                                    XmlText().WithTextTokens(
                                                        TokenList(
                                                            XmlTextLiteral(
                                                                TriviaList(DocumentationCommentExterior("/// ")), " ", " ", TriviaList()))),
                                                    XmlElement(
                                                        XmlElementStartTag(
                                                            XmlName("summary")),
                                                        List(new XmlNodeSyntax[]
                                                        {
                                                            XmlText("casts "),
                                                            XmlEmptyElement(XmlName("see"),  List<XmlAttributeSyntax>(new [] { XmlCrefAttribute(NameMemberCref(IdentifierName(name))) })),
                                                            XmlText(" to "),
                                                            XmlEmptyElement(XmlName("see"), List<XmlAttributeSyntax>(new [] { XmlCrefAttribute(NameMemberCref(ParseTypeName("Ptr2D"))) })),
                                                            XmlText(" pointer.")
                                                        }),
                                                        XmlElementEndTag(
                                                            XmlName("summary"))),
                                                    XmlText().WithTextTokens(
                                                        TokenList(
                                                            XmlTextNewLine(TriviaList(), "\n", "\n", TriviaList()))),
                                                    XmlText().WithTextTokens(
                                                        TokenList(
                                                            XmlTextLiteral(
                                                                TriviaList(DocumentationCommentExterior("/// ")), " ", " ", TriviaList()))),
                                                    XmlElement(
                                                        XmlElementStartTag(
                                                            XmlName("param")).WithAttributes(
                                                                SingletonList<XmlAttributeSyntax>(
                                                                    XmlNameAttribute(
                                                                        XmlName("name"),
                                                                        Token(SyntaxKind.DoubleQuoteToken),
                                                                        IdentifierName("value"),
                                                                        Token(SyntaxKind.DoubleQuoteToken)))),
                                                        List(new XmlNodeSyntax[]
                                                        {
                                                            XmlText("The "),
                                                            XmlEmptyElement(XmlName("see"),  List<XmlAttributeSyntax>(new [] { XmlCrefAttribute(NameMemberCref(IdentifierName(name))) })),
                                                            XmlText(" instance to be converted ")
                                                        }),
                                                        XmlElementEndTag(
                                                            XmlName("param"))),
                                                    XmlText().WithTextTokens(
                                                        TokenList(
                                                            XmlTextNewLine(TriviaList(), "\n", "\n", TriviaList())))
                                            }))))));
                    //Add void*** conversion
                    node = node.AddMembers(
                    ConversionOperatorDeclaration(Token(SyntaxKind.ExplicitKeyword),
                            ParseTypeName(name)).
                        WithModifiers(
                            TokenList(
                                Token(SyntaxKind.PublicKeyword),
                                Token(SyntaxKind.StaticKeyword))).
                        WithParameterList(
                            ParameterList(
                                SingletonSeparatedList(
                                    Parameter(Identifier("value")).
                                    WithType(PointerType(PointerType(PointerType(ParseTypeName("void")))))))).
                        WithExpressionBody(
                            ArrowExpressionClause(
                                        ObjectCreationExpression(
                                            IdentifierName(name)).
                                        WithArgumentList(
                                            ArgumentList(
                                                SingletonSeparatedList(
                                                    Argument(
                                                        CastExpression(
                                                            PointerType(ParseTypeName("Ptr2D")),
                                                            IdentifierName("value")))))))).
                        WithSemicolonToken(
                            Token(SyntaxKind.SemicolonToken)).
                        WithLeadingTrivia(
                            TriviaList(
                                Trivia(
                                    DocumentationCommentTrivia(
                                        SyntaxKind.SingleLineDocumentationCommentTrivia)
                                    .WithContent(
                                        List(
                                            new XmlNodeSyntax[]
                                            {
                                                    XmlText().WithTextTokens(
                                                        TokenList(
                                                            XmlTextLiteral(
                                                                TriviaList(DocumentationCommentExterior("/// ")), " ", " ", TriviaList()))),
                                                    XmlElement(
                                                        XmlElementStartTag(
                                                            XmlName("summary")),
                                                        List(new XmlNodeSyntax[]
                                                        {
                                                            XmlText("casts void*** pointer to "),
                                                            XmlEmptyElement(XmlName("see"), List<XmlAttributeSyntax>(new [] { XmlCrefAttribute(NameMemberCref(IdentifierName(name))) })),
                                                            XmlText(".")
                                                        }),
                                                        XmlElementEndTag(
                                                            XmlName("summary"))),
                                                    XmlText().WithTextTokens(
                                                        TokenList(
                                                            XmlTextNewLine(TriviaList(), "\n", "\n", TriviaList()))),
                                                    XmlText().WithTextTokens(
                                                        TokenList(
                                                            XmlTextLiteral(
                                                                TriviaList(DocumentationCommentExterior("/// ")), " ", " ", TriviaList()))),
                                                    XmlElement(
                                                        XmlElementStartTag(
                                                            XmlName("param")).WithAttributes(
                                                                SingletonList<XmlAttributeSyntax>(
                                                                    XmlNameAttribute(
                                                                        XmlName("name"),
                                                                        Token(SyntaxKind.DoubleQuoteToken),
                                                                        IdentifierName("value"),
                                                                        Token(SyntaxKind.DoubleQuoteToken)))),
                                                        List(new XmlNodeSyntax[]
                                                        {
                                                            XmlText("The void*** instance to be converted")
                                                        }),
                                                        XmlElementEndTag(
                                                            XmlName("param"))),
                                                    XmlText().WithTextTokens(
                                                        TokenList(
                                                            XmlTextNewLine(TriviaList(), "\n", "\n", TriviaList())))
                                            }))))),
                        ConversionOperatorDeclaration(Token(SyntaxKind.ImplicitKeyword),
                            PointerType(PointerType(PointerType(ParseTypeName("void"))))).
                        WithModifiers(
                            TokenList(
                                Token(SyntaxKind.PublicKeyword),
                                Token(SyntaxKind.StaticKeyword))).
                        WithParameterList(
                            ParameterList(
                                SingletonSeparatedList(
                                    Parameter(Identifier("value")).
                                    WithType(IdentifierName(name))))).
                        WithExpressionBody(
                            ArrowExpressionClause(
                                CastExpression(
                                    PointerType(PointerType(PointerType(ParseTypeName("void")))),
                                    MemberAccessExpression(SyntaxKind.SimpleMemberAccessExpression, IdentifierName("value"), IdentifierName("lpVtbl"))))).
                        WithSemicolonToken(
                            Token(SyntaxKind.SemicolonToken)).
                        WithLeadingTrivia(
                            TriviaList(
                                Trivia(
                                    DocumentationCommentTrivia(
                                        SyntaxKind.SingleLineDocumentationCommentTrivia)
                                    .WithContent(
                                        List(
                                            new XmlNodeSyntax[]
                                            {
                                                    XmlText().WithTextTokens(
                                                        TokenList(
                                                            XmlTextLiteral(
                                                                TriviaList(DocumentationCommentExterior("/// ")), " ", " ", TriviaList()))),
                                                    XmlElement(
                                                        XmlElementStartTag(
                                                            XmlName("summary")),
                                                        List(new XmlNodeSyntax[]
                                                        {
                                                            XmlText("casts "),
                                                            XmlEmptyElement(XmlName("see"),  List<XmlAttributeSyntax>(new [] { XmlCrefAttribute(NameMemberCref(IdentifierName(name))) })),
                                                            XmlText(" to void*** pointer")
                                                        }),
                                                        XmlElementEndTag(
                                                            XmlName("summary"))),
                                                    XmlText().WithTextTokens(
                                                        TokenList(
                                                            XmlTextNewLine(TriviaList(), "\n", "\n", TriviaList()))),
                                                    XmlText().WithTextTokens(
                                                        TokenList(
                                                            XmlTextLiteral(
                                                                TriviaList(DocumentationCommentExterior("/// ")), " ", " ", TriviaList()))),
                                                    XmlElement(
                                                        XmlElementStartTag(
                                                            XmlName("param")).WithAttributes(
                                                                SingletonList<XmlAttributeSyntax>(
                                                                    XmlNameAttribute(
                                                                        XmlName("name"),
                                                                        Token(SyntaxKind.DoubleQuoteToken),
                                                                        IdentifierName("value"),
                                                                        Token(SyntaxKind.DoubleQuoteToken)))),
                                                        List(new XmlNodeSyntax[]
                                                        {
                                                            XmlText("The "),
                                                            XmlEmptyElement(XmlName("see"),  List<XmlAttributeSyntax>(new [] { XmlCrefAttribute(NameMemberCref(IdentifierName(name))) })),
                                                            XmlText(" instance to be converted ")
                                                        }),
                                                        XmlElementEndTag(
                                                            XmlName("param"))),
                                                    XmlText().WithTextTokens(
                                                        TokenList(
                                                            XmlTextNewLine(TriviaList(), "\n", "\n", TriviaList())))
                                            }))))));

                    if (treeNode.Parent is not null)
                    {
                        node = generateUpcasts(node, name, treeNode.Parent);
                    }

                    isInComType = false;
                    return node;
                }

                return base.VisitStructDeclaration(node);
            }

            private StructDeclarationSyntax generateUpcasts(StructDeclarationSyntax node, string className, KeyedStringTree.Node treeNode)
            {
                string castName = InterfaceNameToStructName(treeNode.Value);

                node = node.AddMembers(GenerateCastDefinition(className, castName, false));
                node = node.AddMembers(GenerateCastDefinition(castName, className));

                if (treeNode.Parent is not null)
                {
                    return generateUpcasts(node, className, treeNode.Parent);
                }

                return node;
            }

            private string InterfaceNameToStructName(string interfaceName) => interfaceName.EndsWith(".Interface") ? interfaceName.Remove(interfaceName.Length - 10) : interfaceName;

            private ConversionOperatorDeclarationSyntax GenerateCastDefinition(string className, string castName, bool implicitCast = true)
            {
                return ConversionOperatorDeclaration(Token(implicitCast ? SyntaxKind.ImplicitKeyword : SyntaxKind.ExplicitKeyword),
                            ParseTypeName(className)).
                        WithModifiers(
                            TokenList(
                                Token(SyntaxKind.PublicKeyword),
                                Token(SyntaxKind.StaticKeyword))).
                        WithParameterList(
                            ParameterList(
                                SingletonSeparatedList(
                                    Parameter(Identifier("value")).
                                    WithType(ParseTypeName(castName))))).
                        WithExpressionBody(
                            ArrowExpressionClause(
                                        ObjectCreationExpression(
                                            IdentifierName(className)).
                                        WithArgumentList(
                                            ArgumentList(
                                                SingletonSeparatedList(
                                                    Argument(
                                                        IdentifierName("value.lpVtbl"))))))).
                        WithSemicolonToken(
                            Token(SyntaxKind.SemicolonToken)).
                        WithLeadingTrivia(
                            TriviaList(
                                Trivia(
                                    DocumentationCommentTrivia(
                                        SyntaxKind.SingleLineDocumentationCommentTrivia)
                                    .WithContent(
                                        List(
                                            new XmlNodeSyntax[]
                                            {
                                                XmlText().WithTextTokens(
                                                    TokenList(
                                                        XmlTextLiteral(
                                                            TriviaList(DocumentationCommentExterior("/// ")), " ", " ", TriviaList()))),
                                                XmlElement(
                                                    XmlElementStartTag(
                                                        XmlName("summary")),
                                                    List(new XmlNodeSyntax[]
                                                    {
                                                        XmlText($"{(implicitCast ? "Up" : "Down")}casts "),
                                                        XmlEmptyElement(XmlName("see"),  List<XmlAttributeSyntax>(new [] { XmlCrefAttribute(NameMemberCref(IdentifierName(castName))) })),
                                                        XmlText(" to "),
                                                        XmlEmptyElement(XmlName("see"), List<XmlAttributeSyntax>(new [] { XmlCrefAttribute(NameMemberCref(IdentifierName(className))) })),
                                                        XmlText(".")
                                                    }),
                                                    XmlElementEndTag(
                                                        XmlName("summary"))),
                                                XmlText().WithTextTokens(
                                                    TokenList(
                                                        XmlTextNewLine(TriviaList(), "\n", "\n", TriviaList()))),
                                                XmlText().WithTextTokens(
                                                    TokenList(
                                                        XmlTextLiteral(
                                                            TriviaList(DocumentationCommentExterior("/// ")), " ", " ", TriviaList()))),
                                                XmlElement(
                                                    XmlElementStartTag(
                                                        XmlName("param")).WithAttributes(
                                                            SingletonList<XmlAttributeSyntax>(
                                                                XmlNameAttribute(
                                                                    XmlName("name"),
                                                                    Token(SyntaxKind.DoubleQuoteToken),
                                                                    IdentifierName("value"),
                                                                    Token(SyntaxKind.DoubleQuoteToken)))),
                                                    List(new XmlNodeSyntax[]
                                                    {
                                                        XmlText("The "),
                                                        XmlEmptyElement(XmlName("see"),  List<XmlAttributeSyntax>(new [] { XmlCrefAttribute(NameMemberCref(IdentifierName(castName))) })),
                                                        XmlText(" instance to be converted ")
                                                    }),
                                                    XmlElementEndTag(
                                                        XmlName("param"))),
                                                XmlText().WithTextTokens(
                                                    TokenList(
                                                        XmlTextNewLine(TriviaList(), "\n", "\n", TriviaList())))
                                            })))));
            }
        }

        private static int GetPointerDepth(TypeSyntax type, out TypeSyntax innerMost)
        {
            int depth = 0;
            innerMost = type;
            while (innerMost is PointerTypeSyntax pointerType)
            {
                depth++;
                innerMost = pointerType.ElementType;
            }
            return depth;
        }

        private static int GetPointerDepth(ITypeSymbol type, out ITypeSymbol innerMost)
        {
            int depth = 0;
            innerMost = type;
            while (innerMost is IPointerTypeSymbol pointerType)
            {
                depth++;
                innerMost = pointerType.PointedAtType;
            }
            return depth;
        }
    }
}
