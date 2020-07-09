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
    [NativeName("Name", "VkDescriptorSetLayoutBinding")]
    public unsafe struct DescriptorSetLayoutBinding
    {
        public DescriptorSetLayoutBinding
        (
            uint binding = default,
            DescriptorType descriptorType = default,
            uint descriptorCount = default,
            ShaderStageFlags stageFlags = default,
            Sampler* pImmutableSamplers = default
        )
        {
           Binding = binding;
           DescriptorType = descriptorType;
           DescriptorCount = descriptorCount;
           StageFlags = stageFlags;
           PImmutableSamplers = pImmutableSamplers;
        }

/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "binding")]
        public uint Binding;
/// <summary></summary>
        [NativeName("Type", "VkDescriptorType")]
        [NativeName("Type.Name", "VkDescriptorType")]
        [NativeName("Name", "descriptorType")]
        public DescriptorType DescriptorType;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "descriptorCount")]
        public uint DescriptorCount;
/// <summary></summary>
        [NativeName("Type", "VkShaderStageFlags")]
        [NativeName("Type.Name", "VkShaderStageFlags")]
        [NativeName("Name", "stageFlags")]
        public ShaderStageFlags StageFlags;
/// <summary></summary>
        [NativeName("Type", "VkSampler*")]
        [NativeName("Type.Name", "VkSampler")]
        [NativeName("Name", "pImmutableSamplers")]
        public Sampler* PImmutableSamplers;
    }
}
