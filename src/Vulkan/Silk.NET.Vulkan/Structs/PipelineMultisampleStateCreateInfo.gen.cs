// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkPipelineMultisampleStateCreateInfo")]
    public unsafe partial struct PipelineMultisampleStateCreateInfo : IChainStart
    {
        public PipelineMultisampleStateCreateInfo
        (
            StructureType? sType = StructureType.PipelineMultisampleStateCreateInfo,
            void* pNext = null,
            uint? flags = null,
            SampleCountFlags? rasterizationSamples = null,
            Bool32? sampleShadingEnable = null,
            float? minSampleShading = null,
            uint* pSampleMask = null,
            Bool32? alphaToCoverageEnable = null,
            Bool32? alphaToOneEnable = null
        ) : this()
        {
            if (sType is not null)
            {
                SType = sType.Value;
            }

            if (pNext is not null)
            {
                PNext = pNext;
            }

            if (flags is not null)
            {
                Flags = flags.Value;
            }

            if (rasterizationSamples is not null)
            {
                RasterizationSamples = rasterizationSamples.Value;
            }

            if (sampleShadingEnable is not null)
            {
                SampleShadingEnable = sampleShadingEnable.Value;
            }

            if (minSampleShading is not null)
            {
                MinSampleShading = minSampleShading.Value;
            }

            if (pSampleMask is not null)
            {
                PSampleMask = pSampleMask;
            }

            if (alphaToCoverageEnable is not null)
            {
                AlphaToCoverageEnable = alphaToCoverageEnable.Value;
            }

            if (alphaToOneEnable is not null)
            {
                AlphaToOneEnable = alphaToOneEnable.Value;
            }
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

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.PipelineMultisampleStateCreateInfo;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }

        /// <summary>
        /// Convenience method to start a chain.
        /// </summary>
        /// <param name="capture">The newly created chain root</param>
        /// <returns>A reference to the newly created chain.</returns>
        public static unsafe ref PipelineMultisampleStateCreateInfo Chain(
            out PipelineMultisampleStateCreateInfo capture)
        {
            capture = new PipelineMultisampleStateCreateInfo(StructureType.PipelineMultisampleStateCreateInfo);
            return ref capture;
        }
    }
}
