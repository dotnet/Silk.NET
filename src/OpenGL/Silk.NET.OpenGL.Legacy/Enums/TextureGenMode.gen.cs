// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy
{
    [NativeName("Name", "TextureGenMode")]
    public enum TextureGenMode : int
    {
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_EYE_LINEAR")]
        EyeLinear = 0x2400,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_OBJECT_LINEAR")]
        ObjectLinear = 0x2401,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_SPHERE_MAP")]
        SphereMap = 0x2402,
        [NativeName("Name", "GL_EYE_DISTANCE_TO_POINT_SGIS")]
        EyeDistanceToPointSgis = 0x81F0,
        [NativeName("Name", "GL_OBJECT_DISTANCE_TO_POINT_SGIS")]
        ObjectDistanceToPointSgis = 0x81F1,
        [NativeName("Name", "GL_EYE_DISTANCE_TO_LINE_SGIS")]
        EyeDistanceToLineSgis = 0x81F2,
        [NativeName("Name", "GL_OBJECT_DISTANCE_TO_LINE_SGIS")]
        ObjectDistanceToLineSgis = 0x81F3,
    }
}
