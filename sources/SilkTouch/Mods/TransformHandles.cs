// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.Extensions.Options;
using Silk.NET.SilkTouch.Clang;
using Silk.NET.SilkTouch.Naming;
using static Microsoft.CodeAnalysis.CSharp.SyntaxFactory;

namespace Silk.NET.SilkTouch.Mods;

/// <summary>
/// Transforms any pointers to an opaque struct or pointers to a non-existent type to be "handle" type. That is, a
/// struct that wraps the underlying opaque pointer (or other underlying value)
/// </summary>
/// <remarks>
/// It is assumed that all handle types in the generated syntax do not require a <c>using</c> directive in order to be
/// in scope. That is, if a file with the namespace <c>Silk.NET.OpenGL</c> is encountered and it is referencing
/// <c>Program</c>, <c>Program</c> must be declared in <c>Silk.NET.OpenGL</c>, <c>Silk.NET</c>, or <c>Silk</c>.
/// When <see cref="Config.AssumeMissingTypesOpaque"/> is used, types will be generated to this effect.
/// </remarks>
[ModConfiguration<Config>]
public class TransformHandles(IOptionsSnapshot<TransformHandles.Config> config) : Mod
{
    /// <summary>
    /// The configuration for the <see cref="TransformHandles"/> mod.
    /// </summary>
    public class Config
    {
        /// <summary>
        /// Whether it should be assumed that missing types are likely opaque if they are only used as a pointer type
        /// and therefore should be subjected to handle transformations.
        /// </summary>
        public bool AssumeMissingTypesOpaque { get; init; }

        /// <summary>
        /// Whether the DSL (i.e. <c>nullptr</c>) should be usable with handle types.
        /// </summary>
        public bool UseDSL { get; init; }
    }

    /// <inheritdoc />
    public override Task<GeneratedSyntax> AfterScrapeAsync(string key, GeneratedSyntax syntax)
    {
        var cfg = config.Get(key);
        var firstPass = new TypeDiscoverer();
        foreach (var (_, node) in syntax.Files)
        {
            firstPass.Visit(node);
        }

        Dictionary<string, SyntaxNode>? missingFullyQualifiedTypeNamesToRootNodes =
            cfg.AssumeMissingTypesOpaque ? [] : null;
        var handles = firstPass.GetHandleTypes(missingFullyQualifiedTypeNamesToRootNodes);
        if (missingFullyQualifiedTypeNamesToRootNodes is not null)
        {
            foreach (var (fqTypeName, node) in missingFullyQualifiedTypeNamesToRootNodes)
            {
                syntax.Files[$"sources/Handles/{PathForFullyQualified(fqTypeName)}"] = node;
            }
        }

        var rewriter = new Rewriter(handles, cfg.UseDSL);
        syntax = syntax with
        {
            Files = syntax.Files.ToDictionary(
                x =>
                {
                    var effectiveName = ModUtils.GetEffectiveName(x.Key).ToString();
                    if (!handles.ContainsKey(effectiveName))
                    {
                        return x.Key;
                    }

                    syntax.Files.Remove(x.Key);
                    return x.Key.Replace(effectiveName, $"{effectiveName}Handle");
                },
                x => rewriter.Visit(x.Value)
            )
        };

        return Task.FromResult(syntax);
    }

    class TypeDiscoverer : CSharpSyntaxWalker
    {
        /// <summary>
        /// A map of type names to a map of scopes that reference that type name and whether it was referenced as a
        /// pointer.
        /// </summary>
        private Dictionary<string, Dictionary<string, bool>> _referencedTypes = new();

        /// <summary>
        /// A map of parent scopes to types declared within that scope and whether they are an empty struct.
        /// </summary>
        private Dictionary<string, Dictionary<string, bool>> _declaredTypes = new();

        /// <summary>
        /// The current scope i.e. fully qualified type name.
        /// </summary>
        private string _currentScope = string.Empty;

