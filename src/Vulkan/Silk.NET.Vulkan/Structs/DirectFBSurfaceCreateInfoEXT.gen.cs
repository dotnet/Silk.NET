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
    public unsafe struct DirectFBSurfaceCreateInfoEXT
    {
        public DirectFBSurfaceCreateInfoEXT
        (
            StructureType sType = StructureType.DirectfbSurfaceCreateInfoExt,
            void* pNext = default,
            uint flags = default,
            IntPtr dfb = default,
            IntPtr surface = default
        )
        {
           SType = sType;
           PNext = pNext;
           Flags = flags;
           Dfb = dfb;
           Surface = surface;
        }

/// <summary></summary>
        public StructureType SType;
/// <summary></summary>
        public void* PNext;
/// <summary></summary>
        public uint Flags;
/// <summary></summary>
        public IntPtr Dfb;
/// <summary></summary>
        public IntPtr Surface;
    }
}
