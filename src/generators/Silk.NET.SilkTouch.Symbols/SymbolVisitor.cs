// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Collections.Immutable;

namespace Silk.NET.SilkTouch.Symbols;

/// <summary>
/// Implements a base visitor to extend when rewriting or otherwise searching through a <see cref="Symbol"/>
/// </summary>
public abstract class SymbolVisitor
{
    /// <summary>
    /// Visit a <see cref="Symbol"/>. This will call the appropriate method based on the actual type of the <paramref name="symbol"/>
    /// </summary>
    /// <param name="symbol">The symbol to visit</param>
    /// <returns>The rewritten symbol. May be equal to the original symbol of no rewriting has taken place.</returns>
    public virtual Symbol Visit(Symbol symbol)
    {
        if (symbol is TypeSymbol ts) return VisitType(ts);
        if (symbol is MemberSymbol ms) return VisitMember(ms);
        if (symbol is NamespaceSymbol ns) return VisitNamespace(ns);

        if (symbol is IdentifierSymbol @is) return VisitIdentifier(@is);
        if (symbol is TypeReference etr) return VisitTypeReference(etr); 

        return ThrowUnknownSymbol<Symbol>(symbol);
    }

    /// <summary>
    /// Visit a <see cref="MemberSymbol"/>. This will call the appropriate method based on the actual type of the <paramref name="memberSymbol"/>
    /// </summary>
    /// <param name="memberSymbol">The member symbol to visit</param>
    /// <returns>The rewritten symbol</returns>
    /// <seealso cref="VisitField"/>
    protected virtual MemberSymbol VisitMember(MemberSymbol memberSymbol)
    {
        if (memberSymbol is FieldSymbol fs) return VisitField(fs);
        
        return ThrowUnknownSymbol<MemberSymbol>(memberSymbol);
    }

    /// <summary>
    /// Visit a <see cref="FieldSymbol"/>. Will call the appropriate methods to visit the different parts of the field.
    /// </summary>
    /// <param name="fieldSymbol">The field symbol to visit</param>
    /// <returns>The rewritten symbol</returns>
    /// <remarks>
    /// The order in which the parts of the struct are visited is kept as an implementation detail. Do not rely on this order.
    /// </remarks>
    protected virtual FieldSymbol VisitField(FieldSymbol fieldSymbol)
    {
        return new FieldSymbol(VisitTypeReference(fieldSymbol.Type), VisitIdentifier(fieldSymbol.Identifier));
    }
    
    /// <summary>
    /// Visit a <see cref="TypeReference"/>. Will call the appropriate methods to visit the different parts of the symbol.
    /// </summary>
    /// <param name="typeReference">The type reference to visit</param>
    /// <returns>The rewritten symbol</returns>
    /// <remarks>
    /// The order in which the parts of the struct are visited is kept as an implementation detail. Do not rely on this order.
    /// </remarks>
    protected virtual TypeReference VisitTypeReference(TypeReference typeReference)
    {
        if (typeReference is ExternalTypeReference etr) return VisitExternalTypeReference(etr);
        if (typeReference is InternalTypeReference itr) return VisitInternalTypeReference(itr);
        return ThrowUnknownSymbol<TypeReference>(typeReference);
    }
    
    /// <summary>
    /// Visit a <see cref="InternalTypeReference"/>. Will call the appropriate methods to visit the different parts of the symbol.
    /// </summary>
    /// <param name="typeReference">The type reference to visit</param>
    /// <returns>The rewritten symbol</returns>
    /// <remarks>
    /// The order in which the parts of the struct are visited is kept as an implementation detail. Do not rely on this order.
    /// </remarks>
    protected virtual InternalTypeReference VisitInternalTypeReference(InternalTypeReference typeReference)
    {
        return new InternalTypeReference(VisitType(typeReference.Referenced));
    }
    
    /// <summary>
    /// Visit a <see cref="ExternalTypeReference"/>. Will call the appropriate methods to visit the different parts of the symbol.
    /// </summary>
    /// <param name="typeReference">The type reference to visit</param>
    /// <returns>The rewritten symbol</returns>
    /// <remarks>
    /// The order in which the parts of the struct are visited is kept as an implementation detail. Do not rely on this order.
    /// </remarks>
    protected virtual ExternalTypeReference VisitExternalTypeReference(ExternalTypeReference typeReference)
    {
        return new ExternalTypeReference
        (
            typeReference.Namespace is not null ? VisitIdentifier(typeReference.Namespace) : null,
            VisitIdentifier(typeReference.TypeIdentifier)
        );
    }

    /// <summary>
    /// Visit a <see cref="TypeSymbol"/>. This will call the appropriate method based on the actual type of the <paramref name="typeSymbol"/>
    /// </summary>
    /// <param name="typeSymbol">The type symbol to visit</param>
    /// <returns>The rewritten symbol</returns>
    /// <seealso cref="VisitStruct"/>
    protected virtual TypeSymbol VisitType(TypeSymbol typeSymbol)
    {
        if (typeSymbol is StructSymbol @struct) return VisitStruct(@struct);

        return ThrowUnknownSymbol<TypeSymbol>(typeSymbol);
    }
    
    /// <summary>
    /// Visit a <see cref="StructSymbol"/>. Will call the appropriate methods to visit the different parts of the struct.
    /// </summary>
    /// <param name="structSymbol">The struct symbol to visit</param>
    /// <returns>The rewritten symbol</returns>
    /// <seealso cref="VisitType"/>
    /// <remarks>
    /// The order in which the parts of the struct are visited is kept as an implementation detail. Do not rely on this order.
    /// </remarks>
    protected virtual StructSymbol VisitStruct(StructSymbol structSymbol)
    {
        return new StructSymbol
        (
            VisitIdentifier(structSymbol.Identifier),
            structSymbol.Fields.Select(VisitField).ToImmutableArray()
        );
    }

    /// <summary>
    /// Visit an <see cref="IdentifierSymbol"/>.
    /// </summary>
    /// <param name="identifierSymbol">The Identifier to Visit</param>
    /// <returns>The rewritten symbol</returns>
    protected virtual IdentifierSymbol VisitIdentifier(IdentifierSymbol identifierSymbol)
    {
        return identifierSymbol;
    }

    /// <summary>
    /// Visit a <see cref="NamespaceSymbol"/>.
    /// </summary>
    /// <param name="namespaceSymbol">The Namespace to Visit.</param>
    /// <returns>The rewritten symbol</returns>
    protected virtual NamespaceSymbol VisitNamespace(NamespaceSymbol namespaceSymbol)
    {
        return namespaceSymbol with
        {
            Identifier = VisitIdentifier(namespaceSymbol.Identifier),
            Types = namespaceSymbol.Types.Select(VisitType).ToImmutableArray()
        };
    }

    private static T ThrowUnknownSymbol<T>(Symbol symbol)
    {
        throw new NotImplementedException($"Unknown symbol of type {symbol.GetType().FullName} subclass of {typeof(T).Name}");
    }
}
