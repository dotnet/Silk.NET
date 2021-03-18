// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGLES
{
    [NativeName("Name", "EvalTargetNV")]
    public enum EvalTargetNV : int
    {
        [NativeName("Name", "GL_EVAL_2D_NV")]
        Eval2DNV = 0x86C0,
        [NativeName("Name", "GL_EVAL_TRIANGULAR_2D_NV")]
        EvalTriangular2DNV = 0x86C1,
    }
}
