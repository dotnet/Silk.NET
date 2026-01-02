// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[Transformed]
public enum VertexBufferObjectUsage : uint
{
    StreamDraw = unchecked((uint)0x88E0),
    StreamRead = unchecked((uint)0x88E1),
    StreamCopy = unchecked((uint)0x88E2),
    StaticDraw = unchecked((uint)0x88E4),
    StaticRead = unchecked((uint)0x88E5),
    StaticCopy = unchecked((uint)0x88E6),
    DynamicDraw = unchecked((uint)0x88E8),
    DynamicRead = unchecked((uint)0x88E9),
    DynamicCopy = unchecked((uint)0x88EA),
}
