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
    [NativeName("Name", "XrGraphicsBindingOpenGLXcbKHR")]
    public unsafe partial struct GraphicsBindingOpenGLXcbKHR
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
        [NativeName("Type", "xcb_connection_t*")]
        [NativeName("Type.Name", "xcb_connection_t")]
        [NativeName("Name", "connection")]
        public IntPtr* Connection;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "screenNumber")]
        public uint ScreenNumber;
/// <summary></summary>
        [NativeName("Type", "xcb_glx_fbconfig_t")]
        [NativeName("Type.Name", "xcb_glx_fbconfig_t")]
        [NativeName("Name", "fbconfigid")]
        public xcb_glx_fbconfig_t Fbconfigid;
/// <summary></summary>
        [NativeName("Type", "xcb_visualid_t")]
        [NativeName("Type.Name", "xcb_visualid_t")]
        [NativeName("Name", "visualid")]
        public IntPtr Visualid;
/// <summary></summary>
        [NativeName("Type", "xcb_glx_drawable_t")]
        [NativeName("Type.Name", "xcb_glx_drawable_t")]
        [NativeName("Name", "glxDrawable")]
        public xcb_glx_drawable_t GlxDrawable;
/// <summary></summary>
        [NativeName("Type", "xcb_glx_context_t")]
        [NativeName("Type.Name", "xcb_glx_context_t")]
        [NativeName("Name", "glxContext")]
        public xcb_glx_context_t GlxContext;
    }
}
