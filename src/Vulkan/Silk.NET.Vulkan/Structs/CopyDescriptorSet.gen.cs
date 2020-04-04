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
    public unsafe struct CopyDescriptorSet
    {
        public CopyDescriptorSet
        (
            StructureType sType = StructureType.CopyDescriptorSet,
            void* pNext = default,
            DescriptorSet srcSet = default,
            uint srcBinding = default,
            uint srcArrayElement = default,
            DescriptorSet dstSet = default,
            uint dstBinding = default,
            uint dstArrayElement = default,
            uint descriptorCount = default
        )
        {
           SType = sType;
           PNext = pNext;
           SrcSet = srcSet;
           SrcBinding = srcBinding;
           SrcArrayElement = srcArrayElement;
           DstSet = dstSet;
           DstBinding = dstBinding;
           DstArrayElement = dstArrayElement;
           DescriptorCount = descriptorCount;
        }

/// <summary></summary>
        public StructureType SType;
/// <summary></summary>
        public void* PNext;
/// <summary></summary>
        public DescriptorSet SrcSet;
/// <summary></summary>
        public uint SrcBinding;
/// <summary></summary>
        public uint SrcArrayElement;
/// <summary></summary>
        public DescriptorSet DstSet;
/// <summary></summary>
        public uint DstBinding;
/// <summary></summary>
        public uint DstArrayElement;
/// <summary></summary>
        public uint DescriptorCount;
    }
}
