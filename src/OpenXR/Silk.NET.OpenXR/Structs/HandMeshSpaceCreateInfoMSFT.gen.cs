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
    [NativeName("Name", "XrHandMeshSpaceCreateInfoMSFT")]
    public unsafe partial struct HandMeshSpaceCreateInfoMSFT
    {
        public HandMeshSpaceCreateInfoMSFT
        (
            StructureType? type = StructureType.TypeHandMeshSpaceCreateInfoMsft,
            void* next = null,
            HandPoseTypeMSFT? handPoseType = null,
            Posef? poseInHandMeshSpace = null
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

            if (handPoseType is not null)
            {
                HandPoseType = handPoseType.Value;
            }

            if (poseInHandMeshSpace is not null)
            {
                PoseInHandMeshSpace = poseInHandMeshSpace.Value;
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
        [NativeName("Type", "XrHandPoseTypeMSFT")]
        [NativeName("Type.Name", "XrHandPoseTypeMSFT")]
        [NativeName("Name", "handPoseType")]
        public HandPoseTypeMSFT HandPoseType;
/// <summary></summary>
        [NativeName("Type", "XrPosef")]
        [NativeName("Type.Name", "XrPosef")]
        [NativeName("Name", "poseInHandMeshSpace")]
        public Posef PoseInHandMeshSpace;
    }
}
