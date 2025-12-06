// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkDedicatedAllocationBufferCreateInfoNV")]
[SupportedApiProfile("vulkan")]
public unsafe partial struct DedicatedAllocationBufferCreateInfoNV
{
    [NativeName("sType")]
    [SupportedApiProfile("vulkan", ["VK_NV_dedicated_allocation"])]
    public StructureType SType;

    [NativeName("pNext")]
    [SupportedApiProfile("vulkan", ["VK_NV_dedicated_allocation"])]
    public void* PNext;

    [NativeName("dedicatedAllocation")]
    [SupportedApiProfile("vulkan", ["VK_NV_dedicated_allocation"])]
    public uint DedicatedAllocation;
}
