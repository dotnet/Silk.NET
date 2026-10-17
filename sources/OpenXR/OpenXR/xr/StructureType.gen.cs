// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrStructureType")]
public enum StructureType : uint
{
    [NativeName("XR_TYPE_UNKNOWN")]
    Unknown = 0,

    [NativeName("XR_TYPE_API_LAYER_PROPERTIES")]
    ApiLayerProperties = 1,

    [NativeName("XR_TYPE_EXTENSION_PROPERTIES")]
    ExtensionProperties = 2,

    [NativeName("XR_TYPE_INSTANCE_CREATE_INFO")]
    InstanceCreateInfo = 3,

    [NativeName("XR_TYPE_SYSTEM_GET_INFO")]
    SystemGetInfo = 4,

    [NativeName("XR_TYPE_SYSTEM_PROPERTIES")]
    SystemProperties = 5,

    [NativeName("XR_TYPE_VIEW_LOCATE_INFO")]
    ViewLocateInfo = 6,

    [NativeName("XR_TYPE_VIEW")]
    View = 7,

    [NativeName("XR_TYPE_SESSION_CREATE_INFO")]
    SessionCreateInfo = 8,

    [NativeName("XR_TYPE_SWAPCHAIN_CREATE_INFO")]
    SwapchainCreateInfo = 9,

    [NativeName("XR_TYPE_SESSION_BEGIN_INFO")]
    SessionBeginInfo = 10,

    [NativeName("XR_TYPE_VIEW_STATE")]
    ViewState = 11,

    [NativeName("XR_TYPE_FRAME_END_INFO")]
    FrameEndInfo = 12,

    [NativeName("XR_TYPE_HAPTIC_VIBRATION")]
    HapticVibration = 13,

    [NativeName("XR_TYPE_EVENT_DATA_BUFFER")]
    EventDataBuffer = 16,

    [NativeName("XR_TYPE_EVENT_DATA_INSTANCE_LOSS_PENDING")]
    EventDataInstanceLossPending = 17,

    [NativeName("XR_TYPE_EVENT_DATA_SESSION_STATE_CHANGED")]
    EventDataSessionStateChanged = 18,

    [NativeName("XR_TYPE_ACTION_STATE_BOOLEAN")]
    ActionStateBoolean = 23,

    [NativeName("XR_TYPE_ACTION_STATE_FLOAT")]
    ActionStateFloat = 24,

    [NativeName("XR_TYPE_ACTION_STATE_VECTOR2F")]
    ActionStateVector2F = 25,

    [NativeName("XR_TYPE_ACTION_STATE_POSE")]
    ActionStatePose = 27,

    [NativeName("XR_TYPE_ACTION_SET_CREATE_INFO")]
    ActionSetCreateInfo = 28,

    [NativeName("XR_TYPE_ACTION_CREATE_INFO")]
    ActionCreateInfo = 29,

    [NativeName("XR_TYPE_INSTANCE_PROPERTIES")]
    InstanceProperties = 32,

    [NativeName("XR_TYPE_FRAME_WAIT_INFO")]
    FrameWaitInfo = 33,

    [NativeName("XR_TYPE_COMPOSITION_LAYER_PROJECTION")]
    CompositionLayerProjection = 35,

    [NativeName("XR_TYPE_COMPOSITION_LAYER_QUAD")]
    CompositionLayerQuad = 36,

    [NativeName("XR_TYPE_REFERENCE_SPACE_CREATE_INFO")]
    ReferenceSpaceCreateInfo = 37,

    [NativeName("XR_TYPE_ACTION_SPACE_CREATE_INFO")]
    ActionSpaceCreateInfo = 38,

    [NativeName("XR_TYPE_EVENT_DATA_REFERENCE_SPACE_CHANGE_PENDING")]
    EventDataReferenceSpaceChangePending = 40,

    [NativeName("XR_TYPE_VIEW_CONFIGURATION_VIEW")]
    ViewConfigurationView = 41,

    [NativeName("XR_TYPE_SPACE_LOCATION")]
    SpaceLocation = 42,

    [NativeName("XR_TYPE_SPACE_VELOCITY")]
    SpaceVelocity = 43,

    [NativeName("XR_TYPE_FRAME_STATE")]
    FrameState = 44,

    [NativeName("XR_TYPE_VIEW_CONFIGURATION_PROPERTIES")]
    ViewConfigurationProperties = 45,

    [NativeName("XR_TYPE_FRAME_BEGIN_INFO")]
    FrameBeginInfo = 46,

    [NativeName("XR_TYPE_COMPOSITION_LAYER_PROJECTION_VIEW")]
    CompositionLayerProjectionView = 48,

    [NativeName("XR_TYPE_EVENT_DATA_EVENTS_LOST")]
    EventDataEventsLost = 49,

    [NativeName("XR_TYPE_INTERACTION_PROFILE_SUGGESTED_BINDING")]
    InteractionProfileSuggestedBinding = 51,

    [NativeName("XR_TYPE_EVENT_DATA_INTERACTION_PROFILE_CHANGED")]
    EventDataInteractionProfileChanged = 52,

    [NativeName("XR_TYPE_INTERACTION_PROFILE_STATE")]
    InteractionProfileState = 53,

    [NativeName("XR_TYPE_SWAPCHAIN_IMAGE_ACQUIRE_INFO")]
    SwapchainImageAcquireInfo = 55,

    [NativeName("XR_TYPE_SWAPCHAIN_IMAGE_WAIT_INFO")]
    SwapchainImageWaitInfo = 56,

    [NativeName("XR_TYPE_SWAPCHAIN_IMAGE_RELEASE_INFO")]
    SwapchainImageReleaseInfo = 57,

    [NativeName("XR_TYPE_ACTION_STATE_GET_INFO")]
    ActionStateGetInfo = 58,

    [NativeName("XR_TYPE_HAPTIC_ACTION_INFO")]
    HapticActionInfo = 59,

    [NativeName("XR_TYPE_SESSION_ACTION_SETS_ATTACH_INFO")]
    SessionActionSetsAttachInfo = 60,

    [NativeName("XR_TYPE_ACTIONS_SYNC_INFO")]
    ActionsSyncInfo = 61,

    [NativeName("XR_TYPE_BOUND_SOURCES_FOR_ACTION_ENUMERATE_INFO")]
    BoundSourcesForActionEnumerateInfo = 62,

    [NativeName("XR_TYPE_INPUT_SOURCE_LOCALIZED_NAME_GET_INFO")]
    InputSourceLocalizedNameGetInfo = 63,

    [NativeName("XR_TYPE_SPACES_LOCATE_INFO")]
    SpacesLocateInfo = 1000471000,

    [NativeName("XR_TYPE_SPACE_LOCATIONS")]
    SpaceLocations = 1000471001,

    [NativeName("XR_TYPE_SPACE_VELOCITIES")]
    SpaceVelocities = 1000471002,

    [NativeName("XR_TYPE_COMPOSITION_LAYER_CUBE_KHR")]
    CompositionLayerCubeKHR = 1000006000,

    [NativeName("XR_TYPE_INSTANCE_CREATE_INFO_ANDROID_KHR")]
    InstanceCreateInfoAndroidKHR = 1000008000,

    [NativeName("XR_TYPE_COMPOSITION_LAYER_DEPTH_INFO_KHR")]
    CompositionLayerDepthInfoKHR = 1000010000,

    [NativeName("XR_TYPE_VULKAN_SWAPCHAIN_FORMAT_LIST_CREATE_INFO_KHR")]
    VulkanSwapchainFormatListCreateInfoKHR = 1000014000,

    [NativeName("XR_TYPE_EVENT_DATA_PERF_SETTINGS_EXT")]
    EventDataPerfSettingsEXT = 1000015000,

    [NativeName("XR_TYPE_COMPOSITION_LAYER_CYLINDER_KHR")]
    CompositionLayerCylinderKHR = 1000017000,

    [NativeName("XR_TYPE_COMPOSITION_LAYER_EQUIRECT_KHR")]
    CompositionLayerEquirectKHR = 1000018000,

    [NativeName("XR_TYPE_DEBUG_UTILS_OBJECT_NAME_INFO_EXT")]
    DebugUtilsObjectNameInfoEXT = 1000019000,

    [NativeName("XR_TYPE_DEBUG_UTILS_MESSENGER_CALLBACK_DATA_EXT")]
    DebugUtilsMessengerCallbackDataEXT = 1000019001,

    [NativeName("XR_TYPE_DEBUG_UTILS_MESSENGER_CREATE_INFO_EXT")]
    DebugUtilsMessengerCreateInfoEXT = 1000019002,

    [NativeName("XR_TYPE_DEBUG_UTILS_LABEL_EXT")]
    DebugUtilsLabelEXT = 1000019003,

    [NativeName("XR_TYPE_GRAPHICS_BINDING_OPENGL_WIN32_KHR")]
    GraphicsBindingOpenglWin32KHR = 1000023000,

    [NativeName("XR_TYPE_GRAPHICS_BINDING_OPENGL_XLIB_KHR")]
    GraphicsBindingOpenglXlibKHR = 1000023001,

    [NativeName("XR_TYPE_GRAPHICS_BINDING_OPENGL_XCB_KHR")]
    GraphicsBindingOpenglXcbKHR = 1000023002,

    [NativeName("XR_TYPE_GRAPHICS_BINDING_OPENGL_WAYLAND_KHR")]
    GraphicsBindingOpenglWaylandKHR = 1000023003,

    [NativeName("XR_TYPE_SWAPCHAIN_IMAGE_OPENGL_KHR")]
    SwapchainImageOpenglKHR = 1000023004,

    [NativeName("XR_TYPE_GRAPHICS_REQUIREMENTS_OPENGL_KHR")]
    GraphicsRequirementsOpenglKHR = 1000023005,

    [NativeName("XR_TYPE_GRAPHICS_BINDING_OPENGL_ES_ANDROID_KHR")]
    GraphicsBindingOpenglEsAndroidKHR = 1000024001,

    [NativeName("XR_TYPE_SWAPCHAIN_IMAGE_OPENGL_ES_KHR")]
    SwapchainImageOpenglEsKHR = 1000024002,

    [NativeName("XR_TYPE_GRAPHICS_REQUIREMENTS_OPENGL_ES_KHR")]
    GraphicsRequirementsOpenglEsKHR = 1000024003,

    [NativeName("XR_TYPE_GRAPHICS_BINDING_VULKAN_KHR")]
    GraphicsBindingVulkanKHR = 1000025000,

    [NativeName("XR_TYPE_SWAPCHAIN_IMAGE_VULKAN_KHR")]
    SwapchainImageVulkanKHR = 1000025001,

    [NativeName("XR_TYPE_GRAPHICS_REQUIREMENTS_VULKAN_KHR")]
    GraphicsRequirementsVulkanKHR = 1000025002,

    [NativeName("XR_TYPE_GRAPHICS_BINDING_D3D11_KHR")]
    GraphicsBindingD3D11KHR = 1000027000,

    [NativeName("XR_TYPE_SWAPCHAIN_IMAGE_D3D11_KHR")]
    SwapchainImageD3D11KHR = 1000027001,

    [NativeName("XR_TYPE_GRAPHICS_REQUIREMENTS_D3D11_KHR")]
    GraphicsRequirementsD3D11KHR = 1000027002,

    [NativeName("XR_TYPE_GRAPHICS_BINDING_D3D12_KHR")]
    GraphicsBindingD3D12KHR = 1000028000,

    [NativeName("XR_TYPE_SWAPCHAIN_IMAGE_D3D12_KHR")]
    SwapchainImageD3D12KHR = 1000028001,

    [NativeName("XR_TYPE_GRAPHICS_REQUIREMENTS_D3D12_KHR")]
    GraphicsRequirementsD3D12KHR = 1000028002,

    [NativeName("XR_TYPE_GRAPHICS_BINDING_METAL_KHR")]
    GraphicsBindingMetalKHR = 1000029000,

    [NativeName("XR_TYPE_SWAPCHAIN_IMAGE_METAL_KHR")]
    SwapchainImageMetalKHR = 1000029001,

    [NativeName("XR_TYPE_GRAPHICS_REQUIREMENTS_METAL_KHR")]
    GraphicsRequirementsMetalKHR = 1000029002,

    [NativeName("XR_TYPE_SYSTEM_EYE_GAZE_INTERACTION_PROPERTIES_EXT")]
    SystemEyeGazeInteractionPropertiesEXT = 1000030000,

    [NativeName("XR_TYPE_EYE_GAZE_SAMPLE_TIME_EXT")]
    EyeGazeSampleTimeEXT = 1000030001,

    [NativeName("XR_TYPE_VISIBILITY_MASK_KHR")]
    VisibilityMaskKHR = 1000031000,

    [NativeName("XR_TYPE_EVENT_DATA_VISIBILITY_MASK_CHANGED_KHR")]
    EventDataVisibilityMaskChangedKHR = 1000031001,

    [NativeName("XR_TYPE_SESSION_CREATE_INFO_OVERLAY_EXTX")]
    SessionCreateInfoOverlayEXTX = 1000033000,

    [NativeName("XR_TYPE_EVENT_DATA_MAIN_SESSION_VISIBILITY_CHANGED_EXTX")]
    EventDataMainSessionVisibilityChangedEXTX = 1000033003,

    [NativeName("XR_TYPE_COMPOSITION_LAYER_COLOR_SCALE_BIAS_KHR")]
    CompositionLayerColorScaleBiasKHR = 1000034000,

    [NativeName("XR_TYPE_SPATIAL_ANCHOR_CREATE_INFO_MSFT")]
    SpatialAnchorCreateInfoMSFT = 1000039000,

    [NativeName("XR_TYPE_SPATIAL_ANCHOR_SPACE_CREATE_INFO_MSFT")]
    SpatialAnchorSpaceCreateInfoMSFT = 1000039001,

    [NativeName("XR_TYPE_COMPOSITION_LAYER_IMAGE_LAYOUT_FB")]
    CompositionLayerImageLayoutFB = 1000040000,

