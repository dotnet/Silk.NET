// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NativeName("FeedBackToken")]
[Transformed]
public enum FeedBackToken : uint
{
    [NativeName("GL_PASS_THROUGH_TOKEN")]
    PassThroughToken = unchecked((uint)0x0700),

    [NativeName("GL_POINT_TOKEN")]
    PointToken = unchecked((uint)0x0701),

    [NativeName("GL_LINE_TOKEN")]
    LineToken = unchecked((uint)0x0702),

    [NativeName("GL_POLYGON_TOKEN")]
    PolygonToken = unchecked((uint)0x0703),

    [NativeName("GL_BITMAP_TOKEN")]
    BitmapToken = unchecked((uint)0x0704),

    [NativeName("GL_DRAW_PIXEL_TOKEN")]
    DrawPixelToken = unchecked((uint)0x0705),

    [NativeName("GL_COPY_PIXEL_TOKEN")]
    CopyPixelToken = unchecked((uint)0x0706),

    [NativeName("GL_LINE_RESET_TOKEN")]
    LineResetToken = unchecked((uint)0x0707),
}
