// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NativeName("TextureGenParameter")]
public enum TextureGenParameter : uint
{
    [NativeName("GL_TEXTURE_GEN_MODE_OES")]
    TextureGenModeOES = unchecked((uint)0x2500),

    [NativeName("GL_TEXTURE_GEN_MODE")]
    TextureGenMode = unchecked((uint)0x2500),

    [NativeName("GL_OBJECT_PLANE")]
    ObjectPlane = unchecked((uint)0x2501),

    [NativeName("GL_EYE_PLANE")]
    EyePlane = unchecked((uint)0x2502),

    [NativeName("GL_EYE_POINT_SGIS")]
    EyePointSGIS = unchecked((uint)0x81F4),

    [NativeName("GL_OBJECT_POINT_SGIS")]
    ObjectPointSGIS = unchecked((uint)0x81F5),

    [NativeName("GL_EYE_LINE_SGIS")]
    EyeLineSGIS = unchecked((uint)0x81F6),

    [NativeName("GL_OBJECT_LINE_SGIS")]
    ObjectLineSGIS = unchecked((uint)0x81F7),
}
