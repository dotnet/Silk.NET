// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NameAffix("Suffix", "ARM", 0)]
[NativeName("VkTensorARM")]
[NameAffix("Suffix", "_T", -1)]
[NameAffix("Suffix", "Handle", 1)]
public readonly unsafe partial struct TensorHandleArm
{
    public readonly void* Handle;

    public TensorHandleArm(void* handle)
    {
        Handle = handle;
    }

    public bool Equals(TensorHandleArm other) => Handle == other.Handle;

    public override bool Equals(object? obj) => obj is TensorHandleArm other && Equals(other);

    public override int GetHashCode() => HashCode.Combine((nuint)Handle);

    public static bool operator ==(TensorHandleArm left, TensorHandleArm right) =>
        left.Equals(right);

    public static bool operator !=(TensorHandleArm left, TensorHandleArm right) =>
        !left.Equals(right);

    public bool Equals(NullPtr _) => Handle is null;

    public static bool operator ==(TensorHandleArm left, NullPtr right) => left.Equals(right);

    public static bool operator !=(TensorHandleArm left, NullPtr right) => !left.Equals(right);

    public static implicit operator TensorHandleArm(NullPtr _) => default;
}
