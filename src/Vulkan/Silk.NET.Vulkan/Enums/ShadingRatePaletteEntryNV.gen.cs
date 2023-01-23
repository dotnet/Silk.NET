// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkShadingRatePaletteEntryNV")]
    public enum ShadingRatePaletteEntryNV : int
    {
        [Obsolete("Deprecated in favour of \"EntryNoInvocationsNV\"")]
        [NativeName("Name", "VK_SHADING_RATE_PALETTE_ENTRY_NO_INVOCATIONS_NV")]
        ShadingRatePaletteEntryNoInvocationsNV = 0,
        [Obsolete("Deprecated in favour of \"Entry16InvocationsPerPixelNV\"")]
        [NativeName("Name", "VK_SHADING_RATE_PALETTE_ENTRY_16_INVOCATIONS_PER_PIXEL_NV")]
        ShadingRatePaletteEntry16InvocationsPerPixelNV = 1,
        [Obsolete("Deprecated in favour of \"Entry8InvocationsPerPixelNV\"")]
        [NativeName("Name", "VK_SHADING_RATE_PALETTE_ENTRY_8_INVOCATIONS_PER_PIXEL_NV")]
        ShadingRatePaletteEntry8InvocationsPerPixelNV = 2,
        [Obsolete("Deprecated in favour of \"Entry4InvocationsPerPixelNV\"")]
        [NativeName("Name", "VK_SHADING_RATE_PALETTE_ENTRY_4_INVOCATIONS_PER_PIXEL_NV")]
        ShadingRatePaletteEntry4InvocationsPerPixelNV = 3,
        [Obsolete("Deprecated in favour of \"Entry2InvocationsPerPixelNV\"")]
        [NativeName("Name", "VK_SHADING_RATE_PALETTE_ENTRY_2_INVOCATIONS_PER_PIXEL_NV")]
        ShadingRatePaletteEntry2InvocationsPerPixelNV = 4,
        [Obsolete("Deprecated in favour of \"Entry1InvocationPerPixelNV\"")]
        [NativeName("Name", "VK_SHADING_RATE_PALETTE_ENTRY_1_INVOCATION_PER_PIXEL_NV")]
        ShadingRatePaletteEntry1InvocationPerPixelNV = 5,
        [Obsolete("Deprecated in favour of \"Entry1InvocationPer2X1PixelsNV\"")]
        [NativeName("Name", "VK_SHADING_RATE_PALETTE_ENTRY_1_INVOCATION_PER_2X1_PIXELS_NV")]
        ShadingRatePaletteEntry1InvocationPer2X1PixelsNV = 6,
        [Obsolete("Deprecated in favour of \"Entry1InvocationPer1X2PixelsNV\"")]
        [NativeName("Name", "VK_SHADING_RATE_PALETTE_ENTRY_1_INVOCATION_PER_1X2_PIXELS_NV")]
        ShadingRatePaletteEntry1InvocationPer1X2PixelsNV = 7,
        [Obsolete("Deprecated in favour of \"Entry1InvocationPer2X2PixelsNV\"")]
        [NativeName("Name", "VK_SHADING_RATE_PALETTE_ENTRY_1_INVOCATION_PER_2X2_PIXELS_NV")]
        ShadingRatePaletteEntry1InvocationPer2X2PixelsNV = 8,
        [Obsolete("Deprecated in favour of \"Entry1InvocationPer4X2PixelsNV\"")]
        [NativeName("Name", "VK_SHADING_RATE_PALETTE_ENTRY_1_INVOCATION_PER_4X2_PIXELS_NV")]
        ShadingRatePaletteEntry1InvocationPer4X2PixelsNV = 9,
        [Obsolete("Deprecated in favour of \"Entry1InvocationPer2X4PixelsNV\"")]
        [NativeName("Name", "VK_SHADING_RATE_PALETTE_ENTRY_1_INVOCATION_PER_2X4_PIXELS_NV")]
        ShadingRatePaletteEntry1InvocationPer2X4PixelsNV = 10,
        [Obsolete("Deprecated in favour of \"Entry1InvocationPer4X4PixelsNV\"")]
        [NativeName("Name", "VK_SHADING_RATE_PALETTE_ENTRY_1_INVOCATION_PER_4X4_PIXELS_NV")]
        ShadingRatePaletteEntry1InvocationPer4X4PixelsNV = 11,
        [NativeName("Name", "VK_SHADING_RATE_PALETTE_ENTRY_NO_INVOCATIONS_NV")]
        EntryNoInvocationsNV = 0,
        [NativeName("Name", "VK_SHADING_RATE_PALETTE_ENTRY_16_INVOCATIONS_PER_PIXEL_NV")]
        Entry16InvocationsPerPixelNV = 1,
        [NativeName("Name", "VK_SHADING_RATE_PALETTE_ENTRY_8_INVOCATIONS_PER_PIXEL_NV")]
        Entry8InvocationsPerPixelNV = 2,
        [NativeName("Name", "VK_SHADING_RATE_PALETTE_ENTRY_4_INVOCATIONS_PER_PIXEL_NV")]
        Entry4InvocationsPerPixelNV = 3,
        [NativeName("Name", "VK_SHADING_RATE_PALETTE_ENTRY_2_INVOCATIONS_PER_PIXEL_NV")]
        Entry2InvocationsPerPixelNV = 4,
        [NativeName("Name", "VK_SHADING_RATE_PALETTE_ENTRY_1_INVOCATION_PER_PIXEL_NV")]
        Entry1InvocationPerPixelNV = 5,
        [NativeName("Name", "VK_SHADING_RATE_PALETTE_ENTRY_1_INVOCATION_PER_2X1_PIXELS_NV")]
        Entry1InvocationPer2X1PixelsNV = 6,
        [NativeName("Name", "VK_SHADING_RATE_PALETTE_ENTRY_1_INVOCATION_PER_1X2_PIXELS_NV")]
        Entry1InvocationPer1X2PixelsNV = 7,
        [NativeName("Name", "VK_SHADING_RATE_PALETTE_ENTRY_1_INVOCATION_PER_2X2_PIXELS_NV")]
        Entry1InvocationPer2X2PixelsNV = 8,
        [NativeName("Name", "VK_SHADING_RATE_PALETTE_ENTRY_1_INVOCATION_PER_4X2_PIXELS_NV")]
        Entry1InvocationPer4X2PixelsNV = 9,
        [NativeName("Name", "VK_SHADING_RATE_PALETTE_ENTRY_1_INVOCATION_PER_2X4_PIXELS_NV")]
        Entry1InvocationPer2X4PixelsNV = 10,
        [NativeName("Name", "VK_SHADING_RATE_PALETTE_ENTRY_1_INVOCATION_PER_4X4_PIXELS_NV")]
        Entry1InvocationPer4X4PixelsNV = 11,
    }
}
