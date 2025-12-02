// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NameAffix("Suffix", "NV", 0)]
[NativeName("EvalTargetNV")]
public enum EvalTargetNV : uint
{
    [NameAffix("Suffix", "NV", -1)]
    [NativeName("GL_EVAL_2D_NV")]
    Eval2D = unchecked((uint)0x86C0),

    [NameAffix("Suffix", "NV", -1)]
    [NativeName("GL_EVAL_TRIANGULAR_2D_NV")]
    EvalTriangular2D = unchecked((uint)0x86C1),
}
