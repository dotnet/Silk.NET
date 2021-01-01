// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy
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
