// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Runtime.CompilerServices;
using Silk.NET.Maths;

namespace Silk.NET.Input.SDL3.Devices.Pointers;

internal static class MathExtensions
{
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Box2D<float> ExtendBy(this Box2D<float> box, Box2D<float> other) => new(Scalar.Min(box.Min, other.Min), Scalar.Max(box.Max, other.Max));
}
