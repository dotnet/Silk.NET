// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrPassthroughColorLutMETA")]
public readonly unsafe partial struct PassthroughColorLutHandleMETA
    : IEquatable<PassthroughColorLutHandleMETA>
{
    public readonly void* Handle;

    public PassthroughColorLutHandleMETA(void* handle)
    {
        Handle = handle;
    }

    public bool Equals(PassthroughColorLutHandleMETA other) => Handle == other.Handle;

    public override bool Equals(object? obj) =>
        obj is PassthroughColorLutHandleMETA other && Equals(other);

    public override int GetHashCode() => HashCode.Combine((nuint)Handle);

    public static bool operator ==(
        PassthroughColorLutHandleMETA left,
        PassthroughColorLutHandleMETA right
    ) => left.Equals(right);

    public static bool operator !=(
        PassthroughColorLutHandleMETA left,
        PassthroughColorLutHandleMETA right
    ) => !left.Equals(right);

    public bool Equals(NullPtr _) => Handle is null;

    public static bool operator ==(PassthroughColorLutHandleMETA left, NullPtr right) =>
        left.Equals(right);

    public static bool operator !=(PassthroughColorLutHandleMETA left, NullPtr right) =>
        !left.Equals(right);

    public static implicit operator PassthroughColorLutHandleMETA(NullPtr _) => default;
}
