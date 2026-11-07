// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkRenderingFlags")]
[Flags]
public enum RenderingFlags : uint
{
    None = 0x0,

    [NativeName("VK_RENDERING_CONTENTS_SECONDARY_COMMAND_BUFFERS_BIT")]
    ContentsSecondaryCommandBuffersBit = 0x1,

    [NativeName("VK_RENDERING_SUSPENDING_BIT")]
    SuspendingBit = 0x2,

    [NativeName("VK_RENDERING_RESUMING_BIT")]
    ResumingBit = 0x4,

    [NativeName("VK_RENDERING_ENABLE_LEGACY_DITHERING_BIT_EXT")]
    EnableLegacyDitheringBitEXT = 0x8,

    [NativeName("VK_RENDERING_CONTENTS_INLINE_BIT_KHR")]
    ContentsInlineBitKHR = 0x10,

    [NativeName("VK_RENDERING_PER_LAYER_FRAGMENT_DENSITY_BIT_VALVE")]
    PerLayerFragmentDensityBitVALVE = 0x20,

    [NativeName("VK_RENDERING_FRAGMENT_REGION_BIT_EXT")]
    FragmentRegionBitEXT = 0x40,

    [NativeName("VK_RENDERING_CUSTOM_RESOLVE_BIT_EXT")]
    CustomResolveBitEXT = 0x80,

    [NativeName("VK_RENDERING_LOCAL_READ_CONCURRENT_ACCESS_CONTROL_BIT_KHR")]
    LocalReadConcurrentAccessControlBitKHR = 0x100,

    [NativeName("VK_RENDERING_CONTENTS_SECONDARY_COMMAND_BUFFERS_BIT_KHR")]
    ContentsSecondaryCommandBuffersBitKHR = ContentsSecondaryCommandBuffersBit,

    [NativeName("VK_RENDERING_SUSPENDING_BIT_KHR")]
    SuspendingBitKHR = SuspendingBit,

    [NativeName("VK_RENDERING_RESUMING_BIT_KHR")]
    ResumingBitKHR = ResumingBit,

    [NativeName("VK_RENDERING_CONTENTS_INLINE_BIT_EXT")]
    ContentsInlineBitEXT = ContentsInlineBitKHR,
}
