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
    [NativeName("Name", "XrHandJointLocationEXT")]
    public unsafe partial struct HandJointLocationEXT
    {
        public HandJointLocationEXT
        (
            SpaceLocationFlags? locationFlags = null,
            Posef? pose = null,
            float? radius = null
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

            if (radius is not null)
            {
                Radius = radius.Value;
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
/// <summary></summary>
        [NativeName("Type", "float")]
        [NativeName("Type.Name", "float")]
        [NativeName("Name", "radius")]
        public float Radius;
    }
}
