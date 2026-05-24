// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NativeName("EvalTargetNV")]
public enum EvalTargetNV : uint
{
    [NativeName("GL_EVAL_2D_NV")]
    Eval2D = 34496,

    [NativeName("GL_EVAL_TRIANGULAR_2D_NV")]
    EvalTriangular2D = 34497,
}
