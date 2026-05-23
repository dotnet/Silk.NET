// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NativeName("FramebufferParameterName")]
public enum FramebufferParameterName : uint
{
    [NativeName("GL_FRAMEBUFFER_DEFAULT_WIDTH")]
    Width = 37648,

    [NativeName("GL_FRAMEBUFFER_DEFAULT_HEIGHT")]
    Height = 37649,

    [NativeName("GL_FRAMEBUFFER_DEFAULT_LAYERS")]
    Layers = 37650,

    [NativeName("GL_FRAMEBUFFER_DEFAULT_SAMPLES")]
    Samples = 37651,

    [NativeName("GL_FRAMEBUFFER_DEFAULT_FIXED_SAMPLE_LOCATIONS")]
    FixedSampleLocations = 37652,
}
