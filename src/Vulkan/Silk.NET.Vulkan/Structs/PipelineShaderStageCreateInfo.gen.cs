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
    [NativeName("Name", "VkPipelineShaderStageCreateInfo")]
    public unsafe partial struct PipelineShaderStageCreateInfo : IChainStart
    {
        public PipelineShaderStageCreateInfo
        (
            StructureType? sType = StructureType.PipelineShaderStageCreateInfo,
            void* pNext = null,
            PipelineShaderStageCreateFlags? flags = null,
            ShaderStageFlags? stage = null,
            ShaderModule? module = null,
            byte* pName = null,
            SpecializationInfo* pSpecializationInfo = null
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

            if (stage is not null)
            {
                Stage = stage.Value;
            }

            if (module is not null)
            {
                Module = module.Value;
            }

            if (pName is not null)
            {
                PName = pName;
            }

            if (pSpecializationInfo is not null)
            {
                PSpecializationInfo = pSpecializationInfo;
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
        [NativeName("Type", "VkPipelineShaderStageCreateFlags")]
        [NativeName("Type.Name", "VkPipelineShaderStageCreateFlags")]
        [NativeName("Name", "flags")]
        public PipelineShaderStageCreateFlags Flags;
/// <summary></summary>
        [NativeName("Type", "VkShaderStageFlagBits")]
        [NativeName("Type.Name", "VkShaderStageFlagBits")]
        [NativeName("Name", "stage")]
        public ShaderStageFlags Stage;
/// <summary></summary>
        [NativeName("Type", "VkShaderModule")]
        [NativeName("Type.Name", "VkShaderModule")]
        [NativeName("Name", "module")]
        public ShaderModule Module;
/// <summary></summary>
        [NativeName("Type", "char*")]
        [NativeName("Type.Name", "char")]
        [NativeName("Name", "pName")]
        public byte* PName;
/// <summary></summary>
        [NativeName("Type", "VkSpecializationInfo*")]
        [NativeName("Type.Name", "VkSpecializationInfo")]
        [NativeName("Name", "pSpecializationInfo")]
        public SpecializationInfo* PSpecializationInfo;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.PipelineShaderStageCreateInfo;
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
        public static unsafe ref PipelineShaderStageCreateInfo Chain(
            out PipelineShaderStageCreateInfo capture)
        {
            capture = new PipelineShaderStageCreateInfo(StructureType.PipelineShaderStageCreateInfo);
            return ref capture;
        }
    }
}