    [NativeName("XR_TYPE_COMPOSITION_LAYER_ALPHA_BLEND_FB")]
    CompositionLayerAlphaBlendFB = 1000041001,

    [NativeName("XR_TYPE_VIEW_CONFIGURATION_DEPTH_RANGE_EXT")]
    ViewConfigurationDepthRangeEXT = 1000046000,

    [NativeName("XR_TYPE_GRAPHICS_BINDING_EGL_MNDX")]
    GraphicsBindingEglMNDX = 1000048004,

    [NativeName("XR_TYPE_SPATIAL_GRAPH_NODE_SPACE_CREATE_INFO_MSFT")]
    SpatialGraphNodeSpaceCreateInfoMSFT = 1000049000,

    [NativeName("XR_TYPE_SPATIAL_GRAPH_STATIC_NODE_BINDING_CREATE_INFO_MSFT")]
    SpatialGraphStaticNodeBindingCreateInfoMSFT = 1000049001,

    [NativeName("XR_TYPE_SPATIAL_GRAPH_NODE_BINDING_PROPERTIES_GET_INFO_MSFT")]
    SpatialGraphNodeBindingPropertiesGetInfoMSFT = 1000049002,

    [NativeName("XR_TYPE_SPATIAL_GRAPH_NODE_BINDING_PROPERTIES_MSFT")]
    SpatialGraphNodeBindingPropertiesMSFT = 1000049003,

    [NativeName("XR_TYPE_SYSTEM_HAND_TRACKING_PROPERTIES_EXT")]
    SystemHandTrackingPropertiesEXT = 1000051000,

    [NativeName("XR_TYPE_HAND_TRACKER_CREATE_INFO_EXT")]
    HandTrackerCreateInfoEXT = 1000051001,

    [NativeName("XR_TYPE_HAND_JOINTS_LOCATE_INFO_EXT")]
    HandJointsLocateInfoEXT = 1000051002,

    [NativeName("XR_TYPE_HAND_JOINT_LOCATIONS_EXT")]
    HandJointLocationsEXT = 1000051003,

    [NativeName("XR_TYPE_HAND_JOINT_VELOCITIES_EXT")]
    HandJointVelocitiesEXT = 1000051004,

    [NativeName("XR_TYPE_SYSTEM_HAND_TRACKING_MESH_PROPERTIES_MSFT")]
    SystemHandTrackingMeshPropertiesMSFT = 1000052000,

    [NativeName("XR_TYPE_HAND_MESH_SPACE_CREATE_INFO_MSFT")]
    HandMeshSpaceCreateInfoMSFT = 1000052001,

    [NativeName("XR_TYPE_HAND_MESH_UPDATE_INFO_MSFT")]
    HandMeshUpdateInfoMSFT = 1000052002,

    [NativeName("XR_TYPE_HAND_MESH_MSFT")]
    HandMeshMSFT = 1000052003,

    [NativeName("XR_TYPE_HAND_POSE_TYPE_INFO_MSFT")]
    HandPoseTypeInfoMSFT = 1000052004,

    [NativeName("XR_TYPE_SECONDARY_VIEW_CONFIGURATION_SESSION_BEGIN_INFO_MSFT")]
    SecondaryViewConfigurationSessionBeginInfoMSFT = 1000053000,

    [NativeName("XR_TYPE_SECONDARY_VIEW_CONFIGURATION_STATE_MSFT")]
    SecondaryViewConfigurationStateMSFT = 1000053001,

    [NativeName("XR_TYPE_SECONDARY_VIEW_CONFIGURATION_FRAME_STATE_MSFT")]
    SecondaryViewConfigurationFrameStateMSFT = 1000053002,

    [NativeName("XR_TYPE_SECONDARY_VIEW_CONFIGURATION_FRAME_END_INFO_MSFT")]
    SecondaryViewConfigurationFrameEndInfoMSFT = 1000053003,

    [NativeName("XR_TYPE_SECONDARY_VIEW_CONFIGURATION_LAYER_INFO_MSFT")]
    SecondaryViewConfigurationLayerInfoMSFT = 1000053004,

    [NativeName("XR_TYPE_SECONDARY_VIEW_CONFIGURATION_SWAPCHAIN_CREATE_INFO_MSFT")]
    SecondaryViewConfigurationSwapchainCreateInfoMSFT = 1000053005,

    [NativeName("XR_TYPE_CONTROLLER_MODEL_KEY_STATE_MSFT")]
    ControllerModelKeyStateMSFT = 1000055000,

    [NativeName("XR_TYPE_CONTROLLER_MODEL_NODE_PROPERTIES_MSFT")]
    ControllerModelNodePropertiesMSFT = 1000055001,

    [NativeName("XR_TYPE_CONTROLLER_MODEL_PROPERTIES_MSFT")]
    ControllerModelPropertiesMSFT = 1000055002,

    [NativeName("XR_TYPE_CONTROLLER_MODEL_NODE_STATE_MSFT")]
    ControllerModelNodeStateMSFT = 1000055003,

    [NativeName("XR_TYPE_CONTROLLER_MODEL_STATE_MSFT")]
    ControllerModelStateMSFT = 1000055004,

    [NativeName("XR_TYPE_VIEW_CONFIGURATION_VIEW_FOV_EPIC")]
    ViewConfigurationViewFovEPIC = 1000059000,

    [NativeName("XR_TYPE_HOLOGRAPHIC_WINDOW_ATTACHMENT_MSFT")]
    HolographicWindowAttachmentMSFT = 1000063000,

    [NativeName("XR_TYPE_COMPOSITION_LAYER_REPROJECTION_INFO_MSFT")]
    CompositionLayerReprojectionInfoMSFT = 1000066000,

    [NativeName("XR_TYPE_COMPOSITION_LAYER_REPROJECTION_PLANE_OVERRIDE_MSFT")]
    CompositionLayerReprojectionPlaneOverrideMSFT = 1000066001,

    [NativeName("XR_TYPE_ANDROID_SURFACE_SWAPCHAIN_CREATE_INFO_FB")]
    AndroidSurfaceSwapchainCreateInfoFB = 1000070000,

    [NativeName("XR_TYPE_COMPOSITION_LAYER_SECURE_CONTENT_FB")]
    CompositionLayerSecureContentFB = 1000072000,

    [NativeName("XR_TYPE_BODY_TRACKER_CREATE_INFO_FB")]
    BodyTrackerCreateInfoFB = 1000076001,

    [NativeName("XR_TYPE_BODY_JOINTS_LOCATE_INFO_FB")]
    BodyJointsLocateInfoFB = 1000076002,

    [NativeName("XR_TYPE_SYSTEM_BODY_TRACKING_PROPERTIES_FB")]
    SystemBodyTrackingPropertiesFB = 1000076004,

    [NativeName("XR_TYPE_BODY_JOINT_LOCATIONS_FB")]
    BodyJointLocationsFB = 1000076005,

    [NativeName("XR_TYPE_BODY_SKELETON_FB")]
    BodySkeletonFB = 1000076006,

    [NativeName("XR_TYPE_INTERACTION_PROFILE_DPAD_BINDING_EXT")]
    InteractionProfileDpadBindingEXT = 1000078000,

    [NativeName("XR_TYPE_INTERACTION_PROFILE_ANALOG_THRESHOLD_VALVE")]
    InteractionProfileAnalogThresholdVALVE = 1000079000,

    [NativeName("XR_TYPE_HAND_JOINTS_MOTION_RANGE_INFO_EXT")]
    HandJointsMotionRangeInfoEXT = 1000080000,

    [NativeName("XR_TYPE_LOADER_INIT_INFO_ANDROID_KHR")]
    LoaderInitInfoAndroidKHR = 1000089000,

    [NativeName("XR_TYPE_VULKAN_INSTANCE_CREATE_INFO_KHR")]
    VulkanInstanceCreateInfoKHR = 1000090000,

    [NativeName("XR_TYPE_VULKAN_DEVICE_CREATE_INFO_KHR")]
    VulkanDeviceCreateInfoKHR = 1000090001,

    [NativeName("XR_TYPE_VULKAN_GRAPHICS_DEVICE_GET_INFO_KHR")]
    VulkanGraphicsDeviceGetInfoKHR = 1000090003,

    [NativeName("XR_TYPE_COMPOSITION_LAYER_EQUIRECT2_KHR")]
    CompositionLayerEquirect2KHR = 1000091000,

    [NativeName("XR_TYPE_SCENE_OBSERVER_CREATE_INFO_MSFT")]
    SceneObserverCreateInfoMSFT = 1000097000,

    [NativeName("XR_TYPE_SCENE_CREATE_INFO_MSFT")]
    SceneCreateInfoMSFT = 1000097001,

    [NativeName("XR_TYPE_NEW_SCENE_COMPUTE_INFO_MSFT")]
    NewSceneComputeInfoMSFT = 1000097002,

    [NativeName("XR_TYPE_VISUAL_MESH_COMPUTE_LOD_INFO_MSFT")]
    VisualMeshComputeLodInfoMSFT = 1000097003,

    [NativeName("XR_TYPE_SCENE_COMPONENTS_MSFT")]
    SceneComponentsMSFT = 1000097004,

    [NativeName("XR_TYPE_SCENE_COMPONENTS_GET_INFO_MSFT")]
    SceneComponentsGetInfoMSFT = 1000097005,

    [NativeName("XR_TYPE_SCENE_COMPONENT_LOCATIONS_MSFT")]
    SceneComponentLocationsMSFT = 1000097006,

    [NativeName("XR_TYPE_SCENE_COMPONENTS_LOCATE_INFO_MSFT")]
    SceneComponentsLocateInfoMSFT = 1000097007,

    [NativeName("XR_TYPE_SCENE_OBJECTS_MSFT")]
    SceneObjectsMSFT = 1000097008,

    [NativeName("XR_TYPE_SCENE_COMPONENT_PARENT_FILTER_INFO_MSFT")]
    SceneComponentParentFilterInfoMSFT = 1000097009,

    [NativeName("XR_TYPE_SCENE_OBJECT_TYPES_FILTER_INFO_MSFT")]
    SceneObjectTypesFilterInfoMSFT = 1000097010,

    [NativeName("XR_TYPE_SCENE_PLANES_MSFT")]
    ScenePlanesMSFT = 1000097011,

    [NativeName("XR_TYPE_SCENE_PLANE_ALIGNMENT_FILTER_INFO_MSFT")]
    ScenePlaneAlignmentFilterInfoMSFT = 1000097012,

    [NativeName("XR_TYPE_SCENE_MESHES_MSFT")]
    SceneMeshesMSFT = 1000097013,

    [NativeName("XR_TYPE_SCENE_MESH_BUFFERS_GET_INFO_MSFT")]
    SceneMeshBuffersGetInfoMSFT = 1000097014,

    [NativeName("XR_TYPE_SCENE_MESH_BUFFERS_MSFT")]
    SceneMeshBuffersMSFT = 1000097015,

    [NativeName("XR_TYPE_SCENE_MESH_VERTEX_BUFFER_MSFT")]
    SceneMeshVertexBufferMSFT = 1000097016,

    [NativeName("XR_TYPE_SCENE_MESH_INDICES_UINT32_MSFT")]
    SceneMeshIndicesUint32MSFT = 1000097017,

    [NativeName("XR_TYPE_SCENE_MESH_INDICES_UINT16_MSFT")]
    SceneMeshIndicesUint16MSFT = 1000097018,

    [NativeName("XR_TYPE_SERIALIZED_SCENE_FRAGMENT_DATA_GET_INFO_MSFT")]
    SerializedSceneFragmentDataGetInfoMSFT = 1000098000,

    [NativeName("XR_TYPE_SCENE_DESERIALIZE_INFO_MSFT")]
    SceneDeserializeInfoMSFT = 1000098001,

    [NativeName("XR_TYPE_EVENT_DATA_DISPLAY_REFRESH_RATE_CHANGED_FB")]
    EventDataDisplayRefreshRateChangedFB = 1000101000,

    [NativeName("XR_TYPE_VIVE_TRACKER_PATHS_HTCX")]
    ViveTrackerPathsHTCX = 1000103000,

    [NativeName("XR_TYPE_EVENT_DATA_VIVE_TRACKER_CONNECTED_HTCX")]
    EventDataViveTrackerConnectedHTCX = 1000103001,

    [NativeName("XR_TYPE_SYSTEM_FACIAL_TRACKING_PROPERTIES_HTC")]
    SystemFacialTrackingPropertiesHTC = 1000104000,

    [NativeName("XR_TYPE_FACIAL_TRACKER_CREATE_INFO_HTC")]
    FacialTrackerCreateInfoHTC = 1000104001,

    [NativeName("XR_TYPE_FACIAL_EXPRESSIONS_HTC")]
    FacialExpressionsHTC = 1000104002,

    [NativeName("XR_TYPE_SYSTEM_COLOR_SPACE_PROPERTIES_FB")]
    SystemColorSpacePropertiesFB = 1000108000,

    [NativeName("XR_TYPE_HAND_TRACKING_MESH_FB")]
    HandTrackingMeshFB = 1000110001,

    [NativeName("XR_TYPE_HAND_TRACKING_SCALE_FB")]
    HandTrackingScaleFB = 1000110003,

    [NativeName("XR_TYPE_HAND_TRACKING_AIM_STATE_FB")]
    HandTrackingAimStateFB = 1000111001,

    [NativeName("XR_TYPE_HAND_TRACKING_CAPSULES_STATE_FB")]
    HandTrackingCapsulesStateFB = 1000112000,

    [NativeName("XR_TYPE_SYSTEM_SPATIAL_ENTITY_PROPERTIES_FB")]
    SystemSpatialEntityPropertiesFB = 1000113004,

    [NativeName("XR_TYPE_SPATIAL_ANCHOR_CREATE_INFO_FB")]
    SpatialAnchorCreateInfoFB = 1000113003,