        private bool _isPointerType;

        private void VisitType<T>(T type, SyntaxToken identifier, Action<T> @base)
            where T : SyntaxNode
        {
            var before = _currentScope;
            if (!_declaredTypes.TryGetValue(_currentScope, out var v))
            {
                _declaredTypes[_currentScope] = v = [];
            }

            v.Add(
                identifier.ToString(),
                type is StructDeclarationSyntax s
                    && !s.Members.OfType<BaseFieldDeclarationSyntax>().Any()
            );
            _currentScope = string.IsNullOrWhiteSpace(_currentScope)
                ? $"{type.NamespaceFromSyntaxNode()}.{identifier}"
                : $"{_currentScope}.{identifier}";
            @base(type);
            _currentScope = before;
        }

        // We restrict the allowed parents to hopefully avoid mistaking references to e.g. variable names as type
        // references.
        internal static bool SkipTypeNode(SyntaxNode node) =>
            node.Parent
                is not (
                        TypeSyntax
                        or BaseParameterSyntax
                        or BaseMethodDeclarationSyntax
                        or VariableDeclarationSyntax
                    )
                    or QualifiedNameSyntax;

        public override void VisitPointerType(PointerTypeSyntax node)
        {
            if (SkipTypeNode(node))
            {
                return;
            }
            var before = _isPointerType;
            _isPointerType = true;
            base.VisitPointerType(node);
            _isPointerType = before;
        }

        public override void VisitGenericName(GenericNameSyntax node) { }

        public override void VisitAttributeList(AttributeListSyntax node) { }

        public override void VisitIdentifierName(IdentifierNameSyntax node)
        {
            if (SkipTypeNode(node) || node.IsNint || node.IsNuint)
            {
                return;
            }

            if (
                !_referencedTypes.TryGetValue(node.Identifier.ToString(), out var referencingScopes)
            )
            {
                _referencedTypes[node.Identifier.ToString()] = referencingScopes = [];
            }

            referencingScopes[_currentScope] =
                _isPointerType && (!referencingScopes.TryGetValue(_currentScope, out var v) || v);
        }

        public override void VisitStructDeclaration(StructDeclarationSyntax node) =>
            VisitType(node, node.Identifier, base.VisitStructDeclaration);

        public override void VisitClassDeclaration(ClassDeclarationSyntax node) =>
            VisitType(node, node.Identifier, base.VisitClassDeclaration);

        public override void VisitRecordDeclaration(RecordDeclarationSyntax node) =>
            VisitType(node, node.Identifier, base.VisitRecordDeclaration);

        public override void VisitEnumDeclaration(EnumDeclarationSyntax node) =>
            VisitType(node, node.Identifier, base.VisitEnumDeclaration);

        public override void VisitDelegateDeclaration(DelegateDeclarationSyntax node) =>
            VisitType(node, node.Identifier, base.VisitDelegateDeclaration);

        public override void VisitInterfaceDeclaration(InterfaceDeclarationSyntax node) =>
            VisitType(node, node.Identifier, base.VisitInterfaceDeclaration);

        public Dictionary<string, Dictionary<string, string>> GetHandleTypes(
            Dictionary<string, SyntaxNode>? missingFullyQualifiedTypeNamesToRootNodes
        )
        {
            var typeNameToScopesAvailableToDeclaringScope =
                new Dictionary<string, Dictionary<string, string>>();

            // First, let's go through and remove the type references that can be resolved.
            RemoveResolvableTypeReferences(typeNameToScopesAvailableToDeclaringScope);

            if (missingFullyQualifiedTypeNamesToRootNodes is not null)
            {
                GenerateRemainingTypes(
                    typeNameToScopesAvailableToDeclaringScope,
                    missingFullyQualifiedTypeNamesToRootNodes
                );
            }

            _referencedTypes.Clear();
            _declaredTypes.Clear();
            return typeNameToScopesAvailableToDeclaringScope;
        }

