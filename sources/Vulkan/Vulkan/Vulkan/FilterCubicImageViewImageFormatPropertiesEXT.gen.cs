// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NameAffix("Suffix", "EXT", 0)]
[NativeName("VkFilterCubicImageViewImageFormatPropertiesEXT")]
[SupportedApiProfile("vulkan")]
public unsafe partial struct FilterCubicImageViewImageFormatPropertiesEXT
{
    [NativeName("sType")]
    [SupportedApiProfile("vulkan", ["VK_EXT_filter_cubic"])]
    public StructureType SType;

    [NativeName("pNext")]
    [SupportedApiProfile("vulkan", ["VK_EXT_filter_cubic"])]
    public void* PNext;

    [NativeName("filterCubic")]
    [SupportedApiProfile("vulkan", ["VK_EXT_filter_cubic"])]
    public uint FilterCubic;

    [NativeName("filterCubicMinmax")]
    [SupportedApiProfile("vulkan", ["VK_EXT_filter_cubic"])]
    public uint FilterCubicMinmax;
}