    [NativeName("XR_TYPE_SPACE_COMPONENT_STATUS_SET_INFO_FB")]
    SpaceComponentStatusSetInfoFB = 1000113007,

    [NativeName("XR_TYPE_SPACE_COMPONENT_STATUS_FB")]
    SpaceComponentStatusFB = 1000113001,

    [NativeName("XR_TYPE_EVENT_DATA_SPATIAL_ANCHOR_CREATE_COMPLETE_FB")]
    EventDataSpatialAnchorCreateCompleteFB = 1000113005,

    [NativeName("XR_TYPE_EVENT_DATA_SPACE_SET_STATUS_COMPLETE_FB")]
    EventDataSpaceSetStatusCompleteFB = 1000113006,

    [NativeName("XR_TYPE_FOVEATION_PROFILE_CREATE_INFO_FB")]
    FoveationProfileCreateInfoFB = 1000114000,

    [NativeName("XR_TYPE_SWAPCHAIN_CREATE_INFO_FOVEATION_FB")]
    SwapchainCreateInfoFoveationFB = 1000114001,

    [NativeName("XR_TYPE_SWAPCHAIN_STATE_FOVEATION_FB")]
    SwapchainStateFoveationFB = 1000114002,

    [NativeName("XR_TYPE_FOVEATION_LEVEL_PROFILE_CREATE_INFO_FB")]
    FoveationLevelProfileCreateInfoFB = 1000115000,

    [NativeName("XR_TYPE_KEYBOARD_SPACE_CREATE_INFO_FB")]
    KeyboardSpaceCreateInfoFB = 1000116009,

    [NativeName("XR_TYPE_KEYBOARD_TRACKING_QUERY_FB")]
    KeyboardTrackingQueryFB = 1000116004,

    [NativeName("XR_TYPE_SYSTEM_KEYBOARD_TRACKING_PROPERTIES_FB")]
    SystemKeyboardTrackingPropertiesFB = 1000116002,

    [NativeName("XR_TYPE_TRIANGLE_MESH_CREATE_INFO_FB")]
    TriangleMeshCreateInfoFB = 1000117001,

    [NativeName("XR_TYPE_SYSTEM_PASSTHROUGH_PROPERTIES_FB")]
    SystemPassthroughPropertiesFB = 1000118000,

    [NativeName("XR_TYPE_PASSTHROUGH_CREATE_INFO_FB")]
    PassthroughCreateInfoFB = 1000118001,

    [NativeName("XR_TYPE_PASSTHROUGH_LAYER_CREATE_INFO_FB")]
    PassthroughLayerCreateInfoFB = 1000118002,

    [NativeName("XR_TYPE_COMPOSITION_LAYER_PASSTHROUGH_FB")]
    CompositionLayerPassthroughFB = 1000118003,

    [NativeName("XR_TYPE_GEOMETRY_INSTANCE_CREATE_INFO_FB")]
    GeometryInstanceCreateInfoFB = 1000118004,

    [NativeName("XR_TYPE_GEOMETRY_INSTANCE_TRANSFORM_FB")]
    GeometryInstanceTransformFB = 1000118005,

    [NativeName("XR_TYPE_SYSTEM_PASSTHROUGH_PROPERTIES2_FB")]
    SystemPassthroughProperties2FB = 1000118006,

    [NativeName("XR_TYPE_PASSTHROUGH_STYLE_FB")]
    PassthroughStyleFB = 1000118020,

    [NativeName("XR_TYPE_PASSTHROUGH_COLOR_MAP_MONO_TO_RGBA_FB")]
    PassthroughColorMapMonoToRgbaFB = 1000118021,

    [NativeName("XR_TYPE_PASSTHROUGH_COLOR_MAP_MONO_TO_MONO_FB")]
    PassthroughColorMapMonoToMonoFB = 1000118022,

    [NativeName("XR_TYPE_PASSTHROUGH_BRIGHTNESS_CONTRAST_SATURATION_FB")]
    PassthroughBrightnessContrastSaturationFB = 1000118023,

    [NativeName("XR_TYPE_EVENT_DATA_PASSTHROUGH_STATE_CHANGED_FB")]
    EventDataPassthroughStateChangedFB = 1000118030,

    [NativeName("XR_TYPE_RENDER_MODEL_PATH_INFO_FB")]
    RenderModelPathInfoFB = 1000119000,

    [NativeName("XR_TYPE_RENDER_MODEL_PROPERTIES_FB")]
    RenderModelPropertiesFB = 1000119001,

    [NativeName("XR_TYPE_RENDER_MODEL_BUFFER_FB")]
    RenderModelBufferFB = 1000119002,

    [NativeName("XR_TYPE_RENDER_MODEL_LOAD_INFO_FB")]
    RenderModelLoadInfoFB = 1000119003,

    [NativeName("XR_TYPE_SYSTEM_RENDER_MODEL_PROPERTIES_FB")]
    SystemRenderModelPropertiesFB = 1000119004,

    [NativeName("XR_TYPE_RENDER_MODEL_CAPABILITIES_REQUEST_FB")]
    RenderModelCapabilitiesRequestFB = 1000119005,

    [NativeName("XR_TYPE_BINDING_MODIFICATIONS_KHR")]
    BindingModificationsKHR = 1000120000,

    [NativeName("XR_TYPE_VIEW_LOCATE_FOVEATED_RENDERING_VARJO")]
    ViewLocateFoveatedRenderingVARJO = 1000121000,

    [NativeName("XR_TYPE_FOVEATED_VIEW_CONFIGURATION_VIEW_VARJO")]
    FoveatedViewConfigurationViewVARJO = 1000121001,

    [NativeName("XR_TYPE_SYSTEM_FOVEATED_RENDERING_PROPERTIES_VARJO")]
    SystemFoveatedRenderingPropertiesVARJO = 1000121002,

    [NativeName("XR_TYPE_COMPOSITION_LAYER_DEPTH_TEST_VARJO")]
    CompositionLayerDepthTestVARJO = 1000122000,

    [NativeName("XR_TYPE_SYSTEM_MARKER_TRACKING_PROPERTIES_VARJO")]
    SystemMarkerTrackingPropertiesVARJO = 1000124000,

    [NativeName("XR_TYPE_EVENT_DATA_MARKER_TRACKING_UPDATE_VARJO")]
    EventDataMarkerTrackingUpdateVARJO = 1000124001,

    [NativeName("XR_TYPE_MARKER_SPACE_CREATE_INFO_VARJO")]
    MarkerSpaceCreateInfoVARJO = 1000124002,

    [NativeName("XR_TYPE_FRAME_END_INFO_ML")]
    FrameEndInfoML = 1000135000,

    [NativeName("XR_TYPE_GLOBAL_DIMMER_FRAME_END_INFO_ML")]
    GlobalDimmerFrameEndInfoML = 1000136000,

    [NativeName("XR_TYPE_COORDINATE_SPACE_CREATE_INFO_ML")]
    CoordinateSpaceCreateInfoML = 1000137000,

    [NativeName("XR_TYPE_SYSTEM_MARKER_UNDERSTANDING_PROPERTIES_ML")]
    SystemMarkerUnderstandingPropertiesML = 1000138000,

    [NativeName("XR_TYPE_MARKER_DETECTOR_CREATE_INFO_ML")]
    MarkerDetectorCreateInfoML = 1000138001,

    [NativeName("XR_TYPE_MARKER_DETECTOR_ARUCO_INFO_ML")]
    MarkerDetectorArucoInfoML = 1000138002,

    [NativeName("XR_TYPE_MARKER_DETECTOR_SIZE_INFO_ML")]
    MarkerDetectorSizeInfoML = 1000138003,

    [NativeName("XR_TYPE_MARKER_DETECTOR_APRIL_TAG_INFO_ML")]
    MarkerDetectorAprilTagInfoML = 1000138004,

    [NativeName("XR_TYPE_MARKER_DETECTOR_CUSTOM_PROFILE_INFO_ML")]
    MarkerDetectorCustomProfileInfoML = 1000138005,

    [NativeName("XR_TYPE_MARKER_DETECTOR_SNAPSHOT_INFO_ML")]
    MarkerDetectorSnapshotInfoML = 1000138006,

    [NativeName("XR_TYPE_MARKER_DETECTOR_STATE_ML")]
    MarkerDetectorStateML = 1000138007,

    [NativeName("XR_TYPE_MARKER_SPACE_CREATE_INFO_ML")]
    MarkerSpaceCreateInfoML = 1000138008,

    [NativeName("XR_TYPE_LOCALIZATION_MAP_ML")]
    LocalizationMapML = 1000139000,

    [NativeName("XR_TYPE_EVENT_DATA_LOCALIZATION_CHANGED_ML")]
    EventDataLocalizationChangedML = 1000139001,

    [NativeName("XR_TYPE_MAP_LOCALIZATION_REQUEST_INFO_ML")]
    MapLocalizationRequestInfoML = 1000139002,

    [NativeName("XR_TYPE_LOCALIZATION_MAP_IMPORT_INFO_ML")]
    LocalizationMapImportInfoML = 1000139003,

    [NativeName("XR_TYPE_LOCALIZATION_ENABLE_EVENTS_INFO_ML")]
    LocalizationEnableEventsInfoML = 1000139004,

    [NativeName("XR_TYPE_SPATIAL_ANCHORS_CREATE_INFO_FROM_POSE_ML")]
    SpatialAnchorsCreateInfoFromPoseML = 1000140000,

    [NativeName("XR_TYPE_CREATE_SPATIAL_ANCHORS_COMPLETION_ML")]
    CreateSpatialAnchorsCompletionML = 1000140001,

    [NativeName("XR_TYPE_SPATIAL_ANCHOR_STATE_ML")]
    SpatialAnchorStateML = 1000140002,

    [NativeName("XR_TYPE_SPATIAL_ANCHORS_CREATE_STORAGE_INFO_ML")]
    SpatialAnchorsCreateStorageInfoML = 1000141000,

    [NativeName("XR_TYPE_SPATIAL_ANCHORS_QUERY_INFO_RADIUS_ML")]
    SpatialAnchorsQueryInfoRadiusML = 1000141001,

    [NativeName("XR_TYPE_SPATIAL_ANCHORS_QUERY_COMPLETION_ML")]
    SpatialAnchorsQueryCompletionML = 1000141002,

    [NativeName("XR_TYPE_SPATIAL_ANCHORS_CREATE_INFO_FROM_UUIDS_ML")]
    SpatialAnchorsCreateInfoFromUuidsML = 1000141003,

    [NativeName("XR_TYPE_SPATIAL_ANCHORS_PUBLISH_INFO_ML")]
    SpatialAnchorsPublishInfoML = 1000141004,

    [NativeName("XR_TYPE_SPATIAL_ANCHORS_PUBLISH_COMPLETION_ML")]
    SpatialAnchorsPublishCompletionML = 1000141005,

    [NativeName("XR_TYPE_SPATIAL_ANCHORS_DELETE_INFO_ML")]
    SpatialAnchorsDeleteInfoML = 1000141006,

    [NativeName("XR_TYPE_SPATIAL_ANCHORS_DELETE_COMPLETION_ML")]
    SpatialAnchorsDeleteCompletionML = 1000141007,

    [NativeName("XR_TYPE_SPATIAL_ANCHORS_UPDATE_EXPIRATION_INFO_ML")]
    SpatialAnchorsUpdateExpirationInfoML = 1000141008,

    [NativeName("XR_TYPE_SPATIAL_ANCHORS_UPDATE_EXPIRATION_COMPLETION_ML")]
    SpatialAnchorsUpdateExpirationCompletionML = 1000141009,

    [NativeName("XR_TYPE_SPATIAL_ANCHORS_PUBLISH_COMPLETION_DETAILS_ML")]
    SpatialAnchorsPublishCompletionDetailsML = 1000141010,

    [NativeName("XR_TYPE_SPATIAL_ANCHORS_DELETE_COMPLETION_DETAILS_ML")]
    SpatialAnchorsDeleteCompletionDetailsML = 1000141011,

    [NativeName("XR_TYPE_SPATIAL_ANCHORS_UPDATE_EXPIRATION_COMPLETION_DETAILS_ML")]
    SpatialAnchorsUpdateExpirationCompletionDetailsML = 1000141012,

    [NativeName("XR_TYPE_EVENT_DATA_HEADSET_FIT_CHANGED_ML")]
    EventDataHeadsetFitChangedML = 1000472000,

    [NativeName("XR_TYPE_EVENT_DATA_EYE_CALIBRATION_CHANGED_ML")]
    EventDataEyeCalibrationChangedML = 1000472001,

    [NativeName("XR_TYPE_USER_CALIBRATION_ENABLE_EVENTS_INFO_ML")]
    UserCalibrationEnableEventsInfoML = 1000472002,

    [NativeName("XR_TYPE_SPATIAL_ANCHOR_PERSISTENCE_INFO_MSFT")]
    SpatialAnchorPersistenceInfoMSFT = 1000142000,

    [NativeName("XR_TYPE_SPATIAL_ANCHOR_FROM_PERSISTED_ANCHOR_CREATE_INFO_MSFT")]
    SpatialAnchorFromPersistedAnchorCreateInfoMSFT = 1000142001,

    [NativeName("XR_TYPE_SCENE_MARKERS_MSFT")]
    SceneMarkersMSFT = 1000147000,

    [NativeName("XR_TYPE_SCENE_MARKER_TYPE_FILTER_MSFT")]
    SceneMarkerTypeFilterMSFT = 1000147001,

    [NativeName("XR_TYPE_SCENE_MARKER_QR_CODES_MSFT")]
    SceneMarkerQrCodesMSFT = 1000147002,

    [NativeName("XR_TYPE_SPACE_QUERY_INFO_FB")]
    SpaceQueryInfoFB = 1000156001,

    [NativeName("XR_TYPE_SPACE_QUERY_RESULTS_FB")]
    SpaceQueryResultsFB = 1000156002,

