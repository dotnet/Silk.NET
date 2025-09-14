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
    [NativeName("Name", "XrRaycastHitResultANDROID")]
    public unsafe partial struct RaycastHitResultANDROID
    {
        public RaycastHitResultANDROID
        (
            TrackableTypeANDROID? type = null,
            ulong? trackable = null,
            Posef? pose = null
        ) : this()
        {
            if (type is not null)
            {
                Type = type.Value;
            }

            if (trackable is not null)
            {
                Trackable = trackable.Value;
            }

            if (pose is not null)
            {
                Pose = pose.Value;
            }
        }

/// <summary></summary>
        [NativeName("Type", "XrTrackableTypeANDROID")]
        [NativeName("Type.Name", "XrTrackableTypeANDROID")]
        [NativeName("Name", "type")]
        public TrackableTypeANDROID Type;
/// <summary></summary>
        [NativeName("Type", "XrTrackableANDROID")]
        [NativeName("Type.Name", "XrTrackableANDROID")]
        [NativeName("Name", "trackable")]
        public ulong Trackable;
/// <summary></summary>
        [NativeName("Type", "XrPosef")]
        [NativeName("Type.Name", "XrPosef")]
        [NativeName("Name", "pose")]
        public Posef Pose;
    }
}
