// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL Core Profile headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[Transformed]
public enum RenderbufferParameterName : uint
{
    Samples = 0x8CAB,
    Width = 0x8D42,
    Height = 0x8D43,
    InternalFormat = 0x8D44,
    RedSize = 0x8D50,
    GreenSize = 0x8D51,
    BlueSize = 0x8D52,
    AlphaSize = 0x8D53,
    DepthSize = 0x8D54,
    StencilSize = 0x8D55,
    StorageSamplesAMD = 0x91B2,
    CoverageSamplesNV = 0x8CAB,
    ColorSamplesNV = 0x8E10,
    SamplesEXT = 0x8CAB,
    WidthEXT = 0x8D42,
    HeightEXT = 0x8D43,
    InternalFormatEXT = 0x8D44,
    RedSizeEXT = 0x8D50,
    GreenSizeEXT = 0x8D51,
    BlueSizeEXT = 0x8D52,
    AlphaSizeEXT = 0x8D53,
    DepthSizeEXT = 0x8D54,
    StencilSizeEXT = 0x8D55,
    WidthOES = 0x8D42,
    HeightOES = 0x8D43,
    InternalFormatOES = 0x8D44,
    RedSizeOES = 0x8D50,
    GreenSizeOES = 0x8D51,
    BlueSizeOES = 0x8D52,
    AlphaSizeOES = 0x8D53,
    DepthSizeOES = 0x8D54,
    StencilSizeOES = 0x8D55,
    SamplesApple = 0x8CAB,
    SamplesIMG = 0x9133,
    SamplesAngle = 0x8CAB,
    SamplesNV = 0x8CAB
}
