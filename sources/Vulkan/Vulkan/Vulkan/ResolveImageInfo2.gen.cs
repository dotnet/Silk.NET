// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public unsafe partial struct ResolveImageInfo2
{
    [SupportedApiProfile("vulkan", ["VK_VERSION_1_3", "VK_VERSION_1_4"], MinVersion = "1.3")]
    public StructureType SType;

    [NativeTypeName("const void *")]
    [SupportedApiProfile("vulkan", ["VK_VERSION_1_3", "VK_VERSION_1_4"], MinVersion = "1.3")]
    public void* PNext;

    [NativeTypeName("VkImage")]
    [SupportedApiProfile("vulkan", ["VK_VERSION_1_3", "VK_VERSION_1_4"], MinVersion = "1.3")]
    public ImageHandle SrcImage;

    [SupportedApiProfile("vulkan", ["VK_VERSION_1_3", "VK_VERSION_1_4"], MinVersion = "1.3")]
    public ImageLayout SrcImageLayout;

    [NativeTypeName("VkImage")]
    [SupportedApiProfile("vulkan", ["VK_VERSION_1_3", "VK_VERSION_1_4"], MinVersion = "1.3")]
    public ImageHandle DstImage;

    [SupportedApiProfile("vulkan", ["VK_VERSION_1_3", "VK_VERSION_1_4"], MinVersion = "1.3")]
    public ImageLayout DstImageLayout;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan", ["VK_VERSION_1_3", "VK_VERSION_1_4"], MinVersion = "1.3")]
    public uint RegionCount;

    [NativeTypeName("const VkImageResolve2 *")]
    [SupportedApiProfile("vulkan", ["VK_VERSION_1_3", "VK_VERSION_1_4"], MinVersion = "1.3")]
    public ImageResolve2* PRegions;
}