    [NativeName("XR_TYPE_SPACE_STORAGE_LOCATION_FILTER_INFO_FB")]
    SpaceStorageLocationFilterInfoFB = 1000156003,

    [NativeName("XR_TYPE_SPACE_UUID_FILTER_INFO_FB")]
    SpaceUuidFilterInfoFB = 1000156054,

    [NativeName("XR_TYPE_SPACE_COMPONENT_FILTER_INFO_FB")]
    SpaceComponentFilterInfoFB = 1000156052,

    [NativeName("XR_TYPE_EVENT_DATA_SPACE_QUERY_RESULTS_AVAILABLE_FB")]
    EventDataSpaceQueryResultsAvailableFB = 1000156103,

    [NativeName("XR_TYPE_EVENT_DATA_SPACE_QUERY_COMPLETE_FB")]
    EventDataSpaceQueryCompleteFB = 1000156104,

    [NativeName("XR_TYPE_SPACE_SAVE_INFO_FB")]
    SpaceSaveInfoFB = 1000158000,

    [NativeName("XR_TYPE_SPACE_ERASE_INFO_FB")]
    SpaceEraseInfoFB = 1000158001,

    [NativeName("XR_TYPE_EVENT_DATA_SPACE_SAVE_COMPLETE_FB")]
    EventDataSpaceSaveCompleteFB = 1000158106,

    [NativeName("XR_TYPE_EVENT_DATA_SPACE_ERASE_COMPLETE_FB")]
    EventDataSpaceEraseCompleteFB = 1000158107,

    [NativeName("XR_TYPE_SWAPCHAIN_IMAGE_FOVEATION_VULKAN_FB")]
    SwapchainImageFoveationVulkanFB = 1000160000,

    [NativeName("XR_TYPE_SWAPCHAIN_STATE_ANDROID_SURFACE_DIMENSIONS_FB")]
    SwapchainStateAndroidSurfaceDimensionsFB = 1000161000,

    [NativeName("XR_TYPE_SWAPCHAIN_STATE_SAMPLER_OPENGL_ES_FB")]
    SwapchainStateSamplerOpenglEsFB = 1000162000,

    [NativeName("XR_TYPE_SWAPCHAIN_STATE_SAMPLER_VULKAN_FB")]
    SwapchainStateSamplerVulkanFB = 1000163000,

    [NativeName("XR_TYPE_SPACE_SHARE_INFO_FB")]
    SpaceShareInfoFB = 1000169001,

    [NativeName("XR_TYPE_EVENT_DATA_SPACE_SHARE_COMPLETE_FB")]
    EventDataSpaceShareCompleteFB = 1000169002,

    [NativeName("XR_TYPE_COMPOSITION_LAYER_SPACE_WARP_INFO_FB")]
    CompositionLayerSpaceWarpInfoFB = 1000171000,

    [NativeName("XR_TYPE_SYSTEM_SPACE_WARP_PROPERTIES_FB")]
    SystemSpaceWarpPropertiesFB = 1000171001,

    [NativeName("XR_TYPE_HAPTIC_AMPLITUDE_ENVELOPE_VIBRATION_FB")]
    HapticAmplitudeEnvelopeVibrationFB = 1000173001,

    [NativeName("XR_TYPE_SEMANTIC_LABELS_FB")]
    SemanticLabelsFB = 1000175000,

    [NativeName("XR_TYPE_ROOM_LAYOUT_FB")]
    RoomLayoutFB = 1000175001,

    [NativeName("XR_TYPE_BOUNDARY_2D_FB")]
    Boundary2DFB = 1000175002,

    [NativeName("XR_TYPE_SEMANTIC_LABELS_SUPPORT_INFO_FB")]
    SemanticLabelsSupportInfoFB = 1000175010,

    [NativeName("XR_TYPE_DIGITAL_LENS_CONTROL_ALMALENCE")]
    DigitalLensControlALMALENCE = 1000196000,

    [NativeName("XR_TYPE_EVENT_DATA_SCENE_CAPTURE_COMPLETE_FB")]
    EventDataSceneCaptureCompleteFB = 1000198001,

    [NativeName("XR_TYPE_SCENE_CAPTURE_REQUEST_INFO_FB")]
    SceneCaptureRequestInfoFB = 1000198050,

    [NativeName("XR_TYPE_SPACE_CONTAINER_FB")]
    SpaceContainerFB = 1000199000,

    [NativeName("XR_TYPE_FOVEATION_EYE_TRACKED_PROFILE_CREATE_INFO_META")]
    FoveationEyeTrackedProfileCreateInfoMETA = 1000200000,

    [NativeName("XR_TYPE_FOVEATION_EYE_TRACKED_STATE_META")]
    FoveationEyeTrackedStateMETA = 1000200001,

    [NativeName("XR_TYPE_SYSTEM_FOVEATION_EYE_TRACKED_PROPERTIES_META")]
    SystemFoveationEyeTrackedPropertiesMETA = 1000200002,

    [NativeName("XR_TYPE_SYSTEM_FACE_TRACKING_PROPERTIES_FB")]
    SystemFaceTrackingPropertiesFB = 1000201004,

    [NativeName("XR_TYPE_FACE_TRACKER_CREATE_INFO_FB")]
    FaceTrackerCreateInfoFB = 1000201005,

    [NativeName("XR_TYPE_FACE_EXPRESSION_INFO_FB")]
    FaceExpressionInfoFB = 1000201002,

    [NativeName("XR_TYPE_FACE_EXPRESSION_WEIGHTS_FB")]
    FaceExpressionWeightsFB = 1000201006,

    [NativeName("XR_TYPE_EYE_TRACKER_CREATE_INFO_FB")]
    EyeTrackerCreateInfoFB = 1000202001,

    [NativeName("XR_TYPE_EYE_GAZES_INFO_FB")]
    EyeGazesInfoFB = 1000202002,

    [NativeName("XR_TYPE_EYE_GAZES_FB")]
    EyeGazesFB = 1000202003,

    [NativeName("XR_TYPE_SYSTEM_EYE_TRACKING_PROPERTIES_FB")]
    SystemEyeTrackingPropertiesFB = 1000202004,

    [NativeName("XR_TYPE_PASSTHROUGH_KEYBOARD_HANDS_INTENSITY_FB")]
    PassthroughKeyboardHandsIntensityFB = 1000203002,

    [NativeName("XR_TYPE_COMPOSITION_LAYER_SETTINGS_FB")]
    CompositionLayerSettingsFB = 1000204000,

    [NativeName("XR_TYPE_HAPTIC_PCM_VIBRATION_FB")]
    HapticPcmVibrationFB = 1000209001,

    [NativeName("XR_TYPE_DEVICE_PCM_SAMPLE_RATE_STATE_FB")]
    DevicePcmSampleRateStateFB = 1000209002,

    [NativeName("XR_TYPE_FRAME_SYNTHESIS_INFO_EXT")]
    FrameSynthesisInfoEXT = 1000211000,

    [NativeName("XR_TYPE_FRAME_SYNTHESIS_CONFIG_VIEW_EXT")]
    FrameSynthesisConfigViewEXT = 1000211001,

    [NativeName("XR_TYPE_COMPOSITION_LAYER_DEPTH_TEST_FB")]
    CompositionLayerDepthTestFB = 1000212000,

    [NativeName("XR_TYPE_LOCAL_DIMMING_FRAME_END_INFO_META")]
    LocalDimmingFrameEndInfoMETA = 1000216000,

    [NativeName("XR_TYPE_PASSTHROUGH_PREFERENCES_META")]
    PassthroughPreferencesMETA = 1000217000,

    [NativeName("XR_TYPE_SYSTEM_VIRTUAL_KEYBOARD_PROPERTIES_META")]
    SystemVirtualKeyboardPropertiesMETA = 1000219001,

    [NativeName("XR_TYPE_VIRTUAL_KEYBOARD_CREATE_INFO_META")]
    VirtualKeyboardCreateInfoMETA = 1000219002,

    [NativeName("XR_TYPE_VIRTUAL_KEYBOARD_SPACE_CREATE_INFO_META")]
    VirtualKeyboardSpaceCreateInfoMETA = 1000219003,

    [NativeName("XR_TYPE_VIRTUAL_KEYBOARD_LOCATION_INFO_META")]
    VirtualKeyboardLocationInfoMETA = 1000219004,

    [NativeName("XR_TYPE_VIRTUAL_KEYBOARD_MODEL_VISIBILITY_SET_INFO_META")]
    VirtualKeyboardModelVisibilitySetInfoMETA = 1000219005,

    [NativeName("XR_TYPE_VIRTUAL_KEYBOARD_ANIMATION_STATE_META")]
    VirtualKeyboardAnimationStateMETA = 1000219006,

    [NativeName("XR_TYPE_VIRTUAL_KEYBOARD_MODEL_ANIMATION_STATES_META")]
    VirtualKeyboardModelAnimationStatesMETA = 1000219007,

    [NativeName("XR_TYPE_VIRTUAL_KEYBOARD_TEXTURE_DATA_META")]
    VirtualKeyboardTextureDataMETA = 1000219009,

    [NativeName("XR_TYPE_VIRTUAL_KEYBOARD_INPUT_INFO_META")]
    VirtualKeyboardInputInfoMETA = 1000219010,

    [NativeName("XR_TYPE_VIRTUAL_KEYBOARD_TEXT_CONTEXT_CHANGE_INFO_META")]
    VirtualKeyboardTextContextChangeInfoMETA = 1000219011,

    [NativeName("XR_TYPE_EVENT_DATA_VIRTUAL_KEYBOARD_COMMIT_TEXT_META")]
    EventDataVirtualKeyboardCommitTextMETA = 1000219014,

    [NativeName("XR_TYPE_EVENT_DATA_VIRTUAL_KEYBOARD_BACKSPACE_META")]
    EventDataVirtualKeyboardBackspaceMETA = 1000219015,

    [NativeName("XR_TYPE_EVENT_DATA_VIRTUAL_KEYBOARD_ENTER_META")]
    EventDataVirtualKeyboardEnterMETA = 1000219016,

    [NativeName("XR_TYPE_EVENT_DATA_VIRTUAL_KEYBOARD_SHOWN_META")]
    EventDataVirtualKeyboardShownMETA = 1000219017,

    [NativeName("XR_TYPE_EVENT_DATA_VIRTUAL_KEYBOARD_HIDDEN_META")]
    EventDataVirtualKeyboardHiddenMETA = 1000219018,

    [NativeName("XR_TYPE_EXTERNAL_CAMERA_OCULUS")]
    ExternalCameraOCULUS = 1000226000,

    [NativeName("XR_TYPE_VULKAN_SWAPCHAIN_CREATE_INFO_META")]
    VulkanSwapchainCreateInfoMETA = 1000227000,

    [NativeName("XR_TYPE_PERFORMANCE_METRICS_STATE_META")]
    PerformanceMetricsStateMETA = 1000232001,

    [NativeName("XR_TYPE_PERFORMANCE_METRICS_COUNTER_META")]
    PerformanceMetricsCounterMETA = 1000232002,

    [NativeName("XR_TYPE_SPACE_LIST_SAVE_INFO_FB")]
    SpaceListSaveInfoFB = 1000238000,

    [NativeName("XR_TYPE_EVENT_DATA_SPACE_LIST_SAVE_COMPLETE_FB")]
    EventDataSpaceListSaveCompleteFB = 1000238001,

    [NativeName("XR_TYPE_SPACE_USER_CREATE_INFO_FB")]
    SpaceUserCreateInfoFB = 1000241001,

    [NativeName("XR_TYPE_SYSTEM_HEADSET_ID_PROPERTIES_META")]
    SystemHeadsetIdPropertiesMETA = 1000245000,

    [NativeName("XR_TYPE_SYSTEM_SPACE_DISCOVERY_PROPERTIES_META")]
    SystemSpaceDiscoveryPropertiesMETA = 1000247000,

    [NativeName("XR_TYPE_SPACE_DISCOVERY_INFO_META")]
    SpaceDiscoveryInfoMETA = 1000247001,

    [NativeName("XR_TYPE_SPACE_FILTER_UUID_META")]
    SpaceFilterUuidMETA = 1000247003,

    [NativeName("XR_TYPE_SPACE_FILTER_COMPONENT_META")]
    SpaceFilterComponentMETA = 1000247004,

    [NativeName("XR_TYPE_SPACE_DISCOVERY_RESULT_META")]
    SpaceDiscoveryResultMETA = 1000247005,

    [NativeName("XR_TYPE_SPACE_DISCOVERY_RESULTS_META")]
    SpaceDiscoveryResultsMETA = 1000247006,

    [NativeName("XR_TYPE_EVENT_DATA_SPACE_DISCOVERY_RESULTS_AVAILABLE_META")]
    EventDataSpaceDiscoveryResultsAvailableMETA = 1000247007,

    [NativeName("XR_TYPE_EVENT_DATA_SPACE_DISCOVERY_COMPLETE_META")]
    EventDataSpaceDiscoveryCompleteMETA = 1000247008,

    [NativeName("XR_TYPE_RECOMMENDED_LAYER_RESOLUTION_META")]
    RecommendedLayerResolutionMETA = 1000254000,

    [NativeName("XR_TYPE_RECOMMENDED_LAYER_RESOLUTION_GET_INFO_META")]
    RecommendedLayerResolutionGetInfoMETA = 1000254001,

    [NativeName("XR_TYPE_SYSTEM_SPACE_PERSISTENCE_PROPERTIES_META")]
    SystemSpacePersistencePropertiesMETA = 1000259000,

    [NativeName("XR_TYPE_SPACES_SAVE_INFO_META")]
    SpacesSaveInfoMETA = 1000259001,

    [NativeName("XR_TYPE_EVENT_DATA_SPACES_SAVE_RESULT_META")]
    EventDataSpacesSaveResultMETA = 1000259002,

    [NativeName("XR_TYPE_SPACES_ERASE_INFO_META")]
    SpacesEraseInfoMETA = 1000259003,

