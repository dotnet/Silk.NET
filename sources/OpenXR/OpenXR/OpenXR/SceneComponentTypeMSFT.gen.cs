// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrSceneComponentTypeMSFT")]
[SupportedApiProfile("openxr")]
public enum SceneComponentTypeMSFT
{
    [NativeName("XR_SCENE_COMPONENT_TYPE_INVALID_MSFT")]
    [SupportedApiProfile("openxr", ["XR_MSFT_scene_understanding"])]
    Invalid = -1,

    [NativeName("XR_SCENE_COMPONENT_TYPE_OBJECT_MSFT")]
    [SupportedApiProfile("openxr", ["XR_MSFT_scene_understanding"])]
    Object = 1,

    [NativeName("XR_SCENE_COMPONENT_TYPE_PLANE_MSFT")]
    [SupportedApiProfile("openxr", ["XR_MSFT_scene_understanding"])]
    Plane = 2,

    [NativeName("XR_SCENE_COMPONENT_TYPE_VISUAL_MESH_MSFT")]
    [SupportedApiProfile("openxr", ["XR_MSFT_scene_understanding"])]
    VisualMesh = 3,

    [NativeName("XR_SCENE_COMPONENT_TYPE_COLLIDER_MESH_MSFT")]
    [SupportedApiProfile("openxr", ["XR_MSFT_scene_understanding"])]
    ColliderMesh = 4,

    [NativeName("XR_SCENE_COMPONENT_TYPE_SERIALIZED_SCENE_FRAGMENT_MSFT")]
    [SupportedApiProfile(
        "openxr",
        ["XR_MSFT_scene_understanding_serialization"],
        ImpliesSets = ["XR_MSFT_scene_understanding", "XR_VERSION_1_0"]
    )]
    SerializedSceneFragment = 1000098000,

    [NativeName("XR_SCENE_COMPONENT_TYPE_MARKER_MSFT")]
    [SupportedApiProfile(
        "openxr",
        ["XR_MSFT_scene_marker"],
        ImpliesSets = ["XR_MSFT_scene_understanding", "XR_VERSION_1_0"]
    )]
    Marker = 1000147000,
}
