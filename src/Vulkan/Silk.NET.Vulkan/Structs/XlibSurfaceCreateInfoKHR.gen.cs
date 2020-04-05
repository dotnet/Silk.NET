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
    public unsafe struct XlibSurfaceCreateInfoKHR
    {
        public XlibSurfaceCreateInfoKHR
        (
            StructureType sType = StructureType.XlibSurfaceCreateInfoKhr,
            void* pNext = default,
            uint flags = default,
            IntPtr* dpy = default,
            IntPtr window = default
        )
        {
           SType = sType;
           PNext = pNext;
           Flags = flags;
           Dpy = dpy;
           Window = window;
        }

/// <summary></summary>
        public StructureType SType;
/// <summary></summary>
        public void* PNext;
/// <summary></summary>
        public uint Flags;
/// <summary></summary>
        public IntPtr* Dpy;
/// <summary></summary>
        public IntPtr Window;
    }
}
