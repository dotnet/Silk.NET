// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[Transformed]
public enum ColorTableParameterPName : uint
{
    Scale = unchecked((uint)0x80D6),
    Bias = unchecked((uint)0x80D7),
    Format = unchecked((uint)0x80D8),
    Width = unchecked((uint)0x80D9),
    RedSize = unchecked((uint)0x80DA),
    GreenSize = unchecked((uint)0x80DB),
    BlueSize = unchecked((uint)0x80DC),
    AlphaSize = unchecked((uint)0x80DD),
    LuminanceSize = unchecked((uint)0x80DE),
    IntensitySize = unchecked((uint)0x80DF),
    ScaleSGI = unchecked((uint)0x80D6),
    BiasSGI = unchecked((uint)0x80D7),
    FormatSGI = unchecked((uint)0x80D8),
    WidthSGI = unchecked((uint)0x80D9),
    RedSizeSGI = unchecked((uint)0x80DA),
    GreenSizeSGI = unchecked((uint)0x80DB),
    BlueSizeSGI = unchecked((uint)0x80DC),
    AlphaSizeSGI = unchecked((uint)0x80DD),
    LuminanceSizeSGI = unchecked((uint)0x80DE),
    IntensitySizeSGI = unchecked((uint)0x80DF),
}
