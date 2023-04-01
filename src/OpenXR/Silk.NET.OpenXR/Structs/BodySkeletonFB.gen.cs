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
    [NativeName("Name", "XrBodySkeletonFB")]
    public unsafe partial struct BodySkeletonFB
    {
        public BodySkeletonFB
        (
            StructureType? type = StructureType.TypeBodySkeletonFB,
            void* next = null,
            uint? jointCount = null,
            BodySkeletonJointFB* joints = null
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

            if (jointCount is not null)
            {
                JointCount = jointCount.Value;
            }

            if (joints is not null)
            {
                Joints = joints;
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
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "jointCount")]
        public uint JointCount;
/// <summary></summary>
        [NativeName("Type", "XrBodySkeletonJointFB*")]
        [NativeName("Type.Name", "XrBodySkeletonJointFB")]
        [NativeName("Name", "joints")]
        public BodySkeletonJointFB* Joints;
    }
}
