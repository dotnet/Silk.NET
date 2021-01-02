// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkXcbSurfaceCreateInfoKHR")]
    public unsafe partial struct XcbSurfaceCreateInfoKHR
    {
        public XcbSurfaceCreateInfoKHR
        (
            StructureType? sType = StructureType.XcbSurfaceCreateInfoKhr,
            void* pNext = null,
            uint? flags = null,
            nint* connection = null,
            nint? window = null
        ) : this()
        {
            if (sType is not null)
            {
                SType = sType.Value;
            }

            if (pNext is not null)
            {
                PNext = pNext;
            }

            if (flags is not null)
            {
                Flags = flags.Value;
            }

            if (connection is not null)
            {
                Connection = connection;
            }

            if (window is not null)
            {
                Window = window.Value;
            }
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
        public nint* Connection;
/// <summary></summary>
        [NativeName("Type", "xcb_window_t")]
        [NativeName("Type.Name", "xcb_window_t")]
        [NativeName("Name", "window")]
        public nint Window;
    }
}
