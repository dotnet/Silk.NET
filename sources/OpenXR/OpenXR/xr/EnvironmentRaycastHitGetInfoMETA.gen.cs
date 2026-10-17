// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrEnvironmentRaycastHitGetInfoMETA")]
public unsafe partial struct EnvironmentRaycastHitGetInfoMETA
{
    [NativeName("type")]
    public StructureType Type = StructureType.EnvironmentRaycastHitGetInfoMETA;

    [NativeName("next")]
    public void* Next;

    [NativeName("baseSpace")]
    public SpaceHandle BaseSpace;

    [NativeName("time")]
    public long Time;

    [NativeName("origin")]
    public Vector3F Origin;

    [NativeName("direction")]
    public Vector3F Direction;

    [NativeName("filterCount")]
    public uint FilterCount;

    [NativeName("filters")]
    public EnvironmentRaycastFilterBaseHeaderMETA** Filters;

    public EnvironmentRaycastHitGetInfoMETA() { }
}
