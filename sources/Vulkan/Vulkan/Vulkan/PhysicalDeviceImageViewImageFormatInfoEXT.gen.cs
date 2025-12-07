// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkPhysicalDeviceImageViewImageFormatInfoEXT")]
[SupportedApiProfile("vulkan")]
public unsafe partial struct PhysicalDeviceImageViewImageFormatInfoEXT
{
    [NativeName("sType")]
    [SupportedApiProfile("vulkan", ["VK_EXT_filter_cubic"])]
    public StructureType SType;

    [NativeName("pNext")]
    [SupportedApiProfile("vulkan", ["VK_EXT_filter_cubic"])]
    public void* PNext;

    [NativeName("imageViewType")]
    [SupportedApiProfile("vulkan", ["VK_EXT_filter_cubic"])]
    public ImageViewType ImageViewType;
}
