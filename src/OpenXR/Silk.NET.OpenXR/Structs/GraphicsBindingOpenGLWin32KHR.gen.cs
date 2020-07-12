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

namespace Silk.NET.OpenXR
{
    public unsafe struct GraphicsBindingOpenGLWin32KHR
    {
        public GraphicsBindingOpenGLWin32KHR
        (
            StructureType type = StructureType.TypeGraphicsBindingOpenglWin32Khr,
            void* next = default,
            IntPtr hDC = default,
            IntPtr hGlrc = default
        )
        {
           Type = type;
           Next = next;
           HDC = hDC;
           HGlrc = hGlrc;
        }

/// <summary></summary>
        public StructureType Type;
/// <summary></summary>
        public void* Next;
/// <summary></summary>
        public IntPtr HDC;
/// <summary></summary>
        public IntPtr HGlrc;
    }
}
