// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("AHardwareBuffer")]
public readonly unsafe partial struct AHardwareBufferHandle : IEquatable<AHardwareBufferHandle>
{
    public readonly void* Handle;

    public AHardwareBufferHandle(void* handle)
    {
        Handle = handle;
    }

    public bool Equals(AHardwareBufferHandle other) => Handle == other.Handle;

    public override bool Equals(object? obj) => obj is AHardwareBufferHandle other && Equals(other);

    public override int GetHashCode() => HashCode.Combine((nuint)Handle);

    public static bool operator ==(AHardwareBufferHandle left, AHardwareBufferHandle right) =>
        left.Equals(right);

    public static bool operator !=(AHardwareBufferHandle left, AHardwareBufferHandle right) =>
        !left.Equals(right);

    public bool Equals(NullPtr _) => Handle is null;

    public static bool operator ==(AHardwareBufferHandle left, NullPtr right) => left.Equals(right);

    public static bool operator !=(AHardwareBufferHandle left, NullPtr right) =>
        !left.Equals(right);

    public static implicit operator AHardwareBufferHandle(NullPtr _) => default;
}
