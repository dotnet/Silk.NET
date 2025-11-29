// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Silk.NET.SilkTouch.Mods;

/// <summary>
/// The information parsed from a <see cref="NativeTypeNameAttribute"/>.
/// </summary>
public readonly struct NativeTypeNameInfo
{
    /// <summary>
    /// The name of the type by itself or the define name.
    /// </summary>
    public required string Name { get; init; }

    /// <summary>
    /// The value of the #define as a string.
    /// </summary>
    public required string? Value { get; init; }

    /// <summary>
    /// The number of pointer indirection levels.
    /// </summary>
    public required int IndirectionLevels { get; init; }

    /// <summary>
    /// Whether the native type is a #define.
    /// </summary>
    public required bool IsDefine { get; init; }

    /// <summary>
    /// Whether the native type is a const.
    /// All #defines are considered const.
    /// </summary>
    public required bool IsConst { get; init; }
}
