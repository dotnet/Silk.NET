// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrSceneObjectTypeMSFT")]
public enum SceneObjectTypeMSFT
{
    [NativeName("XR_SCENE_OBJECT_TYPE_UNCATEGORIZED_MSFT")]
    Uncategorized = -1,

    [NativeName("XR_SCENE_OBJECT_TYPE_BACKGROUND_MSFT")]
    Background = 1,

    [NativeName("XR_SCENE_OBJECT_TYPE_WALL_MSFT")]
    Wall = 2,

    [NativeName("XR_SCENE_OBJECT_TYPE_FLOOR_MSFT")]
    Floor = 3,

    [NativeName("XR_SCENE_OBJECT_TYPE_CEILING_MSFT")]
    Ceiling = 4,

    [NativeName("XR_SCENE_OBJECT_TYPE_PLATFORM_MSFT")]
    Platform = 5,

    [NativeName("XR_SCENE_OBJECT_TYPE_INFERRED_MSFT")]
    Inferred = 6,
}
