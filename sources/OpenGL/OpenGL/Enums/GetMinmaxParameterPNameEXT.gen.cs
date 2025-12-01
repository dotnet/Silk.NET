// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NativeName("GetMinmaxParameterPNameEXT")]
public enum GetMinmaxParameterPNameEXT : uint
{
    [NativeName("GL_MINMAX_FORMAT")]
    Format = unchecked((uint)0x802F),

    [NativeName("GL_MINMAX_SINK")]
    Sink = unchecked((uint)0x8030),

    [NativeName("GL_MINMAX_FORMAT_EXT")]
    FormatEXT = unchecked((uint)0x802F),

    [NativeName("GL_MINMAX_SINK_EXT")]
    SinkEXT = unchecked((uint)0x8030),
}
