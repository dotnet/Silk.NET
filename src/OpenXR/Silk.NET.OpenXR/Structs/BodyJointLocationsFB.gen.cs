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
    [NativeName("Name", "XrBodyJointLocationsFB")]
    public unsafe partial struct BodyJointLocationsFB
    {
        public BodyJointLocationsFB
        (
            StructureType? type = StructureType.TypeBodyJointLocationsFB,
            void* next = null,
            uint? isActive = null,
            float? confidence = null,
            uint? jointCount = null,
            BodyJointLocationFB* jointLocations = null,
            uint? skeletonChangedCount = null,
            long? time = null
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

            if (isActive is not null)
            {
                IsActive = isActive.Value;
            }

            if (confidence is not null)
            {
                Confidence = confidence.Value;
            }

            if (jointCount is not null)
            {
                JointCount = jointCount.Value;
            }

            if (jointLocations is not null)
            {
                JointLocations = jointLocations;
            }

            if (skeletonChangedCount is not null)
            {
                SkeletonChangedCount = skeletonChangedCount.Value;
            }

            if (time is not null)
            {
                Time = time.Value;
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
        [NativeName("Type", "XrBool32")]
        [NativeName("Type.Name", "XrBool32")]
        [NativeName("Name", "isActive")]
        public uint IsActive;
/// <summary></summary>
        [NativeName("Type", "float")]
        [NativeName("Type.Name", "float")]
        [NativeName("Name", "confidence")]
        public float Confidence;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "jointCount")]
        public uint JointCount;
/// <summary></summary>
        [NativeName("Type", "XrBodyJointLocationFB*")]
        [NativeName("Type.Name", "XrBodyJointLocationFB")]
        [NativeName("Name", "jointLocations")]
        public BodyJointLocationFB* JointLocations;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "skeletonChangedCount")]
        public uint SkeletonChangedCount;
/// <summary></summary>
        [NativeName("Type", "XrTime")]
        [NativeName("Type.Name", "XrTime")]
        [NativeName("Name", "time")]
        public long Time;
    }
}
