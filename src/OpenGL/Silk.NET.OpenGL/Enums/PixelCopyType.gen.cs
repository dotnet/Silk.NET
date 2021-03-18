// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGL
{
    [NativeName("Name", "PixelCopyType")]
    public enum PixelCopyType : int
    {
        [NativeName("Name", "GL_COLOR")]
        Color = 0x1800,
        [NativeName("Name", "GL_COLOR_EXT")]
        ColorExt = 0x1800,
        [NativeName("Name", "GL_DEPTH")]
        Depth = 0x1801,
        [NativeName("Name", "GL_DEPTH_EXT")]
        DepthExt = 0x1801,
        [NativeName("Name", "GL_STENCIL")]
        Stencil = 0x1802,
        [NativeName("Name", "GL_STENCIL_EXT")]
        StencilExt = 0x1802,
    }
}
