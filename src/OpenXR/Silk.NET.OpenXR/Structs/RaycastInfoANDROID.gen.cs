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
    [NativeName("Name", "XrRaycastInfoANDROID")]
    public unsafe partial struct RaycastInfoANDROID
    {
        public RaycastInfoANDROID
        (
            StructureType? type = StructureType.TypeRaycastInfoAndroid,
            void* next = null,
            uint? maxResults = null,
            uint? trackerCount = null,
            TrackableTrackerANDROID* trackers = null,
            Vector3f? origin = null,
            Vector3f? trajectory = null,
            Space? space = null,
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

            if (maxResults is not null)
            {
                MaxResults = maxResults.Value;
            }

            if (trackerCount is not null)
            {
                TrackerCount = trackerCount.Value;
            }

            if (trackers is not null)
            {
                Trackers = trackers;
            }

            if (origin is not null)
            {
                Origin = origin.Value;
            }

            if (trajectory is not null)
            {
                Trajectory = trajectory.Value;
            }

            if (space is not null)
            {
                Space = space.Value;
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
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxResults")]
        public uint MaxResults;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "trackerCount")]
        public uint TrackerCount;
/// <summary></summary>
        [NativeName("Type", "XrTrackableTrackerANDROID*")]
        [NativeName("Type.Name", "XrTrackableTrackerANDROID")]
        [NativeName("Name", "trackers")]
        public TrackableTrackerANDROID* Trackers;
/// <summary></summary>
        [NativeName("Type", "XrVector3f")]
        [NativeName("Type.Name", "XrVector3f")]
        [NativeName("Name", "origin")]
        public Vector3f Origin;
/// <summary></summary>
        [NativeName("Type", "XrVector3f")]
        [NativeName("Type.Name", "XrVector3f")]
        [NativeName("Name", "trajectory")]
        public Vector3f Trajectory;
/// <summary></summary>
        [NativeName("Type", "XrSpace")]
        [NativeName("Type.Name", "XrSpace")]
        [NativeName("Name", "space")]
        public Space Space;
/// <summary></summary>
        [NativeName("Type", "XrTime")]
        [NativeName("Type.Name", "XrTime")]
        [NativeName("Name", "time")]
        public long Time;
    }
}
