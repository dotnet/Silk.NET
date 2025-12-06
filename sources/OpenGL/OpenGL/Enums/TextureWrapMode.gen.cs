// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NativeName("TextureWrapMode")]
public enum TextureWrapMode : uint
{
    [NativeName("GL_LINEAR_MIPMAP_LINEAR")]
    LinearMipmapLinear = 9987,

    [NativeName("GL_REPEAT")]
    Repeat = 10497,

    [NativeName("GL_CLAMP")]
    Clamp = 10496,

    [NativeName("GL_CLAMP_TO_EDGE")]
    ClampToEdge = 33071,

    [NativeName("GL_CLAMP_TO_BORDER")]
    ClampToBorder = 33069,

    [NativeName("GL_MIRRORED_REPEAT")]
    MirroredRepeat = 33648,

    [NativeName("GL_CLAMP_TO_BORDER_ARB")]
    ClampToBorderARB = 33069,

    [NativeName("GL_CLAMP_TO_BORDER_SGIS")]
    ClampToBorderSGIS = 33069,

    [NativeName("GL_CLAMP_TO_EDGE_SGIS")]
    ClampToEdgeSGIS = 33071,

    [NativeName("GL_CLAMP_TO_BORDER_NV")]
    ClampToBorderNV = 33069,
}
