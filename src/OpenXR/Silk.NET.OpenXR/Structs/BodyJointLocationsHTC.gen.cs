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
    [NativeName("Name", "XrBodyJointLocationsHTC")]
    public unsafe partial struct BodyJointLocationsHTC
    {
        public BodyJointLocationsHTC
        (
            StructureType? type = StructureType.TypeBodyJointLocationsHtc,
            void* next = null,
            SpaceLocationFlags? combinedLocationFlags = null,
            BodyJointConfidenceHTC? confidenceLevel = null,
            uint? jointLocationCount = null,
            BodyJointLocationHTC* jointLocations = null,
            uint? skeletonGenerationId = null
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

            if (combinedLocationFlags is not null)
            {
                CombinedLocationFlags = combinedLocationFlags.Value;
            }

            if (confidenceLevel is not null)
            {
                ConfidenceLevel = confidenceLevel.Value;
            }

            if (jointLocationCount is not null)
            {
                JointLocationCount = jointLocationCount.Value;
            }

            if (jointLocations is not null)
            {
                JointLocations = jointLocations;
            }

            if (skeletonGenerationId is not null)
            {
                SkeletonGenerationId = skeletonGenerationId.Value;
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
        [NativeName("Type", "XrSpaceLocationFlags")]
        [NativeName("Type.Name", "XrSpaceLocationFlags")]
        [NativeName("Name", "combinedLocationFlags")]
        public SpaceLocationFlags CombinedLocationFlags;
/// <summary></summary>
        [NativeName("Type", "XrBodyJointConfidenceHTC")]
        [NativeName("Type.Name", "XrBodyJointConfidenceHTC")]
        [NativeName("Name", "confidenceLevel")]
        public BodyJointConfidenceHTC ConfidenceLevel;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "jointLocationCount")]
        public uint JointLocationCount;
/// <summary></summary>
        [NativeName("Type", "XrBodyJointLocationHTC*")]
        [NativeName("Type.Name", "XrBodyJointLocationHTC")]
        [NativeName("Name", "jointLocations")]
        public BodyJointLocationHTC* JointLocations;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "skeletonGenerationId")]
        public uint SkeletonGenerationId;
    }
}
