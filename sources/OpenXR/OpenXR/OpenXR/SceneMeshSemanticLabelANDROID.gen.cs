// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrSceneMeshSemanticLabelANDROID")]
[SupportedApiProfile("openxr")]
public enum SceneMeshSemanticLabelANDROID : uint
{
    [NativeName("XR_SCENE_MESH_SEMANTIC_LABEL_OTHER_ANDROID")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_scene_meshing"])]
    Other = 0,

    [NativeName("XR_SCENE_MESH_SEMANTIC_LABEL_FLOOR_ANDROID")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_scene_meshing"])]
    Floor = 1,

    [NativeName("XR_SCENE_MESH_SEMANTIC_LABEL_CEILING_ANDROID")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_scene_meshing"])]
    Ceiling = 2,

    [NativeName("XR_SCENE_MESH_SEMANTIC_LABEL_WALL_ANDROID")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_scene_meshing"])]
    Wall = 3,

    [NativeName("XR_SCENE_MESH_SEMANTIC_LABEL_TABLE_ANDROID")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_scene_meshing"])]
    Table = 4,
}
