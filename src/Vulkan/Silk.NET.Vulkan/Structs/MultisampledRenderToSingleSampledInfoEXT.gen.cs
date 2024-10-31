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
    [NativeName("Name", "VkMultisampledRenderToSingleSampledInfoEXT")]
    public unsafe partial struct MultisampledRenderToSingleSampledInfoEXT : IExtendsChain<SubpassDescription2>, IExtendsChain<SubpassDescription2KHR>, IExtendsChain<RenderingInfo>, IExtendsChain<RenderingInfoKHR>
    {
        public MultisampledRenderToSingleSampledInfoEXT
        (
            StructureType? sType = StructureType.MultisampledRenderToSingleSampledInfoExt,
            void* pNext = null,
            Bool32? multisampledRenderToSingleSampledEnable = null,
            SampleCountFlags? rasterizationSamples = null
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

            if (multisampledRenderToSingleSampledEnable is not null)
            {
                MultisampledRenderToSingleSampledEnable = multisampledRenderToSingleSampledEnable.Value;
            }

            if (rasterizationSamples is not null)
            {
                RasterizationSamples = rasterizationSamples.Value;
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
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "multisampledRenderToSingleSampledEnable")]
        public Bool32 MultisampledRenderToSingleSampledEnable;
/// <summary></summary>
        [NativeName("Type", "VkSampleCountFlagBits")]
        [NativeName("Type.Name", "VkSampleCountFlagBits")]
        [NativeName("Name", "rasterizationSamples")]
        public SampleCountFlags RasterizationSamples;
        /// <summary>To be documented.</summary>
        public override string ToString()
        {
            return Handle.ToString();
        }


        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.MultisampledRenderToSingleSampledInfoExt;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
