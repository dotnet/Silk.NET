// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkCopyAccelerationStructureModeKHR")]
public enum CopyAccelerationStructureModeKHR : uint
{
    [NativeName("VK_COPY_ACCELERATION_STRUCTURE_MODE_CLONE_KHR")]
    Clone = 0,

    [NativeName("VK_COPY_ACCELERATION_STRUCTURE_MODE_COMPACT_KHR")]
    Compact = 1,

    [NativeName("VK_COPY_ACCELERATION_STRUCTURE_MODE_SERIALIZE_KHR")]
    Serialize = 2,

    [NativeName("VK_COPY_ACCELERATION_STRUCTURE_MODE_DESERIALIZE_KHR")]
    Deserialize = 3,

    [NativeName("VK_COPY_ACCELERATION_STRUCTURE_MODE_CLONE_NV")]
    CloneNV = Clone,

    [NativeName("VK_COPY_ACCELERATION_STRUCTURE_MODE_COMPACT_NV")]
    CompactNV = Compact,
}
