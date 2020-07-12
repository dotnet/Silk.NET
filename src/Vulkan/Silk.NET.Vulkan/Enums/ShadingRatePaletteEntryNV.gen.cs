// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkShadingRatePaletteEntryNV")]
    public enum ShadingRatePaletteEntryNV
    {
        [NativeName("Name", "VK_SHADING_RATE_PALETTE_ENTRY_NO_INVOCATIONS_NV")]
        ShadingRatePaletteEntryNoInvocationsNV = 0,
        [NativeName("Name", "VK_SHADING_RATE_PALETTE_ENTRY_16_INVOCATIONS_PER_PIXEL_NV")]
        ShadingRatePaletteEntry16InvocationsPerPixelNV = 1,
        [NativeName("Name", "VK_SHADING_RATE_PALETTE_ENTRY_8_INVOCATIONS_PER_PIXEL_NV")]
        ShadingRatePaletteEntry8InvocationsPerPixelNV = 2,
        [NativeName("Name", "VK_SHADING_RATE_PALETTE_ENTRY_4_INVOCATIONS_PER_PIXEL_NV")]
        ShadingRatePaletteEntry4InvocationsPerPixelNV = 3,
        [NativeName("Name", "VK_SHADING_RATE_PALETTE_ENTRY_2_INVOCATIONS_PER_PIXEL_NV")]
        ShadingRatePaletteEntry2InvocationsPerPixelNV = 4,
        [NativeName("Name", "VK_SHADING_RATE_PALETTE_ENTRY_1_INVOCATION_PER_PIXEL_NV")]
        ShadingRatePaletteEntry1InvocationPerPixelNV = 5,
        [NativeName("Name", "VK_SHADING_RATE_PALETTE_ENTRY_1_INVOCATION_PER_2X1_PIXELS_NV")]
        ShadingRatePaletteEntry1InvocationPer2X1PixelsNV = 6,
        [NativeName("Name", "VK_SHADING_RATE_PALETTE_ENTRY_1_INVOCATION_PER_1X2_PIXELS_NV")]
        ShadingRatePaletteEntry1InvocationPer1X2PixelsNV = 7,
        [NativeName("Name", "VK_SHADING_RATE_PALETTE_ENTRY_1_INVOCATION_PER_2X2_PIXELS_NV")]
        ShadingRatePaletteEntry1InvocationPer2X2PixelsNV = 8,
        [NativeName("Name", "VK_SHADING_RATE_PALETTE_ENTRY_1_INVOCATION_PER_4X2_PIXELS_NV")]
        ShadingRatePaletteEntry1InvocationPer4X2PixelsNV = 9,
        [NativeName("Name", "VK_SHADING_RATE_PALETTE_ENTRY_1_INVOCATION_PER_2X4_PIXELS_NV")]
        ShadingRatePaletteEntry1InvocationPer2X4PixelsNV = 10,
        [NativeName("Name", "VK_SHADING_RATE_PALETTE_ENTRY_1_INVOCATION_PER_4X4_PIXELS_NV")]
        ShadingRatePaletteEntry1InvocationPer4X4PixelsNV = 11,
    }
}
