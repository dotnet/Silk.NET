// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NativeName("ConditionalRenderMode")]
[Transformed]
public enum ConditionalRenderMode : uint
{
    [NativeName("GL_QUERY_WAIT")]
    Wait = unchecked((uint)0x8E13),

    [NativeName("GL_QUERY_NO_WAIT")]
    NoWait = unchecked((uint)0x8E14),

    [NativeName("GL_QUERY_BY_REGION_WAIT")]
    ByRegionWait = unchecked((uint)0x8E15),

    [NativeName("GL_QUERY_BY_REGION_NO_WAIT")]
    ByRegionNoWait = unchecked((uint)0x8E16),

    [NativeName("GL_QUERY_WAIT_INVERTED")]
    WaitInverted = unchecked((uint)0x8E17),

    [NativeName("GL_QUERY_NO_WAIT_INVERTED")]
    NoWaitInverted = unchecked((uint)0x8E18),

    [NativeName("GL_QUERY_BY_REGION_WAIT_INVERTED")]
    ByRegionWaitInverted = unchecked((uint)0x8E19),

    [NativeName("GL_QUERY_BY_REGION_NO_WAIT_INVERTED")]
    ByRegionNoWaitInverted = unchecked((uint)0x8E1A),
}
