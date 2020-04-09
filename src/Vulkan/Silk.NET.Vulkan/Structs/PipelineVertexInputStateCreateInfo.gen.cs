// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Ultz.SuperInvoke;

namespace Silk.NET.Vulkan
{
    public unsafe struct PipelineVertexInputStateCreateInfo
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
        public StructureType SType;
/// <summary></summary>
        public void* PNext;
/// <summary></summary>
        public uint Flags;
/// <summary></summary>
        public uint VertexBindingDescriptionCount;
/// <summary></summary>
        public VertexInputBindingDescription* PVertexBindingDescriptions;
/// <summary></summary>
        public uint VertexAttributeDescriptionCount;
/// <summary></summary>
        public VertexInputAttributeDescription* PVertexAttributeDescriptions;
    }
}
