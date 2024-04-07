// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL Core Profile headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[Transformed]
public enum ColorTableParameterPName : uint
{
    Scale = 0x80D6,
    Bias = 0x80D7,
    Format = 0x80D8,
    Width = 0x80D9,
    RedSize = 0x80DA,
    GreenSize = 0x80DB,
    BlueSize = 0x80DC,
    AlphaSize = 0x80DD,
    LuminanceSize = 0x80DE,
    IntensitySize = 0x80DF,
    ScaleSGI = 0x80D6,
    BiasSGI = 0x80D7,
    FormatSGI = 0x80D8,
    WidthSGI = 0x80D9,
    RedSizeSGI = 0x80DA,
    GreenSizeSGI = 0x80DB,
    BlueSizeSGI = 0x80DC,
    AlphaSizeSGI = 0x80DD,
    LuminanceSizeSGI = 0x80DE,
    IntensitySizeSGI = 0x80DF
}
