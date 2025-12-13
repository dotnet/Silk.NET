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
    [NativeName("Name", "XrTrackablePlaneANDROID")]
    public unsafe partial struct TrackablePlaneANDROID
    {
        public TrackablePlaneANDROID
        (
            StructureType? type = StructureType.TypeTrackablePlaneAndroid,
            void* next = null,
            TrackingStateANDROID? trackingState = null,
            Posef? centerPose = null,
            Extent2Df? extents = null,
            PlaneTypeANDROID? planeType = null,
            PlaneLabelANDROID? planeLabel = null,
            ulong? subsumedByPlane = null,
            long? lastUpdatedTime = null,
            uint? vertexCapacityInput = null,
            uint* vertexCountOutput = null,
            Vector2f* vertices = null
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

            if (trackingState is not null)
            {
                TrackingState = trackingState.Value;
            }

            if (centerPose is not null)
            {
                CenterPose = centerPose.Value;
            }

            if (extents is not null)
            {
                Extents = extents.Value;
            }

            if (planeType is not null)
            {
                PlaneType = planeType.Value;
            }

            if (planeLabel is not null)
            {
                PlaneLabel = planeLabel.Value;
            }

            if (subsumedByPlane is not null)
            {
                SubsumedByPlane = subsumedByPlane.Value;
            }

            if (lastUpdatedTime is not null)
            {
                LastUpdatedTime = lastUpdatedTime.Value;
            }

            if (vertexCapacityInput is not null)
            {
                VertexCapacityInput = vertexCapacityInput.Value;
            }

            if (vertexCountOutput is not null)
            {
                VertexCountOutput = vertexCountOutput;
            }

            if (vertices is not null)
            {
                Vertices = vertices;
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
        [NativeName("Type", "XrTrackingStateANDROID")]
        [NativeName("Type.Name", "XrTrackingStateANDROID")]
        [NativeName("Name", "trackingState")]
        public TrackingStateANDROID TrackingState;
/// <summary></summary>
        [NativeName("Type", "XrPosef")]
        [NativeName("Type.Name", "XrPosef")]
        [NativeName("Name", "centerPose")]
        public Posef CenterPose;
/// <summary></summary>
        [NativeName("Type", "XrExtent2Df")]
        [NativeName("Type.Name", "XrExtent2Df")]
        [NativeName("Name", "extents")]
        public Extent2Df Extents;
/// <summary></summary>
        [NativeName("Type", "XrPlaneTypeANDROID")]
        [NativeName("Type.Name", "XrPlaneTypeANDROID")]
        [NativeName("Name", "planeType")]
        public PlaneTypeANDROID PlaneType;
/// <summary></summary>
        [NativeName("Type", "XrPlaneLabelANDROID")]
        [NativeName("Type.Name", "XrPlaneLabelANDROID")]
        [NativeName("Name", "planeLabel")]
        public PlaneLabelANDROID PlaneLabel;
/// <summary></summary>
        [NativeName("Type", "XrTrackableANDROID")]
        [NativeName("Type.Name", "XrTrackableANDROID")]
        [NativeName("Name", "subsumedByPlane")]
        public ulong SubsumedByPlane;
/// <summary></summary>
        [NativeName("Type", "XrTime")]
        [NativeName("Type.Name", "XrTime")]
        [NativeName("Name", "lastUpdatedTime")]
        public long LastUpdatedTime;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "vertexCapacityInput")]
        public uint VertexCapacityInput;
/// <summary></summary>
        [NativeName("Type", "uint32_t*")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "vertexCountOutput")]
        public uint* VertexCountOutput;
/// <summary></summary>
        [NativeName("Type", "XrVector2f*")]
        [NativeName("Type.Name", "XrVector2f")]
        [NativeName("Name", "vertices")]
        public Vector2f* Vertices;
    }
}
