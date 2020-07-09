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
    [NativeName("Name", "VkXcbSurfaceCreateInfoKHR")]
    public unsafe struct XcbSurfaceCreateInfoKHR
    {
        public XcbSurfaceCreateInfoKHR
        (
            StructureType sType = StructureType.XcbSurfaceCreateInfoKhr,
            void* pNext = default,
            uint flags = default,
            IntPtr* connection = default,
            IntPtr window = default
        )
        {
           SType = sType;
           PNext = pNext;
           Flags = flags;
           Connection = connection;
           Window = window;
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
        [NativeName("Type", "VkXcbSurfaceCreateFlagsKHR")]
        [NativeName("Type.Name", "VkXcbSurfaceCreateFlagsKHR")]
        [NativeName("Name", "flags")]
        public uint Flags;
/// <summary></summary>
        [NativeName("Type", "xcb_connection_t*")]
        [NativeName("Type.Name", "xcb_connection_t")]
        [NativeName("Name", "connection")]
        public IntPtr* Connection;
/// <summary></summary>
        [NativeName("Type", "xcb_window_t")]
        [NativeName("Type.Name", "xcb_window_t")]
        [NativeName("Name", "window")]
        public IntPtr Window;
    }
}
