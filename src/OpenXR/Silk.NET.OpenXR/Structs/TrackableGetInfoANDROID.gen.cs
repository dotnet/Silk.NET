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
    [NativeName("Name", "XrTrackableGetInfoANDROID")]
    public unsafe partial struct TrackableGetInfoANDROID
    {
        public TrackableGetInfoANDROID
        (
            StructureType? type = StructureType.TypeTrackableGetInfoAndroid,
            void* next = null,
            ulong? trackable = null,
            Space? baseSpace = null,
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

            if (trackable is not null)
            {
                Trackable = trackable.Value;
            }

            if (baseSpace is not null)
            {
                BaseSpace = baseSpace.Value;
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
        [NativeName("Type", "XrTrackableANDROID")]
        [NativeName("Type.Name", "XrTrackableANDROID")]
        [NativeName("Name", "trackable")]
        public ulong Trackable;
/// <summary></summary>
        [NativeName("Type", "XrSpace")]
        [NativeName("Type.Name", "XrSpace")]
        [NativeName("Name", "baseSpace")]
        public Space BaseSpace;
/// <summary></summary>
        [NativeName("Type", "XrTime")]
        [NativeName("Type.Name", "XrTime")]
        [NativeName("Name", "time")]
        public long Time;
    }
}
