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
    [NativeName("Name", "XrPlaneDetectorLocationEXT")]
    public unsafe partial struct PlaneDetectorLocationEXT
    {
        public PlaneDetectorLocationEXT
        (
            StructureType? type = StructureType.TypePlaneDetectorLocationExt,
            void* next = null,
            ulong? planeId = null,
            SpaceLocationFlags? locationFlags = null,
            Posef? pose = null,
            Extent2Df? extents = null,
            PlaneDetectorOrientationEXT? orientation = null,
            PlaneDetectorSemanticTypeEXT? semanticType = null,
            uint? polygonBufferCount = null
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

            if (planeId is not null)
            {
                PlaneId = planeId.Value;
            }

            if (locationFlags is not null)
            {
                LocationFlags = locationFlags.Value;
            }

            if (pose is not null)
            {
                Pose = pose.Value;
            }

            if (extents is not null)
            {
                Extents = extents.Value;
            }

            if (orientation is not null)
            {
                Orientation = orientation.Value;
            }

            if (semanticType is not null)
            {
                SemanticType = semanticType.Value;
            }

            if (polygonBufferCount is not null)
            {
                PolygonBufferCount = polygonBufferCount.Value;
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
        [NativeName("Type", "uint64_t")]
        [NativeName("Type.Name", "uint64_t")]
        [NativeName("Name", "planeId")]
        public ulong PlaneId;
/// <summary></summary>
        [NativeName("Type", "XrSpaceLocationFlags")]
        [NativeName("Type.Name", "XrSpaceLocationFlags")]
        [NativeName("Name", "locationFlags")]
        public SpaceLocationFlags LocationFlags;
/// <summary></summary>
        [NativeName("Type", "XrPosef")]
        [NativeName("Type.Name", "XrPosef")]
        [NativeName("Name", "pose")]
        public Posef Pose;
/// <summary></summary>
        [NativeName("Type", "XrExtent2Df")]
        [NativeName("Type.Name", "XrExtent2Df")]
        [NativeName("Name", "extents")]
        public Extent2Df Extents;
/// <summary></summary>
        [NativeName("Type", "XrPlaneDetectorOrientationEXT")]
        [NativeName("Type.Name", "XrPlaneDetectorOrientationEXT")]
        [NativeName("Name", "orientation")]
        public PlaneDetectorOrientationEXT Orientation;
/// <summary></summary>
        [NativeName("Type", "XrPlaneDetectorSemanticTypeEXT")]
        [NativeName("Type.Name", "XrPlaneDetectorSemanticTypeEXT")]
        [NativeName("Name", "semanticType")]
        public PlaneDetectorSemanticTypeEXT SemanticType;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "polygonBufferCount")]
        public uint PolygonBufferCount;
    }
}
