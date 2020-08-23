// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.OpenXR
{
    [NativeName("Name", "XrGraphicsRequirementsOpenGLESKHR")]
    public unsafe partial struct GraphicsRequirementsOpenGLESKHR
    {
        public GraphicsRequirementsOpenGLESKHR
        (
            StructureType type = StructureType.TypeGraphicsRequirementsOpenglESKhr,
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
        [NativeName("Type", "XrVersion")]
        [NativeName("Type.Name", "XrVersion")]
        [NativeName("Name", "minApiVersionSupported")]
        public ulong MinApiVersionSupported;
/// <summary></summary>
        [NativeName("Type", "XrVersion")]
        [NativeName("Type.Name", "XrVersion")]
        [NativeName("Name", "maxApiVersionSupported")]
        public ulong MaxApiVersionSupported;
    }
}
