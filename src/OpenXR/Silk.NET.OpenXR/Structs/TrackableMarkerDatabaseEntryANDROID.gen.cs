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
    [NativeName("Name", "XrTrackableMarkerDatabaseEntryANDROID")]
    public unsafe partial struct TrackableMarkerDatabaseEntryANDROID
    {
        public TrackableMarkerDatabaseEntryANDROID
        (
            int? id = null,
            float? edgeSize = null
        ) : this()
        {
            if (id is not null)
            {
                Id = id.Value;
            }

            if (edgeSize is not null)
            {
                EdgeSize = edgeSize.Value;
            }
        }

/// <summary></summary>
        [NativeName("Type", "int32_t")]
        [NativeName("Type.Name", "int32_t")]
        [NativeName("Name", "id")]
        public int Id;
/// <summary></summary>
        [NativeName("Type", "float")]
        [NativeName("Type.Name", "float")]
        [NativeName("Name", "edgeSize")]
        public float EdgeSize;
    }
}
