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
    [NativeName("Name", "XrSpatialMarkerDataEXT")]
    public unsafe partial struct SpatialMarkerDataEXT
    {
        public SpatialMarkerDataEXT
        (
            SpatialCapabilityEXT? capability = null,
            uint? markerId = null,
            SpatialBufferEXT? data = null
        ) : this()
        {
            if (capability is not null)
            {
                Capability = capability.Value;
            }

            if (markerId is not null)
            {
                MarkerId = markerId.Value;
            }

            if (data is not null)
            {
                Data = data.Value;
            }
        }

/// <summary></summary>
        [NativeName("Type", "XrSpatialCapabilityEXT")]
        [NativeName("Type.Name", "XrSpatialCapabilityEXT")]
        [NativeName("Name", "capability")]
        public SpatialCapabilityEXT Capability;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "markerId")]
        public uint MarkerId;
/// <summary></summary>
        [NativeName("Type", "XrSpatialBufferEXT")]
        [NativeName("Type.Name", "XrSpatialBufferEXT")]
        [NativeName("Name", "data")]
        public SpatialBufferEXT Data;
    }
}
