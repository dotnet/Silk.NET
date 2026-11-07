// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkSamplerYcbcrModelConversion")]
public enum SamplerYcbcrModelConversion : uint
{
    [NativeName("VK_SAMPLER_YCBCR_MODEL_CONVERSION_RGB_IDENTITY")]
    RgbIdentity = 0,

    [NativeName("VK_SAMPLER_YCBCR_MODEL_CONVERSION_YCBCR_IDENTITY")]
    YcbcrIdentity = 1,

    [NativeName("VK_SAMPLER_YCBCR_MODEL_CONVERSION_YCBCR_709")]
    Ycbcr709 = 2,

    [NativeName("VK_SAMPLER_YCBCR_MODEL_CONVERSION_YCBCR_601")]
    Ycbcr601 = 3,

    [NativeName("VK_SAMPLER_YCBCR_MODEL_CONVERSION_YCBCR_2020")]
    Ycbcr2020 = 4,

    [NativeName("VK_SAMPLER_YCBCR_MODEL_CONVERSION_RGB_IDENTITY_KHR")]
    RgbIdentityKHR = RgbIdentity,

    [NativeName("VK_SAMPLER_YCBCR_MODEL_CONVERSION_YCBCR_IDENTITY_KHR")]
    YcbcrIdentityKHR = YcbcrIdentity,

    [NativeName("VK_SAMPLER_YCBCR_MODEL_CONVERSION_YCBCR_709_KHR")]
    Ycbcr709KHR = Ycbcr709,

    [NativeName("VK_SAMPLER_YCBCR_MODEL_CONVERSION_YCBCR_601_KHR")]
    Ycbcr601KHR = Ycbcr601,

    [NativeName("VK_SAMPLER_YCBCR_MODEL_CONVERSION_YCBCR_2020_KHR")]
    Ycbcr2020KHR = Ycbcr2020,
}
