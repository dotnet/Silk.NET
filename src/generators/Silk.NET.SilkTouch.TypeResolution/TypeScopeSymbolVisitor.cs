// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Silk.NET.SilkTouch.Symbols;

namespace Silk.NET.SilkTouch.TypeResolution;

/// <summary>
/// A <see cref="SymbolVisitor"/> used to build a <see cref="TypeResolutionScope"/>
/// </summary>
public sealed class TypeScopeSymbolVisitor : SymbolVisitor
{
    /// <summary>
    /// The root scope, containing all visited types
    /// </summary>
    public TypeResolutionScope RootScope { get; }
    private TypeResolutionScope _currentScope;
    private TypeSymbol? _currentParent;

    /// <summary>
    /// Creates a <see cref="TypeScopeSymbolVisitor"/>
    /// </summary>
    /// <param name="typeStore">The <see cref="TypeStore"/> used</param>
    public TypeScopeSymbolVisitor(TypeStore typeStore) : base(typeStore)
    {
        RootScope = new(new());
        _currentScope = RootScope;
        _currentParent = null;
    }

    /// <inheritdoc />
    protected override TypeSymbol VisitType(TypeSymbol typeSymbol)
    {
        var newScope = new TypeResolutionScope(new());
        var oldScope = _currentScope;
        var oldParent = _currentParent;
        _currentScope.ChildTypeScopes[typeSymbol.Id] = newScope;
        _currentScope = newScope;
        _currentParent = typeSymbol;
        var result = base.VisitType(typeSymbol);
        _currentScope = oldScope;
        _currentParent = oldParent;
        return result;
    }

    /// <inheritdoc />
    protected override TypeReference VisitTypeReference(TypeReference typeReference)
    {
        if (typeReference is UnresolvedTypeReference)
            return typeReference;

        return base.VisitTypeReference(typeReference);
    }
}
