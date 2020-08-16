// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.OpenXR
{
    [NativeName("Name", "XrSpatialAnchorSpaceCreateInfoMSFT")]
    public unsafe partial struct SpatialAnchorSpaceCreateInfoMSFT
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
        [NativeName("Type", "XrSpatialAnchorMSFT")]
        [NativeName("Type.Name", "XrSpatialAnchorMSFT")]
        [NativeName("Name", "anchor")]
        public SpatialAnchorMSFT Anchor;
/// <summary></summary>
        [NativeName("Type", "XrPosef")]
        [NativeName("Type.Name", "XrPosef")]
        [NativeName("Name", "poseInAnchorSpace")]
        public Posef PoseInAnchorSpace;
    }
}
