// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NativeName("OcclusionQueryEventMaskAMD")]
[Flags]
public enum OcclusionQueryEventMaskAMD : uint
{
    None = 0x0,

    [NativeName("GL_QUERY_DEPTH_PASS_EVENT_BIT_AMD")]
    DepthPassEventBit = 0x1,

    [NativeName("GL_QUERY_DEPTH_FAIL_EVENT_BIT_AMD")]
    DepthFailEventBit = 0x2,

    [NativeName("GL_QUERY_STENCIL_FAIL_EVENT_BIT_AMD")]
    StencilFailEventBit = 0x4,

    [NativeName("GL_QUERY_DEPTH_BOUNDS_FAIL_EVENT_BIT_AMD")]
    DepthBoundsFailEventBit = 0x8,

    [NativeName("GL_QUERY_ALL_EVENT_BITS_AMD")]
    AllEventBits = 0xFFFFFFFF,
}
