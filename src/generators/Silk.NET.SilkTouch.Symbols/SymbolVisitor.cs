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
    /// The <see cref="Silk.NET.SilkTouch.Symbols.TypeStore"/> used by this <see cref="SymbolVisitor"/>
    /// </summary>
    protected TypeStore TypeStore { get; }
    
    /// <summary>
    /// Creates a <see cref="SymbolVisitor"/> with it's dependencies.
    /// </summary>
    /// <param name="typeStore">The <see cref="Silk.NET.SilkTouch.Symbols.TypeStore"/> to use</param>
    public SymbolVisitor(TypeStore typeStore)
    {
        TypeStore = typeStore;
    }
    
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
        if (memberSymbol is MethodSymbol ms) return VisitMethod(ms);
        
        return ThrowUnknownSymbol<MemberSymbol>(memberSymbol);
    }

    /// <summary>
    /// Visit a <see cref="FieldSymbol"/>. Will call the appropriate methods to visit the different parts of the field.
    /// </summary>
    /// <param name="fieldSymbol">The field symbol to visit</param>
    /// <returns>The rewritten symbol</returns>
    /// <remarks>
    /// The order in which the parts are visited is kept as an implementation detail. Do not rely on this order.
    /// </remarks>
    protected virtual FieldSymbol VisitField(FieldSymbol fieldSymbol)
    {
        return new FieldSymbol(VisitTypeReference(fieldSymbol.Type), VisitIdentifier(fieldSymbol.Identifier), fieldSymbol.Annotations);
    }

    /// <summary>
    /// Visit a <see cref="MethodSymbol"/>. Will call the appropriate methods to visit the different parts of the symbol.
    /// </summary>
    /// <param name="methodSymbol">The method to visit</param>
    /// <returns>The rewritten symbol</returns>
    /// <remarks>
    /// The order in which the parts are visited is kept as an implementation detail. Do not rely on this order.
    /// </remarks>
    protected virtual MethodSymbol VisitMethod(MethodSymbol methodSymbol)
    {
        if (methodSymbol is StaticExternalMethodSymbol stms) return VisitStaticExternalMethod(stms);
        return ThrowUnknownSymbol<MethodSymbol>(methodSymbol);
    }

    /// <summary>
    /// Visit a <see cref="StaticExternalMethodSymbol"/>. Will call the appropriate methods to visit the different parts of the symbol.
    /// </summary>
    /// <param name="staticExternalMethodSymbol">The method to visit</param>
    /// <returns>The rewritten symbol</returns>
    /// <remarks>
    /// The order in which the parts are visited is kept as an implementation detail. Do not rely on this order.
    /// </remarks>
    protected virtual StaticExternalMethodSymbol VisitStaticExternalMethod
        (StaticExternalMethodSymbol staticExternalMethodSymbol)
    {
        return new StaticExternalMethodSymbol
        (
            VisitTypeReference(staticExternalMethodSymbol.ReturnType),
            staticExternalMethodSymbol.Parameters.Select
                    (x => new Parameter(VisitTypeReference(x.TypeReference), VisitIdentifier(x.Identifier)))
                .ToImmutableArray(),
            VisitIdentifier(staticExternalMethodSymbol.Identifier),
            staticExternalMethodSymbol.Annotations
        );
    }

    /// <summary>
    /// Visit a <see cref="TypeReference"/>. Will call the appropriate methods to visit the different parts of the symbol.
    /// </summary>
    /// <param name="typeReference">The type reference to visit</param>
    /// <returns>The rewritten symbol</returns>
    /// <remarks>
    /// The order in which the parts are visited is kept as an implementation detail. Do not rely on this order.
    /// </remarks>
    /// <remarks>
    /// By default visiting <see cref="UnresolvedTypeReference"/> will throw. Visitors involved in type resolution should override this method directly.
    /// </remarks>
    protected virtual TypeReference VisitTypeReference(TypeReference typeReference)
    {
        if (typeReference is ExternalTypeReference etr) return VisitExternalTypeReference(etr);
        if (typeReference is InternalTypeReference itr) return VisitInternalTypeReference(itr);
        if (typeReference is UnresolvedTypeReference utr) UnresolvedTypeReference.ThrowInvalidSymbol(utr);
        if (typeReference is PointerTypeReference ptr) return VisitPointerTypeReference(ptr);
        if (typeReference is FunctionPointerTypeReference fptr) return VisitFunctionPointerTypeReference(fptr);
        return ThrowUnknownSymbol<TypeReference>(typeReference);
    }
    
    /// <summary>
    /// Visit a <see cref="PointerTypeReference"/>. Will call the appropriate methods to visit the different parts of the symbol.
    /// </summary>
    /// <param name="pointerTypeReference">The pointer type reference to visit</param>
    /// <returns>The rewritten symbol</returns>
    /// <remarks>
    /// The order in which the parts are visited is kept as an implementation detail. Do not rely on this order.
    /// </remarks>
    protected virtual PointerTypeReference VisitPointerTypeReference(PointerTypeReference pointerTypeReference)
    {
        return new PointerTypeReference(VisitTypeReference(pointerTypeReference.Underlying), pointerTypeReference.Annotations);
    }
    /// <summary>
    /// Visit a <see cref="FunctionPointerTypeReference"/>. Will call the appropriate methods to visit the different parts of the symbol.
    /// </summary>
    /// <param name="functionPointerTypeReference">The function pointer type reference to visit</param>
    /// <returns>The rewritten symbol</returns>
    /// <remarks>
    /// The order in which the parts are visited is kept as an implementation detail. Do not rely on this order.
    /// </remarks>
    protected virtual FunctionPointerTypeReference VisitFunctionPointerTypeReference
        (FunctionPointerTypeReference functionPointerTypeReference)
    {
        return new FunctionPointerTypeReference
        (
            VisitTypeReference(functionPointerTypeReference.ReturnType),
            functionPointerTypeReference.ParameterTypes.Select(VisitTypeReference).ToImmutableArray(),
            functionPointerTypeReference.Annotations
        );
    }
    
    /// <summary>
    /// Visit a <see cref="InternalTypeReference"/>. Will call the appropriate methods to visit the different parts of the symbol.
    /// </summary>
    /// <param name="typeReference">The type reference to visit</param>
    /// <returns>The rewritten symbol</returns>
    /// <remarks>
    /// The order in which the parts are visited is kept as an implementation detail. Do not rely on this order.
    /// </remarks>
    protected virtual InternalTypeReference VisitInternalTypeReference(InternalTypeReference typeReference)
    {
        return new InternalTypeReference(VisitTypeId(typeReference.ReferencedTypeId), typeReference.Annotations);
    }
    
    /// <summary>
    /// Visit a <see cref="ExternalTypeReference"/>. Will call the appropriate methods to visit the different parts of the symbol.
    /// </summary>
    /// <param name="typeReference">The type reference to visit</param>
    /// <returns>The rewritten symbol</returns>
    /// <remarks>
    /// The order in which the parts are visited is kept as an implementation detail. Do not rely on this order.
    /// </remarks>
    protected virtual ExternalTypeReference VisitExternalTypeReference(ExternalTypeReference typeReference)
    {
        return new ExternalTypeReference
        (
            typeReference.Namespace is not null ? VisitIdentifier(typeReference.Namespace) : null,
            VisitIdentifier(typeReference.TypeIdentifier),
            typeReference.Annotations
        );
    }

    /// <summary>
    /// Called when a type is referenced by it's Id and should be visited. Implementers may resolve the Id if they to do so.
    /// The default implementation does not resolve the Id or call any further into the tree.
    /// </summary>
    /// <param name="id">The Id of the type</param>
    /// <returns>The new Id that should be used to reference this type</returns>
    protected virtual TypeId VisitTypeId(TypeId id)
    {
        return id;
    }

    /// <summary>
    /// Visit a <see cref="TypeSymbol"/>. This will call the appropriate method based on the actual type of the <paramref name="typeSymbol"/>.
    /// This will update the <see cref="TypeStore"/> with it's return value by default. Implementors overriding this should update the store themselves.
    /// </summary>
    /// <param name="typeSymbol">The type symbol to visit</param>
    /// <returns>The rewritten symbol</returns>
    /// <seealso cref="VisitStruct"/>
    protected virtual TypeSymbol VisitType(TypeSymbol typeSymbol)
    {
        TypeSymbol? result = null;
        if (typeSymbol is StructSymbol @struct) result = VisitStruct(@struct);
        else if (typeSymbol is ClassSymbol @class) result = VisitClass(@class);

        if (result is not null)
        {
            TypeStore.Store(result);
            return result;
        }

        return ThrowUnknownSymbol<TypeSymbol>(typeSymbol);
    }
    
    /// <summary>
    /// Visit a <see cref="ClassSymbol"/>. Will call the appropriate methods to visit the different parts of the class.
    /// </summary>
    /// <param name="classSymbol">The class symbol to visit</param>
    /// <returns>The rewritten symbol</returns>
    /// <seealso cref="VisitType"/>
    /// <remarks>
    /// The order in which the parts are visited is kept as an implementation detail. Do not rely on this order.
    /// </remarks>
    protected virtual ClassSymbol VisitClass(ClassSymbol classSymbol)
    {
        return new ClassSymbol
        (
            classSymbol.Id,
            VisitIdentifier(classSymbol.Identifier),
            classSymbol.Members.Select(VisitMember).ToImmutableArray(),
            classSymbol.Annotations
        );
    }
    
    /// <summary>
    /// Visit a <see cref="StructSymbol"/>. Will call the appropriate methods to visit the different parts of the struct.
    /// </summary>
    /// <param name="structSymbol">The struct symbol to visit</param>
    /// <returns>The rewritten symbol</returns>
    /// <seealso cref="VisitType"/>
    /// <remarks>
    /// The order in which the parts are visited is kept as an implementation detail. Do not rely on this order.
    /// </remarks>
    protected virtual StructSymbol VisitStruct(StructSymbol structSymbol)
    {
        return new StructSymbol
        (
            structSymbol.Id,
            VisitIdentifier(structSymbol.Identifier),
            structSymbol.Members.Select(VisitMember).ToImmutableArray(),
            structSymbol.Annotations
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
