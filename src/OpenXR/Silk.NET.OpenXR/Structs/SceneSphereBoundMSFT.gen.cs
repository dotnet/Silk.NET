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
    [NativeName("Name", "XrSceneSphereBoundMSFT")]
    public unsafe partial struct SceneSphereBoundMSFT
    {
        public SceneSphereBoundMSFT
        (
            Vector3f? center = null,
            float? radius = null
        ) : this()
        {
            if (center is not null)
            {
                Center = center.Value;
            }

            if (radius is not null)
            {
                Radius = radius.Value;
            }
        }

/// <summary></summary>
        [NativeName("Type", "XrVector3f")]
        [NativeName("Type.Name", "XrVector3f")]
        [NativeName("Name", "center")]
        public Vector3f Center;
/// <summary></summary>
        [NativeName("Type", "float")]
        [NativeName("Type.Name", "float")]
        [NativeName("Name", "radius")]
        public float Radius;
    }
}
