// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Ultz.SuperInvoke;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    public unsafe struct DescriptorUpdateTemplateEntry
    {
        public DescriptorUpdateTemplateEntry
        (
            uint dstBinding = default,
            uint dstArrayElement = default,
            uint descriptorCount = default,
            DescriptorType descriptorType = default,
            UIntPtr offset = default,
            UIntPtr stride = default
        )
        {
           DstBinding = dstBinding;
           DstArrayElement = dstArrayElement;
           DescriptorCount = descriptorCount;
           DescriptorType = descriptorType;
           Offset = offset;
           Stride = stride;
        }

/// <summary></summary>
        public uint DstBinding;
/// <summary></summary>
        public uint DstArrayElement;
/// <summary></summary>
        public uint DescriptorCount;
/// <summary></summary>
        public DescriptorType DescriptorType;
/// <summary></summary>
        public UIntPtr Offset;
/// <summary></summary>
        public UIntPtr Stride;
    }
}
