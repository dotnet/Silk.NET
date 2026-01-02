// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[Transformed]
public enum RenderbufferParameterName : uint
{
    Samples = unchecked((uint)0x8CAB),
    Width = unchecked((uint)0x8D42),
    Height = unchecked((uint)0x8D43),
    InternalFormat = unchecked((uint)0x8D44),
    RedSize = unchecked((uint)0x8D50),
    GreenSize = unchecked((uint)0x8D51),
    BlueSize = unchecked((uint)0x8D52),
    AlphaSize = unchecked((uint)0x8D53),
    DepthSize = unchecked((uint)0x8D54),
    StencilSize = unchecked((uint)0x8D55),
    StorageSamplesAMD = unchecked((uint)0x91B2),
    SamplesEXT = unchecked((uint)0x8CAB),
    WidthEXT = unchecked((uint)0x8D42),
    HeightEXT = unchecked((uint)0x8D43),
    InternalFormatEXT = unchecked((uint)0x8D44),
    RedSizeEXT = unchecked((uint)0x8D50),
    GreenSizeEXT = unchecked((uint)0x8D51),
    BlueSizeEXT = unchecked((uint)0x8D52),
    AlphaSizeEXT = unchecked((uint)0x8D53),
    DepthSizeEXT = unchecked((uint)0x8D54),
    StencilSizeEXT = unchecked((uint)0x8D55),
    CoverageSamplesNV = unchecked((uint)0x8CAB),
    ColorSamplesNV = unchecked((uint)0x8E10),
    SamplesAngle = unchecked((uint)0x8CAB),
    SamplesApple = unchecked((uint)0x8CAB),
    SamplesIMG = unchecked((uint)0x9133),
    SamplesNV = unchecked((uint)0x8CAB),
    WidthOES = unchecked((uint)0x8D42),
    HeightOES = unchecked((uint)0x8D43),
    InternalFormatOES = unchecked((uint)0x8D44),
    RedSizeOES = unchecked((uint)0x8D50),
    GreenSizeOES = unchecked((uint)0x8D51),
    BlueSizeOES = unchecked((uint)0x8D52),
    AlphaSizeOES = unchecked((uint)0x8D53),
    DepthSizeOES = unchecked((uint)0x8D54),
    StencilSizeOES = unchecked((uint)0x8D55),
}
