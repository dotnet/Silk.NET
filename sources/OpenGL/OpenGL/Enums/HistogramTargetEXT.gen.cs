// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NameAffix("Suffix", "EXT", 0)]
[NativeName("HistogramTargetEXT")]
public enum HistogramTargetEXT : uint
{
    [NativeName("GL_HISTOGRAM")]
    Histogram = unchecked((uint)0x8024),

    [NativeName("GL_PROXY_HISTOGRAM")]
    ProxyHistogram = unchecked((uint)0x8025),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_HISTOGRAM_EXT")]
    HistogramEXT = unchecked((uint)0x8024),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_PROXY_HISTOGRAM_EXT")]
    ProxyHistogramEXT = unchecked((uint)0x8025),
}
