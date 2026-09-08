// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrStructureType")]
[SupportedApiProfile("openxr")]
public enum StructureType : uint
{
    [NativeName("XR_TYPE_UNKNOWN")]
    [SupportedApiProfile("openxr")]
    Unknown = 0,

    [NativeName("XR_TYPE_API_LAYER_PROPERTIES")]
    [SupportedApiProfile("openxr")]
    ApiLayerProperties = 1,

    [NativeName("XR_TYPE_EXTENSION_PROPERTIES")]
    [SupportedApiProfile("openxr")]
    ExtensionProperties = 2,

    [NativeName("XR_TYPE_INSTANCE_CREATE_INFO")]
    [SupportedApiProfile("openxr")]
    InstanceCreateInfo = 3,

    [NativeName("XR_TYPE_SYSTEM_GET_INFO")]
    [SupportedApiProfile("openxr")]
    SystemGetInfo = 4,

    [NativeName("XR_TYPE_SYSTEM_PROPERTIES")]
    [SupportedApiProfile("openxr")]
    SystemProperties = 5,

    [NativeName("XR_TYPE_VIEW_LOCATE_INFO")]
    [SupportedApiProfile("openxr")]
    ViewLocateInfo = 6,

    [NativeName("XR_TYPE_VIEW")]
    [SupportedApiProfile("openxr")]
    View = 7,

    [NativeName("XR_TYPE_SESSION_CREATE_INFO")]
    [SupportedApiProfile("openxr")]
    SessionCreateInfo = 8,

    [NativeName("XR_TYPE_SWAPCHAIN_CREATE_INFO")]
    [SupportedApiProfile("openxr")]
    SwapchainCreateInfo = 9,

    [NativeName("XR_TYPE_SESSION_BEGIN_INFO")]
    [SupportedApiProfile("openxr")]
    SessionBeginInfo = 10,

    [NativeName("XR_TYPE_VIEW_STATE")]
    [SupportedApiProfile("openxr")]
    ViewState = 11,

    [NativeName("XR_TYPE_FRAME_END_INFO")]
    [SupportedApiProfile("openxr")]
    FrameEndInfo = 12,

    [NativeName("XR_TYPE_HAPTIC_VIBRATION")]
    [SupportedApiProfile("openxr")]
    HapticVibration = 13,

    [NativeName("XR_TYPE_EVENT_DATA_BUFFER")]
    [SupportedApiProfile("openxr")]
    EventDataBuffer = 16,

    [NativeName("XR_TYPE_EVENT_DATA_INSTANCE_LOSS_PENDING")]
    [SupportedApiProfile("openxr")]
    EventDataInstanceLossPending = 17,

    [NativeName("XR_TYPE_EVENT_DATA_SESSION_STATE_CHANGED")]
    [SupportedApiProfile("openxr")]
    EventDataSessionStateChanged = 18,

    [NativeName("XR_TYPE_ACTION_STATE_BOOLEAN")]
    [SupportedApiProfile("openxr")]
    ActionStateBoolean = 23,

    [NativeName("XR_TYPE_ACTION_STATE_FLOAT")]
    [SupportedApiProfile("openxr")]
    ActionStateFloat = 24,

    [NativeName("XR_TYPE_ACTION_STATE_VECTOR2F")]
    [SupportedApiProfile("openxr")]
    ActionStateVector2F = 25,

    [NativeName("XR_TYPE_ACTION_STATE_POSE")]
    [SupportedApiProfile("openxr")]
    ActionStatePose = 27,

    [NativeName("XR_TYPE_ACTION_SET_CREATE_INFO")]
    [SupportedApiProfile("openxr")]
    ActionSetCreateInfo = 28,

    [NativeName("XR_TYPE_ACTION_CREATE_INFO")]
    [SupportedApiProfile("openxr")]
    ActionCreateInfo = 29,

    [NativeName("XR_TYPE_INSTANCE_PROPERTIES")]
    [SupportedApiProfile("openxr")]
    InstanceProperties = 32,

    [NativeName("XR_TYPE_FRAME_WAIT_INFO")]
    [SupportedApiProfile("openxr")]
    FrameWaitInfo = 33,

    [NativeName("XR_TYPE_COMPOSITION_LAYER_PROJECTION")]
    [SupportedApiProfile("openxr")]
    CompositionLayerProjection = 35,

    [NativeName("XR_TYPE_COMPOSITION_LAYER_QUAD")]
    [SupportedApiProfile("openxr")]
    CompositionLayerQuad = 36,

    [NativeName("XR_TYPE_REFERENCE_SPACE_CREATE_INFO")]
    [SupportedApiProfile("openxr")]
    ReferenceSpaceCreateInfo = 37,

    [NativeName("XR_TYPE_ACTION_SPACE_CREATE_INFO")]
    [SupportedApiProfile("openxr")]
    ActionSpaceCreateInfo = 38,

    [NativeName("XR_TYPE_EVENT_DATA_REFERENCE_SPACE_CHANGE_PENDING")]
    [SupportedApiProfile("openxr")]
    EventDataReferenceSpaceChangePending = 40,

    [NativeName("XR_TYPE_VIEW_CONFIGURATION_VIEW")]
    [SupportedApiProfile("openxr")]
    ViewConfigurationView = 41,

    [NativeName("XR_TYPE_SPACE_LOCATION")]
    [SupportedApiProfile("openxr")]
    SpaceLocation = 42,

    [NativeName("XR_TYPE_SPACE_VELOCITY")]
    [SupportedApiProfile("openxr")]
    SpaceVelocity = 43,

    [NativeName("XR_TYPE_FRAME_STATE")]
    [SupportedApiProfile("openxr")]
    FrameState = 44,

    [NativeName("XR_TYPE_VIEW_CONFIGURATION_PROPERTIES")]
    [SupportedApiProfile("openxr")]
    ViewConfigurationProperties = 45,

    [NativeName("XR_TYPE_FRAME_BEGIN_INFO")]
    [SupportedApiProfile("openxr")]
    FrameBeginInfo = 46,

    [NativeName("XR_TYPE_COMPOSITION_LAYER_PROJECTION_VIEW")]
    [SupportedApiProfile("openxr")]
    CompositionLayerProjectionView = 48,

    [NativeName("XR_TYPE_EVENT_DATA_EVENTS_LOST")]
    [SupportedApiProfile("openxr")]
    EventDataEventsLost = 49,

    [NativeName("XR_TYPE_INTERACTION_PROFILE_SUGGESTED_BINDING")]
    [SupportedApiProfile("openxr")]
    InteractionProfileSuggestedBinding = 51,

    [NativeName("XR_TYPE_EVENT_DATA_INTERACTION_PROFILE_CHANGED")]
    [SupportedApiProfile("openxr")]
    EventDataInteractionProfileChanged = 52,

    [NativeName("XR_TYPE_INTERACTION_PROFILE_STATE")]
    [SupportedApiProfile("openxr")]
    InteractionProfileState = 53,

    [NativeName("XR_TYPE_SWAPCHAIN_IMAGE_ACQUIRE_INFO")]
    [SupportedApiProfile("openxr")]
    SwapchainImageAcquireInfo = 55,

    [NativeName("XR_TYPE_SWAPCHAIN_IMAGE_WAIT_INFO")]
    [SupportedApiProfile("openxr")]
    SwapchainImageWaitInfo = 56,

    [NativeName("XR_TYPE_SWAPCHAIN_IMAGE_RELEASE_INFO")]
    [SupportedApiProfile("openxr")]
    SwapchainImageReleaseInfo = 57,

    [NativeName("XR_TYPE_ACTION_STATE_GET_INFO")]
    [SupportedApiProfile("openxr")]
    ActionStateGetInfo = 58,

    [NativeName("XR_TYPE_HAPTIC_ACTION_INFO")]
    [SupportedApiProfile("openxr")]
    HapticActionInfo = 59,

    [NativeName("XR_TYPE_SESSION_ACTION_SETS_ATTACH_INFO")]
    [SupportedApiProfile("openxr")]
    SessionActionSetsAttachInfo = 60,

    [NativeName("XR_TYPE_ACTIONS_SYNC_INFO")]
    [SupportedApiProfile("openxr")]
    ActionsSyncInfo = 61,

    [NativeName("XR_TYPE_BOUND_SOURCES_FOR_ACTION_ENUMERATE_INFO")]
    [SupportedApiProfile("openxr")]
    BoundSourcesForActionEnumerateInfo = 62,

    [NativeName("XR_TYPE_INPUT_SOURCE_LOCALIZED_NAME_GET_INFO")]
    [SupportedApiProfile("openxr")]
    InputSourceLocalizedNameGetInfo = 63,

    [NativeName("XR_TYPE_SPACES_LOCATE_INFO")]
    [SupportedApiProfile("openxr", ["XR_VERSION_1_1"], MinVersion = "1.1")]
    SpacesLocateInfo = 1000471000,

    [NativeName("XR_TYPE_SPACE_LOCATIONS")]
    [SupportedApiProfile("openxr", ["XR_VERSION_1_1"], MinVersion = "1.1")]
    SpaceLocations = 1000471001,

    [NativeName("XR_TYPE_SPACE_VELOCITIES")]
    [SupportedApiProfile("openxr", ["XR_VERSION_1_1"], MinVersion = "1.1")]
    SpaceVelocities = 1000471002,

    [NativeName("XR_TYPE_COMPOSITION_LAYER_CUBE_KHR")]
    [SupportedApiProfile("openxr", ["XR_KHR_composition_layer_cube"])]
    CompositionLayerCubeKHR = 1000006000,

    [NativeName("XR_TYPE_INSTANCE_CREATE_INFO_ANDROID_KHR")]
    [SupportedApiProfile("openxr", ["XR_KHR_android_create_instance"])]
    InstanceCreateInfoAndroidKHR = 1000008000,

    [NativeName("XR_TYPE_COMPOSITION_LAYER_DEPTH_INFO_KHR")]
    [SupportedApiProfile("openxr", ["XR_KHR_composition_layer_depth"])]
    CompositionLayerDepthInfoKHR = 1000010000,

    [NativeName("XR_TYPE_VULKAN_SWAPCHAIN_FORMAT_LIST_CREATE_INFO_KHR")]
    [SupportedApiProfile(
        "openxr",
        ["XR_KHR_vulkan_swapchain_format_list"],
        ImpliesSets = ["XR_KHR_vulkan_enable", "XR_KHR_vulkan_enable2", "XR_VERSION_1_0"]
    )]
    VulkanSwapchainFormatListCreateInfoKHR = 1000014000,

    [NativeName("XR_TYPE_EVENT_DATA_PERF_SETTINGS_EXT")]
    [SupportedApiProfile("openxr", ["XR_EXT_performance_settings"])]
    EventDataPerfSettingsEXT = 1000015000,

    [NativeName("XR_TYPE_COMPOSITION_LAYER_CYLINDER_KHR")]
    [SupportedApiProfile("openxr", ["XR_KHR_composition_layer_cylinder"])]
    CompositionLayerCylinderKHR = 1000017000,

    [NativeName("XR_TYPE_COMPOSITION_LAYER_EQUIRECT_KHR")]
    [SupportedApiProfile("openxr", ["XR_KHR_composition_layer_equirect"])]
    CompositionLayerEquirectKHR = 1000018000,

    [NativeName("XR_TYPE_DEBUG_UTILS_OBJECT_NAME_INFO_EXT")]
    [SupportedApiProfile("openxr", ["XR_EXT_debug_utils"])]
    DebugUtilsObjectNameInfoEXT = 1000019000,

    [NativeName("XR_TYPE_DEBUG_UTILS_MESSENGER_CALLBACK_DATA_EXT")]
    [SupportedApiProfile("openxr", ["XR_EXT_debug_utils"])]
    DebugUtilsMessengerCallbackDataEXT = 1000019001,

    [NativeName("XR_TYPE_DEBUG_UTILS_MESSENGER_CREATE_INFO_EXT")]
    [SupportedApiProfile("openxr", ["XR_EXT_debug_utils"])]
    DebugUtilsMessengerCreateInfoEXT = 1000019002,

    [NativeName("XR_TYPE_DEBUG_UTILS_LABEL_EXT")]
    [SupportedApiProfile("openxr", ["XR_EXT_debug_utils"])]
    DebugUtilsLabelEXT = 1000019003,

    [NativeName("XR_TYPE_GRAPHICS_BINDING_OPENGL_WIN32_KHR")]
    [SupportedApiProfile("openxr", ["XR_KHR_opengl_enable"])]
    GraphicsBindingOpenglWin32KHR = 1000023000,

    [NativeName("XR_TYPE_GRAPHICS_BINDING_OPENGL_XLIB_KHR")]
    [SupportedApiProfile("openxr", ["XR_KHR_opengl_enable"])]
    GraphicsBindingOpenglXlibKHR = 1000023001,

    [NativeName("XR_TYPE_GRAPHICS_BINDING_OPENGL_XCB_KHR")]
    [SupportedApiProfile("openxr", ["XR_KHR_opengl_enable"])]
    GraphicsBindingOpenglXcbKHR = 1000023002,

    [NativeName("XR_TYPE_GRAPHICS_BINDING_OPENGL_WAYLAND_KHR")]
    [SupportedApiProfile("openxr", ["XR_KHR_opengl_enable"])]
    GraphicsBindingOpenglWaylandKHR = 1000023003,

    [NativeName("XR_TYPE_SWAPCHAIN_IMAGE_OPENGL_KHR")]
    [SupportedApiProfile("openxr", ["XR_KHR_opengl_enable"])]
    SwapchainImageOpenglKHR = 1000023004,

    [NativeName("XR_TYPE_GRAPHICS_REQUIREMENTS_OPENGL_KHR")]
    [SupportedApiProfile("openxr", ["XR_KHR_opengl_enable"])]
    GraphicsRequirementsOpenglKHR = 1000023005,

    [NativeName("XR_TYPE_GRAPHICS_BINDING_OPENGL_ES_ANDROID_KHR")]
    [SupportedApiProfile("openxr", ["XR_KHR_opengl_es_enable"])]
    GraphicsBindingOpenglEsAndroidKHR = 1000024001,

    [NativeName("XR_TYPE_SWAPCHAIN_IMAGE_OPENGL_ES_KHR")]
    [SupportedApiProfile("openxr", ["XR_KHR_opengl_es_enable"])]
    SwapchainImageOpenglEsKHR = 1000024002,

    [NativeName("XR_TYPE_GRAPHICS_REQUIREMENTS_OPENGL_ES_KHR")]
    [SupportedApiProfile("openxr", ["XR_KHR_opengl_es_enable"])]
    GraphicsRequirementsOpenglEsKHR = 1000024003,

    [NativeName("XR_TYPE_GRAPHICS_BINDING_VULKAN_KHR")]
    [SupportedApiProfile("openxr", ["XR_KHR_vulkan_enable"])]
    GraphicsBindingVulkanKHR = 1000025000,

    [NativeName("XR_TYPE_SWAPCHAIN_IMAGE_VULKAN_KHR")]
    [SupportedApiProfile("openxr", ["XR_KHR_vulkan_enable"])]
    SwapchainImageVulkanKHR = 1000025001,

    [NativeName("XR_TYPE_GRAPHICS_REQUIREMENTS_VULKAN_KHR")]
    [SupportedApiProfile("openxr", ["XR_KHR_vulkan_enable"])]
    GraphicsRequirementsVulkanKHR = 1000025002,

    [NativeName("XR_TYPE_GRAPHICS_BINDING_D3D11_KHR")]
    [SupportedApiProfile("openxr", ["XR_KHR_D3D11_enable"])]
    GraphicsBindingD3D11KHR = 1000027000,

    [NativeName("XR_TYPE_SWAPCHAIN_IMAGE_D3D11_KHR")]
    [SupportedApiProfile("openxr", ["XR_KHR_D3D11_enable"])]
    SwapchainImageD3D11KHR = 1000027001,

    [NativeName("XR_TYPE_GRAPHICS_REQUIREMENTS_D3D11_KHR")]
    [SupportedApiProfile("openxr", ["XR_KHR_D3D11_enable"])]
    GraphicsRequirementsD3D11KHR = 1000027002,

    [NativeName("XR_TYPE_GRAPHICS_BINDING_D3D12_KHR")]
    [SupportedApiProfile("openxr", ["XR_KHR_D3D12_enable"])]
    GraphicsBindingD3D12KHR = 1000028000,

    [NativeName("XR_TYPE_SWAPCHAIN_IMAGE_D3D12_KHR")]
    [SupportedApiProfile("openxr", ["XR_KHR_D3D12_enable"])]
    SwapchainImageD3D12KHR = 1000028001,

    [NativeName("XR_TYPE_GRAPHICS_REQUIREMENTS_D3D12_KHR")]
    [SupportedApiProfile("openxr", ["XR_KHR_D3D12_enable"])]
    GraphicsRequirementsD3D12KHR = 1000028002,

    [NativeName("XR_TYPE_GRAPHICS_BINDING_METAL_KHR")]
    [SupportedApiProfile("openxr", ["XR_KHR_metal_enable"])]
    GraphicsBindingMetalKHR = 1000029000,

    [NativeName("XR_TYPE_SWAPCHAIN_IMAGE_METAL_KHR")]
    [SupportedApiProfile("openxr", ["XR_KHR_metal_enable"])]
    SwapchainImageMetalKHR = 1000029001,

    [NativeName("XR_TYPE_GRAPHICS_REQUIREMENTS_METAL_KHR")]
    [SupportedApiProfile("openxr", ["XR_KHR_metal_enable"])]
    GraphicsRequirementsMetalKHR = 1000029002,

    [NativeName("XR_TYPE_SYSTEM_EYE_GAZE_INTERACTION_PROPERTIES_EXT")]
    [SupportedApiProfile("openxr", ["XR_EXT_eye_gaze_interaction"])]
    SystemEyeGazeInteractionPropertiesEXT = 1000030000,

    [NativeName("XR_TYPE_EYE_GAZE_SAMPLE_TIME_EXT")]
    [SupportedApiProfile("openxr", ["XR_EXT_eye_gaze_interaction"])]
    EyeGazeSampleTimeEXT = 1000030001,

    [NativeName("XR_TYPE_VISIBILITY_MASK_KHR")]
    [SupportedApiProfile("openxr", ["XR_KHR_visibility_mask"])]
    VisibilityMaskKHR = 1000031000,

    [NativeName("XR_TYPE_EVENT_DATA_VISIBILITY_MASK_CHANGED_KHR")]
    [SupportedApiProfile("openxr", ["XR_KHR_visibility_mask"])]
    EventDataVisibilityMaskChangedKHR = 1000031001,

    [NativeName("XR_TYPE_SESSION_CREATE_INFO_OVERLAY_EXTX")]
    [SupportedApiProfile("openxr", ["XR_EXTX_overlay"])]
    SessionCreateInfoOverlayEXTX = 1000033000,

    [NativeName("XR_TYPE_EVENT_DATA_MAIN_SESSION_VISIBILITY_CHANGED_EXTX")]
    [SupportedApiProfile("openxr", ["XR_EXTX_overlay"])]
    EventDataMainSessionVisibilityChangedEXTX = 1000033003,

    [NativeName("XR_TYPE_COMPOSITION_LAYER_COLOR_SCALE_BIAS_KHR")]
    [SupportedApiProfile("openxr", ["XR_KHR_composition_layer_color_scale_bias"])]
    CompositionLayerColorScaleBiasKHR = 1000034000,

    [NativeName("XR_TYPE_SPATIAL_ANCHOR_CREATE_INFO_MSFT")]
    [SupportedApiProfile("openxr", ["XR_MSFT_spatial_anchor"])]
    SpatialAnchorCreateInfoMSFT = 1000039000,

    [NativeName("XR_TYPE_SPATIAL_ANCHOR_SPACE_CREATE_INFO_MSFT")]
    [SupportedApiProfile("openxr", ["XR_MSFT_spatial_anchor"])]
    SpatialAnchorSpaceCreateInfoMSFT = 1000039001,

