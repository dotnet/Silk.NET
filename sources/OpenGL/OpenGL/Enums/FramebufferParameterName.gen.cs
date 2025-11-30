// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NativeName("FramebufferParameterName")]
[Transformed]
public enum FramebufferParameterName : uint
{
    [NativeName("GL_FRAMEBUFFER_DEFAULT_WIDTH")]
    Width = unchecked((uint)0x9310),

    [NativeName("GL_FRAMEBUFFER_DEFAULT_HEIGHT")]
    Height = unchecked((uint)0x9311),

    [NativeName("GL_FRAMEBUFFER_DEFAULT_LAYERS")]
    Layers = unchecked((uint)0x9312),

    [NativeName("GL_FRAMEBUFFER_DEFAULT_SAMPLES")]
    Samples = unchecked((uint)0x9313),

    [NativeName("GL_FRAMEBUFFER_DEFAULT_FIXED_SAMPLE_LOCATIONS")]
    FixedSampleLocations = unchecked((uint)0x9314),
}
