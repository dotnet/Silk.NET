// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NativeName("ShadingRateQCOM")]
public enum ShadingRateQCOM : uint
{
    [NativeName("GL_SHADING_RATE_1X1_PIXELS_QCOM")]
    Rate1X1Pixels = unchecked((uint)0x96A6),

    [NativeName("GL_SHADING_RATE_1X2_PIXELS_QCOM")]
    Rate1X2Pixels = unchecked((uint)0x96A7),

    [NativeName("GL_SHADING_RATE_2X1_PIXELS_QCOM")]
    Rate2X1Pixels = unchecked((uint)0x96A8),

    [NativeName("GL_SHADING_RATE_2X2_PIXELS_QCOM")]
    Rate2X2Pixels = unchecked((uint)0x96A9),

    [NativeName("GL_SHADING_RATE_4X2_PIXELS_QCOM")]
    Rate4X2Pixels = unchecked((uint)0x96AC),

    [NativeName("GL_SHADING_RATE_4X4_PIXELS_QCOM")]
    Rate4X4Pixels = unchecked((uint)0x96AE),
}
