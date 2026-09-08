// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrSceneObjectTypeMSFT")]
[SupportedApiProfile("openxr")]
public enum SceneObjectTypeMSFT
{
    [NativeName("XR_SCENE_OBJECT_TYPE_UNCATEGORIZED_MSFT")]
    [SupportedApiProfile("openxr", ["XR_MSFT_scene_understanding"])]
    Uncategorized = -1,

    [NativeName("XR_SCENE_OBJECT_TYPE_BACKGROUND_MSFT")]
    [SupportedApiProfile("openxr", ["XR_MSFT_scene_understanding"])]
    Background = 1,

    [NativeName("XR_SCENE_OBJECT_TYPE_WALL_MSFT")]
    [SupportedApiProfile("openxr", ["XR_MSFT_scene_understanding"])]
    Wall = 2,

    [NativeName("XR_SCENE_OBJECT_TYPE_FLOOR_MSFT")]
    [SupportedApiProfile("openxr", ["XR_MSFT_scene_understanding"])]
    Floor = 3,

    [NativeName("XR_SCENE_OBJECT_TYPE_CEILING_MSFT")]
    [SupportedApiProfile("openxr", ["XR_MSFT_scene_understanding"])]
    Ceiling = 4,

    [NativeName("XR_SCENE_OBJECT_TYPE_PLATFORM_MSFT")]
    [SupportedApiProfile("openxr", ["XR_MSFT_scene_understanding"])]
    Platform = 5,

    [NativeName("XR_SCENE_OBJECT_TYPE_INFERRED_MSFT")]
    [SupportedApiProfile("openxr", ["XR_MSFT_scene_understanding"])]
    Inferred = 6,
}
