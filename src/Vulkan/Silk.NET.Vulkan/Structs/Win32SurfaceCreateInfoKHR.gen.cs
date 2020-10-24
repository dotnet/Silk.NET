// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkWin32SurfaceCreateInfoKHR")]
    public unsafe partial struct Win32SurfaceCreateInfoKHR
    {
        public Win32SurfaceCreateInfoKHR
        (
            StructureType? sType = StructureType.Win32SurfaceCreateInfoKhr,
            void* pNext = null,
            uint? flags = null,
            IntPtr? hinstance = null,
            IntPtr? hwnd = null
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

            if (hinstance is not null)
            {
                Hinstance = hinstance.Value;
            }

            if (hwnd is not null)
            {
                Hwnd = hwnd.Value;
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
        [NativeName("Type", "VkWin32SurfaceCreateFlagsKHR")]
        [NativeName("Type.Name", "VkWin32SurfaceCreateFlagsKHR")]
        [NativeName("Name", "flags")]
        public uint Flags;
/// <summary></summary>
        [NativeName("Type", "HINSTANCE")]
        [NativeName("Type.Name", "HINSTANCE")]
        [NativeName("Name", "hinstance")]
        public IntPtr Hinstance;
/// <summary></summary>
        [NativeName("Type", "HWND")]
        [NativeName("Type.Name", "HWND")]
        [NativeName("Name", "hwnd")]
        public IntPtr Hwnd;
    }
}
