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

            var firstPass = new TypeDiscoverer(cfg.BaseTypes ?? new() { { "IUnknown.Interface", "Silk.NET.Windows.IUnknown.Interface" } }, logger);
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

            //Cleanup our lists
            firstPass.FoundCOMTypes = firstPass.FoundCOMTypes.Where(val => val.Item2).ToList();
            firstPass.SupportedOSTypes = firstPass.SupportedOSTypes.Where(val => firstPass.FoundCOMTypes.Any(com => com.Item1 == val)).ToList();

            foreach (string comType in cfg.AdditionalCOMTypes ?? [])
            {
                firstPass.FoundCOMTypes.Add((comType, true, null));
            }

            int index = 0;

            var compilation = await proj!.GetCompilationAsync();
            if (compilation is null)
            {
                logger.LogWarning("project was unable to compile, some usages may not be properly updated");
            }

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

        class TypeDiscoverer : CSharpSyntaxWalker
        {
            private Dictionary<string, List<(string, bool)>> _interfaceParenting = new Dictionary<string, List<(string, bool)>>();

            /// <summary>
            /// The list of known COM interface types
            /// (name of type, is it a struct?)
            /// </summary>
            public List<(string, bool, KeyedStringTree?)> FoundCOMTypes = [];

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

                if (bases is null)
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
                            COMTypeValidated((className.Item1, className.Item2, InheritanceTrees[i]), BaseType.Key);
                            found = true;
                            break;
                        }
                    }

                    if (found)
                        break;

                    foreach ((string, bool, KeyedStringTree?) val in FoundCOMTypes)
                    {
                        if (val.Item1 == type)
                        {
                            COMTypeValidated((className.Item1, className.Item2, val.Item3), val.Item1);
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

            private void COMTypeValidated((string, bool, KeyedStringTree?) typeName, string parentName)
            {
                if (FoundCOMTypes.Contains(typeName))
                {
                    return;
                }

                FoundCOMTypes.Add(typeName);

                if (!typeName.Item3?.TryAddNode(parentName, typeName.Item1, $"{string.Join('.',_Namespace)}.{typeName.Item1}") ?? true)
                {
                    _logger.LogWarning("Failed to add {} to its Inheritence tree, casts will not generate properly", typeName.Item1);
                }

                if (!_interfaceParenting.TryGetValue(typeName.Item1, out List<(string, bool)>? children))
                    return;

                foreach ((string, bool) childName in children)
                {
                    COMTypeValidated((childName.Item1, childName.Item2, typeName.Item3), typeName.Item1);
                }
            }
        }

        class UsageUpdater(
            List<(string, bool, KeyedStringTree?)> ComTypes)
            : CSharpSyntaxRewriter
        {
            public SemanticModel? SemanticModel;
            public override SyntaxNode? VisitMemberAccessExpression(MemberAccessExpressionSyntax node)
            {
                if (!node.IsKind(SyntaxKind.PointerMemberAccessExpression))
                    return base.VisitMemberAccessExpression(node);

                var typeInfo = SemanticModel.GetTypeInfo(node.Expression);
                var name = GetTypeName(typeInfo.Type?.ToString() ?? string.Empty);

                // Check if the type is a ComType

                if (typeInfo.Type != null && ComTypes.Any(type => $"{type.Item1}*" == name))
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
                var name = GetTypeName(typeInfo.Type?.ToString() ?? string.Empty);
                // Check if the type is a ComType
                if (typeInfo.Type != null && ComTypes.Any(type => $"{type.Item1}*" == name))
                {
                    return AssignmentExpression(node.Kind(), node.Left, LiteralExpression(SyntaxKind.DefaultExpression));
                }
                return base.VisitAssignmentExpression(node);
            }

            public override SyntaxNode? VisitInvocationExpression(InvocationExpressionSyntax node)
            {
                if (!node.ArgumentList.Arguments.Any(arg => arg.Expression.IsKind(SyntaxKind.NullLiteralExpression)))
                    return base.VisitInvocationExpression(node);

                var symbolInfo = SemanticModel.GetSymbolInfo(node);
                var newInvocation = node;
                bool changed = false;
                if (symbolInfo.Symbol is IMethodSymbol methodSymbol)
                {
                    var arguments = node.ArgumentList.Arguments;
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
                            if (ComTypes.Any(type => $"{type.Item1}*" == name))
                            {
                                changed = true;
                                var newDefaultArg = Argument(LiteralExpression(SyntaxKind.DefaultLiteralExpression));
                                newInvocation = newInvocation.ReplaceNode(argument, newDefaultArg);
                            }
                        }
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
                var nameR = GetTypeName(typeInfoR.Type?.ToString() ?? string.Empty);
                var nameL = GetTypeName(typeInfoL.Type?.ToString() ?? string.Empty);


                if (node.Left.IsKind(SyntaxKind.NullLiteralExpression))
                {
                    // Check if the type is a ComType
                    if (typeInfoR.Type != null && ComTypes.Any(type => $"{type.Item1}*" == nameR))
                    {
                        return BinaryExpression(node.Kind(), node.Left, IdentifierName($"{node.Right.ToFullString()}.lpVtbl"));
                    }
                }
                else
                {
                    // Check if the type is a ComType
                    if (typeInfoL.Type != null && ComTypes.Any(type => $"{type.Item1}*" == nameL))
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
                var name = GetTypeName(variableType?.ToString() ?? string.Empty);

                // Check if the parameter type is ComType
                if (!ComTypes.Any(type => $"{type.Item1}*" == name))
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

        class Rewriter(List<(string, bool, KeyedStringTree?)> ComTypes)
            : CSharpSyntaxRewriter
        {
            public override SyntaxNode? VisitPointerType(PointerTypeSyntax node)
            {
                for (int i = 0; i < ComTypes.Count; i++)
                {
                    (string, bool, KeyedStringTree?) val = ComTypes[i];

                    if (val.Item1 == node.ElementType.ToString())
                    {
                        return IdentifierName(val.Item1);
                    }
                }

                return base.VisitPointerType(node);
            }

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

                if (ret is InterfaceDeclarationSyntax inter && inter.BaseList is not null && inter.BaseList.Types.Any(baseType => baseType.Type.ToString().EndsWith(".Interface")))
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
                    (string, bool, KeyedStringTree?) val = ComTypes[i];

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

            public override SyntaxNode? VisitStructDeclaration(StructDeclarationSyntax node)
            {
                string name = node.Identifier.ToString();
                foreach (var ComType in ComTypes)
                {
                    if (name == ComType.Item1 && ComType.Item3 is not null && ComType.Item3.FindNode(name, out KeyedStringTree.Node? treeNode) && treeNode.Parent is not null)
                    {
                        //visit and modify ComType Variables and internal usages first
                        node = (base.VisitStructDeclaration(node) as StructDeclarationSyntax)!;

                        //Correct to the .Interface version which will always be our parent
                        treeNode = treeNode.Parent;

                        //Add vtbl constructor to ComType
                        node = node.AddMembers(ConstructorDeclaration(ComType.Item1).
                                               WithModifiers(
                                                TokenList(
                                                    Token(SyntaxKind.PublicKeyword))).
                                               WithParameterList(
                                                ParameterList(
                                                    SingletonSeparatedList(
                                                        Parameter(
                                                            Identifier("vtbl")).
                                                        WithType(
                                                            ParseTypeName("void***"))))).
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
                                                                            XmlEmptyElement(XmlName("see"),  List<XmlAttributeSyntax>(new [] { XmlCrefAttribute(NameMemberCref(IdentifierName(ComType.Item1))) })),
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
                                                                            XmlName("param")))
                                                                }))))));

                        if (treeNode.Parent is not null)
                        {
                            node = generateUpcasts(node, ComType.Item1, treeNode.Parent);
                        }

                        return node;
                    }
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
                                                        XmlName("param")))
                                            })))));
            }
        }
    }
}
