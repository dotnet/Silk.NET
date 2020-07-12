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
    public unsafe struct ActionSetCreateInfo
    {
        public ActionSetCreateInfo
        (
            StructureType type = StructureType.TypeActionSetCreateInfo,
            void* next = default,
            uint priority = default
        )
        {
           Type = type;
           Next = next;
           Priority = priority;
        }

/// <summary></summary>
        public StructureType Type;
/// <summary></summary>
        public void* Next;
        /// <summary></summary>
       public fixed byte ActionSetName[64];
        /// <summary></summary>
       public fixed byte LocalizedActionSetName[128];
/// <summary></summary>
        public uint Priority;
    }
}
