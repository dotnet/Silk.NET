// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrObjectType")]
[SupportedApiProfile("openxr")]
public enum ObjectType : uint
{
    [NativeName("XR_OBJECT_TYPE_UNKNOWN")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    Unknown = 0,

    [NativeName("XR_OBJECT_TYPE_INSTANCE")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    Instance = 1,

    [NativeName("XR_OBJECT_TYPE_SESSION")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    Session = 2,

    [NativeName("XR_OBJECT_TYPE_SWAPCHAIN")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    Swapchain = 3,

    [NativeName("XR_OBJECT_TYPE_SPACE")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    Space = 4,

    [NativeName("XR_OBJECT_TYPE_ACTION_SET")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    ActionSet = 5,

    [NativeName("XR_OBJECT_TYPE_ACTION")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    Action = 6,

    [NativeName("XR_OBJECT_TYPE_DEBUG_UTILS_MESSENGER_EXT")]
    [SupportedApiProfile("openxr", ["XR_EXT_debug_utils"])]
    DebugUtilsMessengerEXT = 1000019000,

    [NativeName("XR_OBJECT_TYPE_SPATIAL_ANCHOR_MSFT")]
    [SupportedApiProfile("openxr", ["XR_MSFT_spatial_anchor"])]
    SpatialAnchorMSFT = 1000039000,

    [NativeName("XR_OBJECT_TYPE_SPATIAL_GRAPH_NODE_BINDING_MSFT")]
    [SupportedApiProfile("openxr", ["XR_MSFT_spatial_graph_bridge"])]
    SpatialGraphNodeBindingMSFT = 1000049000,

    [NativeName("XR_OBJECT_TYPE_HAND_TRACKER_EXT")]
    [SupportedApiProfile("openxr", ["XR_EXT_hand_tracking"])]
    HandTrackerEXT = 1000051000,

    [NativeName("XR_OBJECT_TYPE_BODY_TRACKER_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_body_tracking"])]
    BodyTrackerFB = 1000076000,

    [NativeName("XR_OBJECT_TYPE_SCENE_OBSERVER_MSFT")]
    [SupportedApiProfile("openxr", ["XR_MSFT_scene_understanding"])]
    SceneObserverMSFT = 1000097000,

    [NativeName("XR_OBJECT_TYPE_SCENE_MSFT")]
    [SupportedApiProfile("openxr", ["XR_MSFT_scene_understanding"])]
    SceneMSFT = 1000097001,

    [NativeName("XR_OBJECT_TYPE_FACIAL_TRACKER_HTC")]
    [SupportedApiProfile("openxr", ["XR_HTC_facial_tracking"])]
    FacialTrackerHTC = 1000104000,

    [NativeName("XR_OBJECT_TYPE_FOVEATION_PROFILE_FB")]
    [SupportedApiProfile(
        "openxr",
        ["XR_FB_foveation"],
        ImpliesSets = ["XR_FB_swapchain_update_state", "XR_VERSION_1_0"]
    )]
    FoveationProfileFB = 1000114000,

    [NativeName("XR_OBJECT_TYPE_TRIANGLE_MESH_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_triangle_mesh"])]
    TriangleMeshFB = 1000117000,

    [NativeName("XR_OBJECT_TYPE_PASSTHROUGH_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_passthrough"])]
    PassthroughFB = 1000118000,

    [NativeName("XR_OBJECT_TYPE_PASSTHROUGH_LAYER_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_passthrough"])]
    PassthroughLayerFB = 1000118002,

    [NativeName("XR_OBJECT_TYPE_GEOMETRY_INSTANCE_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_passthrough"])]
    GeometryInstanceFB = 1000118004,

    [NativeName("XR_OBJECT_TYPE_MARKER_DETECTOR_ML")]
    [SupportedApiProfile("openxr", ["XR_ML_marker_understanding"])]
    MarkerDetectorML = 1000138000,

    [NativeName("XR_OBJECT_TYPE_EXPORTED_LOCALIZATION_MAP_ML")]
    [SupportedApiProfile(
        "openxr",
        ["XR_ML_localization_map"],
        ImpliesSets = ["XR_EXT_uuid", "XR_VERSION_1_0"]
    )]
    ExportedLocalizationMapML = 1000139000,

    [NativeName("XR_OBJECT_TYPE_SPATIAL_ANCHORS_STORAGE_ML")]
    [SupportedApiProfile(
        "openxr",
        ["XR_ML_spatial_anchors_storage"],
        ImpliesSets = ["XR_EXT_future", "XR_ML_spatial_anchors"]
    )]
    SpatialAnchorsStorageML = 1000141000,

    [NativeName("XR_OBJECT_TYPE_SPATIAL_ANCHOR_STORE_CONNECTION_MSFT")]
    [SupportedApiProfile(
        "openxr",
        ["XR_MSFT_spatial_anchor_persistence"],
        ImpliesSets = ["XR_MSFT_spatial_anchor", "XR_VERSION_1_0"]
    )]
    SpatialAnchorStoreConnectionMSFT = 1000142000,

    [NativeName("XR_OBJECT_TYPE_FACE_TRACKER_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_face_tracking"])]
    FaceTrackerFB = 1000201000,

    [NativeName("XR_OBJECT_TYPE_EYE_TRACKER_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_eye_tracking_social"])]
    EyeTrackerFB = 1000202000,