        private void RemoveResolvableTypeReferences(
            // ReSharper disable once SuggestBaseTypeForParameter
            Dictionary<
                string,
                Dictionary<string, string>
            > typeNameToScopesAvailableToDeclaringScope
        )
        {
            foreach (var (typeName, scopeAndIsPointer) in _referencedTypes)
            {
                var reloop = true; // <-- this is used to get around the whole "can't mutate while iterating" issue
                while (reloop)
                {
                    reloop = false;
                    foreach (var (scope, _) in scopeAndIsPointer.OrderBy(x => x.Key.Length))
                    {
                        // First, we find the scope in which the type is declared. This is expected to be within the
                        // reach of the current scope per the documentation remarks on the mod class.
                        var scopeSpan = scope.AsSpan();
                        string? declaringScope = null;
                        var isEmpty = false;

                        // For each parent scope...
                        for (
                            var i = scopeSpan.Length;
                            i != -1;
                            i = scopeSpan.LastIndexOf('.'),
                                scopeSpan = i == -1 ? default : scopeSpan[..i]
                        )
                        {
                            var thisScope = scopeSpan.ToString();
                            if (
                                !_declaredTypes.TryGetValue(
                                    thisScope,
                                    out var declaredTypesToIsEmpty
                                ) || !declaredTypesToIsEmpty.TryGetValue(typeName, out isEmpty)
                            )
                            {
                                continue;
                            }

                            // If we have a found a declaration in the parent scope, this is the declaring scope.
                            declaringScope = thisScope;
                            break;
                        }

                        // The above for loop won't check the global scope, so let's check it now.
                        if (
                            declaringScope is null
                            && _declaredTypes.TryGetValue("", out var globalDeclTypesToIsEmpty)
                            && globalDeclTypesToIsEmpty.TryGetValue(typeName, out isEmpty)
                        )
                        {
                            declaringScope = string.Empty;
                        }

                        if (declaringScope is null)
                        {
                            // Type does not exist, keep in the reference list.
                            continue;
                        }

                        var isHandle =
                            isEmpty
                            && scopeAndIsPointer
                                .Where(x => x.Key.StartsWith(declaringScope))
                                .All(x => x.Value);
                        reloop = true;
                        while (reloop)
                        {
                            reloop = false;
                            foreach (var relatedScope in scopeAndIsPointer.Keys)
                            {
                                if (!relatedScope.StartsWith(declaringScope))
                                {
                                    // Not related.
                                    continue;
                                }

                                scopeAndIsPointer.Remove(relatedScope);
                                if (isHandle)
                                {
                                    if (
                                        !typeNameToScopesAvailableToDeclaringScope.TryGetValue(
                                            typeName,
                                            out var scopesAvailableToDeclaringScope
                                        )
                                    )
                                    {
                                        typeNameToScopesAvailableToDeclaringScope[typeName] =
                                            scopesAvailableToDeclaringScope = [];
                                    }

                                    scopesAvailableToDeclaringScope[relatedScope] = declaringScope;
                                }

                                reloop = true;
                                break;
                            }
                        }

                        reloop = true;
                        break;
                    }
                }
            }
        }

