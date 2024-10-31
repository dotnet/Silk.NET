// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.OpenXR
{
    [NativeName("Name", "XrHandTrackerCreateInfoEXT")]
    public unsafe partial struct HandTrackerCreateInfoEXT
    {
        public HandTrackerCreateInfoEXT
        (
            StructureType? type = StructureType.TypeHandTrackerCreateInfoExt,
            void* next = null,
            HandEXT? hand = null,
            HandJointSetEXT? handJointSet = null
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

            if (hand is not null)
            {
                Hand = hand.Value;
            }

            if (handJointSet is not null)
            {
                HandJointSet = handJointSet.Value;
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
        [NativeName("Type", "XrHandEXT")]
        [NativeName("Type.Name", "XrHandEXT")]
        [NativeName("Name", "hand")]
        public HandEXT Hand;
/// <summary></summary>
        [NativeName("Type", "XrHandJointSetEXT")]
        [NativeName("Type.Name", "XrHandJointSetEXT")]
        [NativeName("Name", "handJointSet")]
        public HandJointSetEXT HandJointSet;
        /// <summary>To be documented.</summary>
        public override string ToString()
        {
            return Handle.ToString();
        }

    }
}
