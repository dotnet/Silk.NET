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
    [NativeName("Name", "XrTrackableMarkerANDROID")]
    public unsafe partial struct TrackableMarkerANDROID
    {
        public TrackableMarkerANDROID
        (
            StructureType? type = StructureType.TypeTrackableMarkerAndroid,
            void* next = null,
            TrackingStateANDROID? trackingState = null,
            long? lastUpdatedTime = null,
            TrackableMarkerDictionaryANDROID? dictionary = null,
            int? markerId = null,
            Posef? centerPose = null,
            Extent2Df? extents = null
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

            if (lastUpdatedTime is not null)
            {
                LastUpdatedTime = lastUpdatedTime.Value;
            }

            if (dictionary is not null)
            {
                Dictionary = dictionary.Value;
            }

            if (markerId is not null)
            {
                MarkerId = markerId.Value;
            }

            if (centerPose is not null)
            {
                CenterPose = centerPose.Value;
            }

            if (extents is not null)
            {
                Extents = extents.Value;
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
        [NativeName("Type", "XrTime")]
        [NativeName("Type.Name", "XrTime")]
        [NativeName("Name", "lastUpdatedTime")]
        public long LastUpdatedTime;
/// <summary></summary>
        [NativeName("Type", "XrTrackableMarkerDictionaryANDROID")]
        [NativeName("Type.Name", "XrTrackableMarkerDictionaryANDROID")]
        [NativeName("Name", "dictionary")]
        public TrackableMarkerDictionaryANDROID Dictionary;
/// <summary></summary>
        [NativeName("Type", "int32_t")]
        [NativeName("Type.Name", "int32_t")]
        [NativeName("Name", "markerId")]
        public int MarkerId;
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
    }
}
