// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrPassthroughLayerANDROID")]
public readonly unsafe partial struct PassthroughLayerHandleANDROID
    : IEquatable<PassthroughLayerHandleANDROID>
{
    public readonly void* Handle;

    public PassthroughLayerHandleANDROID(void* handle)
    {
        Handle = handle;
    }

    public bool Equals(PassthroughLayerHandleANDROID other) => Handle == other.Handle;

    public override bool Equals(object? obj) =>
        obj is PassthroughLayerHandleANDROID other && Equals(other);

    public override int GetHashCode() => HashCode.Combine((nuint)Handle);

    public static bool operator ==(
        PassthroughLayerHandleANDROID left,
        PassthroughLayerHandleANDROID right
    ) => left.Equals(right);

    public static bool operator !=(
        PassthroughLayerHandleANDROID left,
        PassthroughLayerHandleANDROID right
    ) => !left.Equals(right);

    public bool Equals(NullPtr _) => Handle is null;

    public static bool operator ==(PassthroughLayerHandleANDROID left, NullPtr right) =>
        left.Equals(right);

    public static bool operator !=(PassthroughLayerHandleANDROID left, NullPtr right) =>
        !left.Equals(right);

    public static implicit operator PassthroughLayerHandleANDROID(NullPtr _) => default;
}
