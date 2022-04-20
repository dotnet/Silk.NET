// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Collections.Immutable;

namespace Silk.NET.SilkTouch.Symbols;

/// <summary>
/// A <see cref="TypeSymbol"/> representing a <c>struct</c>.
/// </summary>
/// <param name="Identifier">The Identifier of this struct</param>
/// <param name="Layout">The layout of this struct</param>
/// <remarks>
/// In this context, a Struct means a type that represents the layout of a continuous block of memory.
/// </remarks>
// /// Each meaningful place in this memory called a field (see <see cref="FieldSymbol"/>) is accessible via this type.
// /// Fields are allowed to overlap.
// /// Additionally it may contain one or multiple <see cref="MethodSymbol"/> that are called with an instance of this type as their first argument.
public sealed record StructSymbol(IdentifierSymbol Identifier, StructLayout Layout) : TypeSymbol(Identifier);

/// <summary>
/// A <see cref="StructSymbol"/> representing the layout of a <see cref="StructSymbol"/>
/// </summary>
/// <param name="Entries">The entries of this layout</param>
public sealed record StructLayout(ImmutableArray<LayoutEntry> Entries)
{
    /// <summary>
    /// An empty layout with no members
    /// </summary>
    public static readonly StructLayout Empty = new StructLayout(ImmutableArray<LayoutEntry>.Empty);
}

/// <summary>
/// Represents an entry in a <see cref="StructLayout"/>
/// </summary>
/// <param name="Member">The member symbol associated with this layout entry</param>
/// <param name="ByteOffset">The offset of this entry in bytes</param>
/// <seealso cref="StructLayout"/>
public sealed record LayoutEntry(MemberSymbol Member, int ByteOffset);
