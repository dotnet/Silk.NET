// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Numerics;

namespace Silk.NET.Core;

/// <summary>
/// The bool scheme for the Win32 <c>VARIANT_BOOL</c> type.
/// </summary>
public class VariantBool : IBoolScheme
{
    /// <inheritdoc />
    public static T True<T>()
        where T : unmanaged, IEquatable<T>, IIncrementOperators<T>, IDecrementOperators<T>
    {
        // True is -1/all bits set
        var ret = default(T);
        unchecked
        {
            ret--;
        }

        return ret;
    }

    /// <inheritdoc />
    public static bool IsTrue<T>(T value)
        where T : unmanaged, IEquatable<T>, IIncrementOperators<T>, IDecrementOperators<T> =>
        value.Equals(True<T>());
}
