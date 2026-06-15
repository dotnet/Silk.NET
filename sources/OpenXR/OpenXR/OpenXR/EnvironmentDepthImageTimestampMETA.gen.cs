// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrEnvironmentDepthImageTimestampMETA")]
[SupportedApiProfile("openxr")]
public unsafe partial struct EnvironmentDepthImageTimestampMETA
{
    [NativeName("type")]
    [SupportedApiProfile("openxr", ["XR_META_environment_depth"])]
    public StructureType Type = StructureType.TypeEnvironmentDepthImageTimestampMETA;

    [NativeName("next")]
    [SupportedApiProfile("openxr", ["XR_META_environment_depth"])]
    public void* Next;

    [NativeName("captureTime")]
    [SupportedApiProfile("openxr", ["XR_META_environment_depth"])]
    public long CaptureTime;

    [SupportedApiProfile("openxr", ["XR_META_environment_depth"])]
    public EnvironmentDepthImageTimestampMETA() { }
}
