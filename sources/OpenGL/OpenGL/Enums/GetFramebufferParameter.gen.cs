// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[Transformed]
public enum GetFramebufferParameter : uint
{
    Doublebuffer = unchecked((uint)0x0C32),
    Stereo = unchecked((uint)0x0C33),
    SampleBuffers = unchecked((uint)0x80A8),
    Samples = unchecked((uint)0x80A9),
    ImplementationColorReadType = unchecked((uint)0x8B9A),
    ImplementationColorReadFormat = unchecked((uint)0x8B9B),
    FramebufferDefaultWidth = unchecked((uint)0x9310),
    FramebufferDefaultHeight = unchecked((uint)0x9311),
    FramebufferDefaultLayers = unchecked((uint)0x9312),
    FramebufferDefaultSamples = unchecked((uint)0x9313),
    FramebufferDefaultFixedSampleLocations = unchecked((uint)0x9314),
}
