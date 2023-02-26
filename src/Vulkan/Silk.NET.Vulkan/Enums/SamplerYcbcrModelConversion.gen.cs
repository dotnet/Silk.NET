// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [Flags]
    [NativeName("Name", "VkSamplerYcbcrModelConversion")]
    public enum SamplerYcbcrModelConversion : int
    {
        [NativeName("Name", "")]
        None = 0,
        [NativeName("Name", "VK_SAMPLER_YCBCR_MODEL_CONVERSION_RGB_IDENTITY")]
        RgbIdentity = 0,
        [NativeName("Name", "VK_SAMPLER_YCBCR_MODEL_CONVERSION_YCBCR_IDENTITY")]
        YcbcrIdentity = 1,
        [NativeName("Name", "VK_SAMPLER_YCBCR_MODEL_CONVERSION_YCBCR_709")]
        Ycbcr709 = 2,
        [NativeName("Name", "VK_SAMPLER_YCBCR_MODEL_CONVERSION_YCBCR_601")]
        Ycbcr601 = 3,
        [NativeName("Name", "VK_SAMPLER_YCBCR_MODEL_CONVERSION_YCBCR_2020")]
        Ycbcr2020 = 4,
    }
}
