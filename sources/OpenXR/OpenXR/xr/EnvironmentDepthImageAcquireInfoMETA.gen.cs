// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrEnvironmentDepthImageAcquireInfoMETA")]
public unsafe partial struct EnvironmentDepthImageAcquireInfoMETA
{
    [NativeName("type")]
    public StructureType Type = StructureType.EnvironmentDepthImageAcquireInfoMETA;

    [NativeName("next")]
    public void* Next;

    [NativeName("space")]
    public SpaceHandle Space;

    [NativeName("displayTime")]
    public long DisplayTime;

    public EnvironmentDepthImageAcquireInfoMETA() { }
}
