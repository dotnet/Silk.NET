// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGLES
{
    [NativeName("Name", "PathTransformType")]
    public enum PathTransformType : int
    {
        [NativeName("Name", "GL_NONE")]
        None = 0x0,
        [NativeName("Name", "GL_TRANSLATE_X_NV")]
        TranslateXNV = 0x908E,
        [NativeName("Name", "GL_TRANSLATE_Y_NV")]
        TranslateYNV = 0x908F,
        [NativeName("Name", "GL_TRANSLATE_2D_NV")]
        Translate2DNV = 0x9090,
        [NativeName("Name", "GL_TRANSLATE_3D_NV")]
        Translate3DNV = 0x9091,
        [NativeName("Name", "GL_AFFINE_2D_NV")]
        Affine2DNV = 0x9092,
        [NativeName("Name", "GL_AFFINE_3D_NV")]
        Affine3DNV = 0x9094,
        [NativeName("Name", "GL_TRANSPOSE_AFFINE_2D_NV")]
        TransposeAffine2DNV = 0x9096,
        [NativeName("Name", "GL_TRANSPOSE_AFFINE_3D_NV")]
        TransposeAffine3DNV = 0x9098,
    }
}
