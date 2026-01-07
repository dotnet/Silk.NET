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
    [NativeName("Name", "XrTrackableMarkerConfigurationANDROID")]
    public unsafe partial struct TrackableMarkerConfigurationANDROID
    {
        public TrackableMarkerConfigurationANDROID
        (
            StructureType? type = StructureType.TypeTrackableMarkerConfigurationAndroid,
            void* next = null,
            TrackableMarkerTrackingModeANDROID? trackingMode = null,
            uint? databaseCount = null,
            TrackableMarkerDatabaseANDROID* databases = null
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

            if (trackingMode is not null)
            {
                TrackingMode = trackingMode.Value;
            }

            if (databaseCount is not null)
            {
                DatabaseCount = databaseCount.Value;
            }

            if (databases is not null)
            {
                Databases = databases;
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
        [NativeName("Type", "XrTrackableMarkerTrackingModeANDROID")]
        [NativeName("Type.Name", "XrTrackableMarkerTrackingModeANDROID")]
        [NativeName("Name", "trackingMode")]
        public TrackableMarkerTrackingModeANDROID TrackingMode;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "databaseCount")]
        public uint DatabaseCount;
/// <summary></summary>
        [NativeName("Type", "XrTrackableMarkerDatabaseANDROID*")]
        [NativeName("Type.Name", "XrTrackableMarkerDatabaseANDROID")]
        [NativeName("Name", "databases")]
        public TrackableMarkerDatabaseANDROID* Databases;
    }
}
