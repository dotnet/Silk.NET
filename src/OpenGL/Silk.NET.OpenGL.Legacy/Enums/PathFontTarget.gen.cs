// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy
{
    [NativeName("Name", "PathFontTarget")]
    public enum PathFontTarget : int
    {
        [NativeName("Name", "GL_STANDARD_FONT_NAME_NV")]
        StandardFontNameNV = 0x9072,
        [NativeName("Name", "GL_SYSTEM_FONT_NAME_NV")]
        SystemFontNameNV = 0x9073,
        [NativeName("Name", "GL_FILE_NAME_NV")]
        FileNameNV = 0x9074,
    }
}
