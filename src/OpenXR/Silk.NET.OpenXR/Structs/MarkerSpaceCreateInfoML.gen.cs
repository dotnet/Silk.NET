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
    [NativeName("Name", "XrMarkerSpaceCreateInfoML")]
    public unsafe partial struct MarkerSpaceCreateInfoML
    {
        public MarkerSpaceCreateInfoML
        (
            StructureType? type = StructureType.TypeMarkerSpaceCreateInfoML,
            void* next = null,
            MarkerDetectorML? markerDetector = null,
            ulong? marker = null,
            Posef? poseInMarkerSpace = null
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

            if (markerDetector is not null)
            {
                MarkerDetector = markerDetector.Value;
            }

            if (marker is not null)
            {
                Marker = marker.Value;
            }

            if (poseInMarkerSpace is not null)
            {
                PoseInMarkerSpace = poseInMarkerSpace.Value;
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
        [NativeName("Type", "XrMarkerDetectorML")]
        [NativeName("Type.Name", "XrMarkerDetectorML")]
        [NativeName("Name", "markerDetector")]
        public MarkerDetectorML MarkerDetector;
/// <summary></summary>
        [NativeName("Type", "XrMarkerML")]
        [NativeName("Type.Name", "XrMarkerML")]
        [NativeName("Name", "marker")]
        public ulong Marker;
/// <summary></summary>
        [NativeName("Type", "XrPosef")]
        [NativeName("Type.Name", "XrPosef")]
        [NativeName("Name", "poseInMarkerSpace")]
        public Posef PoseInMarkerSpace;
    }
}
