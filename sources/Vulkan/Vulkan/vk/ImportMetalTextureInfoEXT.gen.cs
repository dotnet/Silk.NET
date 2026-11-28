// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkImportMetalTextureInfoEXT")]
[SupportedApiProfile("vulkan")]
public unsafe partial struct ImportMetalTextureInfoEXT
{
    [NativeName("sType")]
    [SupportedApiProfile("vulkan", ["VK_EXT_metal_objects"])]
    public StructureType SType = StructureType.ImportMetalTextureInfoEXT;

    [NativeName("pNext")]
    [SupportedApiProfile("vulkan", ["VK_EXT_metal_objects"])]
    public void* PNext;

    [NativeName("plane")]
    [SupportedApiProfile("vulkan", ["VK_EXT_metal_objects"])]
    public ImageAspectFlags Plane;

    [NativeName("mtlTexture")]
    [SupportedApiProfile("vulkan", ["VK_EXT_metal_objects"])]
    public void* MtlTexture;

    [SupportedApiProfile("vulkan", ["VK_EXT_metal_objects"])]
    public ImportMetalTextureInfoEXT() { }
}
