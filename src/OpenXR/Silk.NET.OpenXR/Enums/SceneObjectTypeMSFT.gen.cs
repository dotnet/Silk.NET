// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenXR
{
    [NativeName("Name", "XrSceneObjectTypeMSFT")]
    public enum SceneObjectTypeMSFT : int
    {
        [Obsolete("Deprecated in favour of \"UncategorizedMsft\"")]
        [NativeName("Name", "XR_SCENE_OBJECT_TYPE_UNCATEGORIZED_MSFT")]
        SceneObjectTypeUncategorizedMsft = unchecked((int) -1),
        [Obsolete("Deprecated in favour of \"BackgroundMsft\"")]
        [NativeName("Name", "XR_SCENE_OBJECT_TYPE_BACKGROUND_MSFT")]
        SceneObjectTypeBackgroundMsft = 1,
        [Obsolete("Deprecated in favour of \"WallMsft\"")]
        [NativeName("Name", "XR_SCENE_OBJECT_TYPE_WALL_MSFT")]
        SceneObjectTypeWallMsft = 2,
        [Obsolete("Deprecated in favour of \"FloorMsft\"")]
        [NativeName("Name", "XR_SCENE_OBJECT_TYPE_FLOOR_MSFT")]
        SceneObjectTypeFloorMsft = 3,
        [Obsolete("Deprecated in favour of \"CeilingMsft\"")]
        [NativeName("Name", "XR_SCENE_OBJECT_TYPE_CEILING_MSFT")]
        SceneObjectTypeCeilingMsft = 4,
        [Obsolete("Deprecated in favour of \"PlatformMsft\"")]
        [NativeName("Name", "XR_SCENE_OBJECT_TYPE_PLATFORM_MSFT")]
        SceneObjectTypePlatformMsft = 5,
        [Obsolete("Deprecated in favour of \"InferredMsft\"")]
        [NativeName("Name", "XR_SCENE_OBJECT_TYPE_INFERRED_MSFT")]
        SceneObjectTypeInferredMsft = 6,
        [NativeName("Name", "XR_SCENE_OBJECT_TYPE_UNCATEGORIZED_MSFT")]
        UncategorizedMsft = unchecked((int) -1),
        [NativeName("Name", "XR_SCENE_OBJECT_TYPE_BACKGROUND_MSFT")]
        BackgroundMsft = 1,
        [NativeName("Name", "XR_SCENE_OBJECT_TYPE_WALL_MSFT")]
        WallMsft = 2,
        [NativeName("Name", "XR_SCENE_OBJECT_TYPE_FLOOR_MSFT")]
        FloorMsft = 3,
        [NativeName("Name", "XR_SCENE_OBJECT_TYPE_CEILING_MSFT")]
        CeilingMsft = 4,
        [NativeName("Name", "XR_SCENE_OBJECT_TYPE_PLATFORM_MSFT")]
        PlatformMsft = 5,
        [NativeName("Name", "XR_SCENE_OBJECT_TYPE_INFERRED_MSFT")]
        InferredMsft = 6,
    }
}
