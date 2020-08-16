// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkPipelineVertexInputStateCreateInfo")]
    public unsafe partial struct PipelineVertexInputStateCreateInfo
    {
        public PipelineVertexInputStateCreateInfo
        (
            StructureType sType = StructureType.PipelineVertexInputStateCreateInfo,
            void* pNext = default,
            uint flags = default,
            uint vertexBindingDescriptionCount = default,
            VertexInputBindingDescription* pVertexBindingDescriptions = default,
            uint vertexAttributeDescriptionCount = default,
            VertexInputAttributeDescription* pVertexAttributeDescriptions = default
        )
        {
            SType = sType;
            PNext = pNext;
            Flags = flags;
            VertexBindingDescriptionCount = vertexBindingDescriptionCount;
            PVertexBindingDescriptions = pVertexBindingDescriptions;
            VertexAttributeDescriptionCount = vertexAttributeDescriptionCount;
            PVertexAttributeDescriptions = pVertexAttributeDescriptions;
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
    }
}
