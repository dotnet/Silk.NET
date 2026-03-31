// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkDedicatedAllocationMemoryAllocateInfoNV")]
[NameAffix("Suffix", "KhronosVendor", "NV")]
[SupportedApiProfile("vulkan")]
public unsafe partial struct VkDedicatedAllocationMemoryAllocateInfoNV
{
    [NativeName("sType")]
    [SupportedApiProfile("vulkan", ["VK_NV_dedicated_allocation"])]
    public VkStructureType SType;

    [NativeName("pNext")]
    [NativeTypeName("const void *")]
    [SupportedApiProfile("vulkan", ["VK_NV_dedicated_allocation"])]
    public void* PNext;

    [NativeName("image")]
    [NativeTypeName("VkImage")]
    [SupportedApiProfile("vulkan", ["VK_NV_dedicated_allocation"])]
    public VkImageHandle Image;

    [NativeName("buffer")]
    [NativeTypeName("VkBuffer")]
    [SupportedApiProfile("vulkan", ["VK_NV_dedicated_allocation"])]
    public VkBufferHandle Buffer;
}
