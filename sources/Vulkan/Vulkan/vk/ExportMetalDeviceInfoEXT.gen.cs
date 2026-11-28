// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkExportMetalDeviceInfoEXT")]
[SupportedApiProfile("vulkan")]
public unsafe partial struct ExportMetalDeviceInfoEXT
{
    [NativeName("sType")]
    [SupportedApiProfile("vulkan", ["VK_EXT_metal_objects"])]
    public StructureType SType = StructureType.ExportMetalDeviceInfoEXT;

    [NativeName("pNext")]
    [SupportedApiProfile("vulkan", ["VK_EXT_metal_objects"])]
    public void* PNext;

    [NativeName("mtlDevice")]
    [SupportedApiProfile("vulkan", ["VK_EXT_metal_objects"])]
    public void* MtlDevice;

    [SupportedApiProfile("vulkan", ["VK_EXT_metal_objects"])]
    public ExportMetalDeviceInfoEXT() { }
}
