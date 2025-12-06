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
    TextureGenModeOES = 9472,

    [NativeName("GL_TEXTURE_GEN_MODE")]
    TextureGenMode = 9472,

    [NativeName("GL_OBJECT_PLANE")]
    ObjectPlane = 9473,

    [NativeName("GL_EYE_PLANE")]
    EyePlane = 9474,

    [NativeName("GL_EYE_POINT_SGIS")]
    EyePointSGIS = 33268,

    [NativeName("GL_OBJECT_POINT_SGIS")]
    ObjectPointSGIS = 33269,

    [NativeName("GL_EYE_LINE_SGIS")]
    EyeLineSGIS = 33270,

    [NativeName("GL_OBJECT_LINE_SGIS")]
    ObjectLineSGIS = 33271,
}
