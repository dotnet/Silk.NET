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
    [NativeName("Name", "VkPipelineVertexInputStateCreateInfo")]
    public unsafe partial struct PipelineVertexInputStateCreateInfo : IChainStart
    {
        public PipelineVertexInputStateCreateInfo
        (
            StructureType? sType = StructureType.PipelineVertexInputStateCreateInfo,
            void* pNext = null,
            uint? flags = null,
            uint? vertexBindingDescriptionCount = null,
            VertexInputBindingDescription* pVertexBindingDescriptions = null,
            uint? vertexAttributeDescriptionCount = null,
            VertexInputAttributeDescription* pVertexAttributeDescriptions = null
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

            if (vertexBindingDescriptionCount is not null)
            {
                VertexBindingDescriptionCount = vertexBindingDescriptionCount.Value;
            }

            if (pVertexBindingDescriptions is not null)
            {
                PVertexBindingDescriptions = pVertexBindingDescriptions;
            }

            if (vertexAttributeDescriptionCount is not null)
            {
                VertexAttributeDescriptionCount = vertexAttributeDescriptionCount.Value;
            }

            if (pVertexAttributeDescriptions is not null)
            {
                PVertexAttributeDescriptions = pVertexAttributeDescriptions;
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
        [NativeName("Type", "VkPipelineVertexInputStateCreateFlags")]
        [NativeName("Type.Name", "VkPipelineVertexInputStateCreateFlags")]
        [NativeName("Name", "flags")]
        public uint Flags;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "vertexBindingDescriptionCount")]
        public uint VertexBindingDescriptionCount;
/// <summary></summary>
        [NativeName("Type", "VkVertexInputBindingDescription*")]
        [NativeName("Type.Name", "VkVertexInputBindingDescription")]
        [NativeName("Name", "pVertexBindingDescriptions")]
        public VertexInputBindingDescription* PVertexBindingDescriptions;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "vertexAttributeDescriptionCount")]
        public uint VertexAttributeDescriptionCount;
/// <summary></summary>
        [NativeName("Type", "VkVertexInputAttributeDescription*")]
        [NativeName("Type.Name", "VkVertexInputAttributeDescription")]
        [NativeName("Name", "pVertexAttributeDescriptions")]
        public VertexInputAttributeDescription* PVertexAttributeDescriptions;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.PipelineVertexInputStateCreateInfo;
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
        public static unsafe ref PipelineVertexInputStateCreateInfo Chain(
            out PipelineVertexInputStateCreateInfo capture)
        {
            capture = new PipelineVertexInputStateCreateInfo(StructureType.PipelineVertexInputStateCreateInfo);
            return ref capture;
        }
    }
}
