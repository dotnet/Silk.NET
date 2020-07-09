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
    [NativeName("Name", "VkWin32SurfaceCreateInfoKHR")]
    public unsafe struct Win32SurfaceCreateInfoKHR
    {
        public Win32SurfaceCreateInfoKHR
        (
            StructureType sType = StructureType.Win32SurfaceCreateInfoKhr,
            void* pNext = default,
            uint flags = default,
            IntPtr hinstance = default,
            IntPtr hwnd = default
        )
        {
           SType = sType;
           PNext = pNext;
           Flags = flags;
           Hinstance = hinstance;
           Hwnd = hwnd;
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
