// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NativeName("GetFramebufferParameter")]
public enum GetFramebufferParameter : uint
{
    [NativeName("GL_SAMPLE_BUFFERS")]
    SampleBuffers = 32936,

    [NativeName("GL_SAMPLES")]
    Samples = 32937,

    [NativeName("GL_DOUBLEBUFFER")]
    Doublebuffer = 3122,

    [NativeName("GL_STEREO")]
    Stereo = 3123,

    [NativeName("GL_IMPLEMENTATION_COLOR_READ_TYPE")]
    ImplementationColorReadType = 35738,

    [NativeName("GL_IMPLEMENTATION_COLOR_READ_FORMAT")]
    ImplementationColorReadFormat = 35739,

    [NativeName("GL_FRAMEBUFFER_DEFAULT_WIDTH")]
    FramebufferDefaultWidth = 37648,

    [NativeName("GL_FRAMEBUFFER_DEFAULT_HEIGHT")]
    FramebufferDefaultHeight = 37649,

    [NativeName("GL_FRAMEBUFFER_DEFAULT_LAYERS")]
    FramebufferDefaultLayers = 37650,

    [NativeName("GL_FRAMEBUFFER_DEFAULT_SAMPLES")]
    FramebufferDefaultSamples = 37651,

    [NativeName("GL_FRAMEBUFFER_DEFAULT_FIXED_SAMPLE_LOCATIONS")]
    FramebufferDefaultFixedSampleLocations = 37652,
}
