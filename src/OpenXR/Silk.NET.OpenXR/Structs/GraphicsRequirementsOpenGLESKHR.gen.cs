// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
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
            StructureType? type = StructureType.TypeGraphicsRequirementsOpenglESKhr,
            void* next = null,
            ulong? minApiVersionSupported = null,
            ulong? maxApiVersionSupported = null
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

            if (minApiVersionSupported is not null)
            {
                MinApiVersionSupported = minApiVersionSupported.Value;
            }

            if (maxApiVersionSupported is not null)
            {
                MaxApiVersionSupported = maxApiVersionSupported.Value;
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
