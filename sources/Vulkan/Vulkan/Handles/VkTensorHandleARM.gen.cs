// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkTensorARM")]
[NameAffix("Suffix", "KhronosHandleType", "_T")]
[NameAffix("Suffix", "HandleType", "Handle")]
[NameAffix("Suffix", "KhronosVendor", "ARM")]
public readonly unsafe partial struct VkTensorHandleARM
{
    public readonly void* Handle;

    public VkTensorHandleARM(void* handle)
    {
        Handle = handle;
    }

    public bool Equals(VkTensorHandleARM other) => Handle == other.Handle;

    public override bool Equals(object? obj) => obj is VkTensorHandleARM other && Equals(other);

    public override int GetHashCode() => HashCode.Combine((nuint)Handle);

    public static bool operator ==(VkTensorHandleARM left, VkTensorHandleARM right) =>
        left.Equals(right);

    public static bool operator !=(VkTensorHandleARM left, VkTensorHandleARM right) =>
        !left.Equals(right);

    public bool Equals(NullPtr _) => Handle is null;

    public static bool operator ==(VkTensorHandleARM left, NullPtr right) => left.Equals(right);

    public static bool operator !=(VkTensorHandleARM left, NullPtr right) => !left.Equals(right);

    public static implicit operator VkTensorHandleARM(NullPtr _) => default;
}
