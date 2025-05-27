// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public unsafe partial struct DedicatedAllocationMemoryAllocateInfoNV
{
    [SupportedApiProfile("vulkan", ["VK_NV_dedicated_allocation"])]
    public StructureType SType;

    [NativeTypeName("const void *")]
    [SupportedApiProfile("vulkan", ["VK_NV_dedicated_allocation"])]
    public void* PNext;

    [NativeTypeName("VkImage")]
    [SupportedApiProfile("vulkan", ["VK_NV_dedicated_allocation"])]
    public ImageHandle Image;

    [NativeTypeName("VkBuffer")]
    [SupportedApiProfile("vulkan", ["VK_NV_dedicated_allocation"])]
    public BufferHandle Buffer;
}
