// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


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
    [NativeName("Name", "XrGraphicsBindingEGLMNDX")]
    public unsafe partial struct GraphicsBindingEGLMNDX
    {
        public GraphicsBindingEGLMNDX
        (
            StructureType? type = StructureType.TypeGraphicsBindingEglMndx,
            void* next = null,
            PfnVoidFunction? getProcAddress = null,
            nint? display = null,
            nint? config = null,
            nint? context = null
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

            if (getProcAddress is not null)
            {
                GetProcAddress = getProcAddress.Value;
            }

            if (display is not null)
            {
                Display = display.Value;
            }

            if (config is not null)
            {
                Config = config.Value;
            }

            if (context is not null)
            {
                Context = context.Value;
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
        [NativeName("Type", "PFNEGLGETPROCADDRESSPROC")]
        [NativeName("Type.Name", "PFNEGLGETPROCADDRESSPROC")]
        [NativeName("Name", "getProcAddress")]
        public PfnVoidFunction GetProcAddress;
/// <summary></summary>
        [NativeName("Type", "EGLDisplay")]
        [NativeName("Type.Name", "EGLDisplay")]
        [NativeName("Name", "display")]
        public nint Display;
/// <summary></summary>
        [NativeName("Type", "EGLConfig")]
        [NativeName("Type.Name", "EGLConfig")]
        [NativeName("Name", "config")]
        public nint Config;
/// <summary></summary>
        [NativeName("Type", "EGLContext")]
        [NativeName("Type.Name", "EGLContext")]
        [NativeName("Name", "context")]
        public nint Context;
    }
}
