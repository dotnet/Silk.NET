// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Collections;
using System.Diagnostics;
using Microsoft.Extensions.Logging;
using Silk.NET.SilkTouch.Symbols;
using Silk.NET.SilkTouch.TypeResolution.Annotations;

namespace Silk.NET.SilkTouch.TypeResolution;

/// <summary>
/// A <see cref="SymbolVisitor"/> used to resolve <see cref="UnresolvedTypeReference"/>s. Requires a <see cref="TypeResolutionScope"/> typically created by <see cref="TypeScopeSymbolVisitor"/>
/// </summary>
/// <remarks>
/// This is the "base" type resolver, it is intended to resolve unresolved type refs with a text of a.b.c.d.e where
/// a.b.c.d.e is somewhere in the parent tree.
/// For example, this will handle a tree such as:
/// Type Identifier='a'
/// -> Type Identifier='b'
/// -> Type Identifier='c'
///    -> Type Identifier='d'
///       -> Type Identifier='e'
///    -> Type Identifier='f'
/// Then 'f' references 'd' using 'a.c.d' or, as it itself is a child of 'c', it may also write 'c.d' or, as they are on the same level, just 'd'.
/// Multiple types with the same name in one tree are of course allowed, in such a case we simply use the closest one in the tree that matches.
/// Resolution is done by
/// - checking the current type scope downwards for a matching name (this only considers direct children)
/// - traversing the tree upwards and then checking the new scope downwards for a matching name.
/// </remarks>
public sealed class NameResolverSymbolVisitor : SymbolVisitor
{
    private readonly ILogger _logger;
    private readonly TypeResolutionScope _rootScope;
    private TypeResolutionScope _currentScope;
    private Stack<TypeResolutionScope> _seenScopes = new();
    /// <summary>
    /// Creates the <see cref="NameResolverSymbolVisitor"/> using a scope used as root.
    /// </summary>
    /// <param name="logger">A logger used for diagnostic purposes</param>
    /// <param name="rootScope">The <see cref="TypeResolutionScope"/> used as root</param>
    /// <param name="typeStore">The <see cref="TypeStore"/> used</param>
    public NameResolverSymbolVisitor(ILogger<NameResolverSymbolVisitor> logger, TypeResolutionScope rootScope, TypeStore typeStore) : base(typeStore)
    {
        _logger = logger;
        _rootScope = rootScope;
        _currentScope = rootScope;
    }

    /// <inheritdoc />
    protected override TypeSymbol VisitType(TypeSymbol typeSymbol)
    {
        var startLength = _seenScopes.Count;
        _seenScopes.Push(_currentScope);
        _currentScope = _currentScope.ChildTypeScopes[typeSymbol.Id];
        var result = base.VisitType(typeSymbol);
        _currentScope = _seenScopes.Pop();
        Debug.Assert(_seenScopes.Count == startLength);
        return result;
    }

    /// <inheritdoc />
    protected override TypeReference VisitTypeReference(TypeReference typeReference)
    {
        if (typeReference is UnresolvedTypeReference utr)
        {
            _logger.LogTrace("Attempting to resolve \"{text}\" to an internal reference", utr.Text);
            if (TryFindMatchingType(_currentScope, utr.Text, out var foundDirectChild))
            {
                _logger.LogTrace("Resolved to direct child {type}", foundDirectChild);
                return new InternalTypeReference(foundDirectChild!.Id, utr.Annotations);
            }
            
            // note: iterating a stack is ordered, just like repeatedly calling .Pop(), but doesn't disturb contents.
            foreach (var scope in _seenScopes)
            {
                if (TryFindMatchingType(scope, utr.Text, out var foundChild))
                {
                    _logger.LogTrace
                    (
                        "Successfully resolved \"{text}\" to internal type {type}",
                        utr.Text,
                        foundChild
                    );
                    return new InternalTypeReference
                    (
                        foundChild!.Id,
                        utr.Annotations.ReplaceOrAdd
                            (x => x is ResolvedFromAnnotation, new ResolvedFromAnnotation(utr.Text))
                    );
                }
            }

            return utr;
        }
        return base.VisitTypeReference(typeReference);
    }

    private bool TryFindMatchingType(TypeResolutionScope rootScope, string text, out TypeSymbol? foundChild)
    {
        // this method "recursively" builds the candidate type names and see if anything matches.
        Stack<(string, TypeResolutionScope)> todo = new Stack<(string, TypeResolutionScope)>();
        todo.Push(("", rootScope));

        while (todo.Count > 0)
        {
            var (prefix, scope) = todo.Pop();

            foreach (var v in scope.ChildTypeScopes)
            {
                var typeId = v.Key;
                if (!TypeStore.TryResolve(typeId, out var type))
                {
                    _logger.LogWarning("Failed to resolve Type ID {id}", typeId);
                    continue;
                }
                Debug.Assert(type is not null);

                var fullName = prefix + type!.Identifier.Value;
                if (fullName == text)
                {
                    foundChild = type;
                    return true;
                }

                var newPrefix = fullName + ".";
                todo.Push((newPrefix, v.Value));
            }
        }
        
        foundChild = null;
        return false;
    }
}
