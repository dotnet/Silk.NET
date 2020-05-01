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
    public unsafe struct DescriptorPoolSize
    {
        public DescriptorPoolSize
        (
            DescriptorType type = default,
            uint descriptorCount = default
        )
        {
           Type = type;
           DescriptorCount = descriptorCount;
        }

/// <summary></summary>
        public DescriptorType Type;
/// <summary></summary>
        public uint DescriptorCount;
    }
}
