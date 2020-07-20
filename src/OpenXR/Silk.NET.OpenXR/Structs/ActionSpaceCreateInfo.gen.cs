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
    [NativeName("Name", "XrActionSpaceCreateInfo")]
    public unsafe partial struct ActionSpaceCreateInfo
    {
        public ActionSpaceCreateInfo
        (
            StructureType type = StructureType.TypeActionSpaceCreateInfo,
            void* next = default,
            Action action = default,
            ulong subactionPath = default,
            Posef poseInActionSpace = default
        )
        {
            Type = type;
            Next = next;
            Action = action;
            SubactionPath = subactionPath;
            PoseInActionSpace = poseInActionSpace;
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
        [NativeName("Type", "XrAction")]
        [NativeName("Type.Name", "XrAction")]
        [NativeName("Name", "action")]
        public Action Action;
/// <summary></summary>
        [NativeName("Type", "XrPath")]
        [NativeName("Type.Name", "XrPath")]
        [NativeName("Name", "subactionPath")]
        public ulong SubactionPath;
/// <summary></summary>
        [NativeName("Type", "XrPosef")]
        [NativeName("Type.Name", "XrPosef")]
        [NativeName("Name", "poseInActionSpace")]
        public Posef PoseInActionSpace;
    }
}
