// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkVideoSessionKHR")]
[NameAffix("Suffix", "KhronosHandleType", "_T")]
[NameAffix("Suffix", "HandleType", "Handle")]
[NameAffix("Suffix", "KhronosVendor", "KHR")]
public readonly unsafe partial struct VkVideoSessionHandleKHR
{
    public readonly void* Handle;

    public VkVideoSessionHandleKHR(void* handle)
    {
        Handle = handle;
    }

    public bool Equals(VkVideoSessionHandleKHR other) => Handle == other.Handle;

    public override bool Equals(object? obj) =>
        obj is VkVideoSessionHandleKHR other && Equals(other);

    public override int GetHashCode() => HashCode.Combine((nuint)Handle);

    public static bool operator ==(VkVideoSessionHandleKHR left, VkVideoSessionHandleKHR right) =>
        left.Equals(right);

    public static bool operator !=(VkVideoSessionHandleKHR left, VkVideoSessionHandleKHR right) =>
        !left.Equals(right);

    public bool Equals(NullPtr _) => Handle is null;

    public static bool operator ==(VkVideoSessionHandleKHR left, NullPtr right) =>
        left.Equals(right);

    public static bool operator !=(VkVideoSessionHandleKHR left, NullPtr right) =>
        !left.Equals(right);

    public static implicit operator VkVideoSessionHandleKHR(NullPtr _) => default;
}
