// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Silk.NET.SilkTouch.Symbols;

/// <summary>
/// A <see cref="FieldSymbol"/>. A field is simply a named location that can hold some type.
/// </summary>
/// <seealso cref="MemberSymbol"/>
public sealed class FieldSymbol : MemberSymbol
{
    /// <summary>
    /// Create a field symbol from the parent <see cref="TypeSymbol"/>, the type of the field and it's identifier 
    /// </summary>
    /// <param name="type">The type of the data stored in this field</param>
    /// <param name="identifier">The identifier of this field</param>
    public FieldSymbol(TypeSymbol type, IdentifierSymbol identifier)
    {
        Type = type;
        Identifier = identifier;
    }
    
    /// <summary>
    /// The <see cref="TypeSymbol"/> of the data stored in this field
    /// </summary>
    public TypeSymbol Type { get; }
    
    /// <summary>
    /// The Identifier of this field
    /// </summary>
    public IdentifierSymbol Identifier { get; }
}
