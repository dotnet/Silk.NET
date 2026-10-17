// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrObjectType")]
public enum ObjectType : uint
{
    [NativeName("XR_OBJECT_TYPE_UNKNOWN")]
    Unknown = 0,

    [NativeName("XR_OBJECT_TYPE_INSTANCE")]
    Instance = 1,

    [NativeName("XR_OBJECT_TYPE_SESSION")]
    Session = 2,

    [NativeName("XR_OBJECT_TYPE_SWAPCHAIN")]
    Swapchain = 3,

    [NativeName("XR_OBJECT_TYPE_SPACE")]
    Space = 4,

    [NativeName("XR_OBJECT_TYPE_ACTION_SET")]
    ActionSet = 5,

    [NativeName("XR_OBJECT_TYPE_ACTION")]
    Action = 6,

    [NativeName("XR_OBJECT_TYPE_DEBUG_UTILS_MESSENGER_EXT")]
    DebugUtilsMessengerEXT = 1000019000,

    [NativeName("XR_OBJECT_TYPE_SPATIAL_ANCHOR_MSFT")]
    SpatialAnchorMSFT = 1000039000,

    [NativeName("XR_OBJECT_TYPE_SPATIAL_GRAPH_NODE_BINDING_MSFT")]
    SpatialGraphNodeBindingMSFT = 1000049000,

    [NativeName("XR_OBJECT_TYPE_HAND_TRACKER_EXT")]
    HandTrackerEXT = 1000051000,

    [NativeName("XR_OBJECT_TYPE_BODY_TRACKER_FB")]
    BodyTrackerFB = 1000076000,

    [NativeName("XR_OBJECT_TYPE_SCENE_OBSERVER_MSFT")]
    SceneObserverMSFT = 1000097000,

    [NativeName("XR_OBJECT_TYPE_SCENE_MSFT")]
    SceneMSFT = 1000097001,

    [NativeName("XR_OBJECT_TYPE_FACIAL_TRACKER_HTC")]
    FacialTrackerHTC = 1000104000,

    [NativeName("XR_OBJECT_TYPE_FOVEATION_PROFILE_FB")]
    FoveationProfileFB = 1000114000,

    [NativeName("XR_OBJECT_TYPE_TRIANGLE_MESH_FB")]
    TriangleMeshFB = 1000117000,

    [NativeName("XR_OBJECT_TYPE_PASSTHROUGH_FB")]
    PassthroughFB = 1000118000,

    [NativeName("XR_OBJECT_TYPE_PASSTHROUGH_LAYER_FB")]
    PassthroughLayerFB = 1000118002,

    [NativeName("XR_OBJECT_TYPE_GEOMETRY_INSTANCE_FB")]
    GeometryInstanceFB = 1000118004,

    [NativeName("XR_OBJECT_TYPE_MARKER_DETECTOR_ML")]
    MarkerDetectorML = 1000138000,

    [NativeName("XR_OBJECT_TYPE_EXPORTED_LOCALIZATION_MAP_ML")]
    ExportedLocalizationMapML = 1000139000,

    [NativeName("XR_OBJECT_TYPE_SPATIAL_ANCHORS_STORAGE_ML")]
    SpatialAnchorsStorageML = 1000141000,

    [NativeName("XR_OBJECT_TYPE_SPATIAL_ANCHOR_STORE_CONNECTION_MSFT")]
    SpatialAnchorStoreConnectionMSFT = 1000142000,

    [NativeName("XR_OBJECT_TYPE_FACE_TRACKER_FB")]
    FaceTrackerFB = 1000201000,

    [NativeName("XR_OBJECT_TYPE_EYE_TRACKER_FB")]
    EyeTrackerFB = 1000202000,

    [NativeName("XR_OBJECT_TYPE_VIRTUAL_KEYBOARD_META")]
    VirtualKeyboardMETA = 1000219000,

    [NativeName("XR_OBJECT_TYPE_SPACE_USER_FB")]
    SpaceUserFB = 1000241000,

    [NativeName("XR_OBJECT_TYPE_PASSTHROUGH_COLOR_LUT_META")]
    PassthroughColorLutMETA = 1000266000,

    [NativeName("XR_OBJECT_TYPE_FACE_TRACKER2_FB")]
    FaceTracker2FB = 1000287012,

    [NativeName("XR_OBJECT_TYPE_ENVIRONMENT_DEPTH_PROVIDER_META")]
    EnvironmentDepthProviderMETA = 1000291000,

    [NativeName("XR_OBJECT_TYPE_ENVIRONMENT_DEPTH_SWAPCHAIN_META")]
    EnvironmentDepthSwapchainMETA = 1000291001,

    [NativeName("XR_OBJECT_TYPE_RENDER_MODEL_EXT")]
    RenderModelEXT = 1000300000,

