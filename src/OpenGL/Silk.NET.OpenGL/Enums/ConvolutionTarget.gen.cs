// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGL
{
    [NativeName("Name", "ConvolutionTarget")]
    public enum ConvolutionTarget
    {
        [NativeName("Name", "GL_CONVOLUTION_1D")]
        Convolution1D = 0x8010,
        [NativeName("Name", "GL_CONVOLUTION_2D")]
        Convolution2D = 0x8011,
    }
}
