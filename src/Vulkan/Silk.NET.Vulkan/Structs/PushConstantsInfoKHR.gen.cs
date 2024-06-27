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
    [NativeName("Name", "VkPushConstantsInfoKHR")]
    public unsafe partial struct PushConstantsInfoKHR : IChainStart
    {
        public PushConstantsInfoKHR
        (
            StructureType? sType = StructureType.PushConstantsInfoKhr,
            void* pNext = null,
            PipelineLayout? layout = null,
            ShaderStageFlags? stageFlags = null,
            uint? offset = null,
            uint? size = null,
            void* pValues = null
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

            if (layout is not null)
            {
                Layout = layout.Value;
            }

            if (stageFlags is not null)
            {
                StageFlags = stageFlags.Value;
            }

            if (offset is not null)
            {
                Offset = offset.Value;
            }

            if (size is not null)
            {
                Size = size.Value;
            }

            if (pValues is not null)
            {
                PValues = pValues;
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
        [NativeName("Type", "VkPipelineLayout")]
        [NativeName("Type.Name", "VkPipelineLayout")]
        [NativeName("Name", "layout")]
        public PipelineLayout Layout;
/// <summary></summary>
        [NativeName("Type", "VkShaderStageFlags")]
        [NativeName("Type.Name", "VkShaderStageFlags")]
        [NativeName("Name", "stageFlags")]
        public ShaderStageFlags StageFlags;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "offset")]
        public uint Offset;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "size")]
        public uint Size;
/// <summary></summary>
        [NativeName("Type", "void*")]
        [NativeName("Type.Name", "void")]
        [NativeName("Name", "pValues")]
        public void* PValues;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.PushConstantsInfoKhr;
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
        public static unsafe ref PushConstantsInfoKHR Chain(
            out PushConstantsInfoKHR capture)
        {
            capture = new PushConstantsInfoKHR(StructureType.PushConstantsInfoKhr);
            return ref capture;
        }
    }
}
