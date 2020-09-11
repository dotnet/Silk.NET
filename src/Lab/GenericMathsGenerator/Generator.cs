// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Text;
using static Microsoft.CodeAnalysis.CSharp.SyntaxFactory;

namespace GenericMathsGenerator
{
    [Generator]
    public class Generator : ISourceGenerator
    {
        public void Initialize(InitializationContext context)
        {
            context.RegisterForSyntaxNotifications(() => new SyntaxReceiver());
        }

        public void Execute(SourceGeneratorContext context)
        {
            try
            {
                context.AddSource
                (
                    "attribute", SourceText.From
                    (
                        @"
using System;

namespace GenericMaths
{
    [AttributeUsage(AttributeTargets.Method | AttributeTargets.Class | AttributeTargets.Struct)]
    public class GenericMathsAttribute : Attribute
    {
        
    }
}
", Encoding.UTF8
                    )
                );

                if (!(context.SyntaxReceiver is SyntaxReceiver sr))
                    return;

                var attributeType = context.Compilation.GetTypeByMetadataName("GenericMaths.GenericMaths");


                var classes = sr.Classes.Select
                    (
                        x => (x,
                            ModelExtensions.GetDeclaredSymbol
                                (context.Compilation.GetSemanticModel(x.SyntaxTree), x) as INamedTypeSymbol)
                    )
                    .Select
                    (
                        x => (x.x, x.Item2,
                            x.Item2.GetAttributes().FirstOrDefault(x => x.AttributeClass.Name == "GenericMaths"))
                    )
                    .Where(att => att.Item3 is not null)
                    .ToArray();

                var structs = sr.Structs.Select
                    (
                        x => (x,
                            ModelExtensions.GetDeclaredSymbol
                                (context.Compilation.GetSemanticModel(x.SyntaxTree), x) as INamedTypeSymbol)
                    )
                    .Select
                    (
                        x => (x.x, x.Item2,
                            x.Item2.GetAttributes().FirstOrDefault(x => x.AttributeClass.Name == "GenericMaths"))
                    )
                    .Where(att => att.Item3 is not null)
                    .ToArray();

                var methods = sr.Methods.Select
                    (
                        x => (x,
                            ModelExtensions.GetDeclaredSymbol
                                (context.Compilation.GetSemanticModel(x.SyntaxTree), x) as IMethodSymbol)
                    )
                    .Select
                    (
                        x => (x.x, x.Item2,
                            x.Item2.GetAttributes()
                                .FirstOrDefault(x => x.AttributeClass.Name == "GenericMathsAttribute"))
                    )
                    .Where(att => att.Item3 is not null)
                    .ToArray();

                foreach (var (declaration, symbol, attribute) in classes)
                {
                    var options = context.AnalyzerConfigOptions.GetOptions(declaration.SyntaxTree);

                    var possibleTypes = new List<TypeSyntax>();
                    if (options.TryGetValue
                            ("generic_maths_possible_types", out var possibleTypesStr) &&
                        !string.IsNullOrWhiteSpace(possibleTypesStr))
                    {
                        foreach (var t in possibleTypesStr.Split(','))
                        {
                            var parsed = ParseTypeName(t);
                            if (!(parsed is null))
                                possibleTypes.Add(parsed);
                        }
                    }

                    if (possibleTypes.Count == 0)
                    {
                        possibleTypes.AddRange
                        (
                            new TypeSyntax[]
                            {
                                IdentifierName(nameof(System) + "." + nameof(Byte)),
                                IdentifierName(nameof(System) + "." + nameof(SByte)),
                                IdentifierName(nameof(System) + "." + nameof(Int16)),
                                IdentifierName(nameof(System) + "." + nameof(UInt16)),
                                IdentifierName(nameof(System) + "." + nameof(Int32)),
                                IdentifierName(nameof(System) + "." + nameof(UInt32)),
                                IdentifierName(nameof(System) + "." + nameof(Int64)),
                                IdentifierName(nameof(System) + "." + nameof(UInt64)),
                            }
                        );
                    }

                    var remaps = new Dictionary<ITypeSymbol, TypeSyntax>();
                    remaps[symbol] = GenericName
                            (symbol.Name)
                        .WithTypeArgumentList
                            (TypeArgumentList(SingletonSeparatedList((TypeSyntax) IdentifierName(typeParam))));

                    var semanticModel = context.Compilation.GetSemanticModel(declaration.SyntaxTree);
                    var rewriter = new GeneralizingRewriter
                    (
                        context, possibleTypes.ToArray(), remaps, semanticModel,
                        IdentifierName(semanticModel.GetDeclaredSymbol(declaration).ToDisplayString())
                    );
                    var newDeclaration = declaration.Update
                    (
                        rewriter.VisitList(declaration.AttributeLists), rewriter.VisitList(declaration.Modifiers),
                        rewriter.VisitToken(declaration.Keyword), rewriter.VisitToken(declaration.Identifier),
                        (TypeParameterListSyntax?) rewriter.Visit
                        (
                            (declaration.TypeParameterList ?? TypeParameterList()).AddParameters
                                (TypeParameter(typeParam))
                        ), (BaseListSyntax?) rewriter.Visit(declaration.BaseList), rewriter.VisitList
                        (
                            declaration.ConstraintClauses.Add
                            (
                                TypeParameterConstraintClause(typeParam)
                                    .WithConstraints
                                    (
                                        SeparatedList
                                        (
                                            new TypeParameterConstraintSyntax[]
                                            {
                                                TypeConstraint(IdentifierName("unmanaged")),
                                                TypeConstraint(IdentifierName("System.IFormattable"))
                                            }
                                        )
                                    )
                            )
                        ), rewriter.VisitToken(declaration.OpenBraceToken), rewriter.VisitList(declaration.Members),
                        rewriter.VisitToken(declaration.CloseBraceToken),
                        rewriter.VisitToken(declaration.SemicolonToken)
                    );
                    newDeclaration = newDeclaration.InsertNodesAfter
                        (newDeclaration.ChildNodes().Last(), rewriter.ExtraMembers);

                    var last = (original: (SyntaxNode) declaration, modified: (SyntaxNode) newDeclaration);

                    while (last.original.Parent != null)
                    {
                        var p = last.original.Parent;
                        var children = p.ChildNodes().Where(x => x != last.original);
                        var modified = p.ReplaceNode
                                (last.original, last.modified)
                            .RemoveNodes(children, SyntaxRemoveOptions.KeepDirectives);
                        last = (original: p, modified: modified);
                    }

                    var str = last.modified.NormalizeWhitespace().ToFullString();
                    File.WriteAllText(@"C:\SILK.NET\src\Lab\GenericMaths\" + $"{declaration.GetHashCode()}.gen", str);
                    context.AddSource($"{declaration.GetHashCode()}", SourceText.From(str, Encoding.UTF8));
                }

                foreach (var (declaration, symbol, attribute) in structs)
                {
                    var options = context.AnalyzerConfigOptions.GetOptions(declaration.SyntaxTree);

                    var possibleTypes = new List<TypeSyntax>();
                    if (options.TryGetValue
                            ("generic_maths_possible_types", out var possibleTypesStr) &&
                        !string.IsNullOrWhiteSpace(possibleTypesStr))
                    {
                        foreach (var t in possibleTypesStr.Split(','))
                        {
                            var parsed = ParseTypeName(t);
                            if (!(parsed is null))
                                possibleTypes.Add(parsed);
                        }
                    }

                    if (possibleTypes.Count == 0)
                    {
                        possibleTypes.AddRange
                        (
                            new TypeSyntax[]
                            {
                                IdentifierName(nameof(System) + "." + nameof(Byte)),
                                IdentifierName(nameof(System) + "." + nameof(SByte)),
                                IdentifierName(nameof(System) + "." + nameof(Int16)),
                                IdentifierName(nameof(System) + "." + nameof(UInt16)),
                                IdentifierName(nameof(System) + "." + nameof(Int32)),
                                IdentifierName(nameof(System) + "." + nameof(UInt32)),
                                IdentifierName(nameof(System) + "." + nameof(Int64)),
                                IdentifierName(nameof(System) + "." + nameof(UInt64)),
                            }
                        );
                    }

                    var remaps = new Dictionary<ITypeSymbol, TypeSyntax>();
                    remaps[symbol] = GenericName
                            (symbol.Name)
                        .WithTypeArgumentList
                            (TypeArgumentList(SingletonSeparatedList((TypeSyntax) IdentifierName(typeParam))));

                    var semanticModel = context.Compilation.GetSemanticModel(declaration.SyntaxTree);
                    var rewriter = new GeneralizingRewriter
                    (
                        context, possibleTypes.ToArray(), remaps, semanticModel,
                        IdentifierName(semanticModel.GetDeclaredSymbol(declaration).ToDisplayString())
                    );
                    var newDeclaration = declaration.Update
                    (
                        rewriter.VisitList(declaration.AttributeLists), rewriter.VisitList(declaration.Modifiers),
                        rewriter.VisitToken(declaration.Keyword), rewriter.VisitToken(declaration.Identifier),
                        (TypeParameterListSyntax?) rewriter.Visit
                        (
                            (declaration.TypeParameterList ?? TypeParameterList()).AddParameters
                                (TypeParameter(typeParam))
                        ), (BaseListSyntax?) rewriter.Visit(declaration.BaseList), rewriter.VisitList
                        (
                            declaration.ConstraintClauses.Add
                            (
                                TypeParameterConstraintClause(typeParam)
                                    .WithConstraints
                                    (
                                        SeparatedList
                                        (
                                            new TypeParameterConstraintSyntax[]
                                            {
                                                TypeConstraint(IdentifierName("unmanaged")),
                                                TypeConstraint(IdentifierName("System.IFormattable"))
                                            }
                                        )
                                    )
                            )
                        ), rewriter.VisitToken(declaration.OpenBraceToken), rewriter.VisitList(declaration.Members),
                        rewriter.VisitToken(declaration.CloseBraceToken),
                        rewriter.VisitToken(declaration.SemicolonToken)
                    );
                    newDeclaration = newDeclaration.InsertNodesAfter
                        (newDeclaration.ChildNodes().Last(), rewriter.ExtraMembers);

                    var last = (original: (SyntaxNode) declaration, modified: (SyntaxNode) newDeclaration);

                    while (last.original.Parent != null)
                    {
                        var p = last.original.Parent;
                        var children = p.ChildNodes().Where(x => x != last.original);
                        var modified = p.ReplaceNode
                                (last.original, last.modified)
                            .RemoveNodes(children, SyntaxRemoveOptions.KeepDirectives);
                        last = (original: p, modified: modified);
                    }

                    var str = last.modified.NormalizeWhitespace().ToFullString();
                    File.WriteAllText(@"C:\SILK.NET\src\Lab\GenericMaths\" + $"{declaration.GetHashCode()}.gen", str);
                    context.AddSource($"{declaration.GetHashCode()}", SourceText.From(str, Encoding.UTF8));
                }

                foreach (var (declaration, symbol, attribute) in methods)
                {
                    var options = context.AnalyzerConfigOptions.GetOptions(declaration.SyntaxTree);

                    var possibleTypes = new List<TypeSyntax>();
                    if (options.TryGetValue
                            ("generic_maths_possible_types", out var possibleTypesStr) &&
                        !string.IsNullOrWhiteSpace(possibleTypesStr))
                    {
                        foreach (var t in possibleTypesStr.Split(','))
                        {
                            var parsed = ParseTypeName(t);
                            if (!(parsed is null))
                                possibleTypes.Add(parsed);
                        }
                    }

                    if (possibleTypes.Count == 0)
                    {
                        possibleTypes.AddRange
                        (
                            new TypeSyntax[]
                            {
                                IdentifierName(nameof(System) + "." + nameof(Byte)),
                                IdentifierName(nameof(System) + "." + nameof(SByte)),
                                IdentifierName(nameof(System) + "." + nameof(Int16)),
                                IdentifierName(nameof(System) + "." + nameof(UInt16)),
                                IdentifierName(nameof(System) + "." + nameof(Int32)),
                                IdentifierName(nameof(System) + "." + nameof(UInt32)),
                                IdentifierName(nameof(System) + "." + nameof(Int64)),
                                IdentifierName(nameof(System) + "." + nameof(UInt64)),
                            }
                        );
                    }

                    var remaps = new Dictionary<ITypeSymbol, TypeSyntax>();

                    var rewriter = new GeneralizingRewriter
                    (
                        context, possibleTypes.ToArray(), remaps,
                        context.Compilation.GetSemanticModel(declaration.SyntaxTree), null
                    );
                    var newDeclaration = declaration.Update
                    (
                        declaration.AttributeLists, declaration.Modifiers, declaration.ReturnType,
                        declaration.ExplicitInterfaceSpecifier, declaration.Identifier, declaration.TypeParameterList,
                        declaration.ParameterList, declaration.ConstraintClauses, declaration.Body,
                        declaration.ExpressionBody, declaration.SemicolonToken
                    );
                    newDeclaration = (MethodDeclarationSyntax) rewriter.VisitMethodDeclaration(newDeclaration)!;
                    newDeclaration = newDeclaration.InsertNodesAfter
                        (newDeclaration.ChildNodes().Last(), rewriter.ExtraMembers);

                    var last = (original: (SyntaxNode) declaration, modified: (SyntaxNode) newDeclaration);

                    while (last.original.Parent != null)
                    {
                        var p = last.original.Parent;
                        var children = p.ChildNodes().Where(x => x != last.original);
                        var modified = p.ReplaceNode
                                (last.original, last.modified)
                            .RemoveNodes(children, SyntaxRemoveOptions.KeepDirectives);
                        last = (original: p, modified: modified);
                    }

                    var str = last.modified.NormalizeWhitespace().ToFullString();
                    File.WriteAllText(@"C:\SILK.NET\src\Lab\GenericMaths\" + $"{declaration.GetHashCode()}.gen", str);
                    context.AddSource($"{declaration.GetHashCode()}", SourceText.From(str, Encoding.UTF8));
                }
            }
            catch (DiagnosticException ex)
            {
                context.ReportDiagnostic(ex.Diagnostic);
            }
            catch (Exception ex)
            {
                Debugger.Launch();
            }
        }

        public class GeneralizingRewriter : CSharpSyntaxRewriter
        {
            private readonly SourceGeneratorContext _context;
            private readonly TypeSyntax[] _possibleTypes;
            private readonly Dictionary<ITypeSymbol, TypeSyntax> _remaps;
            private readonly SemanticModel _semanticModel;
            private readonly TypeSyntax? _parentType;
            public List<MemberDeclarationSyntax> ExtraMembers { get; }

            public GeneralizingRewriter
            (
                SourceGeneratorContext context,
                TypeSyntax[] possibleTypes,
                Dictionary<ITypeSymbol, TypeSyntax> remaps,
                SemanticModel semanticModel,
                TypeSyntax? parentType
            )
            {
                _context = context;
                _possibleTypes = possibleTypes;
                _remaps = remaps;
                _semanticModel = semanticModel;
                _parentType = parentType;
                _remaps.Add(_semanticModel.Compilation.GetSpecialType(SpecialType.System_Single), IdentifierName(typeParam));
                ExtraMembers = new List<MemberDeclarationSyntax>();
            }
            
            public override SyntaxNode? VisitFieldDeclaration(FieldDeclarationSyntax node)
            {
                var modifiers = node.Modifiers;
                var token = modifiers.FirstOrDefault(x => x.Kind() == SyntaxKind.ConstKeyword);

                if (token == default)
                    return base.VisitFieldDeclaration(node);

                var cIndex = modifiers.IndexOf(token);
                
                if (cIndex > 0 && cIndex < modifiers.Count)
                {
                    modifiers = node.Modifiers.RemoveAt(cIndex)
                        .Insert(cIndex, Token(SyntaxKind.StaticKeyword))
                        .Insert(cIndex, Token(SyntaxKind.ReadOnlyKeyword));
                }
                
                return base.VisitFieldDeclaration(node.WithModifiers(modifiers));
            }

            public override SyntaxNode VisitMethodDeclaration(MethodDeclarationSyntax node)
            {
                var returnType = (TypeSyntax)Visit(node.ReturnType)!;
                var body = node.Body is not null
                    ? VisitMethodBody
                    (
                        node.Identifier.Text, returnType, (ParameterListSyntax)Visit(node.ParameterList)!, node.TypeParameterList,
                        node.Modifiers, node.Body!
                    )
                    : VisitExpressionBody
                    (
                        node.Identifier.Text, returnType, (ParameterListSyntax)Visit(node.ParameterList)!, node.TypeParameterList,
                        node.Modifiers, node.ExpressionBody!
                    );

                node = node.Update
                (
                    node.AttributeLists, node.Modifiers,
                    returnType,
                    node.ExplicitInterfaceSpecifier, node.Identifier, node.TypeParameterList,
                    (ParameterListSyntax?) Visit(node.ParameterList) ??
                    throw new ArgumentNullException("parameterList"), node.ConstraintClauses, body, null,
                    default
                );
                return node.Update
                (
                    VisitList(node.AttributeLists), VisitList(node.Modifiers),
                    (TypeSyntax?) Visit(node.ReturnType) ?? throw new ArgumentNullException("returnType"),
                    (ExplicitInterfaceSpecifierSyntax?) Visit(node.ExplicitInterfaceSpecifier),
                    VisitToken(node.Identifier), (TypeParameterListSyntax?) Visit(node.TypeParameterList),
                    node.ParameterList, VisitList(node.ConstraintClauses),
                    body,
                    (ArrowExpressionClauseSyntax?) Visit(node.ExpressionBody), VisitToken(node.SemicolonToken)
                );
            }

            public override SyntaxNode? VisitOperatorDeclaration(OperatorDeclarationSyntax node)
            {
                var identifier = node.OperatorToken.Text switch
                {
                    "+" => "Add",
                    "-" => "Subtract",
                    "*" => "Multiply",
                    "/" => "Divide",
                    "%" => "Modulo",
                    "==" => "Equals",
                    "!=" => "NotEquals",
                    _ => throw new DiagnosticException(Diagnostic.Create(Diagnostics.UnsupportedOperator, null, node.OperatorToken.Text))
                };

                identifier = identifier + "_OP";
                
                var returnType = (TypeSyntax)Visit(node.ReturnType)!;
                var body = node.Body is not null
                    ? VisitMethodBody
                    (
                        identifier, returnType, (ParameterListSyntax)Visit(node.ParameterList)!, TypeParameterList(),
                        node.Modifiers, node.Body!
                    )
                    : VisitExpressionBody
                    (
                        identifier, returnType, (ParameterListSyntax)Visit(node.ParameterList)!, TypeParameterList(),
                        node.Modifiers, node.ExpressionBody!
                    );

                node = node.Update
                (
                    node.AttributeLists, node.Modifiers, returnType, node.OperatorKeyword, node.OperatorToken,
                    (ParameterListSyntax?) Visit(node.ParameterList) ??
                    throw new ArgumentNullException("parameterList"), body, null, default
                );
                return node.Update
                (
                    VisitList(node.AttributeLists), VisitList(node.Modifiers),
                    (TypeSyntax?) Visit(node.ReturnType) ?? throw new ArgumentNullException("returnType"),
                    node.OperatorKeyword, node.OperatorToken, node.ParameterList, body,
                    (ArrowExpressionClauseSyntax?) Visit(node.ExpressionBody), VisitToken(node.SemicolonToken)
                );
            }

            public override SyntaxNode? VisitParameter(ParameterSyntax node) 
                => base.VisitParameter(_semanticModel.GetDeclaredSymbol(node.Type) is ITypeSymbol symbol && _remaps.TryGetValue(symbol, out var n) ? node.WithType(n) : node);

            public BlockSyntax VisitExpressionBody
            (
                string methodName,
                TypeSyntax returnType,
                ParameterListSyntax parameterList,
                TypeParameterListSyntax? typeParameterList,
                SyntaxTokenList modifiers,
                ArrowExpressionClauseSyntax body
            )
            {
                returnType = _semanticModel.GetDeclaredSymbol(returnType) is ITypeSymbol symbol && _remaps.TryGetValue
                    (symbol, out var n)
                    ? n
                    : returnType;
                var statements = new List<StatementSyntax>();
                foreach (var possibleType in _possibleTypes)
                {
                    var name = $"{methodName}_SUB_{(uint) _context.GetHashCode()}_{ExtraMembers.Count}";

                    var m = TokenList
                    (
                        modifiers.Select
                            (
                                x => x.Kind() switch
                                {
                                    SyntaxKind.PublicKeyword => Token(SyntaxKind.PublicKeyword),
                                    SyntaxKind.PrivateKeyword => Token(SyntaxKind.PublicKeyword),
                                    SyntaxKind.InternalKeyword => Token(SyntaxKind.PublicKeyword),
                                    SyntaxKind.ProtectedKeyword => Token(SyntaxKind.PublicKeyword),
                                    _ => x
                                }
                            )
                            .Where(x => x.Kind() != SyntaxKind.OverrideKeyword)
                    );
                    ExtraMembers.Add
                    (
                        MethodDeclaration
                                (IdentifierName(typeParam), name)
                            .WithExpressionBody
                            (
                                    (((ArrowExpressionClauseSyntax) new SpecializingRewriter
                                        (possibleType, _remaps, _semanticModel, returnType, this).Visit(body))!)
                            )
                            .WithParameterList(parameterList)
                            .WithTypeParameterList(typeParameterList)
                            .WithReturnType(returnType)
                            .WithModifiers(m)
                            .WithSemicolonToken(Token(SyntaxKind.SemicolonToken))
                    );
                    statements.Add
                    (
                        IfStatement
                        (
                            BinaryExpression
                            (
                                SyntaxKind.EqualsExpression, TypeOfExpression(IdentifierName(typeParam)),
                                TypeOfExpression(possibleType)
                            ),
                            ReturnStatement
                            (
                                InvocationExpression
                                (
                                    IdentifierName(name),
                                    ArgumentList
                                    (
                                        SeparatedList
                                        (
                                            parameterList.Parameters.Select(x => Argument(IdentifierName(x.Identifier)))
                                        )
                                    )
                                )
                            )
                        )
                    );
                }

                return Block(statements);
            }

            public BlockSyntax VisitMethodBody(string methodName, TypeSyntax returnType, ParameterListSyntax parameterList, TypeParameterListSyntax? typeParameterList, SyntaxTokenList modifiers, BlockSyntax body)
            {
                returnType = _semanticModel.GetDeclaredSymbol(returnType) is ITypeSymbol symbol && _remaps.TryGetValue
                    (symbol, out var n)
                    ? n
                    : returnType;
                var statements = new List<StatementSyntax>();
                foreach (var possibleType in _possibleTypes)
                {
                    var name = $"{methodName}_SUB_{(uint)_context.GetHashCode()}_{ExtraMembers.Count}";

                    var m = modifiers.Select
                        (
                            x => x.Kind() switch
                            {
                                SyntaxKind.PublicKeyword => Token(SyntaxKind.PrivateKeyword),
                                SyntaxKind.PrivateKeyword => Token(SyntaxKind.PrivateKeyword),
                                SyntaxKind.InternalKeyword => Token(SyntaxKind.PrivateKeyword),
                                SyntaxKind.ProtectedKeyword => Token(SyntaxKind.PrivateKeyword),
                                _ => x
                            }
                        )
                        .Where(x => x.Kind() != SyntaxKind.OverrideKeyword).ToArray();
                    
                    if (!m.Any(x => x.IsKind(SyntaxKind.PrivateKeyword)))
                        m = m.Append(Token(SyntaxKind.PrivateKeyword)).ToArray();

                    ExtraMembers.Add
                    (
                        MethodDeclaration
                                (IdentifierName(typeParam), name)
                            .WithBody
                            (
                                Block
                                (
                                    ((StatementSyntax) new SpecializingRewriter
                                        (possibleType, _remaps, _semanticModel, returnType, this).Visit(body))!
                                )
                            )
                            .WithParameterList(parameterList)
                            .WithTypeParameterList(typeParameterList)
                            .WithReturnType(returnType)
                            .WithModifiers(TokenList(m))
                    );
                    statements.Add
                    (
                        IfStatement
                        (
                            BinaryExpression
                            (
                                SyntaxKind.EqualsExpression, TypeOfExpression(IdentifierName(typeParam)),
                                TypeOfExpression(possibleType)
                            ),
                            ReturnStatement
                            (
                                InvocationExpression
                                (
                                    IdentifierName(name),
                                    ArgumentList
                                    (
                                        SeparatedList
                                        (
                                            parameterList.Parameters.Select
                                                (x => Argument(IdentifierName(x.Identifier)))
                                        )
                                    )
                                )
                            )
                        )
                    );
                }

                statements.Add
                (
                    ExpressionStatement
                    (
                        InvocationExpression
                        (
                            MemberAccessExpression
                            (
                                SyntaxKind.SimpleMemberAccessExpression,
                                MemberAccessExpression
                                (
                                    SyntaxKind.SimpleMemberAccessExpression,
                                    MemberAccessExpression
                                    (
                                        SyntaxKind.SimpleMemberAccessExpression,
                                        MemberAccessExpression
                                        (
                                            SyntaxKind.SimpleMemberAccessExpression, IdentifierName("Silk"),
                                            IdentifierName("NET")
                                        ), IdentifierName("Maths")
                                    ), IdentifierName("Scalar")
                                ), IdentifierName("ThrowInvalidType")
                            ), ArgumentList()
                        )
                    )
                );
                statements.Add(ReturnStatement(DefaultExpression(IdentifierName(typeParam))));

                return Block(statements).WithLeadingTrivia(SyntaxTrivia(SyntaxKind.MultiLineCommentTrivia, "/* Processed by specialization rewriter */"));
            }

            public override SyntaxNode? VisitConstructorDeclaration(ConstructorDeclarationSyntax node)
            {

                Debug.Assert(_parentType is not null, nameof(_parentType) + " is null");
                
                var body = node.Body is not null
                    ? VisitMethodBody
                        (node.Identifier.Text, _parentType, node.ParameterList, null, node.Modifiers, node.Body!)
                    : VisitExpressionBody
                        (node.Identifier.Text, _parentType, node.ParameterList, null, node.Modifiers, node.ExpressionBody!);

                return node.Update
                (
                    VisitList(node.AttributeLists), VisitList(node.Modifiers), VisitToken(node.Identifier),
                    (ParameterListSyntax?) Visit(node.ParameterList) ??
                    throw new ArgumentNullException("parameterList"),
                    (ConstructorInitializerSyntax?) Visit(node.Initializer),
                    body,
                    null, VisitToken(default)
                );
            }

            public override SyntaxNode? VisitPropertyDeclaration(PropertyDeclarationSyntax prop)
            {
                Debug.Assert(_parentType is not null, nameof(_parentType) + " is null");

                return base.VisitPropertyDeclaration
                (
                    (prop.AccessorList is not null ? prop.WithAccessorList
                    (
                        AccessorList
                        (
                            List
                            (
                                prop.AccessorList!.Accessors.Select
                                (
                                    node =>
                                    {
                                        var body = node.Body is not null
                                            ? VisitMethodBody
                                            (
                                                $"{prop.Identifier.Text}_accessor_{node.Keyword.Text}", prop.Type,
                                                ParameterList(), null, node.Modifiers, node.Body!
                                            )
                                            : VisitExpressionBody
                                            (
                                                $"{prop.Identifier.Text}_accessor_{node.Keyword.Text}", prop.Type,
                                                ParameterList(), null, node.Modifiers, node.ExpressionBody!
                                            );

                                        return node.Update
                                        (
                                            VisitList(node.AttributeLists), VisitList(node.Modifiers),
                                            VisitToken(node.Keyword),
                                            body, null, default
                                        );
                                    }
                                )
                            )
                        )
                    ): prop).WithType((TypeSyntax)Visit(prop.Type)!)
                );
            }

            public override SyntaxNode? Visit(SyntaxNode? node)
            {
                if (node is TypeSyntax s)
                {
                    try
                    {
                        var symbol = _semanticModel.GetSymbolInfo(s).Symbol;
                        if (symbol is ITypeSymbol ts && _remaps.TryGetValue(ts, out var n))
                            return base.Visit(n);
                    }
                    catch { /* unfortunately, there is not `TryGetTypeInfo` */ }
                }
                
                return base.Visit(node);
            }
        }
        
        private class SpecializingRewriter : CSharpSyntaxRewriter
        {
            private readonly TypeSyntax _specializedType;
            private readonly Dictionary<ITypeSymbol, TypeSyntax> _remaps;
            private readonly SemanticModel _semanticModel;
            private readonly TypeSyntax? _returnType;
            private readonly GeneralizingRewriter _parent;

            public SpecializingRewriter(TypeSyntax specializedType, Dictionary<ITypeSymbol, TypeSyntax> remaps, SemanticModel semanticModel, TypeSyntax? returnType, GeneralizingRewriter parent)
            {
                _specializedType = specializedType;
                _remaps = remaps;
                _semanticModel = semanticModel;
                _returnType = returnType;
                _parent = parent;
            }

            public override SyntaxNode? VisitReturnStatement(ReturnStatementSyntax node)
            {
                // this should handle implicit conversions, by explicitly converting.
                return base.VisitReturnStatement
                (
                    _returnType is null
                        ? node
                        : ReturnStatement
                        (
                            CastExpression
                            (
                                _returnType,
                                CastExpression(PredefinedType(Token(SyntaxKind.ObjectKeyword)), ParenthesizedExpression(node.Expression))
                            )
                        )
                );
            }

            public override SyntaxNode? VisitFieldDeclaration(FieldDeclarationSyntax node)
            {
                var modifiers = node.Modifiers;
                var token = modifiers.FirstOrDefault(x => x.Kind() == SyntaxKind.ConstKeyword);

                if (token == default)
                    return base.VisitFieldDeclaration(node);

                var cIndex = modifiers.IndexOf(token);
                
                if (cIndex > 0 && cIndex < modifiers.Count)
                {
                    modifiers = node.Modifiers.RemoveAt(cIndex)
                        .Insert(cIndex, Token(SyntaxKind.StaticKeyword))
                        .Insert(cIndex, Token(SyntaxKind.ReadOnlyKeyword));
                }
                
                return base.VisitFieldDeclaration(node.WithModifiers(modifiers));
            }
            
            public override SyntaxNode? Visit(SyntaxNode? node)
            {
                if (node is TypeSyntax s)
                {
                    try
                    {
                        var symbol = _semanticModel.GetSymbolInfo(s).Symbol;
                        if (symbol is ITypeSymbol ts && _remaps.TryGetValue(ts, out var n))
                            return base.Visit(n);
                    }
                    catch { /* unfortunately, there is not `TryGetSymbolInfo` */ }
                }
                
                return base.Visit(node);
            }

            private static MemberAccessExpressionSyntax SilkNetMathsScalar = MemberAccessExpression
            (
                SyntaxKind.SimpleMemberAccessExpression,
                MemberAccessExpression
                (
                    SyntaxKind.SimpleMemberAccessExpression,
                    MemberAccessExpression
                        (SyntaxKind.SimpleMemberAccessExpression, IdentifierName("Silk"), IdentifierName("NET")),
                    IdentifierName("Maths")
                ), IdentifierName("Scalar")
            );

            private static ExpressionSyntax AddMethod = MemberAccessExpression
                (SyntaxKind.SimpleMemberAccessExpression, SilkNetMathsScalar, IdentifierName("Add"));

            private static ExpressionSyntax SubtractMethod = MemberAccessExpression
                (SyntaxKind.SimpleMemberAccessExpression, SilkNetMathsScalar, IdentifierName("Subtract"));
            
            private static ExpressionSyntax MultiplyMethod = MemberAccessExpression
                (SyntaxKind.SimpleMemberAccessExpression, SilkNetMathsScalar, IdentifierName("Multiply"));
            
            private static ExpressionSyntax DivideMethod = MemberAccessExpression
                (SyntaxKind.SimpleMemberAccessExpression, SilkNetMathsScalar, IdentifierName("Divide"));

            private static ExpressionSyntax ModMethod = MemberAccessExpression
                (SyntaxKind.SimpleMemberAccessExpression, SilkNetMathsScalar, IdentifierName("Mod"));

            private static ExpressionSyntax SmallerMethod = MemberAccessExpression
                (SyntaxKind.SimpleMemberAccessExpression, SilkNetMathsScalar, IdentifierName("Smaller"));
            
            private static ExpressionSyntax LargerMethod = MemberAccessExpression
                (SyntaxKind.SimpleMemberAccessExpression, SilkNetMathsScalar, IdentifierName("Larger"));
            
            private static ExpressionSyntax SmallerEqualsMethod = MemberAccessExpression
                (SyntaxKind.SimpleMemberAccessExpression, SilkNetMathsScalar, IdentifierName("SmallerEquals"));
            
            private static ExpressionSyntax LargerEqualsMethod = MemberAccessExpression
                (SyntaxKind.SimpleMemberAccessExpression, SilkNetMathsScalar, IdentifierName("LargerEquals"));
            
            private static ExpressionSyntax EqualMethod = MemberAccessExpression
                (SyntaxKind.SimpleMemberAccessExpression, SilkNetMathsScalar, IdentifierName("Equal"));

            private static ExpressionSyntax NotEqualMethod = MemberAccessExpression
                (SyntaxKind.SimpleMemberAccessExpression, SilkNetMathsScalar, IdentifierName("NotEqual"));

            public override SyntaxNode? VisitBinaryExpression(BinaryExpressionSyntax node)
            {
                var (method, boolMethod) = node.OperatorToken.Text switch
                {
                    "+" => (AddMethod, false),
                    "-" => (SubtractMethod, false),
                    "*" => (MultiplyMethod, false),
                    "/" => (DivideMethod, false),
                    "%" => (ModMethod, false),
                    "<" => (SmallerMethod, true),
                    ">" => (LargerMethod, true),
                    "<=" => (SmallerEqualsMethod, true),
                    ">=" => (LargerEqualsMethod, true),
                    "==" => (EqualMethod, true),
                    "!=" => (NotEqualsMethod: NotEqualMethod, true),
                    _ => (null, false)
                } ;

                if (method is null)
                    return base.VisitBinaryExpression(node);

                var expr = ((ExpressionSyntax) VisitInvocationExpression
                (
                    InvocationExpression
                    (
                        method, ArgumentList
                        (
                            SeparatedList
                            (
                                new[]
                                {
                                    Argument(FromGeneric(node.Left)), Argument(FromGeneric(node.Right))
                                }
                            )
                        )
                    )
                ))!;
                
                return boolMethod ? expr : ToGeneric(expr);
            }

            private static IdentifierNameSyntax MathF = IdentifierName("MathF");

            private static ExpressionSyntax NegateMethod = MemberAccessExpression
                (SyntaxKind.SimpleMemberAccessExpression, SilkNetMathsScalar, IdentifierName("Negate"));
            
            public override SyntaxNode? VisitPrefixUnaryExpression(PrefixUnaryExpressionSyntax node)
            {
                var method = node.OperatorToken.Text switch
                {
                    "-" => NegateMethod,
                    _ => null
                };

                if (method is null)
                    return base.VisitPrefixUnaryExpression(node);
                
                return ToGeneric(((ExpressionSyntax)VisitInvocationExpression
                (
                    InvocationExpression
                    (
                        method, ArgumentList
                        (
                            SeparatedList
                            (
                                new[]
                                {
                                    Argument(FromGeneric(node.Operand))
                                }
                            )
                        )
                    )
                ))!);
            }

            public override SyntaxNode? VisitIdentifierName(IdentifierNameSyntax node)
            {
                if (node == MathF)
                    return VisitMemberAccessExpression(SilkNetMathsScalar);
                return base.VisitIdentifierName(node);
            }

            private ExpressionSyntax ToGeneric(ExpressionSyntax syntax)
                => CastExpression
                (
                    IdentifierName(typeParam), CastExpression(PredefinedType(Token(SyntaxKind.ObjectKeyword)), syntax)
                );
            
            private ExpressionSyntax FromGeneric(ExpressionSyntax syntax)
                => CastExpression
                (
                    _specializedType, CastExpression(PredefinedType(Token(SyntaxKind.ObjectKeyword)), syntax)
                );

            public override SyntaxNode? VisitLocalFunctionStatement(LocalFunctionStatementSyntax node)
            {
                // this function essentially delegates to the `_parent` Generializer, which then delegates to another Specializer, before returning to this one
                
                var body = node.Body is not null
                    ? _parent.VisitMethodBody
                    (
                        node.Identifier.Text, (TypeSyntax)Visit(node.ReturnType)!, (ParameterListSyntax)Visit(node.ParameterList)!, node.TypeParameterList,
                        node.Modifiers, node.Body!
                    )
                    : _parent.VisitExpressionBody
                    (
                        node.Identifier.Text, (TypeSyntax)Visit(node.ReturnType)!, (ParameterListSyntax)Visit(node.ParameterList)!, node.TypeParameterList,
                        node.Modifiers, node.ExpressionBody!
                    );

                node = node.Update
                (
                    node.AttributeLists, node.Modifiers,
                    _semanticModel.GetDeclaredSymbol(node.ReturnType) is ITypeSymbol symbol && _remaps.TryGetValue(symbol, out var n) ? n : node.ReturnType,
                    node.Identifier, node.TypeParameterList,
                    (ParameterListSyntax?) _parent.Visit(node.ParameterList) ??
                    throw new ArgumentNullException("parameterList"), node.ConstraintClauses, body, null,
                    default
                );
                return node.Update
                (
                    _parent.VisitList(node.AttributeLists), _parent.VisitList(node.Modifiers),
                    (TypeSyntax?) _parent.Visit(node.ReturnType) ?? throw new ArgumentNullException("returnType"),
                    _parent.VisitToken(node.Identifier), (TypeParameterListSyntax?) _parent.Visit(node.TypeParameterList),
                    node.ParameterList, _parent.VisitList(node.ConstraintClauses),
                    body,
                    (ArrowExpressionClauseSyntax?) _parent.Visit(node.ExpressionBody), _parent.VisitToken(node.SemicolonToken)
                );
            }
        }
        
        const string typeParam = "TNumeric";

        public class SyntaxReceiver : ISyntaxReceiver
        {
            public List<ClassDeclarationSyntax> Classes = new List<ClassDeclarationSyntax>();
            public List<StructDeclarationSyntax> Structs = new List<StructDeclarationSyntax>();
            public List<MethodDeclarationSyntax> Methods = new List<MethodDeclarationSyntax>();
            
            public void OnVisitSyntaxNode(SyntaxNode syntaxNode)
            {
                switch (syntaxNode)
                {
                    case ClassDeclarationSyntax cds:
                        Classes.Add(cds);
                        break;
                    case StructDeclarationSyntax sds:
                        Structs.Add(sds);
                        break;
                    case MethodDeclarationSyntax mds:
                        Methods.Add(mds);
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
