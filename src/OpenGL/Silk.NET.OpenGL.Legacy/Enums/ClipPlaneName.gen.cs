// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy
{
    [NativeName("Name", "ClipPlaneName")]
    public enum ClipPlaneName : int
    {
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_CLIP_PLANE0")]
        ClipPlane0 = 0x3000,
        [Obsolete("Deprecated in favour of \"Distance0\"")]
        [NativeName("Name", "GL_CLIP_DISTANCE0")]
        ClipDistance0 = 0x3000,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_CLIP_PLANE1")]
        ClipPlane1 = 0x3001,
        [Obsolete("Deprecated in favour of \"Distance1\"")]
        [NativeName("Name", "GL_CLIP_DISTANCE1")]
        ClipDistance1 = 0x3001,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_CLIP_PLANE2")]
        ClipPlane2 = 0x3002,
        [Obsolete("Deprecated in favour of \"Distance2\"")]
        [NativeName("Name", "GL_CLIP_DISTANCE2")]
        ClipDistance2 = 0x3002,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_CLIP_PLANE3")]
        ClipPlane3 = 0x3003,
        [Obsolete("Deprecated in favour of \"Distance3\"")]
        [NativeName("Name", "GL_CLIP_DISTANCE3")]
        ClipDistance3 = 0x3003,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_CLIP_PLANE4")]
        ClipPlane4 = 0x3004,
        [Obsolete("Deprecated in favour of \"Distance4\"")]
        [NativeName("Name", "GL_CLIP_DISTANCE4")]
        ClipDistance4 = 0x3004,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_CLIP_PLANE5")]
        ClipPlane5 = 0x3005,
        [Obsolete("Deprecated in favour of \"Distance5\"")]
        [NativeName("Name", "GL_CLIP_DISTANCE5")]
        ClipDistance5 = 0x3005,
        [Obsolete("Deprecated in favour of \"Distance6\"")]
        [NativeName("Name", "GL_CLIP_DISTANCE6")]
        ClipDistance6 = 0x3006,
        [Obsolete("Deprecated in favour of \"Distance7\"")]
        [NativeName("Name", "GL_CLIP_DISTANCE7")]
        ClipDistance7 = 0x3007,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_CLIP_PLANE0")]
        Plane0 = 0x3000,
        [NativeName("Name", "GL_CLIP_DISTANCE0")]
        Distance0 = 0x3000,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_CLIP_PLANE1")]
        Plane1 = 0x3001,
        [NativeName("Name", "GL_CLIP_DISTANCE1")]
        Distance1 = 0x3001,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_CLIP_PLANE2")]
        Plane2 = 0x3002,
        [NativeName("Name", "GL_CLIP_DISTANCE2")]
        Distance2 = 0x3002,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_CLIP_PLANE3")]
        Plane3 = 0x3003,
        [NativeName("Name", "GL_CLIP_DISTANCE3")]
        Distance3 = 0x3003,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_CLIP_PLANE4")]
        Plane4 = 0x3004,
        [NativeName("Name", "GL_CLIP_DISTANCE4")]
        Distance4 = 0x3004,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_CLIP_PLANE5")]
        Plane5 = 0x3005,
        [NativeName("Name", "GL_CLIP_DISTANCE5")]
        Distance5 = 0x3005,
        [NativeName("Name", "GL_CLIP_DISTANCE6")]
        Distance6 = 0x3006,
        [NativeName("Name", "GL_CLIP_DISTANCE7")]
        Distance7 = 0x3007,
    }
}
