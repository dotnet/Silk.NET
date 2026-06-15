// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrBodyJointsLocateInfoHTC")]
[SupportedApiProfile("openxr")]
public unsafe partial struct BodyJointsLocateInfoHTC
{
    [NativeName("type")]
    [SupportedApiProfile("openxr", ["XR_HTC_body_tracking"])]
    public StructureType Type = StructureType.TypeBodyJointsLocateInfoHTC;

    [NativeName("next")]
    [SupportedApiProfile("openxr", ["XR_HTC_body_tracking"])]
    public void* Next;

    [NativeName("baseSpace")]
    [SupportedApiProfile("openxr", ["XR_HTC_body_tracking"])]
    public SpaceHandle BaseSpace;

    [NativeName("time")]
    [SupportedApiProfile("openxr", ["XR_HTC_body_tracking"])]
    public long Time;

    [SupportedApiProfile("openxr", ["XR_HTC_body_tracking"])]
    public BodyJointsLocateInfoHTC() { }
}
