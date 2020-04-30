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
    public unsafe struct DescriptorSetLayoutCreateInfo
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
        public StructureType SType;
/// <summary></summary>
        public void* PNext;
/// <summary></summary>
        public DescriptorSetLayoutCreateFlags Flags;
/// <summary></summary>
        public uint BindingCount;
/// <summary></summary>
        public DescriptorSetLayoutBinding* PBindings;
    }
}
