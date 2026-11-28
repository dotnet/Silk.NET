// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkExportMetalCommandQueueInfoEXT")]
[SupportedApiProfile("vulkan")]
public unsafe partial struct ExportMetalCommandQueueInfoEXT
{
    [NativeName("sType")]
    [SupportedApiProfile("vulkan", ["VK_EXT_metal_objects"])]
    public StructureType SType = StructureType.ExportMetalCommandQueueInfoEXT;

    [NativeName("pNext")]
    [SupportedApiProfile("vulkan", ["VK_EXT_metal_objects"])]
    public void* PNext;

    [NativeName("queue")]
    [SupportedApiProfile("vulkan", ["VK_EXT_metal_objects"])]
    public QueueHandle Queue;

    [NativeName("mtlCommandQueue")]
    [SupportedApiProfile("vulkan", ["VK_EXT_metal_objects"])]
    public void* MtlCommandQueue;

    [SupportedApiProfile("vulkan", ["VK_EXT_metal_objects"])]
    public ExportMetalCommandQueueInfoEXT() { }
}
