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
    [NativeName("Name", "XrTrackableMarkerDatabaseANDROID")]
    public unsafe partial struct TrackableMarkerDatabaseANDROID
    {
        public TrackableMarkerDatabaseANDROID
        (
            TrackableMarkerDictionaryANDROID? dictionary = null,
            uint? entryCount = null,
            TrackableMarkerDatabaseEntryANDROID* entries = null
        ) : this()
        {
            if (dictionary is not null)
            {
                Dictionary = dictionary.Value;
            }

            if (entryCount is not null)
            {
                EntryCount = entryCount.Value;
            }

            if (entries is not null)
            {
                Entries = entries;
            }
        }

/// <summary></summary>
        [NativeName("Type", "XrTrackableMarkerDictionaryANDROID")]
        [NativeName("Type.Name", "XrTrackableMarkerDictionaryANDROID")]
        [NativeName("Name", "dictionary")]
        public TrackableMarkerDictionaryANDROID Dictionary;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "entryCount")]
        public uint EntryCount;
/// <summary></summary>
        [NativeName("Type", "XrTrackableMarkerDatabaseEntryANDROID*")]
        [NativeName("Type.Name", "XrTrackableMarkerDatabaseEntryANDROID")]
        [NativeName("Name", "entries")]
        public TrackableMarkerDatabaseEntryANDROID* Entries;
    }
}
