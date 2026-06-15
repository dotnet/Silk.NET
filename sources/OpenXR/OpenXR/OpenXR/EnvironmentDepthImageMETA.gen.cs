// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrEnvironmentDepthImageMETA")]
[SupportedApiProfile("openxr")]
public unsafe partial struct EnvironmentDepthImageMETA
{
    [NativeName("type")]
    [SupportedApiProfile("openxr", ["XR_META_environment_depth"])]
    public StructureType Type = StructureType.TypeEnvironmentDepthImageMETA;

    [NativeName("next")]
    [SupportedApiProfile("openxr", ["XR_META_environment_depth"])]
    public void* Next;

    [NativeName("swapchainIndex")]
    [SupportedApiProfile("openxr", ["XR_META_environment_depth"])]
    public uint SwapchainIndex;

    [NativeName("nearZ")]
    [SupportedApiProfile("openxr", ["XR_META_environment_depth"])]
    public float NearZ;

    [NativeName("farZ")]
    [SupportedApiProfile("openxr", ["XR_META_environment_depth"])]
    public float FarZ;

    [NativeName("views")]
    [SupportedApiProfile("openxr", ["XR_META_environment_depth"])]
    public EnvironmentDepthImageMETAViews Views;

    [SupportedApiProfile("openxr", ["XR_META_environment_depth"])]
    public EnvironmentDepthImageMETA() { }
}
