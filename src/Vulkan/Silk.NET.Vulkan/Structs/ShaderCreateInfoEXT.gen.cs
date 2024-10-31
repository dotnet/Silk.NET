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
    [NativeName("Name", "VkShaderCreateInfoEXT")]
    public unsafe partial struct ShaderCreateInfoEXT : IChainStart
    {
        public ShaderCreateInfoEXT
        (
            StructureType? sType = StructureType.ShaderCreateInfoExt,
            void* pNext = null,
            ShaderCreateFlagsEXT? flags = null,
            ShaderStageFlags? stage = null,
            ShaderStageFlags? nextStage = null,
            ShaderCodeTypeEXT? codeType = null,
            nuint? codeSize = null,
            void* pCode = null,
            byte* pName = null,
            uint? setLayoutCount = null,
            DescriptorSetLayout* pSetLayouts = null,
            uint? pushConstantRangeCount = null,
            PushConstantRange* pPushConstantRanges = null,
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

            if (nextStage is not null)
            {
                NextStage = nextStage.Value;
            }

            if (codeType is not null)
            {
                CodeType = codeType.Value;
            }

            if (codeSize is not null)
            {
                CodeSize = codeSize.Value;
            }

            if (pCode is not null)
            {
                PCode = pCode;
            }

            if (pName is not null)
            {
                PName = pName;
            }

            if (setLayoutCount is not null)
            {
                SetLayoutCount = setLayoutCount.Value;
            }

            if (pSetLayouts is not null)
            {
                PSetLayouts = pSetLayouts;
            }

            if (pushConstantRangeCount is not null)
            {
                PushConstantRangeCount = pushConstantRangeCount.Value;
            }

            if (pPushConstantRanges is not null)
            {
                PPushConstantRanges = pPushConstantRanges;
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
        [NativeName("Type", "VkShaderCreateFlagsEXT")]
        [NativeName("Type.Name", "VkShaderCreateFlagsEXT")]
        [NativeName("Name", "flags")]
        public ShaderCreateFlagsEXT Flags;
/// <summary></summary>
        [NativeName("Type", "VkShaderStageFlagBits")]
        [NativeName("Type.Name", "VkShaderStageFlagBits")]
        [NativeName("Name", "stage")]
        public ShaderStageFlags Stage;
/// <summary></summary>
        [NativeName("Type", "VkShaderStageFlags")]
        [NativeName("Type.Name", "VkShaderStageFlags")]
        [NativeName("Name", "nextStage")]
        public ShaderStageFlags NextStage;
/// <summary></summary>
        [NativeName("Type", "VkShaderCodeTypeEXT")]
        [NativeName("Type.Name", "VkShaderCodeTypeEXT")]
        [NativeName("Name", "codeType")]
        public ShaderCodeTypeEXT CodeType;
/// <summary></summary>
        [NativeName("Type", "size_t")]
        [NativeName("Type.Name", "size_t")]
        [NativeName("Name", "codeSize")]
        public nuint CodeSize;
/// <summary></summary>
        [NativeName("Type", "void*")]
        [NativeName("Type.Name", "void")]
        [NativeName("Name", "pCode")]
        public void* PCode;
/// <summary></summary>
        [NativeName("Type", "char*")]
        [NativeName("Type.Name", "char")]
        [NativeName("Name", "pName")]
        public byte* PName;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "setLayoutCount")]
        public uint SetLayoutCount;
/// <summary></summary>
        [NativeName("Type", "VkDescriptorSetLayout*")]
        [NativeName("Type.Name", "VkDescriptorSetLayout")]
        [NativeName("Name", "pSetLayouts")]
        public DescriptorSetLayout* PSetLayouts;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "pushConstantRangeCount")]
        public uint PushConstantRangeCount;
/// <summary></summary>
        [NativeName("Type", "VkPushConstantRange*")]
        [NativeName("Type.Name", "VkPushConstantRange")]
        [NativeName("Name", "pPushConstantRanges")]
        public PushConstantRange* PPushConstantRanges;
/// <summary></summary>
        [NativeName("Type", "VkSpecializationInfo*")]
        [NativeName("Type.Name", "VkSpecializationInfo")]
        [NativeName("Name", "pSpecializationInfo")]
        public SpecializationInfo* PSpecializationInfo;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.ShaderCreateInfoExt;
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
        public static unsafe ref ShaderCreateInfoEXT Chain(
            out ShaderCreateInfoEXT capture)
        {
            capture = new ShaderCreateInfoEXT(StructureType.ShaderCreateInfoExt);
            return ref capture;
        }
    }
}
