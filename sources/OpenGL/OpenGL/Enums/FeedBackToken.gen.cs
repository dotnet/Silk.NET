// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[Transformed]
public enum FeedBackToken : uint
{
    PassThroughToken = unchecked((uint)0x0700),
    PointToken = unchecked((uint)0x0701),
    LineToken = unchecked((uint)0x0702),
    PolygonToken = unchecked((uint)0x0703),
    BitmapToken = unchecked((uint)0x0704),
    DrawPixelToken = unchecked((uint)0x0705),
    CopyPixelToken = unchecked((uint)0x0706),
    LineResetToken = unchecked((uint)0x0707),
}
