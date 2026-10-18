// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrSceneComputeConsistencyMSFT")]
[SupportedApiProfile("openxr")]
public enum SceneComputeConsistencyMSFT : uint
{
    [NativeName("XR_SCENE_COMPUTE_CONSISTENCY_SNAPSHOT_COMPLETE_MSFT")]
    [SupportedApiProfile("openxr", ["XR_MSFT_scene_understanding"])]
    SnapshotComplete = 1,

    [NativeName("XR_SCENE_COMPUTE_CONSISTENCY_SNAPSHOT_INCOMPLETE_FAST_MSFT")]
    [SupportedApiProfile("openxr", ["XR_MSFT_scene_understanding"])]
    SnapshotIncompleteFast = 2,

    [NativeName("XR_SCENE_COMPUTE_CONSISTENCY_OCCLUSION_OPTIMIZED_MSFT")]
    [SupportedApiProfile("openxr", ["XR_MSFT_scene_understanding"])]
    OcclusionOptimized = 3,
}
