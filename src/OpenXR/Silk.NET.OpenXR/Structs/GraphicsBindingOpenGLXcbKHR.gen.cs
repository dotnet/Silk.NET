// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


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

namespace Silk.NET.OpenXR
{
    [NativeName("Name", "XrGraphicsBindingOpenGLXcbKHR")]
    public unsafe partial struct GraphicsBindingOpenGLXcbKHR
    {
        public GraphicsBindingOpenGLXcbKHR
        (
            StructureType? type = StructureType.TypeGraphicsBindingOpenglXcbKhr,
            void* next = null,
            nint* connection = null,
            uint? screenNumber = null,
            nint? fbconfigid = null,
            nint? visualid = null,
            nint? glxDrawable = null,
            nint? glxContext = null
        ) : this()
        {
            if (type is not null)
            {
                Type = type.Value;
            }

            if (next is not null)
            {
                Next = next;
            }

            if (connection is not null)
            {
                Connection = connection;
            }

            if (screenNumber is not null)
            {
                ScreenNumber = screenNumber.Value;
            }

            if (fbconfigid is not null)
            {
                Fbconfigid = fbconfigid.Value;
            }

            if (visualid is not null)
            {
                Visualid = visualid.Value;
            }

            if (glxDrawable is not null)
            {
                GlxDrawable = glxDrawable.Value;
            }

            if (glxContext is not null)
            {
                GlxContext = glxContext.Value;
            }
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
        public nint* Connection;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "screenNumber")]
        public uint ScreenNumber;
/// <summary></summary>
        [NativeName("Type", "xcb_glx_fbconfig_t")]
        [NativeName("Type.Name", "xcb_glx_fbconfig_t")]
        [NativeName("Name", "fbconfigid")]
        public nint Fbconfigid;
/// <summary></summary>
        [NativeName("Type", "xcb_visualid_t")]
        [NativeName("Type.Name", "xcb_visualid_t")]
        [NativeName("Name", "visualid")]
        public nint Visualid;
/// <summary></summary>
        [NativeName("Type", "xcb_glx_drawable_t")]
        [NativeName("Type.Name", "xcb_glx_drawable_t")]
        [NativeName("Name", "glxDrawable")]
        public nint GlxDrawable;
/// <summary></summary>
        [NativeName("Type", "xcb_glx_context_t")]
        [NativeName("Type.Name", "xcb_glx_context_t")]
        [NativeName("Name", "glxContext")]
        public nint GlxContext;
    }
}