    [NativeName("XR_TYPE_COMPOSITION_LAYER_IMAGE_LAYOUT_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_composition_layer_image_layout"])]
    CompositionLayerImageLayoutFB = 1000040000,

    [NativeName("XR_TYPE_COMPOSITION_LAYER_ALPHA_BLEND_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_composition_layer_alpha_blend"])]
    CompositionLayerAlphaBlendFB = 1000041001,

    [NativeName("XR_TYPE_VIEW_CONFIGURATION_DEPTH_RANGE_EXT")]
    [SupportedApiProfile("openxr", ["XR_EXT_view_configuration_depth_range"])]
    ViewConfigurationDepthRangeEXT = 1000046000,

    [NativeName("XR_TYPE_GRAPHICS_BINDING_EGL_MNDX")]
    [SupportedApiProfile("openxr", ["XR_MNDX_egl_enable"])]
    GraphicsBindingEglMNDX = 1000048004,

    [NativeName("XR_TYPE_SPATIAL_GRAPH_NODE_SPACE_CREATE_INFO_MSFT")]
    [SupportedApiProfile("openxr", ["XR_MSFT_spatial_graph_bridge"])]
    SpatialGraphNodeSpaceCreateInfoMSFT = 1000049000,

    [NativeName("XR_TYPE_SPATIAL_GRAPH_STATIC_NODE_BINDING_CREATE_INFO_MSFT")]
    [SupportedApiProfile("openxr", ["XR_MSFT_spatial_graph_bridge"])]
    SpatialGraphStaticNodeBindingCreateInfoMSFT = 1000049001,

    [NativeName("XR_TYPE_SPATIAL_GRAPH_NODE_BINDING_PROPERTIES_GET_INFO_MSFT")]
    [SupportedApiProfile("openxr", ["XR_MSFT_spatial_graph_bridge"])]
    SpatialGraphNodeBindingPropertiesGetInfoMSFT = 1000049002,

    [NativeName("XR_TYPE_SPATIAL_GRAPH_NODE_BINDING_PROPERTIES_MSFT")]
    [SupportedApiProfile("openxr", ["XR_MSFT_spatial_graph_bridge"])]
    SpatialGraphNodeBindingPropertiesMSFT = 1000049003,

    [NativeName("XR_TYPE_SYSTEM_HAND_TRACKING_PROPERTIES_EXT")]
    [SupportedApiProfile("openxr", ["XR_EXT_hand_tracking"])]
    SystemHandTrackingPropertiesEXT = 1000051000,

    [NativeName("XR_TYPE_HAND_TRACKER_CREATE_INFO_EXT")]
    [SupportedApiProfile("openxr", ["XR_EXT_hand_tracking"])]
    HandTrackerCreateInfoEXT = 1000051001,

    [NativeName("XR_TYPE_HAND_JOINTS_LOCATE_INFO_EXT")]
    [SupportedApiProfile("openxr", ["XR_EXT_hand_tracking"])]
    HandJointsLocateInfoEXT = 1000051002,

    [NativeName("XR_TYPE_HAND_JOINT_LOCATIONS_EXT")]
    [SupportedApiProfile("openxr", ["XR_EXT_hand_tracking"])]
    HandJointLocationsEXT = 1000051003,

    [NativeName("XR_TYPE_HAND_JOINT_VELOCITIES_EXT")]
    [SupportedApiProfile("openxr", ["XR_EXT_hand_tracking"])]
    HandJointVelocitiesEXT = 1000051004,

    [NativeName("XR_TYPE_SYSTEM_HAND_TRACKING_MESH_PROPERTIES_MSFT")]
    [SupportedApiProfile(
        "openxr",
        ["XR_MSFT_hand_tracking_mesh"],
        ImpliesSets = ["XR_EXT_hand_tracking", "XR_VERSION_1_0"]
    )]
    SystemHandTrackingMeshPropertiesMSFT = 1000052000,

    [NativeName("XR_TYPE_HAND_MESH_SPACE_CREATE_INFO_MSFT")]
    [SupportedApiProfile(
        "openxr",
        ["XR_MSFT_hand_tracking_mesh"],
        ImpliesSets = ["XR_EXT_hand_tracking", "XR_VERSION_1_0"]
    )]
    HandMeshSpaceCreateInfoMSFT = 1000052001,

    [NativeName("XR_TYPE_HAND_MESH_UPDATE_INFO_MSFT")]
    [SupportedApiProfile(
        "openxr",
        ["XR_MSFT_hand_tracking_mesh"],
        ImpliesSets = ["XR_EXT_hand_tracking", "XR_VERSION_1_0"]
    )]
    HandMeshUpdateInfoMSFT = 1000052002,

    [NativeName("XR_TYPE_HAND_MESH_MSFT")]
    [SupportedApiProfile(
        "openxr",
        ["XR_MSFT_hand_tracking_mesh"],
        ImpliesSets = ["XR_EXT_hand_tracking", "XR_VERSION_1_0"]
    )]
    HandMeshMSFT = 1000052003,

    [NativeName("XR_TYPE_HAND_POSE_TYPE_INFO_MSFT")]
    [SupportedApiProfile(
        "openxr",
        ["XR_MSFT_hand_tracking_mesh"],
        ImpliesSets = ["XR_EXT_hand_tracking", "XR_VERSION_1_0"]
    )]
    HandPoseTypeInfoMSFT = 1000052004,

    [NativeName("XR_TYPE_SECONDARY_VIEW_CONFIGURATION_SESSION_BEGIN_INFO_MSFT")]
    [SupportedApiProfile("openxr", ["XR_MSFT_secondary_view_configuration"])]
    SecondaryViewConfigurationSessionBeginInfoMSFT = 1000053000,

    [NativeName("XR_TYPE_SECONDARY_VIEW_CONFIGURATION_STATE_MSFT")]
    [SupportedApiProfile("openxr", ["XR_MSFT_secondary_view_configuration"])]
    SecondaryViewConfigurationStateMSFT = 1000053001,

    [NativeName("XR_TYPE_SECONDARY_VIEW_CONFIGURATION_FRAME_STATE_MSFT")]
    [SupportedApiProfile("openxr", ["XR_MSFT_secondary_view_configuration"])]
    SecondaryViewConfigurationFrameStateMSFT = 1000053002,

    [NativeName("XR_TYPE_SECONDARY_VIEW_CONFIGURATION_FRAME_END_INFO_MSFT")]
    [SupportedApiProfile("openxr", ["XR_MSFT_secondary_view_configuration"])]
    SecondaryViewConfigurationFrameEndInfoMSFT = 1000053003,

    [NativeName("XR_TYPE_SECONDARY_VIEW_CONFIGURATION_LAYER_INFO_MSFT")]
    [SupportedApiProfile("openxr", ["XR_MSFT_secondary_view_configuration"])]
    SecondaryViewConfigurationLayerInfoMSFT = 1000053004,

    [NativeName("XR_TYPE_SECONDARY_VIEW_CONFIGURATION_SWAPCHAIN_CREATE_INFO_MSFT")]
    [SupportedApiProfile("openxr", ["XR_MSFT_secondary_view_configuration"])]
    SecondaryViewConfigurationSwapchainCreateInfoMSFT = 1000053005,

    [NativeName("XR_TYPE_CONTROLLER_MODEL_KEY_STATE_MSFT")]
    [SupportedApiProfile("openxr", ["XR_MSFT_controller_model"])]
    ControllerModelKeyStateMSFT = 1000055000,

    [NativeName("XR_TYPE_CONTROLLER_MODEL_NODE_PROPERTIES_MSFT")]
    [SupportedApiProfile("openxr", ["XR_MSFT_controller_model"])]
    ControllerModelNodePropertiesMSFT = 1000055001,

    [NativeName("XR_TYPE_CONTROLLER_MODEL_PROPERTIES_MSFT")]
    [SupportedApiProfile("openxr", ["XR_MSFT_controller_model"])]
    ControllerModelPropertiesMSFT = 1000055002,

    [NativeName("XR_TYPE_CONTROLLER_MODEL_NODE_STATE_MSFT")]
    [SupportedApiProfile("openxr", ["XR_MSFT_controller_model"])]
    ControllerModelNodeStateMSFT = 1000055003,

    [NativeName("XR_TYPE_CONTROLLER_MODEL_STATE_MSFT")]
    [SupportedApiProfile("openxr", ["XR_MSFT_controller_model"])]
    ControllerModelStateMSFT = 1000055004,

    [NativeName("XR_TYPE_VIEW_CONFIGURATION_VIEW_FOV_EPIC")]
    [SupportedApiProfile("openxr", ["XR_EPIC_view_configuration_fov"])]
    ViewConfigurationViewFovEPIC = 1000059000,

    [NativeName("XR_TYPE_HOLOGRAPHIC_WINDOW_ATTACHMENT_MSFT")]
    [SupportedApiProfile("openxr", ["XR_MSFT_holographic_window_attachment"])]
    HolographicWindowAttachmentMSFT = 1000063000,

    [NativeName("XR_TYPE_COMPOSITION_LAYER_REPROJECTION_INFO_MSFT")]
    [SupportedApiProfile("openxr", ["XR_MSFT_composition_layer_reprojection"])]
    CompositionLayerReprojectionInfoMSFT = 1000066000,

    [NativeName("XR_TYPE_COMPOSITION_LAYER_REPROJECTION_PLANE_OVERRIDE_MSFT")]
    [SupportedApiProfile("openxr", ["XR_MSFT_composition_layer_reprojection"])]
    CompositionLayerReprojectionPlaneOverrideMSFT = 1000066001,

    [NativeName("XR_TYPE_ANDROID_SURFACE_SWAPCHAIN_CREATE_INFO_FB")]
    [SupportedApiProfile(
        "openxr",
        ["XR_FB_android_surface_swapchain_create"],
        ImpliesSets = ["XR_KHR_android_surface_swapchain", "XR_VERSION_1_0"]
    )]
    AndroidSurfaceSwapchainCreateInfoFB = 1000070000,

    [NativeName("XR_TYPE_COMPOSITION_LAYER_SECURE_CONTENT_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_composition_layer_secure_content"])]
    CompositionLayerSecureContentFB = 1000072000,

    [NativeName("XR_TYPE_BODY_TRACKER_CREATE_INFO_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_body_tracking"])]
    BodyTrackerCreateInfoFB = 1000076001,

    [NativeName("XR_TYPE_BODY_JOINTS_LOCATE_INFO_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_body_tracking"])]
    BodyJointsLocateInfoFB = 1000076002,

    [NativeName("XR_TYPE_SYSTEM_BODY_TRACKING_PROPERTIES_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_body_tracking"])]
    SystemBodyTrackingPropertiesFB = 1000076004,

    [NativeName("XR_TYPE_BODY_JOINT_LOCATIONS_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_body_tracking"])]
    BodyJointLocationsFB = 1000076005,

    [NativeName("XR_TYPE_BODY_SKELETON_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_body_tracking"])]
    BodySkeletonFB = 1000076006,

    [NativeName("XR_TYPE_INTERACTION_PROFILE_DPAD_BINDING_EXT")]
    [SupportedApiProfile(
        "openxr",
        ["XR_EXT_dpad_binding"],
        ImpliesSets = ["XR_KHR_binding_modification", "XR_VERSION_1_0"]
    )]
    InteractionProfileDpadBindingEXT = 1000078000,

    [NativeName("XR_TYPE_INTERACTION_PROFILE_ANALOG_THRESHOLD_VALVE")]
    [SupportedApiProfile("openxr", ["XR_VALVE_analog_threshold"])]
    InteractionProfileAnalogThresholdVALVE = 1000079000,

    [NativeName("XR_TYPE_HAND_JOINTS_MOTION_RANGE_INFO_EXT")]
    [SupportedApiProfile(
        "openxr",
        ["XR_EXT_hand_joints_motion_range"],
        ImpliesSets = ["XR_EXT_hand_tracking", "XR_VERSION_1_0"]
    )]
    HandJointsMotionRangeInfoEXT = 1000080000,

    [NativeName("XR_TYPE_LOADER_INIT_INFO_ANDROID_KHR")]
    [SupportedApiProfile(
        "openxr",
        ["XR_KHR_loader_init_android"],
        ImpliesSets = ["XR_KHR_loader_init", "XR_VERSION_1_0"]
    )]
    LoaderInitInfoAndroidKHR = 1000089000,

    [NativeName("XR_TYPE_VULKAN_INSTANCE_CREATE_INFO_KHR")]
    [SupportedApiProfile("openxr", ["XR_KHR_vulkan_enable2"])]
    VulkanInstanceCreateInfoKHR = 1000090000,

    [NativeName("XR_TYPE_VULKAN_DEVICE_CREATE_INFO_KHR")]
    [SupportedApiProfile("openxr", ["XR_KHR_vulkan_enable2"])]
    VulkanDeviceCreateInfoKHR = 1000090001,

    [NativeName("XR_TYPE_VULKAN_GRAPHICS_DEVICE_GET_INFO_KHR")]
    [SupportedApiProfile("openxr", ["XR_KHR_vulkan_enable2"])]
    VulkanGraphicsDeviceGetInfoKHR = 1000090003,

    [NativeName("XR_TYPE_COMPOSITION_LAYER_EQUIRECT2_KHR")]
    [SupportedApiProfile("openxr", ["XR_KHR_composition_layer_equirect2"])]
    CompositionLayerEquirect2KHR = 1000091000,

    [NativeName("XR_TYPE_SCENE_OBSERVER_CREATE_INFO_MSFT")]
    [SupportedApiProfile("openxr", ["XR_MSFT_scene_understanding"])]
    SceneObserverCreateInfoMSFT = 1000097000,

    [NativeName("XR_TYPE_SCENE_CREATE_INFO_MSFT")]
    [SupportedApiProfile("openxr", ["XR_MSFT_scene_understanding"])]
    SceneCreateInfoMSFT = 1000097001,

    [NativeName("XR_TYPE_NEW_SCENE_COMPUTE_INFO_MSFT")]
    [SupportedApiProfile("openxr", ["XR_MSFT_scene_understanding"])]
    NewSceneComputeInfoMSFT = 1000097002,

    [NativeName("XR_TYPE_VISUAL_MESH_COMPUTE_LOD_INFO_MSFT")]
    [SupportedApiProfile("openxr", ["XR_MSFT_scene_understanding"])]
    VisualMeshComputeLodInfoMSFT = 1000097003,

    [NativeName("XR_TYPE_SCENE_COMPONENTS_MSFT")]
    [SupportedApiProfile("openxr", ["XR_MSFT_scene_understanding"])]
    SceneComponentsMSFT = 1000097004,

    [NativeName("XR_TYPE_SCENE_COMPONENTS_GET_INFO_MSFT")]
    [SupportedApiProfile("openxr", ["XR_MSFT_scene_understanding"])]
    SceneComponentsGetInfoMSFT = 1000097005,

    [NativeName("XR_TYPE_SCENE_COMPONENT_LOCATIONS_MSFT")]
    [SupportedApiProfile("openxr", ["XR_MSFT_scene_understanding"])]
    SceneComponentLocationsMSFT = 1000097006,

    [NativeName("XR_TYPE_SCENE_COMPONENTS_LOCATE_INFO_MSFT")]
    [SupportedApiProfile("openxr", ["XR_MSFT_scene_understanding"])]
    SceneComponentsLocateInfoMSFT = 1000097007,

    [NativeName("XR_TYPE_SCENE_OBJECTS_MSFT")]
    [SupportedApiProfile("openxr", ["XR_MSFT_scene_understanding"])]
    SceneObjectsMSFT = 1000097008,

    [NativeName("XR_TYPE_SCENE_COMPONENT_PARENT_FILTER_INFO_MSFT")]
    [SupportedApiProfile("openxr", ["XR_MSFT_scene_understanding"])]
    SceneComponentParentFilterInfoMSFT = 1000097009,

    [NativeName("XR_TYPE_SCENE_OBJECT_TYPES_FILTER_INFO_MSFT")]
    [SupportedApiProfile("openxr", ["XR_MSFT_scene_understanding"])]
    SceneObjectTypesFilterInfoMSFT = 1000097010,

    [NativeName("XR_TYPE_SCENE_PLANES_MSFT")]
    [SupportedApiProfile("openxr", ["XR_MSFT_scene_understanding"])]
    ScenePlanesMSFT = 1000097011,

    [NativeName("XR_TYPE_SCENE_PLANE_ALIGNMENT_FILTER_INFO_MSFT")]
    [SupportedApiProfile("openxr", ["XR_MSFT_scene_understanding"])]
    ScenePlaneAlignmentFilterInfoMSFT = 1000097012,

    [NativeName("XR_TYPE_SCENE_MESHES_MSFT")]
    [SupportedApiProfile("openxr", ["XR_MSFT_scene_understanding"])]
    SceneMeshesMSFT = 1000097013,

    [NativeName("XR_TYPE_SCENE_MESH_BUFFERS_GET_INFO_MSFT")]
    [SupportedApiProfile("openxr", ["XR_MSFT_scene_understanding"])]
    SceneMeshBuffersGetInfoMSFT = 1000097014,

    [NativeName("XR_TYPE_SCENE_MESH_BUFFERS_MSFT")]
    [SupportedApiProfile("openxr", ["XR_MSFT_scene_understanding"])]
    SceneMeshBuffersMSFT = 1000097015,

    [NativeName("XR_TYPE_SCENE_MESH_VERTEX_BUFFER_MSFT")]
    [SupportedApiProfile("openxr", ["XR_MSFT_scene_understanding"])]
    SceneMeshVertexBufferMSFT = 1000097016,

    [NativeName("XR_TYPE_SCENE_MESH_INDICES_UINT32_MSFT")]
    [SupportedApiProfile("openxr", ["XR_MSFT_scene_understanding"])]
    SceneMeshIndicesUint32MSFT = 1000097017,

    [NativeName("XR_TYPE_SCENE_MESH_INDICES_UINT16_MSFT")]
    [SupportedApiProfile("openxr", ["XR_MSFT_scene_understanding"])]
    SceneMeshIndicesUint16MSFT = 1000097018,

    [NativeName("XR_TYPE_SERIALIZED_SCENE_FRAGMENT_DATA_GET_INFO_MSFT")]
    [SupportedApiProfile(
        "openxr",
        ["XR_MSFT_scene_understanding_serialization"],
        ImpliesSets = ["XR_MSFT_scene_understanding", "XR_VERSION_1_0"]
    )]
    SerializedSceneFragmentDataGetInfoMSFT = 1000098000,

    [NativeName("XR_TYPE_SCENE_DESERIALIZE_INFO_MSFT")]
    [SupportedApiProfile(
        "openxr",
        ["XR_MSFT_scene_understanding_serialization"],
        ImpliesSets = ["XR_MSFT_scene_understanding", "XR_VERSION_1_0"]
    )]
    SceneDeserializeInfoMSFT = 1000098001,

    [NativeName("XR_TYPE_EVENT_DATA_DISPLAY_REFRESH_RATE_CHANGED_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_display_refresh_rate"])]
    EventDataDisplayRefreshRateChangedFB = 1000101000,

    [NativeName("XR_TYPE_VIVE_TRACKER_PATHS_HTCX")]
    [SupportedApiProfile("openxr", ["XR_HTCX_vive_tracker_interaction"])]
    ViveTrackerPathsHTCX = 1000103000,

    [NativeName("XR_TYPE_EVENT_DATA_VIVE_TRACKER_CONNECTED_HTCX")]
    [SupportedApiProfile("openxr", ["XR_HTCX_vive_tracker_interaction"])]
    EventDataViveTrackerConnectedHTCX = 1000103001,

    [NativeName("XR_TYPE_SYSTEM_FACIAL_TRACKING_PROPERTIES_HTC")]
    [SupportedApiProfile("openxr", ["XR_HTC_facial_tracking"])]
    SystemFacialTrackingPropertiesHTC = 1000104000,

    [NativeName("XR_TYPE_FACIAL_TRACKER_CREATE_INFO_HTC")]
    [SupportedApiProfile("openxr", ["XR_HTC_facial_tracking"])]
    FacialTrackerCreateInfoHTC = 1000104001,

    [NativeName("XR_TYPE_FACIAL_EXPRESSIONS_HTC")]
    [SupportedApiProfile("openxr", ["XR_HTC_facial_tracking"])]
    FacialExpressionsHTC = 1000104002,

    [NativeName("XR_TYPE_SYSTEM_COLOR_SPACE_PROPERTIES_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_color_space"])]
    SystemColorSpacePropertiesFB = 1000108000,

    [NativeName("XR_TYPE_HAND_TRACKING_MESH_FB")]
    [SupportedApiProfile(
        "openxr",
        ["XR_FB_hand_tracking_mesh"],
        ImpliesSets = ["XR_EXT_hand_tracking", "XR_VERSION_1_0"]
    )]
    HandTrackingMeshFB = 1000110001,

    [NativeName("XR_TYPE_HAND_TRACKING_SCALE_FB")]
    [SupportedApiProfile(
        "openxr",
        ["XR_FB_hand_tracking_mesh"],
        ImpliesSets = ["XR_EXT_hand_tracking", "XR_VERSION_1_0"]
    )]
    HandTrackingScaleFB = 1000110003,

    [NativeName("XR_TYPE_HAND_TRACKING_AIM_STATE_FB")]
    [SupportedApiProfile(
        "openxr",
        ["XR_FB_hand_tracking_aim"],
        ImpliesSets = ["XR_EXT_hand_tracking", "XR_VERSION_1_0"]
    )]
    HandTrackingAimStateFB = 1000111001,

    [NativeName("XR_TYPE_HAND_TRACKING_CAPSULES_STATE_FB")]
    [SupportedApiProfile(
        "openxr",
        ["XR_FB_hand_tracking_capsules"],
        ImpliesSets = ["XR_EXT_hand_tracking", "XR_VERSION_1_0"]
    )]
    HandTrackingCapsulesStateFB = 1000112000,

    [NativeName("XR_TYPE_SYSTEM_SPATIAL_ENTITY_PROPERTIES_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_spatial_entity"])]
    SystemSpatialEntityPropertiesFB = 1000113004,

    [NativeName("XR_TYPE_SPATIAL_ANCHOR_CREATE_INFO_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_spatial_entity"])]
    SpatialAnchorCreateInfoFB = 1000113003,

    [NativeName("XR_TYPE_SPACE_COMPONENT_STATUS_SET_INFO_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_spatial_entity"])]
    SpaceComponentStatusSetInfoFB = 1000113007,

    [NativeName("XR_TYPE_SPACE_COMPONENT_STATUS_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_spatial_entity"])]
    SpaceComponentStatusFB = 1000113001,

    [NativeName("XR_TYPE_EVENT_DATA_SPATIAL_ANCHOR_CREATE_COMPLETE_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_spatial_entity"])]
    EventDataSpatialAnchorCreateCompleteFB = 1000113005,

    [NativeName("XR_TYPE_EVENT_DATA_SPACE_SET_STATUS_COMPLETE_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_spatial_entity"])]
    EventDataSpaceSetStatusCompleteFB = 1000113006,

    [NativeName("XR_TYPE_FOVEATION_PROFILE_CREATE_INFO_FB")]
    [SupportedApiProfile(
        "openxr",
        ["XR_FB_foveation"],
        ImpliesSets = ["XR_FB_swapchain_update_state", "XR_VERSION_1_0"]
    )]
    FoveationProfileCreateInfoFB = 1000114000,

    [NativeName("XR_TYPE_SWAPCHAIN_CREATE_INFO_FOVEATION_FB")]
    [SupportedApiProfile(
        "openxr",
        ["XR_FB_foveation"],
        ImpliesSets = ["XR_FB_swapchain_update_state", "XR_VERSION_1_0"]
    )]
    SwapchainCreateInfoFoveationFB = 1000114001,

    [NativeName("XR_TYPE_SWAPCHAIN_STATE_FOVEATION_FB")]
    [SupportedApiProfile(
        "openxr",
        ["XR_FB_foveation"],
        ImpliesSets = ["XR_FB_swapchain_update_state", "XR_VERSION_1_0"]
    )]
    SwapchainStateFoveationFB = 1000114002,

    [NativeName("XR_TYPE_FOVEATION_LEVEL_PROFILE_CREATE_INFO_FB")]
    [SupportedApiProfile(
        "openxr",
        ["XR_FB_foveation_configuration"],
        ImpliesSets = ["XR_FB_foveation", "XR_VERSION_1_0"]
    )]
    FoveationLevelProfileCreateInfoFB = 1000115000,

    [NativeName("XR_TYPE_KEYBOARD_SPACE_CREATE_INFO_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_keyboard_tracking"])]
    KeyboardSpaceCreateInfoFB = 1000116009,

    [NativeName("XR_TYPE_KEYBOARD_TRACKING_QUERY_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_keyboard_tracking"])]
    KeyboardTrackingQueryFB = 1000116004,

    [NativeName("XR_TYPE_SYSTEM_KEYBOARD_TRACKING_PROPERTIES_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_keyboard_tracking"])]
    SystemKeyboardTrackingPropertiesFB = 1000116002,

    [NativeName("XR_TYPE_TRIANGLE_MESH_CREATE_INFO_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_triangle_mesh"])]
    TriangleMeshCreateInfoFB = 1000117001,

    [NativeName("XR_TYPE_SYSTEM_PASSTHROUGH_PROPERTIES_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_passthrough"])]
    SystemPassthroughPropertiesFB = 1000118000,

    [NativeName("XR_TYPE_PASSTHROUGH_CREATE_INFO_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_passthrough"])]
    PassthroughCreateInfoFB = 1000118001,

    [NativeName("XR_TYPE_PASSTHROUGH_LAYER_CREATE_INFO_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_passthrough"])]
    PassthroughLayerCreateInfoFB = 1000118002,

    [NativeName("XR_TYPE_COMPOSITION_LAYER_PASSTHROUGH_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_passthrough"])]
    CompositionLayerPassthroughFB = 1000118003,

    [NativeName("XR_TYPE_GEOMETRY_INSTANCE_CREATE_INFO_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_passthrough"])]
    GeometryInstanceCreateInfoFB = 1000118004,

    [NativeName("XR_TYPE_GEOMETRY_INSTANCE_TRANSFORM_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_passthrough"])]
    GeometryInstanceTransformFB = 1000118005,

    [NativeName("XR_TYPE_SYSTEM_PASSTHROUGH_PROPERTIES2_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_passthrough"])]
    SystemPassthroughProperties2FB = 1000118006,

    [NativeName("XR_TYPE_PASSTHROUGH_STYLE_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_passthrough"])]
    PassthroughStyleFB = 1000118020,

    [NativeName("XR_TYPE_PASSTHROUGH_COLOR_MAP_MONO_TO_RGBA_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_passthrough"])]
    PassthroughColorMapMonoToRgbaFB = 1000118021,

    [NativeName("XR_TYPE_PASSTHROUGH_COLOR_MAP_MONO_TO_MONO_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_passthrough"])]
    PassthroughColorMapMonoToMonoFB = 1000118022,

    [NativeName("XR_TYPE_PASSTHROUGH_BRIGHTNESS_CONTRAST_SATURATION_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_passthrough"])]
    PassthroughBrightnessContrastSaturationFB = 1000118023,

    [NativeName("XR_TYPE_EVENT_DATA_PASSTHROUGH_STATE_CHANGED_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_passthrough"])]
    EventDataPassthroughStateChangedFB = 1000118030,

    [NativeName("XR_TYPE_RENDER_MODEL_PATH_INFO_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_render_model"])]
    RenderModelPathInfoFB = 1000119000,

    [NativeName("XR_TYPE_RENDER_MODEL_PROPERTIES_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_render_model"])]
    RenderModelPropertiesFB = 1000119001,

    [NativeName("XR_TYPE_RENDER_MODEL_BUFFER_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_render_model"])]
    RenderModelBufferFB = 1000119002,

    [NativeName("XR_TYPE_RENDER_MODEL_LOAD_INFO_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_render_model"])]
    RenderModelLoadInfoFB = 1000119003,

    [NativeName("XR_TYPE_SYSTEM_RENDER_MODEL_PROPERTIES_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_render_model"])]
    SystemRenderModelPropertiesFB = 1000119004,

    [NativeName("XR_TYPE_RENDER_MODEL_CAPABILITIES_REQUEST_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_render_model"])]
    RenderModelCapabilitiesRequestFB = 1000119005,

    [NativeName("XR_TYPE_BINDING_MODIFICATIONS_KHR")]
    [SupportedApiProfile("openxr", ["XR_KHR_binding_modification"])]
    BindingModificationsKHR = 1000120000,

    [NativeName("XR_TYPE_VIEW_LOCATE_FOVEATED_RENDERING_VARJO")]
    [SupportedApiProfile(
        "openxr",
        ["XR_VARJO_foveated_rendering"],
        ImpliesSets = ["XR_VARJO_quad_views", "XR_VERSION_1_0"]
    )]
    ViewLocateFoveatedRenderingVARJO = 1000121000,

    [NativeName("XR_TYPE_FOVEATED_VIEW_CONFIGURATION_VIEW_VARJO")]
    [SupportedApiProfile(
        "openxr",
        ["XR_VARJO_foveated_rendering"],
        ImpliesSets = ["XR_VARJO_quad_views", "XR_VERSION_1_0"]
    )]
    FoveatedViewConfigurationViewVARJO = 1000121001,

    [NativeName("XR_TYPE_SYSTEM_FOVEATED_RENDERING_PROPERTIES_VARJO")]
    [SupportedApiProfile(
        "openxr",
        ["XR_VARJO_foveated_rendering"],
        ImpliesSets = ["XR_VARJO_quad_views", "XR_VERSION_1_0"]
    )]
    SystemFoveatedRenderingPropertiesVARJO = 1000121002,

    [NativeName("XR_TYPE_COMPOSITION_LAYER_DEPTH_TEST_VARJO")]
    [SupportedApiProfile(
        "openxr",
        ["XR_VARJO_composition_layer_depth_test"],
        ImpliesSets = ["XR_KHR_composition_layer_depth", "XR_VERSION_1_0"]
    )]
    CompositionLayerDepthTestVARJO = 1000122000,

    [NativeName("XR_TYPE_SYSTEM_MARKER_TRACKING_PROPERTIES_VARJO")]
    [SupportedApiProfile("openxr", ["XR_VARJO_marker_tracking"])]
    SystemMarkerTrackingPropertiesVARJO = 1000124000,

    [NativeName("XR_TYPE_EVENT_DATA_MARKER_TRACKING_UPDATE_VARJO")]
    [SupportedApiProfile("openxr", ["XR_VARJO_marker_tracking"])]
    EventDataMarkerTrackingUpdateVARJO = 1000124001,

    [NativeName("XR_TYPE_MARKER_SPACE_CREATE_INFO_VARJO")]
    [SupportedApiProfile("openxr", ["XR_VARJO_marker_tracking"])]
    MarkerSpaceCreateInfoVARJO = 1000124002,

    [NativeName("XR_TYPE_FRAME_END_INFO_ML")]
    [SupportedApiProfile("openxr", ["XR_ML_frame_end_info"])]
    FrameEndInfoML = 1000135000,

    [NativeName("XR_TYPE_GLOBAL_DIMMER_FRAME_END_INFO_ML")]
    [SupportedApiProfile("openxr", ["XR_ML_global_dimmer"])]
    GlobalDimmerFrameEndInfoML = 1000136000,

    [NativeName("XR_TYPE_COORDINATE_SPACE_CREATE_INFO_ML")]
    [SupportedApiProfile("openxr", ["XR_ML_compat"])]
    CoordinateSpaceCreateInfoML = 1000137000,

    [NativeName("XR_TYPE_SYSTEM_MARKER_UNDERSTANDING_PROPERTIES_ML")]
    [SupportedApiProfile("openxr", ["XR_ML_marker_understanding"])]
    SystemMarkerUnderstandingPropertiesML = 1000138000,

    [NativeName("XR_TYPE_MARKER_DETECTOR_CREATE_INFO_ML")]
    [SupportedApiProfile("openxr", ["XR_ML_marker_understanding"])]
    MarkerDetectorCreateInfoML = 1000138001,

    [NativeName("XR_TYPE_MARKER_DETECTOR_ARUCO_INFO_ML")]
    [SupportedApiProfile("openxr", ["XR_ML_marker_understanding"])]
    MarkerDetectorArucoInfoML = 1000138002,

    [NativeName("XR_TYPE_MARKER_DETECTOR_SIZE_INFO_ML")]
    [SupportedApiProfile("openxr", ["XR_ML_marker_understanding"])]
    MarkerDetectorSizeInfoML = 1000138003,

    [NativeName("XR_TYPE_MARKER_DETECTOR_APRIL_TAG_INFO_ML")]
    [SupportedApiProfile("openxr", ["XR_ML_marker_understanding"])]
    MarkerDetectorAprilTagInfoML = 1000138004,

    [NativeName("XR_TYPE_MARKER_DETECTOR_CUSTOM_PROFILE_INFO_ML")]
    [SupportedApiProfile("openxr", ["XR_ML_marker_understanding"])]
    MarkerDetectorCustomProfileInfoML = 1000138005,

    [NativeName("XR_TYPE_MARKER_DETECTOR_SNAPSHOT_INFO_ML")]
    [SupportedApiProfile("openxr", ["XR_ML_marker_understanding"])]
    MarkerDetectorSnapshotInfoML = 1000138006,

    [NativeName("XR_TYPE_MARKER_DETECTOR_STATE_ML")]
    [SupportedApiProfile("openxr", ["XR_ML_marker_understanding"])]
    MarkerDetectorStateML = 1000138007,

    [NativeName("XR_TYPE_MARKER_SPACE_CREATE_INFO_ML")]
    [SupportedApiProfile("openxr", ["XR_ML_marker_understanding"])]
    MarkerSpaceCreateInfoML = 1000138008,

    [NativeName("XR_TYPE_LOCALIZATION_MAP_ML")]
    [SupportedApiProfile(
        "openxr",
        ["XR_ML_localization_map"],
        ImpliesSets = ["XR_EXT_uuid", "XR_VERSION_1_0"]
    )]
    LocalizationMapML = 1000139000,

    [NativeName("XR_TYPE_EVENT_DATA_LOCALIZATION_CHANGED_ML")]
    [SupportedApiProfile(
        "openxr",
        ["XR_ML_localization_map"],
        ImpliesSets = ["XR_EXT_uuid", "XR_VERSION_1_0"]
    )]
    EventDataLocalizationChangedML = 1000139001,

    [NativeName("XR_TYPE_MAP_LOCALIZATION_REQUEST_INFO_ML")]
    [SupportedApiProfile(
        "openxr",
        ["XR_ML_localization_map"],
        ImpliesSets = ["XR_EXT_uuid", "XR_VERSION_1_0"]
    )]
    MapLocalizationRequestInfoML = 1000139002,

    [NativeName("XR_TYPE_LOCALIZATION_MAP_IMPORT_INFO_ML")]
    [SupportedApiProfile(
        "openxr",
        ["XR_ML_localization_map"],
        ImpliesSets = ["XR_EXT_uuid", "XR_VERSION_1_0"]
    )]
    LocalizationMapImportInfoML = 1000139003,

    [NativeName("XR_TYPE_LOCALIZATION_ENABLE_EVENTS_INFO_ML")]
    [SupportedApiProfile(
        "openxr",
        ["XR_ML_localization_map"],
        ImpliesSets = ["XR_EXT_uuid", "XR_VERSION_1_0"]
    )]
    LocalizationEnableEventsInfoML = 1000139004,

    [NativeName("XR_TYPE_SPATIAL_ANCHORS_CREATE_INFO_FROM_POSE_ML")]
    [SupportedApiProfile("openxr", ["XR_ML_spatial_anchors"], ImpliesSets = ["XR_EXT_future"])]
    SpatialAnchorsCreateInfoFromPoseML = 1000140000,

    [NativeName("XR_TYPE_CREATE_SPATIAL_ANCHORS_COMPLETION_ML")]
    [SupportedApiProfile("openxr", ["XR_ML_spatial_anchors"], ImpliesSets = ["XR_EXT_future"])]
    CreateSpatialAnchorsCompletionML = 1000140001,

    [NativeName("XR_TYPE_SPATIAL_ANCHOR_STATE_ML")]
    [SupportedApiProfile("openxr", ["XR_ML_spatial_anchors"], ImpliesSets = ["XR_EXT_future"])]
    SpatialAnchorStateML = 1000140002,

    [NativeName("XR_TYPE_SPATIAL_ANCHORS_CREATE_STORAGE_INFO_ML")]
    [SupportedApiProfile(
        "openxr",
        ["XR_ML_spatial_anchors_storage"],
        ImpliesSets = ["XR_EXT_future", "XR_ML_spatial_anchors"]
    )]
    SpatialAnchorsCreateStorageInfoML = 1000141000,

    [NativeName("XR_TYPE_SPATIAL_ANCHORS_QUERY_INFO_RADIUS_ML")]
    [SupportedApiProfile(
        "openxr",
        ["XR_ML_spatial_anchors_storage"],
        ImpliesSets = ["XR_EXT_future", "XR_ML_spatial_anchors"]
    )]
    SpatialAnchorsQueryInfoRadiusML = 1000141001,

    [NativeName("XR_TYPE_SPATIAL_ANCHORS_QUERY_COMPLETION_ML")]
    [SupportedApiProfile(
        "openxr",
        ["XR_ML_spatial_anchors_storage"],
        ImpliesSets = ["XR_EXT_future", "XR_ML_spatial_anchors"]
    )]
    SpatialAnchorsQueryCompletionML = 1000141002,

    [NativeName("XR_TYPE_SPATIAL_ANCHORS_CREATE_INFO_FROM_UUIDS_ML")]
    [SupportedApiProfile(
        "openxr",
        ["XR_ML_spatial_anchors_storage"],
        ImpliesSets = ["XR_EXT_future", "XR_ML_spatial_anchors"]
    )]
    SpatialAnchorsCreateInfoFromUuidsML = 1000141003,

    [NativeName("XR_TYPE_SPATIAL_ANCHORS_PUBLISH_INFO_ML")]
    [SupportedApiProfile(
        "openxr",
        ["XR_ML_spatial_anchors_storage"],
        ImpliesSets = ["XR_EXT_future", "XR_ML_spatial_anchors"]
    )]
    SpatialAnchorsPublishInfoML = 1000141004,

    [NativeName("XR_TYPE_SPATIAL_ANCHORS_PUBLISH_COMPLETION_ML")]
    [SupportedApiProfile(
        "openxr",
        ["XR_ML_spatial_anchors_storage"],
        ImpliesSets = ["XR_EXT_future", "XR_ML_spatial_anchors"]
    )]
    SpatialAnchorsPublishCompletionML = 1000141005,

    [NativeName("XR_TYPE_SPATIAL_ANCHORS_DELETE_INFO_ML")]
    [SupportedApiProfile(
        "openxr",
        ["XR_ML_spatial_anchors_storage"],
        ImpliesSets = ["XR_EXT_future", "XR_ML_spatial_anchors"]
    )]
    SpatialAnchorsDeleteInfoML = 1000141006,

    [NativeName("XR_TYPE_SPATIAL_ANCHORS_DELETE_COMPLETION_ML")]
    [SupportedApiProfile(
        "openxr",
        ["XR_ML_spatial_anchors_storage"],
        ImpliesSets = ["XR_EXT_future", "XR_ML_spatial_anchors"]
    )]
    SpatialAnchorsDeleteCompletionML = 1000141007,

    [NativeName("XR_TYPE_SPATIAL_ANCHORS_UPDATE_EXPIRATION_INFO_ML")]
    [SupportedApiProfile(
        "openxr",
        ["XR_ML_spatial_anchors_storage"],
        ImpliesSets = ["XR_EXT_future", "XR_ML_spatial_anchors"]
    )]
    SpatialAnchorsUpdateExpirationInfoML = 1000141008,

    [NativeName("XR_TYPE_SPATIAL_ANCHORS_UPDATE_EXPIRATION_COMPLETION_ML")]
    [SupportedApiProfile(
        "openxr",
        ["XR_ML_spatial_anchors_storage"],
        ImpliesSets = ["XR_EXT_future", "XR_ML_spatial_anchors"]
    )]
    SpatialAnchorsUpdateExpirationCompletionML = 1000141009,

    [NativeName("XR_TYPE_SPATIAL_ANCHORS_PUBLISH_COMPLETION_DETAILS_ML")]
    [SupportedApiProfile(
        "openxr",
        ["XR_ML_spatial_anchors_storage"],
        ImpliesSets = ["XR_EXT_future", "XR_ML_spatial_anchors"]
    )]
    SpatialAnchorsPublishCompletionDetailsML = 1000141010,

    [NativeName("XR_TYPE_SPATIAL_ANCHORS_DELETE_COMPLETION_DETAILS_ML")]
    [SupportedApiProfile(
        "openxr",
        ["XR_ML_spatial_anchors_storage"],
        ImpliesSets = ["XR_EXT_future", "XR_ML_spatial_anchors"]
    )]
    SpatialAnchorsDeleteCompletionDetailsML = 1000141011,

    [NativeName("XR_TYPE_SPATIAL_ANCHORS_UPDATE_EXPIRATION_COMPLETION_DETAILS_ML")]
    [SupportedApiProfile(
        "openxr",
        ["XR_ML_spatial_anchors_storage"],
        ImpliesSets = ["XR_EXT_future", "XR_ML_spatial_anchors"]
    )]
    SpatialAnchorsUpdateExpirationCompletionDetailsML = 1000141012,

    [NativeName("XR_TYPE_EVENT_DATA_HEADSET_FIT_CHANGED_ML")]
    [SupportedApiProfile("openxr", ["XR_ML_user_calibration"])]
    EventDataHeadsetFitChangedML = 1000472000,

    [NativeName("XR_TYPE_EVENT_DATA_EYE_CALIBRATION_CHANGED_ML")]
    [SupportedApiProfile("openxr", ["XR_ML_user_calibration"])]
    EventDataEyeCalibrationChangedML = 1000472001,

    [NativeName("XR_TYPE_USER_CALIBRATION_ENABLE_EVENTS_INFO_ML")]
    [SupportedApiProfile("openxr", ["XR_ML_user_calibration"])]
    UserCalibrationEnableEventsInfoML = 1000472002,

    [NativeName("XR_TYPE_SPATIAL_ANCHOR_PERSISTENCE_INFO_MSFT")]
    [SupportedApiProfile(
        "openxr",
        ["XR_MSFT_spatial_anchor_persistence"],
        ImpliesSets = ["XR_MSFT_spatial_anchor", "XR_VERSION_1_0"]
    )]
    SpatialAnchorPersistenceInfoMSFT = 1000142000,

    [NativeName("XR_TYPE_SPATIAL_ANCHOR_FROM_PERSISTED_ANCHOR_CREATE_INFO_MSFT")]
    [SupportedApiProfile(
        "openxr",
        ["XR_MSFT_spatial_anchor_persistence"],
        ImpliesSets = ["XR_MSFT_spatial_anchor", "XR_VERSION_1_0"]
    )]
    SpatialAnchorFromPersistedAnchorCreateInfoMSFT = 1000142001,

    [NativeName("XR_TYPE_SCENE_MARKERS_MSFT")]
    [SupportedApiProfile(
        "openxr",
        ["XR_MSFT_scene_marker"],
        ImpliesSets = ["XR_MSFT_scene_understanding", "XR_VERSION_1_0"]
    )]
    SceneMarkersMSFT = 1000147000,

    [NativeName("XR_TYPE_SCENE_MARKER_TYPE_FILTER_MSFT")]
    [SupportedApiProfile(
        "openxr",
        ["XR_MSFT_scene_marker"],
        ImpliesSets = ["XR_MSFT_scene_understanding", "XR_VERSION_1_0"]
    )]
    SceneMarkerTypeFilterMSFT = 1000147001,

    [NativeName("XR_TYPE_SCENE_MARKER_QR_CODES_MSFT")]
    [SupportedApiProfile(
        "openxr",
        ["XR_MSFT_scene_marker"],
        ImpliesSets = ["XR_MSFT_scene_understanding", "XR_VERSION_1_0"]
    )]
    SceneMarkerQrCodesMSFT = 1000147002,

    [NativeName("XR_TYPE_SPACE_QUERY_INFO_FB")]
    [SupportedApiProfile(
        "openxr",
        ["XR_FB_spatial_entity_query"],
        ImpliesSets = ["XR_FB_spatial_entity_storage", "XR_VERSION_1_0"]
    )]
    SpaceQueryInfoFB = 1000156001,

    [NativeName("XR_TYPE_SPACE_QUERY_RESULTS_FB")]
    [SupportedApiProfile(
        "openxr",
        ["XR_FB_spatial_entity_query"],
        ImpliesSets = ["XR_FB_spatial_entity_storage", "XR_VERSION_1_0"]
    )]
    SpaceQueryResultsFB = 1000156002,

    [NativeName("XR_TYPE_SPACE_STORAGE_LOCATION_FILTER_INFO_FB")]
    [SupportedApiProfile(
        "openxr",
        ["XR_FB_spatial_entity_query"],
        ImpliesSets = ["XR_FB_spatial_entity_storage", "XR_VERSION_1_0"]
    )]
    SpaceStorageLocationFilterInfoFB = 1000156003,

    [NativeName("XR_TYPE_SPACE_UUID_FILTER_INFO_FB")]
    [SupportedApiProfile(
        "openxr",
        ["XR_FB_spatial_entity_query"],
        ImpliesSets = ["XR_FB_spatial_entity_storage", "XR_VERSION_1_0"]
    )]
    SpaceUuidFilterInfoFB = 1000156054,

    [NativeName("XR_TYPE_SPACE_COMPONENT_FILTER_INFO_FB")]
    [SupportedApiProfile(
        "openxr",
        ["XR_FB_spatial_entity_query"],
        ImpliesSets = ["XR_FB_spatial_entity_storage", "XR_VERSION_1_0"]
    )]
    SpaceComponentFilterInfoFB = 1000156052,

    [NativeName("XR_TYPE_EVENT_DATA_SPACE_QUERY_RESULTS_AVAILABLE_FB")]
    [SupportedApiProfile(
        "openxr",
        ["XR_FB_spatial_entity_query"],
        ImpliesSets = ["XR_FB_spatial_entity_storage", "XR_VERSION_1_0"]
    )]
    EventDataSpaceQueryResultsAvailableFB = 1000156103,

    [NativeName("XR_TYPE_EVENT_DATA_SPACE_QUERY_COMPLETE_FB")]
    [SupportedApiProfile(
        "openxr",
        ["XR_FB_spatial_entity_query"],
        ImpliesSets = ["XR_FB_spatial_entity_storage", "XR_VERSION_1_0"]
    )]
    EventDataSpaceQueryCompleteFB = 1000156104,

    [NativeName("XR_TYPE_SPACE_SAVE_INFO_FB")]
    [SupportedApiProfile(
        "openxr",
        ["XR_FB_spatial_entity_storage"],
        ImpliesSets = ["XR_FB_spatial_entity", "XR_VERSION_1_0"]
    )]
    SpaceSaveInfoFB = 1000158000,

    [NativeName("XR_TYPE_SPACE_ERASE_INFO_FB")]
    [SupportedApiProfile(
        "openxr",
        ["XR_FB_spatial_entity_storage"],
        ImpliesSets = ["XR_FB_spatial_entity", "XR_VERSION_1_0"]
    )]
    SpaceEraseInfoFB = 1000158001,

    [NativeName("XR_TYPE_EVENT_DATA_SPACE_SAVE_COMPLETE_FB")]
    [SupportedApiProfile(
        "openxr",
        ["XR_FB_spatial_entity_storage"],
        ImpliesSets = ["XR_FB_spatial_entity", "XR_VERSION_1_0"]
    )]
    EventDataSpaceSaveCompleteFB = 1000158106,

    [NativeName("XR_TYPE_EVENT_DATA_SPACE_ERASE_COMPLETE_FB")]
    [SupportedApiProfile(
        "openxr",
        ["XR_FB_spatial_entity_storage"],
        ImpliesSets = ["XR_FB_spatial_entity", "XR_VERSION_1_0"]
    )]
    EventDataSpaceEraseCompleteFB = 1000158107,

    [NativeName("XR_TYPE_SWAPCHAIN_IMAGE_FOVEATION_VULKAN_FB")]
    [SupportedApiProfile(
        "openxr",
        ["XR_FB_foveation_vulkan"],
        ImpliesSets = ["XR_FB_foveation", "XR_VERSION_1_0"]
    )]
    SwapchainImageFoveationVulkanFB = 1000160000,

    [NativeName("XR_TYPE_SWAPCHAIN_STATE_ANDROID_SURFACE_DIMENSIONS_FB")]
    [SupportedApiProfile(
        "openxr",
        ["XR_FB_swapchain_update_state_android_surface"],
        ImpliesSets = [
            "XR_FB_swapchain_update_state",
            "XR_KHR_android_surface_swapchain",
            "XR_VERSION_1_0",
        ]
    )]
    SwapchainStateAndroidSurfaceDimensionsFB = 1000161000,

    [NativeName("XR_TYPE_SWAPCHAIN_STATE_SAMPLER_OPENGL_ES_FB")]
    [SupportedApiProfile(
        "openxr",
        ["XR_FB_swapchain_update_state_opengl_es"],
        ImpliesSets = ["XR_FB_swapchain_update_state", "XR_KHR_opengl_es_enable"]
    )]
    SwapchainStateSamplerOpenglEsFB = 1000162000,

    [NativeName("XR_TYPE_SWAPCHAIN_STATE_SAMPLER_VULKAN_FB")]
    [SupportedApiProfile(
        "openxr",
        ["XR_FB_swapchain_update_state_vulkan"],
        ImpliesSets = ["XR_FB_swapchain_update_state", "XR_KHR_vulkan_enable", "XR_VERSION_1_0"]
    )]
    SwapchainStateSamplerVulkanFB = 1000163000,

    [NativeName("XR_TYPE_SPACE_SHARE_INFO_FB")]
    [SupportedApiProfile(
        "openxr",
        ["XR_FB_spatial_entity_sharing"],
        ImpliesSets = ["XR_FB_spatial_entity", "XR_VERSION_1_0"]
    )]
    SpaceShareInfoFB = 1000169001,

    [NativeName("XR_TYPE_EVENT_DATA_SPACE_SHARE_COMPLETE_FB")]
    [SupportedApiProfile(
        "openxr",
        ["XR_FB_spatial_entity_sharing"],
        ImpliesSets = ["XR_FB_spatial_entity", "XR_VERSION_1_0"]
    )]
    EventDataSpaceShareCompleteFB = 1000169002,

    [NativeName("XR_TYPE_COMPOSITION_LAYER_SPACE_WARP_INFO_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_space_warp"])]
    CompositionLayerSpaceWarpInfoFB = 1000171000,

    [NativeName("XR_TYPE_SYSTEM_SPACE_WARP_PROPERTIES_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_space_warp"])]
    SystemSpaceWarpPropertiesFB = 1000171001,

    [NativeName("XR_TYPE_HAPTIC_AMPLITUDE_ENVELOPE_VIBRATION_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_haptic_amplitude_envelope"])]
    HapticAmplitudeEnvelopeVibrationFB = 1000173001,

    [NativeName("XR_TYPE_SEMANTIC_LABELS_FB")]
    [SupportedApiProfile(
        "openxr",
        ["XR_FB_scene"],
        ImpliesSets = ["XR_FB_spatial_entity", "XR_VERSION_1_0"]
    )]
    SemanticLabelsFB = 1000175000,

    [NativeName("XR_TYPE_ROOM_LAYOUT_FB")]
    [SupportedApiProfile(
        "openxr",
        ["XR_FB_scene"],
        ImpliesSets = ["XR_FB_spatial_entity", "XR_VERSION_1_0"]
    )]
    RoomLayoutFB = 1000175001,

    [NativeName("XR_TYPE_BOUNDARY_2D_FB")]
    [SupportedApiProfile(
        "openxr",
        ["XR_FB_scene"],
        ImpliesSets = ["XR_FB_spatial_entity", "XR_VERSION_1_0"]
    )]
    Boundary2DFB = 1000175002,

    [NativeName("XR_TYPE_SEMANTIC_LABELS_SUPPORT_INFO_FB")]
    [SupportedApiProfile(
        "openxr",
        ["XR_FB_scene"],
        ImpliesSets = ["XR_FB_spatial_entity", "XR_VERSION_1_0"]
    )]
    SemanticLabelsSupportInfoFB = 1000175010,

    [NativeName("XR_TYPE_DIGITAL_LENS_CONTROL_ALMALENCE")]
    [SupportedApiProfile("openxr", ["XR_ALMALENCE_digital_lens_control"])]
    DigitalLensControlALMALENCE = 1000196000,

    [NativeName("XR_TYPE_EVENT_DATA_SCENE_CAPTURE_COMPLETE_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_scene_capture"])]
    EventDataSceneCaptureCompleteFB = 1000198001,

    [NativeName("XR_TYPE_SCENE_CAPTURE_REQUEST_INFO_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_scene_capture"])]
    SceneCaptureRequestInfoFB = 1000198050,

    [NativeName("XR_TYPE_SPACE_CONTAINER_FB")]
    [SupportedApiProfile(
        "openxr",
        ["XR_FB_spatial_entity_container"],
        ImpliesSets = ["XR_FB_spatial_entity", "XR_VERSION_1_0"]
    )]
    SpaceContainerFB = 1000199000,

    [NativeName("XR_TYPE_FOVEATION_EYE_TRACKED_PROFILE_CREATE_INFO_META")]
    [SupportedApiProfile(
        "openxr",
        ["XR_META_foveation_eye_tracked"],
        ImpliesSets = ["XR_FB_foveation", "XR_FB_foveation_configuration", "XR_VERSION_1_0"]
    )]
    FoveationEyeTrackedProfileCreateInfoMETA = 1000200000,

    [NativeName("XR_TYPE_FOVEATION_EYE_TRACKED_STATE_META")]
    [SupportedApiProfile(
        "openxr",
        ["XR_META_foveation_eye_tracked"],
        ImpliesSets = ["XR_FB_foveation", "XR_FB_foveation_configuration", "XR_VERSION_1_0"]
    )]
    FoveationEyeTrackedStateMETA = 1000200001,

    [NativeName("XR_TYPE_SYSTEM_FOVEATION_EYE_TRACKED_PROPERTIES_META")]
    [SupportedApiProfile(
        "openxr",
        ["XR_META_foveation_eye_tracked"],
        ImpliesSets = ["XR_FB_foveation", "XR_FB_foveation_configuration", "XR_VERSION_1_0"]
    )]
    SystemFoveationEyeTrackedPropertiesMETA = 1000200002,

    [NativeName("XR_TYPE_SYSTEM_FACE_TRACKING_PROPERTIES_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_face_tracking"])]
    SystemFaceTrackingPropertiesFB = 1000201004,

    [NativeName("XR_TYPE_FACE_TRACKER_CREATE_INFO_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_face_tracking"])]
    FaceTrackerCreateInfoFB = 1000201005,

    [NativeName("XR_TYPE_FACE_EXPRESSION_INFO_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_face_tracking"])]
    FaceExpressionInfoFB = 1000201002,

    [NativeName("XR_TYPE_FACE_EXPRESSION_WEIGHTS_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_face_tracking"])]
    FaceExpressionWeightsFB = 1000201006,

    [NativeName("XR_TYPE_EYE_TRACKER_CREATE_INFO_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_eye_tracking_social"])]
    EyeTrackerCreateInfoFB = 1000202001,

    [NativeName("XR_TYPE_EYE_GAZES_INFO_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_eye_tracking_social"])]
    EyeGazesInfoFB = 1000202002,

    [NativeName("XR_TYPE_EYE_GAZES_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_eye_tracking_social"])]
    EyeGazesFB = 1000202003,

    [NativeName("XR_TYPE_SYSTEM_EYE_TRACKING_PROPERTIES_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_eye_tracking_social"])]
    SystemEyeTrackingPropertiesFB = 1000202004,

    [NativeName("XR_TYPE_PASSTHROUGH_KEYBOARD_HANDS_INTENSITY_FB")]
    [SupportedApiProfile(
        "openxr",
        ["XR_FB_passthrough_keyboard_hands"],
        ImpliesSets = ["XR_FB_passthrough", "XR_VERSION_1_0"]
    )]
    PassthroughKeyboardHandsIntensityFB = 1000203002,

    [NativeName("XR_TYPE_COMPOSITION_LAYER_SETTINGS_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_composition_layer_settings"])]
    CompositionLayerSettingsFB = 1000204000,

    [NativeName("XR_TYPE_HAPTIC_PCM_VIBRATION_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_haptic_pcm"])]
    HapticPcmVibrationFB = 1000209001,

    [NativeName("XR_TYPE_DEVICE_PCM_SAMPLE_RATE_STATE_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_haptic_pcm"])]
    DevicePcmSampleRateStateFB = 1000209002,

    [NativeName("XR_TYPE_FRAME_SYNTHESIS_INFO_EXT")]
    [SupportedApiProfile("openxr", ["XR_EXT_frame_synthesis"])]
    FrameSynthesisInfoEXT = 1000211000,

    [NativeName("XR_TYPE_FRAME_SYNTHESIS_CONFIG_VIEW_EXT")]
    [SupportedApiProfile("openxr", ["XR_EXT_frame_synthesis"])]
    FrameSynthesisConfigViewEXT = 1000211001,

    [NativeName("XR_TYPE_COMPOSITION_LAYER_DEPTH_TEST_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_composition_layer_depth_test"])]
    CompositionLayerDepthTestFB = 1000212000,

    [NativeName("XR_TYPE_LOCAL_DIMMING_FRAME_END_INFO_META")]
    [SupportedApiProfile("openxr", ["XR_META_local_dimming"])]
    LocalDimmingFrameEndInfoMETA = 1000216000,

    [NativeName("XR_TYPE_PASSTHROUGH_PREFERENCES_META")]
    [SupportedApiProfile("openxr", ["XR_META_passthrough_preferences"])]
    PassthroughPreferencesMETA = 1000217000,

    [NativeName("XR_TYPE_SYSTEM_VIRTUAL_KEYBOARD_PROPERTIES_META")]
    [SupportedApiProfile("openxr", ["XR_META_virtual_keyboard"])]
    SystemVirtualKeyboardPropertiesMETA = 1000219001,

    [NativeName("XR_TYPE_VIRTUAL_KEYBOARD_CREATE_INFO_META")]
    [SupportedApiProfile("openxr", ["XR_META_virtual_keyboard"])]
    VirtualKeyboardCreateInfoMETA = 1000219002,

    [NativeName("XR_TYPE_VIRTUAL_KEYBOARD_SPACE_CREATE_INFO_META")]
    [SupportedApiProfile("openxr", ["XR_META_virtual_keyboard"])]
    VirtualKeyboardSpaceCreateInfoMETA = 1000219003,

    [NativeName("XR_TYPE_VIRTUAL_KEYBOARD_LOCATION_INFO_META")]
    [SupportedApiProfile("openxr", ["XR_META_virtual_keyboard"])]
    VirtualKeyboardLocationInfoMETA = 1000219004,

    [NativeName("XR_TYPE_VIRTUAL_KEYBOARD_MODEL_VISIBILITY_SET_INFO_META")]
    [SupportedApiProfile("openxr", ["XR_META_virtual_keyboard"])]
    VirtualKeyboardModelVisibilitySetInfoMETA = 1000219005,

    [NativeName("XR_TYPE_VIRTUAL_KEYBOARD_ANIMATION_STATE_META")]
    [SupportedApiProfile("openxr", ["XR_META_virtual_keyboard"])]
    VirtualKeyboardAnimationStateMETA = 1000219006,

    [NativeName("XR_TYPE_VIRTUAL_KEYBOARD_MODEL_ANIMATION_STATES_META")]
    [SupportedApiProfile("openxr", ["XR_META_virtual_keyboard"])]
    VirtualKeyboardModelAnimationStatesMETA = 1000219007,

    [NativeName("XR_TYPE_VIRTUAL_KEYBOARD_TEXTURE_DATA_META")]
    [SupportedApiProfile("openxr", ["XR_META_virtual_keyboard"])]
    VirtualKeyboardTextureDataMETA = 1000219009,

    [NativeName("XR_TYPE_VIRTUAL_KEYBOARD_INPUT_INFO_META")]
    [SupportedApiProfile("openxr", ["XR_META_virtual_keyboard"])]
    VirtualKeyboardInputInfoMETA = 1000219010,

    [NativeName("XR_TYPE_VIRTUAL_KEYBOARD_TEXT_CONTEXT_CHANGE_INFO_META")]
    [SupportedApiProfile("openxr", ["XR_META_virtual_keyboard"])]
    VirtualKeyboardTextContextChangeInfoMETA = 1000219011,

    [NativeName("XR_TYPE_EVENT_DATA_VIRTUAL_KEYBOARD_COMMIT_TEXT_META")]
    [SupportedApiProfile("openxr", ["XR_META_virtual_keyboard"])]
    EventDataVirtualKeyboardCommitTextMETA = 1000219014,

    [NativeName("XR_TYPE_EVENT_DATA_VIRTUAL_KEYBOARD_BACKSPACE_META")]
    [SupportedApiProfile("openxr", ["XR_META_virtual_keyboard"])]
    EventDataVirtualKeyboardBackspaceMETA = 1000219015,

    [NativeName("XR_TYPE_EVENT_DATA_VIRTUAL_KEYBOARD_ENTER_META")]
    [SupportedApiProfile("openxr", ["XR_META_virtual_keyboard"])]
    EventDataVirtualKeyboardEnterMETA = 1000219016,

    [NativeName("XR_TYPE_EVENT_DATA_VIRTUAL_KEYBOARD_SHOWN_META")]
    [SupportedApiProfile("openxr", ["XR_META_virtual_keyboard"])]
    EventDataVirtualKeyboardShownMETA = 1000219017,

    [NativeName("XR_TYPE_EVENT_DATA_VIRTUAL_KEYBOARD_HIDDEN_META")]
    [SupportedApiProfile("openxr", ["XR_META_virtual_keyboard"])]
    EventDataVirtualKeyboardHiddenMETA = 1000219018,

    [NativeName("XR_TYPE_EXTERNAL_CAMERA_OCULUS")]
    [SupportedApiProfile("openxr", ["XR_OCULUS_external_camera"])]
    ExternalCameraOCULUS = 1000226000,

    [NativeName("XR_TYPE_VULKAN_SWAPCHAIN_CREATE_INFO_META")]
    [SupportedApiProfile("openxr", ["XR_META_vulkan_swapchain_create_info"])]
    VulkanSwapchainCreateInfoMETA = 1000227000,

    [NativeName("XR_TYPE_PERFORMANCE_METRICS_STATE_META")]
    [SupportedApiProfile("openxr", ["XR_META_performance_metrics"])]
    PerformanceMetricsStateMETA = 1000232001,

    [NativeName("XR_TYPE_PERFORMANCE_METRICS_COUNTER_META")]
    [SupportedApiProfile("openxr", ["XR_META_performance_metrics"])]
    PerformanceMetricsCounterMETA = 1000232002,

    [NativeName("XR_TYPE_SPACE_LIST_SAVE_INFO_FB")]
    [SupportedApiProfile(
        "openxr",
        ["XR_FB_spatial_entity_storage_batch"],
        ImpliesSets = ["XR_FB_spatial_entity_storage", "XR_VERSION_1_0"]
    )]
    SpaceListSaveInfoFB = 1000238000,

    [NativeName("XR_TYPE_EVENT_DATA_SPACE_LIST_SAVE_COMPLETE_FB")]
    [SupportedApiProfile(
        "openxr",
        ["XR_FB_spatial_entity_storage_batch"],
        ImpliesSets = ["XR_FB_spatial_entity_storage", "XR_VERSION_1_0"]
    )]
    EventDataSpaceListSaveCompleteFB = 1000238001,

    [NativeName("XR_TYPE_SPACE_USER_CREATE_INFO_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_spatial_entity_user"])]
    SpaceUserCreateInfoFB = 1000241001,

    [NativeName("XR_TYPE_SYSTEM_HEADSET_ID_PROPERTIES_META")]
    [SupportedApiProfile("openxr", ["XR_META_headset_id"])]
    SystemHeadsetIdPropertiesMETA = 1000245000,

    [NativeName("XR_TYPE_SYSTEM_SPACE_DISCOVERY_PROPERTIES_META")]
    [SupportedApiProfile("openxr", ["XR_META_spatial_entity_discovery"])]
    SystemSpaceDiscoveryPropertiesMETA = 1000247000,

    [NativeName("XR_TYPE_SPACE_DISCOVERY_INFO_META")]
    [SupportedApiProfile("openxr", ["XR_META_spatial_entity_discovery"])]
    SpaceDiscoveryInfoMETA = 1000247001,

    [NativeName("XR_TYPE_SPACE_FILTER_UUID_META")]
    [SupportedApiProfile("openxr", ["XR_META_spatial_entity_discovery"])]
    SpaceFilterUuidMETA = 1000247003,

    [NativeName("XR_TYPE_SPACE_FILTER_COMPONENT_META")]
    [SupportedApiProfile("openxr", ["XR_META_spatial_entity_discovery"])]
    SpaceFilterComponentMETA = 1000247004,

    [NativeName("XR_TYPE_SPACE_DISCOVERY_RESULT_META")]
    [SupportedApiProfile("openxr", ["XR_META_spatial_entity_discovery"])]
    SpaceDiscoveryResultMETA = 1000247005,

    [NativeName("XR_TYPE_SPACE_DISCOVERY_RESULTS_META")]
    [SupportedApiProfile("openxr", ["XR_META_spatial_entity_discovery"])]
    SpaceDiscoveryResultsMETA = 1000247006,

    [NativeName("XR_TYPE_EVENT_DATA_SPACE_DISCOVERY_RESULTS_AVAILABLE_META")]
    [SupportedApiProfile("openxr", ["XR_META_spatial_entity_discovery"])]
    EventDataSpaceDiscoveryResultsAvailableMETA = 1000247007,

    [NativeName("XR_TYPE_EVENT_DATA_SPACE_DISCOVERY_COMPLETE_META")]
    [SupportedApiProfile("openxr", ["XR_META_spatial_entity_discovery"])]
    EventDataSpaceDiscoveryCompleteMETA = 1000247008,

    [NativeName("XR_TYPE_RECOMMENDED_LAYER_RESOLUTION_META")]
    [SupportedApiProfile("openxr", ["XR_META_recommended_layer_resolution"])]
    RecommendedLayerResolutionMETA = 1000254000,

    [NativeName("XR_TYPE_RECOMMENDED_LAYER_RESOLUTION_GET_INFO_META")]
    [SupportedApiProfile("openxr", ["XR_META_recommended_layer_resolution"])]
    RecommendedLayerResolutionGetInfoMETA = 1000254001,

    [NativeName("XR_TYPE_SYSTEM_SPACE_PERSISTENCE_PROPERTIES_META")]
    [SupportedApiProfile("openxr", ["XR_META_spatial_entity_persistence"])]
    SystemSpacePersistencePropertiesMETA = 1000259000,

    [NativeName("XR_TYPE_SPACES_SAVE_INFO_META")]
    [SupportedApiProfile("openxr", ["XR_META_spatial_entity_persistence"])]
    SpacesSaveInfoMETA = 1000259001,

    [NativeName("XR_TYPE_EVENT_DATA_SPACES_SAVE_RESULT_META")]
    [SupportedApiProfile("openxr", ["XR_META_spatial_entity_persistence"])]
    EventDataSpacesSaveResultMETA = 1000259002,

    [NativeName("XR_TYPE_SPACES_ERASE_INFO_META")]
    [SupportedApiProfile("openxr", ["XR_META_spatial_entity_persistence"])]
    SpacesEraseInfoMETA = 1000259003,

    [NativeName("XR_TYPE_EVENT_DATA_SPACES_ERASE_RESULT_META")]
    [SupportedApiProfile("openxr", ["XR_META_spatial_entity_persistence"])]
    EventDataSpacesEraseResultMETA = 1000259004,

    [NativeName("XR_TYPE_SYSTEM_PASSTHROUGH_COLOR_LUT_PROPERTIES_META")]
    [SupportedApiProfile(
        "openxr",
        ["XR_META_passthrough_color_lut"],
        ImpliesSets = ["XR_FB_passthrough", "XR_VERSION_1_0"]
    )]
    SystemPassthroughColorLutPropertiesMETA = 1000266000,

    [NativeName("XR_TYPE_PASSTHROUGH_COLOR_LUT_CREATE_INFO_META")]
    [SupportedApiProfile(
        "openxr",
        ["XR_META_passthrough_color_lut"],
        ImpliesSets = ["XR_FB_passthrough", "XR_VERSION_1_0"]
    )]
    PassthroughColorLutCreateInfoMETA = 1000266001,

    [NativeName("XR_TYPE_PASSTHROUGH_COLOR_LUT_UPDATE_INFO_META")]
    [SupportedApiProfile(
        "openxr",
        ["XR_META_passthrough_color_lut"],
        ImpliesSets = ["XR_FB_passthrough", "XR_VERSION_1_0"]
    )]
    PassthroughColorLutUpdateInfoMETA = 1000266002,

    [NativeName("XR_TYPE_PASSTHROUGH_COLOR_MAP_LUT_META")]
    [SupportedApiProfile(
        "openxr",
        ["XR_META_passthrough_color_lut"],
        ImpliesSets = ["XR_FB_passthrough", "XR_VERSION_1_0"]
    )]
    PassthroughColorMapLutMETA = 1000266100,

    [NativeName("XR_TYPE_PASSTHROUGH_COLOR_MAP_INTERPOLATED_LUT_META")]
    [SupportedApiProfile(
        "openxr",
        ["XR_META_passthrough_color_lut"],
        ImpliesSets = ["XR_FB_passthrough", "XR_VERSION_1_0"]
    )]
    PassthroughColorMapInterpolatedLutMETA = 1000266101,

    [NativeName("XR_TYPE_SPACE_TRIANGLE_MESH_GET_INFO_META")]
    [SupportedApiProfile(
        "openxr",
        ["XR_META_spatial_entity_mesh"],
        ImpliesSets = ["XR_FB_spatial_entity", "XR_VERSION_1_0"]
    )]
    SpaceTriangleMeshGetInfoMETA = 1000269001,

    [NativeName("XR_TYPE_SPACE_TRIANGLE_MESH_META")]
    [SupportedApiProfile(
        "openxr",
        ["XR_META_spatial_entity_mesh"],
        ImpliesSets = ["XR_FB_spatial_entity", "XR_VERSION_1_0"]
    )]
    SpaceTriangleMeshMETA = 1000269002,

    [NativeName("XR_TYPE_SYSTEM_PROPERTIES_BODY_TRACKING_FULL_BODY_META")]
    [SupportedApiProfile(
        "openxr",
        ["XR_META_body_tracking_full_body"],
        ImpliesSets = ["XR_FB_body_tracking"]
    )]
    SystemPropertiesBodyTrackingFullBodyMETA = 1000274000,

    [NativeName("XR_TYPE_EVENT_DATA_PASSTHROUGH_LAYER_RESUMED_META")]
    [SupportedApiProfile(
        "openxr",
        ["XR_META_passthrough_layer_resumed_event"],
        ImpliesSets = ["XR_FB_passthrough", "XR_VERSION_1_0"]
    )]
    EventDataPassthroughLayerResumedMETA = 1000282000,

    [NativeName("XR_TYPE_BODY_TRACKING_CALIBRATION_INFO_META")]
    [SupportedApiProfile(
        "openxr",
        ["XR_META_body_tracking_calibration"],
        ImpliesSets = ["XR_FB_body_tracking"]
    )]
    BodyTrackingCalibrationInfoMETA = 1000283002,

    [NativeName("XR_TYPE_BODY_TRACKING_CALIBRATION_STATUS_META")]
    [SupportedApiProfile(
        "openxr",
        ["XR_META_body_tracking_calibration"],
        ImpliesSets = ["XR_FB_body_tracking"]
    )]
    BodyTrackingCalibrationStatusMETA = 1000283003,

    [NativeName("XR_TYPE_SYSTEM_PROPERTIES_BODY_TRACKING_CALIBRATION_META")]
    [SupportedApiProfile(
        "openxr",
        ["XR_META_body_tracking_calibration"],
        ImpliesSets = ["XR_FB_body_tracking"]
    )]
    SystemPropertiesBodyTrackingCalibrationMETA = 1000283004,

    [NativeName("XR_TYPE_BODY_TRACKING_FIDELITY_STATUS_META")]
    [SupportedApiProfile(
        "openxr",
        ["XR_META_body_tracking_fidelity"],
        ImpliesSets = ["XR_FB_body_tracking", "XR_VERSION_1_0"]
    )]
    BodyTrackingFidelityStatusMETA = 1000284000,

    [NativeName("XR_TYPE_SYSTEM_PROPERTIES_BODY_TRACKING_FIDELITY_META")]
    [SupportedApiProfile(
        "openxr",
        ["XR_META_body_tracking_fidelity"],
        ImpliesSets = ["XR_FB_body_tracking", "XR_VERSION_1_0"]
    )]
    SystemPropertiesBodyTrackingFidelityMETA = 1000284001,

    [NativeName("XR_TYPE_SYSTEM_FACE_TRACKING_PROPERTIES2_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_face_tracking2"])]
    SystemFaceTrackingProperties2FB = 1000287013,

    [NativeName("XR_TYPE_FACE_TRACKER_CREATE_INFO2_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_face_tracking2"])]
    FaceTrackerCreateInfo2FB = 1000287014,

    [NativeName("XR_TYPE_FACE_EXPRESSION_INFO2_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_face_tracking2"])]
    FaceExpressionInfo2FB = 1000287015,

    [NativeName("XR_TYPE_FACE_EXPRESSION_WEIGHTS2_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_face_tracking2"])]
    FaceExpressionWeights2FB = 1000287016,

    [NativeName("XR_TYPE_SYSTEM_SPATIAL_ENTITY_SHARING_PROPERTIES_META")]
    [SupportedApiProfile(
        "openxr",
        ["XR_META_spatial_entity_sharing"],
        ImpliesSets = ["XR_FB_spatial_entity"]
    )]
    SystemSpatialEntitySharingPropertiesMETA = 1000290000,

    [NativeName("XR_TYPE_SHARE_SPACES_INFO_META")]
    [SupportedApiProfile(
        "openxr",
        ["XR_META_spatial_entity_sharing"],
        ImpliesSets = ["XR_FB_spatial_entity"]
    )]
    ShareSpacesInfoMETA = 1000290001,

    [NativeName("XR_TYPE_EVENT_DATA_SHARE_SPACES_COMPLETE_META")]
    [SupportedApiProfile(
        "openxr",
        ["XR_META_spatial_entity_sharing"],
        ImpliesSets = ["XR_FB_spatial_entity"]
    )]
    EventDataShareSpacesCompleteMETA = 1000290002,

    [NativeName("XR_TYPE_ENVIRONMENT_DEPTH_PROVIDER_CREATE_INFO_META")]
    [SupportedApiProfile("openxr", ["XR_META_environment_depth"])]
    EnvironmentDepthProviderCreateInfoMETA = 1000291000,

    [NativeName("XR_TYPE_ENVIRONMENT_DEPTH_SWAPCHAIN_CREATE_INFO_META")]
    [SupportedApiProfile("openxr", ["XR_META_environment_depth"])]
    EnvironmentDepthSwapchainCreateInfoMETA = 1000291001,

    [NativeName("XR_TYPE_ENVIRONMENT_DEPTH_SWAPCHAIN_STATE_META")]
    [SupportedApiProfile("openxr", ["XR_META_environment_depth"])]
    EnvironmentDepthSwapchainStateMETA = 1000291002,

    [NativeName("XR_TYPE_ENVIRONMENT_DEPTH_IMAGE_ACQUIRE_INFO_META")]
    [SupportedApiProfile("openxr", ["XR_META_environment_depth"])]
    EnvironmentDepthImageAcquireInfoMETA = 1000291003,

    [NativeName("XR_TYPE_ENVIRONMENT_DEPTH_IMAGE_VIEW_META")]
    [SupportedApiProfile("openxr", ["XR_META_environment_depth"])]
    EnvironmentDepthImageViewMETA = 1000291004,

    [NativeName("XR_TYPE_ENVIRONMENT_DEPTH_IMAGE_META")]
    [SupportedApiProfile("openxr", ["XR_META_environment_depth"])]
    EnvironmentDepthImageMETA = 1000291005,

    [NativeName("XR_TYPE_ENVIRONMENT_DEPTH_HAND_REMOVAL_SET_INFO_META")]
    [SupportedApiProfile("openxr", ["XR_META_environment_depth"])]
    EnvironmentDepthHandRemovalSetInfoMETA = 1000291006,

    [NativeName("XR_TYPE_SYSTEM_ENVIRONMENT_DEPTH_PROPERTIES_META")]
    [SupportedApiProfile("openxr", ["XR_META_environment_depth"])]
    SystemEnvironmentDepthPropertiesMETA = 1000291007,

    [NativeName("XR_TYPE_ENVIRONMENT_DEPTH_IMAGE_TIMESTAMP_META")]
    [SupportedApiProfile("openxr", ["XR_META_environment_depth"])]
    EnvironmentDepthImageTimestampMETA = 1000291008,

    [NativeName("XR_TYPE_RENDER_MODEL_CREATE_INFO_EXT")]
    [SupportedApiProfile(
        "openxr",
        ["XR_EXT_render_model"],
        ImpliesSets = ["XR_EXT_render_model+XR_EXT_uuid", "XR_EXT_render_model+XR_VERSION_1_1"]
    )]
    RenderModelCreateInfoEXT = 1000300000,

    [NativeName("XR_TYPE_RENDER_MODEL_PROPERTIES_GET_INFO_EXT")]
    [SupportedApiProfile(
        "openxr",
        ["XR_EXT_render_model"],
        ImpliesSets = ["XR_EXT_render_model+XR_EXT_uuid", "XR_EXT_render_model+XR_VERSION_1_1"]
    )]
    RenderModelPropertiesGetInfoEXT = 1000300001,

    [NativeName("XR_TYPE_RENDER_MODEL_PROPERTIES_EXT")]
    [SupportedApiProfile(
        "openxr",
        ["XR_EXT_render_model"],
        ImpliesSets = ["XR_EXT_render_model+XR_EXT_uuid", "XR_EXT_render_model+XR_VERSION_1_1"]
    )]
    RenderModelPropertiesEXT = 1000300002,

    [NativeName("XR_TYPE_RENDER_MODEL_SPACE_CREATE_INFO_EXT")]
    [SupportedApiProfile(
        "openxr",
        ["XR_EXT_render_model"],
        ImpliesSets = ["XR_EXT_render_model+XR_EXT_uuid", "XR_EXT_render_model+XR_VERSION_1_1"]
    )]
    RenderModelSpaceCreateInfoEXT = 1000300003,

    [NativeName("XR_TYPE_RENDER_MODEL_STATE_GET_INFO_EXT")]
    [SupportedApiProfile(
        "openxr",
        ["XR_EXT_render_model"],
        ImpliesSets = ["XR_EXT_render_model+XR_EXT_uuid", "XR_EXT_render_model+XR_VERSION_1_1"]
    )]
    RenderModelStateGetInfoEXT = 1000300004,

    [NativeName("XR_TYPE_RENDER_MODEL_STATE_EXT")]
    [SupportedApiProfile(
        "openxr",
        ["XR_EXT_render_model"],
        ImpliesSets = ["XR_EXT_render_model+XR_EXT_uuid", "XR_EXT_render_model+XR_VERSION_1_1"]
    )]
    RenderModelStateEXT = 1000300005,

    [NativeName("XR_TYPE_RENDER_MODEL_ASSET_CREATE_INFO_EXT")]
    [SupportedApiProfile(
        "openxr",
        ["XR_EXT_render_model"],
        ImpliesSets = ["XR_EXT_render_model+XR_EXT_uuid", "XR_EXT_render_model+XR_VERSION_1_1"]
    )]
    RenderModelAssetCreateInfoEXT = 1000300006,

    [NativeName("XR_TYPE_RENDER_MODEL_ASSET_DATA_GET_INFO_EXT")]
    [SupportedApiProfile(
        "openxr",
        ["XR_EXT_render_model"],
        ImpliesSets = ["XR_EXT_render_model+XR_EXT_uuid", "XR_EXT_render_model+XR_VERSION_1_1"]
    )]
    RenderModelAssetDataGetInfoEXT = 1000300007,

    [NativeName("XR_TYPE_RENDER_MODEL_ASSET_DATA_EXT")]
    [SupportedApiProfile(
        "openxr",
        ["XR_EXT_render_model"],
        ImpliesSets = ["XR_EXT_render_model+XR_EXT_uuid", "XR_EXT_render_model+XR_VERSION_1_1"]
    )]
    RenderModelAssetDataEXT = 1000300008,

    [NativeName("XR_TYPE_RENDER_MODEL_ASSET_PROPERTIES_GET_INFO_EXT")]
    [SupportedApiProfile(
        "openxr",
        ["XR_EXT_render_model"],
        ImpliesSets = ["XR_EXT_render_model+XR_EXT_uuid", "XR_EXT_render_model+XR_VERSION_1_1"]
    )]
    RenderModelAssetPropertiesGetInfoEXT = 1000300009,

    [NativeName("XR_TYPE_RENDER_MODEL_ASSET_PROPERTIES_EXT")]
    [SupportedApiProfile(
        "openxr",
        ["XR_EXT_render_model"],
        ImpliesSets = ["XR_EXT_render_model+XR_EXT_uuid", "XR_EXT_render_model+XR_VERSION_1_1"]
    )]
    RenderModelAssetPropertiesEXT = 1000300010,

    [NativeName("XR_TYPE_INTERACTION_RENDER_MODEL_IDS_ENUMERATE_INFO_EXT")]
    [SupportedApiProfile(
        "openxr",
        ["XR_EXT_interaction_render_model"],
        ImpliesSets = ["XR_EXT_render_model"]
    )]
    InteractionRenderModelIdsEnumerateInfoEXT = 1000301000,

    [NativeName("XR_TYPE_INTERACTION_RENDER_MODEL_SUBACTION_PATH_INFO_EXT")]
    [SupportedApiProfile(
        "openxr",
        ["XR_EXT_interaction_render_model"],
        ImpliesSets = ["XR_EXT_render_model"]
    )]
    InteractionRenderModelSubactionPathInfoEXT = 1000301001,

    [NativeName("XR_TYPE_EVENT_DATA_INTERACTION_RENDER_MODELS_CHANGED_EXT")]
    [SupportedApiProfile(
        "openxr",
        ["XR_EXT_interaction_render_model"],
        ImpliesSets = ["XR_EXT_render_model"]
    )]
    EventDataInteractionRenderModelsChangedEXT = 1000301002,

    [NativeName("XR_TYPE_INTERACTION_RENDER_MODEL_TOP_LEVEL_USER_PATH_GET_INFO_EXT")]
    [SupportedApiProfile(
        "openxr",
        ["XR_EXT_interaction_render_model"],
        ImpliesSets = ["XR_EXT_render_model"]
    )]
    InteractionRenderModelTopLevelUserPathGetInfoEXT = 1000301003,

    [NativeName("XR_TYPE_PASSTHROUGH_CREATE_INFO_HTC")]
    [SupportedApiProfile("openxr", ["XR_HTC_passthrough"])]
    PassthroughCreateInfoHTC = 1000317001,

    [NativeName("XR_TYPE_PASSTHROUGH_COLOR_HTC")]
    [SupportedApiProfile("openxr", ["XR_HTC_passthrough"])]
    PassthroughColorHTC = 1000317002,

    [NativeName("XR_TYPE_PASSTHROUGH_MESH_TRANSFORM_INFO_HTC")]
    [SupportedApiProfile("openxr", ["XR_HTC_passthrough"])]
    PassthroughMeshTransformInfoHTC = 1000317003,

    [NativeName("XR_TYPE_COMPOSITION_LAYER_PASSTHROUGH_HTC")]
    [SupportedApiProfile("openxr", ["XR_HTC_passthrough"])]
    CompositionLayerPassthroughHTC = 1000317004,

    [NativeName("XR_TYPE_FOVEATION_APPLY_INFO_HTC")]
    [SupportedApiProfile("openxr", ["XR_HTC_foveation"])]
    FoveationApplyInfoHTC = 1000318000,

    [NativeName("XR_TYPE_FOVEATION_DYNAMIC_MODE_INFO_HTC")]
    [SupportedApiProfile("openxr", ["XR_HTC_foveation"])]
    FoveationDynamicModeInfoHTC = 1000318001,

    [NativeName("XR_TYPE_FOVEATION_CUSTOM_MODE_INFO_HTC")]
    [SupportedApiProfile("openxr", ["XR_HTC_foveation"])]
    FoveationCustomModeInfoHTC = 1000318002,

    [NativeName("XR_TYPE_SYSTEM_ANCHOR_PROPERTIES_HTC")]
    [SupportedApiProfile("openxr", ["XR_HTC_anchor"])]
    SystemAnchorPropertiesHTC = 1000319000,

    [NativeName("XR_TYPE_SPATIAL_ANCHOR_CREATE_INFO_HTC")]
    [SupportedApiProfile("openxr", ["XR_HTC_anchor"])]
    SpatialAnchorCreateInfoHTC = 1000319001,

    [NativeName("XR_TYPE_SYSTEM_BODY_TRACKING_PROPERTIES_HTC")]
    [SupportedApiProfile("openxr", ["XR_HTC_body_tracking"])]
    SystemBodyTrackingPropertiesHTC = 1000320000,

    [NativeName("XR_TYPE_BODY_TRACKER_CREATE_INFO_HTC")]
    [SupportedApiProfile("openxr", ["XR_HTC_body_tracking"])]
    BodyTrackerCreateInfoHTC = 1000320001,

    [NativeName("XR_TYPE_BODY_JOINTS_LOCATE_INFO_HTC")]
    [SupportedApiProfile("openxr", ["XR_HTC_body_tracking"])]
    BodyJointsLocateInfoHTC = 1000320002,

    [NativeName("XR_TYPE_BODY_JOINT_LOCATIONS_HTC")]
    [SupportedApiProfile("openxr", ["XR_HTC_body_tracking"])]
    BodyJointLocationsHTC = 1000320003,

    [NativeName("XR_TYPE_BODY_SKELETON_HTC")]
    [SupportedApiProfile("openxr", ["XR_HTC_body_tracking"])]
    BodySkeletonHTC = 1000320004,

    [NativeName("XR_TYPE_ACTIVE_ACTION_SET_PRIORITIES_EXT")]
    [SupportedApiProfile("openxr", ["XR_EXT_active_action_set_priority"])]
    ActiveActionSetPrioritiesEXT = 1000373000,

    [NativeName("XR_TYPE_SYSTEM_FORCE_FEEDBACK_CURL_PROPERTIES_MNDX")]
    [SupportedApiProfile(
        "openxr",
        ["XR_MNDX_force_feedback_curl"],
        ImpliesSets = ["XR_EXT_hand_tracking", "XR_VERSION_1_0"]
    )]
    SystemForceFeedbackCurlPropertiesMNDX = 1000375000,

    [NativeName("XR_TYPE_FORCE_FEEDBACK_CURL_APPLY_LOCATIONS_MNDX")]
    [SupportedApiProfile(
        "openxr",
        ["XR_MNDX_force_feedback_curl"],
        ImpliesSets = ["XR_EXT_hand_tracking", "XR_VERSION_1_0"]
    )]
    ForceFeedbackCurlApplyLocationsMNDX = 1000375001,

    [NativeName("XR_TYPE_BODY_TRACKER_CREATE_INFO_BD")]
    [SupportedApiProfile("openxr", ["XR_BD_body_tracking"])]
    BodyTrackerCreateInfoBD = 1000385001,

    [NativeName("XR_TYPE_BODY_JOINTS_LOCATE_INFO_BD")]
    [SupportedApiProfile("openxr", ["XR_BD_body_tracking"])]
    BodyJointsLocateInfoBD = 1000385002,

    [NativeName("XR_TYPE_BODY_JOINT_LOCATIONS_BD")]
    [SupportedApiProfile("openxr", ["XR_BD_body_tracking"])]
    BodyJointLocationsBD = 1000385003,

    [NativeName("XR_TYPE_SYSTEM_BODY_TRACKING_PROPERTIES_BD")]
    [SupportedApiProfile("openxr", ["XR_BD_body_tracking"])]
    SystemBodyTrackingPropertiesBD = 1000385004,

    [NativeName("XR_TYPE_SYSTEM_FACIAL_SIMULATION_PROPERTIES_BD")]
    [SupportedApiProfile("openxr", ["XR_BD_facial_simulation"])]
    SystemFacialSimulationPropertiesBD = 1000386001,

    [NativeName("XR_TYPE_FACE_TRACKER_CREATE_INFO_BD")]
    [SupportedApiProfile("openxr", ["XR_BD_facial_simulation"])]
    FaceTrackerCreateInfoBD = 1000386002,

    [NativeName("XR_TYPE_FACIAL_SIMULATION_DATA_GET_INFO_BD")]
    [SupportedApiProfile("openxr", ["XR_BD_facial_simulation"])]
    FacialSimulationDataGetInfoBD = 1000386003,

    [NativeName("XR_TYPE_FACIAL_SIMULATION_DATA_BD")]
    [SupportedApiProfile("openxr", ["XR_BD_facial_simulation"])]
    FacialSimulationDataBD = 1000386004,

    [NativeName("XR_TYPE_LIP_EXPRESSION_DATA_BD")]
    [SupportedApiProfile("openxr", ["XR_BD_facial_simulation"])]
    LipExpressionDataBD = 1000386005,

    [NativeName("XR_TYPE_SYSTEM_SPATIAL_SENSING_PROPERTIES_BD")]
    [SupportedApiProfile(
        "openxr",
        ["XR_BD_spatial_sensing"],
        ImpliesSets = ["XR_EXT_future", "XR_VERSION_1_0"]
    )]
    SystemSpatialSensingPropertiesBD = 1000389000,

    [NativeName("XR_TYPE_SPATIAL_ENTITY_COMPONENT_GET_INFO_BD")]
    [SupportedApiProfile(
        "openxr",
        ["XR_BD_spatial_sensing"],
        ImpliesSets = ["XR_EXT_future", "XR_VERSION_1_0"]
    )]
    SpatialEntityComponentGetInfoBD = 1000389001,

    [NativeName("XR_TYPE_SPATIAL_ENTITY_LOCATION_GET_INFO_BD")]
    [SupportedApiProfile(
        "openxr",
        ["XR_BD_spatial_sensing"],
        ImpliesSets = ["XR_EXT_future", "XR_VERSION_1_0"]
    )]
    SpatialEntityLocationGetInfoBD = 1000389002,

    [NativeName("XR_TYPE_SPATIAL_ENTITY_COMPONENT_DATA_LOCATION_BD")]
    [SupportedApiProfile(
        "openxr",
        ["XR_BD_spatial_sensing"],
        ImpliesSets = ["XR_EXT_future", "XR_VERSION_1_0"]
    )]
    SpatialEntityComponentDataLocationBD = 1000389003,

    [NativeName("XR_TYPE_SPATIAL_ENTITY_COMPONENT_DATA_SEMANTIC_BD")]
    [SupportedApiProfile(
        "openxr",
        ["XR_BD_spatial_sensing"],
        ImpliesSets = ["XR_EXT_future", "XR_VERSION_1_0"]
    )]
    SpatialEntityComponentDataSemanticBD = 1000389004,

    [NativeName("XR_TYPE_SPATIAL_ENTITY_COMPONENT_DATA_BOUNDING_BOX_2D_BD")]
    [SupportedApiProfile(
        "openxr",
        ["XR_BD_spatial_sensing"],
        ImpliesSets = ["XR_EXT_future", "XR_VERSION_1_0"]
    )]
    SpatialEntityComponentDataBoundingBox2DBD = 1000389005,

    [NativeName("XR_TYPE_SPATIAL_ENTITY_COMPONENT_DATA_POLYGON_BD")]
    [SupportedApiProfile(
        "openxr",
        ["XR_BD_spatial_sensing"],
        ImpliesSets = ["XR_EXT_future", "XR_VERSION_1_0"]
    )]
    SpatialEntityComponentDataPolygonBD = 1000389006,

    [NativeName("XR_TYPE_SPATIAL_ENTITY_COMPONENT_DATA_BOUNDING_BOX_3D_BD")]
    [SupportedApiProfile(
        "openxr",
        ["XR_BD_spatial_sensing"],
        ImpliesSets = ["XR_EXT_future", "XR_VERSION_1_0"]
    )]
    SpatialEntityComponentDataBoundingBox3DBD = 1000389007,

    [NativeName("XR_TYPE_SPATIAL_ENTITY_COMPONENT_DATA_TRIANGLE_MESH_BD")]
    [SupportedApiProfile(
        "openxr",
        ["XR_BD_spatial_sensing"],
        ImpliesSets = ["XR_EXT_future", "XR_VERSION_1_0"]
    )]
    SpatialEntityComponentDataTriangleMeshBD = 1000389008,

    [NativeName("XR_TYPE_SENSE_DATA_PROVIDER_CREATE_INFO_BD")]
    [SupportedApiProfile(
        "openxr",
        ["XR_BD_spatial_sensing"],
        ImpliesSets = ["XR_EXT_future", "XR_VERSION_1_0"]
    )]
    SenseDataProviderCreateInfoBD = 1000389009,

    [NativeName("XR_TYPE_SENSE_DATA_PROVIDER_START_INFO_BD")]
    [SupportedApiProfile(
        "openxr",
        ["XR_BD_spatial_sensing"],
        ImpliesSets = ["XR_EXT_future", "XR_VERSION_1_0"]
    )]
    SenseDataProviderStartInfoBD = 1000389010,

    [NativeName("XR_TYPE_EVENT_DATA_SENSE_DATA_PROVIDER_STATE_CHANGED_BD")]
    [SupportedApiProfile(
        "openxr",
        ["XR_BD_spatial_sensing"],
        ImpliesSets = ["XR_EXT_future", "XR_VERSION_1_0"]
    )]
    EventDataSenseDataProviderStateChangedBD = 1000389011,

    [NativeName("XR_TYPE_EVENT_DATA_SENSE_DATA_UPDATED_BD")]
    [SupportedApiProfile(
        "openxr",
        ["XR_BD_spatial_sensing"],
        ImpliesSets = ["XR_EXT_future", "XR_VERSION_1_0"]
    )]
    EventDataSenseDataUpdatedBD = 1000389012,

    [NativeName("XR_TYPE_SENSE_DATA_QUERY_INFO_BD")]
    [SupportedApiProfile(
        "openxr",
        ["XR_BD_spatial_sensing"],
        ImpliesSets = ["XR_EXT_future", "XR_VERSION_1_0"]
    )]
    SenseDataQueryInfoBD = 1000389013,

    [NativeName("XR_TYPE_SENSE_DATA_QUERY_COMPLETION_BD")]
    [SupportedApiProfile(
        "openxr",
        ["XR_BD_spatial_sensing"],
        ImpliesSets = ["XR_EXT_future", "XR_VERSION_1_0"]
    )]
    SenseDataQueryCompletionBD = 1000389014,

    [NativeName("XR_TYPE_SENSE_DATA_FILTER_UUID_BD")]
    [SupportedApiProfile(
        "openxr",
        ["XR_BD_spatial_sensing"],
        ImpliesSets = ["XR_EXT_future", "XR_VERSION_1_0"]
    )]
    SenseDataFilterUuidBD = 1000389015,

    [NativeName("XR_TYPE_SENSE_DATA_FILTER_SEMANTIC_BD")]
    [SupportedApiProfile(
        "openxr",
        ["XR_BD_spatial_sensing"],
        ImpliesSets = ["XR_EXT_future", "XR_VERSION_1_0"]
    )]
    SenseDataFilterSemanticBD = 1000389016,

    [NativeName("XR_TYPE_QUERIED_SENSE_DATA_GET_INFO_BD")]
    [SupportedApiProfile(
        "openxr",
        ["XR_BD_spatial_sensing"],
        ImpliesSets = ["XR_EXT_future", "XR_VERSION_1_0"]
    )]
    QueriedSenseDataGetInfoBD = 1000389017,

    [NativeName("XR_TYPE_QUERIED_SENSE_DATA_BD")]
    [SupportedApiProfile(
        "openxr",
        ["XR_BD_spatial_sensing"],
        ImpliesSets = ["XR_EXT_future", "XR_VERSION_1_0"]
    )]
    QueriedSenseDataBD = 1000389018,

    [NativeName("XR_TYPE_SPATIAL_ENTITY_STATE_BD")]
    [SupportedApiProfile(
        "openxr",
        ["XR_BD_spatial_sensing"],
        ImpliesSets = ["XR_EXT_future", "XR_VERSION_1_0"]
    )]
    SpatialEntityStateBD = 1000389019,

    [NativeName("XR_TYPE_SPATIAL_ENTITY_ANCHOR_CREATE_INFO_BD")]
    [SupportedApiProfile(
        "openxr",
        ["XR_BD_spatial_sensing"],
        ImpliesSets = ["XR_EXT_future", "XR_VERSION_1_0"]
    )]
    SpatialEntityAnchorCreateInfoBD = 1000389020,

    [NativeName("XR_TYPE_ANCHOR_SPACE_CREATE_INFO_BD")]
    [SupportedApiProfile(
        "openxr",
        ["XR_BD_spatial_sensing"],
        ImpliesSets = ["XR_EXT_future", "XR_VERSION_1_0"]
    )]
    AnchorSpaceCreateInfoBD = 1000389021,

    [NativeName("XR_TYPE_SYSTEM_SPATIAL_ANCHOR_PROPERTIES_BD")]
    [SupportedApiProfile(
        "openxr",
        ["XR_BD_spatial_anchor"],
        ImpliesSets = ["XR_BD_spatial_sensing"]
    )]
    SystemSpatialAnchorPropertiesBD = 1000390000,

    [NativeName("XR_TYPE_SPATIAL_ANCHOR_CREATE_INFO_BD")]
    [SupportedApiProfile(
        "openxr",
        ["XR_BD_spatial_anchor"],
        ImpliesSets = ["XR_BD_spatial_sensing"]
    )]
    SpatialAnchorCreateInfoBD = 1000390001,

    [NativeName("XR_TYPE_SPATIAL_ANCHOR_CREATE_COMPLETION_BD")]
    [SupportedApiProfile(
        "openxr",
        ["XR_BD_spatial_anchor"],
        ImpliesSets = ["XR_BD_spatial_sensing"]
    )]
    SpatialAnchorCreateCompletionBD = 1000390002,

    [NativeName("XR_TYPE_SPATIAL_ANCHOR_PERSIST_INFO_BD")]
    [SupportedApiProfile(
        "openxr",
        ["XR_BD_spatial_anchor"],
        ImpliesSets = ["XR_BD_spatial_sensing"]
    )]
    SpatialAnchorPersistInfoBD = 1000390003,

    [NativeName("XR_TYPE_SPATIAL_ANCHOR_UNPERSIST_INFO_BD")]
    [SupportedApiProfile(
        "openxr",
        ["XR_BD_spatial_anchor"],
        ImpliesSets = ["XR_BD_spatial_sensing"]
    )]
    SpatialAnchorUnpersistInfoBD = 1000390004,

    [NativeName("XR_TYPE_SYSTEM_SPATIAL_ANCHOR_SHARING_PROPERTIES_BD")]
    [SupportedApiProfile(
        "openxr",
        ["XR_BD_spatial_anchor_sharing"],
        ImpliesSets = ["XR_BD_spatial_anchor"]
    )]
    SystemSpatialAnchorSharingPropertiesBD = 1000391000,

    [NativeName("XR_TYPE_SPATIAL_ANCHOR_SHARE_INFO_BD")]
    [SupportedApiProfile(
        "openxr",
        ["XR_BD_spatial_anchor_sharing"],
        ImpliesSets = ["XR_BD_spatial_anchor"]
    )]
    SpatialAnchorShareInfoBD = 1000391001,

    [NativeName("XR_TYPE_SHARED_SPATIAL_ANCHOR_DOWNLOAD_INFO_BD")]
    [SupportedApiProfile(
        "openxr",
        ["XR_BD_spatial_anchor_sharing"],
        ImpliesSets = ["XR_BD_spatial_anchor"]
    )]
    SharedSpatialAnchorDownloadInfoBD = 1000391002,

    [NativeName("XR_TYPE_SYSTEM_SPATIAL_SCENE_PROPERTIES_BD")]
    [SupportedApiProfile(
        "openxr",
        ["XR_BD_spatial_scene"],
        ImpliesSets = ["XR_BD_spatial_sensing"]
    )]
    SystemSpatialScenePropertiesBD = 1000392000,

    [NativeName("XR_TYPE_SCENE_CAPTURE_INFO_BD")]
    [SupportedApiProfile(
        "openxr",
        ["XR_BD_spatial_scene"],
        ImpliesSets = ["XR_BD_spatial_sensing"]
    )]
    SceneCaptureInfoBD = 1000392001,

    [NativeName("XR_TYPE_SYSTEM_SPATIAL_MESH_PROPERTIES_BD")]
    [SupportedApiProfile("openxr", ["XR_BD_spatial_mesh"], ImpliesSets = ["XR_BD_spatial_sensing"])]
    SystemSpatialMeshPropertiesBD = 1000393000,

    [NativeName("XR_TYPE_SENSE_DATA_PROVIDER_CREATE_INFO_SPATIAL_MESH_BD")]
    [SupportedApiProfile("openxr", ["XR_BD_spatial_mesh"], ImpliesSets = ["XR_BD_spatial_sensing"])]
    SenseDataProviderCreateInfoSpatialMeshBD = 1000393001,

    [NativeName("XR_TYPE_FUTURE_POLL_RESULT_PROGRESS_BD")]
    [SupportedApiProfile(
        "openxr",
        ["XR_BD_future_progress"],
        ImpliesSets = ["XR_EXT_future", "XR_VERSION_1_0"]
    )]
    FuturePollResultProgressBD = 1000394001,

    [NativeName("XR_TYPE_SYSTEM_SPATIAL_PLANE_PROPERTIES_BD")]
    [SupportedApiProfile(
        "openxr",
        ["XR_BD_spatial_plane"],
        ImpliesSets = ["XR_BD_spatial_sensing"]
    )]
    SystemSpatialPlanePropertiesBD = 1000396000,

    [NativeName("XR_TYPE_SPATIAL_ENTITY_COMPONENT_DATA_PLANE_ORIENTATION_BD")]
    [SupportedApiProfile(
        "openxr",
        ["XR_BD_spatial_plane"],
        ImpliesSets = ["XR_BD_spatial_sensing"]
    )]
    SpatialEntityComponentDataPlaneOrientationBD = 1000396001,

    [NativeName("XR_TYPE_SENSE_DATA_FILTER_PLANE_ORIENTATION_BD")]
    [SupportedApiProfile(
        "openxr",
        ["XR_BD_spatial_plane"],
        ImpliesSets = ["XR_BD_spatial_sensing"]
    )]
    SenseDataFilterPlaneOrientationBD = 1000396002,

    [NativeName("XR_TYPE_SPATIAL_AUDIO_RENDERER_CREATE_INFO_BD")]
    [SupportedApiProfile("openxr", ["XR_BD_spatial_audio_rendering"])]
    SpatialAudioRendererCreateInfoBD = 1000409000,

    [NativeName("XR_TYPE_AUDIO_BUFFER_BD")]
    [SupportedApiProfile("openxr", ["XR_BD_spatial_audio_rendering"])]
    AudioBufferBD = 1000409001,

    [NativeName("XR_TYPE_SOUND_OBJECT_DIRECTIVITY_CARDIOID_BD")]
    [SupportedApiProfile("openxr", ["XR_BD_spatial_audio_rendering"])]
    SoundObjectDirectivityCardioidBD = 1000409003,

    [NativeName("XR_TYPE_SOUND_OBJECT_SHAPE_SPHERE_BD")]
    [SupportedApiProfile("openxr", ["XR_BD_spatial_audio_rendering"])]
    SoundObjectShapeSphereBD = 1000409004,

    [NativeName("XR_TYPE_SOUND_OBJECT_DISTANCE_ATTENUATION_BD")]
    [SupportedApiProfile("openxr", ["XR_BD_spatial_audio_rendering"])]
    SoundObjectDistanceAttenuationBD = 1000409005,

    [NativeName("XR_TYPE_SOUND_OBJECT_DISTANCE_ATTENUATION_CURVE_BD")]
    [SupportedApiProfile("openxr", ["XR_BD_spatial_audio_rendering"])]
    SoundObjectDistanceAttenuationCurveBD = 1000409006,

    [NativeName("XR_TYPE_SOUND_OBJECT_CONFIG_BD")]
    [SupportedApiProfile("openxr", ["XR_BD_spatial_audio_rendering"])]
    SoundObjectConfigBD = 1000409007,

    [NativeName("XR_TYPE_SOUND_FIELD_CONFIG_BD")]
    [SupportedApiProfile("openxr", ["XR_BD_spatial_audio_rendering"])]
    SoundFieldConfigBD = 1000409008,

    [NativeName("XR_TYPE_SOUND_FIELD_CHANNEL_DEFINITION_SURROUND_BD")]
    [SupportedApiProfile("openxr", ["XR_BD_spatial_audio_rendering"])]
    SoundFieldChannelDefinitionSurroundBD = 1000409009,

    [NativeName("XR_TYPE_SOUND_FIELD_CHANNEL_DEFINITION_AMBIX_BD")]
    [SupportedApiProfile("openxr", ["XR_BD_spatial_audio_rendering"])]
    SoundFieldChannelDefinitionAmbixBD = 1000409010,

    [NativeName("XR_TYPE_SOUND_FIELD_CHANNEL_DEFINITION_FUMA_BD")]
    [SupportedApiProfile("openxr", ["XR_BD_spatial_audio_rendering"])]
    SoundFieldChannelDefinitionFumaBD = 1000409011,

    [NativeName("XR_TYPE_SOUND_TRIANGLE_MESH_BD")]
    [SupportedApiProfile("openxr", ["XR_BD_spatial_audio_rendering"])]
    SoundTriangleMeshBD = 1000409012,

    [NativeName("XR_TYPE_SOUND_OBSTACLE_CONFIG_BD")]
    [SupportedApiProfile("openxr", ["XR_BD_spatial_audio_rendering"])]
    SoundObstacleConfigBD = 1000409013,

    [NativeName("XR_TYPE_SOUND_OBSTACLE_MATERIAL_CONFIG_BD")]
    [SupportedApiProfile("openxr", ["XR_BD_spatial_audio_rendering"])]
    SoundObstacleMaterialConfigBD = 1000409014,

    [NativeName("XR_TYPE_HAND_TRACKING_DATA_SOURCE_INFO_EXT")]
    [SupportedApiProfile(
        "openxr",
        ["XR_EXT_hand_tracking_data_source"],
        ImpliesSets = ["XR_EXT_hand_tracking", "XR_VERSION_1_0"]
    )]
    HandTrackingDataSourceInfoEXT = 1000428000,

    [NativeName("XR_TYPE_HAND_TRACKING_DATA_SOURCE_STATE_EXT")]
    [SupportedApiProfile(
        "openxr",
        ["XR_EXT_hand_tracking_data_source"],
        ImpliesSets = ["XR_EXT_hand_tracking", "XR_VERSION_1_0"]
    )]
    HandTrackingDataSourceStateEXT = 1000428001,

    [NativeName("XR_TYPE_PLANE_DETECTOR_CREATE_INFO_EXT")]
    [SupportedApiProfile("openxr", ["XR_EXT_plane_detection"])]
    PlaneDetectorCreateInfoEXT = 1000429001,

    [NativeName("XR_TYPE_PLANE_DETECTOR_BEGIN_INFO_EXT")]
    [SupportedApiProfile("openxr", ["XR_EXT_plane_detection"])]
    PlaneDetectorBeginInfoEXT = 1000429002,

    [NativeName("XR_TYPE_PLANE_DETECTOR_GET_INFO_EXT")]
    [SupportedApiProfile("openxr", ["XR_EXT_plane_detection"])]
    PlaneDetectorGetInfoEXT = 1000429003,

    [NativeName("XR_TYPE_PLANE_DETECTOR_LOCATIONS_EXT")]
    [SupportedApiProfile("openxr", ["XR_EXT_plane_detection"])]
    PlaneDetectorLocationsEXT = 1000429004,

    [NativeName("XR_TYPE_PLANE_DETECTOR_LOCATION_EXT")]
    [SupportedApiProfile("openxr", ["XR_EXT_plane_detection"])]
    PlaneDetectorLocationEXT = 1000429005,

    [NativeName("XR_TYPE_PLANE_DETECTOR_POLYGON_BUFFER_EXT")]
    [SupportedApiProfile("openxr", ["XR_EXT_plane_detection"])]
    PlaneDetectorPolygonBufferEXT = 1000429006,

    [NativeName("XR_TYPE_SYSTEM_PLANE_DETECTION_PROPERTIES_EXT")]
    [SupportedApiProfile("openxr", ["XR_EXT_plane_detection"])]
    SystemPlaneDetectionPropertiesEXT = 1000429007,

    [NativeName("XR_TYPE_TRACKABLE_GET_INFO_ANDROID")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_trackables"])]
    TrackableGetInfoANDROID = 1000455000,

    [NativeName("XR_TYPE_ANCHOR_SPACE_CREATE_INFO_ANDROID")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_trackables"])]
    AnchorSpaceCreateInfoANDROID = 1000455001,

    [NativeName("XR_TYPE_TRACKABLE_PLANE_ANDROID")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_trackables"])]
    TrackablePlaneANDROID = 1000455003,

    [NativeName("XR_TYPE_TRACKABLE_TRACKER_CREATE_INFO_ANDROID")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_trackables"])]
    TrackableTrackerCreateInfoANDROID = 1000455004,

    [NativeName("XR_TYPE_SYSTEM_TRACKABLES_PROPERTIES_ANDROID")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_trackables"])]
    SystemTrackablesPropertiesANDROID = 1000455005,

    [NativeName("XR_TYPE_EYES_ANDROID")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_eye_tracking"])]
    EyesANDROID = 1000456000,

    [NativeName("XR_TYPE_EYE_TRACKER_CREATE_INFO_ANDROID")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_eye_tracking"])]
    EyeTrackerCreateInfoANDROID = 1000456001,

    [NativeName("XR_TYPE_EYES_GET_INFO_ANDROID")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_eye_tracking"])]
    EyesGetInfoANDROID = 1000456002,

    [NativeName("XR_TYPE_SYSTEM_EYE_TRACKING_PROPERTIES_ANDROID")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_eye_tracking"])]
    SystemEyeTrackingPropertiesANDROID = 1000456004,

    [NativeName("XR_TYPE_PERSISTED_ANCHOR_SPACE_CREATE_INFO_ANDROID")]
    [SupportedApiProfile(
        "openxr",
        ["XR_ANDROID_device_anchor_persistence"],
        ImpliesSets = ["XR_ANDROID_trackables", "XR_EXT_uuid"]
    )]
    PersistedAnchorSpaceCreateInfoANDROID = 1000457001,

    [NativeName("XR_TYPE_PERSISTED_ANCHOR_SPACE_INFO_ANDROID")]
    [SupportedApiProfile(
        "openxr",
        ["XR_ANDROID_device_anchor_persistence"],
        ImpliesSets = ["XR_ANDROID_trackables", "XR_EXT_uuid"]
    )]
    PersistedAnchorSpaceInfoANDROID = 1000457002,

    [NativeName("XR_TYPE_DEVICE_ANCHOR_PERSISTENCE_CREATE_INFO_ANDROID")]
    [SupportedApiProfile(
        "openxr",
        ["XR_ANDROID_device_anchor_persistence"],
        ImpliesSets = ["XR_ANDROID_trackables", "XR_EXT_uuid"]
    )]
    DeviceAnchorPersistenceCreateInfoANDROID = 1000457003,

    [NativeName("XR_TYPE_SYSTEM_DEVICE_ANCHOR_PERSISTENCE_PROPERTIES_ANDROID")]
    [SupportedApiProfile(
        "openxr",
        ["XR_ANDROID_device_anchor_persistence"],
        ImpliesSets = ["XR_ANDROID_trackables", "XR_EXT_uuid"]
    )]
    SystemDeviceAnchorPersistencePropertiesANDROID = 1000457004,

    [NativeName("XR_TYPE_FACE_TRACKER_CREATE_INFO_ANDROID")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_face_tracking"])]
    FaceTrackerCreateInfoANDROID = 1000458000,

    [NativeName("XR_TYPE_FACE_STATE_GET_INFO_ANDROID")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_face_tracking"])]
    FaceStateGetInfoANDROID = 1000458001,

    [NativeName("XR_TYPE_FACE_STATE_ANDROID")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_face_tracking"])]
    FaceStateANDROID = 1000458002,

    [NativeName("XR_TYPE_SYSTEM_FACE_TRACKING_PROPERTIES_ANDROID")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_face_tracking"])]
    SystemFaceTrackingPropertiesANDROID = 1000458003,

    [NativeName("XR_TYPE_PASSTHROUGH_CAMERA_STATE_GET_INFO_ANDROID")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_passthrough_camera_state"])]
    PassthroughCameraStateGetInfoANDROID = 1000460000,

    [NativeName("XR_TYPE_SYSTEM_PASSTHROUGH_CAMERA_STATE_PROPERTIES_ANDROID")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_passthrough_camera_state"])]
    SystemPassthroughCameraStatePropertiesANDROID = 1000460001,

    [NativeName("XR_TYPE_EVENT_DATA_RECOMMENDED_RESOLUTION_CHANGED_ANDROID")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_recommended_resolution"])]
    EventDataRecommendedResolutionChangedANDROID = 1000461000,

    [NativeName("XR_TYPE_PASSTHROUGH_LAYER_CREATE_INFO_ANDROID")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_composition_layer_passthrough_mesh"])]
    PassthroughLayerCreateInfoANDROID = 1000462000,

    [NativeName("XR_TYPE_PASSTHROUGH_LAYER_MESH_ANDROID")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_composition_layer_passthrough_mesh"])]
    PassthroughLayerMeshANDROID = 1000462001,

    [NativeName("XR_TYPE_COMPOSITION_LAYER_PASSTHROUGH_ANDROID")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_composition_layer_passthrough_mesh"])]
    CompositionLayerPassthroughANDROID = 1000462002,

    [NativeName("XR_TYPE_SYSTEM_PASSTHROUGH_LAYER_PROPERTIES_ANDROID")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_composition_layer_passthrough_mesh"])]
    SystemPassthroughLayerPropertiesANDROID = 1000462003,

    [NativeName("XR_TYPE_RAYCAST_INFO_ANDROID")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_raycast"], ImpliesSets = ["XR_ANDROID_trackables"])]
    RaycastInfoANDROID = 1000463000,

    [NativeName("XR_TYPE_RAYCAST_HIT_RESULTS_ANDROID")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_raycast"], ImpliesSets = ["XR_ANDROID_trackables"])]
    RaycastHitResultsANDROID = 1000463001,

    [NativeName("XR_TYPE_PERFORMANCE_METRICS_STATE_ANDROID")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_performance_metrics"])]
    PerformanceMetricsStateANDROID = 1000465000,

    [NativeName("XR_TYPE_PERFORMANCE_METRICS_COUNTER_ANDROID")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_performance_metrics"])]
    PerformanceMetricsCounterANDROID = 1000465001,

    [NativeName("XR_TYPE_TRACKABLE_OBJECT_ANDROID")]
    [SupportedApiProfile(
        "openxr",
        ["XR_ANDROID_trackables_object"],
        ImpliesSets = ["XR_ANDROID_trackables"]
    )]
    TrackableObjectANDROID = 1000466000,

    [NativeName("XR_TYPE_TRACKABLE_OBJECT_CONFIGURATION_ANDROID")]
    [SupportedApiProfile(
        "openxr",
        ["XR_ANDROID_trackables_object"],
        ImpliesSets = ["XR_ANDROID_trackables"]
    )]
    TrackableObjectConfigurationANDROID = 1000466001,

    [NativeName("XR_TYPE_FUTURE_CANCEL_INFO_EXT")]
    [SupportedApiProfile("openxr", ["XR_EXT_future"])]
    FutureCancelInfoEXT = 1000469000,

    [NativeName("XR_TYPE_FUTURE_POLL_INFO_EXT")]
    [SupportedApiProfile("openxr", ["XR_EXT_future"])]
    FuturePollInfoEXT = 1000469001,

    [NativeName("XR_TYPE_FUTURE_COMPLETION_EXT")]
    [SupportedApiProfile("openxr", ["XR_EXT_future"])]
    FutureCompletionEXT = 1000469002,

    [NativeName("XR_TYPE_FUTURE_POLL_RESULT_EXT")]
    [SupportedApiProfile("openxr", ["XR_EXT_future"])]
    FuturePollResultEXT = 1000469003,

    [NativeName("XR_TYPE_EVENT_DATA_USER_PRESENCE_CHANGED_EXT")]
    [SupportedApiProfile("openxr", ["XR_EXT_user_presence"])]
    EventDataUserPresenceChangedEXT = 1000470000,

    [NativeName("XR_TYPE_SYSTEM_USER_PRESENCE_PROPERTIES_EXT")]
    [SupportedApiProfile("openxr", ["XR_EXT_user_presence"])]
    SystemUserPresencePropertiesEXT = 1000470001,

    [NativeName("XR_TYPE_SYSTEM_NOTIFICATIONS_SET_INFO_ML")]
    [SupportedApiProfile("openxr", ["XR_ML_system_notifications"])]
    SystemNotificationsSetInfoML = 1000473000,

    [NativeName("XR_TYPE_WORLD_MESH_DETECTOR_CREATE_INFO_ML")]
    [SupportedApiProfile("openxr", ["XR_ML_world_mesh_detection"], ImpliesSets = ["XR_EXT_future"])]
    WorldMeshDetectorCreateInfoML = 1000474001,

    [NativeName("XR_TYPE_WORLD_MESH_STATE_REQUEST_INFO_ML")]
    [SupportedApiProfile("openxr", ["XR_ML_world_mesh_detection"], ImpliesSets = ["XR_EXT_future"])]
    WorldMeshStateRequestInfoML = 1000474002,

    [NativeName("XR_TYPE_WORLD_MESH_BLOCK_STATE_ML")]
    [SupportedApiProfile("openxr", ["XR_ML_world_mesh_detection"], ImpliesSets = ["XR_EXT_future"])]
    WorldMeshBlockStateML = 1000474003,

    [NativeName("XR_TYPE_WORLD_MESH_STATE_REQUEST_COMPLETION_ML")]
    [SupportedApiProfile("openxr", ["XR_ML_world_mesh_detection"], ImpliesSets = ["XR_EXT_future"])]
    WorldMeshStateRequestCompletionML = 1000474004,

    [NativeName("XR_TYPE_WORLD_MESH_BUFFER_RECOMMENDED_SIZE_INFO_ML")]
    [SupportedApiProfile("openxr", ["XR_ML_world_mesh_detection"], ImpliesSets = ["XR_EXT_future"])]
    WorldMeshBufferRecommendedSizeInfoML = 1000474005,

    [NativeName("XR_TYPE_WORLD_MESH_BUFFER_SIZE_ML")]
    [SupportedApiProfile("openxr", ["XR_ML_world_mesh_detection"], ImpliesSets = ["XR_EXT_future"])]
    WorldMeshBufferSizeML = 1000474006,

    [NativeName("XR_TYPE_WORLD_MESH_BUFFER_ML")]
    [SupportedApiProfile("openxr", ["XR_ML_world_mesh_detection"], ImpliesSets = ["XR_EXT_future"])]
    WorldMeshBufferML = 1000474007,

    [NativeName("XR_TYPE_WORLD_MESH_BLOCK_REQUEST_ML")]
    [SupportedApiProfile("openxr", ["XR_ML_world_mesh_detection"], ImpliesSets = ["XR_EXT_future"])]
    WorldMeshBlockRequestML = 1000474008,

    [NativeName("XR_TYPE_WORLD_MESH_GET_INFO_ML")]
    [SupportedApiProfile("openxr", ["XR_ML_world_mesh_detection"], ImpliesSets = ["XR_EXT_future"])]
    WorldMeshGetInfoML = 1000474009,

    [NativeName("XR_TYPE_WORLD_MESH_BLOCK_ML")]
    [SupportedApiProfile("openxr", ["XR_ML_world_mesh_detection"], ImpliesSets = ["XR_EXT_future"])]
    WorldMeshBlockML = 1000474010,

    [NativeName("XR_TYPE_WORLD_MESH_REQUEST_COMPLETION_ML")]
    [SupportedApiProfile("openxr", ["XR_ML_world_mesh_detection"], ImpliesSets = ["XR_EXT_future"])]
    WorldMeshRequestCompletionML = 1000474011,

    [NativeName("XR_TYPE_WORLD_MESH_REQUEST_COMPLETION_INFO_ML")]
    [SupportedApiProfile("openxr", ["XR_ML_world_mesh_detection"], ImpliesSets = ["XR_EXT_future"])]
    WorldMeshRequestCompletionInfoML = 1000474012,

    [NativeName("XR_TYPE_SYSTEM_FACIAL_EXPRESSION_PROPERTIES_ML")]
    [SupportedApiProfile("openxr", ["XR_ML_facial_expression"])]
    SystemFacialExpressionPropertiesML = 1000482004,

    [NativeName("XR_TYPE_FACIAL_EXPRESSION_CLIENT_CREATE_INFO_ML")]
    [SupportedApiProfile("openxr", ["XR_ML_facial_expression"])]
    FacialExpressionClientCreateInfoML = 1000482005,

    [NativeName("XR_TYPE_FACIAL_EXPRESSION_BLEND_SHAPE_GET_INFO_ML")]
    [SupportedApiProfile("openxr", ["XR_ML_facial_expression"])]
    FacialExpressionBlendShapeGetInfoML = 1000482006,

    [NativeName("XR_TYPE_FACIAL_EXPRESSION_BLEND_SHAPE_PROPERTIES_ML")]
    [SupportedApiProfile("openxr", ["XR_ML_facial_expression"])]
    FacialExpressionBlendShapePropertiesML = 1000482007,

    [NativeName("XR_TYPE_SYSTEM_BOUNDARY_VISIBILITY_PROPERTIES_META")]
    [SupportedApiProfile("openxr", ["XR_META_boundary_visibility"])]
    SystemBoundaryVisibilityPropertiesMETA = 1000528000,

    [NativeName("XR_TYPE_EVENT_DATA_BOUNDARY_VISIBILITY_CHANGED_META")]
    [SupportedApiProfile("openxr", ["XR_META_boundary_visibility"])]
    EventDataBoundaryVisibilityChangedMETA = 1000528001,

    [NativeName("XR_TYPE_SYSTEM_SIMULTANEOUS_HANDS_AND_CONTROLLERS_PROPERTIES_META")]
    [SupportedApiProfile("openxr", ["XR_META_simultaneous_hands_and_controllers"])]
    SystemSimultaneousHandsAndControllersPropertiesMETA = 1000532001,

    [NativeName("XR_TYPE_SIMULTANEOUS_HANDS_AND_CONTROLLERS_TRACKING_RESUME_INFO_META")]
    [SupportedApiProfile("openxr", ["XR_META_simultaneous_hands_and_controllers"])]
    SimultaneousHandsAndControllersTrackingResumeInfoMETA = 1000532002,

    [NativeName("XR_TYPE_SIMULTANEOUS_HANDS_AND_CONTROLLERS_TRACKING_PAUSE_INFO_META")]
    [SupportedApiProfile("openxr", ["XR_META_simultaneous_hands_and_controllers"])]
    SimultaneousHandsAndControllersTrackingPauseInfoMETA = 1000532003,

    [NativeName("XR_TYPE_FACE_TRACKING_VISEMES_META")]
    [SupportedApiProfile(
        "openxr",
        ["XR_META_face_tracking_visemes"],
        ImpliesSets = ["XR_FB_face_tracking2", "XR_VERSION_1_0"]
    )]
    FaceTrackingVisemesMETA = 1000541000,

    [NativeName("XR_TYPE_SYSTEM_FACE_TRACKING_VISEMES_PROPERTIES_META")]
    [SupportedApiProfile(
        "openxr",
        ["XR_META_face_tracking_visemes"],
        ImpliesSets = ["XR_FB_face_tracking2", "XR_VERSION_1_0"]
    )]
    SystemFaceTrackingVisemesPropertiesMETA = 1000541001,

    [NativeName("XR_TYPE_ROOM_MESH_FACE_INDICES_META")]
    [SupportedApiProfile(
        "openxr",
        ["XR_META_spatial_entity_room_mesh"],
        ImpliesSets = [
            "XR_FB_spatial_entity",
            "XR_META_spatial_entity_semantic_label",
            "XR_VERSION_1_0",
        ]
    )]
    RoomMeshFaceIndicesMETA = 1000553000,

    [NativeName("XR_TYPE_SPACE_ROOM_MESH_GET_INFO_META")]
    [SupportedApiProfile(
        "openxr",
        ["XR_META_spatial_entity_room_mesh"],
        ImpliesSets = [
            "XR_FB_spatial_entity",
            "XR_META_spatial_entity_semantic_label",
            "XR_VERSION_1_0",
        ]
    )]
    SpaceRoomMeshGetInfoMETA = 1000553001,

    [NativeName("XR_TYPE_ROOM_MESH_META")]
    [SupportedApiProfile(
        "openxr",
        ["XR_META_spatial_entity_room_mesh"],
        ImpliesSets = [
            "XR_FB_spatial_entity",
            "XR_META_spatial_entity_semantic_label",
            "XR_VERSION_1_0",
        ]
    )]
    RoomMeshMETA = 1000553002,

    [NativeName("XR_TYPE_COLOCATION_DISCOVERY_START_INFO_META")]
    [SupportedApiProfile("openxr", ["XR_META_colocation_discovery"])]
    ColocationDiscoveryStartInfoMETA = 1000571010,

    [NativeName("XR_TYPE_COLOCATION_DISCOVERY_STOP_INFO_META")]
    [SupportedApiProfile("openxr", ["XR_META_colocation_discovery"])]
    ColocationDiscoveryStopInfoMETA = 1000571011,

    [NativeName("XR_TYPE_COLOCATION_ADVERTISEMENT_START_INFO_META")]
    [SupportedApiProfile("openxr", ["XR_META_colocation_discovery"])]
    ColocationAdvertisementStartInfoMETA = 1000571012,

    [NativeName("XR_TYPE_COLOCATION_ADVERTISEMENT_STOP_INFO_META")]
    [SupportedApiProfile("openxr", ["XR_META_colocation_discovery"])]
    ColocationAdvertisementStopInfoMETA = 1000571013,

    [NativeName("XR_TYPE_EVENT_DATA_START_COLOCATION_ADVERTISEMENT_COMPLETE_META")]
    [SupportedApiProfile("openxr", ["XR_META_colocation_discovery"])]
    EventDataStartColocationAdvertisementCompleteMETA = 1000571020,

    [NativeName("XR_TYPE_EVENT_DATA_STOP_COLOCATION_ADVERTISEMENT_COMPLETE_META")]
    [SupportedApiProfile("openxr", ["XR_META_colocation_discovery"])]
    EventDataStopColocationAdvertisementCompleteMETA = 1000571021,

    [NativeName("XR_TYPE_EVENT_DATA_COLOCATION_ADVERTISEMENT_COMPLETE_META")]
    [SupportedApiProfile("openxr", ["XR_META_colocation_discovery"])]
    EventDataColocationAdvertisementCompleteMETA = 1000571022,

    [NativeName("XR_TYPE_EVENT_DATA_START_COLOCATION_DISCOVERY_COMPLETE_META")]
    [SupportedApiProfile("openxr", ["XR_META_colocation_discovery"])]
    EventDataStartColocationDiscoveryCompleteMETA = 1000571023,

    [NativeName("XR_TYPE_EVENT_DATA_COLOCATION_DISCOVERY_RESULT_META")]
    [SupportedApiProfile("openxr", ["XR_META_colocation_discovery"])]
    EventDataColocationDiscoveryResultMETA = 1000571024,

    [NativeName("XR_TYPE_EVENT_DATA_COLOCATION_DISCOVERY_COMPLETE_META")]
    [SupportedApiProfile("openxr", ["XR_META_colocation_discovery"])]
    EventDataColocationDiscoveryCompleteMETA = 1000571025,

    [NativeName("XR_TYPE_EVENT_DATA_STOP_COLOCATION_DISCOVERY_COMPLETE_META")]
    [SupportedApiProfile("openxr", ["XR_META_colocation_discovery"])]
    EventDataStopColocationDiscoveryCompleteMETA = 1000571026,

    [NativeName("XR_TYPE_SYSTEM_COLOCATION_DISCOVERY_PROPERTIES_META")]
    [SupportedApiProfile("openxr", ["XR_META_colocation_discovery"])]
    SystemColocationDiscoveryPropertiesMETA = 1000571030,

    [NativeName("XR_TYPE_SHARE_SPACES_RECIPIENT_GROUPS_META")]
    [SupportedApiProfile("openxr", ["XR_META_spatial_entity_group_sharing"])]
    ShareSpacesRecipientGroupsMETA = 1000572000,

    [NativeName("XR_TYPE_SPACE_GROUP_UUID_FILTER_INFO_META")]
    [SupportedApiProfile("openxr", ["XR_META_spatial_entity_group_sharing"])]
    SpaceGroupUuidFilterInfoMETA = 1000572001,

    [NativeName("XR_TYPE_SYSTEM_SPATIAL_ENTITY_GROUP_SHARING_PROPERTIES_META")]
    [SupportedApiProfile("openxr", ["XR_META_spatial_entity_group_sharing"])]
    SystemSpatialEntityGroupSharingPropertiesMETA = 1000572100,

    [NativeName("XR_TYPE_SYSTEM_ENVIRONMENT_RAYCAST_PROPERTIES_META")]
    [SupportedApiProfile(
        "openxr",
        ["XR_META_environment_raycast"],
        ImpliesSets = ["XR_EXT_future"]
    )]
    SystemEnvironmentRaycastPropertiesMETA = 1000592000,

    [NativeName("XR_TYPE_ENVIRONMENT_RAYCASTER_CREATE_INFO_META")]
    [SupportedApiProfile(
        "openxr",
        ["XR_META_environment_raycast"],
        ImpliesSets = ["XR_EXT_future"]
    )]
    EnvironmentRaycasterCreateInfoMETA = 1000592001,

    [NativeName("XR_TYPE_ENVIRONMENT_RAYCASTER_CREATE_COMPLETION_META")]
    [SupportedApiProfile(
        "openxr",
        ["XR_META_environment_raycast"],
        ImpliesSets = ["XR_EXT_future"]
    )]
    EnvironmentRaycasterCreateCompletionMETA = 1000592002,

    [NativeName("XR_TYPE_ENVIRONMENT_RAYCAST_HIT_GET_INFO_META")]
    [SupportedApiProfile(
        "openxr",
        ["XR_META_environment_raycast"],
        ImpliesSets = ["XR_EXT_future"]
    )]
    EnvironmentRaycastHitGetInfoMETA = 1000592003,

    [NativeName("XR_TYPE_ENVIRONMENT_RAYCAST_HIT_META")]
    [SupportedApiProfile(
        "openxr",
        ["XR_META_environment_raycast"],
        ImpliesSets = ["XR_EXT_future"]
    )]
    EnvironmentRaycastHitMETA = 1000592004,

    [NativeName("XR_TYPE_ENVIRONMENT_RAYCAST_FILTER_DISTANCE_META")]
    [SupportedApiProfile(
        "openxr",
        ["XR_META_environment_raycast"],
        ImpliesSets = ["XR_EXT_future"]
    )]
    EnvironmentRaycastFilterDistanceMETA = 1000592005,

    [NativeName("XR_TYPE_TILE_PROPERTIES_META")]
    [SupportedApiProfile("openxr", ["XR_META_tile_properties_hint"])]
    TilePropertiesMETA = 1000609000,

    [NativeName("XR_TYPE_TILE_PROPERTIES_HINT_META")]
    [SupportedApiProfile("openxr", ["XR_META_tile_properties_hint"])]
    TilePropertiesHintMETA = 1000609001,

    [NativeName("XR_TYPE_LIGHT_ESTIMATOR_CREATE_INFO_ANDROID")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_light_estimation"])]
    LightEstimatorCreateInfoANDROID = 1000700000,

    [NativeName("XR_TYPE_LIGHT_ESTIMATE_GET_INFO_ANDROID")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_light_estimation"])]
    LightEstimateGetInfoANDROID = 1000700001,

    [NativeName("XR_TYPE_LIGHT_ESTIMATE_ANDROID")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_light_estimation"])]
    LightEstimateANDROID = 1000700002,

    [NativeName("XR_TYPE_DIRECTIONAL_LIGHT_ANDROID")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_light_estimation"])]
    DirectionalLightANDROID = 1000700003,

    [NativeName("XR_TYPE_SPHERICAL_HARMONICS_ANDROID")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_light_estimation"])]
    SphericalHarmonicsANDROID = 1000700004,

    [NativeName("XR_TYPE_AMBIENT_LIGHT_ANDROID")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_light_estimation"])]
    AmbientLightANDROID = 1000700005,

    [NativeName("XR_TYPE_SYSTEM_LIGHT_ESTIMATION_PROPERTIES_ANDROID")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_light_estimation"])]
    SystemLightEstimationPropertiesANDROID = 1000700006,

    [NativeName("XR_TYPE_ANCHOR_SHARING_INFO_ANDROID")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_anchor_sharing_export"])]
    AnchorSharingInfoANDROID = 1000701000,

    [NativeName("XR_TYPE_ANCHOR_SHARING_TOKEN_ANDROID")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_anchor_sharing_export"])]
    AnchorSharingTokenANDROID = 1000701001,

    [NativeName("XR_TYPE_SYSTEM_ANCHOR_SHARING_EXPORT_PROPERTIES_ANDROID")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_anchor_sharing_export"])]
    SystemAnchorSharingExportPropertiesANDROID = 1000701002,

    [NativeName("XR_TYPE_SYSTEM_MARKER_TRACKING_PROPERTIES_ANDROID")]
    [SupportedApiProfile(
        "openxr",
        ["XR_ANDROID_trackables_marker"],
        ImpliesSets = ["XR_ANDROID_trackables"]
    )]
    SystemMarkerTrackingPropertiesANDROID = 1000707000,

    [NativeName("XR_TYPE_TRACKABLE_MARKER_CONFIGURATION_ANDROID")]
    [SupportedApiProfile(
        "openxr",
        ["XR_ANDROID_trackables_marker"],
        ImpliesSets = ["XR_ANDROID_trackables"]
    )]
    TrackableMarkerConfigurationANDROID = 1000707001,

    [NativeName("XR_TYPE_TRACKABLE_MARKER_ANDROID")]
    [SupportedApiProfile(
        "openxr",
        ["XR_ANDROID_trackables_marker"],
        ImpliesSets = ["XR_ANDROID_trackables"]
    )]
    TrackableMarkerANDROID = 1000707002,

    [NativeName("XR_TYPE_SYSTEM_QR_CODE_TRACKING_PROPERTIES_ANDROID")]
    [SupportedApiProfile(
        "openxr",
        ["XR_ANDROID_trackables_qr_code"],
        ImpliesSets = ["XR_ANDROID_trackables"]
    )]
    SystemQrCodeTrackingPropertiesANDROID = 1000708000,

    [NativeName("XR_TYPE_TRACKABLE_QR_CODE_CONFIGURATION_ANDROID")]
    [SupportedApiProfile(
        "openxr",
        ["XR_ANDROID_trackables_qr_code"],
        ImpliesSets = ["XR_ANDROID_trackables"]
    )]
    TrackableQrCodeConfigurationANDROID = 1000708001,

    [NativeName("XR_TYPE_TRACKABLE_QR_CODE_ANDROID")]
    [SupportedApiProfile(
        "openxr",
        ["XR_ANDROID_trackables_qr_code"],
        ImpliesSets = ["XR_ANDROID_trackables"]
    )]
    TrackableQrCodeANDROID = 1000708002,

    [NativeName("XR_TYPE_SYSTEM_IMAGE_TRACKING_PROPERTIES_ANDROID")]
    [SupportedApiProfile(
        "openxr",
        ["XR_ANDROID_trackables_image"],
        ImpliesSets = ["XR_ANDROID_trackables", "XR_EXT_future"]
    )]
    SystemImageTrackingPropertiesANDROID = 1000709000,

    [NativeName("XR_TYPE_TRACKABLE_IMAGE_DATABASE_ENTRY_ANDROID")]
    [SupportedApiProfile(
        "openxr",
        ["XR_ANDROID_trackables_image"],
        ImpliesSets = ["XR_ANDROID_trackables", "XR_EXT_future"]
    )]
    TrackableImageDatabaseEntryANDROID = 1000709001,

    [NativeName("XR_TYPE_TRACKABLE_IMAGE_DATABASE_CREATE_INFO_ANDROID")]
    [SupportedApiProfile(
        "openxr",
        ["XR_ANDROID_trackables_image"],
        ImpliesSets = ["XR_ANDROID_trackables", "XR_EXT_future"]
    )]
    TrackableImageDatabaseCreateInfoANDROID = 1000709002,

    [NativeName("XR_TYPE_CREATE_TRACKABLE_IMAGE_DATABASE_COMPLETION_ANDROID")]
    [SupportedApiProfile(
        "openxr",
        ["XR_ANDROID_trackables_image"],
        ImpliesSets = ["XR_ANDROID_trackables", "XR_EXT_future"]
    )]
    CreateTrackableImageDatabaseCompletionANDROID = 1000709003,

    [NativeName("XR_TYPE_TRACKABLE_IMAGE_CONFIGURATION_ANDROID")]
    [SupportedApiProfile(
        "openxr",
        ["XR_ANDROID_trackables_image"],
        ImpliesSets = ["XR_ANDROID_trackables", "XR_EXT_future"]
    )]
    TrackableImageConfigurationANDROID = 1000709004,

    [NativeName("XR_TYPE_TRACKABLE_IMAGE_ANDROID")]
    [SupportedApiProfile(
        "openxr",
        ["XR_ANDROID_trackables_image"],
        ImpliesSets = ["XR_ANDROID_trackables", "XR_EXT_future"]
    )]
    TrackableImageANDROID = 1000709005,

    [NativeName("XR_TYPE_EVENT_DATA_IMAGE_TRACKING_LOST_ANDROID")]
    [SupportedApiProfile(
        "openxr",
        ["XR_ANDROID_trackables_image"],
        ImpliesSets = ["XR_ANDROID_trackables", "XR_EXT_future"]
    )]
    EventDataImageTrackingLostANDROID = 1000709006,

    [NativeName("XR_TYPE_SYSTEM_SCENE_MESHING_PROPERTIES_ANDROID")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_scene_meshing"])]
    SystemSceneMeshingPropertiesANDROID = 1000718000,

    [NativeName("XR_TYPE_SCENE_MESHING_TRACKER_CREATE_INFO_ANDROID")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_scene_meshing"])]
    SceneMeshingTrackerCreateInfoANDROID = 1000718001,

    [NativeName("XR_TYPE_SCENE_MESH_SNAPSHOT_CREATE_INFO_ANDROID")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_scene_meshing"])]
    SceneMeshSnapshotCreateInfoANDROID = 1000718002,

    [NativeName("XR_TYPE_SCENE_MESH_SNAPSHOT_CREATION_RESULT_ANDROID")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_scene_meshing"])]
    SceneMeshSnapshotCreationResultANDROID = 1000718003,

    [NativeName("XR_TYPE_SCENE_SUBMESH_STATE_ANDROID")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_scene_meshing"])]
    SceneSubmeshStateANDROID = 1000718004,

    [NativeName("XR_TYPE_SCENE_SUBMESH_DATA_ANDROID")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_scene_meshing"])]
    SceneSubmeshDataANDROID = 1000718005,

    [NativeName("XR_TYPE_SPATIAL_CAPABILITY_COMPONENT_TYPES_EXT")]
    [SupportedApiProfile("openxr", ["XR_EXT_spatial_entity"], ImpliesSets = ["XR_EXT_future"])]
    SpatialCapabilityComponentTypesEXT = 1000740000,

    [NativeName("XR_TYPE_SPATIAL_CONTEXT_CREATE_INFO_EXT")]
    [SupportedApiProfile("openxr", ["XR_EXT_spatial_entity"], ImpliesSets = ["XR_EXT_future"])]
    SpatialContextCreateInfoEXT = 1000740001,

    [NativeName("XR_TYPE_CREATE_SPATIAL_CONTEXT_COMPLETION_EXT")]
    [SupportedApiProfile("openxr", ["XR_EXT_spatial_entity"], ImpliesSets = ["XR_EXT_future"])]
    CreateSpatialContextCompletionEXT = 1000740002,

    [NativeName("XR_TYPE_SPATIAL_DISCOVERY_SNAPSHOT_CREATE_INFO_EXT")]
    [SupportedApiProfile("openxr", ["XR_EXT_spatial_entity"], ImpliesSets = ["XR_EXT_future"])]
    SpatialDiscoverySnapshotCreateInfoEXT = 1000740003,

    [NativeName("XR_TYPE_CREATE_SPATIAL_DISCOVERY_SNAPSHOT_COMPLETION_INFO_EXT")]
    [SupportedApiProfile("openxr", ["XR_EXT_spatial_entity"], ImpliesSets = ["XR_EXT_future"])]
    CreateSpatialDiscoverySnapshotCompletionInfoEXT = 1000740004,

    [NativeName("XR_TYPE_CREATE_SPATIAL_DISCOVERY_SNAPSHOT_COMPLETION_EXT")]
    [SupportedApiProfile("openxr", ["XR_EXT_spatial_entity"], ImpliesSets = ["XR_EXT_future"])]
    CreateSpatialDiscoverySnapshotCompletionEXT = 1000740005,

    [NativeName("XR_TYPE_SPATIAL_COMPONENT_DATA_QUERY_CONDITION_EXT")]
    [SupportedApiProfile("openxr", ["XR_EXT_spatial_entity"], ImpliesSets = ["XR_EXT_future"])]
    SpatialComponentDataQueryConditionEXT = 1000740006,

    [NativeName("XR_TYPE_SPATIAL_COMPONENT_DATA_QUERY_RESULT_EXT")]
    [SupportedApiProfile("openxr", ["XR_EXT_spatial_entity"], ImpliesSets = ["XR_EXT_future"])]
    SpatialComponentDataQueryResultEXT = 1000740007,

    [NativeName("XR_TYPE_SPATIAL_BUFFER_GET_INFO_EXT")]
    [SupportedApiProfile("openxr", ["XR_EXT_spatial_entity"], ImpliesSets = ["XR_EXT_future"])]
    SpatialBufferGetInfoEXT = 1000740008,

    [NativeName("XR_TYPE_SPATIAL_COMPONENT_BOUNDED_2D_LIST_EXT")]
    [SupportedApiProfile("openxr", ["XR_EXT_spatial_entity"], ImpliesSets = ["XR_EXT_future"])]
    SpatialComponentBounded2DListEXT = 1000740009,

    [NativeName("XR_TYPE_SPATIAL_COMPONENT_BOUNDED_3D_LIST_EXT")]
    [SupportedApiProfile("openxr", ["XR_EXT_spatial_entity"], ImpliesSets = ["XR_EXT_future"])]
    SpatialComponentBounded3DListEXT = 1000740010,

    [NativeName("XR_TYPE_SPATIAL_COMPONENT_PARENT_LIST_EXT")]
    [SupportedApiProfile("openxr", ["XR_EXT_spatial_entity"], ImpliesSets = ["XR_EXT_future"])]
    SpatialComponentParentListEXT = 1000740011,

    [NativeName("XR_TYPE_SPATIAL_COMPONENT_MESH_3D_LIST_EXT")]
    [SupportedApiProfile("openxr", ["XR_EXT_spatial_entity"], ImpliesSets = ["XR_EXT_future"])]
    SpatialComponentMesh3DListEXT = 1000740012,

    [NativeName("XR_TYPE_SPATIAL_ENTITY_FROM_ID_CREATE_INFO_EXT")]
    [SupportedApiProfile("openxr", ["XR_EXT_spatial_entity"], ImpliesSets = ["XR_EXT_future"])]
    SpatialEntityFromIdCreateInfoEXT = 1000740013,

    [NativeName("XR_TYPE_SPATIAL_UPDATE_SNAPSHOT_CREATE_INFO_EXT")]
    [SupportedApiProfile("openxr", ["XR_EXT_spatial_entity"], ImpliesSets = ["XR_EXT_future"])]
    SpatialUpdateSnapshotCreateInfoEXT = 1000740014,

    [NativeName("XR_TYPE_EVENT_DATA_SPATIAL_DISCOVERY_RECOMMENDED_EXT")]
    [SupportedApiProfile("openxr", ["XR_EXT_spatial_entity"], ImpliesSets = ["XR_EXT_future"])]
    EventDataSpatialDiscoveryRecommendedEXT = 1000740015,

    [NativeName("XR_TYPE_SPATIAL_FILTER_TRACKING_STATE_EXT")]
    [SupportedApiProfile("openxr", ["XR_EXT_spatial_entity"], ImpliesSets = ["XR_EXT_future"])]
    SpatialFilterTrackingStateEXT = 1000740016,

    [NativeName("XR_TYPE_SPATIAL_CAPABILITY_CONFIGURATION_PLANE_TRACKING_EXT")]
    [SupportedApiProfile(
        "openxr",
        ["XR_EXT_spatial_plane_tracking"],
        ImpliesSets = ["XR_EXT_spatial_entity"]
    )]
    SpatialCapabilityConfigurationPlaneTrackingEXT = 1000741000,

    [NativeName("XR_TYPE_SPATIAL_COMPONENT_PLANE_ALIGNMENT_LIST_EXT")]
    [SupportedApiProfile(
        "openxr",
        ["XR_EXT_spatial_plane_tracking"],
        ImpliesSets = ["XR_EXT_spatial_entity"]
    )]
    SpatialComponentPlaneAlignmentListEXT = 1000741001,

    [NativeName("XR_TYPE_SPATIAL_COMPONENT_MESH_2D_LIST_EXT")]
    [SupportedApiProfile(
        "openxr",
        ["XR_EXT_spatial_plane_tracking"],
        ImpliesSets = ["XR_EXT_spatial_entity"]
    )]
    SpatialComponentMesh2DListEXT = 1000741002,

    [NativeName("XR_TYPE_SPATIAL_COMPONENT_POLYGON_2D_LIST_EXT")]
    [SupportedApiProfile(
        "openxr",
        ["XR_EXT_spatial_plane_tracking"],
        ImpliesSets = ["XR_EXT_spatial_entity"]
    )]
    SpatialComponentPolygon2DListEXT = 1000741003,

    [NativeName("XR_TYPE_SPATIAL_COMPONENT_PLANE_SEMANTIC_LABEL_LIST_EXT")]
    [SupportedApiProfile(
        "openxr",
        ["XR_EXT_spatial_plane_tracking"],
        ImpliesSets = ["XR_EXT_spatial_entity"]
    )]
    SpatialComponentPlaneSemanticLabelListEXT = 1000741004,

    [NativeName("XR_TYPE_STATIONARY_REFERENCE_SPACE_GENERATION_ID_GET_INFO_EXT")]
    [SupportedApiProfile(
        "openxr",
        ["XR_EXT_stationary_reference_space"],
        ImpliesSets = ["XR_EXT_uuid", "XR_VERSION_1_0"]
    )]
    StationaryReferenceSpaceGenerationIdGetInfoEXT = 1000742001,

    [NativeName("XR_TYPE_STATIONARY_REFERENCE_SPACE_GENERATION_ID_RESULT_EXT")]
    [SupportedApiProfile(
        "openxr",
        ["XR_EXT_stationary_reference_space"],
        ImpliesSets = ["XR_EXT_uuid", "XR_VERSION_1_0"]
    )]
    StationaryReferenceSpaceGenerationIdResultEXT = 1000742002,

    [NativeName("XR_TYPE_SPATIAL_CAPABILITY_CONFIGURATION_QR_CODE_EXT")]
    [SupportedApiProfile(
        "openxr",
        ["XR_EXT_spatial_marker_tracking"],
        ImpliesSets = ["XR_EXT_spatial_entity"]
    )]
    SpatialCapabilityConfigurationQrCodeEXT = 1000743000,

    [NativeName("XR_TYPE_SPATIAL_CAPABILITY_CONFIGURATION_MICRO_QR_CODE_EXT")]
    [SupportedApiProfile(
        "openxr",
        ["XR_EXT_spatial_marker_tracking"],
        ImpliesSets = ["XR_EXT_spatial_entity"]
    )]
    SpatialCapabilityConfigurationMicroQrCodeEXT = 1000743001,

    [NativeName("XR_TYPE_SPATIAL_CAPABILITY_CONFIGURATION_ARUCO_MARKER_EXT")]
    [SupportedApiProfile(
        "openxr",
        ["XR_EXT_spatial_marker_tracking"],
        ImpliesSets = ["XR_EXT_spatial_entity"]
    )]
    SpatialCapabilityConfigurationArucoMarkerEXT = 1000743002,

    [NativeName("XR_TYPE_SPATIAL_CAPABILITY_CONFIGURATION_APRIL_TAG_EXT")]
    [SupportedApiProfile(
        "openxr",
        ["XR_EXT_spatial_marker_tracking"],
        ImpliesSets = ["XR_EXT_spatial_entity"]
    )]
    SpatialCapabilityConfigurationAprilTagEXT = 1000743003,

    [NativeName("XR_TYPE_SPATIAL_MARKER_SIZE_EXT")]
    [SupportedApiProfile(
        "openxr",
        ["XR_EXT_spatial_marker_tracking"],
        ImpliesSets = ["XR_EXT_spatial_entity"]
    )]
    SpatialMarkerSizeEXT = 1000743004,

    [NativeName("XR_TYPE_SPATIAL_MARKER_STATIC_OPTIMIZATION_EXT")]
    [SupportedApiProfile(
        "openxr",
        ["XR_EXT_spatial_marker_tracking"],
        ImpliesSets = ["XR_EXT_spatial_entity"]
    )]
    SpatialMarkerStaticOptimizationEXT = 1000743005,

    [NativeName("XR_TYPE_SPATIAL_COMPONENT_MARKER_LIST_EXT")]
    [SupportedApiProfile(
        "openxr",
        ["XR_EXT_spatial_marker_tracking"],
        ImpliesSets = ["XR_EXT_spatial_entity"]
    )]
    SpatialComponentMarkerListEXT = 1000743006,

    [NativeName("XR_TYPE_SPATIAL_CAPABILITY_CONFIGURATION_ANCHOR_EXT")]
    [SupportedApiProfile(
        "openxr",
        ["XR_EXT_spatial_anchor"],
        ImpliesSets = ["XR_EXT_spatial_entity"]
    )]
    SpatialCapabilityConfigurationAnchorEXT = 1000762000,

    [NativeName("XR_TYPE_SPATIAL_COMPONENT_ANCHOR_LIST_EXT")]
    [SupportedApiProfile(
        "openxr",
        ["XR_EXT_spatial_anchor"],
        ImpliesSets = ["XR_EXT_spatial_entity"]
    )]
    SpatialComponentAnchorListEXT = 1000762001,

    [NativeName("XR_TYPE_SPATIAL_ANCHOR_CREATE_INFO_EXT")]
    [SupportedApiProfile(
        "openxr",
        ["XR_EXT_spatial_anchor"],
        ImpliesSets = ["XR_EXT_spatial_entity"]
    )]
    SpatialAnchorCreateInfoEXT = 1000762002,

    [NativeName("XR_TYPE_SPATIAL_PERSISTENCE_CONTEXT_CREATE_INFO_EXT")]
    [SupportedApiProfile(
        "openxr",
        ["XR_EXT_spatial_persistence"],
        ImpliesSets = ["XR_EXT_future", "XR_EXT_spatial_entity"]
    )]
    SpatialPersistenceContextCreateInfoEXT = 1000763000,

    [NativeName("XR_TYPE_CREATE_SPATIAL_PERSISTENCE_CONTEXT_COMPLETION_EXT")]
    [SupportedApiProfile(
        "openxr",
        ["XR_EXT_spatial_persistence"],
        ImpliesSets = ["XR_EXT_future", "XR_EXT_spatial_entity"]
    )]
    CreateSpatialPersistenceContextCompletionEXT = 1000763001,

    [NativeName("XR_TYPE_SPATIAL_CONTEXT_PERSISTENCE_CONFIG_EXT")]
    [SupportedApiProfile(
        "openxr",
        ["XR_EXT_spatial_persistence"],
        ImpliesSets = ["XR_EXT_future", "XR_EXT_spatial_entity"]
    )]
    SpatialContextPersistenceConfigEXT = 1000763002,

    [NativeName("XR_TYPE_SPATIAL_DISCOVERY_PERSISTENCE_UUID_FILTER_EXT")]
    [SupportedApiProfile(
        "openxr",
        ["XR_EXT_spatial_persistence"],
        ImpliesSets = ["XR_EXT_future", "XR_EXT_spatial_entity"]
    )]
    SpatialDiscoveryPersistenceUuidFilterEXT = 1000763003,

    [NativeName("XR_TYPE_SPATIAL_COMPONENT_PERSISTENCE_LIST_EXT")]
    [SupportedApiProfile(
        "openxr",
        ["XR_EXT_spatial_persistence"],
        ImpliesSets = ["XR_EXT_future", "XR_EXT_spatial_entity"]
    )]
    SpatialComponentPersistenceListEXT = 1000763004,

    [NativeName("XR_TYPE_HAPTIC_PARAMETRIC_VIBRATION_EXT")]
    [SupportedApiProfile("openxr", ["XR_EXT_haptic_parametric"])]
    HapticParametricVibrationEXT = 1000775000,

    [NativeName("XR_TYPE_HAPTIC_PARAMETRIC_PROPERTIES_EXT")]
    [SupportedApiProfile("openxr", ["XR_EXT_haptic_parametric"])]
    HapticParametricPropertiesEXT = 1000775001,

    [NativeName("XR_TYPE_SYSTEM_HAPTIC_PARAMETRIC_PROPERTIES_EXT")]
    [SupportedApiProfile("openxr", ["XR_EXT_haptic_parametric"])]
    SystemHapticParametricPropertiesEXT = 1000775002,

    [NativeName("XR_TYPE_SPATIAL_ENTITY_PERSIST_INFO_EXT")]
    [SupportedApiProfile(
        "openxr",
        ["XR_EXT_spatial_persistence_operations"],
        ImpliesSets = ["XR_EXT_future", "XR_EXT_spatial_persistence"]
    )]
    SpatialEntityPersistInfoEXT = 1000781000,

    [NativeName("XR_TYPE_PERSIST_SPATIAL_ENTITY_COMPLETION_EXT")]
    [SupportedApiProfile(
        "openxr",
        ["XR_EXT_spatial_persistence_operations"],
        ImpliesSets = ["XR_EXT_future", "XR_EXT_spatial_persistence"]
    )]
    PersistSpatialEntityCompletionEXT = 1000781001,

    [NativeName("XR_TYPE_SPATIAL_ENTITY_UNPERSIST_INFO_EXT")]
    [SupportedApiProfile(
        "openxr",
        ["XR_EXT_spatial_persistence_operations"],
        ImpliesSets = ["XR_EXT_future", "XR_EXT_spatial_persistence"]
    )]
    SpatialEntityUnpersistInfoEXT = 1000781002,

    [NativeName("XR_TYPE_UNPERSIST_SPATIAL_ENTITY_COMPLETION_EXT")]
    [SupportedApiProfile(
        "openxr",
        ["XR_EXT_spatial_persistence_operations"],
        ImpliesSets = ["XR_EXT_future", "XR_EXT_spatial_persistence"]
    )]
    UnpersistSpatialEntityCompletionEXT = 1000781003,

    [NativeName("XR_TYPE_SPATIAL_CAPABILITY_CONFIGURATION_OBJECT_TRACKING_ANDROID")]
    [SupportedApiProfile(
        "openxr",
        ["XR_ANDROID_spatial_object_tracking"],
        ImpliesSets = ["XR_EXT_spatial_entity"]
    )]
    SpatialCapabilityConfigurationObjectTrackingANDROID = 1000785000,

    [NativeName("XR_TYPE_SPATIAL_COMPONENT_OBJECT_SEMANTIC_LABEL_LIST_ANDROID")]
    [SupportedApiProfile(
        "openxr",
        ["XR_ANDROID_spatial_object_tracking"],
        ImpliesSets = ["XR_EXT_spatial_entity"]
    )]
    SpatialComponentObjectSemanticLabelListANDROID = 1000785001,

    [NativeName("XR_TYPE_SPATIAL_CAPABILITY_CONFIGURATION_DEPTH_RAYCAST_ANDROID")]
    [SupportedApiProfile(
        "openxr",
        ["XR_ANDROID_spatial_discovery_raycast"],
        ImpliesSets = ["XR_EXT_spatial_entity"]
    )]
    SpatialCapabilityConfigurationDepthRaycastANDROID = 1000786000,

    [NativeName("XR_TYPE_SPATIAL_RAYCAST_INFO_ANDROID")]
    [SupportedApiProfile(
        "openxr",
        ["XR_ANDROID_spatial_discovery_raycast"],
        ImpliesSets = ["XR_EXT_spatial_entity"]
    )]
    SpatialRaycastInfoANDROID = 1000786001,

    [NativeName("XR_TYPE_SPATIAL_COMPONENT_RAYCAST_RESULT_LIST_ANDROID")]
    [SupportedApiProfile(
        "openxr",
        ["XR_ANDROID_spatial_discovery_raycast"],
        ImpliesSets = ["XR_EXT_spatial_entity"]
    )]
    SpatialComponentRaycastResultListANDROID = 1000786002,

    [NativeName("XR_TYPE_SPATIAL_RAYCAST_SNAPSHOT_CREATE_INFO_ANDROID")]
    [SupportedApiProfile(
        "openxr",
        ["XR_ANDROID_spatial_discovery_raycast"],
        ImpliesSets = ["XR_EXT_spatial_entity"]
    )]
    SpatialRaycastSnapshotCreateInfoANDROID = 1000786003,

    [NativeName("XR_TYPE_SPATIAL_ANCHOR_PARENT_ANDROID")]
    [SupportedApiProfile(
        "openxr",
        ["XR_ANDROID_spatial_entity_bound_anchor"],
        ImpliesSets = ["XR_EXT_spatial_anchor"]
    )]
    SpatialAnchorParentANDROID = 1000790000,

    [NativeName("XR_TYPE_SPATIAL_DISCOVERY_UNIQUE_ENTITIES_FILTER_ANDROID")]
    [SupportedApiProfile(
        "openxr",
        ["XR_ANDROID_spatial_component_subsumed_by"],
        ImpliesSets = ["XR_EXT_spatial_entity", "XR_EXT_spatial_plane_tracking"]
    )]
    SpatialDiscoveryUniqueEntitiesFilterANDROID = 1000791001,

    [NativeName("XR_TYPE_SPATIAL_COMPONENT_SUBSUMED_BY_LIST_ANDROID")]
    [SupportedApiProfile(
        "openxr",
        ["XR_ANDROID_spatial_component_subsumed_by"],
        ImpliesSets = ["XR_EXT_spatial_entity", "XR_EXT_spatial_plane_tracking"]
    )]
    SpatialComponentSubsumedByListANDROID = 1000791002,

    [NativeName("XR_TYPE_SPATIAL_ANCHOR_SPACE_FROM_ID_CREATE_INFO_ANDROID")]
    [SupportedApiProfile(
        "openxr",
        ["XR_ANDROID_spatial_anchor_space"],
        ImpliesSets = ["XR_EXT_spatial_anchor"]
    )]
    SpatialAnchorSpaceFromIdCreateInfoANDROID = 1000795000,

    [NativeName("XR_TYPE_BATTERY_STATE_DISPLAY_EXT")]
    [SupportedApiProfile("openxr", ["XR_EXT_interaction_profile_battery_state_display"])]
    BatteryStateDisplayEXT = 1000836000,

    [NativeName("XR_TYPE_LOADER_INIT_INFO_PROPERTIES_EXT")]
    [SupportedApiProfile("openxr", ["XR_EXT_loader_init_properties"])]
    LoaderInitInfoPropertiesEXT = 1000838000,

    [NativeName("XR_TYPE_EVENT_DATA_VIEW_CONFIGURATION_VIEWS_CHANGED_EXT")]
    [SupportedApiProfile("openxr", ["XR_EXT_view_configuration_views_change"])]
    EventDataViewConfigurationViewsChangedEXT = 1000839000,

    [NativeName("XR_TYPE_GRAPHICS_BINDING_VULKAN2_KHR")]
    [SupportedApiProfile("openxr", ["XR_KHR_vulkan_enable2"])]
    GraphicsBindingVulkan2KHR = GraphicsBindingVulkanKHR,

    [NativeName("XR_TYPE_SWAPCHAIN_IMAGE_VULKAN2_KHR")]
    [SupportedApiProfile("openxr", ["XR_KHR_vulkan_enable2"])]
    SwapchainImageVulkan2KHR = SwapchainImageVulkanKHR,

    [NativeName("XR_TYPE_GRAPHICS_REQUIREMENTS_VULKAN2_KHR")]
    [SupportedApiProfile("openxr", ["XR_KHR_vulkan_enable2"])]
    GraphicsRequirementsVulkan2KHR = GraphicsRequirementsVulkanKHR,

    [NativeName("XR_TYPE_DEVICE_PCM_SAMPLE_RATE_GET_INFO_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_haptic_pcm"])]
    DevicePcmSampleRateGetInfoFB = DevicePcmSampleRateStateFB,

    [NativeName("XR_TYPE_SPACES_LOCATE_INFO_KHR")]
    [SupportedApiProfile("openxr", ["XR_KHR_locate_spaces"])]
    SpacesLocateInfoKHR = SpacesLocateInfo,

    [NativeName("XR_TYPE_SPACE_LOCATIONS_KHR")]
    [SupportedApiProfile("openxr", ["XR_KHR_locate_spaces"])]
    SpaceLocationsKHR = SpaceLocations,

    [NativeName("XR_TYPE_SPACE_VELOCITIES_KHR")]
    [SupportedApiProfile("openxr", ["XR_KHR_locate_spaces"])]
    SpaceVelocitiesKHR = SpaceVelocities,
}
