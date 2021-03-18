// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGL
{
    [NativeName("Name", "ConvolutionTarget")]
    public enum ConvolutionTarget : int
    {
        [NativeName("Name", "GL_CONVOLUTION_1D")]
        Convolution1D = 0x8010,
        [NativeName("Name", "GL_CONVOLUTION_2D")]
        Convolution2D = 0x8011,
    }
}
