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
    [NativeName("Name", "XrSpaceLocationData")]
    [NativeName("Aliases", "XrSpaceLocationDataKHR")]
    public unsafe partial struct SpaceLocationData
    {
        public SpaceLocationData
        (
            SpaceLocationFlags? locationFlags = null,
            Posef? pose = null
        ) : this()
        {
            if (locationFlags is not null)
            {
                LocationFlags = locationFlags.Value;
            }

            if (pose is not null)
            {
                Pose = pose.Value;
            }
        }

/// <summary></summary>
        [NativeName("Type", "XrSpaceLocationFlags")]
        [NativeName("Type.Name", "XrSpaceLocationFlags")]
        [NativeName("Name", "locationFlags")]
        public SpaceLocationFlags LocationFlags;
/// <summary></summary>
        [NativeName("Type", "XrPosef")]
        [NativeName("Type.Name", "XrPosef")]
        [NativeName("Name", "pose")]
        public Posef Pose;
    }
}
