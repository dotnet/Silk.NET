// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenXR
{
    [NativeName("Name", "XrObjectType")]
    public enum ObjectType : int
    {
        [NativeName("Name", "XR_OBJECT_TYPE_UNKNOWN")]
        Unknown = 0,
        [NativeName("Name", "XR_OBJECT_TYPE_INSTANCE")]
        Instance = 1,
        [NativeName("Name", "XR_OBJECT_TYPE_SESSION")]
        Session = 2,
        [NativeName("Name", "XR_OBJECT_TYPE_SWAPCHAIN")]
        Swapchain = 3,
        [NativeName("Name", "XR_OBJECT_TYPE_SPACE")]
        Space = 4,
        [NativeName("Name", "XR_OBJECT_TYPE_ACTION_SET")]
        ActionSet = 5,
        [NativeName("Name", "XR_OBJECT_TYPE_ACTION")]
        Action = 6,
        [NativeName("Name", "XR_OBJECT_TYPE_DEBUG_UTILS_MESSENGER_EXT")]
        DebugUtilsMessengerExt = 1000019000,
        [NativeName("Name", "XR_OBJECT_TYPE_SPATIAL_ANCHOR_MSFT")]
        SpatialAnchorMsft = 1000039000,
        [NativeName("Name", "XR_OBJECT_TYPE_SPATIAL_GRAPH_NODE_BINDING_MSFT")]
        SpatialGraphNodeBindingMsft = 1000049000,
        [NativeName("Name", "XR_OBJECT_TYPE_HAND_TRACKER_EXT")]
        HandTrackerExt = 1000051000,
        [NativeName("Name", "XR_OBJECT_TYPE_SCENE_OBSERVER_MSFT")]
        SceneObserverMsft = 1000097000,
        [NativeName("Name", "XR_OBJECT_TYPE_SCENE_MSFT")]
        SceneMsft = 1000097001,
        [NativeName("Name", "XR_OBJECT_TYPE_FACIAL_TRACKER_HTC")]
        FacialTrackerHtc = 1000104000,
        [NativeName("Name", "XR_OBJECT_TYPE_FOVEATION_PROFILE_FB")]
        FoveationProfileFB = 1000114000,
        [NativeName("Name", "XR_OBJECT_TYPE_TRIANGLE_MESH_FB")]
        TriangleMeshFB = 1000117000,
        [NativeName("Name", "XR_OBJECT_TYPE_PASSTHROUGH_FB")]
        PassthroughFB = 1000118000,
        [NativeName("Name", "XR_OBJECT_TYPE_PASSTHROUGH_LAYER_FB")]
        PassthroughLayerFB = 1000118002,
        [NativeName("Name", "XR_OBJECT_TYPE_GEOMETRY_INSTANCE_FB")]
        GeometryInstanceFB = 1000118004,
        [NativeName("Name", "XR_OBJECT_TYPE_SPATIAL_ANCHOR_STORE_CONNECTION_MSFT")]
        SpatialAnchorStoreConnectionMsft = 1000142000,
        [NativeName("Name", "XR_OBJECT_TYPE_PASSTHROUGH_HTC")]
        PassthroughHtc = 1000317000,
    }
}
