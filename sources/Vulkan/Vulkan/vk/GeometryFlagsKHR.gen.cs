// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkGeometryFlagsKHR")]
[Flags]
public enum GeometryFlagsKHR : uint
{
    None = 0x0,

    [NativeName("VK_GEOMETRY_OPAQUE_BIT_KHR")]
    OpaqueBit = 0x1,

    [NativeName("VK_GEOMETRY_NO_DUPLICATE_ANY_HIT_INVOCATION_BIT_KHR")]
    NoDuplicateAnyHitInvocationBit = 0x2,

    [NativeName("VK_GEOMETRY_OPAQUE_BIT_NV")]
    OpaqueBitNV = OpaqueBit,

    [NativeName("VK_GEOMETRY_NO_DUPLICATE_ANY_HIT_INVOCATION_BIT_NV")]
    NoDuplicateAnyHitInvocationBitNV = NoDuplicateAnyHitInvocationBit,
}
