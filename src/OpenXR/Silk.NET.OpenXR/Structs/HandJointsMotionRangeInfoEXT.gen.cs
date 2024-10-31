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
    [NativeName("Name", "XrHandJointsMotionRangeInfoEXT")]
    public unsafe partial struct HandJointsMotionRangeInfoEXT
    {
        public HandJointsMotionRangeInfoEXT
        (
            StructureType? type = StructureType.TypeHandJointsMotionRangeInfoExt,
            void* next = null,
            HandJointsMotionRangeEXT? handJointsMotionRange = null
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

            if (handJointsMotionRange is not null)
            {
                HandJointsMotionRange = handJointsMotionRange.Value;
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
        [NativeName("Type", "XrHandJointsMotionRangeEXT")]
        [NativeName("Type.Name", "XrHandJointsMotionRangeEXT")]
        [NativeName("Name", "handJointsMotionRange")]
        public HandJointsMotionRangeEXT HandJointsMotionRange;
        /// <summary>To be documented.</summary>
        public override string ToString()
        {
            return Handle.ToString();
        }

    }
}
