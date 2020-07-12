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
    public unsafe struct EventDataBuffer
    {
        public EventDataBuffer
        (
            StructureType type = StructureType.TypeEventDataBuffer,
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
        /// <summary></summary>
       public fixed byte Varying[4000];
    }
}