    [NativeName("XR_TYPE_EVENT_DATA_SPACES_ERASE_RESULT_META")]
    EventDataSpacesEraseResultMETA = 1000259004,

    [NativeName("XR_TYPE_SYSTEM_PASSTHROUGH_COLOR_LUT_PROPERTIES_META")]
    SystemPassthroughColorLutPropertiesMETA = 1000266000,

    [NativeName("XR_TYPE_PASSTHROUGH_COLOR_LUT_CREATE_INFO_META")]
    PassthroughColorLutCreateInfoMETA = 1000266001,

    [NativeName("XR_TYPE_PASSTHROUGH_COLOR_LUT_UPDATE_INFO_META")]
    PassthroughColorLutUpdateInfoMETA = 1000266002,

    [NativeName("XR_TYPE_PASSTHROUGH_COLOR_MAP_LUT_META")]
    PassthroughColorMapLutMETA = 1000266100,

    [NativeName("XR_TYPE_PASSTHROUGH_COLOR_MAP_INTERPOLATED_LUT_META")]
    PassthroughColorMapInterpolatedLutMETA = 1000266101,

    [NativeName("XR_TYPE_SPACE_TRIANGLE_MESH_GET_INFO_META")]
    SpaceTriangleMeshGetInfoMETA = 1000269001,

    [NativeName("XR_TYPE_SPACE_TRIANGLE_MESH_META")]
    SpaceTriangleMeshMETA = 1000269002,

    [NativeName("XR_TYPE_SYSTEM_PROPERTIES_BODY_TRACKING_FULL_BODY_META")]
    SystemPropertiesBodyTrackingFullBodyMETA = 1000274000,

    [NativeName("XR_TYPE_EVENT_DATA_PASSTHROUGH_LAYER_RESUMED_META")]
    EventDataPassthroughLayerResumedMETA = 1000282000,

    [NativeName("XR_TYPE_BODY_TRACKING_CALIBRATION_INFO_META")]
    BodyTrackingCalibrationInfoMETA = 1000283002,

    [NativeName("XR_TYPE_BODY_TRACKING_CALIBRATION_STATUS_META")]
    BodyTrackingCalibrationStatusMETA = 1000283003,

    [NativeName("XR_TYPE_SYSTEM_PROPERTIES_BODY_TRACKING_CALIBRATION_META")]
    SystemPropertiesBodyTrackingCalibrationMETA = 1000283004,

    [NativeName("XR_TYPE_BODY_TRACKING_FIDELITY_STATUS_META")]
    BodyTrackingFidelityStatusMETA = 1000284000,

    [NativeName("XR_TYPE_SYSTEM_PROPERTIES_BODY_TRACKING_FIDELITY_META")]
    SystemPropertiesBodyTrackingFidelityMETA = 1000284001,

    [NativeName("XR_TYPE_SYSTEM_FACE_TRACKING_PROPERTIES2_FB")]
    SystemFaceTrackingProperties2FB = 1000287013,

    [NativeName("XR_TYPE_FACE_TRACKER_CREATE_INFO2_FB")]
    FaceTrackerCreateInfo2FB = 1000287014,

    [NativeName("XR_TYPE_FACE_EXPRESSION_INFO2_FB")]
    FaceExpressionInfo2FB = 1000287015,

    [NativeName("XR_TYPE_FACE_EXPRESSION_WEIGHTS2_FB")]
    FaceExpressionWeights2FB = 1000287016,

    [NativeName("XR_TYPE_SYSTEM_SPATIAL_ENTITY_SHARING_PROPERTIES_META")]
    SystemSpatialEntitySharingPropertiesMETA = 1000290000,

    [NativeName("XR_TYPE_SHARE_SPACES_INFO_META")]
    ShareSpacesInfoMETA = 1000290001,

    [NativeName("XR_TYPE_EVENT_DATA_SHARE_SPACES_COMPLETE_META")]
    EventDataShareSpacesCompleteMETA = 1000290002,

    [NativeName("XR_TYPE_ENVIRONMENT_DEPTH_PROVIDER_CREATE_INFO_META")]
    EnvironmentDepthProviderCreateInfoMETA = 1000291000,

    [NativeName("XR_TYPE_ENVIRONMENT_DEPTH_SWAPCHAIN_CREATE_INFO_META")]
    EnvironmentDepthSwapchainCreateInfoMETA = 1000291001,

    [NativeName("XR_TYPE_ENVIRONMENT_DEPTH_SWAPCHAIN_STATE_META")]
    EnvironmentDepthSwapchainStateMETA = 1000291002,

    [NativeName("XR_TYPE_ENVIRONMENT_DEPTH_IMAGE_ACQUIRE_INFO_META")]
    EnvironmentDepthImageAcquireInfoMETA = 1000291003,

    [NativeName("XR_TYPE_ENVIRONMENT_DEPTH_IMAGE_VIEW_META")]
    EnvironmentDepthImageViewMETA = 1000291004,

    [NativeName("XR_TYPE_ENVIRONMENT_DEPTH_IMAGE_META")]
    EnvironmentDepthImageMETA = 1000291005,

    [NativeName("XR_TYPE_ENVIRONMENT_DEPTH_HAND_REMOVAL_SET_INFO_META")]
    EnvironmentDepthHandRemovalSetInfoMETA = 1000291006,

    [NativeName("XR_TYPE_SYSTEM_ENVIRONMENT_DEPTH_PROPERTIES_META")]
    SystemEnvironmentDepthPropertiesMETA = 1000291007,

    [NativeName("XR_TYPE_ENVIRONMENT_DEPTH_IMAGE_TIMESTAMP_META")]
    EnvironmentDepthImageTimestampMETA = 1000291008,

    [NativeName("XR_TYPE_RENDER_MODEL_CREATE_INFO_EXT")]
    RenderModelCreateInfoEXT = 1000300000,

    [NativeName("XR_TYPE_RENDER_MODEL_PROPERTIES_GET_INFO_EXT")]
    RenderModelPropertiesGetInfoEXT = 1000300001,

    [NativeName("XR_TYPE_RENDER_MODEL_PROPERTIES_EXT")]
    RenderModelPropertiesEXT = 1000300002,

    [NativeName("XR_TYPE_RENDER_MODEL_SPACE_CREATE_INFO_EXT")]
    RenderModelSpaceCreateInfoEXT = 1000300003,

    [NativeName("XR_TYPE_RENDER_MODEL_STATE_GET_INFO_EXT")]
    RenderModelStateGetInfoEXT = 1000300004,

    [NativeName("XR_TYPE_RENDER_MODEL_STATE_EXT")]
    RenderModelStateEXT = 1000300005,

    [NativeName("XR_TYPE_RENDER_MODEL_ASSET_CREATE_INFO_EXT")]
    RenderModelAssetCreateInfoEXT = 1000300006,

    [NativeName("XR_TYPE_RENDER_MODEL_ASSET_DATA_GET_INFO_EXT")]
    RenderModelAssetDataGetInfoEXT = 1000300007,

    [NativeName("XR_TYPE_RENDER_MODEL_ASSET_DATA_EXT")]
    RenderModelAssetDataEXT = 1000300008,

    [NativeName("XR_TYPE_RENDER_MODEL_ASSET_PROPERTIES_GET_INFO_EXT")]
    RenderModelAssetPropertiesGetInfoEXT = 1000300009,

    [NativeName("XR_TYPE_RENDER_MODEL_ASSET_PROPERTIES_EXT")]
    RenderModelAssetPropertiesEXT = 1000300010,

    [NativeName("XR_TYPE_INTERACTION_RENDER_MODEL_IDS_ENUMERATE_INFO_EXT")]
    InteractionRenderModelIdsEnumerateInfoEXT = 1000301000,

    [NativeName("XR_TYPE_INTERACTION_RENDER_MODEL_SUBACTION_PATH_INFO_EXT")]
    InteractionRenderModelSubactionPathInfoEXT = 1000301001,

    [NativeName("XR_TYPE_EVENT_DATA_INTERACTION_RENDER_MODELS_CHANGED_EXT")]
    EventDataInteractionRenderModelsChangedEXT = 1000301002,

    [NativeName("XR_TYPE_INTERACTION_RENDER_MODEL_TOP_LEVEL_USER_PATH_GET_INFO_EXT")]
    InteractionRenderModelTopLevelUserPathGetInfoEXT = 1000301003,

    [NativeName("XR_TYPE_PASSTHROUGH_CREATE_INFO_HTC")]
    PassthroughCreateInfoHTC = 1000317001,

    [NativeName("XR_TYPE_PASSTHROUGH_COLOR_HTC")]
    PassthroughColorHTC = 1000317002,

    [NativeName("XR_TYPE_PASSTHROUGH_MESH_TRANSFORM_INFO_HTC")]
    PassthroughMeshTransformInfoHTC = 1000317003,

    [NativeName("XR_TYPE_COMPOSITION_LAYER_PASSTHROUGH_HTC")]
    CompositionLayerPassthroughHTC = 1000317004,

    [NativeName("XR_TYPE_FOVEATION_APPLY_INFO_HTC")]
    FoveationApplyInfoHTC = 1000318000,

    [NativeName("XR_TYPE_FOVEATION_DYNAMIC_MODE_INFO_HTC")]
    FoveationDynamicModeInfoHTC = 1000318001,

    [NativeName("XR_TYPE_FOVEATION_CUSTOM_MODE_INFO_HTC")]
    FoveationCustomModeInfoHTC = 1000318002,

    [NativeName("XR_TYPE_SYSTEM_ANCHOR_PROPERTIES_HTC")]
    SystemAnchorPropertiesHTC = 1000319000,

    [NativeName("XR_TYPE_SPATIAL_ANCHOR_CREATE_INFO_HTC")]
    SpatialAnchorCreateInfoHTC = 1000319001,

    [NativeName("XR_TYPE_SYSTEM_BODY_TRACKING_PROPERTIES_HTC")]
    SystemBodyTrackingPropertiesHTC = 1000320000,

    [NativeName("XR_TYPE_BODY_TRACKER_CREATE_INFO_HTC")]
    BodyTrackerCreateInfoHTC = 1000320001,

    [NativeName("XR_TYPE_BODY_JOINTS_LOCATE_INFO_HTC")]
    BodyJointsLocateInfoHTC = 1000320002,

    [NativeName("XR_TYPE_BODY_JOINT_LOCATIONS_HTC")]
    BodyJointLocationsHTC = 1000320003,

    [NativeName("XR_TYPE_BODY_SKELETON_HTC")]
    BodySkeletonHTC = 1000320004,

    [NativeName("XR_TYPE_ACTIVE_ACTION_SET_PRIORITIES_EXT")]
    ActiveActionSetPrioritiesEXT = 1000373000,

    [NativeName("XR_TYPE_SYSTEM_FORCE_FEEDBACK_CURL_PROPERTIES_MNDX")]
    SystemForceFeedbackCurlPropertiesMNDX = 1000375000,

    [NativeName("XR_TYPE_FORCE_FEEDBACK_CURL_APPLY_LOCATIONS_MNDX")]
    ForceFeedbackCurlApplyLocationsMNDX = 1000375001,

    [NativeName("XR_TYPE_BODY_TRACKER_CREATE_INFO_BD")]
    BodyTrackerCreateInfoBD = 1000385001,

    [NativeName("XR_TYPE_BODY_JOINTS_LOCATE_INFO_BD")]
    BodyJointsLocateInfoBD = 1000385002,

    [NativeName("XR_TYPE_BODY_JOINT_LOCATIONS_BD")]
    BodyJointLocationsBD = 1000385003,

    [NativeName("XR_TYPE_SYSTEM_BODY_TRACKING_PROPERTIES_BD")]
    SystemBodyTrackingPropertiesBD = 1000385004,

    [NativeName("XR_TYPE_SYSTEM_FACIAL_SIMULATION_PROPERTIES_BD")]
    SystemFacialSimulationPropertiesBD = 1000386001,

    [NativeName("XR_TYPE_FACE_TRACKER_CREATE_INFO_BD")]
    FaceTrackerCreateInfoBD = 1000386002,

    [NativeName("XR_TYPE_FACIAL_SIMULATION_DATA_GET_INFO_BD")]
    FacialSimulationDataGetInfoBD = 1000386003,

    [NativeName("XR_TYPE_FACIAL_SIMULATION_DATA_BD")]
    FacialSimulationDataBD = 1000386004,

    [NativeName("XR_TYPE_LIP_EXPRESSION_DATA_BD")]
    LipExpressionDataBD = 1000386005,

    [NativeName("XR_TYPE_SYSTEM_SPATIAL_SENSING_PROPERTIES_BD")]
    SystemSpatialSensingPropertiesBD = 1000389000,

    [NativeName("XR_TYPE_SPATIAL_ENTITY_COMPONENT_GET_INFO_BD")]
    SpatialEntityComponentGetInfoBD = 1000389001,

    [NativeName("XR_TYPE_SPATIAL_ENTITY_LOCATION_GET_INFO_BD")]
    SpatialEntityLocationGetInfoBD = 1000389002,

    [NativeName("XR_TYPE_SPATIAL_ENTITY_COMPONENT_DATA_LOCATION_BD")]
    SpatialEntityComponentDataLocationBD = 1000389003,

    [NativeName("XR_TYPE_SPATIAL_ENTITY_COMPONENT_DATA_SEMANTIC_BD")]
    SpatialEntityComponentDataSemanticBD = 1000389004,

    [NativeName("XR_TYPE_SPATIAL_ENTITY_COMPONENT_DATA_BOUNDING_BOX_2D_BD")]
    SpatialEntityComponentDataBoundingBox2DBD = 1000389005,

    [NativeName("XR_TYPE_SPATIAL_ENTITY_COMPONENT_DATA_POLYGON_BD")]
    SpatialEntityComponentDataPolygonBD = 1000389006,

