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
    [NativeName("Name", "VkStreamDescriptorSurfaceCreateInfoGGP")]
    public unsafe partial struct StreamDescriptorSurfaceCreateInfoGGP
    {
        public StreamDescriptorSurfaceCreateInfoGGP
        (
            StructureType sType = StructureType.StreamDescriptorSurfaceCreateInfoGgp,
            void* pNext = default,
            uint flags = default,
            IntPtr streamDescriptor = default
        )
        {
            SType = sType;
            PNext = pNext;
            Flags = flags;
            StreamDescriptor = streamDescriptor;
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
        [NativeName("Type", "VkStreamDescriptorSurfaceCreateFlagsGGP")]
        [NativeName("Type.Name", "VkStreamDescriptorSurfaceCreateFlagsGGP")]
        [NativeName("Name", "flags")]
        public uint Flags;
/// <summary></summary>
        [NativeName("Type", "GgpStreamDescriptor")]
        [NativeName("Type.Name", "GgpStreamDescriptor")]
        [NativeName("Name", "streamDescriptor")]
        public IntPtr StreamDescriptor;
    }
}
