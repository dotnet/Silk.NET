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

namespace Silk.NET.OpenXR
{
    [NativeName("Name", "XrGraphicsBindingOpenGLWin32KHR")]
    public unsafe partial struct GraphicsBindingOpenGLWin32KHR
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
        [NativeName("Type", "XrStructureType")]
        [NativeName("Type.Name", "XrStructureType")]
        [NativeName("Name", "type")]
        public StructureType Type;
/// <summary></summary>
        [NativeName("Type", "void*")]
        [NativeName("Type.Name", "void")]
        [NativeName("Name", "next")]
        public void* Next;
/// <summary></summary>
        [NativeName("Type", "HDC")]
        [NativeName("Type.Name", "HDC")]
        [NativeName("Name", "hDC")]
        public IntPtr HDC;
/// <summary></summary>
        [NativeName("Type", "HGLRC")]
        [NativeName("Type.Name", "HGLRC")]
        [NativeName("Name", "hGLRC")]
        public IntPtr HGlrc;
    }
}
