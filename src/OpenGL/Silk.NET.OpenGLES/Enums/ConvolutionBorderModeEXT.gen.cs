// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGLES
{
    [NativeName("Name", "ConvolutionBorderModeEXT")]
    public enum ConvolutionBorderModeEXT
    {
        [NativeName("Name", "GL_REDUCE")]
        Reduce = 0x8016,
        [NativeName("Name", "GL_REDUCE_EXT")]
        ReduceExt = 0x8016,
    }
}
