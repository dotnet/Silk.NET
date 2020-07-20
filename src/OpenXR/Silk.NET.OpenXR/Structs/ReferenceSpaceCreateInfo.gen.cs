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
    [NativeName("Name", "XrReferenceSpaceCreateInfo")]
    public unsafe partial struct ReferenceSpaceCreateInfo
    {
        public ReferenceSpaceCreateInfo
        (
            StructureType type = StructureType.TypeReferenceSpaceCreateInfo,
            void* next = default,
            ReferenceSpaceType referenceSpaceType = default,
            Posef poseInReferenceSpace = default
        )
        {
            Type = type;
            Next = next;
            ReferenceSpaceType = referenceSpaceType;
            PoseInReferenceSpace = poseInReferenceSpace;
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
        [NativeName("Type", "XrReferenceSpaceType")]
        [NativeName("Type.Name", "XrReferenceSpaceType")]
        [NativeName("Name", "referenceSpaceType")]
        public ReferenceSpaceType ReferenceSpaceType;
/// <summary></summary>
        [NativeName("Type", "XrPosef")]
        [NativeName("Type.Name", "XrPosef")]
        [NativeName("Name", "poseInReferenceSpace")]
        public Posef PoseInReferenceSpace;
    }
}
