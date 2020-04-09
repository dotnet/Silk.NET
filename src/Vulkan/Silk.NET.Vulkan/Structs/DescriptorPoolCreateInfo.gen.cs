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
    public unsafe struct DescriptorPoolCreateInfo
    {
        public DescriptorPoolCreateInfo
        (
            StructureType sType = StructureType.DescriptorPoolCreateInfo,
            void* pNext = default,
            DescriptorPoolCreateFlags flags = default,
            uint maxSets = default,
            uint poolSizeCount = default,
            DescriptorPoolSize* pPoolSizes = default
        )
        {
           SType = sType;
           PNext = pNext;
           Flags = flags;
           MaxSets = maxSets;
           PoolSizeCount = poolSizeCount;
           PPoolSizes = pPoolSizes;
        }

/// <summary></summary>
        public StructureType SType;
/// <summary></summary>
        public void* PNext;
/// <summary></summary>
        public DescriptorPoolCreateFlags Flags;
/// <summary></summary>
        public uint MaxSets;
/// <summary></summary>
        public uint PoolSizeCount;
/// <summary></summary>
        public DescriptorPoolSize* PPoolSizes;
    }
}
