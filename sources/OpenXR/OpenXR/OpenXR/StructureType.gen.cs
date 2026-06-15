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
    TypeUnknown = 0,

    [NativeName("XR_TYPE_API_LAYER_PROPERTIES")]
    [SupportedApiProfile("openxr")]
    TypeApiLayerProperties = 1,

    [NativeName("XR_TYPE_EXTENSION_PROPERTIES")]
    [SupportedApiProfile("openxr")]
    TypeExtensionProperties = 2,

    [NativeName("XR_TYPE_INSTANCE_CREATE_INFO")]
    [SupportedApiProfile("openxr")]
    TypeInstanceCreateInfo = 3,

    [NativeName("XR_TYPE_SYSTEM_GET_INFO")]
    [SupportedApiProfile("openxr")]
    TypeSystemGetInfo = 4,

    [NativeName("XR_TYPE_SYSTEM_PROPERTIES")]
    [SupportedApiProfile("openxr")]
    TypeSystemProperties = 5,

    [NativeName("XR_TYPE_VIEW_LOCATE_INFO")]
    [SupportedApiProfile("openxr")]
    TypeViewLocateInfo = 6,

    [NativeName("XR_TYPE_VIEW")]
    [SupportedApiProfile("openxr")]
    TypeView = 7,

    [NativeName("XR_TYPE_SESSION_CREATE_INFO")]
    [SupportedApiProfile("openxr")]
    TypeSessionCreateInfo = 8,

    [NativeName("XR_TYPE_SWAPCHAIN_CREATE_INFO")]
    [SupportedApiProfile("openxr")]
    TypeSwapchainCreateInfo = 9,

    [NativeName("XR_TYPE_SESSION_BEGIN_INFO")]
    [SupportedApiProfile("openxr")]
    TypeSessionBeginInfo = 10,

    [NativeName("XR_TYPE_VIEW_STATE")]
    [SupportedApiProfile("openxr")]
    TypeViewState = 11,

    [NativeName("XR_TYPE_FRAME_END_INFO")]
    [SupportedApiProfile("openxr")]
    TypeFrameEndInfo = 12,

    [NativeName("XR_TYPE_HAPTIC_VIBRATION")]
    [SupportedApiProfile("openxr")]
    TypeHapticVibration = 13,

    [NativeName("XR_TYPE_EVENT_DATA_BUFFER")]
    [SupportedApiProfile("openxr")]
    TypeEventDataBuffer = 16,

    [NativeName("XR_TYPE_EVENT_DATA_INSTANCE_LOSS_PENDING")]
    [SupportedApiProfile("openxr")]
    TypeEventDataInstanceLossPending = 17,

    [NativeName("XR_TYPE_EVENT_DATA_SESSION_STATE_CHANGED")]
    [SupportedApiProfile("openxr")]
    TypeEventDataSessionStateChanged = 18,

    [NativeName("XR_TYPE_ACTION_STATE_BOOLEAN")]
    [SupportedApiProfile("openxr")]
    TypeActionStateBoolean = 23,

    [NativeName("XR_TYPE_ACTION_STATE_FLOAT")]
    [SupportedApiProfile("openxr")]
    TypeActionStateFloat = 24,

    [NativeName("XR_TYPE_ACTION_STATE_VECTOR2F")]
    [SupportedApiProfile("openxr")]
    TypeActionStateVector2F = 25,

    [NativeName("XR_TYPE_ACTION_STATE_POSE")]
    [SupportedApiProfile("openxr")]
    TypeActionStatePose = 27,

    [NativeName("XR_TYPE_ACTION_SET_CREATE_INFO")]
    [SupportedApiProfile("openxr")]
    TypeActionSetCreateInfo = 28,

    [NativeName("XR_TYPE_ACTION_CREATE_INFO")]
    [SupportedApiProfile("openxr")]
    TypeActionCreateInfo = 29,

    [NativeName("XR_TYPE_INSTANCE_PROPERTIES")]
    [SupportedApiProfile("openxr")]
    TypeInstanceProperties = 32,

    [NativeName("XR_TYPE_FRAME_WAIT_INFO")]
    [SupportedApiProfile("openxr")]
    TypeFrameWaitInfo = 33,

    [NativeName("XR_TYPE_COMPOSITION_LAYER_PROJECTION")]
    [SupportedApiProfile("openxr")]
    TypeCompositionLayerProjection = 35,

    [NativeName("XR_TYPE_COMPOSITION_LAYER_QUAD")]
    [SupportedApiProfile("openxr")]
    TypeCompositionLayerQuad = 36,

    [NativeName("XR_TYPE_REFERENCE_SPACE_CREATE_INFO")]
    [SupportedApiProfile("openxr")]
    TypeReferenceSpaceCreateInfo = 37,

    [NativeName("XR_TYPE_ACTION_SPACE_CREATE_INFO")]
    [SupportedApiProfile("openxr")]
    TypeActionSpaceCreateInfo = 38,

    [NativeName("XR_TYPE_EVENT_DATA_REFERENCE_SPACE_CHANGE_PENDING")]
    [SupportedApiProfile("openxr")]
    TypeEventDataReferenceSpaceChangePending = 40,

    [NativeName("XR_TYPE_VIEW_CONFIGURATION_VIEW")]
    [SupportedApiProfile("openxr")]
    TypeViewConfigurationView = 41,

    [NativeName("XR_TYPE_SPACE_LOCATION")]
    [SupportedApiProfile("openxr")]
    TypeSpaceLocation = 42,

    [NativeName("XR_TYPE_SPACE_VELOCITY")]
    [SupportedApiProfile("openxr")]
    TypeSpaceVelocity = 43,

    [NativeName("XR_TYPE_FRAME_STATE")]
    [SupportedApiProfile("openxr")]
    TypeFrameState = 44,

    [NativeName("XR_TYPE_VIEW_CONFIGURATION_PROPERTIES")]
    [SupportedApiProfile("openxr")]
    TypeViewConfigurationProperties = 45,

    [NativeName("XR_TYPE_FRAME_BEGIN_INFO")]
    [SupportedApiProfile("openxr")]
    TypeFrameBeginInfo = 46,

    [NativeName("XR_TYPE_COMPOSITION_LAYER_PROJECTION_VIEW")]
    [SupportedApiProfile("openxr")]
    TypeCompositionLayerProjectionView = 48,

    [NativeName("XR_TYPE_EVENT_DATA_EVENTS_LOST")]
    [SupportedApiProfile("openxr")]
    TypeEventDataEventsLost = 49,

    [NativeName("XR_TYPE_INTERACTION_PROFILE_SUGGESTED_BINDING")]
    [SupportedApiProfile("openxr")]
    TypeInteractionProfileSuggestedBinding = 51,

    [NativeName("XR_TYPE_EVENT_DATA_INTERACTION_PROFILE_CHANGED")]
    [SupportedApiProfile("openxr")]
    TypeEventDataInteractionProfileChanged = 52,

    [NativeName("XR_TYPE_INTERACTION_PROFILE_STATE")]
    [SupportedApiProfile("openxr")]
    TypeInteractionProfileState = 53,

    [NativeName("XR_TYPE_SWAPCHAIN_IMAGE_ACQUIRE_INFO")]
    [SupportedApiProfile("openxr")]
    TypeSwapchainImageAcquireInfo = 55,

    [NativeName("XR_TYPE_SWAPCHAIN_IMAGE_WAIT_INFO")]
    [SupportedApiProfile("openxr")]
    TypeSwapchainImageWaitInfo = 56,

    [NativeName("XR_TYPE_SWAPCHAIN_IMAGE_RELEASE_INFO")]
    [SupportedApiProfile("openxr")]
    TypeSwapchainImageReleaseInfo = 57,

    [NativeName("XR_TYPE_ACTION_STATE_GET_INFO")]
    [SupportedApiProfile("openxr")]
    TypeActionStateGetInfo = 58,

    [NativeName("XR_TYPE_HAPTIC_ACTION_INFO")]
    [SupportedApiProfile("openxr")]
    TypeHapticActionInfo = 59,

    [NativeName("XR_TYPE_SESSION_ACTION_SETS_ATTACH_INFO")]
    [SupportedApiProfile("openxr")]
    TypeSessionActionSetsAttachInfo = 60,

    [NativeName("XR_TYPE_ACTIONS_SYNC_INFO")]
    [SupportedApiProfile("openxr")]
    TypeActionsSyncInfo = 61,

    [NativeName("XR_TYPE_BOUND_SOURCES_FOR_ACTION_ENUMERATE_INFO")]
    [SupportedApiProfile("openxr")]
    TypeBoundSourcesForActionEnumerateInfo = 62,

    [NativeName("XR_TYPE_INPUT_SOURCE_LOCALIZED_NAME_GET_INFO")]
    [SupportedApiProfile("openxr")]
    TypeInputSourceLocalizedNameGetInfo = 63,

    [NativeName("XR_TYPE_SPACES_LOCATE_INFO")]
    [SupportedApiProfile("openxr", ["XR_VERSION_1_1"], MinVersion = "1.1")]
    TypeSpacesLocateInfo = 1000471000,

    [NativeName("XR_TYPE_SPACE_LOCATIONS")]
    [SupportedApiProfile("openxr", ["XR_VERSION_1_1"], MinVersion = "1.1")]
    TypeSpaceLocations = 1000471001,

    [NativeName("XR_TYPE_SPACE_VELOCITIES")]
    [SupportedApiProfile("openxr", ["XR_VERSION_1_1"], MinVersion = "1.1")]
    TypeSpaceVelocities = 1000471002,

    [NativeName("XR_TYPE_COMPOSITION_LAYER_CUBE_KHR")]
    [SupportedApiProfile("openxr", ["XR_KHR_composition_layer_cube"])]
    TypeCompositionLayerCubeKHR = 1000006000,

    [NativeName("XR_TYPE_INSTANCE_CREATE_INFO_ANDROID_KHR")]
    [SupportedApiProfile("openxr", ["XR_KHR_android_create_instance"])]
    TypeInstanceCreateInfoAndroidKHR = 1000008000,

    [NativeName("XR_TYPE_COMPOSITION_LAYER_DEPTH_INFO_KHR")]
    [SupportedApiProfile("openxr", ["XR_KHR_composition_layer_depth"])]
    TypeCompositionLayerDepthInfoKHR = 1000010000,

    [NativeName("XR_TYPE_VULKAN_SWAPCHAIN_FORMAT_LIST_CREATE_INFO_KHR")]
    [SupportedApiProfile(
        "openxr",
        ["XR_KHR_vulkan_swapchain_format_list"],
        ImpliesSets = ["XR_KHR_vulkan_enable", "XR_KHR_vulkan_enable2", "XR_VERSION_1_0"]
    )]
    TypeVulkanSwapchainFormatListCreateInfoKHR = 1000014000,

    [NativeName("XR_TYPE_EVENT_DATA_PERF_SETTINGS_EXT")]
    [SupportedApiProfile("openxr", ["XR_EXT_performance_settings"])]
    TypeEventDataPerfSettingsEXT = 1000015000,

    [NativeName("XR_TYPE_COMPOSITION_LAYER_CYLINDER_KHR")]
    [SupportedApiProfile("openxr", ["XR_KHR_composition_layer_cylinder"])]
    TypeCompositionLayerCylinderKHR = 1000017000,

    [NativeName("XR_TYPE_COMPOSITION_LAYER_EQUIRECT_KHR")]
    [SupportedApiProfile("openxr", ["XR_KHR_composition_layer_equirect"])]
    TypeCompositionLayerEquirectKHR = 1000018000,

    [NativeName("XR_TYPE_DEBUG_UTILS_OBJECT_NAME_INFO_EXT")]
    [SupportedApiProfile("openxr", ["XR_EXT_debug_utils"])]
    TypeDebugUtilsObjectNameInfoEXT = 1000019000,

    [NativeName("XR_TYPE_DEBUG_UTILS_MESSENGER_CALLBACK_DATA_EXT")]
    [SupportedApiProfile("openxr", ["XR_EXT_debug_utils"])]
    TypeDebugUtilsMessengerCallbackDataEXT = 1000019001,

    [NativeName("XR_TYPE_DEBUG_UTILS_MESSENGER_CREATE_INFO_EXT")]
    [SupportedApiProfile("openxr", ["XR_EXT_debug_utils"])]
    TypeDebugUtilsMessengerCreateInfoEXT = 1000019002,

    [NativeName("XR_TYPE_DEBUG_UTILS_LABEL_EXT")]
    [SupportedApiProfile("openxr", ["XR_EXT_debug_utils"])]
    TypeDebugUtilsLabelEXT = 1000019003,

    [NativeName("XR_TYPE_GRAPHICS_BINDING_OPENGL_WIN32_KHR")]
    [SupportedApiProfile("openxr", ["XR_KHR_opengl_enable"])]
    TypeGraphicsBindingOpenglWin32KHR = 1000023000,

    [NativeName("XR_TYPE_GRAPHICS_BINDING_OPENGL_XLIB_KHR")]
    [SupportedApiProfile("openxr", ["XR_KHR_opengl_enable"])]
    TypeGraphicsBindingOpenglXlibKHR = 1000023001,

    [NativeName("XR_TYPE_GRAPHICS_BINDING_OPENGL_XCB_KHR")]
    [SupportedApiProfile("openxr", ["XR_KHR_opengl_enable"])]
    TypeGraphicsBindingOpenglXcbKHR = 1000023002,

    [NativeName("XR_TYPE_GRAPHICS_BINDING_OPENGL_WAYLAND_KHR")]
    [SupportedApiProfile("openxr", ["XR_KHR_opengl_enable"])]
    TypeGraphicsBindingOpenglWaylandKHR = 1000023003,

    [NativeName("XR_TYPE_SWAPCHAIN_IMAGE_OPENGL_KHR")]
    [SupportedApiProfile("openxr", ["XR_KHR_opengl_enable"])]
    TypeSwapchainImageOpenglKHR = 1000023004,

    [NativeName("XR_TYPE_GRAPHICS_REQUIREMENTS_OPENGL_KHR")]
    [SupportedApiProfile("openxr", ["XR_KHR_opengl_enable"])]
    TypeGraphicsRequirementsOpenglKHR = 1000023005,

    [NativeName("XR_TYPE_GRAPHICS_BINDING_OPENGL_ES_ANDROID_KHR")]
    [SupportedApiProfile("openxr", ["XR_KHR_opengl_es_enable"])]
    TypeGraphicsBindingOpenglEsAndroidKHR = 1000024001,

    [NativeName("XR_TYPE_SWAPCHAIN_IMAGE_OPENGL_ES_KHR")]
    [SupportedApiProfile("openxr", ["XR_KHR_opengl_es_enable"])]
    TypeSwapchainImageOpenglEsKHR = 1000024002,

    [NativeName("XR_TYPE_GRAPHICS_REQUIREMENTS_OPENGL_ES_KHR")]
    [SupportedApiProfile("openxr", ["XR_KHR_opengl_es_enable"])]
    TypeGraphicsRequirementsOpenglEsKHR = 1000024003,

    [NativeName("XR_TYPE_GRAPHICS_BINDING_VULKAN_KHR")]
    [SupportedApiProfile("openxr", ["XR_KHR_vulkan_enable"])]
    TypeGraphicsBindingVulkanKHR = 1000025000,

    [NativeName("XR_TYPE_SWAPCHAIN_IMAGE_VULKAN_KHR")]
    [SupportedApiProfile("openxr", ["XR_KHR_vulkan_enable"])]
    TypeSwapchainImageVulkanKHR = 1000025001,

    [NativeName("XR_TYPE_GRAPHICS_REQUIREMENTS_VULKAN_KHR")]
    [SupportedApiProfile("openxr", ["XR_KHR_vulkan_enable"])]
    TypeGraphicsRequirementsVulkanKHR = 1000025002,

    [NativeName("XR_TYPE_GRAPHICS_BINDING_D3D11_KHR")]
    [SupportedApiProfile("openxr", ["XR_KHR_D3D11_enable"])]
    TypeGraphicsBindingD3D11KHR = 1000027000,

    [NativeName("XR_TYPE_SWAPCHAIN_IMAGE_D3D11_KHR")]
    [SupportedApiProfile("openxr", ["XR_KHR_D3D11_enable"])]
    TypeSwapchainImageD3D11KHR = 1000027001,

    [NativeName("XR_TYPE_GRAPHICS_REQUIREMENTS_D3D11_KHR")]
    [SupportedApiProfile("openxr", ["XR_KHR_D3D11_enable"])]
    TypeGraphicsRequirementsD3D11KHR = 1000027002,

    [NativeName("XR_TYPE_GRAPHICS_BINDING_D3D12_KHR")]
    [SupportedApiProfile("openxr", ["XR_KHR_D3D12_enable"])]
    TypeGraphicsBindingD3D12KHR = 1000028000,

    [NativeName("XR_TYPE_SWAPCHAIN_IMAGE_D3D12_KHR")]
    [SupportedApiProfile("openxr", ["XR_KHR_D3D12_enable"])]
    TypeSwapchainImageD3D12KHR = 1000028001,

    [NativeName("XR_TYPE_GRAPHICS_REQUIREMENTS_D3D12_KHR")]
    [SupportedApiProfile("openxr", ["XR_KHR_D3D12_enable"])]
    TypeGraphicsRequirementsD3D12KHR = 1000028002,

    [NativeName("XR_TYPE_GRAPHICS_BINDING_METAL_KHR")]
    [SupportedApiProfile("openxr", ["XR_KHR_metal_enable"])]
    TypeGraphicsBindingMetalKHR = 1000029000,

    [NativeName("XR_TYPE_SWAPCHAIN_IMAGE_METAL_KHR")]
    [SupportedApiProfile("openxr", ["XR_KHR_metal_enable"])]
    TypeSwapchainImageMetalKHR = 1000029001,

    [NativeName("XR_TYPE_GRAPHICS_REQUIREMENTS_METAL_KHR")]
    [SupportedApiProfile("openxr", ["XR_KHR_metal_enable"])]
    TypeGraphicsRequirementsMetalKHR = 1000029002,

    [NativeName("XR_TYPE_SYSTEM_EYE_GAZE_INTERACTION_PROPERTIES_EXT")]
    [SupportedApiProfile("openxr", ["XR_EXT_eye_gaze_interaction"])]
    TypeSystemEyeGazeInteractionPropertiesEXT = 1000030000,

    [NativeName("XR_TYPE_EYE_GAZE_SAMPLE_TIME_EXT")]
    [SupportedApiProfile("openxr", ["XR_EXT_eye_gaze_interaction"])]
    TypeEyeGazeSampleTimeEXT = 1000030001,

    [NativeName("XR_TYPE_VISIBILITY_MASK_KHR")]
    [SupportedApiProfile("openxr", ["XR_KHR_visibility_mask"])]
    TypeVisibilityMaskKHR = 1000031000,

    [NativeName("XR_TYPE_EVENT_DATA_VISIBILITY_MASK_CHANGED_KHR")]
    [SupportedApiProfile("openxr", ["XR_KHR_visibility_mask"])]
    TypeEventDataVisibilityMaskChangedKHR = 1000031001,

    [NativeName("XR_TYPE_SESSION_CREATE_INFO_OVERLAY_EXTX")]
    [SupportedApiProfile("openxr", ["XR_EXTX_overlay"])]
    TypeSessionCreateInfoOverlayEXTX = 1000033000,

    [NativeName("XR_TYPE_EVENT_DATA_MAIN_SESSION_VISIBILITY_CHANGED_EXTX")]
    [SupportedApiProfile("openxr", ["XR_EXTX_overlay"])]
    TypeEventDataMainSessionVisibilityChangedEXTX = 1000033003,

    [NativeName("XR_TYPE_COMPOSITION_LAYER_COLOR_SCALE_BIAS_KHR")]
    [SupportedApiProfile("openxr", ["XR_KHR_composition_layer_color_scale_bias"])]
    TypeCompositionLayerColorScaleBiasKHR = 1000034000,

    [NativeName("XR_TYPE_SPATIAL_ANCHOR_CREATE_INFO_MSFT")]
    [SupportedApiProfile("openxr", ["XR_MSFT_spatial_anchor"])]
    TypeSpatialAnchorCreateInfoMSFT = 1000039000,

    [NativeName("XR_TYPE_SPATIAL_ANCHOR_SPACE_CREATE_INFO_MSFT")]
    [SupportedApiProfile("openxr", ["XR_MSFT_spatial_anchor"])]
    TypeSpatialAnchorSpaceCreateInfoMSFT = 1000039001,

    [NativeName("XR_TYPE_COMPOSITION_LAYER_IMAGE_LAYOUT_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_composition_layer_image_layout"])]
    TypeCompositionLayerImageLayoutFB = 1000040000,

    [NativeName("XR_TYPE_COMPOSITION_LAYER_ALPHA_BLEND_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_composition_layer_alpha_blend"])]
    TypeCompositionLayerAlphaBlendFB = 1000041001,

    [NativeName("XR_TYPE_VIEW_CONFIGURATION_DEPTH_RANGE_EXT")]
    [SupportedApiProfile("openxr", ["XR_EXT_view_configuration_depth_range"])]
    TypeViewConfigurationDepthRangeEXT = 1000046000,

    [NativeName("XR_TYPE_GRAPHICS_BINDING_EGL_MNDX")]
    [SupportedApiProfile("openxr", ["XR_MNDX_egl_enable"])]
    TypeGraphicsBindingEglMNDX = 1000048004,

    [NativeName("XR_TYPE_SPATIAL_GRAPH_NODE_SPACE_CREATE_INFO_MSFT")]
    [SupportedApiProfile("openxr", ["XR_MSFT_spatial_graph_bridge"])]
    TypeSpatialGraphNodeSpaceCreateInfoMSFT = 1000049000,

    [NativeName("XR_TYPE_SPATIAL_GRAPH_STATIC_NODE_BINDING_CREATE_INFO_MSFT")]
    [SupportedApiProfile("openxr", ["XR_MSFT_spatial_graph_bridge"])]
    TypeSpatialGraphStaticNodeBindingCreateInfoMSFT = 1000049001,

    [NativeName("XR_TYPE_SPATIAL_GRAPH_NODE_BINDING_PROPERTIES_GET_INFO_MSFT")]
    [SupportedApiProfile("openxr", ["XR_MSFT_spatial_graph_bridge"])]
    TypeSpatialGraphNodeBindingPropertiesGetInfoMSFT = 1000049002,

    [NativeName("XR_TYPE_SPATIAL_GRAPH_NODE_BINDING_PROPERTIES_MSFT")]
    [SupportedApiProfile("openxr", ["XR_MSFT_spatial_graph_bridge"])]
    TypeSpatialGraphNodeBindingPropertiesMSFT = 1000049003,

    [NativeName("XR_TYPE_SYSTEM_HAND_TRACKING_PROPERTIES_EXT")]
    [SupportedApiProfile("openxr", ["XR_EXT_hand_tracking"])]
    TypeSystemHandTrackingPropertiesEXT = 1000051000,

    [NativeName("XR_TYPE_HAND_TRACKER_CREATE_INFO_EXT")]
    [SupportedApiProfile("openxr", ["XR_EXT_hand_tracking"])]
    TypeHandTrackerCreateInfoEXT = 1000051001,

    [NativeName("XR_TYPE_HAND_JOINTS_LOCATE_INFO_EXT")]
    [SupportedApiProfile("openxr", ["XR_EXT_hand_tracking"])]
    TypeHandJointsLocateInfoEXT = 1000051002,

    [NativeName("XR_TYPE_HAND_JOINT_LOCATIONS_EXT")]
    [SupportedApiProfile("openxr", ["XR_EXT_hand_tracking"])]
    TypeHandJointLocationsEXT = 1000051003,

    [NativeName("XR_TYPE_HAND_JOINT_VELOCITIES_EXT")]
    [SupportedApiProfile("openxr", ["XR_EXT_hand_tracking"])]
    TypeHandJointVelocitiesEXT = 1000051004,

    [NativeName("XR_TYPE_SYSTEM_HAND_TRACKING_MESH_PROPERTIES_MSFT")]
    [SupportedApiProfile(
        "openxr",
        ["XR_MSFT_hand_tracking_mesh"],
        ImpliesSets = ["XR_EXT_hand_tracking", "XR_VERSION_1_0"]
    )]
    TypeSystemHandTrackingMeshPropertiesMSFT = 1000052000,

    [NativeName("XR_TYPE_HAND_MESH_SPACE_CREATE_INFO_MSFT")]
    [SupportedApiProfile(
        "openxr",
        ["XR_MSFT_hand_tracking_mesh"],
        ImpliesSets = ["XR_EXT_hand_tracking", "XR_VERSION_1_0"]
    )]
    TypeHandMeshSpaceCreateInfoMSFT = 1000052001,

    [NativeName("XR_TYPE_HAND_MESH_UPDATE_INFO_MSFT")]
    [SupportedApiProfile(
        "openxr",
        ["XR_MSFT_hand_tracking_mesh"],
        ImpliesSets = ["XR_EXT_hand_tracking", "XR_VERSION_1_0"]
    )]
    TypeHandMeshUpdateInfoMSFT = 1000052002,

    [NativeName("XR_TYPE_HAND_MESH_MSFT")]
    [SupportedApiProfile(
        "openxr",
        ["XR_MSFT_hand_tracking_mesh"],
        ImpliesSets = ["XR_EXT_hand_tracking", "XR_VERSION_1_0"]
    )]
    TypeHandMeshMSFT = 1000052003,

    [NativeName("XR_TYPE_HAND_POSE_TYPE_INFO_MSFT")]
    [SupportedApiProfile(
        "openxr",
        ["XR_MSFT_hand_tracking_mesh"],
        ImpliesSets = ["XR_EXT_hand_tracking", "XR_VERSION_1_0"]
    )]
    TypeHandPoseTypeInfoMSFT = 1000052004,

    [NativeName("XR_TYPE_SECONDARY_VIEW_CONFIGURATION_SESSION_BEGIN_INFO_MSFT")]
    [SupportedApiProfile("openxr", ["XR_MSFT_secondary_view_configuration"])]
    TypeSecondaryViewConfigurationSessionBeginInfoMSFT = 1000053000,

    [NativeName("XR_TYPE_SECONDARY_VIEW_CONFIGURATION_STATE_MSFT")]
    [SupportedApiProfile("openxr", ["XR_MSFT_secondary_view_configuration"])]
    TypeSecondaryViewConfigurationStateMSFT = 1000053001,

    [NativeName("XR_TYPE_SECONDARY_VIEW_CONFIGURATION_FRAME_STATE_MSFT")]
    [SupportedApiProfile("openxr", ["XR_MSFT_secondary_view_configuration"])]
    TypeSecondaryViewConfigurationFrameStateMSFT = 1000053002,

    [NativeName("XR_TYPE_SECONDARY_VIEW_CONFIGURATION_FRAME_END_INFO_MSFT")]
    [SupportedApiProfile("openxr", ["XR_MSFT_secondary_view_configuration"])]
    TypeSecondaryViewConfigurationFrameEndInfoMSFT = 1000053003,

    [NativeName("XR_TYPE_SECONDARY_VIEW_CONFIGURATION_LAYER_INFO_MSFT")]
    [SupportedApiProfile("openxr", ["XR_MSFT_secondary_view_configuration"])]
    TypeSecondaryViewConfigurationLayerInfoMSFT = 1000053004,

    [NativeName("XR_TYPE_SECONDARY_VIEW_CONFIGURATION_SWAPCHAIN_CREATE_INFO_MSFT")]
    [SupportedApiProfile("openxr", ["XR_MSFT_secondary_view_configuration"])]
    TypeSecondaryViewConfigurationSwapchainCreateInfoMSFT = 1000053005,

    [NativeName("XR_TYPE_CONTROLLER_MODEL_KEY_STATE_MSFT")]
    [SupportedApiProfile("openxr", ["XR_MSFT_controller_model"])]
    TypeControllerModelKeyStateMSFT = 1000055000,

    [NativeName("XR_TYPE_CONTROLLER_MODEL_NODE_PROPERTIES_MSFT")]
    [SupportedApiProfile("openxr", ["XR_MSFT_controller_model"])]
    TypeControllerModelNodePropertiesMSFT = 1000055001,

    [NativeName("XR_TYPE_CONTROLLER_MODEL_PROPERTIES_MSFT")]
    [SupportedApiProfile("openxr", ["XR_MSFT_controller_model"])]
    TypeControllerModelPropertiesMSFT = 1000055002,

    [NativeName("XR_TYPE_CONTROLLER_MODEL_NODE_STATE_MSFT")]
    [SupportedApiProfile("openxr", ["XR_MSFT_controller_model"])]
    TypeControllerModelNodeStateMSFT = 1000055003,

    [NativeName("XR_TYPE_CONTROLLER_MODEL_STATE_MSFT")]
    [SupportedApiProfile("openxr", ["XR_MSFT_controller_model"])]
    TypeControllerModelStateMSFT = 1000055004,

    [NativeName("XR_TYPE_VIEW_CONFIGURATION_VIEW_FOV_EPIC")]
    [SupportedApiProfile("openxr", ["XR_EPIC_view_configuration_fov"])]
    TypeViewConfigurationViewFovEPIC = 1000059000,

    [NativeName("XR_TYPE_HOLOGRAPHIC_WINDOW_ATTACHMENT_MSFT")]
    [SupportedApiProfile("openxr", ["XR_MSFT_holographic_window_attachment"])]
    TypeHolographicWindowAttachmentMSFT = 1000063000,

    [NativeName("XR_TYPE_COMPOSITION_LAYER_REPROJECTION_INFO_MSFT")]
    [SupportedApiProfile("openxr", ["XR_MSFT_composition_layer_reprojection"])]
    TypeCompositionLayerReprojectionInfoMSFT = 1000066000,

    [NativeName("XR_TYPE_COMPOSITION_LAYER_REPROJECTION_PLANE_OVERRIDE_MSFT")]
    [SupportedApiProfile("openxr", ["XR_MSFT_composition_layer_reprojection"])]
    TypeCompositionLayerReprojectionPlaneOverrideMSFT = 1000066001,

    [NativeName("XR_TYPE_ANDROID_SURFACE_SWAPCHAIN_CREATE_INFO_FB")]
    [SupportedApiProfile(
        "openxr",
        ["XR_FB_android_surface_swapchain_create"],
        ImpliesSets = ["XR_KHR_android_surface_swapchain", "XR_VERSION_1_0"]
    )]
    TypeAndroidSurfaceSwapchainCreateInfoFB = 1000070000,

    [NativeName("XR_TYPE_COMPOSITION_LAYER_SECURE_CONTENT_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_composition_layer_secure_content"])]
    TypeCompositionLayerSecureContentFB = 1000072000,

    [NativeName("XR_TYPE_BODY_TRACKER_CREATE_INFO_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_body_tracking"])]
    TypeBodyTrackerCreateInfoFB = 1000076001,

    [NativeName("XR_TYPE_BODY_JOINTS_LOCATE_INFO_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_body_tracking"])]
    TypeBodyJointsLocateInfoFB = 1000076002,

    [NativeName("XR_TYPE_SYSTEM_BODY_TRACKING_PROPERTIES_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_body_tracking"])]
    TypeSystemBodyTrackingPropertiesFB = 1000076004,

    [NativeName("XR_TYPE_BODY_JOINT_LOCATIONS_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_body_tracking"])]
    TypeBodyJointLocationsFB = 1000076005,

    [NativeName("XR_TYPE_BODY_SKELETON_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_body_tracking"])]
    TypeBodySkeletonFB = 1000076006,

    [NativeName("XR_TYPE_INTERACTION_PROFILE_DPAD_BINDING_EXT")]
    [SupportedApiProfile(
        "openxr",
        ["XR_EXT_dpad_binding"],
        ImpliesSets = ["XR_KHR_binding_modification", "XR_VERSION_1_0"]
    )]
    TypeInteractionProfileDpadBindingEXT = 1000078000,

    [NativeName("XR_TYPE_INTERACTION_PROFILE_ANALOG_THRESHOLD_VALVE")]
    [SupportedApiProfile("openxr", ["XR_VALVE_analog_threshold"])]
    TypeInteractionProfileAnalogThresholdVALVE = 1000079000,

    [NativeName("XR_TYPE_HAND_JOINTS_MOTION_RANGE_INFO_EXT")]
    [SupportedApiProfile(
        "openxr",
        ["XR_EXT_hand_joints_motion_range"],
        ImpliesSets = ["XR_EXT_hand_tracking", "XR_VERSION_1_0"]
    )]
    TypeHandJointsMotionRangeInfoEXT = 1000080000,

    [NativeName("XR_TYPE_LOADER_INIT_INFO_ANDROID_KHR")]
    [SupportedApiProfile(
        "openxr",
        ["XR_KHR_loader_init_android"],
        ImpliesSets = ["XR_KHR_loader_init", "XR_VERSION_1_0"]
    )]
    TypeLoaderInitInfoAndroidKHR = 1000089000,

    [NativeName("XR_TYPE_VULKAN_INSTANCE_CREATE_INFO_KHR")]
    [SupportedApiProfile("openxr", ["XR_KHR_vulkan_enable2"])]
    TypeVulkanInstanceCreateInfoKHR = 1000090000,

    [NativeName("XR_TYPE_VULKAN_DEVICE_CREATE_INFO_KHR")]
    [SupportedApiProfile("openxr", ["XR_KHR_vulkan_enable2"])]
    TypeVulkanDeviceCreateInfoKHR = 1000090001,

    [NativeName("XR_TYPE_VULKAN_GRAPHICS_DEVICE_GET_INFO_KHR")]
    [SupportedApiProfile("openxr", ["XR_KHR_vulkan_enable2"])]
    TypeVulkanGraphicsDeviceGetInfoKHR = 1000090003,

    [NativeName("XR_TYPE_COMPOSITION_LAYER_EQUIRECT2_KHR")]
    [SupportedApiProfile("openxr", ["XR_KHR_composition_layer_equirect2"])]
    TypeCompositionLayerEquirect2KHR = 1000091000,

    [NativeName("XR_TYPE_SCENE_OBSERVER_CREATE_INFO_MSFT")]
    [SupportedApiProfile("openxr", ["XR_MSFT_scene_understanding"])]
    TypeSceneObserverCreateInfoMSFT = 1000097000,

    [NativeName("XR_TYPE_SCENE_CREATE_INFO_MSFT")]
    [SupportedApiProfile("openxr", ["XR_MSFT_scene_understanding"])]
    TypeSceneCreateInfoMSFT = 1000097001,

    [NativeName("XR_TYPE_NEW_SCENE_COMPUTE_INFO_MSFT")]
    [SupportedApiProfile("openxr", ["XR_MSFT_scene_understanding"])]
    TypeNewSceneComputeInfoMSFT = 1000097002,

    [NativeName("XR_TYPE_VISUAL_MESH_COMPUTE_LOD_INFO_MSFT")]
    [SupportedApiProfile("openxr", ["XR_MSFT_scene_understanding"])]
    TypeVisualMeshComputeLodInfoMSFT = 1000097003,

    [NativeName("XR_TYPE_SCENE_COMPONENTS_MSFT")]
    [SupportedApiProfile("openxr", ["XR_MSFT_scene_understanding"])]
    TypeSceneComponentsMSFT = 1000097004,

    [NativeName("XR_TYPE_SCENE_COMPONENTS_GET_INFO_MSFT")]
    [SupportedApiProfile("openxr", ["XR_MSFT_scene_understanding"])]
    TypeSceneComponentsGetInfoMSFT = 1000097005,

    [NativeName("XR_TYPE_SCENE_COMPONENT_LOCATIONS_MSFT")]
    [SupportedApiProfile("openxr", ["XR_MSFT_scene_understanding"])]
    TypeSceneComponentLocationsMSFT = 1000097006,

    [NativeName("XR_TYPE_SCENE_COMPONENTS_LOCATE_INFO_MSFT")]
    [SupportedApiProfile("openxr", ["XR_MSFT_scene_understanding"])]
    TypeSceneComponentsLocateInfoMSFT = 1000097007,

    [NativeName("XR_TYPE_SCENE_OBJECTS_MSFT")]
    [SupportedApiProfile("openxr", ["XR_MSFT_scene_understanding"])]
    TypeSceneObjectsMSFT = 1000097008,

    [NativeName("XR_TYPE_SCENE_COMPONENT_PARENT_FILTER_INFO_MSFT")]
    [SupportedApiProfile("openxr", ["XR_MSFT_scene_understanding"])]
    TypeSceneComponentParentFilterInfoMSFT = 1000097009,

    [NativeName("XR_TYPE_SCENE_OBJECT_TYPES_FILTER_INFO_MSFT")]
    [SupportedApiProfile("openxr", ["XR_MSFT_scene_understanding"])]
    TypeSceneObjectTypesFilterInfoMSFT = 1000097010,

    [NativeName("XR_TYPE_SCENE_PLANES_MSFT")]
    [SupportedApiProfile("openxr", ["XR_MSFT_scene_understanding"])]
    TypeScenePlanesMSFT = 1000097011,

    [NativeName("XR_TYPE_SCENE_PLANE_ALIGNMENT_FILTER_INFO_MSFT")]
    [SupportedApiProfile("openxr", ["XR_MSFT_scene_understanding"])]
    TypeScenePlaneAlignmentFilterInfoMSFT = 1000097012,

    [NativeName("XR_TYPE_SCENE_MESHES_MSFT")]
    [SupportedApiProfile("openxr", ["XR_MSFT_scene_understanding"])]
    TypeSceneMeshesMSFT = 1000097013,

    [NativeName("XR_TYPE_SCENE_MESH_BUFFERS_GET_INFO_MSFT")]
    [SupportedApiProfile("openxr", ["XR_MSFT_scene_understanding"])]
    TypeSceneMeshBuffersGetInfoMSFT = 1000097014,

    [NativeName("XR_TYPE_SCENE_MESH_BUFFERS_MSFT")]
    [SupportedApiProfile("openxr", ["XR_MSFT_scene_understanding"])]
    TypeSceneMeshBuffersMSFT = 1000097015,

    [NativeName("XR_TYPE_SCENE_MESH_VERTEX_BUFFER_MSFT")]
    [SupportedApiProfile("openxr", ["XR_MSFT_scene_understanding"])]
    TypeSceneMeshVertexBufferMSFT = 1000097016,

    [NativeName("XR_TYPE_SCENE_MESH_INDICES_UINT32_MSFT")]
    [SupportedApiProfile("openxr", ["XR_MSFT_scene_understanding"])]
    TypeSceneMeshIndicesUint32MSFT = 1000097017,

    [NativeName("XR_TYPE_SCENE_MESH_INDICES_UINT16_MSFT")]
    [SupportedApiProfile("openxr", ["XR_MSFT_scene_understanding"])]
    TypeSceneMeshIndicesUint16MSFT = 1000097018,

    [NativeName("XR_TYPE_SERIALIZED_SCENE_FRAGMENT_DATA_GET_INFO_MSFT")]
    [SupportedApiProfile(
        "openxr",
        ["XR_MSFT_scene_understanding_serialization"],
        ImpliesSets = ["XR_MSFT_scene_understanding", "XR_VERSION_1_0"]
    )]
    TypeSerializedSceneFragmentDataGetInfoMSFT = 1000098000,

    [NativeName("XR_TYPE_SCENE_DESERIALIZE_INFO_MSFT")]
    [SupportedApiProfile(
        "openxr",
        ["XR_MSFT_scene_understanding_serialization"],
        ImpliesSets = ["XR_MSFT_scene_understanding", "XR_VERSION_1_0"]
    )]
    TypeSceneDeserializeInfoMSFT = 1000098001,

    [NativeName("XR_TYPE_EVENT_DATA_DISPLAY_REFRESH_RATE_CHANGED_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_display_refresh_rate"])]
    TypeEventDataDisplayRefreshRateChangedFB = 1000101000,

    [NativeName("XR_TYPE_VIVE_TRACKER_PATHS_HTCX")]
    [SupportedApiProfile("openxr", ["XR_HTCX_vive_tracker_interaction"])]
    TypeViveTrackerPathsHTCX = 1000103000,

    [NativeName("XR_TYPE_EVENT_DATA_VIVE_TRACKER_CONNECTED_HTCX")]
    [SupportedApiProfile("openxr", ["XR_HTCX_vive_tracker_interaction"])]
    TypeEventDataViveTrackerConnectedHTCX = 1000103001,

    [NativeName("XR_TYPE_SYSTEM_FACIAL_TRACKING_PROPERTIES_HTC")]
    [SupportedApiProfile("openxr", ["XR_HTC_facial_tracking"])]
    TypeSystemFacialTrackingPropertiesHTC = 1000104000,

    [NativeName("XR_TYPE_FACIAL_TRACKER_CREATE_INFO_HTC")]
    [SupportedApiProfile("openxr", ["XR_HTC_facial_tracking"])]
    TypeFacialTrackerCreateInfoHTC = 1000104001,

    [NativeName("XR_TYPE_FACIAL_EXPRESSIONS_HTC")]
    [SupportedApiProfile("openxr", ["XR_HTC_facial_tracking"])]
    TypeFacialExpressionsHTC = 1000104002,

    [NativeName("XR_TYPE_SYSTEM_COLOR_SPACE_PROPERTIES_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_color_space"])]
    TypeSystemColorSpacePropertiesFB = 1000108000,

    [NativeName("XR_TYPE_HAND_TRACKING_MESH_FB")]
    [SupportedApiProfile(
        "openxr",
        ["XR_FB_hand_tracking_mesh"],
        ImpliesSets = ["XR_EXT_hand_tracking", "XR_VERSION_1_0"]
    )]
    TypeHandTrackingMeshFB = 1000110001,

    [NativeName("XR_TYPE_HAND_TRACKING_SCALE_FB")]
    [SupportedApiProfile(
        "openxr",
        ["XR_FB_hand_tracking_mesh"],
        ImpliesSets = ["XR_EXT_hand_tracking", "XR_VERSION_1_0"]
    )]
    TypeHandTrackingScaleFB = 1000110003,

    [NativeName("XR_TYPE_HAND_TRACKING_AIM_STATE_FB")]
    [SupportedApiProfile(
        "openxr",
        ["XR_FB_hand_tracking_aim"],
        ImpliesSets = ["XR_EXT_hand_tracking", "XR_VERSION_1_0"]
    )]
    TypeHandTrackingAimStateFB = 1000111001,

    [NativeName("XR_TYPE_HAND_TRACKING_CAPSULES_STATE_FB")]
    [SupportedApiProfile(
        "openxr",
        ["XR_FB_hand_tracking_capsules"],
        ImpliesSets = ["XR_EXT_hand_tracking", "XR_VERSION_1_0"]
    )]
    TypeHandTrackingCapsulesStateFB = 1000112000,

    [NativeName("XR_TYPE_SYSTEM_SPATIAL_ENTITY_PROPERTIES_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_spatial_entity"])]
    TypeSystemSpatialEntityPropertiesFB = 1000113004,

    [NativeName("XR_TYPE_SPATIAL_ANCHOR_CREATE_INFO_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_spatial_entity"])]
    TypeSpatialAnchorCreateInfoFB = 1000113003,

    [NativeName("XR_TYPE_SPACE_COMPONENT_STATUS_SET_INFO_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_spatial_entity"])]
    TypeSpaceComponentStatusSetInfoFB = 1000113007,

    [NativeName("XR_TYPE_SPACE_COMPONENT_STATUS_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_spatial_entity"])]
    TypeSpaceComponentStatusFB = 1000113001,

    [NativeName("XR_TYPE_EVENT_DATA_SPATIAL_ANCHOR_CREATE_COMPLETE_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_spatial_entity"])]
    TypeEventDataSpatialAnchorCreateCompleteFB = 1000113005,

    [NativeName("XR_TYPE_EVENT_DATA_SPACE_SET_STATUS_COMPLETE_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_spatial_entity"])]
    TypeEventDataSpaceSetStatusCompleteFB = 1000113006,

    [NativeName("XR_TYPE_FOVEATION_PROFILE_CREATE_INFO_FB")]
    [SupportedApiProfile(
        "openxr",
        ["XR_FB_foveation"],
        ImpliesSets = ["XR_FB_swapchain_update_state", "XR_VERSION_1_0"]
    )]
    TypeFoveationProfileCreateInfoFB = 1000114000,

    [NativeName("XR_TYPE_SWAPCHAIN_CREATE_INFO_FOVEATION_FB")]
    [SupportedApiProfile(
        "openxr",
        ["XR_FB_foveation"],
        ImpliesSets = ["XR_FB_swapchain_update_state", "XR_VERSION_1_0"]
    )]
    TypeSwapchainCreateInfoFoveationFB = 1000114001,

    [NativeName("XR_TYPE_SWAPCHAIN_STATE_FOVEATION_FB")]
    [SupportedApiProfile(
        "openxr",
        ["XR_FB_foveation"],
        ImpliesSets = ["XR_FB_swapchain_update_state", "XR_VERSION_1_0"]
    )]
    TypeSwapchainStateFoveationFB = 1000114002,

    [NativeName("XR_TYPE_FOVEATION_LEVEL_PROFILE_CREATE_INFO_FB")]
    [SupportedApiProfile(
        "openxr",
        ["XR_FB_foveation_configuration"],
        ImpliesSets = ["XR_FB_foveation", "XR_VERSION_1_0"]
    )]
    TypeFoveationLevelProfileCreateInfoFB = 1000115000,

    [NativeName("XR_TYPE_KEYBOARD_SPACE_CREATE_INFO_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_keyboard_tracking"])]
    TypeKeyboardSpaceCreateInfoFB = 1000116009,

    [NativeName("XR_TYPE_KEYBOARD_TRACKING_QUERY_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_keyboard_tracking"])]
    TypeKeyboardTrackingQueryFB = 1000116004,

    [NativeName("XR_TYPE_SYSTEM_KEYBOARD_TRACKING_PROPERTIES_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_keyboard_tracking"])]
    TypeSystemKeyboardTrackingPropertiesFB = 1000116002,

    [NativeName("XR_TYPE_TRIANGLE_MESH_CREATE_INFO_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_triangle_mesh"])]
    TypeTriangleMeshCreateInfoFB = 1000117001,

    [NativeName("XR_TYPE_SYSTEM_PASSTHROUGH_PROPERTIES_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_passthrough"])]
    TypeSystemPassthroughPropertiesFB = 1000118000,

    [NativeName("XR_TYPE_PASSTHROUGH_CREATE_INFO_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_passthrough"])]
    TypePassthroughCreateInfoFB = 1000118001,

    [NativeName("XR_TYPE_PASSTHROUGH_LAYER_CREATE_INFO_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_passthrough"])]
    TypePassthroughLayerCreateInfoFB = 1000118002,

    [NativeName("XR_TYPE_COMPOSITION_LAYER_PASSTHROUGH_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_passthrough"])]
    TypeCompositionLayerPassthroughFB = 1000118003,

    [NativeName("XR_TYPE_GEOMETRY_INSTANCE_CREATE_INFO_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_passthrough"])]
    TypeGeometryInstanceCreateInfoFB = 1000118004,

    [NativeName("XR_TYPE_GEOMETRY_INSTANCE_TRANSFORM_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_passthrough"])]
    TypeGeometryInstanceTransformFB = 1000118005,

    [NativeName("XR_TYPE_SYSTEM_PASSTHROUGH_PROPERTIES2_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_passthrough"])]
    TypeSystemPassthroughProperties2FB = 1000118006,

    [NativeName("XR_TYPE_PASSTHROUGH_STYLE_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_passthrough"])]
    TypePassthroughStyleFB = 1000118020,

    [NativeName("XR_TYPE_PASSTHROUGH_COLOR_MAP_MONO_TO_RGBA_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_passthrough"])]
    TypePassthroughColorMapMonoToRgbaFB = 1000118021,

    [NativeName("XR_TYPE_PASSTHROUGH_COLOR_MAP_MONO_TO_MONO_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_passthrough"])]
    TypePassthroughColorMapMonoToMonoFB = 1000118022,

    [NativeName("XR_TYPE_PASSTHROUGH_BRIGHTNESS_CONTRAST_SATURATION_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_passthrough"])]
    TypePassthroughBrightnessContrastSaturationFB = 1000118023,

    [NativeName("XR_TYPE_EVENT_DATA_PASSTHROUGH_STATE_CHANGED_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_passthrough"])]
    TypeEventDataPassthroughStateChangedFB = 1000118030,

    [NativeName("XR_TYPE_RENDER_MODEL_PATH_INFO_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_render_model"])]
    TypeRenderModelPathInfoFB = 1000119000,

    [NativeName("XR_TYPE_RENDER_MODEL_PROPERTIES_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_render_model"])]
    TypeRenderModelPropertiesFB = 1000119001,

    [NativeName("XR_TYPE_RENDER_MODEL_BUFFER_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_render_model"])]
    TypeRenderModelBufferFB = 1000119002,

    [NativeName("XR_TYPE_RENDER_MODEL_LOAD_INFO_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_render_model"])]
    TypeRenderModelLoadInfoFB = 1000119003,

    [NativeName("XR_TYPE_SYSTEM_RENDER_MODEL_PROPERTIES_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_render_model"])]
    TypeSystemRenderModelPropertiesFB = 1000119004,

    [NativeName("XR_TYPE_RENDER_MODEL_CAPABILITIES_REQUEST_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_render_model"])]
    TypeRenderModelCapabilitiesRequestFB = 1000119005,

    [NativeName("XR_TYPE_BINDING_MODIFICATIONS_KHR")]
    [SupportedApiProfile("openxr", ["XR_KHR_binding_modification"])]
    TypeBindingModificationsKHR = 1000120000,

    [NativeName("XR_TYPE_VIEW_LOCATE_FOVEATED_RENDERING_VARJO")]
    [SupportedApiProfile(
        "openxr",
        ["XR_VARJO_foveated_rendering"],
        ImpliesSets = ["XR_VARJO_quad_views", "XR_VERSION_1_0"]
    )]
    TypeViewLocateFoveatedRenderingVARJO = 1000121000,

    [NativeName("XR_TYPE_FOVEATED_VIEW_CONFIGURATION_VIEW_VARJO")]
    [SupportedApiProfile(
        "openxr",
        ["XR_VARJO_foveated_rendering"],
        ImpliesSets = ["XR_VARJO_quad_views", "XR_VERSION_1_0"]
    )]
    TypeFoveatedViewConfigurationViewVARJO = 1000121001,

    [NativeName("XR_TYPE_SYSTEM_FOVEATED_RENDERING_PROPERTIES_VARJO")]
    [SupportedApiProfile(
        "openxr",
        ["XR_VARJO_foveated_rendering"],
        ImpliesSets = ["XR_VARJO_quad_views", "XR_VERSION_1_0"]
    )]
    TypeSystemFoveatedRenderingPropertiesVARJO = 1000121002,

    [NativeName("XR_TYPE_COMPOSITION_LAYER_DEPTH_TEST_VARJO")]
    [SupportedApiProfile(
        "openxr",
        ["XR_VARJO_composition_layer_depth_test"],
        ImpliesSets = ["XR_KHR_composition_layer_depth", "XR_VERSION_1_0"]
    )]
    TypeCompositionLayerDepthTestVARJO = 1000122000,

    [NativeName("XR_TYPE_SYSTEM_MARKER_TRACKING_PROPERTIES_VARJO")]
    [SupportedApiProfile("openxr", ["XR_VARJO_marker_tracking"])]
    TypeSystemMarkerTrackingPropertiesVARJO = 1000124000,

    [NativeName("XR_TYPE_EVENT_DATA_MARKER_TRACKING_UPDATE_VARJO")]
    [SupportedApiProfile("openxr", ["XR_VARJO_marker_tracking"])]
    TypeEventDataMarkerTrackingUpdateVARJO = 1000124001,

    [NativeName("XR_TYPE_MARKER_SPACE_CREATE_INFO_VARJO")]
    [SupportedApiProfile("openxr", ["XR_VARJO_marker_tracking"])]
    TypeMarkerSpaceCreateInfoVARJO = 1000124002,

    [NativeName("XR_TYPE_FRAME_END_INFO_ML")]
    [SupportedApiProfile("openxr", ["XR_ML_frame_end_info"])]
    TypeFrameEndInfoML = 1000135000,

    [NativeName("XR_TYPE_GLOBAL_DIMMER_FRAME_END_INFO_ML")]
    [SupportedApiProfile("openxr", ["XR_ML_global_dimmer"])]
    TypeGlobalDimmerFrameEndInfoML = 1000136000,

    [NativeName("XR_TYPE_COORDINATE_SPACE_CREATE_INFO_ML")]
    [SupportedApiProfile("openxr", ["XR_ML_compat"])]
    TypeCoordinateSpaceCreateInfoML = 1000137000,

    [NativeName("XR_TYPE_SYSTEM_MARKER_UNDERSTANDING_PROPERTIES_ML")]
    [SupportedApiProfile("openxr", ["XR_ML_marker_understanding"])]
    TypeSystemMarkerUnderstandingPropertiesML = 1000138000,

    [NativeName("XR_TYPE_MARKER_DETECTOR_CREATE_INFO_ML")]
    [SupportedApiProfile("openxr", ["XR_ML_marker_understanding"])]
    TypeMarkerDetectorCreateInfoML = 1000138001,

    [NativeName("XR_TYPE_MARKER_DETECTOR_ARUCO_INFO_ML")]
    [SupportedApiProfile("openxr", ["XR_ML_marker_understanding"])]
    TypeMarkerDetectorArucoInfoML = 1000138002,

    [NativeName("XR_TYPE_MARKER_DETECTOR_SIZE_INFO_ML")]
    [SupportedApiProfile("openxr", ["XR_ML_marker_understanding"])]
    TypeMarkerDetectorSizeInfoML = 1000138003,

    [NativeName("XR_TYPE_MARKER_DETECTOR_APRIL_TAG_INFO_ML")]
    [SupportedApiProfile("openxr", ["XR_ML_marker_understanding"])]
    TypeMarkerDetectorAprilTagInfoML = 1000138004,

    [NativeName("XR_TYPE_MARKER_DETECTOR_CUSTOM_PROFILE_INFO_ML")]
    [SupportedApiProfile("openxr", ["XR_ML_marker_understanding"])]
    TypeMarkerDetectorCustomProfileInfoML = 1000138005,

    [NativeName("XR_TYPE_MARKER_DETECTOR_SNAPSHOT_INFO_ML")]
    [SupportedApiProfile("openxr", ["XR_ML_marker_understanding"])]
    TypeMarkerDetectorSnapshotInfoML = 1000138006,

    [NativeName("XR_TYPE_MARKER_DETECTOR_STATE_ML")]
    [SupportedApiProfile("openxr", ["XR_ML_marker_understanding"])]
    TypeMarkerDetectorStateML = 1000138007,

    [NativeName("XR_TYPE_MARKER_SPACE_CREATE_INFO_ML")]
    [SupportedApiProfile("openxr", ["XR_ML_marker_understanding"])]
    TypeMarkerSpaceCreateInfoML = 1000138008,

    [NativeName("XR_TYPE_LOCALIZATION_MAP_ML")]
    [SupportedApiProfile(
        "openxr",
        ["XR_ML_localization_map"],
        ImpliesSets = ["XR_EXT_uuid", "XR_VERSION_1_0"]
    )]
    TypeLocalizationMapML = 1000139000,

    [NativeName("XR_TYPE_EVENT_DATA_LOCALIZATION_CHANGED_ML")]
    [SupportedApiProfile(
        "openxr",
        ["XR_ML_localization_map"],
        ImpliesSets = ["XR_EXT_uuid", "XR_VERSION_1_0"]
    )]
    TypeEventDataLocalizationChangedML = 1000139001,

    [NativeName("XR_TYPE_MAP_LOCALIZATION_REQUEST_INFO_ML")]
    [SupportedApiProfile(
        "openxr",
        ["XR_ML_localization_map"],
        ImpliesSets = ["XR_EXT_uuid", "XR_VERSION_1_0"]
    )]
    TypeMapLocalizationRequestInfoML = 1000139002,

    [NativeName("XR_TYPE_LOCALIZATION_MAP_IMPORT_INFO_ML")]
    [SupportedApiProfile(
        "openxr",
        ["XR_ML_localization_map"],
        ImpliesSets = ["XR_EXT_uuid", "XR_VERSION_1_0"]
    )]
    TypeLocalizationMapImportInfoML = 1000139003,

    [NativeName("XR_TYPE_LOCALIZATION_ENABLE_EVENTS_INFO_ML")]
    [SupportedApiProfile(
        "openxr",
        ["XR_ML_localization_map"],
        ImpliesSets = ["XR_EXT_uuid", "XR_VERSION_1_0"]
    )]
    TypeLocalizationEnableEventsInfoML = 1000139004,

    [NativeName("XR_TYPE_SPATIAL_ANCHORS_CREATE_INFO_FROM_POSE_ML")]
    [SupportedApiProfile("openxr", ["XR_ML_spatial_anchors"], ImpliesSets = ["XR_EXT_future"])]
    TypeSpatialAnchorsCreateInfoFromPoseML = 1000140000,

    [NativeName("XR_TYPE_CREATE_SPATIAL_ANCHORS_COMPLETION_ML")]
    [SupportedApiProfile("openxr", ["XR_ML_spatial_anchors"], ImpliesSets = ["XR_EXT_future"])]
    TypeCreateSpatialAnchorsCompletionML = 1000140001,

    [NativeName("XR_TYPE_SPATIAL_ANCHOR_STATE_ML")]
    [SupportedApiProfile("openxr", ["XR_ML_spatial_anchors"], ImpliesSets = ["XR_EXT_future"])]
    TypeSpatialAnchorStateML = 1000140002,

    [NativeName("XR_TYPE_SPATIAL_ANCHORS_CREATE_STORAGE_INFO_ML")]
    [SupportedApiProfile(
        "openxr",
        ["XR_ML_spatial_anchors_storage"],
        ImpliesSets = ["XR_EXT_future", "XR_ML_spatial_anchors"]
    )]
    TypeSpatialAnchorsCreateStorageInfoML = 1000141000,

    [NativeName("XR_TYPE_SPATIAL_ANCHORS_QUERY_INFO_RADIUS_ML")]
    [SupportedApiProfile(
        "openxr",
        ["XR_ML_spatial_anchors_storage"],
        ImpliesSets = ["XR_EXT_future", "XR_ML_spatial_anchors"]
    )]
    TypeSpatialAnchorsQueryInfoRadiusML = 1000141001,

    [NativeName("XR_TYPE_SPATIAL_ANCHORS_QUERY_COMPLETION_ML")]
    [SupportedApiProfile(
        "openxr",
        ["XR_ML_spatial_anchors_storage"],
        ImpliesSets = ["XR_EXT_future", "XR_ML_spatial_anchors"]
    )]
    TypeSpatialAnchorsQueryCompletionML = 1000141002,

    [NativeName("XR_TYPE_SPATIAL_ANCHORS_CREATE_INFO_FROM_UUIDS_ML")]
    [SupportedApiProfile(
        "openxr",
        ["XR_ML_spatial_anchors_storage"],
        ImpliesSets = ["XR_EXT_future", "XR_ML_spatial_anchors"]
    )]
    TypeSpatialAnchorsCreateInfoFromUuidsML = 1000141003,

    [NativeName("XR_TYPE_SPATIAL_ANCHORS_PUBLISH_INFO_ML")]
    [SupportedApiProfile(
        "openxr",
        ["XR_ML_spatial_anchors_storage"],
        ImpliesSets = ["XR_EXT_future", "XR_ML_spatial_anchors"]
    )]
    TypeSpatialAnchorsPublishInfoML = 1000141004,

    [NativeName("XR_TYPE_SPATIAL_ANCHORS_PUBLISH_COMPLETION_ML")]
    [SupportedApiProfile(
        "openxr",
        ["XR_ML_spatial_anchors_storage"],
        ImpliesSets = ["XR_EXT_future", "XR_ML_spatial_anchors"]
    )]
    TypeSpatialAnchorsPublishCompletionML = 1000141005,

    [NativeName("XR_TYPE_SPATIAL_ANCHORS_DELETE_INFO_ML")]
    [SupportedApiProfile(
        "openxr",
        ["XR_ML_spatial_anchors_storage"],
        ImpliesSets = ["XR_EXT_future", "XR_ML_spatial_anchors"]
    )]
    TypeSpatialAnchorsDeleteInfoML = 1000141006,

    [NativeName("XR_TYPE_SPATIAL_ANCHORS_DELETE_COMPLETION_ML")]
    [SupportedApiProfile(
        "openxr",
        ["XR_ML_spatial_anchors_storage"],
        ImpliesSets = ["XR_EXT_future", "XR_ML_spatial_anchors"]
    )]
    TypeSpatialAnchorsDeleteCompletionML = 1000141007,

    [NativeName("XR_TYPE_SPATIAL_ANCHORS_UPDATE_EXPIRATION_INFO_ML")]
    [SupportedApiProfile(
        "openxr",
        ["XR_ML_spatial_anchors_storage"],
        ImpliesSets = ["XR_EXT_future", "XR_ML_spatial_anchors"]
    )]
    TypeSpatialAnchorsUpdateExpirationInfoML = 1000141008,

    [NativeName("XR_TYPE_SPATIAL_ANCHORS_UPDATE_EXPIRATION_COMPLETION_ML")]
    [SupportedApiProfile(
        "openxr",
        ["XR_ML_spatial_anchors_storage"],
        ImpliesSets = ["XR_EXT_future", "XR_ML_spatial_anchors"]
    )]
    TypeSpatialAnchorsUpdateExpirationCompletionML = 1000141009,

    [NativeName("XR_TYPE_SPATIAL_ANCHORS_PUBLISH_COMPLETION_DETAILS_ML")]
    [SupportedApiProfile(
        "openxr",
        ["XR_ML_spatial_anchors_storage"],
        ImpliesSets = ["XR_EXT_future", "XR_ML_spatial_anchors"]
    )]
    TypeSpatialAnchorsPublishCompletionDetailsML = 1000141010,

    [NativeName("XR_TYPE_SPATIAL_ANCHORS_DELETE_COMPLETION_DETAILS_ML")]
    [SupportedApiProfile(
        "openxr",
        ["XR_ML_spatial_anchors_storage"],
        ImpliesSets = ["XR_EXT_future", "XR_ML_spatial_anchors"]
    )]
    TypeSpatialAnchorsDeleteCompletionDetailsML = 1000141011,

    [NativeName("XR_TYPE_SPATIAL_ANCHORS_UPDATE_EXPIRATION_COMPLETION_DETAILS_ML")]
    [SupportedApiProfile(
        "openxr",
        ["XR_ML_spatial_anchors_storage"],
        ImpliesSets = ["XR_EXT_future", "XR_ML_spatial_anchors"]
    )]
    TypeSpatialAnchorsUpdateExpirationCompletionDetailsML = 1000141012,

    [NativeName("XR_TYPE_EVENT_DATA_HEADSET_FIT_CHANGED_ML")]
    [SupportedApiProfile("openxr", ["XR_ML_user_calibration"])]
    TypeEventDataHeadsetFitChangedML = 1000472000,

    [NativeName("XR_TYPE_EVENT_DATA_EYE_CALIBRATION_CHANGED_ML")]
    [SupportedApiProfile("openxr", ["XR_ML_user_calibration"])]
    TypeEventDataEyeCalibrationChangedML = 1000472001,

    [NativeName("XR_TYPE_USER_CALIBRATION_ENABLE_EVENTS_INFO_ML")]
    [SupportedApiProfile("openxr", ["XR_ML_user_calibration"])]
    TypeUserCalibrationEnableEventsInfoML = 1000472002,

    [NativeName("XR_TYPE_SPATIAL_ANCHOR_PERSISTENCE_INFO_MSFT")]
    [SupportedApiProfile(
        "openxr",
        ["XR_MSFT_spatial_anchor_persistence"],
        ImpliesSets = ["XR_MSFT_spatial_anchor", "XR_VERSION_1_0"]
    )]
    TypeSpatialAnchorPersistenceInfoMSFT = 1000142000,

    [NativeName("XR_TYPE_SPATIAL_ANCHOR_FROM_PERSISTED_ANCHOR_CREATE_INFO_MSFT")]
    [SupportedApiProfile(
        "openxr",
        ["XR_MSFT_spatial_anchor_persistence"],
        ImpliesSets = ["XR_MSFT_spatial_anchor", "XR_VERSION_1_0"]
    )]
    TypeSpatialAnchorFromPersistedAnchorCreateInfoMSFT = 1000142001,

    [NativeName("XR_TYPE_SCENE_MARKERS_MSFT")]
    [SupportedApiProfile(
        "openxr",
        ["XR_MSFT_scene_marker"],
        ImpliesSets = ["XR_MSFT_scene_understanding", "XR_VERSION_1_0"]
    )]
    TypeSceneMarkersMSFT = 1000147000,

    [NativeName("XR_TYPE_SCENE_MARKER_TYPE_FILTER_MSFT")]
    [SupportedApiProfile(
        "openxr",
        ["XR_MSFT_scene_marker"],
        ImpliesSets = ["XR_MSFT_scene_understanding", "XR_VERSION_1_0"]
    )]
    TypeSceneMarkerTypeFilterMSFT = 1000147001,

    [NativeName("XR_TYPE_SCENE_MARKER_QR_CODES_MSFT")]
    [SupportedApiProfile(
        "openxr",
        ["XR_MSFT_scene_marker"],
        ImpliesSets = ["XR_MSFT_scene_understanding", "XR_VERSION_1_0"]
    )]
    TypeSceneMarkerQrCodesMSFT = 1000147002,

    [NativeName("XR_TYPE_SPACE_QUERY_INFO_FB")]
    [SupportedApiProfile(
        "openxr",
        ["XR_FB_spatial_entity_query"],
        ImpliesSets = ["XR_FB_spatial_entity_storage", "XR_VERSION_1_0"]
    )]
    TypeSpaceQueryInfoFB = 1000156001,

    [NativeName("XR_TYPE_SPACE_QUERY_RESULTS_FB")]
    [SupportedApiProfile(
        "openxr",
        ["XR_FB_spatial_entity_query"],
        ImpliesSets = ["XR_FB_spatial_entity_storage", "XR_VERSION_1_0"]
    )]
    TypeSpaceQueryResultsFB = 1000156002,

    [NativeName("XR_TYPE_SPACE_STORAGE_LOCATION_FILTER_INFO_FB")]
    [SupportedApiProfile(
        "openxr",
        ["XR_FB_spatial_entity_query"],
        ImpliesSets = ["XR_FB_spatial_entity_storage", "XR_VERSION_1_0"]
    )]
    TypeSpaceStorageLocationFilterInfoFB = 1000156003,

    [NativeName("XR_TYPE_SPACE_UUID_FILTER_INFO_FB")]
    [SupportedApiProfile(
        "openxr",
        ["XR_FB_spatial_entity_query"],
        ImpliesSets = ["XR_FB_spatial_entity_storage", "XR_VERSION_1_0"]
    )]
    TypeSpaceUuidFilterInfoFB = 1000156054,

    [NativeName("XR_TYPE_SPACE_COMPONENT_FILTER_INFO_FB")]
    [SupportedApiProfile(
        "openxr",
        ["XR_FB_spatial_entity_query"],
        ImpliesSets = ["XR_FB_spatial_entity_storage", "XR_VERSION_1_0"]
    )]
    TypeSpaceComponentFilterInfoFB = 1000156052,

    [NativeName("XR_TYPE_EVENT_DATA_SPACE_QUERY_RESULTS_AVAILABLE_FB")]
    [SupportedApiProfile(
        "openxr",
        ["XR_FB_spatial_entity_query"],
        ImpliesSets = ["XR_FB_spatial_entity_storage", "XR_VERSION_1_0"]
    )]
    TypeEventDataSpaceQueryResultsAvailableFB = 1000156103,

    [NativeName("XR_TYPE_EVENT_DATA_SPACE_QUERY_COMPLETE_FB")]
    [SupportedApiProfile(
        "openxr",
        ["XR_FB_spatial_entity_query"],
        ImpliesSets = ["XR_FB_spatial_entity_storage", "XR_VERSION_1_0"]
    )]
    TypeEventDataSpaceQueryCompleteFB = 1000156104,

    [NativeName("XR_TYPE_SPACE_SAVE_INFO_FB")]
    [SupportedApiProfile(
        "openxr",
        ["XR_FB_spatial_entity_storage"],
        ImpliesSets = ["XR_FB_spatial_entity", "XR_VERSION_1_0"]
    )]
    TypeSpaceSaveInfoFB = 1000158000,

    [NativeName("XR_TYPE_SPACE_ERASE_INFO_FB")]
    [SupportedApiProfile(
        "openxr",
        ["XR_FB_spatial_entity_storage"],
        ImpliesSets = ["XR_FB_spatial_entity", "XR_VERSION_1_0"]
    )]
    TypeSpaceEraseInfoFB = 1000158001,

    [NativeName("XR_TYPE_EVENT_DATA_SPACE_SAVE_COMPLETE_FB")]
    [SupportedApiProfile(
        "openxr",
        ["XR_FB_spatial_entity_storage"],
        ImpliesSets = ["XR_FB_spatial_entity", "XR_VERSION_1_0"]
    )]
    TypeEventDataSpaceSaveCompleteFB = 1000158106,

    [NativeName("XR_TYPE_EVENT_DATA_SPACE_ERASE_COMPLETE_FB")]
    [SupportedApiProfile(
        "openxr",
        ["XR_FB_spatial_entity_storage"],
        ImpliesSets = ["XR_FB_spatial_entity", "XR_VERSION_1_0"]
    )]
    TypeEventDataSpaceEraseCompleteFB = 1000158107,

    [NativeName("XR_TYPE_SWAPCHAIN_IMAGE_FOVEATION_VULKAN_FB")]
    [SupportedApiProfile(
        "openxr",
        ["XR_FB_foveation_vulkan"],
        ImpliesSets = ["XR_FB_foveation", "XR_VERSION_1_0"]
    )]
    TypeSwapchainImageFoveationVulkanFB = 1000160000,

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
    TypeSwapchainStateAndroidSurfaceDimensionsFB = 1000161000,

    [NativeName("XR_TYPE_SWAPCHAIN_STATE_SAMPLER_OPENGL_ES_FB")]
    [SupportedApiProfile(
        "openxr",
        ["XR_FB_swapchain_update_state_opengl_es"],
        ImpliesSets = ["XR_FB_swapchain_update_state", "XR_KHR_opengl_es_enable"]
    )]
    TypeSwapchainStateSamplerOpenglEsFB = 1000162000,

    [NativeName("XR_TYPE_SWAPCHAIN_STATE_SAMPLER_VULKAN_FB")]
    [SupportedApiProfile(
        "openxr",
        ["XR_FB_swapchain_update_state_vulkan"],
        ImpliesSets = ["XR_FB_swapchain_update_state", "XR_KHR_vulkan_enable", "XR_VERSION_1_0"]
    )]
    TypeSwapchainStateSamplerVulkanFB = 1000163000,

    [NativeName("XR_TYPE_SPACE_SHARE_INFO_FB")]
    [SupportedApiProfile(
        "openxr",
        ["XR_FB_spatial_entity_sharing"],
        ImpliesSets = ["XR_FB_spatial_entity", "XR_VERSION_1_0"]
    )]
    TypeSpaceShareInfoFB = 1000169001,

    [NativeName("XR_TYPE_EVENT_DATA_SPACE_SHARE_COMPLETE_FB")]
    [SupportedApiProfile(
        "openxr",
        ["XR_FB_spatial_entity_sharing"],
        ImpliesSets = ["XR_FB_spatial_entity", "XR_VERSION_1_0"]
    )]
    TypeEventDataSpaceShareCompleteFB = 1000169002,

    [NativeName("XR_TYPE_COMPOSITION_LAYER_SPACE_WARP_INFO_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_space_warp"])]
    TypeCompositionLayerSpaceWarpInfoFB = 1000171000,

    [NativeName("XR_TYPE_SYSTEM_SPACE_WARP_PROPERTIES_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_space_warp"])]
    TypeSystemSpaceWarpPropertiesFB = 1000171001,

    [NativeName("XR_TYPE_HAPTIC_AMPLITUDE_ENVELOPE_VIBRATION_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_haptic_amplitude_envelope"])]
    TypeHapticAmplitudeEnvelopeVibrationFB = 1000173001,

    [NativeName("XR_TYPE_SEMANTIC_LABELS_FB")]
    [SupportedApiProfile(
        "openxr",
        ["XR_FB_scene"],
        ImpliesSets = ["XR_FB_spatial_entity", "XR_VERSION_1_0"]
    )]
    TypeSemanticLabelsFB = 1000175000,

    [NativeName("XR_TYPE_ROOM_LAYOUT_FB")]
    [SupportedApiProfile(
        "openxr",
        ["XR_FB_scene"],
        ImpliesSets = ["XR_FB_spatial_entity", "XR_VERSION_1_0"]
    )]
    TypeRoomLayoutFB = 1000175001,

    [NativeName("XR_TYPE_BOUNDARY_2D_FB")]
    [SupportedApiProfile(
        "openxr",
        ["XR_FB_scene"],
        ImpliesSets = ["XR_FB_spatial_entity", "XR_VERSION_1_0"]
    )]
    TypeBoundary2DFB = 1000175002,

    [NativeName("XR_TYPE_SEMANTIC_LABELS_SUPPORT_INFO_FB")]
    [SupportedApiProfile(
        "openxr",
        ["XR_FB_scene"],
        ImpliesSets = ["XR_FB_spatial_entity", "XR_VERSION_1_0"]
    )]
    TypeSemanticLabelsSupportInfoFB = 1000175010,

    [NativeName("XR_TYPE_DIGITAL_LENS_CONTROL_ALMALENCE")]
    [SupportedApiProfile("openxr", ["XR_ALMALENCE_digital_lens_control"])]
    TypeDigitalLensControlALMALENCE = 1000196000,

    [NativeName("XR_TYPE_EVENT_DATA_SCENE_CAPTURE_COMPLETE_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_scene_capture"])]
    TypeEventDataSceneCaptureCompleteFB = 1000198001,

    [NativeName("XR_TYPE_SCENE_CAPTURE_REQUEST_INFO_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_scene_capture"])]
    TypeSceneCaptureRequestInfoFB = 1000198050,

    [NativeName("XR_TYPE_SPACE_CONTAINER_FB")]
    [SupportedApiProfile(
        "openxr",
        ["XR_FB_spatial_entity_container"],
        ImpliesSets = ["XR_FB_spatial_entity", "XR_VERSION_1_0"]
    )]
    TypeSpaceContainerFB = 1000199000,

    [NativeName("XR_TYPE_FOVEATION_EYE_TRACKED_PROFILE_CREATE_INFO_META")]
    [SupportedApiProfile(
        "openxr",
        ["XR_META_foveation_eye_tracked"],
        ImpliesSets = ["XR_FB_foveation", "XR_FB_foveation_configuration", "XR_VERSION_1_0"]
    )]
    TypeFoveationEyeTrackedProfileCreateInfoMETA = 1000200000,

    [NativeName("XR_TYPE_FOVEATION_EYE_TRACKED_STATE_META")]
    [SupportedApiProfile(
        "openxr",
        ["XR_META_foveation_eye_tracked"],
        ImpliesSets = ["XR_FB_foveation", "XR_FB_foveation_configuration", "XR_VERSION_1_0"]
    )]
    TypeFoveationEyeTrackedStateMETA = 1000200001,

    [NativeName("XR_TYPE_SYSTEM_FOVEATION_EYE_TRACKED_PROPERTIES_META")]
    [SupportedApiProfile(
        "openxr",
        ["XR_META_foveation_eye_tracked"],
        ImpliesSets = ["XR_FB_foveation", "XR_FB_foveation_configuration", "XR_VERSION_1_0"]
    )]
    TypeSystemFoveationEyeTrackedPropertiesMETA = 1000200002,

    [NativeName("XR_TYPE_SYSTEM_FACE_TRACKING_PROPERTIES_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_face_tracking"])]
    TypeSystemFaceTrackingPropertiesFB = 1000201004,

    [NativeName("XR_TYPE_FACE_TRACKER_CREATE_INFO_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_face_tracking"])]
    TypeFaceTrackerCreateInfoFB = 1000201005,

    [NativeName("XR_TYPE_FACE_EXPRESSION_INFO_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_face_tracking"])]
    TypeFaceExpressionInfoFB = 1000201002,

    [NativeName("XR_TYPE_FACE_EXPRESSION_WEIGHTS_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_face_tracking"])]
    TypeFaceExpressionWeightsFB = 1000201006,

    [NativeName("XR_TYPE_EYE_TRACKER_CREATE_INFO_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_eye_tracking_social"])]
    TypeEyeTrackerCreateInfoFB = 1000202001,

    [NativeName("XR_TYPE_EYE_GAZES_INFO_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_eye_tracking_social"])]
    TypeEyeGazesInfoFB = 1000202002,

    [NativeName("XR_TYPE_EYE_GAZES_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_eye_tracking_social"])]
    TypeEyeGazesFB = 1000202003,

    [NativeName("XR_TYPE_SYSTEM_EYE_TRACKING_PROPERTIES_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_eye_tracking_social"])]
    TypeSystemEyeTrackingPropertiesFB = 1000202004,

    [NativeName("XR_TYPE_PASSTHROUGH_KEYBOARD_HANDS_INTENSITY_FB")]
    [SupportedApiProfile(
        "openxr",
        ["XR_FB_passthrough_keyboard_hands"],
        ImpliesSets = ["XR_FB_passthrough", "XR_VERSION_1_0"]
    )]
    TypePassthroughKeyboardHandsIntensityFB = 1000203002,

    [NativeName("XR_TYPE_COMPOSITION_LAYER_SETTINGS_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_composition_layer_settings"])]
    TypeCompositionLayerSettingsFB = 1000204000,

    [NativeName("XR_TYPE_HAPTIC_PCM_VIBRATION_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_haptic_pcm"])]
    TypeHapticPcmVibrationFB = 1000209001,

    [NativeName("XR_TYPE_DEVICE_PCM_SAMPLE_RATE_STATE_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_haptic_pcm"])]
    TypeDevicePcmSampleRateStateFB = 1000209002,

    [NativeName("XR_TYPE_FRAME_SYNTHESIS_INFO_EXT")]
    [SupportedApiProfile("openxr", ["XR_EXT_frame_synthesis"])]
    TypeFrameSynthesisInfoEXT = 1000211000,

    [NativeName("XR_TYPE_FRAME_SYNTHESIS_CONFIG_VIEW_EXT")]
    [SupportedApiProfile("openxr", ["XR_EXT_frame_synthesis"])]
    TypeFrameSynthesisConfigViewEXT = 1000211001,

    [NativeName("XR_TYPE_COMPOSITION_LAYER_DEPTH_TEST_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_composition_layer_depth_test"])]
    TypeCompositionLayerDepthTestFB = 1000212000,

    [NativeName("XR_TYPE_LOCAL_DIMMING_FRAME_END_INFO_META")]
    [SupportedApiProfile("openxr", ["XR_META_local_dimming"])]
    TypeLocalDimmingFrameEndInfoMETA = 1000216000,

    [NativeName("XR_TYPE_PASSTHROUGH_PREFERENCES_META")]
    [SupportedApiProfile("openxr", ["XR_META_passthrough_preferences"])]
    TypePassthroughPreferencesMETA = 1000217000,

    [NativeName("XR_TYPE_SYSTEM_VIRTUAL_KEYBOARD_PROPERTIES_META")]
    [SupportedApiProfile("openxr", ["XR_META_virtual_keyboard"])]
    TypeSystemVirtualKeyboardPropertiesMETA = 1000219001,

    [NativeName("XR_TYPE_VIRTUAL_KEYBOARD_CREATE_INFO_META")]
    [SupportedApiProfile("openxr", ["XR_META_virtual_keyboard"])]
    TypeVirtualKeyboardCreateInfoMETA = 1000219002,

    [NativeName("XR_TYPE_VIRTUAL_KEYBOARD_SPACE_CREATE_INFO_META")]
    [SupportedApiProfile("openxr", ["XR_META_virtual_keyboard"])]
    TypeVirtualKeyboardSpaceCreateInfoMETA = 1000219003,

    [NativeName("XR_TYPE_VIRTUAL_KEYBOARD_LOCATION_INFO_META")]
    [SupportedApiProfile("openxr", ["XR_META_virtual_keyboard"])]
    TypeVirtualKeyboardLocationInfoMETA = 1000219004,

    [NativeName("XR_TYPE_VIRTUAL_KEYBOARD_MODEL_VISIBILITY_SET_INFO_META")]
    [SupportedApiProfile("openxr", ["XR_META_virtual_keyboard"])]
    TypeVirtualKeyboardModelVisibilitySetInfoMETA = 1000219005,

    [NativeName("XR_TYPE_VIRTUAL_KEYBOARD_ANIMATION_STATE_META")]
    [SupportedApiProfile("openxr", ["XR_META_virtual_keyboard"])]
    TypeVirtualKeyboardAnimationStateMETA = 1000219006,

    [NativeName("XR_TYPE_VIRTUAL_KEYBOARD_MODEL_ANIMATION_STATES_META")]
    [SupportedApiProfile("openxr", ["XR_META_virtual_keyboard"])]
    TypeVirtualKeyboardModelAnimationStatesMETA = 1000219007,

    [NativeName("XR_TYPE_VIRTUAL_KEYBOARD_TEXTURE_DATA_META")]
    [SupportedApiProfile("openxr", ["XR_META_virtual_keyboard"])]
    TypeVirtualKeyboardTextureDataMETA = 1000219009,

    [NativeName("XR_TYPE_VIRTUAL_KEYBOARD_INPUT_INFO_META")]
    [SupportedApiProfile("openxr", ["XR_META_virtual_keyboard"])]
    TypeVirtualKeyboardInputInfoMETA = 1000219010,

    [NativeName("XR_TYPE_VIRTUAL_KEYBOARD_TEXT_CONTEXT_CHANGE_INFO_META")]
    [SupportedApiProfile("openxr", ["XR_META_virtual_keyboard"])]
    TypeVirtualKeyboardTextContextChangeInfoMETA = 1000219011,

    [NativeName("XR_TYPE_EVENT_DATA_VIRTUAL_KEYBOARD_COMMIT_TEXT_META")]
    [SupportedApiProfile("openxr", ["XR_META_virtual_keyboard"])]
    TypeEventDataVirtualKeyboardCommitTextMETA = 1000219014,

    [NativeName("XR_TYPE_EVENT_DATA_VIRTUAL_KEYBOARD_BACKSPACE_META")]
    [SupportedApiProfile("openxr", ["XR_META_virtual_keyboard"])]
    TypeEventDataVirtualKeyboardBackspaceMETA = 1000219015,

    [NativeName("XR_TYPE_EVENT_DATA_VIRTUAL_KEYBOARD_ENTER_META")]
    [SupportedApiProfile("openxr", ["XR_META_virtual_keyboard"])]
    TypeEventDataVirtualKeyboardEnterMETA = 1000219016,

    [NativeName("XR_TYPE_EVENT_DATA_VIRTUAL_KEYBOARD_SHOWN_META")]
    [SupportedApiProfile("openxr", ["XR_META_virtual_keyboard"])]
    TypeEventDataVirtualKeyboardShownMETA = 1000219017,

    [NativeName("XR_TYPE_EVENT_DATA_VIRTUAL_KEYBOARD_HIDDEN_META")]
    [SupportedApiProfile("openxr", ["XR_META_virtual_keyboard"])]
    TypeEventDataVirtualKeyboardHiddenMETA = 1000219018,

    [NativeName("XR_TYPE_EXTERNAL_CAMERA_OCULUS")]
    [SupportedApiProfile("openxr", ["XR_OCULUS_external_camera"])]
    TypeExternalCameraOCULUS = 1000226000,

    [NativeName("XR_TYPE_VULKAN_SWAPCHAIN_CREATE_INFO_META")]
    [SupportedApiProfile("openxr", ["XR_META_vulkan_swapchain_create_info"])]
    TypeVulkanSwapchainCreateInfoMETA = 1000227000,

    [NativeName("XR_TYPE_PERFORMANCE_METRICS_STATE_META")]
    [SupportedApiProfile("openxr", ["XR_META_performance_metrics"])]
    TypePerformanceMetricsStateMETA = 1000232001,

    [NativeName("XR_TYPE_PERFORMANCE_METRICS_COUNTER_META")]
    [SupportedApiProfile("openxr", ["XR_META_performance_metrics"])]
    TypePerformanceMetricsCounterMETA = 1000232002,

    [NativeName("XR_TYPE_SPACE_LIST_SAVE_INFO_FB")]
    [SupportedApiProfile(
        "openxr",
        ["XR_FB_spatial_entity_storage_batch"],
        ImpliesSets = ["XR_FB_spatial_entity_storage", "XR_VERSION_1_0"]
    )]
    TypeSpaceListSaveInfoFB = 1000238000,

    [NativeName("XR_TYPE_EVENT_DATA_SPACE_LIST_SAVE_COMPLETE_FB")]
    [SupportedApiProfile(
        "openxr",
        ["XR_FB_spatial_entity_storage_batch"],
        ImpliesSets = ["XR_FB_spatial_entity_storage", "XR_VERSION_1_0"]
    )]
    TypeEventDataSpaceListSaveCompleteFB = 1000238001,

    [NativeName("XR_TYPE_SPACE_USER_CREATE_INFO_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_spatial_entity_user"])]
    TypeSpaceUserCreateInfoFB = 1000241001,

    [NativeName("XR_TYPE_SYSTEM_HEADSET_ID_PROPERTIES_META")]
    [SupportedApiProfile("openxr", ["XR_META_headset_id"])]
    TypeSystemHeadsetIdPropertiesMETA = 1000245000,

    [NativeName("XR_TYPE_SYSTEM_SPACE_DISCOVERY_PROPERTIES_META")]
    [SupportedApiProfile("openxr", ["XR_META_spatial_entity_discovery"])]
    TypeSystemSpaceDiscoveryPropertiesMETA = 1000247000,

    [NativeName("XR_TYPE_SPACE_DISCOVERY_INFO_META")]
    [SupportedApiProfile("openxr", ["XR_META_spatial_entity_discovery"])]
    TypeSpaceDiscoveryInfoMETA = 1000247001,

    [NativeName("XR_TYPE_SPACE_FILTER_UUID_META")]
    [SupportedApiProfile("openxr", ["XR_META_spatial_entity_discovery"])]
    TypeSpaceFilterUuidMETA = 1000247003,

    [NativeName("XR_TYPE_SPACE_FILTER_COMPONENT_META")]
    [SupportedApiProfile("openxr", ["XR_META_spatial_entity_discovery"])]
    TypeSpaceFilterComponentMETA = 1000247004,

    [NativeName("XR_TYPE_SPACE_DISCOVERY_RESULT_META")]
    [SupportedApiProfile("openxr", ["XR_META_spatial_entity_discovery"])]
    TypeSpaceDiscoveryResultMETA = 1000247005,

    [NativeName("XR_TYPE_SPACE_DISCOVERY_RESULTS_META")]
    [SupportedApiProfile("openxr", ["XR_META_spatial_entity_discovery"])]
    TypeSpaceDiscoveryResultsMETA = 1000247006,

    [NativeName("XR_TYPE_EVENT_DATA_SPACE_DISCOVERY_RESULTS_AVAILABLE_META")]
    [SupportedApiProfile("openxr", ["XR_META_spatial_entity_discovery"])]
    TypeEventDataSpaceDiscoveryResultsAvailableMETA = 1000247007,

    [NativeName("XR_TYPE_EVENT_DATA_SPACE_DISCOVERY_COMPLETE_META")]
    [SupportedApiProfile("openxr", ["XR_META_spatial_entity_discovery"])]
    TypeEventDataSpaceDiscoveryCompleteMETA = 1000247008,

    [NativeName("XR_TYPE_RECOMMENDED_LAYER_RESOLUTION_META")]
    [SupportedApiProfile("openxr", ["XR_META_recommended_layer_resolution"])]
    TypeRecommendedLayerResolutionMETA = 1000254000,

    [NativeName("XR_TYPE_RECOMMENDED_LAYER_RESOLUTION_GET_INFO_META")]
    [SupportedApiProfile("openxr", ["XR_META_recommended_layer_resolution"])]
    TypeRecommendedLayerResolutionGetInfoMETA = 1000254001,

    [NativeName("XR_TYPE_SYSTEM_SPACE_PERSISTENCE_PROPERTIES_META")]
    [SupportedApiProfile("openxr", ["XR_META_spatial_entity_persistence"])]
    TypeSystemSpacePersistencePropertiesMETA = 1000259000,

    [NativeName("XR_TYPE_SPACES_SAVE_INFO_META")]
    [SupportedApiProfile("openxr", ["XR_META_spatial_entity_persistence"])]
    TypeSpacesSaveInfoMETA = 1000259001,

    [NativeName("XR_TYPE_EVENT_DATA_SPACES_SAVE_RESULT_META")]
    [SupportedApiProfile("openxr", ["XR_META_spatial_entity_persistence"])]
    TypeEventDataSpacesSaveResultMETA = 1000259002,

    [NativeName("XR_TYPE_SPACES_ERASE_INFO_META")]
    [SupportedApiProfile("openxr", ["XR_META_spatial_entity_persistence"])]
    TypeSpacesEraseInfoMETA = 1000259003,

    [NativeName("XR_TYPE_EVENT_DATA_SPACES_ERASE_RESULT_META")]
    [SupportedApiProfile("openxr", ["XR_META_spatial_entity_persistence"])]
    TypeEventDataSpacesEraseResultMETA = 1000259004,

    [NativeName("XR_TYPE_SYSTEM_PASSTHROUGH_COLOR_LUT_PROPERTIES_META")]
    [SupportedApiProfile(
        "openxr",
        ["XR_META_passthrough_color_lut"],
        ImpliesSets = ["XR_FB_passthrough", "XR_VERSION_1_0"]
    )]
    TypeSystemPassthroughColorLutPropertiesMETA = 1000266000,

    [NativeName("XR_TYPE_PASSTHROUGH_COLOR_LUT_CREATE_INFO_META")]
    [SupportedApiProfile(
        "openxr",
        ["XR_META_passthrough_color_lut"],
        ImpliesSets = ["XR_FB_passthrough", "XR_VERSION_1_0"]
    )]
    TypePassthroughColorLutCreateInfoMETA = 1000266001,

    [NativeName("XR_TYPE_PASSTHROUGH_COLOR_LUT_UPDATE_INFO_META")]
    [SupportedApiProfile(
        "openxr",
        ["XR_META_passthrough_color_lut"],
        ImpliesSets = ["XR_FB_passthrough", "XR_VERSION_1_0"]
    )]
    TypePassthroughColorLutUpdateInfoMETA = 1000266002,

    [NativeName("XR_TYPE_PASSTHROUGH_COLOR_MAP_LUT_META")]
    [SupportedApiProfile(
        "openxr",
        ["XR_META_passthrough_color_lut"],
        ImpliesSets = ["XR_FB_passthrough", "XR_VERSION_1_0"]
    )]
    TypePassthroughColorMapLutMETA = 1000266100,

    [NativeName("XR_TYPE_PASSTHROUGH_COLOR_MAP_INTERPOLATED_LUT_META")]
    [SupportedApiProfile(
        "openxr",
        ["XR_META_passthrough_color_lut"],
        ImpliesSets = ["XR_FB_passthrough", "XR_VERSION_1_0"]
    )]
    TypePassthroughColorMapInterpolatedLutMETA = 1000266101,

    [NativeName("XR_TYPE_SPACE_TRIANGLE_MESH_GET_INFO_META")]
    [SupportedApiProfile(
        "openxr",
        ["XR_META_spatial_entity_mesh"],
        ImpliesSets = ["XR_FB_spatial_entity", "XR_VERSION_1_0"]
    )]
    TypeSpaceTriangleMeshGetInfoMETA = 1000269001,

    [NativeName("XR_TYPE_SPACE_TRIANGLE_MESH_META")]
    [SupportedApiProfile(
        "openxr",
        ["XR_META_spatial_entity_mesh"],
        ImpliesSets = ["XR_FB_spatial_entity", "XR_VERSION_1_0"]
    )]
    TypeSpaceTriangleMeshMETA = 1000269002,

    [NativeName("XR_TYPE_SYSTEM_PROPERTIES_BODY_TRACKING_FULL_BODY_META")]
    [SupportedApiProfile(
        "openxr",
        ["XR_META_body_tracking_full_body"],
        ImpliesSets = ["XR_FB_body_tracking"]
    )]
    TypeSystemPropertiesBodyTrackingFullBodyMETA = 1000274000,

    [NativeName("XR_TYPE_EVENT_DATA_PASSTHROUGH_LAYER_RESUMED_META")]
    [SupportedApiProfile(
        "openxr",
        ["XR_META_passthrough_layer_resumed_event"],
        ImpliesSets = ["XR_FB_passthrough", "XR_VERSION_1_0"]
    )]
    TypeEventDataPassthroughLayerResumedMETA = 1000282000,

    [NativeName("XR_TYPE_BODY_TRACKING_CALIBRATION_INFO_META")]
    [SupportedApiProfile(
        "openxr",
        ["XR_META_body_tracking_calibration"],
        ImpliesSets = ["XR_FB_body_tracking"]
    )]
    TypeBodyTrackingCalibrationInfoMETA = 1000283002,

    [NativeName("XR_TYPE_BODY_TRACKING_CALIBRATION_STATUS_META")]
    [SupportedApiProfile(
        "openxr",
        ["XR_META_body_tracking_calibration"],
        ImpliesSets = ["XR_FB_body_tracking"]
    )]
    TypeBodyTrackingCalibrationStatusMETA = 1000283003,

    [NativeName("XR_TYPE_SYSTEM_PROPERTIES_BODY_TRACKING_CALIBRATION_META")]
    [SupportedApiProfile(
        "openxr",
        ["XR_META_body_tracking_calibration"],
        ImpliesSets = ["XR_FB_body_tracking"]
    )]
    TypeSystemPropertiesBodyTrackingCalibrationMETA = 1000283004,

    [NativeName("XR_TYPE_BODY_TRACKING_FIDELITY_STATUS_META")]
    [SupportedApiProfile(
        "openxr",
        ["XR_META_body_tracking_fidelity"],
        ImpliesSets = ["XR_FB_body_tracking", "XR_VERSION_1_0"]
    )]
    TypeBodyTrackingFidelityStatusMETA = 1000284000,

    [NativeName("XR_TYPE_SYSTEM_PROPERTIES_BODY_TRACKING_FIDELITY_META")]
    [SupportedApiProfile(
        "openxr",
        ["XR_META_body_tracking_fidelity"],
        ImpliesSets = ["XR_FB_body_tracking", "XR_VERSION_1_0"]
    )]
    TypeSystemPropertiesBodyTrackingFidelityMETA = 1000284001,

    [NativeName("XR_TYPE_SYSTEM_FACE_TRACKING_PROPERTIES2_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_face_tracking2"])]
    TypeSystemFaceTrackingProperties2FB = 1000287013,

    [NativeName("XR_TYPE_FACE_TRACKER_CREATE_INFO2_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_face_tracking2"])]
    TypeFaceTrackerCreateInfo2FB = 1000287014,

    [NativeName("XR_TYPE_FACE_EXPRESSION_INFO2_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_face_tracking2"])]
    TypeFaceExpressionInfo2FB = 1000287015,

    [NativeName("XR_TYPE_FACE_EXPRESSION_WEIGHTS2_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_face_tracking2"])]
    TypeFaceExpressionWeights2FB = 1000287016,

    [NativeName("XR_TYPE_SYSTEM_SPATIAL_ENTITY_SHARING_PROPERTIES_META")]
    [SupportedApiProfile(
        "openxr",
        ["XR_META_spatial_entity_sharing"],
        ImpliesSets = ["XR_FB_spatial_entity"]
    )]
    TypeSystemSpatialEntitySharingPropertiesMETA = 1000290000,

    [NativeName("XR_TYPE_SHARE_SPACES_INFO_META")]
    [SupportedApiProfile(
        "openxr",
        ["XR_META_spatial_entity_sharing"],
        ImpliesSets = ["XR_FB_spatial_entity"]
    )]
    TypeShareSpacesInfoMETA = 1000290001,

    [NativeName("XR_TYPE_EVENT_DATA_SHARE_SPACES_COMPLETE_META")]
    [SupportedApiProfile(
        "openxr",
        ["XR_META_spatial_entity_sharing"],
        ImpliesSets = ["XR_FB_spatial_entity"]
    )]
    TypeEventDataShareSpacesCompleteMETA = 1000290002,

    [NativeName("XR_TYPE_ENVIRONMENT_DEPTH_PROVIDER_CREATE_INFO_META")]
    [SupportedApiProfile("openxr", ["XR_META_environment_depth"])]
    TypeEnvironmentDepthProviderCreateInfoMETA = 1000291000,

    [NativeName("XR_TYPE_ENVIRONMENT_DEPTH_SWAPCHAIN_CREATE_INFO_META")]
    [SupportedApiProfile("openxr", ["XR_META_environment_depth"])]
    TypeEnvironmentDepthSwapchainCreateInfoMETA = 1000291001,

    [NativeName("XR_TYPE_ENVIRONMENT_DEPTH_SWAPCHAIN_STATE_META")]
    [SupportedApiProfile("openxr", ["XR_META_environment_depth"])]
    TypeEnvironmentDepthSwapchainStateMETA = 1000291002,

    [NativeName("XR_TYPE_ENVIRONMENT_DEPTH_IMAGE_ACQUIRE_INFO_META")]
    [SupportedApiProfile("openxr", ["XR_META_environment_depth"])]
    TypeEnvironmentDepthImageAcquireInfoMETA = 1000291003,

    [NativeName("XR_TYPE_ENVIRONMENT_DEPTH_IMAGE_VIEW_META")]
    [SupportedApiProfile("openxr", ["XR_META_environment_depth"])]
    TypeEnvironmentDepthImageViewMETA = 1000291004,

    [NativeName("XR_TYPE_ENVIRONMENT_DEPTH_IMAGE_META")]
    [SupportedApiProfile("openxr", ["XR_META_environment_depth"])]
    TypeEnvironmentDepthImageMETA = 1000291005,

    [NativeName("XR_TYPE_ENVIRONMENT_DEPTH_HAND_REMOVAL_SET_INFO_META")]
    [SupportedApiProfile("openxr", ["XR_META_environment_depth"])]
    TypeEnvironmentDepthHandRemovalSetInfoMETA = 1000291006,

    [NativeName("XR_TYPE_SYSTEM_ENVIRONMENT_DEPTH_PROPERTIES_META")]
    [SupportedApiProfile("openxr", ["XR_META_environment_depth"])]
    TypeSystemEnvironmentDepthPropertiesMETA = 1000291007,

    [NativeName("XR_TYPE_ENVIRONMENT_DEPTH_IMAGE_TIMESTAMP_META")]
    [SupportedApiProfile("openxr", ["XR_META_environment_depth"])]
    TypeEnvironmentDepthImageTimestampMETA = 1000291008,

    [NativeName("XR_TYPE_RENDER_MODEL_CREATE_INFO_EXT")]
    [SupportedApiProfile(
        "openxr",
        ["XR_EXT_render_model"],
        ImpliesSets = ["XR_EXT_render_model+XR_EXT_uuid", "XR_EXT_render_model+XR_VERSION_1_1"]
    )]
    TypeRenderModelCreateInfoEXT = 1000300000,

    [NativeName("XR_TYPE_RENDER_MODEL_PROPERTIES_GET_INFO_EXT")]
    [SupportedApiProfile(
        "openxr",
        ["XR_EXT_render_model"],
        ImpliesSets = ["XR_EXT_render_model+XR_EXT_uuid", "XR_EXT_render_model+XR_VERSION_1_1"]
    )]
    TypeRenderModelPropertiesGetInfoEXT = 1000300001,

    [NativeName("XR_TYPE_RENDER_MODEL_PROPERTIES_EXT")]
    [SupportedApiProfile(
        "openxr",
        ["XR_EXT_render_model"],
        ImpliesSets = ["XR_EXT_render_model+XR_EXT_uuid", "XR_EXT_render_model+XR_VERSION_1_1"]
    )]
    TypeRenderModelPropertiesEXT = 1000300002,

    [NativeName("XR_TYPE_RENDER_MODEL_SPACE_CREATE_INFO_EXT")]
    [SupportedApiProfile(
        "openxr",
        ["XR_EXT_render_model"],
        ImpliesSets = ["XR_EXT_render_model+XR_EXT_uuid", "XR_EXT_render_model+XR_VERSION_1_1"]
    )]
    TypeRenderModelSpaceCreateInfoEXT = 1000300003,

    [NativeName("XR_TYPE_RENDER_MODEL_STATE_GET_INFO_EXT")]
    [SupportedApiProfile(
        "openxr",
        ["XR_EXT_render_model"],
        ImpliesSets = ["XR_EXT_render_model+XR_EXT_uuid", "XR_EXT_render_model+XR_VERSION_1_1"]
    )]
    TypeRenderModelStateGetInfoEXT = 1000300004,

    [NativeName("XR_TYPE_RENDER_MODEL_STATE_EXT")]
    [SupportedApiProfile(
        "openxr",
        ["XR_EXT_render_model"],
        ImpliesSets = ["XR_EXT_render_model+XR_EXT_uuid", "XR_EXT_render_model+XR_VERSION_1_1"]
    )]
    TypeRenderModelStateEXT = 1000300005,

    [NativeName("XR_TYPE_RENDER_MODEL_ASSET_CREATE_INFO_EXT")]
    [SupportedApiProfile(
        "openxr",
        ["XR_EXT_render_model"],
        ImpliesSets = ["XR_EXT_render_model+XR_EXT_uuid", "XR_EXT_render_model+XR_VERSION_1_1"]
    )]
    TypeRenderModelAssetCreateInfoEXT = 1000300006,

    [NativeName("XR_TYPE_RENDER_MODEL_ASSET_DATA_GET_INFO_EXT")]
    [SupportedApiProfile(
        "openxr",
        ["XR_EXT_render_model"],
        ImpliesSets = ["XR_EXT_render_model+XR_EXT_uuid", "XR_EXT_render_model+XR_VERSION_1_1"]
    )]
    TypeRenderModelAssetDataGetInfoEXT = 1000300007,

    [NativeName("XR_TYPE_RENDER_MODEL_ASSET_DATA_EXT")]
    [SupportedApiProfile(
        "openxr",
        ["XR_EXT_render_model"],
        ImpliesSets = ["XR_EXT_render_model+XR_EXT_uuid", "XR_EXT_render_model+XR_VERSION_1_1"]
    )]
    TypeRenderModelAssetDataEXT = 1000300008,

    [NativeName("XR_TYPE_RENDER_MODEL_ASSET_PROPERTIES_GET_INFO_EXT")]
    [SupportedApiProfile(
        "openxr",
        ["XR_EXT_render_model"],
        ImpliesSets = ["XR_EXT_render_model+XR_EXT_uuid", "XR_EXT_render_model+XR_VERSION_1_1"]
    )]
    TypeRenderModelAssetPropertiesGetInfoEXT = 1000300009,

    [NativeName("XR_TYPE_RENDER_MODEL_ASSET_PROPERTIES_EXT")]
    [SupportedApiProfile(
        "openxr",
        ["XR_EXT_render_model"],
        ImpliesSets = ["XR_EXT_render_model+XR_EXT_uuid", "XR_EXT_render_model+XR_VERSION_1_1"]
    )]
    TypeRenderModelAssetPropertiesEXT = 1000300010,

    [NativeName("XR_TYPE_INTERACTION_RENDER_MODEL_IDS_ENUMERATE_INFO_EXT")]
    [SupportedApiProfile(
        "openxr",
        ["XR_EXT_interaction_render_model"],
        ImpliesSets = ["XR_EXT_render_model"]
    )]
    TypeInteractionRenderModelIdsEnumerateInfoEXT = 1000301000,

    [NativeName("XR_TYPE_INTERACTION_RENDER_MODEL_SUBACTION_PATH_INFO_EXT")]
    [SupportedApiProfile(
        "openxr",
        ["XR_EXT_interaction_render_model"],
        ImpliesSets = ["XR_EXT_render_model"]
    )]
    TypeInteractionRenderModelSubactionPathInfoEXT = 1000301001,

    [NativeName("XR_TYPE_EVENT_DATA_INTERACTION_RENDER_MODELS_CHANGED_EXT")]
    [SupportedApiProfile(
        "openxr",
        ["XR_EXT_interaction_render_model"],
        ImpliesSets = ["XR_EXT_render_model"]
    )]
    TypeEventDataInteractionRenderModelsChangedEXT = 1000301002,

    [NativeName("XR_TYPE_INTERACTION_RENDER_MODEL_TOP_LEVEL_USER_PATH_GET_INFO_EXT")]
    [SupportedApiProfile(
        "openxr",
        ["XR_EXT_interaction_render_model"],
        ImpliesSets = ["XR_EXT_render_model"]
    )]
    TypeInteractionRenderModelTopLevelUserPathGetInfoEXT = 1000301003,

    [NativeName("XR_TYPE_PASSTHROUGH_CREATE_INFO_HTC")]
    [SupportedApiProfile("openxr", ["XR_HTC_passthrough"])]
    TypePassthroughCreateInfoHTC = 1000317001,

    [NativeName("XR_TYPE_PASSTHROUGH_COLOR_HTC")]
    [SupportedApiProfile("openxr", ["XR_HTC_passthrough"])]
    TypePassthroughColorHTC = 1000317002,

    [NativeName("XR_TYPE_PASSTHROUGH_MESH_TRANSFORM_INFO_HTC")]
    [SupportedApiProfile("openxr", ["XR_HTC_passthrough"])]
    TypePassthroughMeshTransformInfoHTC = 1000317003,

    [NativeName("XR_TYPE_COMPOSITION_LAYER_PASSTHROUGH_HTC")]
    [SupportedApiProfile("openxr", ["XR_HTC_passthrough"])]
    TypeCompositionLayerPassthroughHTC = 1000317004,

    [NativeName("XR_TYPE_FOVEATION_APPLY_INFO_HTC")]
    [SupportedApiProfile("openxr", ["XR_HTC_foveation"])]
    TypeFoveationApplyInfoHTC = 1000318000,

    [NativeName("XR_TYPE_FOVEATION_DYNAMIC_MODE_INFO_HTC")]
    [SupportedApiProfile("openxr", ["XR_HTC_foveation"])]
    TypeFoveationDynamicModeInfoHTC = 1000318001,

    [NativeName("XR_TYPE_FOVEATION_CUSTOM_MODE_INFO_HTC")]
    [SupportedApiProfile("openxr", ["XR_HTC_foveation"])]
    TypeFoveationCustomModeInfoHTC = 1000318002,

    [NativeName("XR_TYPE_SYSTEM_ANCHOR_PROPERTIES_HTC")]
    [SupportedApiProfile("openxr", ["XR_HTC_anchor"])]
    TypeSystemAnchorPropertiesHTC = 1000319000,

    [NativeName("XR_TYPE_SPATIAL_ANCHOR_CREATE_INFO_HTC")]
    [SupportedApiProfile("openxr", ["XR_HTC_anchor"])]
    TypeSpatialAnchorCreateInfoHTC = 1000319001,

    [NativeName("XR_TYPE_SYSTEM_BODY_TRACKING_PROPERTIES_HTC")]
    [SupportedApiProfile("openxr", ["XR_HTC_body_tracking"])]
    TypeSystemBodyTrackingPropertiesHTC = 1000320000,

    [NativeName("XR_TYPE_BODY_TRACKER_CREATE_INFO_HTC")]
    [SupportedApiProfile("openxr", ["XR_HTC_body_tracking"])]
    TypeBodyTrackerCreateInfoHTC = 1000320001,

    [NativeName("XR_TYPE_BODY_JOINTS_LOCATE_INFO_HTC")]
    [SupportedApiProfile("openxr", ["XR_HTC_body_tracking"])]
    TypeBodyJointsLocateInfoHTC = 1000320002,

    [NativeName("XR_TYPE_BODY_JOINT_LOCATIONS_HTC")]
    [SupportedApiProfile("openxr", ["XR_HTC_body_tracking"])]
    TypeBodyJointLocationsHTC = 1000320003,

    [NativeName("XR_TYPE_BODY_SKELETON_HTC")]
    [SupportedApiProfile("openxr", ["XR_HTC_body_tracking"])]
    TypeBodySkeletonHTC = 1000320004,

    [NativeName("XR_TYPE_ACTIVE_ACTION_SET_PRIORITIES_EXT")]
    [SupportedApiProfile("openxr", ["XR_EXT_active_action_set_priority"])]
    TypeActiveActionSetPrioritiesEXT = 1000373000,

    [NativeName("XR_TYPE_SYSTEM_FORCE_FEEDBACK_CURL_PROPERTIES_MNDX")]
    [SupportedApiProfile(
        "openxr",
        ["XR_MNDX_force_feedback_curl"],
        ImpliesSets = ["XR_EXT_hand_tracking", "XR_VERSION_1_0"]
    )]
    TypeSystemForceFeedbackCurlPropertiesMNDX = 1000375000,

    [NativeName("XR_TYPE_FORCE_FEEDBACK_CURL_APPLY_LOCATIONS_MNDX")]
    [SupportedApiProfile(
        "openxr",
        ["XR_MNDX_force_feedback_curl"],
        ImpliesSets = ["XR_EXT_hand_tracking", "XR_VERSION_1_0"]
    )]
    TypeForceFeedbackCurlApplyLocationsMNDX = 1000375001,

    [NativeName("XR_TYPE_BODY_TRACKER_CREATE_INFO_BD")]
    [SupportedApiProfile("openxr", ["XR_BD_body_tracking"])]
    TypeBodyTrackerCreateInfoBD = 1000385001,

    [NativeName("XR_TYPE_BODY_JOINTS_LOCATE_INFO_BD")]
    [SupportedApiProfile("openxr", ["XR_BD_body_tracking"])]
    TypeBodyJointsLocateInfoBD = 1000385002,

    [NativeName("XR_TYPE_BODY_JOINT_LOCATIONS_BD")]
    [SupportedApiProfile("openxr", ["XR_BD_body_tracking"])]
    TypeBodyJointLocationsBD = 1000385003,

    [NativeName("XR_TYPE_SYSTEM_BODY_TRACKING_PROPERTIES_BD")]
    [SupportedApiProfile("openxr", ["XR_BD_body_tracking"])]
    TypeSystemBodyTrackingPropertiesBD = 1000385004,

    [NativeName("XR_TYPE_SYSTEM_FACIAL_SIMULATION_PROPERTIES_BD")]
    [SupportedApiProfile("openxr", ["XR_BD_facial_simulation"])]
    TypeSystemFacialSimulationPropertiesBD = 1000386001,

    [NativeName("XR_TYPE_FACE_TRACKER_CREATE_INFO_BD")]
    [SupportedApiProfile("openxr", ["XR_BD_facial_simulation"])]
    TypeFaceTrackerCreateInfoBD = 1000386002,

    [NativeName("XR_TYPE_FACIAL_SIMULATION_DATA_GET_INFO_BD")]
    [SupportedApiProfile("openxr", ["XR_BD_facial_simulation"])]
    TypeFacialSimulationDataGetInfoBD = 1000386003,

    [NativeName("XR_TYPE_FACIAL_SIMULATION_DATA_BD")]
    [SupportedApiProfile("openxr", ["XR_BD_facial_simulation"])]
    TypeFacialSimulationDataBD = 1000386004,

    [NativeName("XR_TYPE_LIP_EXPRESSION_DATA_BD")]
    [SupportedApiProfile("openxr", ["XR_BD_facial_simulation"])]
    TypeLipExpressionDataBD = 1000386005,

    [NativeName("XR_TYPE_SYSTEM_SPATIAL_SENSING_PROPERTIES_BD")]
    [SupportedApiProfile(
        "openxr",
        ["XR_BD_spatial_sensing"],
        ImpliesSets = ["XR_EXT_future", "XR_VERSION_1_0"]
    )]
    TypeSystemSpatialSensingPropertiesBD = 1000389000,

    [NativeName("XR_TYPE_SPATIAL_ENTITY_COMPONENT_GET_INFO_BD")]
    [SupportedApiProfile(
        "openxr",
        ["XR_BD_spatial_sensing"],
        ImpliesSets = ["XR_EXT_future", "XR_VERSION_1_0"]
    )]
    TypeSpatialEntityComponentGetInfoBD = 1000389001,

    [NativeName("XR_TYPE_SPATIAL_ENTITY_LOCATION_GET_INFO_BD")]
    [SupportedApiProfile(
        "openxr",
        ["XR_BD_spatial_sensing"],
        ImpliesSets = ["XR_EXT_future", "XR_VERSION_1_0"]
    )]
    TypeSpatialEntityLocationGetInfoBD = 1000389002,

    [NativeName("XR_TYPE_SPATIAL_ENTITY_COMPONENT_DATA_LOCATION_BD")]
    [SupportedApiProfile(
        "openxr",
        ["XR_BD_spatial_sensing"],
        ImpliesSets = ["XR_EXT_future", "XR_VERSION_1_0"]
    )]
    TypeSpatialEntityComponentDataLocationBD = 1000389003,

    [NativeName("XR_TYPE_SPATIAL_ENTITY_COMPONENT_DATA_SEMANTIC_BD")]
    [SupportedApiProfile(
        "openxr",
        ["XR_BD_spatial_sensing"],
        ImpliesSets = ["XR_EXT_future", "XR_VERSION_1_0"]
    )]
    TypeSpatialEntityComponentDataSemanticBD = 1000389004,

    [NativeName("XR_TYPE_SPATIAL_ENTITY_COMPONENT_DATA_BOUNDING_BOX_2D_BD")]
    [SupportedApiProfile(
        "openxr",
        ["XR_BD_spatial_sensing"],
        ImpliesSets = ["XR_EXT_future", "XR_VERSION_1_0"]
    )]
    TypeSpatialEntityComponentDataBoundingBox2DBD = 1000389005,

    [NativeName("XR_TYPE_SPATIAL_ENTITY_COMPONENT_DATA_POLYGON_BD")]
    [SupportedApiProfile(
        "openxr",
        ["XR_BD_spatial_sensing"],
        ImpliesSets = ["XR_EXT_future", "XR_VERSION_1_0"]
    )]
    TypeSpatialEntityComponentDataPolygonBD = 1000389006,

    [NativeName("XR_TYPE_SPATIAL_ENTITY_COMPONENT_DATA_BOUNDING_BOX_3D_BD")]
    [SupportedApiProfile(
        "openxr",
        ["XR_BD_spatial_sensing"],
        ImpliesSets = ["XR_EXT_future", "XR_VERSION_1_0"]
    )]
    TypeSpatialEntityComponentDataBoundingBox3DBD = 1000389007,

    [NativeName("XR_TYPE_SPATIAL_ENTITY_COMPONENT_DATA_TRIANGLE_MESH_BD")]
    [SupportedApiProfile(
        "openxr",
        ["XR_BD_spatial_sensing"],
        ImpliesSets = ["XR_EXT_future", "XR_VERSION_1_0"]
    )]
    TypeSpatialEntityComponentDataTriangleMeshBD = 1000389008,

    [NativeName("XR_TYPE_SENSE_DATA_PROVIDER_CREATE_INFO_BD")]
    [SupportedApiProfile(
        "openxr",
        ["XR_BD_spatial_sensing"],
        ImpliesSets = ["XR_EXT_future", "XR_VERSION_1_0"]
    )]
    TypeSenseDataProviderCreateInfoBD = 1000389009,

    [NativeName("XR_TYPE_SENSE_DATA_PROVIDER_START_INFO_BD")]
    [SupportedApiProfile(
        "openxr",
        ["XR_BD_spatial_sensing"],
        ImpliesSets = ["XR_EXT_future", "XR_VERSION_1_0"]
    )]
    TypeSenseDataProviderStartInfoBD = 1000389010,

    [NativeName("XR_TYPE_EVENT_DATA_SENSE_DATA_PROVIDER_STATE_CHANGED_BD")]
    [SupportedApiProfile(
        "openxr",
        ["XR_BD_spatial_sensing"],
        ImpliesSets = ["XR_EXT_future", "XR_VERSION_1_0"]
    )]
    TypeEventDataSenseDataProviderStateChangedBD = 1000389011,

    [NativeName("XR_TYPE_EVENT_DATA_SENSE_DATA_UPDATED_BD")]
    [SupportedApiProfile(
        "openxr",
        ["XR_BD_spatial_sensing"],
        ImpliesSets = ["XR_EXT_future", "XR_VERSION_1_0"]
    )]
    TypeEventDataSenseDataUpdatedBD = 1000389012,

    [NativeName("XR_TYPE_SENSE_DATA_QUERY_INFO_BD")]
    [SupportedApiProfile(
        "openxr",
        ["XR_BD_spatial_sensing"],
        ImpliesSets = ["XR_EXT_future", "XR_VERSION_1_0"]
    )]
    TypeSenseDataQueryInfoBD = 1000389013,

    [NativeName("XR_TYPE_SENSE_DATA_QUERY_COMPLETION_BD")]
    [SupportedApiProfile(
        "openxr",
        ["XR_BD_spatial_sensing"],
        ImpliesSets = ["XR_EXT_future", "XR_VERSION_1_0"]
    )]
    TypeSenseDataQueryCompletionBD = 1000389014,

    [NativeName("XR_TYPE_SENSE_DATA_FILTER_UUID_BD")]
    [SupportedApiProfile(
        "openxr",
        ["XR_BD_spatial_sensing"],
        ImpliesSets = ["XR_EXT_future", "XR_VERSION_1_0"]
    )]
    TypeSenseDataFilterUuidBD = 1000389015,

    [NativeName("XR_TYPE_SENSE_DATA_FILTER_SEMANTIC_BD")]
    [SupportedApiProfile(
        "openxr",
        ["XR_BD_spatial_sensing"],
        ImpliesSets = ["XR_EXT_future", "XR_VERSION_1_0"]
    )]
    TypeSenseDataFilterSemanticBD = 1000389016,

    [NativeName("XR_TYPE_QUERIED_SENSE_DATA_GET_INFO_BD")]
    [SupportedApiProfile(
        "openxr",
        ["XR_BD_spatial_sensing"],
        ImpliesSets = ["XR_EXT_future", "XR_VERSION_1_0"]
    )]
    TypeQueriedSenseDataGetInfoBD = 1000389017,

    [NativeName("XR_TYPE_QUERIED_SENSE_DATA_BD")]
    [SupportedApiProfile(
        "openxr",
        ["XR_BD_spatial_sensing"],
        ImpliesSets = ["XR_EXT_future", "XR_VERSION_1_0"]
    )]
    TypeQueriedSenseDataBD = 1000389018,

    [NativeName("XR_TYPE_SPATIAL_ENTITY_STATE_BD")]
    [SupportedApiProfile(
        "openxr",
        ["XR_BD_spatial_sensing"],
        ImpliesSets = ["XR_EXT_future", "XR_VERSION_1_0"]
    )]
    TypeSpatialEntityStateBD = 1000389019,

    [NativeName("XR_TYPE_SPATIAL_ENTITY_ANCHOR_CREATE_INFO_BD")]
    [SupportedApiProfile(
        "openxr",
        ["XR_BD_spatial_sensing"],
        ImpliesSets = ["XR_EXT_future", "XR_VERSION_1_0"]
    )]
    TypeSpatialEntityAnchorCreateInfoBD = 1000389020,

    [NativeName("XR_TYPE_ANCHOR_SPACE_CREATE_INFO_BD")]
    [SupportedApiProfile(
        "openxr",
        ["XR_BD_spatial_sensing"],
        ImpliesSets = ["XR_EXT_future", "XR_VERSION_1_0"]
    )]
    TypeAnchorSpaceCreateInfoBD = 1000389021,

    [NativeName("XR_TYPE_SYSTEM_SPATIAL_ANCHOR_PROPERTIES_BD")]
    [SupportedApiProfile(
        "openxr",
        ["XR_BD_spatial_anchor"],
        ImpliesSets = ["XR_BD_spatial_sensing"]
    )]
    TypeSystemSpatialAnchorPropertiesBD = 1000390000,

    [NativeName("XR_TYPE_SPATIAL_ANCHOR_CREATE_INFO_BD")]
    [SupportedApiProfile(
        "openxr",
        ["XR_BD_spatial_anchor"],
        ImpliesSets = ["XR_BD_spatial_sensing"]
    )]
    TypeSpatialAnchorCreateInfoBD = 1000390001,

    [NativeName("XR_TYPE_SPATIAL_ANCHOR_CREATE_COMPLETION_BD")]
    [SupportedApiProfile(
        "openxr",
        ["XR_BD_spatial_anchor"],
        ImpliesSets = ["XR_BD_spatial_sensing"]
    )]
    TypeSpatialAnchorCreateCompletionBD = 1000390002,

    [NativeName("XR_TYPE_SPATIAL_ANCHOR_PERSIST_INFO_BD")]
    [SupportedApiProfile(
        "openxr",
        ["XR_BD_spatial_anchor"],
        ImpliesSets = ["XR_BD_spatial_sensing"]
    )]
    TypeSpatialAnchorPersistInfoBD = 1000390003,

    [NativeName("XR_TYPE_SPATIAL_ANCHOR_UNPERSIST_INFO_BD")]
    [SupportedApiProfile(
        "openxr",
        ["XR_BD_spatial_anchor"],
        ImpliesSets = ["XR_BD_spatial_sensing"]
    )]
    TypeSpatialAnchorUnpersistInfoBD = 1000390004,

    [NativeName("XR_TYPE_SYSTEM_SPATIAL_ANCHOR_SHARING_PROPERTIES_BD")]
    [SupportedApiProfile(
        "openxr",
        ["XR_BD_spatial_anchor_sharing"],
        ImpliesSets = ["XR_BD_spatial_anchor"]
    )]
    TypeSystemSpatialAnchorSharingPropertiesBD = 1000391000,

    [NativeName("XR_TYPE_SPATIAL_ANCHOR_SHARE_INFO_BD")]
    [SupportedApiProfile(
        "openxr",
        ["XR_BD_spatial_anchor_sharing"],
        ImpliesSets = ["XR_BD_spatial_anchor"]
    )]
    TypeSpatialAnchorShareInfoBD = 1000391001,

    [NativeName("XR_TYPE_SHARED_SPATIAL_ANCHOR_DOWNLOAD_INFO_BD")]
    [SupportedApiProfile(
        "openxr",
        ["XR_BD_spatial_anchor_sharing"],
        ImpliesSets = ["XR_BD_spatial_anchor"]
    )]
    TypeSharedSpatialAnchorDownloadInfoBD = 1000391002,

    [NativeName("XR_TYPE_SYSTEM_SPATIAL_SCENE_PROPERTIES_BD")]
    [SupportedApiProfile(
        "openxr",
        ["XR_BD_spatial_scene"],
        ImpliesSets = ["XR_BD_spatial_sensing"]
    )]
    TypeSystemSpatialScenePropertiesBD = 1000392000,

    [NativeName("XR_TYPE_SCENE_CAPTURE_INFO_BD")]
    [SupportedApiProfile(
        "openxr",
        ["XR_BD_spatial_scene"],
        ImpliesSets = ["XR_BD_spatial_sensing"]
    )]
    TypeSceneCaptureInfoBD = 1000392001,

    [NativeName("XR_TYPE_SYSTEM_SPATIAL_MESH_PROPERTIES_BD")]
    [SupportedApiProfile("openxr", ["XR_BD_spatial_mesh"], ImpliesSets = ["XR_BD_spatial_sensing"])]
    TypeSystemSpatialMeshPropertiesBD = 1000393000,

    [NativeName("XR_TYPE_SENSE_DATA_PROVIDER_CREATE_INFO_SPATIAL_MESH_BD")]
    [SupportedApiProfile("openxr", ["XR_BD_spatial_mesh"], ImpliesSets = ["XR_BD_spatial_sensing"])]
    TypeSenseDataProviderCreateInfoSpatialMeshBD = 1000393001,

    [NativeName("XR_TYPE_FUTURE_POLL_RESULT_PROGRESS_BD")]
    [SupportedApiProfile(
        "openxr",
        ["XR_BD_future_progress"],
        ImpliesSets = ["XR_EXT_future", "XR_VERSION_1_0"]
    )]
    TypeFuturePollResultProgressBD = 1000394001,

    [NativeName("XR_TYPE_SYSTEM_SPATIAL_PLANE_PROPERTIES_BD")]
    [SupportedApiProfile(
        "openxr",
        ["XR_BD_spatial_plane"],
        ImpliesSets = ["XR_BD_spatial_sensing"]
    )]
    TypeSystemSpatialPlanePropertiesBD = 1000396000,

    [NativeName("XR_TYPE_SPATIAL_ENTITY_COMPONENT_DATA_PLANE_ORIENTATION_BD")]
    [SupportedApiProfile(
        "openxr",
        ["XR_BD_spatial_plane"],
        ImpliesSets = ["XR_BD_spatial_sensing"]
    )]
    TypeSpatialEntityComponentDataPlaneOrientationBD = 1000396001,

    [NativeName("XR_TYPE_SENSE_DATA_FILTER_PLANE_ORIENTATION_BD")]
    [SupportedApiProfile(
        "openxr",
        ["XR_BD_spatial_plane"],
        ImpliesSets = ["XR_BD_spatial_sensing"]
    )]
    TypeSenseDataFilterPlaneOrientationBD = 1000396002,

    [NativeName("XR_TYPE_SPATIAL_AUDIO_RENDERER_CREATE_INFO_BD")]
    [SupportedApiProfile("openxr", ["XR_BD_spatial_audio_rendering"])]
    TypeSpatialAudioRendererCreateInfoBD = 1000409000,

    [NativeName("XR_TYPE_AUDIO_BUFFER_BD")]
    [SupportedApiProfile("openxr", ["XR_BD_spatial_audio_rendering"])]
    TypeAudioBufferBD = 1000409001,

    [NativeName("XR_TYPE_SOUND_OBJECT_DIRECTIVITY_CARDIOID_BD")]
    [SupportedApiProfile("openxr", ["XR_BD_spatial_audio_rendering"])]
    TypeSoundObjectDirectivityCardioidBD = 1000409003,

    [NativeName("XR_TYPE_SOUND_OBJECT_SHAPE_SPHERE_BD")]
    [SupportedApiProfile("openxr", ["XR_BD_spatial_audio_rendering"])]
    TypeSoundObjectShapeSphereBD = 1000409004,

    [NativeName("XR_TYPE_SOUND_OBJECT_DISTANCE_ATTENUATION_BD")]
    [SupportedApiProfile("openxr", ["XR_BD_spatial_audio_rendering"])]
    TypeSoundObjectDistanceAttenuationBD = 1000409005,

    [NativeName("XR_TYPE_SOUND_OBJECT_DISTANCE_ATTENUATION_CURVE_BD")]
    [SupportedApiProfile("openxr", ["XR_BD_spatial_audio_rendering"])]
    TypeSoundObjectDistanceAttenuationCurveBD = 1000409006,

    [NativeName("XR_TYPE_SOUND_OBJECT_CONFIG_BD")]
    [SupportedApiProfile("openxr", ["XR_BD_spatial_audio_rendering"])]
    TypeSoundObjectConfigBD = 1000409007,

    [NativeName("XR_TYPE_SOUND_FIELD_CONFIG_BD")]
    [SupportedApiProfile("openxr", ["XR_BD_spatial_audio_rendering"])]
    TypeSoundFieldConfigBD = 1000409008,

    [NativeName("XR_TYPE_SOUND_FIELD_CHANNEL_DEFINITION_SURROUND_BD")]
    [SupportedApiProfile("openxr", ["XR_BD_spatial_audio_rendering"])]
    TypeSoundFieldChannelDefinitionSurroundBD = 1000409009,

    [NativeName("XR_TYPE_SOUND_FIELD_CHANNEL_DEFINITION_AMBIX_BD")]
    [SupportedApiProfile("openxr", ["XR_BD_spatial_audio_rendering"])]
    TypeSoundFieldChannelDefinitionAmbixBD = 1000409010,

    [NativeName("XR_TYPE_SOUND_FIELD_CHANNEL_DEFINITION_FUMA_BD")]
    [SupportedApiProfile("openxr", ["XR_BD_spatial_audio_rendering"])]
    TypeSoundFieldChannelDefinitionFumaBD = 1000409011,

    [NativeName("XR_TYPE_SOUND_TRIANGLE_MESH_BD")]
    [SupportedApiProfile("openxr", ["XR_BD_spatial_audio_rendering"])]
    TypeSoundTriangleMeshBD = 1000409012,

    [NativeName("XR_TYPE_SOUND_OBSTACLE_CONFIG_BD")]
    [SupportedApiProfile("openxr", ["XR_BD_spatial_audio_rendering"])]
    TypeSoundObstacleConfigBD = 1000409013,

    [NativeName("XR_TYPE_SOUND_OBSTACLE_MATERIAL_CONFIG_BD")]
    [SupportedApiProfile("openxr", ["XR_BD_spatial_audio_rendering"])]
    TypeSoundObstacleMaterialConfigBD = 1000409014,

    [NativeName("XR_TYPE_HAND_TRACKING_DATA_SOURCE_INFO_EXT")]
    [SupportedApiProfile(
        "openxr",
        ["XR_EXT_hand_tracking_data_source"],
        ImpliesSets = ["XR_EXT_hand_tracking", "XR_VERSION_1_0"]
    )]
    TypeHandTrackingDataSourceInfoEXT = 1000428000,

    [NativeName("XR_TYPE_HAND_TRACKING_DATA_SOURCE_STATE_EXT")]
    [SupportedApiProfile(
        "openxr",
        ["XR_EXT_hand_tracking_data_source"],
        ImpliesSets = ["XR_EXT_hand_tracking", "XR_VERSION_1_0"]
    )]
    TypeHandTrackingDataSourceStateEXT = 1000428001,

    [NativeName("XR_TYPE_PLANE_DETECTOR_CREATE_INFO_EXT")]
    [SupportedApiProfile("openxr", ["XR_EXT_plane_detection"])]
    TypePlaneDetectorCreateInfoEXT = 1000429001,

    [NativeName("XR_TYPE_PLANE_DETECTOR_BEGIN_INFO_EXT")]
    [SupportedApiProfile("openxr", ["XR_EXT_plane_detection"])]
    TypePlaneDetectorBeginInfoEXT = 1000429002,

    [NativeName("XR_TYPE_PLANE_DETECTOR_GET_INFO_EXT")]
    [SupportedApiProfile("openxr", ["XR_EXT_plane_detection"])]
    TypePlaneDetectorGetInfoEXT = 1000429003,

    [NativeName("XR_TYPE_PLANE_DETECTOR_LOCATIONS_EXT")]
    [SupportedApiProfile("openxr", ["XR_EXT_plane_detection"])]
    TypePlaneDetectorLocationsEXT = 1000429004,

    [NativeName("XR_TYPE_PLANE_DETECTOR_LOCATION_EXT")]
    [SupportedApiProfile("openxr", ["XR_EXT_plane_detection"])]
    TypePlaneDetectorLocationEXT = 1000429005,

    [NativeName("XR_TYPE_PLANE_DETECTOR_POLYGON_BUFFER_EXT")]
    [SupportedApiProfile("openxr", ["XR_EXT_plane_detection"])]
    TypePlaneDetectorPolygonBufferEXT = 1000429006,

    [NativeName("XR_TYPE_SYSTEM_PLANE_DETECTION_PROPERTIES_EXT")]
    [SupportedApiProfile("openxr", ["XR_EXT_plane_detection"])]
    TypeSystemPlaneDetectionPropertiesEXT = 1000429007,

    [NativeName("XR_TYPE_TRACKABLE_GET_INFO_ANDROID")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_trackables"])]
    TypeTrackableGetInfoANDROID = 1000455000,

    [NativeName("XR_TYPE_ANCHOR_SPACE_CREATE_INFO_ANDROID")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_trackables"])]
    TypeAnchorSpaceCreateInfoANDROID = 1000455001,

    [NativeName("XR_TYPE_TRACKABLE_PLANE_ANDROID")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_trackables"])]
    TypeTrackablePlaneANDROID = 1000455003,

    [NativeName("XR_TYPE_TRACKABLE_TRACKER_CREATE_INFO_ANDROID")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_trackables"])]
    TypeTrackableTrackerCreateInfoANDROID = 1000455004,

    [NativeName("XR_TYPE_SYSTEM_TRACKABLES_PROPERTIES_ANDROID")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_trackables"])]
    TypeSystemTrackablesPropertiesANDROID = 1000455005,

    [NativeName("XR_TYPE_EYES_ANDROID")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_eye_tracking"])]
    TypeEyesANDROID = 1000456000,

    [NativeName("XR_TYPE_EYE_TRACKER_CREATE_INFO_ANDROID")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_eye_tracking"])]
    TypeEyeTrackerCreateInfoANDROID = 1000456001,

    [NativeName("XR_TYPE_EYES_GET_INFO_ANDROID")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_eye_tracking"])]
    TypeEyesGetInfoANDROID = 1000456002,

    [NativeName("XR_TYPE_SYSTEM_EYE_TRACKING_PROPERTIES_ANDROID")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_eye_tracking"])]
    TypeSystemEyeTrackingPropertiesANDROID = 1000456004,

    [NativeName("XR_TYPE_PERSISTED_ANCHOR_SPACE_CREATE_INFO_ANDROID")]
    [SupportedApiProfile(
        "openxr",
        ["XR_ANDROID_device_anchor_persistence"],
        ImpliesSets = ["XR_ANDROID_trackables", "XR_EXT_uuid"]
    )]
    TypePersistedAnchorSpaceCreateInfoANDROID = 1000457001,

    [NativeName("XR_TYPE_PERSISTED_ANCHOR_SPACE_INFO_ANDROID")]
    [SupportedApiProfile(
        "openxr",
        ["XR_ANDROID_device_anchor_persistence"],
        ImpliesSets = ["XR_ANDROID_trackables", "XR_EXT_uuid"]
    )]
    TypePersistedAnchorSpaceInfoANDROID = 1000457002,

    [NativeName("XR_TYPE_DEVICE_ANCHOR_PERSISTENCE_CREATE_INFO_ANDROID")]
    [SupportedApiProfile(
        "openxr",
        ["XR_ANDROID_device_anchor_persistence"],
        ImpliesSets = ["XR_ANDROID_trackables", "XR_EXT_uuid"]
    )]
    TypeDeviceAnchorPersistenceCreateInfoANDROID = 1000457003,

    [NativeName("XR_TYPE_SYSTEM_DEVICE_ANCHOR_PERSISTENCE_PROPERTIES_ANDROID")]
    [SupportedApiProfile(
        "openxr",
        ["XR_ANDROID_device_anchor_persistence"],
        ImpliesSets = ["XR_ANDROID_trackables", "XR_EXT_uuid"]
    )]
    TypeSystemDeviceAnchorPersistencePropertiesANDROID = 1000457004,

    [NativeName("XR_TYPE_FACE_TRACKER_CREATE_INFO_ANDROID")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_face_tracking"])]
    TypeFaceTrackerCreateInfoANDROID = 1000458000,

    [NativeName("XR_TYPE_FACE_STATE_GET_INFO_ANDROID")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_face_tracking"])]
    TypeFaceStateGetInfoANDROID = 1000458001,

    [NativeName("XR_TYPE_FACE_STATE_ANDROID")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_face_tracking"])]
    TypeFaceStateANDROID = 1000458002,

    [NativeName("XR_TYPE_SYSTEM_FACE_TRACKING_PROPERTIES_ANDROID")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_face_tracking"])]
    TypeSystemFaceTrackingPropertiesANDROID = 1000458003,

    [NativeName("XR_TYPE_PASSTHROUGH_CAMERA_STATE_GET_INFO_ANDROID")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_passthrough_camera_state"])]
    TypePassthroughCameraStateGetInfoANDROID = 1000460000,

    [NativeName("XR_TYPE_SYSTEM_PASSTHROUGH_CAMERA_STATE_PROPERTIES_ANDROID")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_passthrough_camera_state"])]
    TypeSystemPassthroughCameraStatePropertiesANDROID = 1000460001,

    [NativeName("XR_TYPE_EVENT_DATA_RECOMMENDED_RESOLUTION_CHANGED_ANDROID")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_recommended_resolution"])]
    TypeEventDataRecommendedResolutionChangedANDROID = 1000461000,

    [NativeName("XR_TYPE_PASSTHROUGH_LAYER_CREATE_INFO_ANDROID")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_composition_layer_passthrough_mesh"])]
    TypePassthroughLayerCreateInfoANDROID = 1000462000,

    [NativeName("XR_TYPE_PASSTHROUGH_LAYER_MESH_ANDROID")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_composition_layer_passthrough_mesh"])]
    TypePassthroughLayerMeshANDROID = 1000462001,

    [NativeName("XR_TYPE_COMPOSITION_LAYER_PASSTHROUGH_ANDROID")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_composition_layer_passthrough_mesh"])]
    TypeCompositionLayerPassthroughANDROID = 1000462002,

    [NativeName("XR_TYPE_SYSTEM_PASSTHROUGH_LAYER_PROPERTIES_ANDROID")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_composition_layer_passthrough_mesh"])]
    TypeSystemPassthroughLayerPropertiesANDROID = 1000462003,

    [NativeName("XR_TYPE_RAYCAST_INFO_ANDROID")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_raycast"], ImpliesSets = ["XR_ANDROID_trackables"])]
    TypeRaycastInfoANDROID = 1000463000,

    [NativeName("XR_TYPE_RAYCAST_HIT_RESULTS_ANDROID")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_raycast"], ImpliesSets = ["XR_ANDROID_trackables"])]
    TypeRaycastHitResultsANDROID = 1000463001,

    [NativeName("XR_TYPE_PERFORMANCE_METRICS_STATE_ANDROID")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_performance_metrics"])]
    TypePerformanceMetricsStateANDROID = 1000465000,

    [NativeName("XR_TYPE_PERFORMANCE_METRICS_COUNTER_ANDROID")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_performance_metrics"])]
    TypePerformanceMetricsCounterANDROID = 1000465001,

    [NativeName("XR_TYPE_TRACKABLE_OBJECT_ANDROID")]
    [SupportedApiProfile(
        "openxr",
        ["XR_ANDROID_trackables_object"],
        ImpliesSets = ["XR_ANDROID_trackables"]
    )]
    TypeTrackableObjectANDROID = 1000466000,

    [NativeName("XR_TYPE_TRACKABLE_OBJECT_CONFIGURATION_ANDROID")]
    [SupportedApiProfile(
        "openxr",
        ["XR_ANDROID_trackables_object"],
        ImpliesSets = ["XR_ANDROID_trackables"]
    )]
    TypeTrackableObjectConfigurationANDROID = 1000466001,

    [NativeName("XR_TYPE_FUTURE_CANCEL_INFO_EXT")]
    [SupportedApiProfile("openxr", ["XR_EXT_future"])]
    TypeFutureCancelInfoEXT = 1000469000,

    [NativeName("XR_TYPE_FUTURE_POLL_INFO_EXT")]
    [SupportedApiProfile("openxr", ["XR_EXT_future"])]
    TypeFuturePollInfoEXT = 1000469001,

    [NativeName("XR_TYPE_FUTURE_COMPLETION_EXT")]
    [SupportedApiProfile("openxr", ["XR_EXT_future"])]
    TypeFutureCompletionEXT = 1000469002,

    [NativeName("XR_TYPE_FUTURE_POLL_RESULT_EXT")]
    [SupportedApiProfile("openxr", ["XR_EXT_future"])]
    TypeFuturePollResultEXT = 1000469003,

    [NativeName("XR_TYPE_EVENT_DATA_USER_PRESENCE_CHANGED_EXT")]
    [SupportedApiProfile("openxr", ["XR_EXT_user_presence"])]
    TypeEventDataUserPresenceChangedEXT = 1000470000,

    [NativeName("XR_TYPE_SYSTEM_USER_PRESENCE_PROPERTIES_EXT")]
    [SupportedApiProfile("openxr", ["XR_EXT_user_presence"])]
    TypeSystemUserPresencePropertiesEXT = 1000470001,

    [NativeName("XR_TYPE_SYSTEM_NOTIFICATIONS_SET_INFO_ML")]
    [SupportedApiProfile("openxr", ["XR_ML_system_notifications"])]
    TypeSystemNotificationsSetInfoML = 1000473000,

    [NativeName("XR_TYPE_WORLD_MESH_DETECTOR_CREATE_INFO_ML")]
    [SupportedApiProfile("openxr", ["XR_ML_world_mesh_detection"], ImpliesSets = ["XR_EXT_future"])]
    TypeWorldMeshDetectorCreateInfoML = 1000474001,

    [NativeName("XR_TYPE_WORLD_MESH_STATE_REQUEST_INFO_ML")]
    [SupportedApiProfile("openxr", ["XR_ML_world_mesh_detection"], ImpliesSets = ["XR_EXT_future"])]
    TypeWorldMeshStateRequestInfoML = 1000474002,

    [NativeName("XR_TYPE_WORLD_MESH_BLOCK_STATE_ML")]
    [SupportedApiProfile("openxr", ["XR_ML_world_mesh_detection"], ImpliesSets = ["XR_EXT_future"])]
    TypeWorldMeshBlockStateML = 1000474003,

    [NativeName("XR_TYPE_WORLD_MESH_STATE_REQUEST_COMPLETION_ML")]
    [SupportedApiProfile("openxr", ["XR_ML_world_mesh_detection"], ImpliesSets = ["XR_EXT_future"])]
    TypeWorldMeshStateRequestCompletionML = 1000474004,

    [NativeName("XR_TYPE_WORLD_MESH_BUFFER_RECOMMENDED_SIZE_INFO_ML")]
    [SupportedApiProfile("openxr", ["XR_ML_world_mesh_detection"], ImpliesSets = ["XR_EXT_future"])]
    TypeWorldMeshBufferRecommendedSizeInfoML = 1000474005,

    [NativeName("XR_TYPE_WORLD_MESH_BUFFER_SIZE_ML")]
    [SupportedApiProfile("openxr", ["XR_ML_world_mesh_detection"], ImpliesSets = ["XR_EXT_future"])]
    TypeWorldMeshBufferSizeML = 1000474006,

    [NativeName("XR_TYPE_WORLD_MESH_BUFFER_ML")]
    [SupportedApiProfile("openxr", ["XR_ML_world_mesh_detection"], ImpliesSets = ["XR_EXT_future"])]
    TypeWorldMeshBufferML = 1000474007,

    [NativeName("XR_TYPE_WORLD_MESH_BLOCK_REQUEST_ML")]
    [SupportedApiProfile("openxr", ["XR_ML_world_mesh_detection"], ImpliesSets = ["XR_EXT_future"])]
    TypeWorldMeshBlockRequestML = 1000474008,

    [NativeName("XR_TYPE_WORLD_MESH_GET_INFO_ML")]
    [SupportedApiProfile("openxr", ["XR_ML_world_mesh_detection"], ImpliesSets = ["XR_EXT_future"])]
    TypeWorldMeshGetInfoML = 1000474009,

    [NativeName("XR_TYPE_WORLD_MESH_BLOCK_ML")]
    [SupportedApiProfile("openxr", ["XR_ML_world_mesh_detection"], ImpliesSets = ["XR_EXT_future"])]
    TypeWorldMeshBlockML = 1000474010,

    [NativeName("XR_TYPE_WORLD_MESH_REQUEST_COMPLETION_ML")]
    [SupportedApiProfile("openxr", ["XR_ML_world_mesh_detection"], ImpliesSets = ["XR_EXT_future"])]
    TypeWorldMeshRequestCompletionML = 1000474011,

    [NativeName("XR_TYPE_WORLD_MESH_REQUEST_COMPLETION_INFO_ML")]
    [SupportedApiProfile("openxr", ["XR_ML_world_mesh_detection"], ImpliesSets = ["XR_EXT_future"])]
    TypeWorldMeshRequestCompletionInfoML = 1000474012,

    [NativeName("XR_TYPE_SYSTEM_FACIAL_EXPRESSION_PROPERTIES_ML")]
    [SupportedApiProfile("openxr", ["XR_ML_facial_expression"])]
    TypeSystemFacialExpressionPropertiesML = 1000482004,

    [NativeName("XR_TYPE_FACIAL_EXPRESSION_CLIENT_CREATE_INFO_ML")]
    [SupportedApiProfile("openxr", ["XR_ML_facial_expression"])]
    TypeFacialExpressionClientCreateInfoML = 1000482005,

    [NativeName("XR_TYPE_FACIAL_EXPRESSION_BLEND_SHAPE_GET_INFO_ML")]
    [SupportedApiProfile("openxr", ["XR_ML_facial_expression"])]
    TypeFacialExpressionBlendShapeGetInfoML = 1000482006,

    [NativeName("XR_TYPE_FACIAL_EXPRESSION_BLEND_SHAPE_PROPERTIES_ML")]
    [SupportedApiProfile("openxr", ["XR_ML_facial_expression"])]
    TypeFacialExpressionBlendShapePropertiesML = 1000482007,

    [NativeName("XR_TYPE_SYSTEM_BOUNDARY_VISIBILITY_PROPERTIES_META")]
    [SupportedApiProfile("openxr", ["XR_META_boundary_visibility"])]
    TypeSystemBoundaryVisibilityPropertiesMETA = 1000528000,

    [NativeName("XR_TYPE_EVENT_DATA_BOUNDARY_VISIBILITY_CHANGED_META")]
    [SupportedApiProfile("openxr", ["XR_META_boundary_visibility"])]
    TypeEventDataBoundaryVisibilityChangedMETA = 1000528001,

    [NativeName("XR_TYPE_SYSTEM_SIMULTANEOUS_HANDS_AND_CONTROLLERS_PROPERTIES_META")]
    [SupportedApiProfile("openxr", ["XR_META_simultaneous_hands_and_controllers"])]
    TypeSystemSimultaneousHandsAndControllersPropertiesMETA = 1000532001,

    [NativeName("XR_TYPE_SIMULTANEOUS_HANDS_AND_CONTROLLERS_TRACKING_RESUME_INFO_META")]
    [SupportedApiProfile("openxr", ["XR_META_simultaneous_hands_and_controllers"])]
    TypeSimultaneousHandsAndControllersTrackingResumeInfoMETA = 1000532002,

    [NativeName("XR_TYPE_SIMULTANEOUS_HANDS_AND_CONTROLLERS_TRACKING_PAUSE_INFO_META")]
    [SupportedApiProfile("openxr", ["XR_META_simultaneous_hands_and_controllers"])]
    TypeSimultaneousHandsAndControllersTrackingPauseInfoMETA = 1000532003,

    [NativeName("XR_TYPE_FACE_TRACKING_VISEMES_META")]
    [SupportedApiProfile(
        "openxr",
        ["XR_META_face_tracking_visemes"],
        ImpliesSets = ["XR_FB_face_tracking2", "XR_VERSION_1_0"]
    )]
    TypeFaceTrackingVisemesMETA = 1000541000,

    [NativeName("XR_TYPE_SYSTEM_FACE_TRACKING_VISEMES_PROPERTIES_META")]
    [SupportedApiProfile(
        "openxr",
        ["XR_META_face_tracking_visemes"],
        ImpliesSets = ["XR_FB_face_tracking2", "XR_VERSION_1_0"]
    )]
    TypeSystemFaceTrackingVisemesPropertiesMETA = 1000541001,

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
    TypeRoomMeshFaceIndicesMETA = 1000553000,

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
    TypeSpaceRoomMeshGetInfoMETA = 1000553001,

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
    TypeRoomMeshMETA = 1000553002,

    [NativeName("XR_TYPE_COLOCATION_DISCOVERY_START_INFO_META")]
    [SupportedApiProfile("openxr", ["XR_META_colocation_discovery"])]
    TypeColocationDiscoveryStartInfoMETA = 1000571010,

    [NativeName("XR_TYPE_COLOCATION_DISCOVERY_STOP_INFO_META")]
    [SupportedApiProfile("openxr", ["XR_META_colocation_discovery"])]
    TypeColocationDiscoveryStopInfoMETA = 1000571011,

    [NativeName("XR_TYPE_COLOCATION_ADVERTISEMENT_START_INFO_META")]
    [SupportedApiProfile("openxr", ["XR_META_colocation_discovery"])]
    TypeColocationAdvertisementStartInfoMETA = 1000571012,

    [NativeName("XR_TYPE_COLOCATION_ADVERTISEMENT_STOP_INFO_META")]
    [SupportedApiProfile("openxr", ["XR_META_colocation_discovery"])]
    TypeColocationAdvertisementStopInfoMETA = 1000571013,

    [NativeName("XR_TYPE_EVENT_DATA_START_COLOCATION_ADVERTISEMENT_COMPLETE_META")]
    [SupportedApiProfile("openxr", ["XR_META_colocation_discovery"])]
    TypeEventDataStartColocationAdvertisementCompleteMETA = 1000571020,

    [NativeName("XR_TYPE_EVENT_DATA_STOP_COLOCATION_ADVERTISEMENT_COMPLETE_META")]
    [SupportedApiProfile("openxr", ["XR_META_colocation_discovery"])]
    TypeEventDataStopColocationAdvertisementCompleteMETA = 1000571021,

    [NativeName("XR_TYPE_EVENT_DATA_COLOCATION_ADVERTISEMENT_COMPLETE_META")]
    [SupportedApiProfile("openxr", ["XR_META_colocation_discovery"])]
    TypeEventDataColocationAdvertisementCompleteMETA = 1000571022,

    [NativeName("XR_TYPE_EVENT_DATA_START_COLOCATION_DISCOVERY_COMPLETE_META")]
    [SupportedApiProfile("openxr", ["XR_META_colocation_discovery"])]
    TypeEventDataStartColocationDiscoveryCompleteMETA = 1000571023,

    [NativeName("XR_TYPE_EVENT_DATA_COLOCATION_DISCOVERY_RESULT_META")]
    [SupportedApiProfile("openxr", ["XR_META_colocation_discovery"])]
    TypeEventDataColocationDiscoveryResultMETA = 1000571024,

    [NativeName("XR_TYPE_EVENT_DATA_COLOCATION_DISCOVERY_COMPLETE_META")]
    [SupportedApiProfile("openxr", ["XR_META_colocation_discovery"])]
    TypeEventDataColocationDiscoveryCompleteMETA = 1000571025,

    [NativeName("XR_TYPE_EVENT_DATA_STOP_COLOCATION_DISCOVERY_COMPLETE_META")]
    [SupportedApiProfile("openxr", ["XR_META_colocation_discovery"])]
    TypeEventDataStopColocationDiscoveryCompleteMETA = 1000571026,

    [NativeName("XR_TYPE_SYSTEM_COLOCATION_DISCOVERY_PROPERTIES_META")]
    [SupportedApiProfile("openxr", ["XR_META_colocation_discovery"])]
    TypeSystemColocationDiscoveryPropertiesMETA = 1000571030,

    [NativeName("XR_TYPE_SHARE_SPACES_RECIPIENT_GROUPS_META")]
    [SupportedApiProfile("openxr", ["XR_META_spatial_entity_group_sharing"])]
    TypeShareSpacesRecipientGroupsMETA = 1000572000,

    [NativeName("XR_TYPE_SPACE_GROUP_UUID_FILTER_INFO_META")]
    [SupportedApiProfile("openxr", ["XR_META_spatial_entity_group_sharing"])]
    TypeSpaceGroupUuidFilterInfoMETA = 1000572001,

    [NativeName("XR_TYPE_SYSTEM_SPATIAL_ENTITY_GROUP_SHARING_PROPERTIES_META")]
    [SupportedApiProfile("openxr", ["XR_META_spatial_entity_group_sharing"])]
    TypeSystemSpatialEntityGroupSharingPropertiesMETA = 1000572100,

    [NativeName("XR_TYPE_SYSTEM_ENVIRONMENT_RAYCAST_PROPERTIES_META")]
    [SupportedApiProfile(
        "openxr",
        ["XR_META_environment_raycast"],
        ImpliesSets = ["XR_EXT_future"]
    )]
    TypeSystemEnvironmentRaycastPropertiesMETA = 1000592000,

    [NativeName("XR_TYPE_ENVIRONMENT_RAYCASTER_CREATE_INFO_META")]
    [SupportedApiProfile(
        "openxr",
        ["XR_META_environment_raycast"],
        ImpliesSets = ["XR_EXT_future"]
    )]
    TypeEnvironmentRaycasterCreateInfoMETA = 1000592001,

    [NativeName("XR_TYPE_ENVIRONMENT_RAYCASTER_CREATE_COMPLETION_META")]
    [SupportedApiProfile(
        "openxr",
        ["XR_META_environment_raycast"],
        ImpliesSets = ["XR_EXT_future"]
    )]
    TypeEnvironmentRaycasterCreateCompletionMETA = 1000592002,

    [NativeName("XR_TYPE_ENVIRONMENT_RAYCAST_HIT_GET_INFO_META")]
    [SupportedApiProfile(
        "openxr",
        ["XR_META_environment_raycast"],
        ImpliesSets = ["XR_EXT_future"]
    )]
    TypeEnvironmentRaycastHitGetInfoMETA = 1000592003,

    [NativeName("XR_TYPE_ENVIRONMENT_RAYCAST_HIT_META")]
    [SupportedApiProfile(
        "openxr",
        ["XR_META_environment_raycast"],
        ImpliesSets = ["XR_EXT_future"]
    )]
    TypeEnvironmentRaycastHitMETA = 1000592004,

    [NativeName("XR_TYPE_ENVIRONMENT_RAYCAST_FILTER_DISTANCE_META")]
    [SupportedApiProfile(
        "openxr",
        ["XR_META_environment_raycast"],
        ImpliesSets = ["XR_EXT_future"]
    )]
    TypeEnvironmentRaycastFilterDistanceMETA = 1000592005,

    [NativeName("XR_TYPE_TILE_PROPERTIES_META")]
    [SupportedApiProfile("openxr", ["XR_META_tile_properties_hint"])]
    TypeTilePropertiesMETA = 1000609000,

    [NativeName("XR_TYPE_TILE_PROPERTIES_HINT_META")]
    [SupportedApiProfile("openxr", ["XR_META_tile_properties_hint"])]
    TypeTilePropertiesHintMETA = 1000609001,

    [NativeName("XR_TYPE_LIGHT_ESTIMATOR_CREATE_INFO_ANDROID")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_light_estimation"])]
    TypeLightEstimatorCreateInfoANDROID = 1000700000,

    [NativeName("XR_TYPE_LIGHT_ESTIMATE_GET_INFO_ANDROID")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_light_estimation"])]
    TypeLightEstimateGetInfoANDROID = 1000700001,

    [NativeName("XR_TYPE_LIGHT_ESTIMATE_ANDROID")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_light_estimation"])]
    TypeLightEstimateANDROID = 1000700002,

    [NativeName("XR_TYPE_DIRECTIONAL_LIGHT_ANDROID")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_light_estimation"])]
    TypeDirectionalLightANDROID = 1000700003,

    [NativeName("XR_TYPE_SPHERICAL_HARMONICS_ANDROID")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_light_estimation"])]
    TypeSphericalHarmonicsANDROID = 1000700004,

    [NativeName("XR_TYPE_AMBIENT_LIGHT_ANDROID")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_light_estimation"])]
    TypeAmbientLightANDROID = 1000700005,

    [NativeName("XR_TYPE_SYSTEM_LIGHT_ESTIMATION_PROPERTIES_ANDROID")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_light_estimation"])]
    TypeSystemLightEstimationPropertiesANDROID = 1000700006,

    [NativeName("XR_TYPE_ANCHOR_SHARING_INFO_ANDROID")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_anchor_sharing_export"])]
    TypeAnchorSharingInfoANDROID = 1000701000,

    [NativeName("XR_TYPE_ANCHOR_SHARING_TOKEN_ANDROID")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_anchor_sharing_export"])]
    TypeAnchorSharingTokenANDROID = 1000701001,

    [NativeName("XR_TYPE_SYSTEM_ANCHOR_SHARING_EXPORT_PROPERTIES_ANDROID")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_anchor_sharing_export"])]
    TypeSystemAnchorSharingExportPropertiesANDROID = 1000701002,

    [NativeName("XR_TYPE_SYSTEM_MARKER_TRACKING_PROPERTIES_ANDROID")]
    [SupportedApiProfile(
        "openxr",
        ["XR_ANDROID_trackables_marker"],
        ImpliesSets = ["XR_ANDROID_trackables"]
    )]
    TypeSystemMarkerTrackingPropertiesANDROID = 1000707000,

    [NativeName("XR_TYPE_TRACKABLE_MARKER_CONFIGURATION_ANDROID")]
    [SupportedApiProfile(
        "openxr",
        ["XR_ANDROID_trackables_marker"],
        ImpliesSets = ["XR_ANDROID_trackables"]
    )]
    TypeTrackableMarkerConfigurationANDROID = 1000707001,

    [NativeName("XR_TYPE_TRACKABLE_MARKER_ANDROID")]
    [SupportedApiProfile(
        "openxr",
        ["XR_ANDROID_trackables_marker"],
        ImpliesSets = ["XR_ANDROID_trackables"]
    )]
    TypeTrackableMarkerANDROID = 1000707002,

    [NativeName("XR_TYPE_SYSTEM_QR_CODE_TRACKING_PROPERTIES_ANDROID")]
    [SupportedApiProfile(
        "openxr",
        ["XR_ANDROID_trackables_qr_code"],
        ImpliesSets = ["XR_ANDROID_trackables"]
    )]
    TypeSystemQrCodeTrackingPropertiesANDROID = 1000708000,

    [NativeName("XR_TYPE_TRACKABLE_QR_CODE_CONFIGURATION_ANDROID")]
    [SupportedApiProfile(
        "openxr",
        ["XR_ANDROID_trackables_qr_code"],
        ImpliesSets = ["XR_ANDROID_trackables"]
    )]
    TypeTrackableQrCodeConfigurationANDROID = 1000708001,

    [NativeName("XR_TYPE_TRACKABLE_QR_CODE_ANDROID")]
    [SupportedApiProfile(
        "openxr",
        ["XR_ANDROID_trackables_qr_code"],
        ImpliesSets = ["XR_ANDROID_trackables"]
    )]
    TypeTrackableQrCodeANDROID = 1000708002,

    [NativeName("XR_TYPE_SYSTEM_IMAGE_TRACKING_PROPERTIES_ANDROID")]
    [SupportedApiProfile(
        "openxr",
        ["XR_ANDROID_trackables_image"],
        ImpliesSets = ["XR_ANDROID_trackables", "XR_EXT_future"]
    )]
    TypeSystemImageTrackingPropertiesANDROID = 1000709000,

    [NativeName("XR_TYPE_TRACKABLE_IMAGE_DATABASE_ENTRY_ANDROID")]
    [SupportedApiProfile(
        "openxr",
        ["XR_ANDROID_trackables_image"],
        ImpliesSets = ["XR_ANDROID_trackables", "XR_EXT_future"]
    )]
    TypeTrackableImageDatabaseEntryANDROID = 1000709001,

    [NativeName("XR_TYPE_TRACKABLE_IMAGE_DATABASE_CREATE_INFO_ANDROID")]
    [SupportedApiProfile(
        "openxr",
        ["XR_ANDROID_trackables_image"],
        ImpliesSets = ["XR_ANDROID_trackables", "XR_EXT_future"]
    )]
    TypeTrackableImageDatabaseCreateInfoANDROID = 1000709002,

    [NativeName("XR_TYPE_CREATE_TRACKABLE_IMAGE_DATABASE_COMPLETION_ANDROID")]
    [SupportedApiProfile(
        "openxr",
        ["XR_ANDROID_trackables_image"],
        ImpliesSets = ["XR_ANDROID_trackables", "XR_EXT_future"]
    )]
    TypeCreateTrackableImageDatabaseCompletionANDROID = 1000709003,

    [NativeName("XR_TYPE_TRACKABLE_IMAGE_CONFIGURATION_ANDROID")]
    [SupportedApiProfile(
        "openxr",
        ["XR_ANDROID_trackables_image"],
        ImpliesSets = ["XR_ANDROID_trackables", "XR_EXT_future"]
    )]
    TypeTrackableImageConfigurationANDROID = 1000709004,

    [NativeName("XR_TYPE_TRACKABLE_IMAGE_ANDROID")]
    [SupportedApiProfile(
        "openxr",
        ["XR_ANDROID_trackables_image"],
        ImpliesSets = ["XR_ANDROID_trackables", "XR_EXT_future"]
    )]
    TypeTrackableImageANDROID = 1000709005,

    [NativeName("XR_TYPE_EVENT_DATA_IMAGE_TRACKING_LOST_ANDROID")]
    [SupportedApiProfile(
        "openxr",
        ["XR_ANDROID_trackables_image"],
        ImpliesSets = ["XR_ANDROID_trackables", "XR_EXT_future"]
    )]
    TypeEventDataImageTrackingLostANDROID = 1000709006,

    [NativeName("XR_TYPE_SYSTEM_SCENE_MESHING_PROPERTIES_ANDROID")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_scene_meshing"])]
    TypeSystemSceneMeshingPropertiesANDROID = 1000718000,

    [NativeName("XR_TYPE_SCENE_MESHING_TRACKER_CREATE_INFO_ANDROID")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_scene_meshing"])]
    TypeSceneMeshingTrackerCreateInfoANDROID = 1000718001,

    [NativeName("XR_TYPE_SCENE_MESH_SNAPSHOT_CREATE_INFO_ANDROID")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_scene_meshing"])]
    TypeSceneMeshSnapshotCreateInfoANDROID = 1000718002,

    [NativeName("XR_TYPE_SCENE_MESH_SNAPSHOT_CREATION_RESULT_ANDROID")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_scene_meshing"])]
    TypeSceneMeshSnapshotCreationResultANDROID = 1000718003,

    [NativeName("XR_TYPE_SCENE_SUBMESH_STATE_ANDROID")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_scene_meshing"])]
    TypeSceneSubmeshStateANDROID = 1000718004,

    [NativeName("XR_TYPE_SCENE_SUBMESH_DATA_ANDROID")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_scene_meshing"])]
    TypeSceneSubmeshDataANDROID = 1000718005,

    [NativeName("XR_TYPE_SPATIAL_CAPABILITY_COMPONENT_TYPES_EXT")]
    [SupportedApiProfile("openxr", ["XR_EXT_spatial_entity"], ImpliesSets = ["XR_EXT_future"])]
    TypeSpatialCapabilityComponentTypesEXT = 1000740000,

    [NativeName("XR_TYPE_SPATIAL_CONTEXT_CREATE_INFO_EXT")]
    [SupportedApiProfile("openxr", ["XR_EXT_spatial_entity"], ImpliesSets = ["XR_EXT_future"])]
    TypeSpatialContextCreateInfoEXT = 1000740001,

    [NativeName("XR_TYPE_CREATE_SPATIAL_CONTEXT_COMPLETION_EXT")]
    [SupportedApiProfile("openxr", ["XR_EXT_spatial_entity"], ImpliesSets = ["XR_EXT_future"])]
    TypeCreateSpatialContextCompletionEXT = 1000740002,

    [NativeName("XR_TYPE_SPATIAL_DISCOVERY_SNAPSHOT_CREATE_INFO_EXT")]
    [SupportedApiProfile("openxr", ["XR_EXT_spatial_entity"], ImpliesSets = ["XR_EXT_future"])]
    TypeSpatialDiscoverySnapshotCreateInfoEXT = 1000740003,

    [NativeName("XR_TYPE_CREATE_SPATIAL_DISCOVERY_SNAPSHOT_COMPLETION_INFO_EXT")]
    [SupportedApiProfile("openxr", ["XR_EXT_spatial_entity"], ImpliesSets = ["XR_EXT_future"])]
    TypeCreateSpatialDiscoverySnapshotCompletionInfoEXT = 1000740004,

    [NativeName("XR_TYPE_CREATE_SPATIAL_DISCOVERY_SNAPSHOT_COMPLETION_EXT")]
    [SupportedApiProfile("openxr", ["XR_EXT_spatial_entity"], ImpliesSets = ["XR_EXT_future"])]
    TypeCreateSpatialDiscoverySnapshotCompletionEXT = 1000740005,

    [NativeName("XR_TYPE_SPATIAL_COMPONENT_DATA_QUERY_CONDITION_EXT")]
    [SupportedApiProfile("openxr", ["XR_EXT_spatial_entity"], ImpliesSets = ["XR_EXT_future"])]
    TypeSpatialComponentDataQueryConditionEXT = 1000740006,

    [NativeName("XR_TYPE_SPATIAL_COMPONENT_DATA_QUERY_RESULT_EXT")]
    [SupportedApiProfile("openxr", ["XR_EXT_spatial_entity"], ImpliesSets = ["XR_EXT_future"])]
    TypeSpatialComponentDataQueryResultEXT = 1000740007,

    [NativeName("XR_TYPE_SPATIAL_BUFFER_GET_INFO_EXT")]
    [SupportedApiProfile("openxr", ["XR_EXT_spatial_entity"], ImpliesSets = ["XR_EXT_future"])]
    TypeSpatialBufferGetInfoEXT = 1000740008,

    [NativeName("XR_TYPE_SPATIAL_COMPONENT_BOUNDED_2D_LIST_EXT")]
    [SupportedApiProfile("openxr", ["XR_EXT_spatial_entity"], ImpliesSets = ["XR_EXT_future"])]
    TypeSpatialComponentBounded2DListEXT = 1000740009,

    [NativeName("XR_TYPE_SPATIAL_COMPONENT_BOUNDED_3D_LIST_EXT")]
    [SupportedApiProfile("openxr", ["XR_EXT_spatial_entity"], ImpliesSets = ["XR_EXT_future"])]
    TypeSpatialComponentBounded3DListEXT = 1000740010,

    [NativeName("XR_TYPE_SPATIAL_COMPONENT_PARENT_LIST_EXT")]
    [SupportedApiProfile("openxr", ["XR_EXT_spatial_entity"], ImpliesSets = ["XR_EXT_future"])]
    TypeSpatialComponentParentListEXT = 1000740011,

    [NativeName("XR_TYPE_SPATIAL_COMPONENT_MESH_3D_LIST_EXT")]
    [SupportedApiProfile("openxr", ["XR_EXT_spatial_entity"], ImpliesSets = ["XR_EXT_future"])]
    TypeSpatialComponentMesh3DListEXT = 1000740012,

    [NativeName("XR_TYPE_SPATIAL_ENTITY_FROM_ID_CREATE_INFO_EXT")]
    [SupportedApiProfile("openxr", ["XR_EXT_spatial_entity"], ImpliesSets = ["XR_EXT_future"])]
    TypeSpatialEntityFromIdCreateInfoEXT = 1000740013,

    [NativeName("XR_TYPE_SPATIAL_UPDATE_SNAPSHOT_CREATE_INFO_EXT")]
    [SupportedApiProfile("openxr", ["XR_EXT_spatial_entity"], ImpliesSets = ["XR_EXT_future"])]
    TypeSpatialUpdateSnapshotCreateInfoEXT = 1000740014,

    [NativeName("XR_TYPE_EVENT_DATA_SPATIAL_DISCOVERY_RECOMMENDED_EXT")]
    [SupportedApiProfile("openxr", ["XR_EXT_spatial_entity"], ImpliesSets = ["XR_EXT_future"])]
    TypeEventDataSpatialDiscoveryRecommendedEXT = 1000740015,

    [NativeName("XR_TYPE_SPATIAL_FILTER_TRACKING_STATE_EXT")]
    [SupportedApiProfile("openxr", ["XR_EXT_spatial_entity"], ImpliesSets = ["XR_EXT_future"])]
    TypeSpatialFilterTrackingStateEXT = 1000740016,

    [NativeName("XR_TYPE_SPATIAL_CAPABILITY_CONFIGURATION_PLANE_TRACKING_EXT")]
    [SupportedApiProfile(
        "openxr",
        ["XR_EXT_spatial_plane_tracking"],
        ImpliesSets = ["XR_EXT_spatial_entity"]
    )]
    TypeSpatialCapabilityConfigurationPlaneTrackingEXT = 1000741000,

    [NativeName("XR_TYPE_SPATIAL_COMPONENT_PLANE_ALIGNMENT_LIST_EXT")]
    [SupportedApiProfile(
        "openxr",
        ["XR_EXT_spatial_plane_tracking"],
        ImpliesSets = ["XR_EXT_spatial_entity"]
    )]
    TypeSpatialComponentPlaneAlignmentListEXT = 1000741001,

    [NativeName("XR_TYPE_SPATIAL_COMPONENT_MESH_2D_LIST_EXT")]
    [SupportedApiProfile(
        "openxr",
        ["XR_EXT_spatial_plane_tracking"],
        ImpliesSets = ["XR_EXT_spatial_entity"]
    )]
    TypeSpatialComponentMesh2DListEXT = 1000741002,

    [NativeName("XR_TYPE_SPATIAL_COMPONENT_POLYGON_2D_LIST_EXT")]
    [SupportedApiProfile(
        "openxr",
        ["XR_EXT_spatial_plane_tracking"],
        ImpliesSets = ["XR_EXT_spatial_entity"]
    )]
    TypeSpatialComponentPolygon2DListEXT = 1000741003,

    [NativeName("XR_TYPE_SPATIAL_COMPONENT_PLANE_SEMANTIC_LABEL_LIST_EXT")]
    [SupportedApiProfile(
        "openxr",
        ["XR_EXT_spatial_plane_tracking"],
        ImpliesSets = ["XR_EXT_spatial_entity"]
    )]
    TypeSpatialComponentPlaneSemanticLabelListEXT = 1000741004,

    [NativeName("XR_TYPE_STATIONARY_REFERENCE_SPACE_GENERATION_ID_GET_INFO_EXT")]
    [SupportedApiProfile(
        "openxr",
        ["XR_EXT_stationary_reference_space"],
        ImpliesSets = ["XR_EXT_uuid", "XR_VERSION_1_0"]
    )]
    TypeStationaryReferenceSpaceGenerationIdGetInfoEXT = 1000742001,

    [NativeName("XR_TYPE_STATIONARY_REFERENCE_SPACE_GENERATION_ID_RESULT_EXT")]
    [SupportedApiProfile(
        "openxr",
        ["XR_EXT_stationary_reference_space"],
        ImpliesSets = ["XR_EXT_uuid", "XR_VERSION_1_0"]
    )]
    TypeStationaryReferenceSpaceGenerationIdResultEXT = 1000742002,

    [NativeName("XR_TYPE_SPATIAL_CAPABILITY_CONFIGURATION_QR_CODE_EXT")]
    [SupportedApiProfile(
        "openxr",
        ["XR_EXT_spatial_marker_tracking"],
        ImpliesSets = ["XR_EXT_spatial_entity"]
    )]
    TypeSpatialCapabilityConfigurationQrCodeEXT = 1000743000,

    [NativeName("XR_TYPE_SPATIAL_CAPABILITY_CONFIGURATION_MICRO_QR_CODE_EXT")]
    [SupportedApiProfile(
        "openxr",
        ["XR_EXT_spatial_marker_tracking"],
        ImpliesSets = ["XR_EXT_spatial_entity"]
    )]
    TypeSpatialCapabilityConfigurationMicroQrCodeEXT = 1000743001,

    [NativeName("XR_TYPE_SPATIAL_CAPABILITY_CONFIGURATION_ARUCO_MARKER_EXT")]
    [SupportedApiProfile(
        "openxr",
        ["XR_EXT_spatial_marker_tracking"],
        ImpliesSets = ["XR_EXT_spatial_entity"]
    )]
    TypeSpatialCapabilityConfigurationArucoMarkerEXT = 1000743002,

    [NativeName("XR_TYPE_SPATIAL_CAPABILITY_CONFIGURATION_APRIL_TAG_EXT")]
    [SupportedApiProfile(
        "openxr",
        ["XR_EXT_spatial_marker_tracking"],
        ImpliesSets = ["XR_EXT_spatial_entity"]
    )]
    TypeSpatialCapabilityConfigurationAprilTagEXT = 1000743003,

    [NativeName("XR_TYPE_SPATIAL_MARKER_SIZE_EXT")]
    [SupportedApiProfile(
        "openxr",
        ["XR_EXT_spatial_marker_tracking"],
        ImpliesSets = ["XR_EXT_spatial_entity"]
    )]
    TypeSpatialMarkerSizeEXT = 1000743004,

    [NativeName("XR_TYPE_SPATIAL_MARKER_STATIC_OPTIMIZATION_EXT")]
    [SupportedApiProfile(
        "openxr",
        ["XR_EXT_spatial_marker_tracking"],
        ImpliesSets = ["XR_EXT_spatial_entity"]
    )]
    TypeSpatialMarkerStaticOptimizationEXT = 1000743005,

    [NativeName("XR_TYPE_SPATIAL_COMPONENT_MARKER_LIST_EXT")]
    [SupportedApiProfile(
        "openxr",
        ["XR_EXT_spatial_marker_tracking"],
        ImpliesSets = ["XR_EXT_spatial_entity"]
    )]
    TypeSpatialComponentMarkerListEXT = 1000743006,

    [NativeName("XR_TYPE_SPATIAL_CAPABILITY_CONFIGURATION_ANCHOR_EXT")]
    [SupportedApiProfile(
        "openxr",
        ["XR_EXT_spatial_anchor"],
        ImpliesSets = ["XR_EXT_spatial_entity"]
    )]
    TypeSpatialCapabilityConfigurationAnchorEXT = 1000762000,

    [NativeName("XR_TYPE_SPATIAL_COMPONENT_ANCHOR_LIST_EXT")]
    [SupportedApiProfile(
        "openxr",
        ["XR_EXT_spatial_anchor"],
        ImpliesSets = ["XR_EXT_spatial_entity"]
    )]
    TypeSpatialComponentAnchorListEXT = 1000762001,

    [NativeName("XR_TYPE_SPATIAL_ANCHOR_CREATE_INFO_EXT")]
    [SupportedApiProfile(
        "openxr",
        ["XR_EXT_spatial_anchor"],
        ImpliesSets = ["XR_EXT_spatial_entity"]
    )]
    TypeSpatialAnchorCreateInfoEXT = 1000762002,

    [NativeName("XR_TYPE_SPATIAL_PERSISTENCE_CONTEXT_CREATE_INFO_EXT")]
    [SupportedApiProfile(
        "openxr",
        ["XR_EXT_spatial_persistence"],
        ImpliesSets = ["XR_EXT_future", "XR_EXT_spatial_entity"]
    )]
    TypeSpatialPersistenceContextCreateInfoEXT = 1000763000,

    [NativeName("XR_TYPE_CREATE_SPATIAL_PERSISTENCE_CONTEXT_COMPLETION_EXT")]
    [SupportedApiProfile(
        "openxr",
        ["XR_EXT_spatial_persistence"],
        ImpliesSets = ["XR_EXT_future", "XR_EXT_spatial_entity"]
    )]
    TypeCreateSpatialPersistenceContextCompletionEXT = 1000763001,

    [NativeName("XR_TYPE_SPATIAL_CONTEXT_PERSISTENCE_CONFIG_EXT")]
    [SupportedApiProfile(
        "openxr",
        ["XR_EXT_spatial_persistence"],
        ImpliesSets = ["XR_EXT_future", "XR_EXT_spatial_entity"]
    )]
    TypeSpatialContextPersistenceConfigEXT = 1000763002,

    [NativeName("XR_TYPE_SPATIAL_DISCOVERY_PERSISTENCE_UUID_FILTER_EXT")]
    [SupportedApiProfile(
        "openxr",
        ["XR_EXT_spatial_persistence"],
        ImpliesSets = ["XR_EXT_future", "XR_EXT_spatial_entity"]
    )]
    TypeSpatialDiscoveryPersistenceUuidFilterEXT = 1000763003,

    [NativeName("XR_TYPE_SPATIAL_COMPONENT_PERSISTENCE_LIST_EXT")]
    [SupportedApiProfile(
        "openxr",
        ["XR_EXT_spatial_persistence"],
        ImpliesSets = ["XR_EXT_future", "XR_EXT_spatial_entity"]
    )]
    TypeSpatialComponentPersistenceListEXT = 1000763004,

    [NativeName("XR_TYPE_HAPTIC_PARAMETRIC_VIBRATION_EXT")]
    [SupportedApiProfile("openxr", ["XR_EXT_haptic_parametric"])]
    TypeHapticParametricVibrationEXT = 1000775000,

    [NativeName("XR_TYPE_HAPTIC_PARAMETRIC_PROPERTIES_EXT")]
    [SupportedApiProfile("openxr", ["XR_EXT_haptic_parametric"])]
    TypeHapticParametricPropertiesEXT = 1000775001,

    [NativeName("XR_TYPE_SYSTEM_HAPTIC_PARAMETRIC_PROPERTIES_EXT")]
    [SupportedApiProfile("openxr", ["XR_EXT_haptic_parametric"])]
    TypeSystemHapticParametricPropertiesEXT = 1000775002,

    [NativeName("XR_TYPE_SPATIAL_ENTITY_PERSIST_INFO_EXT")]
    [SupportedApiProfile(
        "openxr",
        ["XR_EXT_spatial_persistence_operations"],
        ImpliesSets = ["XR_EXT_future", "XR_EXT_spatial_persistence"]
    )]
    TypeSpatialEntityPersistInfoEXT = 1000781000,

    [NativeName("XR_TYPE_PERSIST_SPATIAL_ENTITY_COMPLETION_EXT")]
    [SupportedApiProfile(
        "openxr",
        ["XR_EXT_spatial_persistence_operations"],
        ImpliesSets = ["XR_EXT_future", "XR_EXT_spatial_persistence"]
    )]
    TypePersistSpatialEntityCompletionEXT = 1000781001,

    [NativeName("XR_TYPE_SPATIAL_ENTITY_UNPERSIST_INFO_EXT")]
    [SupportedApiProfile(
        "openxr",
        ["XR_EXT_spatial_persistence_operations"],
        ImpliesSets = ["XR_EXT_future", "XR_EXT_spatial_persistence"]
    )]
    TypeSpatialEntityUnpersistInfoEXT = 1000781002,

    [NativeName("XR_TYPE_UNPERSIST_SPATIAL_ENTITY_COMPLETION_EXT")]
    [SupportedApiProfile(
        "openxr",
        ["XR_EXT_spatial_persistence_operations"],
        ImpliesSets = ["XR_EXT_future", "XR_EXT_spatial_persistence"]
    )]
    TypeUnpersistSpatialEntityCompletionEXT = 1000781003,

    [NativeName("XR_TYPE_SPATIAL_CAPABILITY_CONFIGURATION_OBJECT_TRACKING_ANDROID")]
    [SupportedApiProfile(
        "openxr",
        ["XR_ANDROID_spatial_object_tracking"],
        ImpliesSets = ["XR_EXT_spatial_entity"]
    )]
    TypeSpatialCapabilityConfigurationObjectTrackingANDROID = 1000785000,

    [NativeName("XR_TYPE_SPATIAL_COMPONENT_OBJECT_SEMANTIC_LABEL_LIST_ANDROID")]
    [SupportedApiProfile(
        "openxr",
        ["XR_ANDROID_spatial_object_tracking"],
        ImpliesSets = ["XR_EXT_spatial_entity"]
    )]
    TypeSpatialComponentObjectSemanticLabelListANDROID = 1000785001,

    [NativeName("XR_TYPE_SPATIAL_CAPABILITY_CONFIGURATION_DEPTH_RAYCAST_ANDROID")]
    [SupportedApiProfile(
        "openxr",
        ["XR_ANDROID_spatial_discovery_raycast"],
        ImpliesSets = ["XR_EXT_spatial_entity"]
    )]
    TypeSpatialCapabilityConfigurationDepthRaycastANDROID = 1000786000,

    [NativeName("XR_TYPE_SPATIAL_RAYCAST_INFO_ANDROID")]
    [SupportedApiProfile(
        "openxr",
        ["XR_ANDROID_spatial_discovery_raycast"],
        ImpliesSets = ["XR_EXT_spatial_entity"]
    )]
    TypeSpatialRaycastInfoANDROID = 1000786001,

    [NativeName("XR_TYPE_SPATIAL_COMPONENT_RAYCAST_RESULT_LIST_ANDROID")]
    [SupportedApiProfile(
        "openxr",
        ["XR_ANDROID_spatial_discovery_raycast"],
        ImpliesSets = ["XR_EXT_spatial_entity"]
    )]
    TypeSpatialComponentRaycastResultListANDROID = 1000786002,

    [NativeName("XR_TYPE_SPATIAL_RAYCAST_SNAPSHOT_CREATE_INFO_ANDROID")]
    [SupportedApiProfile(
        "openxr",
        ["XR_ANDROID_spatial_discovery_raycast"],
        ImpliesSets = ["XR_EXT_spatial_entity"]
    )]
    TypeSpatialRaycastSnapshotCreateInfoANDROID = 1000786003,

    [NativeName("XR_TYPE_SPATIAL_ANCHOR_PARENT_ANDROID")]
    [SupportedApiProfile(
        "openxr",
        ["XR_ANDROID_spatial_entity_bound_anchor"],
        ImpliesSets = ["XR_EXT_spatial_anchor"]
    )]
    TypeSpatialAnchorParentANDROID = 1000790000,

    [NativeName("XR_TYPE_SPATIAL_DISCOVERY_UNIQUE_ENTITIES_FILTER_ANDROID")]
    [SupportedApiProfile(
        "openxr",
        ["XR_ANDROID_spatial_component_subsumed_by"],
        ImpliesSets = ["XR_EXT_spatial_entity", "XR_EXT_spatial_plane_tracking"]
    )]
    TypeSpatialDiscoveryUniqueEntitiesFilterANDROID = 1000791001,

    [NativeName("XR_TYPE_SPATIAL_COMPONENT_SUBSUMED_BY_LIST_ANDROID")]
    [SupportedApiProfile(
        "openxr",
        ["XR_ANDROID_spatial_component_subsumed_by"],
        ImpliesSets = ["XR_EXT_spatial_entity", "XR_EXT_spatial_plane_tracking"]
    )]
    TypeSpatialComponentSubsumedByListANDROID = 1000791002,

    [NativeName("XR_TYPE_SPATIAL_ANCHOR_SPACE_FROM_ID_CREATE_INFO_ANDROID")]
    [SupportedApiProfile(
        "openxr",
        ["XR_ANDROID_spatial_anchor_space"],
        ImpliesSets = ["XR_EXT_spatial_anchor"]
    )]
    TypeSpatialAnchorSpaceFromIdCreateInfoANDROID = 1000795000,

    [NativeName("XR_TYPE_BATTERY_STATE_DISPLAY_EXT")]
    [SupportedApiProfile("openxr", ["XR_EXT_interaction_profile_battery_state_display"])]
    TypeBatteryStateDisplayEXT = 1000836000,

    [NativeName("XR_TYPE_LOADER_INIT_INFO_PROPERTIES_EXT")]
    [SupportedApiProfile("openxr", ["XR_EXT_loader_init_properties"])]
    TypeLoaderInitInfoPropertiesEXT = 1000838000,

    [NativeName("XR_TYPE_EVENT_DATA_VIEW_CONFIGURATION_VIEWS_CHANGED_EXT")]
    [SupportedApiProfile("openxr", ["XR_EXT_view_configuration_views_change"])]
    TypeEventDataViewConfigurationViewsChangedEXT = 1000839000,

    [NativeName("XR_TYPE_GRAPHICS_BINDING_VULKAN2_KHR")]
    [SupportedApiProfile("openxr", ["XR_KHR_vulkan_enable2"])]
    TypeGraphicsBindingVulkan2KHR = TypeGraphicsBindingVulkanKHR,

    [NativeName("XR_TYPE_SWAPCHAIN_IMAGE_VULKAN2_KHR")]
    [SupportedApiProfile("openxr", ["XR_KHR_vulkan_enable2"])]
    TypeSwapchainImageVulkan2KHR = TypeSwapchainImageVulkanKHR,

    [NativeName("XR_TYPE_GRAPHICS_REQUIREMENTS_VULKAN2_KHR")]
    [SupportedApiProfile("openxr", ["XR_KHR_vulkan_enable2"])]
    TypeGraphicsRequirementsVulkan2KHR = TypeGraphicsRequirementsVulkanKHR,

    [NativeName("XR_TYPE_DEVICE_PCM_SAMPLE_RATE_GET_INFO_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_haptic_pcm"])]
    TypeDevicePcmSampleRateGetInfoFB = TypeDevicePcmSampleRateStateFB,

    [NativeName("XR_TYPE_SPACES_LOCATE_INFO_KHR")]
    [SupportedApiProfile("openxr", ["XR_KHR_locate_spaces"])]
    TypeSpacesLocateInfoKHR = TypeSpacesLocateInfo,

    [NativeName("XR_TYPE_SPACE_LOCATIONS_KHR")]
    [SupportedApiProfile("openxr", ["XR_KHR_locate_spaces"])]
    TypeSpaceLocationsKHR = TypeSpaceLocations,

    [NativeName("XR_TYPE_SPACE_VELOCITIES_KHR")]
    [SupportedApiProfile("openxr", ["XR_KHR_locate_spaces"])]
    TypeSpaceVelocitiesKHR = TypeSpaceVelocities,
}
