// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Silk.NET.SilkTouch.Naming;

/// <summary>
/// Used to categorize characters into mutually exclusive categories.
/// </summary>
public enum CharType
{
    /// <summary>
    /// Characters that are capital letters.
    /// </summary>
    Upper,

    /// <summary>
    /// Characters that are digits.
    /// </summary>
    Number,

    /// <summary>
    /// Characters that separate words in C# identifiers.
    /// </summary>
    Separator,

    /// <summary>
    /// All other characters.
    /// Often lowercase letters.
    /// </summary>
    Other,
}
