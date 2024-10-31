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
    [NativeName("Name", "VkPipelineViewportWScalingStateCreateInfoNV")]
    public unsafe partial struct PipelineViewportWScalingStateCreateInfoNV : IExtendsChain<PipelineViewportStateCreateInfo>
    {
        public PipelineViewportWScalingStateCreateInfoNV
        (
            StructureType? sType = StructureType.PipelineViewportWScalingStateCreateInfoNV,
            void* pNext = null,
            Bool32? viewportWScalingEnable = null,
            uint? viewportCount = null,
            ViewportWScalingNV* pViewportWScalings = null
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

            if (viewportWScalingEnable is not null)
            {
                ViewportWScalingEnable = viewportWScalingEnable.Value;
            }

            if (viewportCount is not null)
            {
                ViewportCount = viewportCount.Value;
            }

            if (pViewportWScalings is not null)
            {
                PViewportWScalings = pViewportWScalings;
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
        [NativeName("Name", "viewportWScalingEnable")]
        public Bool32 ViewportWScalingEnable;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "viewportCount")]
        public uint ViewportCount;
/// <summary></summary>
        [NativeName("Type", "VkViewportWScalingNV*")]
        [NativeName("Type.Name", "VkViewportWScalingNV")]
        [NativeName("Name", "pViewportWScalings")]
        public ViewportWScalingNV* PViewportWScalings;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.PipelineViewportWScalingStateCreateInfoNV;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
