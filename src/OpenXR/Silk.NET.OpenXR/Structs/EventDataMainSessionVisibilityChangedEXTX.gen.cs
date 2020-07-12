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
    public unsafe struct EventDataMainSessionVisibilityChangedEXTX
    {
        public EventDataMainSessionVisibilityChangedEXTX
        (
            StructureType type = StructureType.TypeEventDataMainSessionVisibilityChangedExtx,
            void* next = default,
            uint visible = default,
            OverlayMainSessionFlagsEXTX flags = default
        )
        {
           Type = type;
           Next = next;
           Visible = visible;
           Flags = flags;
        }

/// <summary></summary>
        public StructureType Type;
/// <summary></summary>
        public void* Next;
/// <summary></summary>
        public uint Visible;
/// <summary></summary>
        public OverlayMainSessionFlagsEXTX Flags;
    }
}
