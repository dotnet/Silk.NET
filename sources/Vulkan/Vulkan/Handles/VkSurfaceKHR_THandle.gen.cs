// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

public readonly unsafe partial struct VkSurfaceKHR_THandle
{
    public readonly void* Handle;

    public bool Equals(VkSurfaceKHR_THandle other) => Handle == other.Handle;

    public override bool Equals(object? obj) => obj is VkSurfaceKHR_THandle other && Equals(other);

    public override int GetHashCode() => HashCode.Combine((nuint)Handle);

    public static bool operator ==(VkSurfaceKHR_THandle left, VkSurfaceKHR_THandle right) =>
        left.Equals(right);

    public static bool operator !=(VkSurfaceKHR_THandle left, VkSurfaceKHR_THandle right) =>
        !left.Equals(right);

    public bool Equals(NullPtr _) => Handle is null;

    public static bool operator ==(VkSurfaceKHR_THandle left, NullPtr right) => left.Equals(right);

    public static bool operator !=(VkSurfaceKHR_THandle left, NullPtr right) => !left.Equals(right);

    public static implicit operator VkSurfaceKHR_THandle(NullPtr _) => default;
}