        private void GenerateRemainingTypes(
            Dictionary<
                string,
                Dictionary<string, string>
            > typeNameToScopesAvailableToDeclaringScope,
            Dictionary<string, SyntaxNode> missingFullyQualifiedTypeNamesToRootNodes
        )
        {
            foreach (var (typeName, scopeAndIsPointer) in _referencedTypes)
            {
                if (scopeAndIsPointer.Count == 0 || scopeAndIsPointer.Any(x => !x.Value))
                {
                    continue;
                }

                var destNs = NameUtils
                    .FindCommonPrefix(
                        scopeAndIsPointer
                            .Keys.Select(x =>
                                // Get the parent scopes because each scope is actually the fully qualified type name,
                                // not the namespace
                                x[..(x.LastIndexOf('.') is var i && i == -1 ? x.Length : i)]
                            )
                            .ToArray(),
                        true,
                        false,
                        true
                    )
                    .Trim('.');
                var fq = string.IsNullOrWhiteSpace(destNs) ? typeName : $"{destNs}.{typeName}";
                var s = StructDeclaration(typeName)
                    .WithModifiers(
                        TokenList(
                            Token(SyntaxKind.PublicKeyword),
                            Token(SyntaxKind.UnsafeKeyword),
                            Token(SyntaxKind.PartialKeyword)
                        )
                    );
                if (
                    !typeNameToScopesAvailableToDeclaringScope.TryGetValue(
                        typeName,
                        out var scopesAvailableToDeclaringScope
                    )
                )
                {
                    typeNameToScopesAvailableToDeclaringScope[typeName] =
                        scopesAvailableToDeclaringScope = [];
                }

                foreach (var scope in scopeAndIsPointer.Keys)
                {
                    scopesAvailableToDeclaringScope[scope] = destNs;
                }

                missingFullyQualifiedTypeNamesToRootNodes[fq] = CompilationUnit()
                    .WithMembers(
                        SingletonList<MemberDeclarationSyntax>(
                            string.IsNullOrWhiteSpace(destNs)
                                ? s
                                : FileScopedNamespaceDeclaration(
                                        ModUtils.NamespaceIntoIdentifierName(destNs)
                                    )
                                    .WithMembers(SingletonList<MemberDeclarationSyntax>(s))
                        )
                    );
            }
        }
    }

