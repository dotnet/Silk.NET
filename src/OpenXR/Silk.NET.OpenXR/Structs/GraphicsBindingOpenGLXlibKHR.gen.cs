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
    [NativeName("Name", "XrGraphicsBindingOpenGLXlibKHR")]
    public unsafe partial struct GraphicsBindingOpenGLXlibKHR
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
        [NativeName("Type", "Display*")]
        [NativeName("Type.Name", "Display")]
        [NativeName("Name", "xDisplay")]
        public IntPtr* XDisplay;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "visualid")]
        public uint Visualid;
/// <summary></summary>
        [NativeName("Type", "GLXFBConfig")]
        [NativeName("Type.Name", "GLXFBConfig")]
        [NativeName("Name", "glxFBConfig")]
        public GLXFBConfig GlxFbconfig;
/// <summary></summary>
        [NativeName("Type", "GLXDrawable")]
        [NativeName("Type.Name", "GLXDrawable")]
        [NativeName("Name", "glxDrawable")]
        public IntPtr GlxDrawable;
/// <summary></summary>
        [NativeName("Type", "GLXContext")]
        [NativeName("Type.Name", "GLXContext")]
        [NativeName("Name", "glxContext")]
        public IntPtr GlxContext;
    }
}
