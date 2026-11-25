// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkImportMetalIOSurfaceInfoEXT")]
[SupportedApiProfile("vulkan")]
public unsafe partial struct ImportMetalIOSurfaceInfoEXT
{
    [NativeName("sType")]
    [SupportedApiProfile("vulkan", ["VK_EXT_metal_objects"])]
    public StructureType SType = StructureType.ImportMetalIoSurfaceInfoEXT;

    [NativeName("pNext")]
    [SupportedApiProfile("vulkan", ["VK_EXT_metal_objects"])]
    public void* PNext;

    [NativeName("ioSurface")]
    [SupportedApiProfile("vulkan", ["VK_EXT_metal_objects"])]
    public IOSurfaceHandle IoSurface;

    [SupportedApiProfile("vulkan", ["VK_EXT_metal_objects"])]
    public ImportMetalIOSurfaceInfoEXT() { }
}
