// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NameAffix("Suffix", "SGIX", 0)]
[NativeName("FragmentLightModelParameterSGIX")]
[Transformed]
public enum FragmentLightModelParameterSgix : uint
{
    [NameAffix("Suffix", "SGIX", 0)]
    [NativeName("GL_FRAGMENT_LIGHT_MODEL_LOCAL_VIEWER_SGIX")]
    LocalViewersgix = unchecked((uint)0x8408),

    [NameAffix("Suffix", "SGIX", 0)]
    [NativeName("GL_FRAGMENT_LIGHT_MODEL_TWO_SIDE_SGIX")]
    TwoSidesgix = unchecked((uint)0x8409),

    [NameAffix("Suffix", "SGIX", 0)]
    [NativeName("GL_FRAGMENT_LIGHT_MODEL_AMBIENT_SGIX")]
    Ambientsgix = unchecked((uint)0x840A),

    [NameAffix("Suffix", "SGIX", 0)]
    [NativeName("GL_FRAGMENT_LIGHT_MODEL_NORMAL_INTERPOLATION_SGIX")]
    NormalInterpolationsgix = unchecked((uint)0x840B),
}
