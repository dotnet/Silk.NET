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
    [NativeName("Name", "XrSpatialComponentMarkerListEXT")]
    public unsafe partial struct SpatialComponentMarkerListEXT
    {
        public SpatialComponentMarkerListEXT
        (
            StructureType? type = StructureType.TypeSpatialComponentMarkerListExt,
            void* next = null,
            uint? markerCount = null,
            SpatialMarkerDataEXT* markers = null
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

            if (markerCount is not null)
            {
                MarkerCount = markerCount.Value;
            }

            if (markers is not null)
            {
                Markers = markers;
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
        [NativeName("Name", "markerCount")]
        public uint MarkerCount;
/// <summary></summary>
        [NativeName("Type", "XrSpatialMarkerDataEXT*")]
        [NativeName("Type.Name", "XrSpatialMarkerDataEXT")]
        [NativeName("Name", "markers")]
        public SpatialMarkerDataEXT* Markers;
    }
}
