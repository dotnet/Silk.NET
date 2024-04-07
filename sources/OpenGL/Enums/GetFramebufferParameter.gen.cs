// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL Core Profile headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[Transformed]
public enum GetFramebufferParameter : uint
{
    Doublebuffer = 0x0C32,
    Stereo = 0x0C33,
    SampleBuffers = 0x80A8,
    Samples = 0x80A9,
    ImplementationColorReadType = 0x8B9A,
    ImplementationColorReadFormat = 0x8B9B,
    FramebufferDefaultWidth = 0x9310,
    FramebufferDefaultHeight = 0x9311,
    FramebufferDefaultLayers = 0x9312,
    FramebufferDefaultSamples = 0x9313,
    FramebufferDefaultFixedSampleLocations = 0x9314
}