    [NativeName("XR_TYPE_SPATIAL_ENTITY_COMPONENT_DATA_BOUNDING_BOX_3D_BD")]
    SpatialEntityComponentDataBoundingBox3DBD = 1000389007,

    [NativeName("XR_TYPE_SPATIAL_ENTITY_COMPONENT_DATA_TRIANGLE_MESH_BD")]
    SpatialEntityComponentDataTriangleMeshBD = 1000389008,

    [NativeName("XR_TYPE_SENSE_DATA_PROVIDER_CREATE_INFO_BD")]
    SenseDataProviderCreateInfoBD = 1000389009,

    [NativeName("XR_TYPE_SENSE_DATA_PROVIDER_START_INFO_BD")]
    SenseDataProviderStartInfoBD = 1000389010,

    [NativeName("XR_TYPE_EVENT_DATA_SENSE_DATA_PROVIDER_STATE_CHANGED_BD")]
    EventDataSenseDataProviderStateChangedBD = 1000389011,

    [NativeName("XR_TYPE_EVENT_DATA_SENSE_DATA_UPDATED_BD")]
    EventDataSenseDataUpdatedBD = 1000389012,

    [NativeName("XR_TYPE_SENSE_DATA_QUERY_INFO_BD")]
    SenseDataQueryInfoBD = 1000389013,

    [NativeName("XR_TYPE_SENSE_DATA_QUERY_COMPLETION_BD")]
    SenseDataQueryCompletionBD = 1000389014,

    [NativeName("XR_TYPE_SENSE_DATA_FILTER_UUID_BD")]
    SenseDataFilterUuidBD = 1000389015,

    [NativeName("XR_TYPE_SENSE_DATA_FILTER_SEMANTIC_BD")]
    SenseDataFilterSemanticBD = 1000389016,

    [NativeName("XR_TYPE_QUERIED_SENSE_DATA_GET_INFO_BD")]
    QueriedSenseDataGetInfoBD = 1000389017,

    [NativeName("XR_TYPE_QUERIED_SENSE_DATA_BD")]
    QueriedSenseDataBD = 1000389018,

    [NativeName("XR_TYPE_SPATIAL_ENTITY_STATE_BD")]
    SpatialEntityStateBD = 1000389019,

    [NativeName("XR_TYPE_SPATIAL_ENTITY_ANCHOR_CREATE_INFO_BD")]
    SpatialEntityAnchorCreateInfoBD = 1000389020,

    [NativeName("XR_TYPE_ANCHOR_SPACE_CREATE_INFO_BD")]
    AnchorSpaceCreateInfoBD = 1000389021,

    [NativeName("XR_TYPE_SYSTEM_SPATIAL_ANCHOR_PROPERTIES_BD")]
    SystemSpatialAnchorPropertiesBD = 1000390000,

    [NativeName("XR_TYPE_SPATIAL_ANCHOR_CREATE_INFO_BD")]
    SpatialAnchorCreateInfoBD = 1000390001,

    [NativeName("XR_TYPE_SPATIAL_ANCHOR_CREATE_COMPLETION_BD")]
    SpatialAnchorCreateCompletionBD = 1000390002,

    [NativeName("XR_TYPE_SPATIAL_ANCHOR_PERSIST_INFO_BD")]
    SpatialAnchorPersistInfoBD = 1000390003,

    [NativeName("XR_TYPE_SPATIAL_ANCHOR_UNPERSIST_INFO_BD")]
    SpatialAnchorUnpersistInfoBD = 1000390004,

    [NativeName("XR_TYPE_SYSTEM_SPATIAL_ANCHOR_SHARING_PROPERTIES_BD")]
    SystemSpatialAnchorSharingPropertiesBD = 1000391000,

    [NativeName("XR_TYPE_SPATIAL_ANCHOR_SHARE_INFO_BD")]
    SpatialAnchorShareInfoBD = 1000391001,

    [NativeName("XR_TYPE_SHARED_SPATIAL_ANCHOR_DOWNLOAD_INFO_BD")]
    SharedSpatialAnchorDownloadInfoBD = 1000391002,

    [NativeName("XR_TYPE_SYSTEM_SPATIAL_SCENE_PROPERTIES_BD")]
    SystemSpatialScenePropertiesBD = 1000392000,

    [NativeName("XR_TYPE_SCENE_CAPTURE_INFO_BD")]
    SceneCaptureInfoBD = 1000392001,

    [NativeName("XR_TYPE_SYSTEM_SPATIAL_MESH_PROPERTIES_BD")]
    SystemSpatialMeshPropertiesBD = 1000393000,

    [NativeName("XR_TYPE_SENSE_DATA_PROVIDER_CREATE_INFO_SPATIAL_MESH_BD")]
    SenseDataProviderCreateInfoSpatialMeshBD = 1000393001,

    [NativeName("XR_TYPE_FUTURE_POLL_RESULT_PROGRESS_BD")]
    FuturePollResultProgressBD = 1000394001,

    [NativeName("XR_TYPE_SYSTEM_SPATIAL_PLANE_PROPERTIES_BD")]
    SystemSpatialPlanePropertiesBD = 1000396000,

    [NativeName("XR_TYPE_SPATIAL_ENTITY_COMPONENT_DATA_PLANE_ORIENTATION_BD")]
    SpatialEntityComponentDataPlaneOrientationBD = 1000396001,

    [NativeName("XR_TYPE_SENSE_DATA_FILTER_PLANE_ORIENTATION_BD")]
    SenseDataFilterPlaneOrientationBD = 1000396002,

    [NativeName("XR_TYPE_SPATIAL_AUDIO_RENDERER_CREATE_INFO_BD")]
    SpatialAudioRendererCreateInfoBD = 1000409000,

    [NativeName("XR_TYPE_AUDIO_BUFFER_BD")]
    AudioBufferBD = 1000409001,

    [NativeName("XR_TYPE_SOUND_OBJECT_DIRECTIVITY_CARDIOID_BD")]
    SoundObjectDirectivityCardioidBD = 1000409003,

    [NativeName("XR_TYPE_SOUND_OBJECT_SHAPE_SPHERE_BD")]
    SoundObjectShapeSphereBD = 1000409004,

    [NativeName("XR_TYPE_SOUND_OBJECT_DISTANCE_ATTENUATION_BD")]
    SoundObjectDistanceAttenuationBD = 1000409005,

    [NativeName("XR_TYPE_SOUND_OBJECT_DISTANCE_ATTENUATION_CURVE_BD")]
    SoundObjectDistanceAttenuationCurveBD = 1000409006,

    [NativeName("XR_TYPE_SOUND_OBJECT_CONFIG_BD")]
    SoundObjectConfigBD = 1000409007,

    [NativeName("XR_TYPE_SOUND_FIELD_CONFIG_BD")]
    SoundFieldConfigBD = 1000409008,

    [NativeName("XR_TYPE_SOUND_FIELD_CHANNEL_DEFINITION_SURROUND_BD")]
    SoundFieldChannelDefinitionSurroundBD = 1000409009,

    [NativeName("XR_TYPE_SOUND_FIELD_CHANNEL_DEFINITION_AMBIX_BD")]
    SoundFieldChannelDefinitionAmbixBD = 1000409010,

    [NativeName("XR_TYPE_SOUND_FIELD_CHANNEL_DEFINITION_FUMA_BD")]
    SoundFieldChannelDefinitionFumaBD = 1000409011,

    [NativeName("XR_TYPE_SOUND_TRIANGLE_MESH_BD")]
    SoundTriangleMeshBD = 1000409012,

    [NativeName("XR_TYPE_SOUND_OBSTACLE_CONFIG_BD")]
    SoundObstacleConfigBD = 1000409013,

    [NativeName("XR_TYPE_SOUND_OBSTACLE_MATERIAL_CONFIG_BD")]
    SoundObstacleMaterialConfigBD = 1000409014,

    [NativeName("XR_TYPE_HAND_TRACKING_DATA_SOURCE_INFO_EXT")]
    HandTrackingDataSourceInfoEXT = 1000428000,

    [NativeName("XR_TYPE_HAND_TRACKING_DATA_SOURCE_STATE_EXT")]
    HandTrackingDataSourceStateEXT = 1000428001,

    [NativeName("XR_TYPE_PLANE_DETECTOR_CREATE_INFO_EXT")]
    PlaneDetectorCreateInfoEXT = 1000429001,

    [NativeName("XR_TYPE_PLANE_DETECTOR_BEGIN_INFO_EXT")]
    PlaneDetectorBeginInfoEXT = 1000429002,

    [NativeName("XR_TYPE_PLANE_DETECTOR_GET_INFO_EXT")]
    PlaneDetectorGetInfoEXT = 1000429003,

    [NativeName("XR_TYPE_PLANE_DETECTOR_LOCATIONS_EXT")]
    PlaneDetectorLocationsEXT = 1000429004,

    [NativeName("XR_TYPE_PLANE_DETECTOR_LOCATION_EXT")]
    PlaneDetectorLocationEXT = 1000429005,

    [NativeName("XR_TYPE_PLANE_DETECTOR_POLYGON_BUFFER_EXT")]
    PlaneDetectorPolygonBufferEXT = 1000429006,

    [NativeName("XR_TYPE_SYSTEM_PLANE_DETECTION_PROPERTIES_EXT")]
    SystemPlaneDetectionPropertiesEXT = 1000429007,

    [NativeName("XR_TYPE_TRACKABLE_GET_INFO_ANDROID")]
    TrackableGetInfoANDROID = 1000455000,

    [NativeName("XR_TYPE_ANCHOR_SPACE_CREATE_INFO_ANDROID")]
    AnchorSpaceCreateInfoANDROID = 1000455001,

    [NativeName("XR_TYPE_TRACKABLE_PLANE_ANDROID")]
    TrackablePlaneANDROID = 1000455003,

    [NativeName("XR_TYPE_TRACKABLE_TRACKER_CREATE_INFO_ANDROID")]
    TrackableTrackerCreateInfoANDROID = 1000455004,

    [NativeName("XR_TYPE_SYSTEM_TRACKABLES_PROPERTIES_ANDROID")]
    SystemTrackablesPropertiesANDROID = 1000455005,

    [NativeName("XR_TYPE_EYES_ANDROID")]
    EyesANDROID = 1000456000,

    [NativeName("XR_TYPE_EYE_TRACKER_CREATE_INFO_ANDROID")]
    EyeTrackerCreateInfoANDROID = 1000456001,

    [NativeName("XR_TYPE_EYES_GET_INFO_ANDROID")]
    EyesGetInfoANDROID = 1000456002,

    [NativeName("XR_TYPE_SYSTEM_EYE_TRACKING_PROPERTIES_ANDROID")]
    SystemEyeTrackingPropertiesANDROID = 1000456004,

    [NativeName("XR_TYPE_PERSISTED_ANCHOR_SPACE_CREATE_INFO_ANDROID")]
    PersistedAnchorSpaceCreateInfoANDROID = 1000457001,

    [NativeName("XR_TYPE_PERSISTED_ANCHOR_SPACE_INFO_ANDROID")]
    PersistedAnchorSpaceInfoANDROID = 1000457002,

    [NativeName("XR_TYPE_DEVICE_ANCHOR_PERSISTENCE_CREATE_INFO_ANDROID")]
    DeviceAnchorPersistenceCreateInfoANDROID = 1000457003,

    [NativeName("XR_TYPE_SYSTEM_DEVICE_ANCHOR_PERSISTENCE_PROPERTIES_ANDROID")]
    SystemDeviceAnchorPersistencePropertiesANDROID = 1000457004,

    [NativeName("XR_TYPE_FACE_TRACKER_CREATE_INFO_ANDROID")]
    FaceTrackerCreateInfoANDROID = 1000458000,

    [NativeName("XR_TYPE_FACE_STATE_GET_INFO_ANDROID")]
    FaceStateGetInfoANDROID = 1000458001,

    [NativeName("XR_TYPE_FACE_STATE_ANDROID")]
    FaceStateANDROID = 1000458002,

    [NativeName("XR_TYPE_SYSTEM_FACE_TRACKING_PROPERTIES_ANDROID")]
    SystemFaceTrackingPropertiesANDROID = 1000458003,

    [NativeName("XR_TYPE_PASSTHROUGH_CAMERA_STATE_GET_INFO_ANDROID")]
    PassthroughCameraStateGetInfoANDROID = 1000460000,

    [NativeName("XR_TYPE_SYSTEM_PASSTHROUGH_CAMERA_STATE_PROPERTIES_ANDROID")]
    SystemPassthroughCameraStatePropertiesANDROID = 1000460001,

    [NativeName("XR_TYPE_EVENT_DATA_RECOMMENDED_RESOLUTION_CHANGED_ANDROID")]
    EventDataRecommendedResolutionChangedANDROID = 1000461000,

    [NativeName("XR_TYPE_PASSTHROUGH_LAYER_CREATE_INFO_ANDROID")]
    PassthroughLayerCreateInfoANDROID = 1000462000,

    [NativeName("XR_TYPE_PASSTHROUGH_LAYER_MESH_ANDROID")]
    PassthroughLayerMeshANDROID = 1000462001,

    [NativeName("XR_TYPE_COMPOSITION_LAYER_PASSTHROUGH_ANDROID")]
    CompositionLayerPassthroughANDROID = 1000462002,

    [NativeName("XR_TYPE_SYSTEM_PASSTHROUGH_LAYER_PROPERTIES_ANDROID")]
    SystemPassthroughLayerPropertiesANDROID = 1000462003,

    [NativeName("XR_TYPE_RAYCAST_INFO_ANDROID")]
    RaycastInfoANDROID = 1000463000,

    [NativeName("XR_TYPE_RAYCAST_HIT_RESULTS_ANDROID")]
    RaycastHitResultsANDROID = 1000463001,

    [NativeName("XR_TYPE_PERFORMANCE_METRICS_STATE_ANDROID")]
    PerformanceMetricsStateANDROID = 1000465000,

