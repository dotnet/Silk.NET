// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NativeName("FeedbackType")]
public enum FeedbackType : uint
{
    [NativeName("GL_2D")]
    X2D = 1536,

    [NativeName("GL_3D")]
    X3D = 1537,

    [NativeName("GL_3D_COLOR")]
    X3DColor = 1538,

    [NativeName("GL_3D_COLOR_TEXTURE")]
    X3DColorTexture = 1539,

    [NativeName("GL_4D_COLOR_TEXTURE")]
    X4DColorTexture = 1540,
}
