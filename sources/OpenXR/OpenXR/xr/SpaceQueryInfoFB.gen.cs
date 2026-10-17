// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrSpaceQueryInfoFB")]
public unsafe partial struct SpaceQueryInfoFB
{
    [NativeName("type")]
    public StructureType Type = StructureType.SpaceQueryInfoFB;

    [NativeName("next")]
    public void* Next;

    [NativeName("queryAction")]
    public SpaceQueryActionFB QueryAction;

    [NativeName("maxResultCount")]
    public uint MaxResultCount;

    [NativeName("timeout")]
    public long Timeout;

    [NativeName("filter")]
    public SpaceFilterInfoBaseHeaderFB* Filter;

    [NativeName("excludeFilter")]
    public SpaceFilterInfoBaseHeaderFB* ExcludeFilter;

    public SpaceQueryInfoFB() { }
}
