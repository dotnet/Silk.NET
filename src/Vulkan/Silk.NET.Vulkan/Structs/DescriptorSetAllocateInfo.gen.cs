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
    [NativeName("Name", "VkDescriptorSetAllocateInfo")]
    public unsafe partial struct DescriptorSetAllocateInfo
    {
        public DescriptorSetAllocateInfo
        (
            StructureType sType = StructureType.DescriptorSetAllocateInfo,
            void* pNext = default,
            DescriptorPool descriptorPool = default,
            uint descriptorSetCount = default,
            DescriptorSetLayout* pSetLayouts = default
        )
        {
            SType = sType;
            PNext = pNext;
            DescriptorPool = descriptorPool;
            DescriptorSetCount = descriptorSetCount;
            PSetLayouts = pSetLayouts;
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
        [NativeName("Type", "VkDescriptorPool")]
        [NativeName("Type.Name", "VkDescriptorPool")]
        [NativeName("Name", "descriptorPool")]
        public DescriptorPool DescriptorPool;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "descriptorSetCount")]
        public uint DescriptorSetCount;
/// <summary></summary>
        [NativeName("Type", "VkDescriptorSetLayout*")]
        [NativeName("Type.Name", "VkDescriptorSetLayout")]
        [NativeName("Name", "pSetLayouts")]
        public DescriptorSetLayout* PSetLayouts;
    }
}
