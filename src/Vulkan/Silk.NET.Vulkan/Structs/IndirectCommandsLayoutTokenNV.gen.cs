// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Ultz.SuperInvoke;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    public unsafe struct IndirectCommandsLayoutTokenNV
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
        public StructureType SType;
/// <summary></summary>
        public void* PNext;
/// <summary></summary>
        public IndirectCommandsTokenTypeNV TokenType;
/// <summary></summary>
        public uint Stream;
/// <summary></summary>
        public uint Offset;
/// <summary></summary>
        public uint VertexBindingUnit;
/// <summary></summary>
        public Bool32 VertexDynamicStride;
/// <summary></summary>
        public PipelineLayout PushconstantPipelineLayout;
/// <summary></summary>
        public ShaderStageFlags PushconstantShaderStageFlags;
/// <summary></summary>
        public uint PushconstantOffset;
/// <summary></summary>
        public uint PushconstantSize;
/// <summary></summary>
        public IndirectStateFlagsNV IndirectStateFlags;
/// <summary></summary>
        public uint IndexTypeCount;
/// <summary></summary>
        public IndexType* PIndexTypes;
/// <summary></summary>
        public uint* PIndexTypeValues;
    }
}
