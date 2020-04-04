// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Ultz.SuperInvoke;

namespace Silk.NET.Vulkan
{
    public unsafe struct PipelineMultisampleStateCreateInfo
    {
        public PipelineMultisampleStateCreateInfo
        (
            StructureType sType = StructureType.PipelineMultisampleStateCreateInfo,
            void* pNext = default,
            uint flags = default,
            SampleCountFlags rasterizationSamples = default,
            Bool32 sampleShadingEnable = default,
            float minSampleShading = default,
            uint* pSampleMask = default,
            Bool32 alphaToCoverageEnable = default,
            Bool32 alphaToOneEnable = default
        )
        {
           SType = sType;
           PNext = pNext;
           Flags = flags;
           RasterizationSamples = rasterizationSamples;
           SampleShadingEnable = sampleShadingEnable;
           MinSampleShading = minSampleShading;
           PSampleMask = pSampleMask;
           AlphaToCoverageEnable = alphaToCoverageEnable;
           AlphaToOneEnable = alphaToOneEnable;
        }

/// <summary></summary>
        public StructureType SType;
/// <summary></summary>
        public void* PNext;
/// <summary></summary>
        public uint Flags;
/// <summary></summary>
        public SampleCountFlags RasterizationSamples;
/// <summary></summary>
        public Bool32 SampleShadingEnable;
/// <summary></summary>
        public float MinSampleShading;
/// <summary></summary>
        public uint* PSampleMask;
/// <summary></summary>
        public Bool32 AlphaToCoverageEnable;
/// <summary></summary>
        public Bool32 AlphaToOneEnable;
    }
}
