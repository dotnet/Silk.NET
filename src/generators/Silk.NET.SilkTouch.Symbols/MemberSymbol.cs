// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Silk.NET.SilkTouch.Symbols;

/// <summary>
/// A <see cref="MemberSymbol"/>, representing a generic member of some <see cref="TypeSymbol"/>
/// </summary>
/// <seealso cref="FieldSymbol"/>
public abstract record MemberSymbol(IdentifierSymbol Identifier) : Symbol;
