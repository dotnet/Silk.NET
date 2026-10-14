// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NativeName("ConditionalRenderMode")]
public enum ConditionalRenderMode : uint
{
    [NativeName("GL_QUERY_WAIT")]
    Wait = 36371,

    [NativeName("GL_QUERY_NO_WAIT")]
    NoWait = 36372,

    [NativeName("GL_QUERY_BY_REGION_WAIT")]
    ByRegionWait = 36373,

    [NativeName("GL_QUERY_BY_REGION_NO_WAIT")]
    ByRegionNoWait = 36374,

    [NativeName("GL_QUERY_WAIT_INVERTED")]
    WaitInverted = 36375,

    [NativeName("GL_QUERY_NO_WAIT_INVERTED")]
    NoWaitInverted = 36376,

    [NativeName("GL_QUERY_BY_REGION_WAIT_INVERTED")]
    ByRegionWaitInverted = 36377,

    [NativeName("GL_QUERY_BY_REGION_NO_WAIT_INVERTED")]
    ByRegionNoWaitInverted = 36378,
}
