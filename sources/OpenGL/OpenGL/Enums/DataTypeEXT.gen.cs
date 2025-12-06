// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NativeName("DataTypeEXT")]
public enum DataTypeEXT : uint
{
    [NativeName("GL_SCALAR_EXT")]
    Scalar = 34750,

    [NativeName("GL_VECTOR_EXT")]
    Vector = 34751,

    [NativeName("GL_MATRIX_EXT")]
    Matrix = 34752,
}
