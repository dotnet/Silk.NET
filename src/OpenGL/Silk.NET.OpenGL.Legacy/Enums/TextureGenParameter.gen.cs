// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy
{
    [NativeName("Name", "TextureGenParameter")]
    public enum TextureGenParameter : int
    {
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_TEXTURE_GEN_MODE")]
        TextureGenMode = 0x2500,
        [NativeName("Name", "GL_TEXTURE_GEN_MODE_OES")]
        TextureGenModeOes = 0x2500,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_OBJECT_PLANE")]
        ObjectPlane = 0x2501,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_EYE_PLANE")]
        EyePlane = 0x2502,
        [NativeName("Name", "GL_EYE_POINT_SGIS")]
        EyePointSgis = 0x81F4,
        [NativeName("Name", "GL_OBJECT_POINT_SGIS")]
        ObjectPointSgis = 0x81F5,
        [NativeName("Name", "GL_EYE_LINE_SGIS")]
        EyeLineSgis = 0x81F6,
        [NativeName("Name", "GL_OBJECT_LINE_SGIS")]
        ObjectLineSgis = 0x81F7,
    }
}
