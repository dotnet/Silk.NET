// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[Transformed]
public enum BlendingFactor : uint
{
    Zero = unchecked((uint)0),
    One = unchecked((uint)1),
    SrcColor = unchecked((uint)0x0300),
    OneMinusSrcColor = unchecked((uint)0x0301),
    SrcAlpha = unchecked((uint)0x0302),
    OneMinusSrcAlpha = unchecked((uint)0x0303),
    DstAlpha = unchecked((uint)0x0304),
    OneMinusDstAlpha = unchecked((uint)0x0305),
    DstColor = unchecked((uint)0x0306),
    OneMinusDstColor = unchecked((uint)0x0307),
    SrcAlphaSaturate = unchecked((uint)0x0308),
    ConstantColor = unchecked((uint)0x8001),
    OneMinusConstantColor = unchecked((uint)0x8002),
    ConstantAlpha = unchecked((uint)0x8003),
    OneMinusConstantAlpha = unchecked((uint)0x8004),
    Src1Alpha = unchecked((uint)0x8589),
    Src1Color = unchecked((uint)0x88F9),
    OneMinusSrc1Color = unchecked((uint)0x88FA),
    OneMinusSrc1Alpha = unchecked((uint)0x88FB),
}
