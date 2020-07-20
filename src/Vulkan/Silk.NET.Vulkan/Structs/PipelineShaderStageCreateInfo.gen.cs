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
    [NativeName("Name", "VkPipelineShaderStageCreateInfo")]
    public unsafe partial struct PipelineShaderStageCreateInfo
    {
        public PipelineShaderStageCreateInfo
        (
            StructureType sType = StructureType.PipelineShaderStageCreateInfo,
            void* pNext = default,
            PipelineShaderStageCreateFlags flags = default,
            ShaderStageFlags stage = default,
            ShaderModule module = default,
            byte* pName = default,
            SpecializationInfo* pSpecializationInfo = default
        )
        {
            SType = sType;
            PNext = pNext;
            Flags = flags;
            Stage = stage;
            Module = module;
            PName = pName;
            PSpecializationInfo = pSpecializationInfo;
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
    }
}
