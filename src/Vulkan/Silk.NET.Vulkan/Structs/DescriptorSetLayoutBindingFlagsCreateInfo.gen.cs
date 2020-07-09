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
    [NativeName("Name", "VkDescriptorSetLayoutBindingFlagsCreateInfo")]
    public unsafe struct DescriptorSetLayoutBindingFlagsCreateInfo
    {
        public DescriptorSetLayoutBindingFlagsCreateInfo
        (
            StructureType sType = StructureType.DescriptorSetLayoutBindingFlagsCreateInfo,
            void* pNext = default,
            uint bindingCount = default,
            DescriptorBindingFlags* pBindingFlags = default
        )
        {
           SType = sType;
           PNext = pNext;
           BindingCount = bindingCount;
           PBindingFlags = pBindingFlags;
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
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "bindingCount")]
        public uint BindingCount;
/// <summary></summary>
        [NativeName("Type", "VkDescriptorBindingFlags*")]
        [NativeName("Type.Name", "VkDescriptorBindingFlags")]
        [NativeName("Name", "pBindingFlags")]
        public DescriptorBindingFlags* PBindingFlags;
    }
}
