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
    [NativeName("Name", "VkPipelineViewportSwizzleStateCreateInfoNV")]
    public unsafe partial struct PipelineViewportSwizzleStateCreateInfoNV : IExtendsChain<PipelineViewportStateCreateInfo>
    {
        public PipelineViewportSwizzleStateCreateInfoNV
        (
            StructureType? sType = StructureType.PipelineViewportSwizzleStateCreateInfoNV,
            void* pNext = null,
            uint? flags = null,
            uint? viewportCount = null,
            ViewportSwizzleNV* pViewportSwizzles = null
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

            if (viewportCount is not null)
            {
                ViewportCount = viewportCount.Value;
            }

            if (pViewportSwizzles is not null)
            {
                PViewportSwizzles = pViewportSwizzles;
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
        [NativeName("Type", "VkPipelineViewportSwizzleStateCreateFlagsNV")]
        [NativeName("Type.Name", "VkPipelineViewportSwizzleStateCreateFlagsNV")]
        [NativeName("Name", "flags")]
        public uint Flags;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "viewportCount")]
        public uint ViewportCount;
/// <summary></summary>
        [NativeName("Type", "VkViewportSwizzleNV*")]
        [NativeName("Type.Name", "VkViewportSwizzleNV")]
        [NativeName("Name", "pViewportSwizzles")]
        public ViewportSwizzleNV* PViewportSwizzles;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.PipelineViewportSwizzleStateCreateInfoNV;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
