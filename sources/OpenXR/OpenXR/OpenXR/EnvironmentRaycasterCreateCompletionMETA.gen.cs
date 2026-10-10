// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrEnvironmentRaycasterCreateCompletionMETA")]
[SupportedApiProfile("openxr")]
public unsafe partial struct EnvironmentRaycasterCreateCompletionMETA
{
    [NativeName("type")]
    [SupportedApiProfile(
        "openxr",
        ["XR_META_environment_raycast"],
        ImpliesSets = ["XR_EXT_future"]
    )]
    public StructureType Type = StructureType.EnvironmentRaycasterCreateCompletionMETA;

    [NativeName("next")]
    [SupportedApiProfile(
        "openxr",
        ["XR_META_environment_raycast"],
        ImpliesSets = ["XR_EXT_future"]
    )]
    public void* Next;

    [NativeName("futureResult")]
    [SupportedApiProfile(
        "openxr",
        ["XR_META_environment_raycast"],
        ImpliesSets = ["XR_EXT_future"]
    )]
    public Result FutureResult;

    [NativeName("environmentRaycaster")]
    [SupportedApiProfile(
        "openxr",
        ["XR_META_environment_raycast"],
        ImpliesSets = ["XR_EXT_future"]
    )]
    public EnvironmentRaycasterHandleMETA EnvironmentRaycaster;

    [SupportedApiProfile(
        "openxr",
        ["XR_META_environment_raycast"],
        ImpliesSets = ["XR_EXT_future"]
    )]
    public EnvironmentRaycasterCreateCompletionMETA() { }
}
