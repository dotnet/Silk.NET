// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;

namespace Silk.NET.OpenXR;

public struct MLCoordinateFrameUID : IEquatable<MLCoordinateFrameUID>
{
    public MLCoordinateFrameUID(ulong first = 0, ulong second = 0) => (First, Second) = (first, second);
    public ulong First;
    public ulong Second;
    public bool Equals(MLCoordinateFrameUID other) => First == other.First && Second == other.Second;
    public override bool Equals(object obj) => obj is MLCoordinateFrameUID other && Equals(other);
    public override int GetHashCode() => HashCode.Combine(First, Second);
    public static bool operator ==(MLCoordinateFrameUID left, MLCoordinateFrameUID right) => left.Equals(right);
    public static bool operator !=(MLCoordinateFrameUID left, MLCoordinateFrameUID right) => !left.Equals(right);
}
