// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [Flags]
    [NativeName("Name", "VkVideoEncodeRgbModelConversionFlagsVALVE")]
    public enum VideoEncodeRgbModelConversionFlagsVALVE : int
    {
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"RgbIdentityBitValve\"")]
        [NativeName("Name", "VK_VIDEO_ENCODE_RGB_MODEL_CONVERSION_RGB_IDENTITY_BIT_VALVE")]
        VideoEncodeRgbModelConversionRgbIdentityBitValve = 1,
        [Obsolete("Deprecated in favour of \"YcbcrIdentityBitValve\"")]
        [NativeName("Name", "VK_VIDEO_ENCODE_RGB_MODEL_CONVERSION_YCBCR_IDENTITY_BIT_VALVE")]
        VideoEncodeRgbModelConversionYcbcrIdentityBitValve = 2,
        [Obsolete("Deprecated in favour of \"Ycbcr709BitValve\"")]
        [NativeName("Name", "VK_VIDEO_ENCODE_RGB_MODEL_CONVERSION_YCBCR_709_BIT_VALVE")]
        VideoEncodeRgbModelConversionYcbcr709BitValve = 4,
        [Obsolete("Deprecated in favour of \"Ycbcr601BitValve\"")]
        [NativeName("Name", "VK_VIDEO_ENCODE_RGB_MODEL_CONVERSION_YCBCR_601_BIT_VALVE")]
        VideoEncodeRgbModelConversionYcbcr601BitValve = 8,
        [Obsolete("Deprecated in favour of \"Ycbcr2020BitValve\"")]
        [NativeName("Name", "VK_VIDEO_ENCODE_RGB_MODEL_CONVERSION_YCBCR_2020_BIT_VALVE")]
        VideoEncodeRgbModelConversionYcbcr2020BitValve = 16,
        [NativeName("Name", "VK_VIDEO_ENCODE_RGB_MODEL_CONVERSION_RGB_IDENTITY_BIT_VALVE")]
        RgbIdentityBitValve = 1,
        [NativeName("Name", "VK_VIDEO_ENCODE_RGB_MODEL_CONVERSION_YCBCR_IDENTITY_BIT_VALVE")]
        YcbcrIdentityBitValve = 2,
        [NativeName("Name", "VK_VIDEO_ENCODE_RGB_MODEL_CONVERSION_YCBCR_709_BIT_VALVE")]
        Ycbcr709BitValve = 4,
        [NativeName("Name", "VK_VIDEO_ENCODE_RGB_MODEL_CONVERSION_YCBCR_601_BIT_VALVE")]
        Ycbcr601BitValve = 8,
        [NativeName("Name", "VK_VIDEO_ENCODE_RGB_MODEL_CONVERSION_YCBCR_2020_BIT_VALVE")]
        Ycbcr2020BitValve = 16,
    }
}
