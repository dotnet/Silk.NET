// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkDescriptorSet")]
[NameAffix("Suffix", "KhronosHandleType", "_T")]
[NameAffix("Suffix", "HandleType", "Handle")]
public readonly unsafe partial struct VkDescriptorSetHandle
{
    public readonly void* Handle;

    public VkDescriptorSetHandle(void* handle)
    {
        Handle = handle;
    }

    public bool Equals(VkDescriptorSetHandle other) => Handle == other.Handle;

    public override bool Equals(object? obj) => obj is VkDescriptorSetHandle other && Equals(other);

    public override int GetHashCode() => HashCode.Combine((nuint)Handle);

    public static bool operator ==(VkDescriptorSetHandle left, VkDescriptorSetHandle right) =>
        left.Equals(right);

    public static bool operator !=(VkDescriptorSetHandle left, VkDescriptorSetHandle right) =>
        !left.Equals(right);

    public bool Equals(NullPtr _) => Handle is null;

    public static bool operator ==(VkDescriptorSetHandle left, NullPtr right) => left.Equals(right);

    public static bool operator !=(VkDescriptorSetHandle left, NullPtr right) =>
        !left.Equals(right);

    public static implicit operator VkDescriptorSetHandle(NullPtr _) => default;
}
