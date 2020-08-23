// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkWaylandSurfaceCreateInfoKHR")]
    public unsafe partial struct WaylandSurfaceCreateInfoKHR
    {
        public WaylandSurfaceCreateInfoKHR
        (
            StructureType sType = StructureType.WaylandSurfaceCreateInfoKhr,
            void* pNext = default,
            uint flags = default,
            IntPtr* display = default,
            IntPtr* surface = default
        )
        {
            SType = sType;
            PNext = pNext;
            Flags = flags;
            Display = display;
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
        [NativeName("Type", "VkWaylandSurfaceCreateFlagsKHR")]
        [NativeName("Type.Name", "VkWaylandSurfaceCreateFlagsKHR")]
        [NativeName("Name", "flags")]
        public uint Flags;
/// <summary></summary>
        [NativeName("Type", "wl_display*")]
        [NativeName("Type.Name", "wl_display")]
        [NativeName("Name", "display")]
        public IntPtr* Display;
/// <summary></summary>
        [NativeName("Type", "wl_surface*")]
        [NativeName("Type.Name", "wl_surface")]
        [NativeName("Name", "surface")]
        public IntPtr* Surface;
    }
}
