// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrSceneComputeFeatureMSFT")]
[SupportedApiProfile("openxr")]
public enum SceneComputeFeatureMSFT : uint
{
    [NativeName("XR_SCENE_COMPUTE_FEATURE_PLANE_MSFT")]
    [SupportedApiProfile("openxr", ["XR_MSFT_scene_understanding"])]
    Plane = 1,

    [NativeName("XR_SCENE_COMPUTE_FEATURE_PLANE_MESH_MSFT")]
    [SupportedApiProfile("openxr", ["XR_MSFT_scene_understanding"])]
    PlaneMesh = 2,

    [NativeName("XR_SCENE_COMPUTE_FEATURE_VISUAL_MESH_MSFT")]
    [SupportedApiProfile("openxr", ["XR_MSFT_scene_understanding"])]
    VisualMesh = 3,

    [NativeName("XR_SCENE_COMPUTE_FEATURE_COLLIDER_MESH_MSFT")]
    [SupportedApiProfile("openxr", ["XR_MSFT_scene_understanding"])]
    ColliderMesh = 4,

    [NativeName("XR_SCENE_COMPUTE_FEATURE_SERIALIZE_SCENE_MSFT")]
    [SupportedApiProfile(
        "openxr",
        ["XR_MSFT_scene_understanding_serialization"],
        ImpliesSets = ["XR_MSFT_scene_understanding", "XR_VERSION_1_0"]
    )]
    SerializeScene = 1000098000,

    [NativeName("XR_SCENE_COMPUTE_FEATURE_MARKER_MSFT")]
    [SupportedApiProfile(
        "openxr",
        ["XR_MSFT_scene_marker"],
        ImpliesSets = ["XR_MSFT_scene_understanding", "XR_VERSION_1_0"]
    )]
    Marker = 1000147000,
}
