// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL Core Profile headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

[Transformed]
public enum PathTransformType
{
    NONE = 0,
    TranslateXNV = 0x908E,
    TranslateYNV = 0x908F,
    Translate2DNV = 0x9090,
    Translate3DNV = 0x9091,
    Affine2DNV = 0x9092,
    Affine3DNV = 0x9094,
    TransposeAffine2DNV = 0x9096,
    TransposeAffine3DNV = 0x9098
}
