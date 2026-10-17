// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrFoveationEyeTrackedProfileCreateInfoMETA")]
public unsafe partial struct FoveationEyeTrackedProfileCreateInfoMETA
{
    [NativeName("type")]
    public StructureType Type = StructureType.FoveationEyeTrackedProfileCreateInfoMETA;

    [NativeName("next")]
    public void* Next;

    [NativeName("flags")]
    public FoveationEyeTrackedProfileCreateFlagsMETA Flags;

    public FoveationEyeTrackedProfileCreateInfoMETA() { }
}
