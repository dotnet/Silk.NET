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
        [NativeName("Name", "XR_OBJECT_TYPE_BODY_TRACKER_FB")]
        BodyTrackerFB = 1000076000,
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
        [NativeName("Name", "XR_OBJECT_TYPE_MARKER_DETECTOR_ML")]
        MarkerDetectorML = 1000138000,
        [NativeName("Name", "XR_OBJECT_TYPE_EXPORTED_LOCALIZATION_MAP_ML")]
        ExportedLocalizationMapML = 1000139000,
        [NativeName("Name", "XR_OBJECT_TYPE_SPATIAL_ANCHORS_STORAGE_ML")]
        SpatialAnchorsStorageML = 1000141000,
        [NativeName("Name", "XR_OBJECT_TYPE_SPATIAL_ANCHOR_STORE_CONNECTION_MSFT")]
        SpatialAnchorStoreConnectionMsft = 1000142000,
        [NativeName("Name", "XR_OBJECT_TYPE_FACE_TRACKER_FB")]
        FaceTrackerFB = 1000201000,
        [NativeName("Name", "XR_OBJECT_TYPE_EYE_TRACKER_FB")]
        EyeTrackerFB = 1000202000,
        [NativeName("Name", "XR_OBJECT_TYPE_VIRTUAL_KEYBOARD_META")]
        VirtualKeyboardMeta = 1000219000,
        [NativeName("Name", "XR_OBJECT_TYPE_SPACE_USER_FB")]
        SpaceUserFB = 1000241000,
        [NativeName("Name", "XR_OBJECT_TYPE_PASSTHROUGH_COLOR_LUT_META")]
        PassthroughColorLutMeta = 1000266000,
        [NativeName("Name", "XR_OBJECT_TYPE_FACE_TRACKER2_FB")]
        FaceTracker2FB = 1000287012,
        [NativeName("Name", "XR_OBJECT_TYPE_ENVIRONMENT_DEPTH_PROVIDER_META")]
        EnvironmentDepthProviderMeta = 1000291000,
        [NativeName("Name", "XR_OBJECT_TYPE_ENVIRONMENT_DEPTH_SWAPCHAIN_META")]
        EnvironmentDepthSwapchainMeta = 1000291001,
        [NativeName("Name", "XR_OBJECT_TYPE_RENDER_MODEL_EXT")]
        RenderModelExt = 1000300000,
        [NativeName("Name", "XR_OBJECT_TYPE_RENDER_MODEL_ASSET_EXT")]
        RenderModelAssetExt = 1000300001,
        [NativeName("Name", "XR_OBJECT_TYPE_PASSTHROUGH_HTC")]
        PassthroughHtc = 1000317000,
        [NativeName("Name", "XR_OBJECT_TYPE_BODY_TRACKER_HTC")]
        BodyTrackerHtc = 1000320000,
        [NativeName("Name", "XR_OBJECT_TYPE_BODY_TRACKER_BD")]
        BodyTrackerBD = 1000385000,
        [NativeName("Name", "XR_OBJECT_TYPE_SENSE_DATA_PROVIDER_BD")]
        SenseDataProviderBD = 1000389000,
        [NativeName("Name", "XR_OBJECT_TYPE_SENSE_DATA_SNAPSHOT_BD")]
        SenseDataSnapshotBD = 1000389001,
        [NativeName("Name", "XR_OBJECT_TYPE_ANCHOR_BD")]
        AnchorBD = 1000389002,
        [NativeName("Name", "XR_OBJECT_TYPE_PLANE_DETECTOR_EXT")]
        PlaneDetectorExt = 1000429000,
        [NativeName("Name", "XR_OBJECT_TYPE_TRACKABLE_TRACKER_ANDROID")]
        TrackableTrackerAndroid = 1000455001,
        [NativeName("Name", "XR_OBJECT_TYPE_DEVICE_ANCHOR_PERSISTENCE_ANDROID")]
        DeviceAnchorPersistenceAndroid = 1000457000,
        [NativeName("Name", "XR_OBJECT_TYPE_WORLD_MESH_DETECTOR_ML")]
        WorldMeshDetectorML = 1000474000,
        [NativeName("Name", "XR_OBJECT_TYPE_FACIAL_EXPRESSION_CLIENT_ML")]
        FacialExpressionClientML = 1000482000,
        [NativeName("Name", "XR_OBJECT_TYPE_SPATIAL_ENTITY_EXT")]
        SpatialEntityExt = 1000740000,
        [NativeName("Name", "XR_OBJECT_TYPE_SPATIAL_CONTEXT_EXT")]
        SpatialContextExt = 1000740001,
        [NativeName("Name", "XR_OBJECT_TYPE_SPATIAL_SNAPSHOT_EXT")]
        SpatialSnapshotExt = 1000740002,
        [NativeName("Name", "XR_OBJECT_TYPE_SPATIAL_PERSISTENCE_CONTEXT_EXT")]
        SpatialPersistenceContextExt = 1000763000,
    }
}
