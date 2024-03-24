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
    [NativeName("Name", "VkSetDescriptorBufferOffsetsInfoEXT")]
    public unsafe partial struct SetDescriptorBufferOffsetsInfoEXT : IChainStart
    {
        public SetDescriptorBufferOffsetsInfoEXT
        (
            StructureType? sType = StructureType.SetDescriptorBufferOffsetsInfoExt,
            void* pNext = null,
            ShaderStageFlags? stageFlags = null,
            PipelineLayout? layout = null,
            uint? firstSet = null,
            uint? setCount = null,
            uint* pBufferIndices = null,
            ulong* pOffsets = null
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

            if (stageFlags is not null)
            {
                StageFlags = stageFlags.Value;
            }

            if (layout is not null)
            {
                Layout = layout.Value;
            }

            if (firstSet is not null)
            {
                FirstSet = firstSet.Value;
            }

            if (setCount is not null)
            {
                SetCount = setCount.Value;
            }

            if (pBufferIndices is not null)
            {
                PBufferIndices = pBufferIndices;
            }

            if (pOffsets is not null)
            {
                POffsets = pOffsets;
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
        [NativeName("Type", "VkShaderStageFlags")]
        [NativeName("Type.Name", "VkShaderStageFlags")]
        [NativeName("Name", "stageFlags")]
        public ShaderStageFlags StageFlags;
/// <summary></summary>
        [NativeName("Type", "VkPipelineLayout")]
        [NativeName("Type.Name", "VkPipelineLayout")]
        [NativeName("Name", "layout")]
        public PipelineLayout Layout;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "firstSet")]
        public uint FirstSet;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "setCount")]
        public uint SetCount;
/// <summary></summary>
        [NativeName("Type", "uint32_t*")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "pBufferIndices")]
        public uint* PBufferIndices;
/// <summary></summary>
        [NativeName("Type", "VkDeviceSize*")]
        [NativeName("Type.Name", "VkDeviceSize")]
        [NativeName("Name", "pOffsets")]
        public ulong* POffsets;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.SetDescriptorBufferOffsetsInfoExt;
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
        public static unsafe ref SetDescriptorBufferOffsetsInfoEXT Chain(
            out SetDescriptorBufferOffsetsInfoEXT capture)
        {
            capture = new SetDescriptorBufferOffsetsInfoEXT(StructureType.SetDescriptorBufferOffsetsInfoExt);
            return ref capture;
        }
    }
}
