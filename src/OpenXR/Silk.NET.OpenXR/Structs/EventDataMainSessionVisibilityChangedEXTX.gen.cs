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
    [NativeName("Name", "XrEventDataMainSessionVisibilityChangedEXTX")]
    public unsafe partial struct EventDataMainSessionVisibilityChangedEXTX
    {
        public EventDataMainSessionVisibilityChangedEXTX
        (
            StructureType? type = StructureType.TypeEventDataMainSessionVisibilityChangedExtx,
            void* next = null,
            uint? visible = null,
            OverlayMainSessionFlagsEXTX? flags = null
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

            if (visible is not null)
            {
                Visible = visible.Value;
            }

            if (flags is not null)
            {
                Flags = flags.Value;
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
        [NativeName("Type", "XrBool32")]
        [NativeName("Type.Name", "XrBool32")]
        [NativeName("Name", "visible")]
        public uint Visible;
/// <summary></summary>
        [NativeName("Type", "XrOverlayMainSessionFlagsEXTX")]
        [NativeName("Type.Name", "XrOverlayMainSessionFlagsEXTX")]
        [NativeName("Name", "flags")]
        public OverlayMainSessionFlagsEXTX Flags;
    }
}