    [NativeName("XR_OBJECT_TYPE_RENDER_MODEL_ASSET_EXT")]
    RenderModelAssetEXT = 1000300001,

    [NativeName("XR_OBJECT_TYPE_PASSTHROUGH_HTC")]
    PassthroughHTC = 1000317000,

    [NativeName("XR_OBJECT_TYPE_BODY_TRACKER_HTC")]
    BodyTrackerHTC = 1000320000,

    [NativeName("XR_OBJECT_TYPE_BODY_TRACKER_BD")]
    BodyTrackerBD = 1000385000,

    [NativeName("XR_OBJECT_TYPE_FACE_TRACKER_BD")]
    FaceTrackerBD = 1000386000,

    [NativeName("XR_OBJECT_TYPE_SENSE_DATA_PROVIDER_BD")]
    SenseDataProviderBD = 1000389000,

    [NativeName("XR_OBJECT_TYPE_SENSE_DATA_SNAPSHOT_BD")]
    SenseDataSnapshotBD = 1000389001,

    [NativeName("XR_OBJECT_TYPE_ANCHOR_BD")]
    AnchorBD = 1000389002,

    [NativeName("XR_OBJECT_TYPE_SPATIAL_AUDIO_RENDERER_BD")]
    SpatialAudioRendererBD = 1000409000,

    [NativeName("XR_OBJECT_TYPE_SOUND_FIELD_BD")]
    SoundFieldBD = 1000409001,

    [NativeName("XR_OBJECT_TYPE_SOUND_OBJECT_BD")]
    SoundObjectBD = 1000409002,

    [NativeName("XR_OBJECT_TYPE_SOUND_OBSTACLE_BD")]
    SoundObstacleBD = 1000409003,

    [NativeName("XR_OBJECT_TYPE_SOUND_OBSTACLE_MATERIAL_BD")]
    SoundObstacleMaterialBD = 1000409004,

    [NativeName("XR_OBJECT_TYPE_PLANE_DETECTOR_EXT")]
    PlaneDetectorEXT = 1000429000,

    [NativeName("XR_OBJECT_TYPE_TRACKABLE_TRACKER_ANDROID")]
    TrackableTrackerANDROID = 1000455001,

    [NativeName("XR_OBJECT_TYPE_EYE_TRACKER_ANDROID")]
    EyeTrackerANDROID = 1000456000,

    [NativeName("XR_OBJECT_TYPE_DEVICE_ANCHOR_PERSISTENCE_ANDROID")]
    DeviceAnchorPersistenceANDROID = 1000457000,

    [NativeName("XR_OBJECT_TYPE_FACE_TRACKER_ANDROID")]
    FaceTrackerANDROID = 1000458000,

    [NativeName("XR_OBJECT_TYPE_PASSTHROUGH_LAYER_ANDROID")]
    PassthroughLayerANDROID = 1000462000,

    [NativeName("XR_OBJECT_TYPE_WORLD_MESH_DETECTOR_ML")]
    WorldMeshDetectorML = 1000474000,

    [NativeName("XR_OBJECT_TYPE_FACIAL_EXPRESSION_CLIENT_ML")]
    FacialExpressionClientML = 1000482000,

    [NativeName("XR_OBJECT_TYPE_ENVIRONMENT_RAYCASTER_META")]
    EnvironmentRaycasterMETA = 1000592000,

    [NativeName("XR_OBJECT_TYPE_LIGHT_ESTIMATOR_ANDROID")]
    LightEstimatorANDROID = 1000700000,

    [NativeName("XR_OBJECT_TYPE_TRACKABLE_IMAGE_DATABASE_ANDROID")]
    TrackableImageDatabaseANDROID = 1000709000,

    [NativeName("XR_OBJECT_TYPE_SCENE_MESHING_TRACKER_ANDROID")]
    SceneMeshingTrackerANDROID = 1000718000,

    [NativeName("XR_OBJECT_TYPE_SCENE_MESH_SNAPSHOT_ANDROID")]
    SceneMeshSnapshotANDROID = 1000718001,

    [NativeName("XR_OBJECT_TYPE_SPATIAL_ENTITY_EXT")]
    SpatialEntityEXT = 1000740000,

    [NativeName("XR_OBJECT_TYPE_SPATIAL_CONTEXT_EXT")]
    SpatialContextEXT = 1000740001,

    [NativeName("XR_OBJECT_TYPE_SPATIAL_SNAPSHOT_EXT")]
    SpatialSnapshotEXT = 1000740002,

    [NativeName("XR_OBJECT_TYPE_SPATIAL_PERSISTENCE_CONTEXT_EXT")]
    SpatialPersistenceContextEXT = 1000763000,
}
