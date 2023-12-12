// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy
{
    [NativeName("Name", "TextureWrapMode")]
    public enum TextureWrapMode : int
    {
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_CLAMP")]
        Clamp = 0x2900,
        [NativeName("Name", "GL_REPEAT")]
        Repeat = 0x2901,
        [NativeName("Name", "GL_CLAMP_TO_BORDER")]
        ClampToBorder = 0x812D,
        [NativeName("Name", "GL_CLAMP_TO_BORDER_ARB")]
        ClampToBorderArb = 0x812D,
        [NativeName("Name", "GL_CLAMP_TO_BORDER_EXT")]
        ClampToBorderExt = 0x812D,
        [NativeName("Name", "GL_CLAMP_TO_BORDER_NV")]
        ClampToBorderNV = 0x812D,
        [NativeName("Name", "GL_CLAMP_TO_BORDER_SGIS")]
        ClampToBorderSgis = 0x812D,
        [NativeName("Name", "GL_CLAMP_TO_BORDER_OES")]
        ClampToBorderOes = 0x812D,
        [NativeName("Name", "GL_CLAMP_TO_EDGE")]
        ClampToEdge = 0x812F,
        [NativeName("Name", "GL_CLAMP_TO_EDGE_SGIS")]
        ClampToEdgeSgis = 0x812F,
        [NativeName("Name", "GL_MIRRORED_REPEAT")]
        MirroredRepeat = 0x8370,
        [NativeName("Name", "GL_MIRRORED_REPEAT_ARB")]
        MirroredRepeatArb = 0x8370,
        [NativeName("Name", "GL_MIRRORED_REPEAT_IBM")]
        MirroredRepeatIbm = 0x8370,
        [NativeName("Name", "GL_MIRRORED_REPEAT_OES")]
        MirroredRepeatOes = 0x8370,
    }
}
