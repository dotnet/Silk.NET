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
    public unsafe struct GraphicsBindingOpenGLESAndroidKHR
    {
        public GraphicsBindingOpenGLESAndroidKHR
        (
            StructureType type = StructureType.TypeGraphicsBindingOpenglESAndroidKhr,
            void* next = default,
            EGLDisplay display = default,
            EGLConfig config = default,
            EGLContext context = default
        )
        {
           Type = type;
           Next = next;
           Display = display;
           Config = config;
           Context = context;
        }

/// <summary></summary>
        public StructureType Type;
/// <summary></summary>
        public void* Next;
/// <summary></summary>
        public EGLDisplay Display;
/// <summary></summary>
        public EGLConfig Config;
/// <summary></summary>
        public EGLContext Context;
    }
}
