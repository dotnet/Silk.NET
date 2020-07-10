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
    [NativeName("Name", "VkDescriptorSetLayoutCreateInfo")]
    public unsafe partial struct DescriptorSetLayoutCreateInfo
    {
        public DescriptorSetLayoutCreateInfo
        (
            StructureType sType = StructureType.DescriptorSetLayoutCreateInfo,
            void* pNext = default,
            DescriptorSetLayoutCreateFlags flags = default,
            uint bindingCount = default,
            DescriptorSetLayoutBinding* pBindings = default
        )
        {
            SType = sType;
            PNext = pNext;
            Flags = flags;
            BindingCount = bindingCount;
            PBindings = pBindings;
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
        [NativeName("Type", "VkDescriptorSetLayoutCreateFlags")]
        [NativeName("Type.Name", "VkDescriptorSetLayoutCreateFlags")]
        [NativeName("Name", "flags")]
        public DescriptorSetLayoutCreateFlags Flags;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "bindingCount")]
        public uint BindingCount;
/// <summary></summary>
        [NativeName("Type", "VkDescriptorSetLayoutBinding*")]
        [NativeName("Type.Name", "VkDescriptorSetLayoutBinding")]
        [NativeName("Name", "pBindings")]
        public DescriptorSetLayoutBinding* PBindings;
    }
}
