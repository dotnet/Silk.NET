// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL Core Profile headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

[Transformed]
public enum FeedBackToken
{
    PassThroughToken = 0x0700,
    PointToken = 0x0701,
    LineToken = 0x0702,
    PolygonToken = 0x0703,
    BitmapToken = 0x0704,
    DrawPixelToken = 0x0705,
    CopyPixelToken = 0x0706,
    LineResetToken = 0x0707
}
