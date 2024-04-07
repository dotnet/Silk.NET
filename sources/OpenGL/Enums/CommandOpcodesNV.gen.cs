// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL Core Profile headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[Transformed]
public enum CommandOpcodesNV : uint
{
    TerminateSequenceCommand = 0x0000,
    NopCommand = 0x0001,
    DrawElementsCommand = 0x0002,
    DrawArraysCommand = 0x0003,
    DrawElementsStripCommand = 0x0004,
    DrawArraysStripCommand = 0x0005,
    DrawElementsInstancedCommand = 0x0006,
    DrawArraysInstancedCommand = 0x0007,
    ElementAddressCommand = 0x0008,
    AttributeAddressCommand = 0x0009,
    UniformAddressCommand = 0x000A,
    BlendColorCommand = 0x000B,
    StencilRefCommand = 0x000C,
    LineWidthCommand = 0x000D,
    PolygonOffsetCommand = 0x000E,
    AlphaRefCommand = 0x000F,
    ViewportCommand = 0x0010,
    ScissorCommand = 0x0011,
    FrontFaceCommand = 0x0012
}
