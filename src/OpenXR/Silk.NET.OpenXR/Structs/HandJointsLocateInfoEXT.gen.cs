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
    public unsafe struct HandJointsLocateInfoEXT
    {
        public HandJointsLocateInfoEXT
        (
            StructureType type = StructureType.TypeHandJointsLocateInfoExt,
            void* next = default,
            Space baseSpace = default,
            long time = default
        )
        {
           Type = type;
           Next = next;
           BaseSpace = baseSpace;
           Time = time;
        }

/// <summary></summary>
        public StructureType Type;
/// <summary></summary>
        public void* Next;
/// <summary></summary>
        public Space BaseSpace;
/// <summary></summary>
        public long Time;
    }
}
