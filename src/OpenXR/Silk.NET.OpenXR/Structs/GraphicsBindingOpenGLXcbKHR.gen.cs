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
    public unsafe struct GraphicsBindingOpenGLXcbKHR
    {
        public GraphicsBindingOpenGLXcbKHR
        (
            StructureType type = StructureType.TypeGraphicsBindingOpenglXcbKhr,
            void* next = default,
            IntPtr* connection = default,
            uint screenNumber = default,
            xcb_glx_fbconfig_t fbconfigid = default,
            IntPtr visualid = default,
            xcb_glx_drawable_t glxDrawable = default,
            xcb_glx_context_t glxContext = default
        )
        {
           Type = type;
           Next = next;
           Connection = connection;
           ScreenNumber = screenNumber;
           Fbconfigid = fbconfigid;
           Visualid = visualid;
           GlxDrawable = glxDrawable;
           GlxContext = glxContext;
        }

/// <summary></summary>
        public StructureType Type;
/// <summary></summary>
        public void* Next;
/// <summary></summary>
        public IntPtr* Connection;
/// <summary></summary>
        public uint ScreenNumber;
/// <summary></summary>
        public xcb_glx_fbconfig_t Fbconfigid;
/// <summary></summary>
        public IntPtr Visualid;
/// <summary></summary>
        public xcb_glx_drawable_t GlxDrawable;
/// <summary></summary>
        public xcb_glx_context_t GlxContext;
    }
}
