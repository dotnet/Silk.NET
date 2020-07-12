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
    public unsafe struct HandMeshSpaceCreateInfoMSFT
    {
        public HandMeshSpaceCreateInfoMSFT
        (
            StructureType type = StructureType.TypeHandMeshSpaceCreateInfoMsft,
            void* next = default,
            HandPoseTypeMSFT handPoseType = default,
            Posef poseInHandMeshSpace = default
        )
        {
           Type = type;
           Next = next;
           HandPoseType = handPoseType;
           PoseInHandMeshSpace = poseInHandMeshSpace;
        }

/// <summary></summary>
        public StructureType Type;
/// <summary></summary>
        public void* Next;
/// <summary></summary>
        public HandPoseTypeMSFT HandPoseType;
/// <summary></summary>
        public Posef PoseInHandMeshSpace;
    }
}
