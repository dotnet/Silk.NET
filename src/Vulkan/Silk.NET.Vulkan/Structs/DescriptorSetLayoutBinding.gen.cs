// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


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
    [NativeName("Name", "VkDescriptorSetLayoutBinding")]
    public unsafe partial struct DescriptorSetLayoutBinding
    {
        public DescriptorSetLayoutBinding
        (
            uint? binding = null,
            DescriptorType? descriptorType = null,
            uint? descriptorCount = null,
            ShaderStageFlags? stageFlags = null,
            Sampler* pImmutableSamplers = null
        ) : this()
        {
            if (binding is not null)
            {
                Binding = binding.Value;
            }

            if (descriptorType is not null)
            {
                DescriptorType = descriptorType.Value;
            }

            if (descriptorCount is not null)
            {
                DescriptorCount = descriptorCount.Value;
            }

            if (stageFlags is not null)
            {
                StageFlags = stageFlags.Value;
            }

            if (pImmutableSamplers is not null)
            {
                PImmutableSamplers = pImmutableSamplers;
            }
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
