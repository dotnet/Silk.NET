// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NameAffix("Suffix", "AMD", 0)]
[NativeName("OcclusionQueryEventMaskAMD")]
[Transformed]
[Flags]
public enum OcclusionQueryEventMaskAMD : uint
{
    [NameAffix("Suffix", "AMD", 0)]
    [NativeName("GL_QUERY_DEPTH_PASS_EVENT_BIT_AMD")]
    DepthPassEventBitAMD = unchecked((uint)0x00000001),

    [NameAffix("Suffix", "AMD", 0)]
    [NativeName("GL_QUERY_DEPTH_FAIL_EVENT_BIT_AMD")]
    DepthFailEventBitAMD = unchecked((uint)0x00000002),

    [NameAffix("Suffix", "AMD", 0)]
    [NativeName("GL_QUERY_STENCIL_FAIL_EVENT_BIT_AMD")]
    StencilFailEventBitAMD = unchecked((uint)0x00000004),

    [NameAffix("Suffix", "AMD", 0)]
    [NativeName("GL_QUERY_DEPTH_BOUNDS_FAIL_EVENT_BIT_AMD")]
    DepthBoundsFailEventBitAMD = unchecked((uint)0x00000008),

    [NameAffix("Suffix", "AMD", 0)]
    [NativeName("GL_QUERY_ALL_EVENT_BITS_AMD")]
    AllEventBitsAMD = unchecked((uint)0xFFFFFFFF),
}
