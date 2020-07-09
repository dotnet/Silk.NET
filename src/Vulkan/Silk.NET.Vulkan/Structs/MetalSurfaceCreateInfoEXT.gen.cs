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
    [NativeName("Name", "VkMetalSurfaceCreateInfoEXT")]
    public unsafe struct MetalSurfaceCreateInfoEXT
    {
        public MetalSurfaceCreateInfoEXT
        (
            StructureType sType = StructureType.MetalSurfaceCreateInfoExt,
            void* pNext = default,
            uint flags = default,
            IntPtr* pLayer = default
        )
        {
           SType = sType;
           PNext = pNext;
           Flags = flags;
           PLayer = pLayer;
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
        [NativeName("Type", "VkMetalSurfaceCreateFlagsEXT")]
        [NativeName("Type.Name", "VkMetalSurfaceCreateFlagsEXT")]
        [NativeName("Name", "flags")]
        public uint Flags;
/// <summary></summary>
        [NativeName("Type", "CAMetalLayer*")]
        [NativeName("Type.Name", "CAMetalLayer")]
        [NativeName("Name", "pLayer")]
        public IntPtr* PLayer;
    }
}
