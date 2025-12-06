// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NativeName("CombinerMappingNV")]
public enum CombinerMappingNV : uint
{
    [NativeName("GL_UNSIGNED_IDENTITY_NV")]
    UnsignedIdentity = 34102,

    [NativeName("GL_UNSIGNED_INVERT_NV")]
    UnsignedInvert = 34103,

    [NativeName("GL_EXPAND_NORMAL_NV")]
    ExpandNormal = 34104,

    [NativeName("GL_EXPAND_NEGATE_NV")]
    ExpandNegate = 34105,

    [NativeName("GL_HALF_BIAS_NORMAL_NV")]
    HalfBiasNormal = 34106,

    [NativeName("GL_HALF_BIAS_NEGATE_NV")]
    HalfBiasNegate = 34107,

    [NativeName("GL_SIGNED_IDENTITY_NV")]
    SignedIdentity = 34108,

    [NativeName("GL_SIGNED_NEGATE_NV")]
    SignedNegate = 34109,
}
