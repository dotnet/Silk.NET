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
    public unsafe struct HandMeshUpdateInfoMSFT
    {
        public HandMeshUpdateInfoMSFT
        (
            StructureType type = StructureType.TypeHandMeshUpdateInfoMsft,
            void* next = default,
            long time = default,
            HandPoseTypeMSFT handPoseType = default
        )
        {
           Type = type;
           Next = next;
           Time = time;
           HandPoseType = handPoseType;
        }

/// <summary></summary>
        public StructureType Type;
/// <summary></summary>
        public void* Next;
/// <summary></summary>
        public long Time;
/// <summary></summary>
        public HandPoseTypeMSFT HandPoseType;
    }
}
