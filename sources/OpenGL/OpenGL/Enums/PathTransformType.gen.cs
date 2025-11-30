// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NativeName("PathTransformType")]
[Transformed]
public enum PathTransformType : uint
{
    [NativeName("GL_NONE")]
    None = unchecked((uint)0),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_TRANSLATE_X_NV")]
    TranslateXnv = unchecked((uint)0x908E),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_TRANSLATE_Y_NV")]
    TranslateYnv = unchecked((uint)0x908F),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_TRANSLATE_2D_NV")]
    Translate2Dnv = unchecked((uint)0x9090),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_TRANSLATE_3D_NV")]
    Translate3Dnv = unchecked((uint)0x9091),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_AFFINE_2D_NV")]
    Affine2Dnv = unchecked((uint)0x9092),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_AFFINE_3D_NV")]
    Affine3Dnv = unchecked((uint)0x9094),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_TRANSPOSE_AFFINE_2D_NV")]
    TransposeAffine2Dnv = unchecked((uint)0x9096),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_TRANSPOSE_AFFINE_3D_NV")]
    TransposeAffine3Dnv = unchecked((uint)0x9098),
}
