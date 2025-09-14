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
    [NativeName("Name", "XrTrackableObjectANDROID")]
    public unsafe partial struct TrackableObjectANDROID
    {
        public TrackableObjectANDROID
        (
            StructureType? type = StructureType.TypeTrackableObjectAndroid,
            void* next = null,
            TrackingStateANDROID? trackingState = null,
            Posef? centerPose = null,
            Extent3DfEXT? extents = null,
            ObjectLabelANDROID? objectLabel = null,
            long? lastUpdatedTime = null
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

            if (objectLabel is not null)
            {
                ObjectLabel = objectLabel.Value;
            }

            if (lastUpdatedTime is not null)
            {
                LastUpdatedTime = lastUpdatedTime.Value;
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
        [NativeName("Type", "XrExtent3DfEXT")]
        [NativeName("Type.Name", "XrExtent3DfEXT")]
        [NativeName("Name", "extents")]
        public Extent3DfEXT Extents;
/// <summary></summary>
        [NativeName("Type", "XrObjectLabelANDROID")]
        [NativeName("Type.Name", "XrObjectLabelANDROID")]
        [NativeName("Name", "objectLabel")]
        public ObjectLabelANDROID ObjectLabel;
/// <summary></summary>
        [NativeName("Type", "XrTime")]
        [NativeName("Type.Name", "XrTime")]
        [NativeName("Name", "lastUpdatedTime")]
        public long LastUpdatedTime;
    }
}
