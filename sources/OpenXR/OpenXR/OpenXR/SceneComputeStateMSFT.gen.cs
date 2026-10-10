// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrSceneComputeStateMSFT")]
[SupportedApiProfile("openxr")]
public enum SceneComputeStateMSFT : uint
{
    [NativeName("XR_SCENE_COMPUTE_STATE_NONE_MSFT")]
    [SupportedApiProfile("openxr", ["XR_MSFT_scene_understanding"])]
    None = 0,

    [NativeName("XR_SCENE_COMPUTE_STATE_UPDATING_MSFT")]
    [SupportedApiProfile("openxr", ["XR_MSFT_scene_understanding"])]
    Updating = 1,

    [NativeName("XR_SCENE_COMPUTE_STATE_COMPLETED_MSFT")]
    [SupportedApiProfile("openxr", ["XR_MSFT_scene_understanding"])]
    Completed = 2,

    [NativeName("XR_SCENE_COMPUTE_STATE_COMPLETED_WITH_ERROR_MSFT")]
    [SupportedApiProfile("openxr", ["XR_MSFT_scene_understanding"])]
    CompletedWithError = 3,
}
