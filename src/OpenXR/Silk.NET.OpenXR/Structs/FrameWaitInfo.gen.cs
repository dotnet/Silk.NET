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
    public unsafe struct FrameWaitInfo
    {
        public FrameWaitInfo
        (
            StructureType type = StructureType.TypeFrameWaitInfo,
            void* next = default
        )
        {
           Type = type;
           Next = next;
        }

/// <summary></summary>
        public StructureType Type;
/// <summary></summary>
        public void* Next;
    }
}
