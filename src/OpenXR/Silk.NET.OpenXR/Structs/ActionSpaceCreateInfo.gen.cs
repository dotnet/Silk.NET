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
    public unsafe struct ActionSpaceCreateInfo
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
        public StructureType Type;
/// <summary></summary>
        public void* Next;
/// <summary></summary>
        public Action Action;
/// <summary></summary>
        public ulong SubactionPath;
/// <summary></summary>
        public Posef PoseInActionSpace;
    }
}
