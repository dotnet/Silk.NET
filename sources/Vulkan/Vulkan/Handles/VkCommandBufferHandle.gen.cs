// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkCommandBuffer")]
[NameAffix("Suffix", "KhronosHandleType", "_T")]
[NameAffix("Suffix", "HandleType", "Handle")]
public readonly unsafe partial struct VkCommandBufferHandle
{
    public readonly void* Handle;

    public VkCommandBufferHandle(void* handle)
    {
        Handle = handle;
    }

    public bool Equals(VkCommandBufferHandle other) => Handle == other.Handle;

    public override bool Equals(object? obj) => obj is VkCommandBufferHandle other && Equals(other);

    public override int GetHashCode() => HashCode.Combine((nuint)Handle);

    public static bool operator ==(VkCommandBufferHandle left, VkCommandBufferHandle right) =>
        left.Equals(right);

    public static bool operator !=(VkCommandBufferHandle left, VkCommandBufferHandle right) =>
        !left.Equals(right);

    public bool Equals(NullPtr _) => Handle is null;

    public static bool operator ==(VkCommandBufferHandle left, NullPtr right) => left.Equals(right);

    public static bool operator !=(VkCommandBufferHandle left, NullPtr right) =>
        !left.Equals(right);

    public static implicit operator VkCommandBufferHandle(NullPtr _) => default;
}
