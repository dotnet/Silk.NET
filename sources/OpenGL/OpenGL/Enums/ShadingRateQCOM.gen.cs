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
    Rate1X1Pixels = 38566,

    [NativeName("GL_SHADING_RATE_1X2_PIXELS_QCOM")]
    Rate1X2Pixels = 38567,

    [NativeName("GL_SHADING_RATE_2X1_PIXELS_QCOM")]
    Rate2X1Pixels = 38568,

    [NativeName("GL_SHADING_RATE_2X2_PIXELS_QCOM")]
    Rate2X2Pixels = 38569,

    [NativeName("GL_SHADING_RATE_4X2_PIXELS_QCOM")]
    Rate4X2Pixels = 38572,

    [NativeName("GL_SHADING_RATE_4X4_PIXELS_QCOM")]
    Rate4X4Pixels = 38574,
}
