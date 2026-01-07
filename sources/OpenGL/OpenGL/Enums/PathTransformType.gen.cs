// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NativeName("PathTransformType")]
public enum PathTransformType : uint
{
    [NativeName("GL_NONE")]
    None = 0,

    [NativeName("GL_TRANSLATE_X_NV")]
    TranslateXNV = 37006,

    [NativeName("GL_TRANSLATE_Y_NV")]
    TranslateYNV = 37007,

    [NativeName("GL_TRANSLATE_2D_NV")]
    Translate2DNV = 37008,

    [NativeName("GL_TRANSLATE_3D_NV")]
    Translate3DNV = 37009,

    [NativeName("GL_AFFINE_2D_NV")]
    Affine2DNV = 37010,

    [NativeName("GL_AFFINE_3D_NV")]
    Affine3DNV = 37012,

    [NativeName("GL_TRANSPOSE_AFFINE_2D_NV")]
    TransposeAffine2DNV = 37014,

    [NativeName("GL_TRANSPOSE_AFFINE_3D_NV")]
    TransposeAffine3DNV = 37016,
}
