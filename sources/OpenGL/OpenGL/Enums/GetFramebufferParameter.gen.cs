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
    SampleBuffers = unchecked((uint)0x80A8),

    [NativeName("GL_SAMPLES")]
    Samples = unchecked((uint)0x80A9),

    [NativeName("GL_DOUBLEBUFFER")]
    Doublebuffer = unchecked((uint)0x0C32),

    [NativeName("GL_STEREO")]
    Stereo = unchecked((uint)0x0C33),

    [NativeName("GL_IMPLEMENTATION_COLOR_READ_TYPE")]
    ImplementationColorReadType = unchecked((uint)0x8B9A),

    [NativeName("GL_IMPLEMENTATION_COLOR_READ_FORMAT")]
    ImplementationColorReadFormat = unchecked((uint)0x8B9B),

    [NativeName("GL_FRAMEBUFFER_DEFAULT_WIDTH")]
    FramebufferDefaultWidth = unchecked((uint)0x9310),

    [NativeName("GL_FRAMEBUFFER_DEFAULT_HEIGHT")]
    FramebufferDefaultHeight = unchecked((uint)0x9311),

    [NativeName("GL_FRAMEBUFFER_DEFAULT_LAYERS")]
    FramebufferDefaultLayers = unchecked((uint)0x9312),

    [NativeName("GL_FRAMEBUFFER_DEFAULT_SAMPLES")]
    FramebufferDefaultSamples = unchecked((uint)0x9313),

    [NativeName("GL_FRAMEBUFFER_DEFAULT_FIXED_SAMPLE_LOCATIONS")]
    FramebufferDefaultFixedSampleLocations = unchecked((uint)0x9314),
}