    [NativeName("XR_TYPE_PERFORMANCE_METRICS_COUNTER_ANDROID")]
    PerformanceMetricsCounterANDROID = 1000465001,

    [NativeName("XR_TYPE_TRACKABLE_OBJECT_ANDROID")]
    TrackableObjectANDROID = 1000466000,

    [NativeName("XR_TYPE_TRACKABLE_OBJECT_CONFIGURATION_ANDROID")]
    TrackableObjectConfigurationANDROID = 1000466001,

    [NativeName("XR_TYPE_FUTURE_CANCEL_INFO_EXT")]
    FutureCancelInfoEXT = 1000469000,

    [NativeName("XR_TYPE_FUTURE_POLL_INFO_EXT")]
    FuturePollInfoEXT = 1000469001,

    [NativeName("XR_TYPE_FUTURE_COMPLETION_EXT")]
    FutureCompletionEXT = 1000469002,

    [NativeName("XR_TYPE_FUTURE_POLL_RESULT_EXT")]
    FuturePollResultEXT = 1000469003,

    [NativeName("XR_TYPE_EVENT_DATA_USER_PRESENCE_CHANGED_EXT")]
    EventDataUserPresenceChangedEXT = 1000470000,

    [NativeName("XR_TYPE_SYSTEM_USER_PRESENCE_PROPERTIES_EXT")]
    SystemUserPresencePropertiesEXT = 1000470001,

    [NativeName("XR_TYPE_SYSTEM_NOTIFICATIONS_SET_INFO_ML")]
    SystemNotificationsSetInfoML = 1000473000,

    [NativeName("XR_TYPE_WORLD_MESH_DETECTOR_CREATE_INFO_ML")]
    WorldMeshDetectorCreateInfoML = 1000474001,

    [NativeName("XR_TYPE_WORLD_MESH_STATE_REQUEST_INFO_ML")]
    WorldMeshStateRequestInfoML = 1000474002,

    [NativeName("XR_TYPE_WORLD_MESH_BLOCK_STATE_ML")]
    WorldMeshBlockStateML = 1000474003,

    [NativeName("XR_TYPE_WORLD_MESH_STATE_REQUEST_COMPLETION_ML")]
    WorldMeshStateRequestCompletionML = 1000474004,

    [NativeName("XR_TYPE_WORLD_MESH_BUFFER_RECOMMENDED_SIZE_INFO_ML")]
    WorldMeshBufferRecommendedSizeInfoML = 1000474005,

    [NativeName("XR_TYPE_WORLD_MESH_BUFFER_SIZE_ML")]
    WorldMeshBufferSizeML = 1000474006,

    [NativeName("XR_TYPE_WORLD_MESH_BUFFER_ML")]
    WorldMeshBufferML = 1000474007,

    [NativeName("XR_TYPE_WORLD_MESH_BLOCK_REQUEST_ML")]
    WorldMeshBlockRequestML = 1000474008,

    [NativeName("XR_TYPE_WORLD_MESH_GET_INFO_ML")]
    WorldMeshGetInfoML = 1000474009,

    [NativeName("XR_TYPE_WORLD_MESH_BLOCK_ML")]
    WorldMeshBlockML = 1000474010,

    [NativeName("XR_TYPE_WORLD_MESH_REQUEST_COMPLETION_ML")]
    WorldMeshRequestCompletionML = 1000474011,

    [NativeName("XR_TYPE_WORLD_MESH_REQUEST_COMPLETION_INFO_ML")]
    WorldMeshRequestCompletionInfoML = 1000474012,

    [NativeName("XR_TYPE_SYSTEM_FACIAL_EXPRESSION_PROPERTIES_ML")]
    SystemFacialExpressionPropertiesML = 1000482004,

    [NativeName("XR_TYPE_FACIAL_EXPRESSION_CLIENT_CREATE_INFO_ML")]
    FacialExpressionClientCreateInfoML = 1000482005,

    [NativeName("XR_TYPE_FACIAL_EXPRESSION_BLEND_SHAPE_GET_INFO_ML")]
    FacialExpressionBlendShapeGetInfoML = 1000482006,

    [NativeName("XR_TYPE_FACIAL_EXPRESSION_BLEND_SHAPE_PROPERTIES_ML")]
    FacialExpressionBlendShapePropertiesML = 1000482007,

    [NativeName("XR_TYPE_SYSTEM_BOUNDARY_VISIBILITY_PROPERTIES_META")]
    SystemBoundaryVisibilityPropertiesMETA = 1000528000,

    [NativeName("XR_TYPE_EVENT_DATA_BOUNDARY_VISIBILITY_CHANGED_META")]
    EventDataBoundaryVisibilityChangedMETA = 1000528001,

    [NativeName("XR_TYPE_SYSTEM_SIMULTANEOUS_HANDS_AND_CONTROLLERS_PROPERTIES_META")]
    SystemSimultaneousHandsAndControllersPropertiesMETA = 1000532001,

    [NativeName("XR_TYPE_SIMULTANEOUS_HANDS_AND_CONTROLLERS_TRACKING_RESUME_INFO_META")]
    SimultaneousHandsAndControllersTrackingResumeInfoMETA = 1000532002,

    [NativeName("XR_TYPE_SIMULTANEOUS_HANDS_AND_CONTROLLERS_TRACKING_PAUSE_INFO_META")]
    SimultaneousHandsAndControllersTrackingPauseInfoMETA = 1000532003,

    [NativeName("XR_TYPE_FACE_TRACKING_VISEMES_META")]
    FaceTrackingVisemesMETA = 1000541000,

    [NativeName("XR_TYPE_SYSTEM_FACE_TRACKING_VISEMES_PROPERTIES_META")]
    SystemFaceTrackingVisemesPropertiesMETA = 1000541001,

    [NativeName("XR_TYPE_ROOM_MESH_FACE_INDICES_META")]
    RoomMeshFaceIndicesMETA = 1000553000,

    [NativeName("XR_TYPE_SPACE_ROOM_MESH_GET_INFO_META")]
    SpaceRoomMeshGetInfoMETA = 1000553001,

    [NativeName("XR_TYPE_ROOM_MESH_META")]
    RoomMeshMETA = 1000553002,

    [NativeName("XR_TYPE_COLOCATION_DISCOVERY_START_INFO_META")]
    ColocationDiscoveryStartInfoMETA = 1000571010,

    [NativeName("XR_TYPE_COLOCATION_DISCOVERY_STOP_INFO_META")]
    ColocationDiscoveryStopInfoMETA = 1000571011,

    [NativeName("XR_TYPE_COLOCATION_ADVERTISEMENT_START_INFO_META")]
    ColocationAdvertisementStartInfoMETA = 1000571012,

    [NativeName("XR_TYPE_COLOCATION_ADVERTISEMENT_STOP_INFO_META")]
    ColocationAdvertisementStopInfoMETA = 1000571013,

    [NativeName("XR_TYPE_EVENT_DATA_START_COLOCATION_ADVERTISEMENT_COMPLETE_META")]
    EventDataStartColocationAdvertisementCompleteMETA = 1000571020,

    [NativeName("XR_TYPE_EVENT_DATA_STOP_COLOCATION_ADVERTISEMENT_COMPLETE_META")]
    EventDataStopColocationAdvertisementCompleteMETA = 1000571021,

    [NativeName("XR_TYPE_EVENT_DATA_COLOCATION_ADVERTISEMENT_COMPLETE_META")]
    EventDataColocationAdvertisementCompleteMETA = 1000571022,

    [NativeName("XR_TYPE_EVENT_DATA_START_COLOCATION_DISCOVERY_COMPLETE_META")]
    EventDataStartColocationDiscoveryCompleteMETA = 1000571023,

    [NativeName("XR_TYPE_EVENT_DATA_COLOCATION_DISCOVERY_RESULT_META")]
    EventDataColocationDiscoveryResultMETA = 1000571024,

    [NativeName("XR_TYPE_EVENT_DATA_COLOCATION_DISCOVERY_COMPLETE_META")]
    EventDataColocationDiscoveryCompleteMETA = 1000571025,

    [NativeName("XR_TYPE_EVENT_DATA_STOP_COLOCATION_DISCOVERY_COMPLETE_META")]
    EventDataStopColocationDiscoveryCompleteMETA = 1000571026,

    [NativeName("XR_TYPE_SYSTEM_COLOCATION_DISCOVERY_PROPERTIES_META")]
    SystemColocationDiscoveryPropertiesMETA = 1000571030,

    [NativeName("XR_TYPE_SHARE_SPACES_RECIPIENT_GROUPS_META")]
    ShareSpacesRecipientGroupsMETA = 1000572000,

    [NativeName("XR_TYPE_SPACE_GROUP_UUID_FILTER_INFO_META")]
    SpaceGroupUuidFilterInfoMETA = 1000572001,

    [NativeName("XR_TYPE_SYSTEM_SPATIAL_ENTITY_GROUP_SHARING_PROPERTIES_META")]
    SystemSpatialEntityGroupSharingPropertiesMETA = 1000572100,

    [NativeName("XR_TYPE_SYSTEM_ENVIRONMENT_RAYCAST_PROPERTIES_META")]
    SystemEnvironmentRaycastPropertiesMETA = 1000592000,

    [NativeName("XR_TYPE_ENVIRONMENT_RAYCASTER_CREATE_INFO_META")]
    EnvironmentRaycasterCreateInfoMETA = 1000592001,

    [NativeName("XR_TYPE_ENVIRONMENT_RAYCASTER_CREATE_COMPLETION_META")]
    EnvironmentRaycasterCreateCompletionMETA = 1000592002,

    [NativeName("XR_TYPE_ENVIRONMENT_RAYCAST_HIT_GET_INFO_META")]
    EnvironmentRaycastHitGetInfoMETA = 1000592003,

    [NativeName("XR_TYPE_ENVIRONMENT_RAYCAST_HIT_META")]
    EnvironmentRaycastHitMETA = 1000592004,

    [NativeName("XR_TYPE_ENVIRONMENT_RAYCAST_FILTER_DISTANCE_META")]
    EnvironmentRaycastFilterDistanceMETA = 1000592005,

    [NativeName("XR_TYPE_TILE_PROPERTIES_META")]
    TilePropertiesMETA = 1000609000,

    [NativeName("XR_TYPE_TILE_PROPERTIES_HINT_META")]
    TilePropertiesHintMETA = 1000609001,

    [NativeName("XR_TYPE_LIGHT_ESTIMATOR_CREATE_INFO_ANDROID")]
    LightEstimatorCreateInfoANDROID = 1000700000,

    [NativeName("XR_TYPE_LIGHT_ESTIMATE_GET_INFO_ANDROID")]
    LightEstimateGetInfoANDROID = 1000700001,

    [NativeName("XR_TYPE_LIGHT_ESTIMATE_ANDROID")]
    LightEstimateANDROID = 1000700002,

    [NativeName("XR_TYPE_DIRECTIONAL_LIGHT_ANDROID")]
    DirectionalLightANDROID = 1000700003,

    [NativeName("XR_TYPE_SPHERICAL_HARMONICS_ANDROID")]
    SphericalHarmonicsANDROID = 1000700004,

    [NativeName("XR_TYPE_AMBIENT_LIGHT_ANDROID")]
    AmbientLightANDROID = 1000700005,

    [NativeName("XR_TYPE_SYSTEM_LIGHT_ESTIMATION_PROPERTIES_ANDROID")]
    SystemLightEstimationPropertiesANDROID = 1000700006,

    [NativeName("XR_TYPE_ANCHOR_SHARING_INFO_ANDROID")]
    AnchorSharingInfoANDROID = 1000701000,

    [NativeName("XR_TYPE_ANCHOR_SHARING_TOKEN_ANDROID")]
    AnchorSharingTokenANDROID = 1000701001,

    [NativeName("XR_TYPE_SYSTEM_ANCHOR_SHARING_EXPORT_PROPERTIES_ANDROID")]
    SystemAnchorSharingExportPropertiesANDROID = 1000701002,

    [NativeName("XR_TYPE_SYSTEM_MARKER_TRACKING_PROPERTIES_ANDROID")]
    SystemMarkerTrackingPropertiesANDROID = 1000707000,

    [NativeName("XR_TYPE_TRACKABLE_MARKER_CONFIGURATION_ANDROID")]
    TrackableMarkerConfigurationANDROID = 1000707001,

    [NativeName("XR_TYPE_TRACKABLE_MARKER_ANDROID")]
    TrackableMarkerANDROID = 1000707002,

    [NativeName("XR_TYPE_SYSTEM_QR_CODE_TRACKING_PROPERTIES_ANDROID")]
    SystemQrCodeTrackingPropertiesANDROID = 1000708000,

    [NativeName("XR_TYPE_TRACKABLE_QR_CODE_CONFIGURATION_ANDROID")]
    TrackableQrCodeConfigurationANDROID = 1000708001,

    [NativeName("XR_TYPE_TRACKABLE_QR_CODE_ANDROID")]
    TrackableQrCodeANDROID = 1000708002,

    [NativeName("XR_TYPE_SYSTEM_IMAGE_TRACKING_PROPERTIES_ANDROID")]
    SystemImageTrackingPropertiesANDROID = 1000709000,

    [NativeName("XR_TYPE_TRACKABLE_IMAGE_DATABASE_ENTRY_ANDROID")]
    TrackableImageDatabaseEntryANDROID = 1000709001,

    [NativeName("XR_TYPE_TRACKABLE_IMAGE_DATABASE_CREATE_INFO_ANDROID")]
    TrackableImageDatabaseCreateInfoANDROID = 1000709002,

    [NativeName("XR_TYPE_CREATE_TRACKABLE_IMAGE_DATABASE_COMPLETION_ANDROID")]
    CreateTrackableImageDatabaseCompletionANDROID = 1000709003,

    [NativeName("XR_TYPE_TRACKABLE_IMAGE_CONFIGURATION_ANDROID")]
    TrackableImageConfigurationANDROID = 1000709004,

