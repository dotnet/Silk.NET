// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Ultz.SuperInvoke;

namespace Silk.NET.Vulkan
{
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
        public StructureType SType;
/// <summary></summary>
        public void* PNext;
/// <summary></summary>
        public uint Flags;
/// <summary></summary>
        public IntPtr Hinstance;
/// <summary></summary>
        public IntPtr Hwnd;
    }
}
