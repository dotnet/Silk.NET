// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy
{
    [NativeName("Name", "PathStringFormat")]
    public enum PathStringFormat : int
    {
        [Obsolete("Deprecated in favour of \"SvgNV\"")]
        [NativeName("Name", "GL_PATH_FORMAT_SVG_NV")]
        PathFormatSvgNV = 0x9070,
        [Obsolete("Deprecated in favour of \"PSNV\"")]
        [NativeName("Name", "GL_PATH_FORMAT_PS_NV")]
        PathFormatPSNV = 0x9071,
        [NativeName("Name", "GL_PATH_FORMAT_SVG_NV")]
        SvgNV = 0x9070,
        [NativeName("Name", "GL_PATH_FORMAT_PS_NV")]
        PSNV = 0x9071,
    }
}
