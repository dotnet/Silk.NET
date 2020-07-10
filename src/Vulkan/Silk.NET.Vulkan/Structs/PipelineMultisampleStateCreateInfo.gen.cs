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
    [NativeName("Name", "VkPipelineMultisampleStateCreateInfo")]
    public unsafe partial struct PipelineMultisampleStateCreateInfo
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
        [NativeName("Type", "VkPipelineMultisampleStateCreateFlags")]
        [NativeName("Type.Name", "VkPipelineMultisampleStateCreateFlags")]
        [NativeName("Name", "flags")]
        public uint Flags;
/// <summary></summary>
        [NativeName("Type", "VkSampleCountFlagBits")]
        [NativeName("Type.Name", "VkSampleCountFlagBits")]
        [NativeName("Name", "rasterizationSamples")]
        public SampleCountFlags RasterizationSamples;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "sampleShadingEnable")]
        public Bool32 SampleShadingEnable;
/// <summary></summary>
        [NativeName("Type", "float")]
        [NativeName("Type.Name", "float")]
        [NativeName("Name", "minSampleShading")]
        public float MinSampleShading;
/// <summary></summary>
        [NativeName("Type", "VkSampleMask*")]
        [NativeName("Type.Name", "VkSampleMask")]
        [NativeName("Name", "pSampleMask")]
        public uint* PSampleMask;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "alphaToCoverageEnable")]
        public Bool32 AlphaToCoverageEnable;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "alphaToOneEnable")]
        public Bool32 AlphaToOneEnable;
    }
}
