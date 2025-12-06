// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkDescriptorSetLayout")]
public readonly unsafe partial struct DescriptorSetLayoutHandle
{
    public readonly void* Handle;

    public DescriptorSetLayoutHandle(void* handle)
    {
        Handle = handle;
    }

    public bool Equals(DescriptorSetLayoutHandle other) => Handle == other.Handle;

    public override bool Equals(object? obj) =>
        obj is DescriptorSetLayoutHandle other && Equals(other);

    public override int GetHashCode() => HashCode.Combine((nuint)Handle);

    public static bool operator ==(
        DescriptorSetLayoutHandle left,
        DescriptorSetLayoutHandle right
    ) => left.Equals(right);

    public static bool operator !=(
        DescriptorSetLayoutHandle left,
        DescriptorSetLayoutHandle right
    ) => !left.Equals(right);

    public bool Equals(NullPtr _) => Handle is null;

    public static bool operator ==(DescriptorSetLayoutHandle left, NullPtr right) =>
        left.Equals(right);

    public static bool operator !=(DescriptorSetLayoutHandle left, NullPtr right) =>
        !left.Equals(right);

    public static implicit operator DescriptorSetLayoutHandle(NullPtr _) => default;
}
