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
    [NativeName("Name", "VkIndirectCommandsLayoutCreateInfoEXT")]
    public unsafe partial struct IndirectCommandsLayoutCreateInfoEXT : IChainStart
    {
        public IndirectCommandsLayoutCreateInfoEXT
        (
            StructureType? sType = StructureType.IndirectCommandsLayoutCreateInfoExt,
            void* pNext = null,
            IndirectCommandsLayoutUsageFlagsEXT? flags = null,
            ShaderStageFlags? shaderStages = null,
            uint? indirectStride = null,
            PipelineLayout? pipelineLayout = null,
            uint? tokenCount = null,
            IndirectCommandsLayoutTokenEXT* pTokens = null
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

            if (shaderStages is not null)
            {
                ShaderStages = shaderStages.Value;
            }

            if (indirectStride is not null)
            {
                IndirectStride = indirectStride.Value;
            }

            if (pipelineLayout is not null)
            {
                PipelineLayout = pipelineLayout.Value;
            }

            if (tokenCount is not null)
            {
                TokenCount = tokenCount.Value;
            }

            if (pTokens is not null)
            {
                PTokens = pTokens;
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
        [NativeName("Type", "VkIndirectCommandsLayoutUsageFlagsEXT")]
        [NativeName("Type.Name", "VkIndirectCommandsLayoutUsageFlagsEXT")]
        [NativeName("Name", "flags")]
        public IndirectCommandsLayoutUsageFlagsEXT Flags;
/// <summary></summary>
        [NativeName("Type", "VkShaderStageFlags")]
        [NativeName("Type.Name", "VkShaderStageFlags")]
        [NativeName("Name", "shaderStages")]
        public ShaderStageFlags ShaderStages;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "indirectStride")]
        public uint IndirectStride;
/// <summary></summary>
        [NativeName("Type", "VkPipelineLayout")]
        [NativeName("Type.Name", "VkPipelineLayout")]
        [NativeName("Name", "pipelineLayout")]
        public PipelineLayout PipelineLayout;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "tokenCount")]
        public uint TokenCount;
/// <summary></summary>
        [NativeName("Type", "VkIndirectCommandsLayoutTokenEXT*")]
        [NativeName("Type.Name", "VkIndirectCommandsLayoutTokenEXT")]
        [NativeName("Name", "pTokens")]
        public IndirectCommandsLayoutTokenEXT* PTokens;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.IndirectCommandsLayoutCreateInfoExt;
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
        public static unsafe ref IndirectCommandsLayoutCreateInfoEXT Chain(
            out IndirectCommandsLayoutCreateInfoEXT capture)
        {
            capture = new IndirectCommandsLayoutCreateInfoEXT(StructureType.IndirectCommandsLayoutCreateInfoExt);
            return ref capture;
        }
    }
}
