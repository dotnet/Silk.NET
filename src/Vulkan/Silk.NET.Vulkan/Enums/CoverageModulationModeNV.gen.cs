// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkCoverageModulationModeNV")]
    public enum CoverageModulationModeNV : int
    {
        [NativeName("Name", "VK_COVERAGE_MODULATION_MODE_NONE_NV")]
        CoverageModulationModeNoneNV = 0,
        [NativeName("Name", "VK_COVERAGE_MODULATION_MODE_RGB_NV")]
        CoverageModulationModeRgbNV = 1,
        [NativeName("Name", "VK_COVERAGE_MODULATION_MODE_ALPHA_NV")]
        CoverageModulationModeAlphaNV = 2,
        [NativeName("Name", "VK_COVERAGE_MODULATION_MODE_RGBA_NV")]
        CoverageModulationModeRgbaNV = 3,
    }
}
