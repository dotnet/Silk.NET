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
    [NativeName("Name", "XrSceneMarkerMSFT")]
    public unsafe partial struct SceneMarkerMSFT
    {
        public SceneMarkerMSFT
        (
            SceneMarkerTypeMSFT? markerType = null,
            long? lastSeenTime = null,
            Offset2Df? center = null,
            Extent2Df? size = null
        ) : this()
        {
            if (markerType is not null)
            {
                MarkerType = markerType.Value;
            }

            if (lastSeenTime is not null)
            {
                LastSeenTime = lastSeenTime.Value;
            }

            if (center is not null)
            {
                Center = center.Value;
            }

            if (size is not null)
            {
                Size = size.Value;
            }
        }

/// <summary></summary>
        [NativeName("Type", "XrSceneMarkerTypeMSFT")]
        [NativeName("Type.Name", "XrSceneMarkerTypeMSFT")]
        [NativeName("Name", "markerType")]
        public SceneMarkerTypeMSFT MarkerType;
/// <summary></summary>
        [NativeName("Type", "XrTime")]
        [NativeName("Type.Name", "XrTime")]
        [NativeName("Name", "lastSeenTime")]
        public long LastSeenTime;
/// <summary></summary>
        [NativeName("Type", "XrOffset2Df")]
        [NativeName("Type.Name", "XrOffset2Df")]
        [NativeName("Name", "center")]
        public Offset2Df Center;
/// <summary></summary>
        [NativeName("Type", "XrExtent2Df")]
        [NativeName("Type.Name", "XrExtent2Df")]
        [NativeName("Name", "size")]
        public Extent2Df Size;
    }
}
