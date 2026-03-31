// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkIndirectCommandsLayoutNV")]
[NameAffix("Suffix", "KhronosHandleType", "_T")]
[NameAffix("Suffix", "HandleType", "Handle")]
[NameAffix("Suffix", "KhronosVendor", "NV")]
public readonly unsafe partial struct VkIndirectCommandsLayoutHandleNV
{
    public readonly void* Handle;

    public VkIndirectCommandsLayoutHandleNV(void* handle)
    {
        Handle = handle;
    }

    public bool Equals(VkIndirectCommandsLayoutHandleNV other) => Handle == other.Handle;

    public override bool Equals(object? obj) =>
        obj is VkIndirectCommandsLayoutHandleNV other && Equals(other);

    public override int GetHashCode() => HashCode.Combine((nuint)Handle);

    public static bool operator ==(
        VkIndirectCommandsLayoutHandleNV left,
        VkIndirectCommandsLayoutHandleNV right
    ) => left.Equals(right);

    public static bool operator !=(
        VkIndirectCommandsLayoutHandleNV left,
        VkIndirectCommandsLayoutHandleNV right
    ) => !left.Equals(right);

    public bool Equals(NullPtr _) => Handle is null;

    public static bool operator ==(VkIndirectCommandsLayoutHandleNV left, NullPtr right) =>
        left.Equals(right);

    public static bool operator !=(VkIndirectCommandsLayoutHandleNV left, NullPtr right) =>
        !left.Equals(right);

    public static implicit operator VkIndirectCommandsLayoutHandleNV(NullPtr _) => default;
}
