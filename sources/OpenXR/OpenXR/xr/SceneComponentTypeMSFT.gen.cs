// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrSceneComponentTypeMSFT")]
public enum SceneComponentTypeMSFT
{
    [NativeName("XR_SCENE_COMPONENT_TYPE_INVALID_MSFT")]
    Invalid = -1,

    [NativeName("XR_SCENE_COMPONENT_TYPE_OBJECT_MSFT")]
    Object = 1,

    [NativeName("XR_SCENE_COMPONENT_TYPE_PLANE_MSFT")]
    Plane = 2,

    [NativeName("XR_SCENE_COMPONENT_TYPE_VISUAL_MESH_MSFT")]
    VisualMesh = 3,

    [NativeName("XR_SCENE_COMPONENT_TYPE_COLLIDER_MESH_MSFT")]
    ColliderMesh = 4,

    [NativeName("XR_SCENE_COMPONENT_TYPE_SERIALIZED_SCENE_FRAGMENT_MSFT")]
    SerializedSceneFragment = 1000098000,

    [NativeName("XR_SCENE_COMPONENT_TYPE_MARKER_MSFT")]
    Marker = 1000147000,
}
