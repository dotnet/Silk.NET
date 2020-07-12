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
    public unsafe struct ActionsSyncInfo
    {
        public ActionsSyncInfo
        (
            StructureType type = StructureType.TypeActionsSyncInfo,
            void* next = default,
            uint countActiveActionSets = default,
            ActiveActionSet* activeActionSets = default
        )
        {
           Type = type;
           Next = next;
           CountActiveActionSets = countActiveActionSets;
           ActiveActionSets = activeActionSets;
        }

/// <summary></summary>
        public StructureType Type;
/// <summary></summary>
        public void* Next;
/// <summary></summary>
        public uint CountActiveActionSets;
/// <summary></summary>
        public ActiveActionSet* ActiveActionSets;
    }
}
