// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[Transformed]
public enum CommandOpcodesNV : uint
{
    TerminateSequenceCommand = unchecked((uint)0x0000),
    NopCommand = unchecked((uint)0x0001),
    DrawElementsCommand = unchecked((uint)0x0002),
    DrawArraysCommand = unchecked((uint)0x0003),
    DrawElementsStripCommand = unchecked((uint)0x0004),
    DrawArraysStripCommand = unchecked((uint)0x0005),
    DrawElementsInstancedCommand = unchecked((uint)0x0006),
    DrawArraysInstancedCommand = unchecked((uint)0x0007),
    ElementAddressCommand = unchecked((uint)0x0008),
    AttributeAddressCommand = unchecked((uint)0x0009),
    UniformAddressCommand = unchecked((uint)0x000A),
    BlendColorCommand = unchecked((uint)0x000B),
    StencilRefCommand = unchecked((uint)0x000C),
    LineWidthCommand = unchecked((uint)0x000D),
    PolygonOffsetCommand = unchecked((uint)0x000E),
    AlphaRefCommand = unchecked((uint)0x000F),
    ViewportCommand = unchecked((uint)0x0010),
    ScissorCommand = unchecked((uint)0x0011),
    FrontFaceCommand = unchecked((uint)0x0012),
}
