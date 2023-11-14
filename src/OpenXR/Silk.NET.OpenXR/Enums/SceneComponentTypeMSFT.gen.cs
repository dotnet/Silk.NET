// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenXR
{
    [Flags]
    [NativeName("Name", "XrSceneComponentTypeMSFT")]
    public enum SceneComponentTypeMSFT : int
    {
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"InvalidMsft\"")]
        [NativeName("Name", "XR_SCENE_COMPONENT_TYPE_INVALID_MSFT")]
        SceneComponentTypeInvalidMsft = unchecked((int) -1),
        [Obsolete("Deprecated in favour of \"ObjectMsft\"")]
        [NativeName("Name", "XR_SCENE_COMPONENT_TYPE_OBJECT_MSFT")]
        SceneComponentTypeObjectMsft = 1,
        [Obsolete("Deprecated in favour of \"PlaneMsft\"")]
        [NativeName("Name", "XR_SCENE_COMPONENT_TYPE_PLANE_MSFT")]
        SceneComponentTypePlaneMsft = 2,
        [Obsolete("Deprecated in favour of \"VisualMeshMsft\"")]
        [NativeName("Name", "XR_SCENE_COMPONENT_TYPE_VISUAL_MESH_MSFT")]
        SceneComponentTypeVisualMeshMsft = 3,
        [Obsolete("Deprecated in favour of \"ColliderMeshMsft\"")]
        [NativeName("Name", "XR_SCENE_COMPONENT_TYPE_COLLIDER_MESH_MSFT")]
        SceneComponentTypeColliderMeshMsft = 4,
        [Obsolete("Deprecated in favour of \"SerializedSceneFragmentMsft\"")]
        [NativeName("Name", "XR_SCENE_COMPONENT_TYPE_SERIALIZED_SCENE_FRAGMENT_MSFT")]
        SceneComponentTypeSerializedSceneFragmentMsft = 1000098000,
        [Obsolete("Deprecated in favour of \"MarkerMsft\"")]
        [NativeName("Name", "XR_SCENE_COMPONENT_TYPE_MARKER_MSFT")]
        SceneComponentTypeMarkerMsft = 1000147000,
        [NativeName("Name", "XR_SCENE_COMPONENT_TYPE_INVALID_MSFT")]
        InvalidMsft = unchecked((int) -1),
        [NativeName("Name", "XR_SCENE_COMPONENT_TYPE_OBJECT_MSFT")]
        ObjectMsft = 1,
        [NativeName("Name", "XR_SCENE_COMPONENT_TYPE_PLANE_MSFT")]
        PlaneMsft = 2,
        [NativeName("Name", "XR_SCENE_COMPONENT_TYPE_VISUAL_MESH_MSFT")]
        VisualMeshMsft = 3,
        [NativeName("Name", "XR_SCENE_COMPONENT_TYPE_COLLIDER_MESH_MSFT")]
        ColliderMeshMsft = 4,
        [NativeName("Name", "XR_SCENE_COMPONENT_TYPE_SERIALIZED_SCENE_FRAGMENT_MSFT")]
        SerializedSceneFragmentMsft = 1000098000,
        [NativeName("Name", "XR_SCENE_COMPONENT_TYPE_MARKER_MSFT")]
        MarkerMsft = 1000147000,
    }
}
