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
    public unsafe struct GraphicsRequirementsOpenGLKHR
    {
        public GraphicsRequirementsOpenGLKHR
        (
            StructureType type = StructureType.TypeGraphicsRequirementsOpenglKhr,
            void* next = default,
            ulong minApiVersionSupported = default,
            ulong maxApiVersionSupported = default
        )
        {
           Type = type;
           Next = next;
           MinApiVersionSupported = minApiVersionSupported;
           MaxApiVersionSupported = maxApiVersionSupported;
        }

/// <summary></summary>
        public StructureType Type;
/// <summary></summary>
        public void* Next;
/// <summary></summary>
        public ulong MinApiVersionSupported;
/// <summary></summary>
        public ulong MaxApiVersionSupported;
    }
}
