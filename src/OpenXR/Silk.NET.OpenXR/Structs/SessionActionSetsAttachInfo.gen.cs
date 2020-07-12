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
    public unsafe struct SessionActionSetsAttachInfo
    {
        public SessionActionSetsAttachInfo
        (
            StructureType type = StructureType.TypeSessionActionSetsAttachInfo,
            void* next = default,
            uint countActionSets = default,
            ActionSet* actionSets = default
        )
        {
           Type = type;
           Next = next;
           CountActionSets = countActionSets;
           ActionSets = actionSets;
        }

/// <summary></summary>
        public StructureType Type;
/// <summary></summary>
        public void* Next;
/// <summary></summary>
        public uint CountActionSets;
/// <summary></summary>
        public ActionSet* ActionSets;
    }
}
