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
    [NativeName("Name", "XrSystemMarkerTrackingPropertiesANDROID")]
    public unsafe partial struct SystemMarkerTrackingPropertiesANDROID
    {
        public SystemMarkerTrackingPropertiesANDROID
        (
            StructureType? type = StructureType.TypeSystemMarkerTrackingPropertiesAndroid,
            void* next = null,
            uint? supportsMarkerTracking = null,
            uint? supportsMarkerSizeEstimation = null,
            ushort? maxMarkerCount = null
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

            if (supportsMarkerTracking is not null)
            {
                SupportsMarkerTracking = supportsMarkerTracking.Value;
            }

            if (supportsMarkerSizeEstimation is not null)
            {
                SupportsMarkerSizeEstimation = supportsMarkerSizeEstimation.Value;
            }

            if (maxMarkerCount is not null)
            {
                MaxMarkerCount = maxMarkerCount.Value;
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
        [NativeName("Type", "XrBool32")]
        [NativeName("Type.Name", "XrBool32")]
        [NativeName("Name", "supportsMarkerTracking")]
        public uint SupportsMarkerTracking;
/// <summary></summary>
        [NativeName("Type", "XrBool32")]
        [NativeName("Type.Name", "XrBool32")]
        [NativeName("Name", "supportsMarkerSizeEstimation")]
        public uint SupportsMarkerSizeEstimation;
/// <summary></summary>
        [NativeName("Type", "uint16_t")]
        [NativeName("Type.Name", "uint16_t")]
        [NativeName("Name", "maxMarkerCount")]
        public ushort MaxMarkerCount;
    }
}
