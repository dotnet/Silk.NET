// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Runtime.InteropServices;

namespace Silk.NET.Core;

/// <summary>
/// Represents a target type for UTF-8 string literals.
/// </summary>
/// <param name="bytes">The UTF-8 bytes.</param>
public readonly ref struct Utf8String(ReadOnlySpan<byte> bytes)
{
    /// <summary>
    /// Gets the UTF-8 byte representation of this string.
    /// </summary>
    public ReadOnlySpan<byte> Bytes { get; } = bytes;

    /// <summary>
    /// Converts this string to a <see cref="Ref{T}"/>.
    /// </summary>
    /// <param name="str">The string.</param>
    /// <returns>The ref.</returns>
    public static implicit operator Ref<byte>(Utf8String str) => str.Bytes;

    /// <summary>
    /// Converts this string to a <see cref="Ref{T}"/>.
    /// </summary>
    /// <param name="str">The string.</param>
    /// <returns>The ref.</returns>
    public static implicit operator Ref<sbyte>(Utf8String str) => (ReadOnlySpan<sbyte>)str;

    /// <summary>
    /// Converts this string to a <see cref="ReadOnlySpan{T}"/>.
    /// </summary>
    /// <param name="str">The string.</param>
    /// <returns>The span.</returns>
    public static implicit operator ReadOnlySpan<byte>(Utf8String str) => str.Bytes;

    /// <summary>
    /// Converts this string to a <see cref="Ref{T}"/>.
    /// </summary>
    /// <param name="str">The string.</param>
    /// <returns>The span.</returns>
    public static implicit operator ReadOnlySpan<sbyte>(Utf8String str) =>
        MemoryMarshal.Cast<byte, sbyte>(str);

    // TODO add ptr casts once we have an analyzer for e.g. [KnownImmovable]

    /// <summary>
    /// Converts this string to a <see cref="Ref"/>.
    /// </summary>
    /// <param name="str">The string.</param>
    /// <returns>The ref.</returns>
    public static implicit operator Ref(Utf8String str) => (Ref<byte>)str.Bytes;

    /// <summary>
    /// Converts this string to a <see cref="string"/>.
    /// </summary>
    /// <param name="str">The string.</param>
    /// <returns>The string.</returns>
    public static implicit operator string(Utf8String str) => str.ToString();

    /// <summary>
    /// Converts the given UTF-8 bytes to a <see cref="Utf8String"/>.
    /// </summary>
    /// <param name="bytes">The bytes.</param>
    /// <returns>The string.</returns>
    public static implicit operator Utf8String(ReadOnlySpan<byte> bytes) => new(bytes);

    /// <summary>
    /// Converts the given UTF-8 bytes to a <see cref="Utf8String"/>.
    /// </summary>
    /// <param name="bytes">The bytes.</param>
    /// <returns>The string.</returns>
    public static implicit operator Utf8String(ReadOnlySpan<sbyte> bytes) =>
        MemoryMarshal.Cast<sbyte, byte>(bytes);

    /// <inheritdoc />
    public override string ToString() => (string)(Ref<byte>)this;
}
