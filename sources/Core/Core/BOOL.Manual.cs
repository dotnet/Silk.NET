// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Numerics;

namespace Silk.NET.Core;

/// <summary>
/// Boolean value commonly used by Microsoft
/// </summary>
public readonly partial struct BOOL : IIncrementOperators<BOOL>
{
    /// <summary>
    /// Increment boolean value
    /// </summary>
    /// <param name="value">bool value to increment</param>
    /// <returns>incremented bool value</returns>
    public static BOOL operator ++(BOOL value) => new(value.Value + 1);
}
