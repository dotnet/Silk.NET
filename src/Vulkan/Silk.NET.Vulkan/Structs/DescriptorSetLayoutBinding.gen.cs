// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Ultz.SuperInvoke;

namespace Silk.NET.Vulkan
{
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
        public uint Binding;
/// <summary></summary>
        public DescriptorType DescriptorType;
/// <summary></summary>
        public uint DescriptorCount;
/// <summary></summary>
        public ShaderStageFlags StageFlags;
/// <summary></summary>
        public Sampler* PImmutableSamplers;
    }
}
