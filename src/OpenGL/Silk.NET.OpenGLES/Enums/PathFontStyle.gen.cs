// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGLES
{
    [NativeName("Name", "PathFontStyle")]
    public enum PathFontStyle : int
    {
        [NativeName("Name", "GL_BOLD_BIT_NV")]
        BoldBitNV = 0x1,
        [NativeName("Name", "GL_ITALIC_BIT_NV")]
        ItalicBitNV = 0x2,
        [NativeName("Name", "GL_NONE")]
        None = 0x0,
    }
}
