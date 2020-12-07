// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGLES
{
    [NativeName("Name", "CombinerBiasNV")]
    public enum CombinerBiasNV
    {
        [NativeName("Name", "GL_NONE")]
        None = 0x0,
        [NativeName("Name", "GL_BIAS_BY_NEGATIVE_ONE_HALF_NV")]
        BiasByNegativeOneHalfNV = 0x8541,
    }
}
