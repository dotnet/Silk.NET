// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrSceneComputeFeatureMSFT")]
public enum SceneComputeFeatureMSFT : uint
{
    [NativeName("XR_SCENE_COMPUTE_FEATURE_PLANE_MSFT")]
    Plane = 1,

    [NativeName("XR_SCENE_COMPUTE_FEATURE_PLANE_MESH_MSFT")]
    PlaneMesh = 2,

    [NativeName("XR_SCENE_COMPUTE_FEATURE_VISUAL_MESH_MSFT")]
    VisualMesh = 3,

    [NativeName("XR_SCENE_COMPUTE_FEATURE_COLLIDER_MESH_MSFT")]
    ColliderMesh = 4,

    [NativeName("XR_SCENE_COMPUTE_FEATURE_SERIALIZE_SCENE_MSFT")]
    SerializeScene = 1000098000,

    [NativeName("XR_SCENE_COMPUTE_FEATURE_MARKER_MSFT")]
    Marker = 1000147000,
}
