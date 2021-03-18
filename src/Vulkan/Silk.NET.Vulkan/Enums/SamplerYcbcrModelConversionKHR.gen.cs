// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkSamplerYcbcrModelConversionKHR")]
    public enum SamplerYcbcrModelConversionKHR : int
    {
        [NativeName("Name", "VK_SAMPLER_YCBCR_MODEL_CONVERSION_RGB_IDENTITY")]
        SamplerYcbcrModelConversionRgbIdentity = 0,
        [NativeName("Name", "VK_SAMPLER_YCBCR_MODEL_CONVERSION_YCBCR_IDENTITY")]
        SamplerYcbcrModelConversionYcbcrIdentity = 1,
        [NativeName("Name", "VK_SAMPLER_YCBCR_MODEL_CONVERSION_YCBCR_709")]
        SamplerYcbcrModelConversionYcbcr709 = 2,
        [NativeName("Name", "VK_SAMPLER_YCBCR_MODEL_CONVERSION_YCBCR_601")]
        SamplerYcbcrModelConversionYcbcr601 = 3,
        [NativeName("Name", "VK_SAMPLER_YCBCR_MODEL_CONVERSION_YCBCR_2020")]
        SamplerYcbcrModelConversionYcbcr2020 = 4,
    }
}
