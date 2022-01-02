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
    [NativeName("Name", "VkIndirectCommandsLayoutTokenNV")]
    public unsafe partial struct IndirectCommandsLayoutTokenNV : IChainable
    {
        public IndirectCommandsLayoutTokenNV
        (
            StructureType? sType = StructureType.IndirectCommandsLayoutTokenNV,
            void* pNext = null,
            IndirectCommandsTokenTypeNV? tokenType = null,
            uint? stream = null,
            uint? offset = null,
            uint? vertexBindingUnit = null,
            Bool32? vertexDynamicStride = null,
            PipelineLayout? pushconstantPipelineLayout = null,
            ShaderStageFlags? pushconstantShaderStageFlags = null,
            uint? pushconstantOffset = null,
            uint? pushconstantSize = null,
            IndirectStateFlagsNV? indirectStateFlags = null,
            uint? indexTypeCount = null,
            IndexType* pIndexTypes = null,
            uint* pIndexTypeValues = null
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

            if (tokenType is not null)
            {
                TokenType = tokenType.Value;
            }

            if (stream is not null)
            {
                Stream = stream.Value;
            }

            if (offset is not null)
            {
                Offset = offset.Value;
            }

            if (vertexBindingUnit is not null)
            {
                VertexBindingUnit = vertexBindingUnit.Value;
            }

            if (vertexDynamicStride is not null)
            {
                VertexDynamicStride = vertexDynamicStride.Value;
            }

            if (pushconstantPipelineLayout is not null)
            {
                PushconstantPipelineLayout = pushconstantPipelineLayout.Value;
            }

            if (pushconstantShaderStageFlags is not null)
            {
                PushconstantShaderStageFlags = pushconstantShaderStageFlags.Value;
            }

            if (pushconstantOffset is not null)
            {
                PushconstantOffset = pushconstantOffset.Value;
            }

            if (pushconstantSize is not null)
            {
                PushconstantSize = pushconstantSize.Value;
            }

            if (indirectStateFlags is not null)
            {
                IndirectStateFlags = indirectStateFlags.Value;
            }

            if (indexTypeCount is not null)
            {
                IndexTypeCount = indexTypeCount.Value;
            }

            if (pIndexTypes is not null)
            {
                PIndexTypes = pIndexTypes;
            }

            if (pIndexTypeValues is not null)
            {
                PIndexTypeValues = pIndexTypeValues;
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

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.IndirectCommandsLayoutTokenNV;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
