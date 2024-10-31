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
    [NativeName("Name", "VkPipelineViewportStateCreateInfo")]
    public unsafe partial struct PipelineViewportStateCreateInfo : IChainStart
    {
        public PipelineViewportStateCreateInfo
        (
            StructureType? sType = StructureType.PipelineViewportStateCreateInfo,
            void* pNext = null,
            uint? flags = null,
            uint? viewportCount = null,
            Viewport* pViewports = null,
            uint? scissorCount = null,
            Rect2D* pScissors = null
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

            if (pViewports is not null)
            {
                PViewports = pViewports;
            }

            if (scissorCount is not null)
            {
                ScissorCount = scissorCount.Value;
            }

            if (pScissors is not null)
            {
                PScissors = pScissors;
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
        [NativeName("Type", "VkPipelineViewportStateCreateFlags")]
        [NativeName("Type.Name", "VkPipelineViewportStateCreateFlags")]
        [NativeName("Name", "flags")]
        public uint Flags;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "viewportCount")]
        public uint ViewportCount;
/// <summary></summary>
        [NativeName("Type", "VkViewport*")]
        [NativeName("Type.Name", "VkViewport")]
        [NativeName("Name", "pViewports")]
        public Viewport* PViewports;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "scissorCount")]
        public uint ScissorCount;
/// <summary></summary>
        [NativeName("Type", "VkRect2D*")]
        [NativeName("Type.Name", "VkRect2D")]
        [NativeName("Name", "pScissors")]
        public Rect2D* PScissors;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.PipelineViewportStateCreateInfo;
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
        public static unsafe ref PipelineViewportStateCreateInfo Chain(
            out PipelineViewportStateCreateInfo capture)
        {
            capture = new PipelineViewportStateCreateInfo(StructureType.PipelineViewportStateCreateInfo);
            return ref capture;
        }
    }
}
