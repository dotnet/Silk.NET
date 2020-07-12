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
    [NativeName("Name", "XrHandMeshUpdateInfoMSFT")]
    public unsafe partial struct HandMeshUpdateInfoMSFT
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
        [NativeName("Type", "XrTime")]
        [NativeName("Type.Name", "XrTime")]
        [NativeName("Name", "time")]
        public long Time;
/// <summary></summary>
        [NativeName("Type", "XrHandPoseTypeMSFT")]
        [NativeName("Type.Name", "XrHandPoseTypeMSFT")]
        [NativeName("Name", "handPoseType")]
        public HandPoseTypeMSFT HandPoseType;
    }
}
