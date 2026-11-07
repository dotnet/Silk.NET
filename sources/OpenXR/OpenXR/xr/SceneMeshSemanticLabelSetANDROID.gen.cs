// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrSceneMeshSemanticLabelSetANDROID")]
[SupportedApiProfile("openxr")]
public enum SceneMeshSemanticLabelSetANDROID : uint
{
    [NativeName("XR_SCENE_MESH_SEMANTIC_LABEL_SET_NONE_ANDROID")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_scene_meshing"])]
    None = 0,

    [NativeName("XR_SCENE_MESH_SEMANTIC_LABEL_SET_DEFAULT_ANDROID")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_scene_meshing"])]
    Default = 1,
}
