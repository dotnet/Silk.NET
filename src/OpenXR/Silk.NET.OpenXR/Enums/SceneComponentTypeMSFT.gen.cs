// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenXR
{
    [NativeName("Name", "XrSceneComponentTypeMSFT")]
    public enum SceneComponentTypeMSFT : int
    {
        [NativeName("Name", "XR_SCENE_COMPONENT_TYPE_INVALID_MSFT")]
        SceneComponentTypeInvalidMsft = -1,
        [NativeName("Name", "XR_SCENE_COMPONENT_TYPE_OBJECT_MSFT")]
        SceneComponentTypeObjectMsft = 1,
        [NativeName("Name", "XR_SCENE_COMPONENT_TYPE_PLANE_MSFT")]
        SceneComponentTypePlaneMsft = 2,
        [NativeName("Name", "XR_SCENE_COMPONENT_TYPE_VISUAL_MESH_MSFT")]
        SceneComponentTypeVisualMeshMsft = 3,
        [NativeName("Name", "XR_SCENE_COMPONENT_TYPE_COLLIDER_MESH_MSFT")]
        SceneComponentTypeColliderMeshMsft = 4,
        [NativeName("Name", "XR_SCENE_COMPONENT_TYPE_SERIALIZED_SCENE_FRAGMENT_MSFT")]
        SceneComponentTypeSerializedSceneFragmentMsft = 1000098000,
    }
}
