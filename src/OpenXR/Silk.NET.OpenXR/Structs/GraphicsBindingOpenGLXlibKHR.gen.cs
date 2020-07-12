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
    public unsafe struct GraphicsBindingOpenGLXlibKHR
    {
        public GraphicsBindingOpenGLXlibKHR
        (
            StructureType type = StructureType.TypeGraphicsBindingOpenglXlibKhr,
            void* next = default,
            IntPtr* xDisplay = default,
            uint visualid = default,
            GLXFBConfig glxFbconfig = default,
            IntPtr glxDrawable = default,
            IntPtr glxContext = default
        )
        {
           Type = type;
           Next = next;
           XDisplay = xDisplay;
           Visualid = visualid;
           GlxFbconfig = glxFbconfig;
           GlxDrawable = glxDrawable;
           GlxContext = glxContext;
        }

/// <summary></summary>
        public StructureType Type;
/// <summary></summary>
        public void* Next;
/// <summary></summary>
        public IntPtr* XDisplay;
/// <summary></summary>
        public uint Visualid;
/// <summary></summary>
        public GLXFBConfig GlxFbconfig;
/// <summary></summary>
        public IntPtr GlxDrawable;
/// <summary></summary>
        public IntPtr GlxContext;
    }
}
