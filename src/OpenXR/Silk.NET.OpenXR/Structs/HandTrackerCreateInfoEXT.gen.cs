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
    [NativeName("Name", "XrHandTrackerCreateInfoEXT")]
    public unsafe partial struct HandTrackerCreateInfoEXT
    {
        public HandTrackerCreateInfoEXT
        (
            StructureType type = StructureType.TypeHandTrackerCreateInfoExt,
            void* next = default,
            HandEXT hand = default,
            HandJointSetEXT handJointSet = default
        )
        {
            Type = type;
            Next = next;
            Hand = hand;
            HandJointSet = handJointSet;
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
        [NativeName("Type", "XrHandEXT")]
        [NativeName("Type.Name", "XrHandEXT")]
        [NativeName("Name", "hand")]
        public HandEXT Hand;
/// <summary></summary>
        [NativeName("Type", "XrHandJointSetEXT")]
        [NativeName("Type.Name", "XrHandJointSetEXT")]
        [NativeName("Name", "handJointSet")]
        public HandJointSetEXT HandJointSet;
    }
}
