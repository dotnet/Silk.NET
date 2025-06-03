// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Silk.NET.SilkTouch.Naming;
using static Microsoft.CodeAnalysis.CSharp.SyntaxFactory;

namespace Silk.NET.SilkTouch.Mods.Scraping;

/// <summary>
/// This discovers "handle" types, which are structs that wrap an underlying opaque pointer.
/// </summary>
/// <remarks>
/// <para>
/// This was originally used by <see cref="TransformHandles"/>, but was moved out as a separate class
/// so that <see cref="ExtractNestedTyping"/> can share the functionality.
/// </para>
/// <para>
/// This works by looking for all type references and type declarations.
/// For type references, we track if the type if referenced as a pointer.
/// For type declarations, we track if the type was declared as an empty struct.
/// </para>
/// <para>
/// If a type is always referenced as a pointer, we conclude that the type is a handle type.
/// Additionally, if the handle type does not have a corresponding empty struct, we conclude that the handle type is
/// missing.
/// </para>
/// </remarks>
public class HandleTypeDiscoverer : CSharpSyntaxWalker
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
    /// Tracks the current scope i.e. fully qualified type name.
    /// </summary>
    private string _currentScope = string.Empty;

    /// <summary>
    /// Tracks if the currently visited type was referenced as a pointer.
    /// </summary>
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

    /// <inheritdoc />
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

    /// <inheritdoc />
    public override void VisitGenericName(GenericNameSyntax node) { }

    /// <inheritdoc />
    public override void VisitAttributeList(AttributeListSyntax node) { }

    /// <inheritdoc />
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

    /// <inheritdoc />
    public override void VisitStructDeclaration(StructDeclarationSyntax node) =>
        VisitType(node, node.Identifier, base.VisitStructDeclaration);

    /// <inheritdoc />
    public override void VisitClassDeclaration(ClassDeclarationSyntax node) =>
        VisitType(node, node.Identifier, base.VisitClassDeclaration);

    /// <inheritdoc />
    public override void VisitRecordDeclaration(RecordDeclarationSyntax node) =>
        VisitType(node, node.Identifier, base.VisitRecordDeclaration);

    /// <inheritdoc />
    public override void VisitEnumDeclaration(EnumDeclarationSyntax node) =>
        VisitType(node, node.Identifier, base.VisitEnumDeclaration);

    /// <inheritdoc />
    public override void VisitDelegateDeclaration(DelegateDeclarationSyntax node) =>
        VisitType(node, node.Identifier, base.VisitDelegateDeclaration);

    /// <inheritdoc />
    public override void VisitInterfaceDeclaration(InterfaceDeclarationSyntax node) =>
        VisitType(node, node.Identifier, base.VisitInterfaceDeclaration);

    /// <summary>
    /// Gets all discovered handle types, and optionally, any missing handle types.
    /// </summary>
    /// <param name="missingFullyQualifiedTypeNamesToRootNodes">If not null, this dictionary will be populated with syntax nodes for each missing handle type.</param>
    /// <returns>
    /// Dictionary containing discovered handle types.
    /// The keys are the names of the discovered handle types.
    /// The values are the fully qualified names of the types that reference that handle type and the namespace of those types.
    /// </returns>
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
