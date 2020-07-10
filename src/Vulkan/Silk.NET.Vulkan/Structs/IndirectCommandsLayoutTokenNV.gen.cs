// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Ultz.SuperInvoke;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkIndirectCommandsLayoutTokenNV")]
    public unsafe partial struct IndirectCommandsLayoutTokenNV
    {
        public IndirectCommandsLayoutTokenNV
        (
            StructureType sType = StructureType.IndirectCommandsLayoutTokenNV,
            void* pNext = default,
            IndirectCommandsTokenTypeNV tokenType = default,
            uint stream = default,
            uint offset = default,
            uint vertexBindingUnit = default,
            Bool32 vertexDynamicStride = default,
            PipelineLayout pushconstantPipelineLayout = default,
            ShaderStageFlags pushconstantShaderStageFlags = default,
            uint pushconstantOffset = default,
            uint pushconstantSize = default,
            IndirectStateFlagsNV indirectStateFlags = default,
            uint indexTypeCount = default,
            IndexType* pIndexTypes = default,
            uint* pIndexTypeValues = default
        )
        {
            SType = sType;
            PNext = pNext;
            TokenType = tokenType;
            Stream = stream;
            Offset = offset;
            VertexBindingUnit = vertexBindingUnit;
            VertexDynamicStride = vertexDynamicStride;
            PushconstantPipelineLayout = pushconstantPipelineLayout;
            PushconstantShaderStageFlags = pushconstantShaderStageFlags;
            PushconstantOffset = pushconstantOffset;
            PushconstantSize = pushconstantSize;
            IndirectStateFlags = indirectStateFlags;
            IndexTypeCount = indexTypeCount;
            PIndexTypes = pIndexTypes;
            PIndexTypeValues = pIndexTypeValues;
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
        [NativeName("Type", "VkIndirectCommandsTokenTypeNV")]
        [NativeName("Type.Name", "VkIndirectCommandsTokenTypeNV")]
        [NativeName("Name", "tokenType")]
        public IndirectCommandsTokenTypeNV TokenType;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "stream")]
        public uint Stream;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "offset")]
        public uint Offset;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "vertexBindingUnit")]
        public uint VertexBindingUnit;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "vertexDynamicStride")]
        public Bool32 VertexDynamicStride;
/// <summary></summary>
        [NativeName("Type", "VkPipelineLayout")]
        [NativeName("Type.Name", "VkPipelineLayout")]
        [NativeName("Name", "pushconstantPipelineLayout")]
        public PipelineLayout PushconstantPipelineLayout;
/// <summary></summary>
        [NativeName("Type", "VkShaderStageFlags")]
        [NativeName("Type.Name", "VkShaderStageFlags")]
        [NativeName("Name", "pushconstantShaderStageFlags")]
        public ShaderStageFlags PushconstantShaderStageFlags;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "pushconstantOffset")]
        public uint PushconstantOffset;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "pushconstantSize")]
        public uint PushconstantSize;
/// <summary></summary>
        [NativeName("Type", "VkIndirectStateFlagsNV")]
        [NativeName("Type.Name", "VkIndirectStateFlagsNV")]
        [NativeName("Name", "indirectStateFlags")]
        public IndirectStateFlagsNV IndirectStateFlags;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "indexTypeCount")]
        public uint IndexTypeCount;
/// <summary></summary>
        [NativeName("Type", "VkIndexType*")]
        [NativeName("Type.Name", "VkIndexType")]
        [NativeName("Name", "pIndexTypes")]
        public IndexType* PIndexTypes;
/// <summary></summary>
        [NativeName("Type", "uint32_t*")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "pIndexTypeValues")]
        public uint* PIndexTypeValues;
    }
}
