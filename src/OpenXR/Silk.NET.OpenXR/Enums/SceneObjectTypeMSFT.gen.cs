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
        [NativeName("Name", "XR_SCENE_OBJECT_TYPE_UNCATEGORIZED_MSFT")]
        SceneObjectTypeUncategorizedMsft = -1,
        [NativeName("Name", "XR_SCENE_OBJECT_TYPE_BACKGROUND_MSFT")]
        SceneObjectTypeBackgroundMsft = 1,
        [NativeName("Name", "XR_SCENE_OBJECT_TYPE_WALL_MSFT")]
        SceneObjectTypeWallMsft = 2,
        [NativeName("Name", "XR_SCENE_OBJECT_TYPE_FLOOR_MSFT")]
        SceneObjectTypeFloorMsft = 3,
        [NativeName("Name", "XR_SCENE_OBJECT_TYPE_CEILING_MSFT")]
        SceneObjectTypeCeilingMsft = 4,
        [NativeName("Name", "XR_SCENE_OBJECT_TYPE_PLATFORM_MSFT")]
        SceneObjectTypePlatformMsft = 5,
        [NativeName("Name", "XR_SCENE_OBJECT_TYPE_INFERRED_MSFT")]
        SceneObjectTypeInferredMsft = 6,
    }
}
