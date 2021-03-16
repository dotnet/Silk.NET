// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkFragmentShadingRateNV")]
    public enum FragmentShadingRateNV : int
    {
        [NativeName("Name", "VK_FRAGMENT_SHADING_RATE_1_INVOCATION_PER_PIXEL_NV")]
        FragmentShadingRate1InvocationPerPixelNV = 0,
        [NativeName("Name", "VK_FRAGMENT_SHADING_RATE_1_INVOCATION_PER_1X2_PIXELS_NV")]
        FragmentShadingRate1InvocationPer1X2PixelsNV = 1,
        [NativeName("Name", "VK_FRAGMENT_SHADING_RATE_1_INVOCATION_PER_2X1_PIXELS_NV")]
        FragmentShadingRate1InvocationPer2X1PixelsNV = 4,
        [NativeName("Name", "VK_FRAGMENT_SHADING_RATE_1_INVOCATION_PER_2X2_PIXELS_NV")]
        FragmentShadingRate1InvocationPer2X2PixelsNV = 5,
        [NativeName("Name", "VK_FRAGMENT_SHADING_RATE_1_INVOCATION_PER_2X4_PIXELS_NV")]
        FragmentShadingRate1InvocationPer2X4PixelsNV = 6,
        [NativeName("Name", "VK_FRAGMENT_SHADING_RATE_1_INVOCATION_PER_4X2_PIXELS_NV")]
        FragmentShadingRate1InvocationPer4X2PixelsNV = 9,
        [NativeName("Name", "VK_FRAGMENT_SHADING_RATE_1_INVOCATION_PER_4X4_PIXELS_NV")]
        FragmentShadingRate1InvocationPer4X4PixelsNV = 10,
        [NativeName("Name", "VK_FRAGMENT_SHADING_RATE_2_INVOCATIONS_PER_PIXEL_NV")]
        FragmentShadingRate2InvocationsPerPixelNV = 11,
        [NativeName("Name", "VK_FRAGMENT_SHADING_RATE_4_INVOCATIONS_PER_PIXEL_NV")]
        FragmentShadingRate4InvocationsPerPixelNV = 12,
        [NativeName("Name", "VK_FRAGMENT_SHADING_RATE_8_INVOCATIONS_PER_PIXEL_NV")]
        FragmentShadingRate8InvocationsPerPixelNV = 13,
        [NativeName("Name", "VK_FRAGMENT_SHADING_RATE_16_INVOCATIONS_PER_PIXEL_NV")]
        FragmentShadingRate16InvocationsPerPixelNV = 14,
        [NativeName("Name", "VK_FRAGMENT_SHADING_RATE_NO_INVOCATIONS_NV")]
        FragmentShadingRateNoInvocationsNV = 15,
    }
}