    [NativeName("XR_TYPE_TRACKABLE_IMAGE_ANDROID")]
    TrackableImageANDROID = 1000709005,

    [NativeName("XR_TYPE_EVENT_DATA_IMAGE_TRACKING_LOST_ANDROID")]
    EventDataImageTrackingLostANDROID = 1000709006,

    [NativeName("XR_TYPE_SYSTEM_SCENE_MESHING_PROPERTIES_ANDROID")]
    SystemSceneMeshingPropertiesANDROID = 1000718000,

    [NativeName("XR_TYPE_SCENE_MESHING_TRACKER_CREATE_INFO_ANDROID")]
    SceneMeshingTrackerCreateInfoANDROID = 1000718001,

    [NativeName("XR_TYPE_SCENE_MESH_SNAPSHOT_CREATE_INFO_ANDROID")]
    SceneMeshSnapshotCreateInfoANDROID = 1000718002,

    [NativeName("XR_TYPE_SCENE_MESH_SNAPSHOT_CREATION_RESULT_ANDROID")]
    SceneMeshSnapshotCreationResultANDROID = 1000718003,

    [NativeName("XR_TYPE_SCENE_SUBMESH_STATE_ANDROID")]
    SceneSubmeshStateANDROID = 1000718004,

    [NativeName("XR_TYPE_SCENE_SUBMESH_DATA_ANDROID")]
    SceneSubmeshDataANDROID = 1000718005,

    [NativeName("XR_TYPE_SPATIAL_CAPABILITY_COMPONENT_TYPES_EXT")]
    SpatialCapabilityComponentTypesEXT = 1000740000,

    [NativeName("XR_TYPE_SPATIAL_CONTEXT_CREATE_INFO_EXT")]
    SpatialContextCreateInfoEXT = 1000740001,

    [NativeName("XR_TYPE_CREATE_SPATIAL_CONTEXT_COMPLETION_EXT")]
    CreateSpatialContextCompletionEXT = 1000740002,

    [NativeName("XR_TYPE_SPATIAL_DISCOVERY_SNAPSHOT_CREATE_INFO_EXT")]
    SpatialDiscoverySnapshotCreateInfoEXT = 1000740003,

    [NativeName("XR_TYPE_CREATE_SPATIAL_DISCOVERY_SNAPSHOT_COMPLETION_INFO_EXT")]
    CreateSpatialDiscoverySnapshotCompletionInfoEXT = 1000740004,

    [NativeName("XR_TYPE_CREATE_SPATIAL_DISCOVERY_SNAPSHOT_COMPLETION_EXT")]
    CreateSpatialDiscoverySnapshotCompletionEXT = 1000740005,

    [NativeName("XR_TYPE_SPATIAL_COMPONENT_DATA_QUERY_CONDITION_EXT")]
    SpatialComponentDataQueryConditionEXT = 1000740006,

    [NativeName("XR_TYPE_SPATIAL_COMPONENT_DATA_QUERY_RESULT_EXT")]
    SpatialComponentDataQueryResultEXT = 1000740007,

    [NativeName("XR_TYPE_SPATIAL_BUFFER_GET_INFO_EXT")]
    SpatialBufferGetInfoEXT = 1000740008,

    [NativeName("XR_TYPE_SPATIAL_COMPONENT_BOUNDED_2D_LIST_EXT")]
    SpatialComponentBounded2DListEXT = 1000740009,

    [NativeName("XR_TYPE_SPATIAL_COMPONENT_BOUNDED_3D_LIST_EXT")]
    SpatialComponentBounded3DListEXT = 1000740010,

    [NativeName("XR_TYPE_SPATIAL_COMPONENT_PARENT_LIST_EXT")]
    SpatialComponentParentListEXT = 1000740011,

    [NativeName("XR_TYPE_SPATIAL_COMPONENT_MESH_3D_LIST_EXT")]
    SpatialComponentMesh3DListEXT = 1000740012,

    [NativeName("XR_TYPE_SPATIAL_ENTITY_FROM_ID_CREATE_INFO_EXT")]
    SpatialEntityFromIdCreateInfoEXT = 1000740013,

    [NativeName("XR_TYPE_SPATIAL_UPDATE_SNAPSHOT_CREATE_INFO_EXT")]
    SpatialUpdateSnapshotCreateInfoEXT = 1000740014,

    [NativeName("XR_TYPE_EVENT_DATA_SPATIAL_DISCOVERY_RECOMMENDED_EXT")]
    EventDataSpatialDiscoveryRecommendedEXT = 1000740015,

    [NativeName("XR_TYPE_SPATIAL_FILTER_TRACKING_STATE_EXT")]
    SpatialFilterTrackingStateEXT = 1000740016,

    [NativeName("XR_TYPE_SPATIAL_CAPABILITY_CONFIGURATION_PLANE_TRACKING_EXT")]
    SpatialCapabilityConfigurationPlaneTrackingEXT = 1000741000,

    [NativeName("XR_TYPE_SPATIAL_COMPONENT_PLANE_ALIGNMENT_LIST_EXT")]
    SpatialComponentPlaneAlignmentListEXT = 1000741001,

    [NativeName("XR_TYPE_SPATIAL_COMPONENT_MESH_2D_LIST_EXT")]
    SpatialComponentMesh2DListEXT = 1000741002,

    [NativeName("XR_TYPE_SPATIAL_COMPONENT_POLYGON_2D_LIST_EXT")]
    SpatialComponentPolygon2DListEXT = 1000741003,

    [NativeName("XR_TYPE_SPATIAL_COMPONENT_PLANE_SEMANTIC_LABEL_LIST_EXT")]
    SpatialComponentPlaneSemanticLabelListEXT = 1000741004,

    [NativeName("XR_TYPE_STATIONARY_REFERENCE_SPACE_GENERATION_ID_GET_INFO_EXT")]
    StationaryReferenceSpaceGenerationIdGetInfoEXT = 1000742001,

    [NativeName("XR_TYPE_STATIONARY_REFERENCE_SPACE_GENERATION_ID_RESULT_EXT")]
    StationaryReferenceSpaceGenerationIdResultEXT = 1000742002,

    [NativeName("XR_TYPE_SPATIAL_CAPABILITY_CONFIGURATION_QR_CODE_EXT")]
    SpatialCapabilityConfigurationQrCodeEXT = 1000743000,

    [NativeName("XR_TYPE_SPATIAL_CAPABILITY_CONFIGURATION_MICRO_QR_CODE_EXT")]
    SpatialCapabilityConfigurationMicroQrCodeEXT = 1000743001,

    [NativeName("XR_TYPE_SPATIAL_CAPABILITY_CONFIGURATION_ARUCO_MARKER_EXT")]
    SpatialCapabilityConfigurationArucoMarkerEXT = 1000743002,

    [NativeName("XR_TYPE_SPATIAL_CAPABILITY_CONFIGURATION_APRIL_TAG_EXT")]
    SpatialCapabilityConfigurationAprilTagEXT = 1000743003,

    [NativeName("XR_TYPE_SPATIAL_MARKER_SIZE_EXT")]
    SpatialMarkerSizeEXT = 1000743004,

    [NativeName("XR_TYPE_SPATIAL_MARKER_STATIC_OPTIMIZATION_EXT")]
    SpatialMarkerStaticOptimizationEXT = 1000743005,

    [NativeName("XR_TYPE_SPATIAL_COMPONENT_MARKER_LIST_EXT")]
    SpatialComponentMarkerListEXT = 1000743006,

    [NativeName("XR_TYPE_SPATIAL_CAPABILITY_CONFIGURATION_ANCHOR_EXT")]
    SpatialCapabilityConfigurationAnchorEXT = 1000762000,

    [NativeName("XR_TYPE_SPATIAL_COMPONENT_ANCHOR_LIST_EXT")]
    SpatialComponentAnchorListEXT = 1000762001,

    [NativeName("XR_TYPE_SPATIAL_ANCHOR_CREATE_INFO_EXT")]
    SpatialAnchorCreateInfoEXT = 1000762002,

    [NativeName("XR_TYPE_SPATIAL_PERSISTENCE_CONTEXT_CREATE_INFO_EXT")]
    SpatialPersistenceContextCreateInfoEXT = 1000763000,

    [NativeName("XR_TYPE_CREATE_SPATIAL_PERSISTENCE_CONTEXT_COMPLETION_EXT")]
    CreateSpatialPersistenceContextCompletionEXT = 1000763001,

    [NativeName("XR_TYPE_SPATIAL_CONTEXT_PERSISTENCE_CONFIG_EXT")]
    SpatialContextPersistenceConfigEXT = 1000763002,

    [NativeName("XR_TYPE_SPATIAL_DISCOVERY_PERSISTENCE_UUID_FILTER_EXT")]
    SpatialDiscoveryPersistenceUuidFilterEXT = 1000763003,

    [NativeName("XR_TYPE_SPATIAL_COMPONENT_PERSISTENCE_LIST_EXT")]
    SpatialComponentPersistenceListEXT = 1000763004,

    [NativeName("XR_TYPE_HAPTIC_PARAMETRIC_VIBRATION_EXT")]
    HapticParametricVibrationEXT = 1000775000,

    [NativeName("XR_TYPE_HAPTIC_PARAMETRIC_PROPERTIES_EXT")]
    HapticParametricPropertiesEXT = 1000775001,

    [NativeName("XR_TYPE_SYSTEM_HAPTIC_PARAMETRIC_PROPERTIES_EXT")]
    SystemHapticParametricPropertiesEXT = 1000775002,

    [NativeName("XR_TYPE_SPATIAL_ENTITY_PERSIST_INFO_EXT")]
    SpatialEntityPersistInfoEXT = 1000781000,

    [NativeName("XR_TYPE_PERSIST_SPATIAL_ENTITY_COMPLETION_EXT")]
    PersistSpatialEntityCompletionEXT = 1000781001,

    [NativeName("XR_TYPE_SPATIAL_ENTITY_UNPERSIST_INFO_EXT")]
    SpatialEntityUnpersistInfoEXT = 1000781002,

    [NativeName("XR_TYPE_UNPERSIST_SPATIAL_ENTITY_COMPLETION_EXT")]
    UnpersistSpatialEntityCompletionEXT = 1000781003,

    [NativeName("XR_TYPE_SPATIAL_CAPABILITY_CONFIGURATION_OBJECT_TRACKING_ANDROID")]
    SpatialCapabilityConfigurationObjectTrackingANDROID = 1000785000,

    [NativeName("XR_TYPE_SPATIAL_COMPONENT_OBJECT_SEMANTIC_LABEL_LIST_ANDROID")]
    SpatialComponentObjectSemanticLabelListANDROID = 1000785001,

    [NativeName("XR_TYPE_SPATIAL_CAPABILITY_CONFIGURATION_DEPTH_RAYCAST_ANDROID")]
    SpatialCapabilityConfigurationDepthRaycastANDROID = 1000786000,

    [NativeName("XR_TYPE_SPATIAL_RAYCAST_INFO_ANDROID")]
    SpatialRaycastInfoANDROID = 1000786001,

    [NativeName("XR_TYPE_SPATIAL_COMPONENT_RAYCAST_RESULT_LIST_ANDROID")]
    SpatialComponentRaycastResultListANDROID = 1000786002,

    [NativeName("XR_TYPE_SPATIAL_RAYCAST_SNAPSHOT_CREATE_INFO_ANDROID")]
    SpatialRaycastSnapshotCreateInfoANDROID = 1000786003,

    [NativeName("XR_TYPE_SPATIAL_ANCHOR_PARENT_ANDROID")]
    SpatialAnchorParentANDROID = 1000790000,

    [NativeName("XR_TYPE_SPATIAL_DISCOVERY_UNIQUE_ENTITIES_FILTER_ANDROID")]
    SpatialDiscoveryUniqueEntitiesFilterANDROID = 1000791001,

    [NativeName("XR_TYPE_SPATIAL_COMPONENT_SUBSUMED_BY_LIST_ANDROID")]
    SpatialComponentSubsumedByListANDROID = 1000791002,

    [NativeName("XR_TYPE_SPATIAL_ANCHOR_SPACE_FROM_ID_CREATE_INFO_ANDROID")]
    SpatialAnchorSpaceFromIdCreateInfoANDROID = 1000795000,

    [NativeName("XR_TYPE_BATTERY_STATE_DISPLAY_EXT")]
    BatteryStateDisplayEXT = 1000836000,

    [NativeName("XR_TYPE_LOADER_INIT_INFO_PROPERTIES_EXT")]
    LoaderInitInfoPropertiesEXT = 1000838000,

    [NativeName("XR_TYPE_EVENT_DATA_VIEW_CONFIGURATION_VIEWS_CHANGED_EXT")]
    EventDataViewConfigurationViewsChangedEXT = 1000839000,

    [NativeName("XR_TYPE_GRAPHICS_BINDING_VULKAN2_KHR")]
    GraphicsBindingVulkan2KHR = GraphicsBindingVulkanKHR,

    [NativeName("XR_TYPE_SWAPCHAIN_IMAGE_VULKAN2_KHR")]
    SwapchainImageVulkan2KHR = SwapchainImageVulkanKHR,

    [NativeName("XR_TYPE_GRAPHICS_REQUIREMENTS_VULKAN2_KHR")]
    GraphicsRequirementsVulkan2KHR = GraphicsRequirementsVulkanKHR,

    [NativeName("XR_TYPE_DEVICE_PCM_SAMPLE_RATE_GET_INFO_FB")]
    DevicePcmSampleRateGetInfoFB = DevicePcmSampleRateStateFB,

    [NativeName("XR_TYPE_SPACES_LOCATE_INFO_KHR")]
    SpacesLocateInfoKHR = SpacesLocateInfo,

    [NativeName("XR_TYPE_SPACE_LOCATIONS_KHR")]
    SpaceLocationsKHR = SpaceLocations,

    [NativeName("XR_TYPE_SPACE_VELOCITIES_KHR")]
    SpaceVelocitiesKHR = SpaceVelocities,
}
