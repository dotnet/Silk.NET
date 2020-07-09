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
    [NativeName("Name", "VkDirectFBSurfaceCreateInfoEXT")]
    public unsafe struct DirectFBSurfaceCreateInfoEXT
    {
        public DirectFBSurfaceCreateInfoEXT
        (
            StructureType sType = StructureType.DirectfbSurfaceCreateInfoExt,
            void* pNext = default,
            uint flags = default,
            IDirectFB* dfb = default,
            IDirectFBSurface* surface = default
        )
        {
           SType = sType;
           PNext = pNext;
           Flags = flags;
           Dfb = dfb;
           Surface = surface;
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
        [NativeName("Type", "VkDirectFBSurfaceCreateFlagsEXT")]
        [NativeName("Type.Name", "VkDirectFBSurfaceCreateFlagsEXT")]
        [NativeName("Name", "flags")]
        public uint Flags;
/// <summary></summary>
        [NativeName("Type", "IDirectFB*")]
        [NativeName("Type.Name", "IDirectFB")]
        [NativeName("Name", "dfb")]
        public IDirectFB* Dfb;
/// <summary></summary>
        [NativeName("Type", "IDirectFBSurface*")]
        [NativeName("Type.Name", "IDirectFBSurface")]
        [NativeName("Name", "surface")]
        public IDirectFBSurface* Surface;
    }
}
