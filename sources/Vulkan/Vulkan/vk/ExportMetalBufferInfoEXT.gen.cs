// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkExportMetalBufferInfoEXT")]
[SupportedApiProfile("vulkan")]
public unsafe partial struct ExportMetalBufferInfoEXT
{
    [NativeName("sType")]
    [SupportedApiProfile("vulkan", ["VK_EXT_metal_objects"])]
    public StructureType SType = StructureType.ExportMetalBufferInfoEXT;

    [NativeName("pNext")]
    [SupportedApiProfile("vulkan", ["VK_EXT_metal_objects"])]
    public void* PNext;

    [NativeName("memory")]
    [SupportedApiProfile("vulkan", ["VK_EXT_metal_objects"])]
    public DeviceMemoryHandle Memory;

    [NativeName("mtlBuffer")]
    [SupportedApiProfile("vulkan", ["VK_EXT_metal_objects"])]
    public void* MtlBuffer;

    [SupportedApiProfile("vulkan", ["VK_EXT_metal_objects"])]
    public ExportMetalBufferInfoEXT() { }
}