    class Rewriter(Dictionary<string, Dictionary<string, string>> handles, bool useDSL)
        : CSharpSyntaxRewriter
    {
        /// <summary>
        /// The current scope i.e. fully qualified type name.
        /// </summary>
        private string _currentScope = string.Empty;

        private bool _isPointerType;
        private bool _derefPtr;

        private SyntaxNode? VisitType<T>(T type, SyntaxToken identifier, Func<T, SyntaxNode?> @base)
            where T : SyntaxNode
        {
            var before = _currentScope;
            _currentScope = string.IsNullOrWhiteSpace(_currentScope)
                ? $"{type.NamespaceFromSyntaxNode()}.{identifier}"
                : $"{_currentScope}.{identifier}";
            var ret = @base(type);
            _currentScope = before;
            return ret;
        }

        public override SyntaxNode? VisitPointerType(PointerTypeSyntax node)
        {
            if (TypeDiscoverer.SkipTypeNode(node))
            {
                return node;
            }
            var before = _isPointerType;
            _isPointerType = true;
            var ret = base.VisitPointerType(node);
            _isPointerType = before;
            if (_derefPtr && ret is PointerTypeSyntax ptr)
            {
                ret = ptr.ElementType;
            }

            _derefPtr = false;
            return ret;
        }

        public override SyntaxNode VisitGenericName(GenericNameSyntax node) => node;

        public override SyntaxNode VisitIdentifierName(IdentifierNameSyntax node)
        {
            if (TypeDiscoverer.SkipTypeNode(node))
            {
                return node;
            }

            _derefPtr =
                handles.TryGetValue(node.Identifier.ToString(), out var applicableScopes)
                && applicableScopes.ContainsKey(_currentScope);
            return _derefPtr ? node.WithIdentifier(Identifier($"{node.Identifier}Handle")) : node;
        }

        public override SyntaxNode? VisitStructDeclaration(StructDeclarationSyntax node)
        {
            if (
                handles.TryGetValue(node.Identifier.ToString(), out var scopes)
                && scopes.ContainsValue(node.NamespaceFromSyntaxNode())
            )
            {
                var self = $"{node.Identifier}Handle";
                return node.WithIdentifier(Identifier(self))
                    .WithMembers(
                        List(
                            GetDefaultMembers(self).Concat(useDSL ? GetDSLImplementation(self) : [])
                        )
                    )
                    .WithModifiers(
                        TokenList(
                            Token(SyntaxKind.PublicKeyword),
                            Token(SyntaxKind.ReadOnlyKeyword),
                            Token(SyntaxKind.UnsafeKeyword),
                            Token(SyntaxKind.PartialKeyword)
                        )
                    );
            }

            return VisitType(node, node.Identifier, base.VisitStructDeclaration);
        }

        public override SyntaxNode? VisitClassDeclaration(ClassDeclarationSyntax node) =>
            VisitType(node, node.Identifier, base.VisitClassDeclaration);

        public override SyntaxNode? VisitRecordDeclaration(RecordDeclarationSyntax node) =>
            VisitType(node, node.Identifier, base.VisitRecordDeclaration);

        public override SyntaxNode? VisitEnumDeclaration(EnumDeclarationSyntax node) =>
            VisitType(node, node.Identifier, base.VisitEnumDeclaration);

        public override SyntaxNode? VisitDelegateDeclaration(DelegateDeclarationSyntax node) =>
            VisitType(node, node.Identifier, base.VisitDelegateDeclaration);

        public override SyntaxNode? VisitInterfaceDeclaration(InterfaceDeclarationSyntax node) =>
            VisitType(node, node.Identifier, base.VisitInterfaceDeclaration);

        private static IEnumerable<MemberDeclarationSyntax> GetDefaultMembers(string self)
        {
            yield return FieldDeclaration(
                    VariableDeclaration(
                        PointerType(PredefinedType(Token(SyntaxKind.VoidKeyword))),
                        SingletonSeparatedList(VariableDeclarator("Handle"))
                    )
                )
                .WithModifiers(
                    TokenList(Token(SyntaxKind.PublicKeyword), Token(SyntaxKind.ReadOnlyKeyword))
                );
            yield return MethodDeclaration(
                    PredefinedType(Token(SyntaxKind.BoolKeyword)),
                    Identifier("Equals")
                )
                .WithModifiers(TokenList(Token(SyntaxKind.PublicKeyword)))
                .WithParameterList(
                    ParameterList(
                        SingletonSeparatedList(
                            Parameter(Identifier("other")).WithType(IdentifierName(self))
                        )
                    )
                )
                .WithExpressionBody(
                    ArrowExpressionClause(
                        BinaryExpression(
                            SyntaxKind.EqualsExpression,
                            IdentifierName("Handle"),
                            MemberAccessExpression(
                                SyntaxKind.SimpleMemberAccessExpression,
                                IdentifierName("other"),
                                IdentifierName("Handle")
                            )
                        )
                    )
                )
                .WithSemicolonToken(Token(SyntaxKind.SemicolonToken));
            yield return MethodDeclaration(
                    PredefinedType(Token(SyntaxKind.BoolKeyword)),
                    Identifier("Equals")
                )
                .WithModifiers(
                    TokenList([Token(SyntaxKind.PublicKeyword), Token(SyntaxKind.OverrideKeyword)])
                )
                .WithParameterList(
                    ParameterList(
                        SingletonSeparatedList(
                            Parameter(Identifier("obj"))
                                .WithType(
                                    NullableType(PredefinedType(Token(SyntaxKind.ObjectKeyword)))
                                )
                        )
                    )
                )
                .WithExpressionBody(
                    ArrowExpressionClause(
                        BinaryExpression(
                            SyntaxKind.LogicalAndExpression,
                            IsPatternExpression(
                                IdentifierName("obj"),
                                DeclarationPattern(
                                    IdentifierName(self),
                                    SingleVariableDesignation(Identifier("other"))
                                )
                            ),
                            InvocationExpression(IdentifierName("Equals"))
                                .WithArgumentList(
                                    ArgumentList(
                                        SingletonSeparatedList(Argument(IdentifierName("other")))
                                    )
                                )
                        )
                    )
                )
                .WithSemicolonToken(Token(SyntaxKind.SemicolonToken));
            yield return MethodDeclaration(
                    PredefinedType(Token(SyntaxKind.IntKeyword)),
                    Identifier("GetHashCode")
                )
                .WithModifiers(
                    TokenList([Token(SyntaxKind.PublicKeyword), Token(SyntaxKind.OverrideKeyword)])
                )
                .WithExpressionBody(
                    ArrowExpressionClause(
                        InvocationExpression(
                                MemberAccessExpression(
                                    SyntaxKind.SimpleMemberAccessExpression,
                                    IdentifierName("HashCode"),
                                    IdentifierName("Combine")
                                )
                            )
                            .WithArgumentList(
                                ArgumentList(
                                    SingletonSeparatedList(
                                        Argument(
                                            CastExpression(
                                                IdentifierName("nuint"),
                                                IdentifierName("Handle")
                                            )
                                        )
                                    )
                                )
                            )
                    )
                )
                .WithSemicolonToken(Token(SyntaxKind.SemicolonToken));
            yield return OperatorDeclaration(
                    PredefinedType(Token(SyntaxKind.BoolKeyword)),
                    Token(SyntaxKind.EqualsEqualsToken)
                )
                .WithModifiers(
                    TokenList([Token(SyntaxKind.PublicKeyword), Token(SyntaxKind.StaticKeyword)])
                )
                .WithParameterList(
                    ParameterList(
                        SeparatedList<ParameterSyntax>(
                            new SyntaxNodeOrToken[]
                            {
                                Parameter(Identifier("left")).WithType(IdentifierName(self)),
                                Token(SyntaxKind.CommaToken),
                                Parameter(Identifier("right")).WithType(IdentifierName(self))
                            }
                        )
                    )
                )
                .WithExpressionBody(
                    ArrowExpressionClause(
                        InvocationExpression(
                                MemberAccessExpression(
                                    SyntaxKind.SimpleMemberAccessExpression,
                                    IdentifierName("left"),
                                    IdentifierName("Equals")
                                )
                            )
                            .WithArgumentList(
                                ArgumentList(
                                    SingletonSeparatedList(Argument(IdentifierName("right")))
                                )
                            )
                    )
                )
                .WithSemicolonToken(Token(SyntaxKind.SemicolonToken));
            yield return OperatorDeclaration(
                    PredefinedType(Token(SyntaxKind.BoolKeyword)),
                    Token(SyntaxKind.ExclamationEqualsToken)
                )
                .WithModifiers(
                    TokenList([Token(SyntaxKind.PublicKeyword), Token(SyntaxKind.StaticKeyword)])
                )
                .WithParameterList(
                    ParameterList(
                        SeparatedList(
                            [
                                Parameter(Identifier("left")).WithType(IdentifierName(self)),
                                Parameter(Identifier("right")).WithType(IdentifierName(self))
                            ]
                        )
                    )
                )
                .WithExpressionBody(
                    ArrowExpressionClause(
                        PrefixUnaryExpression(
                            SyntaxKind.LogicalNotExpression,
                            InvocationExpression(
                                    MemberAccessExpression(
                                        SyntaxKind.SimpleMemberAccessExpression,
                                        IdentifierName("left"),
                                        IdentifierName("Equals")
                                    )
                                )
                                .WithArgumentList(
                                    ArgumentList(
                                        SingletonSeparatedList(Argument(IdentifierName("right")))
                                    )
                                )
                        )
                    )
                )
                .WithSemicolonToken(Token(SyntaxKind.SemicolonToken));
        }

        private static IEnumerable<MemberDeclarationSyntax> GetDSLImplementation(string self)
        {
            yield return MethodDeclaration(
                    PredefinedType(Token(SyntaxKind.BoolKeyword)),
                    Identifier("Equals")
                )
                .WithModifiers(TokenList(Token(SyntaxKind.PublicKeyword)))
                .WithParameterList(
                    ParameterList(
                        SingletonSeparatedList(
                            Parameter(Identifier("_")).WithType(IdentifierName("NullPtr"))
                        )
                    )
                )
                .WithExpressionBody(
                    ArrowExpressionClause(
                        IsPatternExpression(
                            IdentifierName("Handle"),
                            ConstantPattern(LiteralExpression(SyntaxKind.NullLiteralExpression))
                        )
                    )
                )
                .WithSemicolonToken(Token(SyntaxKind.SemicolonToken));
            yield return OperatorDeclaration(
                    PredefinedType(Token(SyntaxKind.BoolKeyword)),
                    Token(SyntaxKind.EqualsEqualsToken)
                )
                .WithModifiers(
                    TokenList([Token(SyntaxKind.PublicKeyword), Token(SyntaxKind.StaticKeyword)])
                )
                .WithParameterList(
                    ParameterList(
                        SeparatedList<ParameterSyntax>(
                            new SyntaxNodeOrToken[]
                            {
                                Parameter(Identifier("left")).WithType(IdentifierName(self)),
                                Token(SyntaxKind.CommaToken),
                                Parameter(Identifier("right")).WithType(IdentifierName("NullPtr"))
                            }
                        )
                    )
                )
                .WithExpressionBody(
                    ArrowExpressionClause(
                        InvocationExpression(
                                MemberAccessExpression(
                                    SyntaxKind.SimpleMemberAccessExpression,
                                    IdentifierName("left"),
                                    IdentifierName("Equals")
                                )
                            )
                            .WithArgumentList(
                                ArgumentList(
                                    SingletonSeparatedList(Argument(IdentifierName("right")))
                                )
                            )
                    )
                )
                .WithSemicolonToken(Token(SyntaxKind.SemicolonToken));
            yield return OperatorDeclaration(
                    PredefinedType(Token(SyntaxKind.BoolKeyword)),
                    Token(SyntaxKind.ExclamationEqualsToken)
                )
                .WithModifiers(
                    TokenList([Token(SyntaxKind.PublicKeyword), Token(SyntaxKind.StaticKeyword)])
                )
                .WithParameterList(
                    ParameterList(
                        SeparatedList(
                            [
                                Parameter(Identifier("left")).WithType(IdentifierName(self)),
                                Parameter(Identifier("right")).WithType(IdentifierName("NullPtr"))
                            ]
                        )
                    )
                )
                .WithExpressionBody(
                    ArrowExpressionClause(
                        PrefixUnaryExpression(
                            SyntaxKind.LogicalNotExpression,
                            InvocationExpression(
                                    MemberAccessExpression(
                                        SyntaxKind.SimpleMemberAccessExpression,
                                        IdentifierName("left"),
                                        IdentifierName("Equals")
                                    )
                                )
                                .WithArgumentList(
                                    ArgumentList(
                                        SingletonSeparatedList(Argument(IdentifierName("right")))
                                    )
                                )
                        )
                    )
                )
                .WithSemicolonToken(Token(SyntaxKind.SemicolonToken));
            yield return ConversionOperatorDeclaration(
                    Token(SyntaxKind.ImplicitKeyword),
                    IdentifierName(self)
                )
                .WithModifiers(
                    TokenList([Token(SyntaxKind.PublicKeyword), Token(SyntaxKind.StaticKeyword)])
                )
                .WithParameterList(
                    ParameterList(
                        SingletonSeparatedList(
                            Parameter(
                                    Identifier(
                                        TriviaList(),
                                        SyntaxKind.UnderscoreToken,
                                        "_",
                                        "_",
                                        TriviaList()
                                    )
                                )
                                .WithType(IdentifierName("NullPtr"))
                        )
                    )
                )
                .WithExpressionBody(
                    ArrowExpressionClause(LiteralExpression(SyntaxKind.DefaultLiteralExpression))
                )
                .WithSemicolonToken(Token(SyntaxKind.SemicolonToken));
        }
    }
}
