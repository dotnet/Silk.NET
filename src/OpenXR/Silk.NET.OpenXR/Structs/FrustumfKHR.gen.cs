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
    [NativeName("Name", "XrFrustumfKHR")]
    [NativeName("AliasOf", "XrFrustumf")]
    public unsafe partial struct FrustumfKHR
    {
        public FrustumfKHR
        (
            Posef? pose = null,
            Fovf? fov = null,
            float? nearZ = null,
            float? farZ = null
        ) : this()
        {
            if (pose is not null)
            {
                Pose = pose.Value;
            }

            if (fov is not null)
            {
                Fov = fov.Value;
            }

            if (nearZ is not null)
            {
                NearZ = nearZ.Value;
            }

            if (farZ is not null)
            {
                FarZ = farZ.Value;
            }
        }

/// <summary></summary>
        [NativeName("Type", "XrPosef")]
        [NativeName("Type.Name", "XrPosef")]
        [NativeName("Name", "pose")]
        public Posef Pose;
/// <summary></summary>
        [NativeName("Type", "XrFovf")]
        [NativeName("Type.Name", "XrFovf")]
        [NativeName("Name", "fov")]
        public Fovf Fov;
/// <summary></summary>
        [NativeName("Type", "float")]
        [NativeName("Type.Name", "float")]
        [NativeName("Name", "nearZ")]
        public float NearZ;
/// <summary></summary>
        [NativeName("Type", "float")]
        [NativeName("Type.Name", "float")]
        [NativeName("Name", "farZ")]
        public float FarZ;
    }
}
