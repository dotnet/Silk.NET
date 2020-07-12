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
    public unsafe struct SpatialAnchorSpaceCreateInfoMSFT
    {
        public SpatialAnchorSpaceCreateInfoMSFT
        (
            StructureType type = StructureType.TypeSpatialAnchorSpaceCreateInfoMsft,
            void* next = default,
            SpatialAnchorMSFT anchor = default,
            Posef poseInAnchorSpace = default
        )
        {
           Type = type;
           Next = next;
           Anchor = anchor;
           PoseInAnchorSpace = poseInAnchorSpace;
        }

/// <summary></summary>
        public StructureType Type;
/// <summary></summary>
        public void* Next;
/// <summary></summary>
        public SpatialAnchorMSFT Anchor;
/// <summary></summary>
        public Posef PoseInAnchorSpace;
    }
}
