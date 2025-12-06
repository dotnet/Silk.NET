// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NativeName("FeedBackToken")]
public enum FeedBackToken : uint
{
    [NativeName("GL_PASS_THROUGH_TOKEN")]
    PassThroughToken = 1792,

    [NativeName("GL_POINT_TOKEN")]
    PointToken = 1793,

    [NativeName("GL_LINE_TOKEN")]
    LineToken = 1794,

    [NativeName("GL_POLYGON_TOKEN")]
    PolygonToken = 1795,

    [NativeName("GL_BITMAP_TOKEN")]
    BitmapToken = 1796,

    [NativeName("GL_DRAW_PIXEL_TOKEN")]
    DrawPixelToken = 1797,

    [NativeName("GL_COPY_PIXEL_TOKEN")]
    CopyPixelToken = 1798,

    [NativeName("GL_LINE_RESET_TOKEN")]
    LineResetToken = 1799,
}
