// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Ultz.SuperInvoke;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkFramebufferMixedSamplesCombinationNV")]
    public unsafe partial struct FramebufferMixedSamplesCombinationNV
    {
        public FramebufferMixedSamplesCombinationNV
        (
            StructureType sType = StructureType.FramebufferMixedSamplesCombinationNV,
            void* pNext = default,
            CoverageReductionModeNV coverageReductionMode = default,
            SampleCountFlags rasterizationSamples = default,
            SampleCountFlags depthStencilSamples = default,
            SampleCountFlags colorSamples = default
        )
        {
            SType = sType;
            PNext = pNext;
            CoverageReductionMode = coverageReductionMode;
            RasterizationSamples = rasterizationSamples;
            DepthStencilSamples = depthStencilSamples;
            ColorSamples = colorSamples;
        }

/// <summary></summary>
        [NativeName("Type", "VkStructureType")]
        [NativeName("Type.Name", "VkStructureType")]
        [NativeName("Name", "sType")]
        public StructureType SType;
/// <summary></summary>
        [NativeName("Type", "void*")]
        [NativeName("Type.Name", "void")]
        [NativeName("Name", "pNext")]
        public void* PNext;
/// <summary></summary>
        [NativeName("Type", "VkCoverageReductionModeNV")]
        [NativeName("Type.Name", "VkCoverageReductionModeNV")]
        [NativeName("Name", "coverageReductionMode")]
        public CoverageReductionModeNV CoverageReductionMode;
/// <summary></summary>
        [NativeName("Type", "VkSampleCountFlagBits")]
        [NativeName("Type.Name", "VkSampleCountFlagBits")]
        [NativeName("Name", "rasterizationSamples")]
        public SampleCountFlags RasterizationSamples;
/// <summary></summary>
        [NativeName("Type", "VkSampleCountFlags")]
        [NativeName("Type.Name", "VkSampleCountFlags")]
        [NativeName("Name", "depthStencilSamples")]
        public SampleCountFlags DepthStencilSamples;
/// <summary></summary>
        [NativeName("Type", "VkSampleCountFlags")]
        [NativeName("Type.Name", "VkSampleCountFlags")]
        [NativeName("Name", "colorSamples")]
        public SampleCountFlags ColorSamples;
    }
}
