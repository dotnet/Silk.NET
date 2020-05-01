// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Ultz.SuperInvoke;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    public unsafe struct FramebufferMixedSamplesCombinationNV
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
        public StructureType SType;
/// <summary></summary>
        public void* PNext;
/// <summary></summary>
        public CoverageReductionModeNV CoverageReductionMode;
/// <summary></summary>
        public SampleCountFlags RasterizationSamples;
/// <summary></summary>
        public SampleCountFlags DepthStencilSamples;
/// <summary></summary>
        public SampleCountFlags ColorSamples;
    }
}
