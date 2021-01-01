// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGL
{
    [NativeName("Name", "ConvolutionTargetEXT")]
    public enum ConvolutionTargetEXT : int
    {
        [NativeName("Name", "GL_CONVOLUTION_1D")]
        Convolution1D = 0x8010,
        [NativeName("Name", "GL_CONVOLUTION_1D_EXT")]
        Convolution1DExt = 0x8010,
        [NativeName("Name", "GL_CONVOLUTION_2D")]
        Convolution2D = 0x8011,
        [NativeName("Name", "GL_CONVOLUTION_2D_EXT")]
        Convolution2DExt = 0x8011,
    }
}
