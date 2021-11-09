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
    [NativeName("Name", "VkFramebufferMixedSamplesCombinationNV")]
    public unsafe partial struct FramebufferMixedSamplesCombinationNV : IChainable
    {
        public FramebufferMixedSamplesCombinationNV
        (
            StructureType? sType = StructureType.FramebufferMixedSamplesCombinationNV,
            void* pNext = null,
            CoverageReductionModeNV? coverageReductionMode = null,
            SampleCountFlags? rasterizationSamples = null,
            SampleCountFlags? depthStencilSamples = null,
            SampleCountFlags? colorSamples = null
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

            if (coverageReductionMode is not null)
            {
                CoverageReductionMode = coverageReductionMode.Value;
            }

            if (rasterizationSamples is not null)
            {
                RasterizationSamples = rasterizationSamples.Value;
            }

            if (depthStencilSamples is not null)
            {
                DepthStencilSamples = depthStencilSamples.Value;
            }

            if (colorSamples is not null)
            {
                ColorSamples = colorSamples.Value;
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

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.FramebufferMixedSamplesCombinationNV;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
