// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Ultz.SuperInvoke;

#pragma warning disable 1591

namespace Silk.NET.OpenXR
{
    [NativeName("Name", "XrActionsSyncInfo")]
    public unsafe partial struct ActionsSyncInfo
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
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "countActiveActionSets")]
        public uint CountActiveActionSets;
/// <summary></summary>
        [NativeName("Type", "XrActiveActionSet*")]
        [NativeName("Type.Name", "XrActiveActionSet")]
        [NativeName("Name", "activeActionSets")]
        public ActiveActionSet* ActiveActionSets;
    }
}
