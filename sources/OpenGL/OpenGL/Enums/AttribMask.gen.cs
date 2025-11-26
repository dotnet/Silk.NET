// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[Transformed]
[Flags]
public enum AttribMask : uint
{
    DepthBufferBit = unchecked((uint)0x00000100),
    StencilBufferBit = unchecked((uint)0x00000400),
    ColorBufferBit = unchecked((uint)0x00004000),
    CurrentBit = unchecked((uint)0x00000001),
    PointBit = unchecked((uint)0x00000002),
    LineBit = unchecked((uint)0x00000004),
    PolygonBit = unchecked((uint)0x00000008),
    PolygonStippleBit = unchecked((uint)0x00000010),
    PixelModeBit = unchecked((uint)0x00000020),
    LightingBit = unchecked((uint)0x00000040),
    FogBit = unchecked((uint)0x00000080),
    AccumBufferBit = unchecked((uint)0x00000200),
    ViewportBit = unchecked((uint)0x00000800),
    TransformBit = unchecked((uint)0x00001000),
    EnableBit = unchecked((uint)0x00002000),
    HintBit = unchecked((uint)0x00008000),
    EvalBit = unchecked((uint)0x00010000),
    ListBit = unchecked((uint)0x00020000),
    TextureBit = unchecked((uint)0x00040000),
    ScissorBit = unchecked((uint)0x00080000),
    AllAttribBits = unchecked((uint)0xFFFFFFFF),
    MultisampleBit = unchecked((uint)0x20000000),
    MultisampleBitARB = unchecked((uint)0x20000000),
    MultisampleBit3DFX = unchecked((uint)0x20000000),
    MultisampleBitEXT = unchecked((uint)0x20000000),
}