    [NativeName("XR_OBJECT_TYPE_VIRTUAL_KEYBOARD_META")]
    [SupportedApiProfile("openxr", ["XR_META_virtual_keyboard"])]
    VirtualKeyboardMETA = 1000219000,

    [NativeName("XR_OBJECT_TYPE_SPACE_USER_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_spatial_entity_user"])]
    SpaceUserFB = 1000241000,

    [NativeName("XR_OBJECT_TYPE_PASSTHROUGH_COLOR_LUT_META")]
    [SupportedApiProfile(
        "openxr",
        ["XR_META_passthrough_color_lut"],
        ImpliesSets = ["XR_FB_passthrough", "XR_VERSION_1_0"]
    )]
    PassthroughColorLutMETA = 1000266000,

    [NativeName("XR_OBJECT_TYPE_FACE_TRACKER2_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_face_tracking2"])]
    FaceTracker2FB = 1000287012,

    [NativeName("XR_OBJECT_TYPE_ENVIRONMENT_DEPTH_PROVIDER_META")]
    [SupportedApiProfile("openxr", ["XR_META_environment_depth"])]
    EnvironmentDepthProviderMETA = 1000291000,

    [NativeName("XR_OBJECT_TYPE_ENVIRONMENT_DEPTH_SWAPCHAIN_META")]
    [SupportedApiProfile("openxr", ["XR_META_environment_depth"])]
    EnvironmentDepthSwapchainMETA = 1000291001,

    [NativeName("XR_OBJECT_TYPE_RENDER_MODEL_EXT")]
    [SupportedApiProfile(
        "openxr",
        ["XR_EXT_render_model"],
        ImpliesSets = ["XR_EXT_render_model+XR_EXT_uuid", "XR_EXT_render_model+XR_VERSION_1_1"]
    )]
    RenderModelEXT = 1000300000,

    [NativeName("XR_OBJECT_TYPE_RENDER_MODEL_ASSET_EXT")]
    [SupportedApiProfile(
        "openxr",
        ["XR_EXT_render_model"],
        ImpliesSets = ["XR_EXT_render_model+XR_EXT_uuid", "XR_EXT_render_model+XR_VERSION_1_1"]
    )]
    RenderModelAssetEXT = 1000300001,

    [NativeName("XR_OBJECT_TYPE_PASSTHROUGH_HTC")]
    [SupportedApiProfile("openxr", ["XR_HTC_passthrough"])]
    PassthroughHTC = 1000317000,

    [NativeName("XR_OBJECT_TYPE_BODY_TRACKER_HTC")]
    [SupportedApiProfile("openxr", ["XR_HTC_body_tracking"])]
    BodyTrackerHTC = 1000320000,

    [NativeName("XR_OBJECT_TYPE_BODY_TRACKER_BD")]
    [SupportedApiProfile("openxr", ["XR_BD_body_tracking"])]
    BodyTrackerBD = 1000385000,

    [NativeName("XR_OBJECT_TYPE_FACE_TRACKER_BD")]
    [SupportedApiProfile("openxr", ["XR_BD_facial_simulation"])]
    FaceTrackerBD = 1000386000,

    [NativeName("XR_OBJECT_TYPE_SENSE_DATA_PROVIDER_BD")]
    [SupportedApiProfile(
        "openxr",
        ["XR_BD_spatial_sensing"],
        ImpliesSets = ["XR_EXT_future", "XR_VERSION_1_0"]
    )]
    SenseDataProviderBD = 1000389000,

    [NativeName("XR_OBJECT_TYPE_SENSE_DATA_SNAPSHOT_BD")]
    [SupportedApiProfile(
        "openxr",
        ["XR_BD_spatial_sensing"],
        ImpliesSets = ["XR_EXT_future", "XR_VERSION_1_0"]
    )]
    SenseDataSnapshotBD = 1000389001,

    [NativeName("XR_OBJECT_TYPE_ANCHOR_BD")]
    [SupportedApiProfile(
        "openxr",
        ["XR_BD_spatial_sensing"],
        ImpliesSets = ["XR_EXT_future", "XR_VERSION_1_0"]
    )]
    AnchorBD = 1000389002,

    [NativeName("XR_OBJECT_TYPE_SPATIAL_AUDIO_RENDERER_BD")]
    [SupportedApiProfile("openxr", ["XR_BD_spatial_audio_rendering"])]
    SpatialAudioRendererBD = 1000409000,

    [NativeName("XR_OBJECT_TYPE_SOUND_FIELD_BD")]
    [SupportedApiProfile("openxr", ["XR_BD_spatial_audio_rendering"])]
    SoundFieldBD = 1000409001,

    [NativeName("XR_OBJECT_TYPE_SOUND_OBJECT_BD")]
    [SupportedApiProfile("openxr", ["XR_BD_spatial_audio_rendering"])]
    SoundObjectBD = 1000409002,

    [NativeName("XR_OBJECT_TYPE_SOUND_OBSTACLE_BD")]
    [SupportedApiProfile("openxr", ["XR_BD_spatial_audio_rendering"])]
    SoundObstacleBD = 1000409003,

    [NativeName("XR_OBJECT_TYPE_SOUND_OBSTACLE_MATERIAL_BD")]
    [SupportedApiProfile("openxr", ["XR_BD_spatial_audio_rendering"])]
    SoundObstacleMaterialBD = 1000409004,

    [NativeName("XR_OBJECT_TYPE_PLANE_DETECTOR_EXT")]
    [SupportedApiProfile("openxr", ["XR_EXT_plane_detection"])]
    PlaneDetectorEXT = 1000429000,

    [NativeName("XR_OBJECT_TYPE_TRACKABLE_TRACKER_ANDROID")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_trackables"])]
    TrackableTrackerANDROID = 1000455001,

    [NativeName("XR_OBJECT_TYPE_EYE_TRACKER_ANDROID")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_eye_tracking"])]
    EyeTrackerANDROID = 1000456000,

    [NativeName("XR_OBJECT_TYPE_DEVICE_ANCHOR_PERSISTENCE_ANDROID")]
    [SupportedApiProfile(
        "openxr",
        ["XR_ANDROID_device_anchor_persistence"],
        ImpliesSets = ["XR_ANDROID_trackables", "XR_EXT_uuid"]
    )]
    DeviceAnchorPersistenceANDROID = 1000457000,

    [NativeName("XR_OBJECT_TYPE_FACE_TRACKER_ANDROID")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_face_tracking"])]
    FaceTrackerANDROID = 1000458000,

    [NativeName("XR_OBJECT_TYPE_PASSTHROUGH_LAYER_ANDROID")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_composition_layer_passthrough_mesh"])]
    PassthroughLayerANDROID = 1000462000,

    [NativeName("XR_OBJECT_TYPE_WORLD_MESH_DETECTOR_ML")]
    [SupportedApiProfile("openxr", ["XR_ML_world_mesh_detection"], ImpliesSets = ["XR_EXT_future"])]
    WorldMeshDetectorML = 1000474000,

    [NativeName("XR_OBJECT_TYPE_FACIAL_EXPRESSION_CLIENT_ML")]
    [SupportedApiProfile("openxr", ["XR_ML_facial_expression"])]
    FacialExpressionClientML = 1000482000,

    [NativeName("XR_OBJECT_TYPE_ENVIRONMENT_RAYCASTER_META")]
    [SupportedApiProfile(
        "openxr",
        ["XR_META_environment_raycast"],
        ImpliesSets = ["XR_EXT_future"]
    )]
    EnvironmentRaycasterMETA = 1000592000,

    [NativeName("XR_OBJECT_TYPE_LIGHT_ESTIMATOR_ANDROID")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_light_estimation"])]
    LightEstimatorANDROID = 1000700000,

    [NativeName("XR_OBJECT_TYPE_TRACKABLE_IMAGE_DATABASE_ANDROID")]
    [SupportedApiProfile(
        "openxr",
        ["XR_ANDROID_trackables_image"],
        ImpliesSets = ["XR_ANDROID_trackables", "XR_EXT_future"]
    )]
    TrackableImageDatabaseANDROID = 1000709000,

    [NativeName("XR_OBJECT_TYPE_SCENE_MESHING_TRACKER_ANDROID")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_scene_meshing"])]
    SceneMeshingTrackerANDROID = 1000718000,

    [NativeName("XR_OBJECT_TYPE_SCENE_MESH_SNAPSHOT_ANDROID")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_scene_meshing"])]
    SceneMeshSnapshotANDROID = 1000718001,

    [NativeName("XR_OBJECT_TYPE_SPATIAL_ENTITY_EXT")]
    [SupportedApiProfile("openxr", ["XR_EXT_spatial_entity"], ImpliesSets = ["XR_EXT_future"])]
    SpatialEntityEXT = 1000740000,

    [NativeName("XR_OBJECT_TYPE_SPATIAL_CONTEXT_EXT")]
    [SupportedApiProfile("openxr", ["XR_EXT_spatial_entity"], ImpliesSets = ["XR_EXT_future"])]
    SpatialContextEXT = 1000740001,

    [NativeName("XR_OBJECT_TYPE_SPATIAL_SNAPSHOT_EXT")]
    [SupportedApiProfile("openxr", ["XR_EXT_spatial_entity"], ImpliesSets = ["XR_EXT_future"])]
    SpatialSnapshotEXT = 1000740002,

    [NativeName("XR_OBJECT_TYPE_SPATIAL_PERSISTENCE_CONTEXT_EXT")]
    [SupportedApiProfile(
        "openxr",
        ["XR_EXT_spatial_persistence"],
        ImpliesSets = ["XR_EXT_future", "XR_EXT_spatial_entity"]
    )]
    SpatialPersistenceContextEXT = 1000763000,
}
