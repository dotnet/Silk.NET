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
    [NativeName("Name", "VkPipelineViewportExclusiveScissorStateCreateInfoNV")]
    public unsafe partial struct PipelineViewportExclusiveScissorStateCreateInfoNV : IExtendsChain<PipelineViewportStateCreateInfo>
    {
        public PipelineViewportExclusiveScissorStateCreateInfoNV
        (
            StructureType? sType = StructureType.PipelineViewportExclusiveScissorStateCreateInfoNV,
            void* pNext = null,
            uint? exclusiveScissorCount = null,
            Rect2D* pExclusiveScissors = null
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

            if (exclusiveScissorCount is not null)
            {
                ExclusiveScissorCount = exclusiveScissorCount.Value;
            }

            if (pExclusiveScissors is not null)
            {
                PExclusiveScissors = pExclusiveScissors;
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
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "exclusiveScissorCount")]
        public uint ExclusiveScissorCount;
/// <summary></summary>
        [NativeName("Type", "VkRect2D*")]
        [NativeName("Type.Name", "VkRect2D")]
        [NativeName("Name", "pExclusiveScissors")]
        public Rect2D* PExclusiveScissors;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.PipelineViewportExclusiveScissorStateCreateInfoNV;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
