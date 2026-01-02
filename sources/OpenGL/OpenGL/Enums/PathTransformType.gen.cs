// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[Transformed]
public enum PathTransformType : uint
{
    None = unchecked((uint)0),
    TranslateXNV = unchecked((uint)0x908E),
    TranslateYNV = unchecked((uint)0x908F),
    Translate2DNV = unchecked((uint)0x9090),
    Translate3DNV = unchecked((uint)0x9091),
    Affine2DNV = unchecked((uint)0x9092),
    Affine3DNV = unchecked((uint)0x9094),
    TransposeAffine2DNV = unchecked((uint)0x9096),
    TransposeAffine3DNV = unchecked((uint)0x9098),
}
