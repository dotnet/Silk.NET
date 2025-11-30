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
public enum OcclusionQueryEventMaskAmd : uint
{
    [NameAffix("Suffix", "AMD", 0)]
    [NativeName("GL_QUERY_DEPTH_PASS_EVENT_BIT_AMD")]
    DepthPassEventBitamd = unchecked((uint)0x00000001),

    [NameAffix("Suffix", "AMD", 0)]
    [NativeName("GL_QUERY_DEPTH_FAIL_EVENT_BIT_AMD")]
    DepthFailEventBitamd = unchecked((uint)0x00000002),

    [NameAffix("Suffix", "AMD", 0)]
    [NativeName("GL_QUERY_STENCIL_FAIL_EVENT_BIT_AMD")]
    StencilFailEventBitamd = unchecked((uint)0x00000004),

    [NameAffix("Suffix", "AMD", 0)]
    [NativeName("GL_QUERY_DEPTH_BOUNDS_FAIL_EVENT_BIT_AMD")]
    DepthBoundsFailEventBitamd = unchecked((uint)0x00000008),

    [NameAffix("Suffix", "AMD", 0)]
    [NativeName("GL_QUERY_ALL_EVENT_BITS_AMD")]
    AllEventBitsamd = unchecked((uint)0xFFFFFFFF),
}
