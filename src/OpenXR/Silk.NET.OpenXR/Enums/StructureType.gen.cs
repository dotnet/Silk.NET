// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenXR
{
    [NativeName("Name", "XrStructureType")]
    public enum StructureType : int
    {
        [Obsolete("Deprecated in favour of \"Unknown\"")]
        [NativeName("Name", "XR_TYPE_UNKNOWN")]
        TypeUnknown = 0,
        [Obsolete("Deprecated in favour of \"ApiLayerProperties\"")]
        [NativeName("Name", "XR_TYPE_API_LAYER_PROPERTIES")]
        TypeApiLayerProperties = 1,
        [Obsolete("Deprecated in favour of \"ExtensionProperties\"")]
        [NativeName("Name", "XR_TYPE_EXTENSION_PROPERTIES")]
        TypeExtensionProperties = 2,
        [Obsolete("Deprecated in favour of \"InstanceCreateInfo\"")]
        [NativeName("Name", "XR_TYPE_INSTANCE_CREATE_INFO")]
        TypeInstanceCreateInfo = 3,
        [Obsolete("Deprecated in favour of \"SystemGetInfo\"")]
        [NativeName("Name", "XR_TYPE_SYSTEM_GET_INFO")]
        TypeSystemGetInfo = 4,
        [Obsolete("Deprecated in favour of \"SystemProperties\"")]
        [NativeName("Name", "XR_TYPE_SYSTEM_PROPERTIES")]
        TypeSystemProperties = 5,
        [Obsolete("Deprecated in favour of \"ViewLocateInfo\"")]
        [NativeName("Name", "XR_TYPE_VIEW_LOCATE_INFO")]
        TypeViewLocateInfo = 6,
        [Obsolete("Deprecated in favour of \"View\"")]
        [NativeName("Name", "XR_TYPE_VIEW")]
        TypeView = 7,
        [Obsolete("Deprecated in favour of \"SessionCreateInfo\"")]
        [NativeName("Name", "XR_TYPE_SESSION_CREATE_INFO")]
        TypeSessionCreateInfo = 8,
        [Obsolete("Deprecated in favour of \"SwapchainCreateInfo\"")]
        [NativeName("Name", "XR_TYPE_SWAPCHAIN_CREATE_INFO")]
        TypeSwapchainCreateInfo = 9,
        [Obsolete("Deprecated in favour of \"SessionBeginInfo\"")]
        [NativeName("Name", "XR_TYPE_SESSION_BEGIN_INFO")]
        TypeSessionBeginInfo = 10,
        [Obsolete("Deprecated in favour of \"ViewState\"")]
        [NativeName("Name", "XR_TYPE_VIEW_STATE")]
        TypeViewState = 11,
        [Obsolete("Deprecated in favour of \"FrameEndInfo\"")]
        [NativeName("Name", "XR_TYPE_FRAME_END_INFO")]
        TypeFrameEndInfo = 12,
        [Obsolete("Deprecated in favour of \"HapticVibration\"")]
        [NativeName("Name", "XR_TYPE_HAPTIC_VIBRATION")]
        TypeHapticVibration = 13,
        [Obsolete("Deprecated in favour of \"EventDataBuffer\"")]
        [NativeName("Name", "XR_TYPE_EVENT_DATA_BUFFER")]
        TypeEventDataBuffer = 16,
        [Obsolete("Deprecated in favour of \"EventDataInstanceLossPending\"")]
        [NativeName("Name", "XR_TYPE_EVENT_DATA_INSTANCE_LOSS_PENDING")]
        TypeEventDataInstanceLossPending = 17,
        [Obsolete("Deprecated in favour of \"EventDataSessionStateChanged\"")]
        [NativeName("Name", "XR_TYPE_EVENT_DATA_SESSION_STATE_CHANGED")]
        TypeEventDataSessionStateChanged = 18,
        [Obsolete("Deprecated in favour of \"ActionStateBoolean\"")]
        [NativeName("Name", "XR_TYPE_ACTION_STATE_BOOLEAN")]
        TypeActionStateBoolean = 23,
        [Obsolete("Deprecated in favour of \"ActionStateFloat\"")]
        [NativeName("Name", "XR_TYPE_ACTION_STATE_FLOAT")]
        TypeActionStateFloat = 24,
        [Obsolete("Deprecated in favour of \"ActionStateVector2f\"")]
        [NativeName("Name", "XR_TYPE_ACTION_STATE_VECTOR2F")]
        TypeActionStateVector2f = 25,
        [Obsolete("Deprecated in favour of \"ActionStatePose\"")]
        [NativeName("Name", "XR_TYPE_ACTION_STATE_POSE")]
        TypeActionStatePose = 27,
        [Obsolete("Deprecated in favour of \"ActionSetCreateInfo\"")]
        [NativeName("Name", "XR_TYPE_ACTION_SET_CREATE_INFO")]
        TypeActionSetCreateInfo = 28,
        [Obsolete("Deprecated in favour of \"ActionCreateInfo\"")]
        [NativeName("Name", "XR_TYPE_ACTION_CREATE_INFO")]
        TypeActionCreateInfo = 29,
        [Obsolete("Deprecated in favour of \"InstanceProperties\"")]
        [NativeName("Name", "XR_TYPE_INSTANCE_PROPERTIES")]
        TypeInstanceProperties = 32,
        [Obsolete("Deprecated in favour of \"FrameWaitInfo\"")]
        [NativeName("Name", "XR_TYPE_FRAME_WAIT_INFO")]
        TypeFrameWaitInfo = 33,
        [Obsolete("Deprecated in favour of \"CompositionLayerProjection\"")]
        [NativeName("Name", "XR_TYPE_COMPOSITION_LAYER_PROJECTION")]
        TypeCompositionLayerProjection = 35,
        [Obsolete("Deprecated in favour of \"CompositionLayerQuad\"")]
        [NativeName("Name", "XR_TYPE_COMPOSITION_LAYER_QUAD")]
        TypeCompositionLayerQuad = 36,
        [Obsolete("Deprecated in favour of \"ReferenceSpaceCreateInfo\"")]
        [NativeName("Name", "XR_TYPE_REFERENCE_SPACE_CREATE_INFO")]
        TypeReferenceSpaceCreateInfo = 37,
        [Obsolete("Deprecated in favour of \"ActionSpaceCreateInfo\"")]
        [NativeName("Name", "XR_TYPE_ACTION_SPACE_CREATE_INFO")]
        TypeActionSpaceCreateInfo = 38,
        [Obsolete("Deprecated in favour of \"EventDataReferenceSpaceChangePending\"")]
        [NativeName("Name", "XR_TYPE_EVENT_DATA_REFERENCE_SPACE_CHANGE_PENDING")]
        TypeEventDataReferenceSpaceChangePending = 40,
        [Obsolete("Deprecated in favour of \"ViewConfigurationView\"")]
        [NativeName("Name", "XR_TYPE_VIEW_CONFIGURATION_VIEW")]
        TypeViewConfigurationView = 41,
        [Obsolete("Deprecated in favour of \"SpaceLocation\"")]
        [NativeName("Name", "XR_TYPE_SPACE_LOCATION")]
        TypeSpaceLocation = 42,
        [Obsolete("Deprecated in favour of \"SpaceVelocity\"")]
        [NativeName("Name", "XR_TYPE_SPACE_VELOCITY")]
        TypeSpaceVelocity = 43,
        [Obsolete("Deprecated in favour of \"FrameState\"")]
        [NativeName("Name", "XR_TYPE_FRAME_STATE")]
        TypeFrameState = 44,
        [Obsolete("Deprecated in favour of \"ViewConfigurationProperties\"")]
        [NativeName("Name", "XR_TYPE_VIEW_CONFIGURATION_PROPERTIES")]
        TypeViewConfigurationProperties = 45,
        [Obsolete("Deprecated in favour of \"FrameBeginInfo\"")]
        [NativeName("Name", "XR_TYPE_FRAME_BEGIN_INFO")]
        TypeFrameBeginInfo = 46,
        [Obsolete("Deprecated in favour of \"CompositionLayerProjectionView\"")]
        [NativeName("Name", "XR_TYPE_COMPOSITION_LAYER_PROJECTION_VIEW")]
        TypeCompositionLayerProjectionView = 48,
        [Obsolete("Deprecated in favour of \"EventDataEventsLost\"")]
        [NativeName("Name", "XR_TYPE_EVENT_DATA_EVENTS_LOST")]
        TypeEventDataEventsLost = 49,
        [Obsolete("Deprecated in favour of \"InteractionProfileSuggestedBinding\"")]
        [NativeName("Name", "XR_TYPE_INTERACTION_PROFILE_SUGGESTED_BINDING")]
        TypeInteractionProfileSuggestedBinding = 51,
        [Obsolete("Deprecated in favour of \"EventDataInteractionProfileChanged\"")]
        [NativeName("Name", "XR_TYPE_EVENT_DATA_INTERACTION_PROFILE_CHANGED")]
        TypeEventDataInteractionProfileChanged = 52,
        [Obsolete("Deprecated in favour of \"InteractionProfileState\"")]
        [NativeName("Name", "XR_TYPE_INTERACTION_PROFILE_STATE")]
        TypeInteractionProfileState = 53,
        [Obsolete("Deprecated in favour of \"SwapchainImageAcquireInfo\"")]
        [NativeName("Name", "XR_TYPE_SWAPCHAIN_IMAGE_ACQUIRE_INFO")]
        TypeSwapchainImageAcquireInfo = 55,
        [Obsolete("Deprecated in favour of \"SwapchainImageWaitInfo\"")]
        [NativeName("Name", "XR_TYPE_SWAPCHAIN_IMAGE_WAIT_INFO")]
        TypeSwapchainImageWaitInfo = 56,
        [Obsolete("Deprecated in favour of \"SwapchainImageReleaseInfo\"")]
        [NativeName("Name", "XR_TYPE_SWAPCHAIN_IMAGE_RELEASE_INFO")]
        TypeSwapchainImageReleaseInfo = 57,
        [Obsolete("Deprecated in favour of \"ActionStateGetInfo\"")]
        [NativeName("Name", "XR_TYPE_ACTION_STATE_GET_INFO")]
        TypeActionStateGetInfo = 58,
        [Obsolete("Deprecated in favour of \"HapticActionInfo\"")]
        [NativeName("Name", "XR_TYPE_HAPTIC_ACTION_INFO")]
        TypeHapticActionInfo = 59,
        [Obsolete("Deprecated in favour of \"SessionActionSetsAttachInfo\"")]
        [NativeName("Name", "XR_TYPE_SESSION_ACTION_SETS_ATTACH_INFO")]
        TypeSessionActionSetsAttachInfo = 60,
        [Obsolete("Deprecated in favour of \"ActionsSyncInfo\"")]
        [NativeName("Name", "XR_TYPE_ACTIONS_SYNC_INFO")]
        TypeActionsSyncInfo = 61,
        [Obsolete("Deprecated in favour of \"BoundSourcesForActionEnumerateInfo\"")]
        [NativeName("Name", "XR_TYPE_BOUND_SOURCES_FOR_ACTION_ENUMERATE_INFO")]
        TypeBoundSourcesForActionEnumerateInfo = 62,
        [Obsolete("Deprecated in favour of \"InputSourceLocalizedNameGetInfo\"")]
        [NativeName("Name", "XR_TYPE_INPUT_SOURCE_LOCALIZED_NAME_GET_INFO")]
        TypeInputSourceLocalizedNameGetInfo = 63,
        [Obsolete("Deprecated in favour of \"CompositionLayerCubeKhr\"")]
        [NativeName("Name", "XR_TYPE_COMPOSITION_LAYER_CUBE_KHR")]
        TypeCompositionLayerCubeKhr = 1000006000,
        [Obsolete("Deprecated in favour of \"InstanceCreateInfoAndroidKhr\"")]
        [NativeName("Name", "XR_TYPE_INSTANCE_CREATE_INFO_ANDROID_KHR")]
        TypeInstanceCreateInfoAndroidKhr = 1000008000,
        [Obsolete("Deprecated in favour of \"CompositionLayerDepthInfoKhr\"")]
        [NativeName("Name", "XR_TYPE_COMPOSITION_LAYER_DEPTH_INFO_KHR")]
        TypeCompositionLayerDepthInfoKhr = 1000010000,
        [Obsolete("Deprecated in favour of \"VulkanSwapchainFormatListCreateInfoKhr\"")]
        [NativeName("Name", "XR_TYPE_VULKAN_SWAPCHAIN_FORMAT_LIST_CREATE_INFO_KHR")]
        TypeVulkanSwapchainFormatListCreateInfoKhr = 1000014000,
        [Obsolete("Deprecated in favour of \"EventDataPerfSettingsExt\"")]
        [NativeName("Name", "XR_TYPE_EVENT_DATA_PERF_SETTINGS_EXT")]
        TypeEventDataPerfSettingsExt = 1000015000,
        [Obsolete("Deprecated in favour of \"CompositionLayerCylinderKhr\"")]
        [NativeName("Name", "XR_TYPE_COMPOSITION_LAYER_CYLINDER_KHR")]
        TypeCompositionLayerCylinderKhr = 1000017000,
        [Obsolete("Deprecated in favour of \"CompositionLayerEquirectKhr\"")]
        [NativeName("Name", "XR_TYPE_COMPOSITION_LAYER_EQUIRECT_KHR")]
        TypeCompositionLayerEquirectKhr = 1000018000,
        [Obsolete("Deprecated in favour of \"DebugUtilsObjectNameInfoExt\"")]
        [NativeName("Name", "XR_TYPE_DEBUG_UTILS_OBJECT_NAME_INFO_EXT")]
        TypeDebugUtilsObjectNameInfoExt = 1000019000,
        [Obsolete("Deprecated in favour of \"DebugUtilsMessengerCallbackDataExt\"")]
        [NativeName("Name", "XR_TYPE_DEBUG_UTILS_MESSENGER_CALLBACK_DATA_EXT")]
        TypeDebugUtilsMessengerCallbackDataExt = 1000019001,
        [Obsolete("Deprecated in favour of \"DebugUtilsMessengerCreateInfoExt\"")]
        [NativeName("Name", "XR_TYPE_DEBUG_UTILS_MESSENGER_CREATE_INFO_EXT")]
        TypeDebugUtilsMessengerCreateInfoExt = 1000019002,
        [Obsolete("Deprecated in favour of \"DebugUtilsLabelExt\"")]
        [NativeName("Name", "XR_TYPE_DEBUG_UTILS_LABEL_EXT")]
        TypeDebugUtilsLabelExt = 1000019003,
        [Obsolete("Deprecated in favour of \"GraphicsBindingOpenglWin32Khr\"")]
        [NativeName("Name", "XR_TYPE_GRAPHICS_BINDING_OPENGL_WIN32_KHR")]
        TypeGraphicsBindingOpenglWin32Khr = 1000023000,
        [Obsolete("Deprecated in favour of \"GraphicsBindingOpenglXlibKhr\"")]
        [NativeName("Name", "XR_TYPE_GRAPHICS_BINDING_OPENGL_XLIB_KHR")]
        TypeGraphicsBindingOpenglXlibKhr = 1000023001,
        [Obsolete("Deprecated in favour of \"GraphicsBindingOpenglXcbKhr\"")]
        [NativeName("Name", "XR_TYPE_GRAPHICS_BINDING_OPENGL_XCB_KHR")]
        TypeGraphicsBindingOpenglXcbKhr = 1000023002,
        [Obsolete("Deprecated in favour of \"GraphicsBindingOpenglWaylandKhr\"")]
        [NativeName("Name", "XR_TYPE_GRAPHICS_BINDING_OPENGL_WAYLAND_KHR")]
        TypeGraphicsBindingOpenglWaylandKhr = 1000023003,
        [Obsolete("Deprecated in favour of \"SwapchainImageOpenglKhr\"")]
        [NativeName("Name", "XR_TYPE_SWAPCHAIN_IMAGE_OPENGL_KHR")]
        TypeSwapchainImageOpenglKhr = 1000023004,
        [Obsolete("Deprecated in favour of \"GraphicsRequirementsOpenglKhr\"")]
        [NativeName("Name", "XR_TYPE_GRAPHICS_REQUIREMENTS_OPENGL_KHR")]
        TypeGraphicsRequirementsOpenglKhr = 1000023005,
        [Obsolete("Deprecated in favour of \"GraphicsBindingOpenglESAndroidKhr\"")]
        [NativeName("Name", "XR_TYPE_GRAPHICS_BINDING_OPENGL_ES_ANDROID_KHR")]
        TypeGraphicsBindingOpenglESAndroidKhr = 1000024001,
        [Obsolete("Deprecated in favour of \"SwapchainImageOpenglESKhr\"")]
        [NativeName("Name", "XR_TYPE_SWAPCHAIN_IMAGE_OPENGL_ES_KHR")]
        TypeSwapchainImageOpenglESKhr = 1000024002,
        [Obsolete("Deprecated in favour of \"GraphicsRequirementsOpenglESKhr\"")]
        [NativeName("Name", "XR_TYPE_GRAPHICS_REQUIREMENTS_OPENGL_ES_KHR")]
        TypeGraphicsRequirementsOpenglESKhr = 1000024003,
        [Obsolete("Deprecated in favour of \"GraphicsBindingVulkanKhr\"")]
        [NativeName("Name", "XR_TYPE_GRAPHICS_BINDING_VULKAN_KHR")]
        TypeGraphicsBindingVulkanKhr = 1000025000,
        [Obsolete("Deprecated in favour of \"SwapchainImageVulkanKhr\"")]
        [NativeName("Name", "XR_TYPE_SWAPCHAIN_IMAGE_VULKAN_KHR")]
        TypeSwapchainImageVulkanKhr = 1000025001,
        [Obsolete("Deprecated in favour of \"GraphicsRequirementsVulkanKhr\"")]
        [NativeName("Name", "XR_TYPE_GRAPHICS_REQUIREMENTS_VULKAN_KHR")]
        TypeGraphicsRequirementsVulkanKhr = 1000025002,
        [Obsolete("Deprecated in favour of \"GraphicsBindingD3D11Khr\"")]
        [NativeName("Name", "XR_TYPE_GRAPHICS_BINDING_D3D11_KHR")]
        TypeGraphicsBindingD3D11Khr = 1000027000,
        [Obsolete("Deprecated in favour of \"SwapchainImageD3D11Khr\"")]
        [NativeName("Name", "XR_TYPE_SWAPCHAIN_IMAGE_D3D11_KHR")]
        TypeSwapchainImageD3D11Khr = 1000027001,
        [Obsolete("Deprecated in favour of \"GraphicsRequirementsD3D11Khr\"")]
        [NativeName("Name", "XR_TYPE_GRAPHICS_REQUIREMENTS_D3D11_KHR")]
        TypeGraphicsRequirementsD3D11Khr = 1000027002,
        [Obsolete("Deprecated in favour of \"GraphicsBindingD3D12Khr\"")]
        [NativeName("Name", "XR_TYPE_GRAPHICS_BINDING_D3D12_KHR")]
        TypeGraphicsBindingD3D12Khr = 1000028000,
        [Obsolete("Deprecated in favour of \"SwapchainImageD3D12Khr\"")]
        [NativeName("Name", "XR_TYPE_SWAPCHAIN_IMAGE_D3D12_KHR")]
        TypeSwapchainImageD3D12Khr = 1000028001,
        [Obsolete("Deprecated in favour of \"GraphicsRequirementsD3D12Khr\"")]
        [NativeName("Name", "XR_TYPE_GRAPHICS_REQUIREMENTS_D3D12_KHR")]
        TypeGraphicsRequirementsD3D12Khr = 1000028002,
        [Obsolete("Deprecated in favour of \"GraphicsBindingMetalKhr\"")]
        [NativeName("Name", "XR_TYPE_GRAPHICS_BINDING_METAL_KHR")]
        TypeGraphicsBindingMetalKhr = 1000029000,
        [Obsolete("Deprecated in favour of \"SwapchainImageMetalKhr\"")]
        [NativeName("Name", "XR_TYPE_SWAPCHAIN_IMAGE_METAL_KHR")]
        TypeSwapchainImageMetalKhr = 1000029001,
        [Obsolete("Deprecated in favour of \"GraphicsRequirementsMetalKhr\"")]
        [NativeName("Name", "XR_TYPE_GRAPHICS_REQUIREMENTS_METAL_KHR")]
        TypeGraphicsRequirementsMetalKhr = 1000029002,
        [Obsolete("Deprecated in favour of \"SystemEyeGazeInteractionPropertiesExt\"")]
        [NativeName("Name", "XR_TYPE_SYSTEM_EYE_GAZE_INTERACTION_PROPERTIES_EXT")]
        TypeSystemEyeGazeInteractionPropertiesExt = 1000030000,
        [Obsolete("Deprecated in favour of \"EyeGazeSampleTimeExt\"")]
        [NativeName("Name", "XR_TYPE_EYE_GAZE_SAMPLE_TIME_EXT")]
        TypeEyeGazeSampleTimeExt = 1000030001,
        [Obsolete("Deprecated in favour of \"VisibilityMaskKhr\"")]
        [NativeName("Name", "XR_TYPE_VISIBILITY_MASK_KHR")]
        TypeVisibilityMaskKhr = 1000031000,
        [Obsolete("Deprecated in favour of \"EventDataVisibilityMaskChangedKhr\"")]
        [NativeName("Name", "XR_TYPE_EVENT_DATA_VISIBILITY_MASK_CHANGED_KHR")]
        TypeEventDataVisibilityMaskChangedKhr = 1000031001,
        [Obsolete("Deprecated in favour of \"SessionCreateInfoOverlayExtx\"")]
        [NativeName("Name", "XR_TYPE_SESSION_CREATE_INFO_OVERLAY_EXTX")]
        TypeSessionCreateInfoOverlayExtx = 1000033000,
        [Obsolete("Deprecated in favour of \"EventDataMainSessionVisibilityChangedExtx\"")]
        [NativeName("Name", "XR_TYPE_EVENT_DATA_MAIN_SESSION_VISIBILITY_CHANGED_EXTX")]
        TypeEventDataMainSessionVisibilityChangedExtx = 1000033003,
        [Obsolete("Deprecated in favour of \"CompositionLayerColorScaleBiasKhr\"")]
        [NativeName("Name", "XR_TYPE_COMPOSITION_LAYER_COLOR_SCALE_BIAS_KHR")]
        TypeCompositionLayerColorScaleBiasKhr = 1000034000,
        [Obsolete("Deprecated in favour of \"SpatialAnchorCreateInfoMsft\"")]
        [NativeName("Name", "XR_TYPE_SPATIAL_ANCHOR_CREATE_INFO_MSFT")]
        TypeSpatialAnchorCreateInfoMsft = 1000039000,
        [Obsolete("Deprecated in favour of \"SpatialAnchorSpaceCreateInfoMsft\"")]
        [NativeName("Name", "XR_TYPE_SPATIAL_ANCHOR_SPACE_CREATE_INFO_MSFT")]
        TypeSpatialAnchorSpaceCreateInfoMsft = 1000039001,
        [Obsolete("Deprecated in favour of \"CompositionLayerImageLayoutFB\"")]
        [NativeName("Name", "XR_TYPE_COMPOSITION_LAYER_IMAGE_LAYOUT_FB")]
        TypeCompositionLayerImageLayoutFB = 1000040000,
        [Obsolete("Deprecated in favour of \"CompositionLayerAlphaBlendFB\"")]
        [NativeName("Name", "XR_TYPE_COMPOSITION_LAYER_ALPHA_BLEND_FB")]
        TypeCompositionLayerAlphaBlendFB = 1000041001,
        [Obsolete("Deprecated in favour of \"ViewConfigurationDepthRangeExt\"")]
        [NativeName("Name", "XR_TYPE_VIEW_CONFIGURATION_DEPTH_RANGE_EXT")]
        TypeViewConfigurationDepthRangeExt = 1000046000,
        [Obsolete("Deprecated in favour of \"GraphicsBindingEglMndx\"")]
        [NativeName("Name", "XR_TYPE_GRAPHICS_BINDING_EGL_MNDX")]
        TypeGraphicsBindingEglMndx = 1000048004,
        [Obsolete("Deprecated in favour of \"SpatialGraphNodeSpaceCreateInfoMsft\"")]
        [NativeName("Name", "XR_TYPE_SPATIAL_GRAPH_NODE_SPACE_CREATE_INFO_MSFT")]
        TypeSpatialGraphNodeSpaceCreateInfoMsft = 1000049000,
        [Obsolete("Deprecated in favour of \"SpatialGraphStaticNodeBindingCreateInfoMsft\"")]
        [NativeName("Name", "XR_TYPE_SPATIAL_GRAPH_STATIC_NODE_BINDING_CREATE_INFO_MSFT")]
        TypeSpatialGraphStaticNodeBindingCreateInfoMsft = 1000049001,
        [Obsolete("Deprecated in favour of \"SpatialGraphNodeBindingPropertiesGetInfoMsft\"")]
        [NativeName("Name", "XR_TYPE_SPATIAL_GRAPH_NODE_BINDING_PROPERTIES_GET_INFO_MSFT")]
        TypeSpatialGraphNodeBindingPropertiesGetInfoMsft = 1000049002,
        [Obsolete("Deprecated in favour of \"SpatialGraphNodeBindingPropertiesMsft\"")]
        [NativeName("Name", "XR_TYPE_SPATIAL_GRAPH_NODE_BINDING_PROPERTIES_MSFT")]
        TypeSpatialGraphNodeBindingPropertiesMsft = 1000049003,
        [Obsolete("Deprecated in favour of \"SystemHandTrackingPropertiesExt\"")]
        [NativeName("Name", "XR_TYPE_SYSTEM_HAND_TRACKING_PROPERTIES_EXT")]
        TypeSystemHandTrackingPropertiesExt = 1000051000,
        [Obsolete("Deprecated in favour of \"HandTrackerCreateInfoExt\"")]
        [NativeName("Name", "XR_TYPE_HAND_TRACKER_CREATE_INFO_EXT")]
        TypeHandTrackerCreateInfoExt = 1000051001,
        [Obsolete("Deprecated in favour of \"HandJointsLocateInfoExt\"")]
        [NativeName("Name", "XR_TYPE_HAND_JOINTS_LOCATE_INFO_EXT")]
        TypeHandJointsLocateInfoExt = 1000051002,
        [Obsolete("Deprecated in favour of \"HandJointLocationsExt\"")]
        [NativeName("Name", "XR_TYPE_HAND_JOINT_LOCATIONS_EXT")]
        TypeHandJointLocationsExt = 1000051003,
        [Obsolete("Deprecated in favour of \"HandJointVelocitiesExt\"")]
        [NativeName("Name", "XR_TYPE_HAND_JOINT_VELOCITIES_EXT")]
        TypeHandJointVelocitiesExt = 1000051004,
        [Obsolete("Deprecated in favour of \"SystemHandTrackingMeshPropertiesMsft\"")]
        [NativeName("Name", "XR_TYPE_SYSTEM_HAND_TRACKING_MESH_PROPERTIES_MSFT")]
        TypeSystemHandTrackingMeshPropertiesMsft = 1000052000,
        [Obsolete("Deprecated in favour of \"HandMeshSpaceCreateInfoMsft\"")]
        [NativeName("Name", "XR_TYPE_HAND_MESH_SPACE_CREATE_INFO_MSFT")]
        TypeHandMeshSpaceCreateInfoMsft = 1000052001,
        [Obsolete("Deprecated in favour of \"HandMeshUpdateInfoMsft\"")]
        [NativeName("Name", "XR_TYPE_HAND_MESH_UPDATE_INFO_MSFT")]
        TypeHandMeshUpdateInfoMsft = 1000052002,
        [Obsolete("Deprecated in favour of \"HandMeshMsft\"")]
        [NativeName("Name", "XR_TYPE_HAND_MESH_MSFT")]
        TypeHandMeshMsft = 1000052003,
        [Obsolete("Deprecated in favour of \"HandPoseTypeInfoMsft\"")]
        [NativeName("Name", "XR_TYPE_HAND_POSE_TYPE_INFO_MSFT")]
        TypeHandPoseTypeInfoMsft = 1000052004,
        [Obsolete("Deprecated in favour of \"SecondaryViewConfigurationSessionBeginInfoMsft\"")]
        [NativeName("Name", "XR_TYPE_SECONDARY_VIEW_CONFIGURATION_SESSION_BEGIN_INFO_MSFT")]
        TypeSecondaryViewConfigurationSessionBeginInfoMsft = 1000053000,
        [Obsolete("Deprecated in favour of \"SecondaryViewConfigurationStateMsft\"")]
        [NativeName("Name", "XR_TYPE_SECONDARY_VIEW_CONFIGURATION_STATE_MSFT")]
        TypeSecondaryViewConfigurationStateMsft = 1000053001,
        [Obsolete("Deprecated in favour of \"SecondaryViewConfigurationFrameStateMsft\"")]
        [NativeName("Name", "XR_TYPE_SECONDARY_VIEW_CONFIGURATION_FRAME_STATE_MSFT")]
        TypeSecondaryViewConfigurationFrameStateMsft = 1000053002,
        [Obsolete("Deprecated in favour of \"SecondaryViewConfigurationFrameEndInfoMsft\"")]
        [NativeName("Name", "XR_TYPE_SECONDARY_VIEW_CONFIGURATION_FRAME_END_INFO_MSFT")]
        TypeSecondaryViewConfigurationFrameEndInfoMsft = 1000053003,
        [Obsolete("Deprecated in favour of \"SecondaryViewConfigurationLayerInfoMsft\"")]
        [NativeName("Name", "XR_TYPE_SECONDARY_VIEW_CONFIGURATION_LAYER_INFO_MSFT")]
        TypeSecondaryViewConfigurationLayerInfoMsft = 1000053004,
        [Obsolete("Deprecated in favour of \"SecondaryViewConfigurationSwapchainCreateInfoMsft\"")]
        [NativeName("Name", "XR_TYPE_SECONDARY_VIEW_CONFIGURATION_SWAPCHAIN_CREATE_INFO_MSFT")]
        TypeSecondaryViewConfigurationSwapchainCreateInfoMsft = 1000053005,
        [Obsolete("Deprecated in favour of \"ControllerModelKeyStateMsft\"")]
        [NativeName("Name", "XR_TYPE_CONTROLLER_MODEL_KEY_STATE_MSFT")]
        TypeControllerModelKeyStateMsft = 1000055000,
        [Obsolete("Deprecated in favour of \"ControllerModelNodePropertiesMsft\"")]
        [NativeName("Name", "XR_TYPE_CONTROLLER_MODEL_NODE_PROPERTIES_MSFT")]
        TypeControllerModelNodePropertiesMsft = 1000055001,
        [Obsolete("Deprecated in favour of \"ControllerModelPropertiesMsft\"")]
        [NativeName("Name", "XR_TYPE_CONTROLLER_MODEL_PROPERTIES_MSFT")]
        TypeControllerModelPropertiesMsft = 1000055002,
        [Obsolete("Deprecated in favour of \"ControllerModelNodeStateMsft\"")]
        [NativeName("Name", "XR_TYPE_CONTROLLER_MODEL_NODE_STATE_MSFT")]
        TypeControllerModelNodeStateMsft = 1000055003,
        [Obsolete("Deprecated in favour of \"ControllerModelStateMsft\"")]
        [NativeName("Name", "XR_TYPE_CONTROLLER_MODEL_STATE_MSFT")]
        TypeControllerModelStateMsft = 1000055004,
        [Obsolete("Deprecated in favour of \"ViewConfigurationViewFovEpic\"")]
        [NativeName("Name", "XR_TYPE_VIEW_CONFIGURATION_VIEW_FOV_EPIC")]
        TypeViewConfigurationViewFovEpic = 1000059000,
        [Obsolete("Deprecated in favour of \"HolographicWindowAttachmentMsft\"")]
        [NativeName("Name", "XR_TYPE_HOLOGRAPHIC_WINDOW_ATTACHMENT_MSFT")]
        TypeHolographicWindowAttachmentMsft = 1000063000,
        [Obsolete("Deprecated in favour of \"CompositionLayerReprojectionInfoMsft\"")]
        [NativeName("Name", "XR_TYPE_COMPOSITION_LAYER_REPROJECTION_INFO_MSFT")]
        TypeCompositionLayerReprojectionInfoMsft = 1000066000,
        [Obsolete("Deprecated in favour of \"CompositionLayerReprojectionPlaneOverrideMsft\"")]
        [NativeName("Name", "XR_TYPE_COMPOSITION_LAYER_REPROJECTION_PLANE_OVERRIDE_MSFT")]
        TypeCompositionLayerReprojectionPlaneOverrideMsft = 1000066001,
        [Obsolete("Deprecated in favour of \"AndroidSurfaceSwapchainCreateInfoFB\"")]
        [NativeName("Name", "XR_TYPE_ANDROID_SURFACE_SWAPCHAIN_CREATE_INFO_FB")]
        TypeAndroidSurfaceSwapchainCreateInfoFB = 1000070000,
        [Obsolete("Deprecated in favour of \"CompositionLayerSecureContentFB\"")]
        [NativeName("Name", "XR_TYPE_COMPOSITION_LAYER_SECURE_CONTENT_FB")]
        TypeCompositionLayerSecureContentFB = 1000072000,
        [Obsolete("Deprecated in favour of \"BodyTrackerCreateInfoFB\"")]
        [NativeName("Name", "XR_TYPE_BODY_TRACKER_CREATE_INFO_FB")]
        TypeBodyTrackerCreateInfoFB = 1000076001,
        [Obsolete("Deprecated in favour of \"BodyJointsLocateInfoFB\"")]
        [NativeName("Name", "XR_TYPE_BODY_JOINTS_LOCATE_INFO_FB")]
        TypeBodyJointsLocateInfoFB = 1000076002,
        [Obsolete("Deprecated in favour of \"SystemBodyTrackingPropertiesFB\"")]
        [NativeName("Name", "XR_TYPE_SYSTEM_BODY_TRACKING_PROPERTIES_FB")]
        TypeSystemBodyTrackingPropertiesFB = 1000076004,
        [Obsolete("Deprecated in favour of \"BodyJointLocationsFB\"")]
        [NativeName("Name", "XR_TYPE_BODY_JOINT_LOCATIONS_FB")]
        TypeBodyJointLocationsFB = 1000076005,
        [Obsolete("Deprecated in favour of \"BodySkeletonFB\"")]
        [NativeName("Name", "XR_TYPE_BODY_SKELETON_FB")]
        TypeBodySkeletonFB = 1000076006,
        [Obsolete("Deprecated in favour of \"InteractionProfileDpadBindingExt\"")]
        [NativeName("Name", "XR_TYPE_INTERACTION_PROFILE_DPAD_BINDING_EXT")]
        TypeInteractionProfileDpadBindingExt = 1000078000,
        [Obsolete("Deprecated in favour of \"InteractionProfileAnalogThresholdValve\"")]
        [NativeName("Name", "XR_TYPE_INTERACTION_PROFILE_ANALOG_THRESHOLD_VALVE")]
        TypeInteractionProfileAnalogThresholdValve = 1000079000,
        [Obsolete("Deprecated in favour of \"HandJointsMotionRangeInfoExt\"")]
        [NativeName("Name", "XR_TYPE_HAND_JOINTS_MOTION_RANGE_INFO_EXT")]
        TypeHandJointsMotionRangeInfoExt = 1000080000,
        [Obsolete("Deprecated in favour of \"LoaderInitInfoAndroidKhr\"")]
        [NativeName("Name", "XR_TYPE_LOADER_INIT_INFO_ANDROID_KHR")]
        TypeLoaderInitInfoAndroidKhr = 1000089000,
        [Obsolete("Deprecated in favour of \"VulkanInstanceCreateInfoKhr\"")]
        [NativeName("Name", "XR_TYPE_VULKAN_INSTANCE_CREATE_INFO_KHR")]
        TypeVulkanInstanceCreateInfoKhr = 1000090000,
        [Obsolete("Deprecated in favour of \"VulkanDeviceCreateInfoKhr\"")]
        [NativeName("Name", "XR_TYPE_VULKAN_DEVICE_CREATE_INFO_KHR")]
        TypeVulkanDeviceCreateInfoKhr = 1000090001,
        [Obsolete("Deprecated in favour of \"VulkanGraphicsDeviceGetInfoKhr\"")]
        [NativeName("Name", "XR_TYPE_VULKAN_GRAPHICS_DEVICE_GET_INFO_KHR")]
        TypeVulkanGraphicsDeviceGetInfoKhr = 1000090003,
        [Obsolete("Deprecated in favour of \"GraphicsBindingVulkan2Khr\"")]
        [NativeName("Name", "XR_TYPE_GRAPHICS_BINDING_VULKAN2_KHR")]
        TypeGraphicsBindingVulkan2Khr = 1000090000,
        [Obsolete("Deprecated in favour of \"SwapchainImageVulkan2Khr\"")]
        [NativeName("Name", "XR_TYPE_SWAPCHAIN_IMAGE_VULKAN2_KHR")]
        TypeSwapchainImageVulkan2Khr = 1000090001,
        [Obsolete("Deprecated in favour of \"GraphicsRequirementsVulkan2Khr\"")]
        [NativeName("Name", "XR_TYPE_GRAPHICS_REQUIREMENTS_VULKAN2_KHR")]
        TypeGraphicsRequirementsVulkan2Khr = 1000090002,
        [Obsolete("Deprecated in favour of \"CompositionLayerEquirect2Khr\"")]
        [NativeName("Name", "XR_TYPE_COMPOSITION_LAYER_EQUIRECT2_KHR")]
        TypeCompositionLayerEquirect2Khr = 1000091000,
        [Obsolete("Deprecated in favour of \"SceneObserverCreateInfoMsft\"")]
        [NativeName("Name", "XR_TYPE_SCENE_OBSERVER_CREATE_INFO_MSFT")]
        TypeSceneObserverCreateInfoMsft = 1000097000,
        [Obsolete("Deprecated in favour of \"SceneCreateInfoMsft\"")]
        [NativeName("Name", "XR_TYPE_SCENE_CREATE_INFO_MSFT")]
        TypeSceneCreateInfoMsft = 1000097001,
        [Obsolete("Deprecated in favour of \"NewSceneComputeInfoMsft\"")]
        [NativeName("Name", "XR_TYPE_NEW_SCENE_COMPUTE_INFO_MSFT")]
        TypeNewSceneComputeInfoMsft = 1000097002,
        [Obsolete("Deprecated in favour of \"VisualMeshComputeLodInfoMsft\"")]
        [NativeName("Name", "XR_TYPE_VISUAL_MESH_COMPUTE_LOD_INFO_MSFT")]
        TypeVisualMeshComputeLodInfoMsft = 1000097003,
        [Obsolete("Deprecated in favour of \"SceneComponentsMsft\"")]
        [NativeName("Name", "XR_TYPE_SCENE_COMPONENTS_MSFT")]
        TypeSceneComponentsMsft = 1000097004,
        [Obsolete("Deprecated in favour of \"SceneComponentsGetInfoMsft\"")]
        [NativeName("Name", "XR_TYPE_SCENE_COMPONENTS_GET_INFO_MSFT")]
        TypeSceneComponentsGetInfoMsft = 1000097005,
        [Obsolete("Deprecated in favour of \"SceneComponentLocationsMsft\"")]
        [NativeName("Name", "XR_TYPE_SCENE_COMPONENT_LOCATIONS_MSFT")]
        TypeSceneComponentLocationsMsft = 1000097006,
        [Obsolete("Deprecated in favour of \"SceneComponentsLocateInfoMsft\"")]
        [NativeName("Name", "XR_TYPE_SCENE_COMPONENTS_LOCATE_INFO_MSFT")]
        TypeSceneComponentsLocateInfoMsft = 1000097007,
        [Obsolete("Deprecated in favour of \"SceneObjectsMsft\"")]
        [NativeName("Name", "XR_TYPE_SCENE_OBJECTS_MSFT")]
        TypeSceneObjectsMsft = 1000097008,
        [Obsolete("Deprecated in favour of \"SceneComponentParentFilterInfoMsft\"")]
        [NativeName("Name", "XR_TYPE_SCENE_COMPONENT_PARENT_FILTER_INFO_MSFT")]
        TypeSceneComponentParentFilterInfoMsft = 1000097009,
        [Obsolete("Deprecated in favour of \"SceneObjectTypesFilterInfoMsft\"")]
        [NativeName("Name", "XR_TYPE_SCENE_OBJECT_TYPES_FILTER_INFO_MSFT")]
        TypeSceneObjectTypesFilterInfoMsft = 1000097010,
        [Obsolete("Deprecated in favour of \"ScenePlanesMsft\"")]
        [NativeName("Name", "XR_TYPE_SCENE_PLANES_MSFT")]
        TypeScenePlanesMsft = 1000097011,
        [Obsolete("Deprecated in favour of \"ScenePlaneAlignmentFilterInfoMsft\"")]
        [NativeName("Name", "XR_TYPE_SCENE_PLANE_ALIGNMENT_FILTER_INFO_MSFT")]
        TypeScenePlaneAlignmentFilterInfoMsft = 1000097012,
        [Obsolete("Deprecated in favour of \"SceneMeshesMsft\"")]
        [NativeName("Name", "XR_TYPE_SCENE_MESHES_MSFT")]
        TypeSceneMeshesMsft = 1000097013,
        [Obsolete("Deprecated in favour of \"SceneMeshBuffersGetInfoMsft\"")]
        [NativeName("Name", "XR_TYPE_SCENE_MESH_BUFFERS_GET_INFO_MSFT")]
        TypeSceneMeshBuffersGetInfoMsft = 1000097014,
        [Obsolete("Deprecated in favour of \"SceneMeshBuffersMsft\"")]
        [NativeName("Name", "XR_TYPE_SCENE_MESH_BUFFERS_MSFT")]
        TypeSceneMeshBuffersMsft = 1000097015,
        [Obsolete("Deprecated in favour of \"SceneMeshVertexBufferMsft\"")]
        [NativeName("Name", "XR_TYPE_SCENE_MESH_VERTEX_BUFFER_MSFT")]
        TypeSceneMeshVertexBufferMsft = 1000097016,
        [Obsolete("Deprecated in favour of \"SceneMeshIndicesUint32Msft\"")]
        [NativeName("Name", "XR_TYPE_SCENE_MESH_INDICES_UINT32_MSFT")]
        TypeSceneMeshIndicesUint32Msft = 1000097017,
        [Obsolete("Deprecated in favour of \"SceneMeshIndicesUint16Msft\"")]
        [NativeName("Name", "XR_TYPE_SCENE_MESH_INDICES_UINT16_MSFT")]
        TypeSceneMeshIndicesUint16Msft = 1000097018,
        [Obsolete("Deprecated in favour of \"SerializedSceneFragmentDataGetInfoMsft\"")]
        [NativeName("Name", "XR_TYPE_SERIALIZED_SCENE_FRAGMENT_DATA_GET_INFO_MSFT")]
        TypeSerializedSceneFragmentDataGetInfoMsft = 1000098000,
        [Obsolete("Deprecated in favour of \"SceneDeserializeInfoMsft\"")]
        [NativeName("Name", "XR_TYPE_SCENE_DESERIALIZE_INFO_MSFT")]
        TypeSceneDeserializeInfoMsft = 1000098001,
        [Obsolete("Deprecated in favour of \"EventDataDisplayRefreshRateChangedFB\"")]
        [NativeName("Name", "XR_TYPE_EVENT_DATA_DISPLAY_REFRESH_RATE_CHANGED_FB")]
        TypeEventDataDisplayRefreshRateChangedFB = 1000101000,
        [Obsolete("Deprecated in favour of \"ViveTrackerPathsHtcx\"")]
        [NativeName("Name", "XR_TYPE_VIVE_TRACKER_PATHS_HTCX")]
        TypeViveTrackerPathsHtcx = 1000103000,
        [Obsolete("Deprecated in favour of \"EventDataViveTrackerConnectedHtcx\"")]
        [NativeName("Name", "XR_TYPE_EVENT_DATA_VIVE_TRACKER_CONNECTED_HTCX")]
        TypeEventDataViveTrackerConnectedHtcx = 1000103001,
        [Obsolete("Deprecated in favour of \"SystemFacialTrackingPropertiesHtc\"")]
        [NativeName("Name", "XR_TYPE_SYSTEM_FACIAL_TRACKING_PROPERTIES_HTC")]
        TypeSystemFacialTrackingPropertiesHtc = 1000104000,
        [Obsolete("Deprecated in favour of \"FacialTrackerCreateInfoHtc\"")]
        [NativeName("Name", "XR_TYPE_FACIAL_TRACKER_CREATE_INFO_HTC")]
        TypeFacialTrackerCreateInfoHtc = 1000104001,
        [Obsolete("Deprecated in favour of \"FacialExpressionsHtc\"")]
        [NativeName("Name", "XR_TYPE_FACIAL_EXPRESSIONS_HTC")]
        TypeFacialExpressionsHtc = 1000104002,
        [Obsolete("Deprecated in favour of \"SystemColorSpacePropertiesFB\"")]
        [NativeName("Name", "XR_TYPE_SYSTEM_COLOR_SPACE_PROPERTIES_FB")]
        TypeSystemColorSpacePropertiesFB = 1000108000,
        [Obsolete("Deprecated in favour of \"HandTrackingMeshFB\"")]
        [NativeName("Name", "XR_TYPE_HAND_TRACKING_MESH_FB")]
        TypeHandTrackingMeshFB = 1000110001,
        [Obsolete("Deprecated in favour of \"HandTrackingScaleFB\"")]
        [NativeName("Name", "XR_TYPE_HAND_TRACKING_SCALE_FB")]
        TypeHandTrackingScaleFB = 1000110003,
        [Obsolete("Deprecated in favour of \"HandTrackingAimStateFB\"")]
        [NativeName("Name", "XR_TYPE_HAND_TRACKING_AIM_STATE_FB")]
        TypeHandTrackingAimStateFB = 1000111001,
        [Obsolete("Deprecated in favour of \"HandTrackingCapsulesStateFB\"")]
        [NativeName("Name", "XR_TYPE_HAND_TRACKING_CAPSULES_STATE_FB")]
        TypeHandTrackingCapsulesStateFB = 1000112000,
        [Obsolete("Deprecated in favour of \"SystemSpatialEntityPropertiesFB\"")]
        [NativeName("Name", "XR_TYPE_SYSTEM_SPATIAL_ENTITY_PROPERTIES_FB")]
        TypeSystemSpatialEntityPropertiesFB = 1000113004,
        [Obsolete("Deprecated in favour of \"SpatialAnchorCreateInfoFB\"")]
        [NativeName("Name", "XR_TYPE_SPATIAL_ANCHOR_CREATE_INFO_FB")]
        TypeSpatialAnchorCreateInfoFB = 1000113003,
        [Obsolete("Deprecated in favour of \"SpaceComponentStatusSetInfoFB\"")]
        [NativeName("Name", "XR_TYPE_SPACE_COMPONENT_STATUS_SET_INFO_FB")]
        TypeSpaceComponentStatusSetInfoFB = 1000113007,
        [Obsolete("Deprecated in favour of \"SpaceComponentStatusFB\"")]
        [NativeName("Name", "XR_TYPE_SPACE_COMPONENT_STATUS_FB")]
        TypeSpaceComponentStatusFB = 1000113001,
        [Obsolete("Deprecated in favour of \"EventDataSpatialAnchorCreateCompleteFB\"")]
        [NativeName("Name", "XR_TYPE_EVENT_DATA_SPATIAL_ANCHOR_CREATE_COMPLETE_FB")]
        TypeEventDataSpatialAnchorCreateCompleteFB = 1000113005,
        [Obsolete("Deprecated in favour of \"EventDataSpaceSetStatusCompleteFB\"")]
        [NativeName("Name", "XR_TYPE_EVENT_DATA_SPACE_SET_STATUS_COMPLETE_FB")]
        TypeEventDataSpaceSetStatusCompleteFB = 1000113006,
        [Obsolete("Deprecated in favour of \"FoveationProfileCreateInfoFB\"")]
        [NativeName("Name", "XR_TYPE_FOVEATION_PROFILE_CREATE_INFO_FB")]
        TypeFoveationProfileCreateInfoFB = 1000114000,
        [Obsolete("Deprecated in favour of \"SwapchainCreateInfoFoveationFB\"")]
        [NativeName("Name", "XR_TYPE_SWAPCHAIN_CREATE_INFO_FOVEATION_FB")]
        TypeSwapchainCreateInfoFoveationFB = 1000114001,
        [Obsolete("Deprecated in favour of \"SwapchainStateFoveationFB\"")]
        [NativeName("Name", "XR_TYPE_SWAPCHAIN_STATE_FOVEATION_FB")]
        TypeSwapchainStateFoveationFB = 1000114002,
        [Obsolete("Deprecated in favour of \"FoveationLevelProfileCreateInfoFB\"")]
        [NativeName("Name", "XR_TYPE_FOVEATION_LEVEL_PROFILE_CREATE_INFO_FB")]
        TypeFoveationLevelProfileCreateInfoFB = 1000115000,
        [Obsolete("Deprecated in favour of \"KeyboardSpaceCreateInfoFB\"")]
        [NativeName("Name", "XR_TYPE_KEYBOARD_SPACE_CREATE_INFO_FB")]
        TypeKeyboardSpaceCreateInfoFB = 1000116009,
        [Obsolete("Deprecated in favour of \"KeyboardTrackingQueryFB\"")]
        [NativeName("Name", "XR_TYPE_KEYBOARD_TRACKING_QUERY_FB")]
        TypeKeyboardTrackingQueryFB = 1000116004,
        [Obsolete("Deprecated in favour of \"SystemKeyboardTrackingPropertiesFB\"")]
        [NativeName("Name", "XR_TYPE_SYSTEM_KEYBOARD_TRACKING_PROPERTIES_FB")]
        TypeSystemKeyboardTrackingPropertiesFB = 1000116002,
        [Obsolete("Deprecated in favour of \"TriangleMeshCreateInfoFB\"")]
        [NativeName("Name", "XR_TYPE_TRIANGLE_MESH_CREATE_INFO_FB")]
        TypeTriangleMeshCreateInfoFB = 1000117001,
        [Obsolete("Deprecated in favour of \"SystemPassthroughPropertiesFB\"")]
        [NativeName("Name", "XR_TYPE_SYSTEM_PASSTHROUGH_PROPERTIES_FB")]
        TypeSystemPassthroughPropertiesFB = 1000118000,
        [Obsolete("Deprecated in favour of \"PassthroughCreateInfoFB\"")]
        [NativeName("Name", "XR_TYPE_PASSTHROUGH_CREATE_INFO_FB")]
        TypePassthroughCreateInfoFB = 1000118001,
        [Obsolete("Deprecated in favour of \"PassthroughLayerCreateInfoFB\"")]
        [NativeName("Name", "XR_TYPE_PASSTHROUGH_LAYER_CREATE_INFO_FB")]
        TypePassthroughLayerCreateInfoFB = 1000118002,
        [Obsolete("Deprecated in favour of \"CompositionLayerPassthroughFB\"")]
        [NativeName("Name", "XR_TYPE_COMPOSITION_LAYER_PASSTHROUGH_FB")]
        TypeCompositionLayerPassthroughFB = 1000118003,
        [Obsolete("Deprecated in favour of \"GeometryInstanceCreateInfoFB\"")]
        [NativeName("Name", "XR_TYPE_GEOMETRY_INSTANCE_CREATE_INFO_FB")]
        TypeGeometryInstanceCreateInfoFB = 1000118004,
        [Obsolete("Deprecated in favour of \"GeometryInstanceTransformFB\"")]
        [NativeName("Name", "XR_TYPE_GEOMETRY_INSTANCE_TRANSFORM_FB")]
        TypeGeometryInstanceTransformFB = 1000118005,
        [Obsolete("Deprecated in favour of \"SystemPassthroughProperties2FB\"")]
        [NativeName("Name", "XR_TYPE_SYSTEM_PASSTHROUGH_PROPERTIES2_FB")]
        TypeSystemPassthroughProperties2FB = 1000118006,
        [Obsolete("Deprecated in favour of \"PassthroughStyleFB\"")]
        [NativeName("Name", "XR_TYPE_PASSTHROUGH_STYLE_FB")]
        TypePassthroughStyleFB = 1000118020,
        [Obsolete("Deprecated in favour of \"PassthroughColorMapMonoToRgbaFB\"")]
        [NativeName("Name", "XR_TYPE_PASSTHROUGH_COLOR_MAP_MONO_TO_RGBA_FB")]
        TypePassthroughColorMapMonoToRgbaFB = 1000118021,
        [Obsolete("Deprecated in favour of \"PassthroughColorMapMonoToMonoFB\"")]
        [NativeName("Name", "XR_TYPE_PASSTHROUGH_COLOR_MAP_MONO_TO_MONO_FB")]
        TypePassthroughColorMapMonoToMonoFB = 1000118022,
        [Obsolete("Deprecated in favour of \"PassthroughBrightnessContrastSaturationFB\"")]
        [NativeName("Name", "XR_TYPE_PASSTHROUGH_BRIGHTNESS_CONTRAST_SATURATION_FB")]
        TypePassthroughBrightnessContrastSaturationFB = 1000118023,
        [Obsolete("Deprecated in favour of \"EventDataPassthroughStateChangedFB\"")]
        [NativeName("Name", "XR_TYPE_EVENT_DATA_PASSTHROUGH_STATE_CHANGED_FB")]
        TypeEventDataPassthroughStateChangedFB = 1000118030,
        [Obsolete("Deprecated in favour of \"RenderModelPathInfoFB\"")]
        [NativeName("Name", "XR_TYPE_RENDER_MODEL_PATH_INFO_FB")]
        TypeRenderModelPathInfoFB = 1000119000,
        [Obsolete("Deprecated in favour of \"RenderModelPropertiesFB\"")]
        [NativeName("Name", "XR_TYPE_RENDER_MODEL_PROPERTIES_FB")]
        TypeRenderModelPropertiesFB = 1000119001,
        [Obsolete("Deprecated in favour of \"RenderModelBufferFB\"")]
        [NativeName("Name", "XR_TYPE_RENDER_MODEL_BUFFER_FB")]
        TypeRenderModelBufferFB = 1000119002,
        [Obsolete("Deprecated in favour of \"RenderModelLoadInfoFB\"")]
        [NativeName("Name", "XR_TYPE_RENDER_MODEL_LOAD_INFO_FB")]
        TypeRenderModelLoadInfoFB = 1000119003,
        [Obsolete("Deprecated in favour of \"SystemRenderModelPropertiesFB\"")]
        [NativeName("Name", "XR_TYPE_SYSTEM_RENDER_MODEL_PROPERTIES_FB")]
        TypeSystemRenderModelPropertiesFB = 1000119004,
        [Obsolete("Deprecated in favour of \"RenderModelCapabilitiesRequestFB\"")]
        [NativeName("Name", "XR_TYPE_RENDER_MODEL_CAPABILITIES_REQUEST_FB")]
        TypeRenderModelCapabilitiesRequestFB = 1000119005,
        [Obsolete("Deprecated in favour of \"BindingModificationsKhr\"")]
        [NativeName("Name", "XR_TYPE_BINDING_MODIFICATIONS_KHR")]
        TypeBindingModificationsKhr = 1000120000,
        [Obsolete("Deprecated in favour of \"ViewLocateFoveatedRenderingVarjo\"")]
        [NativeName("Name", "XR_TYPE_VIEW_LOCATE_FOVEATED_RENDERING_VARJO")]
        TypeViewLocateFoveatedRenderingVarjo = 1000121000,
        [Obsolete("Deprecated in favour of \"FoveatedViewConfigurationViewVarjo\"")]
        [NativeName("Name", "XR_TYPE_FOVEATED_VIEW_CONFIGURATION_VIEW_VARJO")]
        TypeFoveatedViewConfigurationViewVarjo = 1000121001,
        [Obsolete("Deprecated in favour of \"SystemFoveatedRenderingPropertiesVarjo\"")]
        [NativeName("Name", "XR_TYPE_SYSTEM_FOVEATED_RENDERING_PROPERTIES_VARJO")]
        TypeSystemFoveatedRenderingPropertiesVarjo = 1000121002,
        [Obsolete("Deprecated in favour of \"CompositionLayerDepthTestVarjo\"")]
        [NativeName("Name", "XR_TYPE_COMPOSITION_LAYER_DEPTH_TEST_VARJO")]
        TypeCompositionLayerDepthTestVarjo = 1000122000,
        [Obsolete("Deprecated in favour of \"SystemMarkerTrackingPropertiesVarjo\"")]
        [NativeName("Name", "XR_TYPE_SYSTEM_MARKER_TRACKING_PROPERTIES_VARJO")]
        TypeSystemMarkerTrackingPropertiesVarjo = 1000124000,
        [Obsolete("Deprecated in favour of \"EventDataMarkerTrackingUpdateVarjo\"")]
        [NativeName("Name", "XR_TYPE_EVENT_DATA_MARKER_TRACKING_UPDATE_VARJO")]
        TypeEventDataMarkerTrackingUpdateVarjo = 1000124001,
        [Obsolete("Deprecated in favour of \"MarkerSpaceCreateInfoVarjo\"")]
        [NativeName("Name", "XR_TYPE_MARKER_SPACE_CREATE_INFO_VARJO")]
        TypeMarkerSpaceCreateInfoVarjo = 1000124002,
        [Obsolete("Deprecated in favour of \"FrameEndInfoML\"")]
        [NativeName("Name", "XR_TYPE_FRAME_END_INFO_ML")]
        TypeFrameEndInfoML = 1000135000,
        [Obsolete("Deprecated in favour of \"GlobalDimmerFrameEndInfoML\"")]
        [NativeName("Name", "XR_TYPE_GLOBAL_DIMMER_FRAME_END_INFO_ML")]
        TypeGlobalDimmerFrameEndInfoML = 1000136000,
        [Obsolete("Deprecated in favour of \"CoordinateSpaceCreateInfoML\"")]
        [NativeName("Name", "XR_TYPE_COORDINATE_SPACE_CREATE_INFO_ML")]
        TypeCoordinateSpaceCreateInfoML = 1000137000,
        [Obsolete("Deprecated in favour of \"SystemMarkerUnderstandingPropertiesML\"")]
        [NativeName("Name", "XR_TYPE_SYSTEM_MARKER_UNDERSTANDING_PROPERTIES_ML")]
        TypeSystemMarkerUnderstandingPropertiesML = 1000138000,
        [Obsolete("Deprecated in favour of \"MarkerDetectorCreateInfoML\"")]
        [NativeName("Name", "XR_TYPE_MARKER_DETECTOR_CREATE_INFO_ML")]
        TypeMarkerDetectorCreateInfoML = 1000138001,
        [Obsolete("Deprecated in favour of \"MarkerDetectorArucoInfoML\"")]
        [NativeName("Name", "XR_TYPE_MARKER_DETECTOR_ARUCO_INFO_ML")]
        TypeMarkerDetectorArucoInfoML = 1000138002,
        [Obsolete("Deprecated in favour of \"MarkerDetectorSizeInfoML\"")]
        [NativeName("Name", "XR_TYPE_MARKER_DETECTOR_SIZE_INFO_ML")]
        TypeMarkerDetectorSizeInfoML = 1000138003,
        [Obsolete("Deprecated in favour of \"MarkerDetectorAprilTagInfoML\"")]
        [NativeName("Name", "XR_TYPE_MARKER_DETECTOR_APRIL_TAG_INFO_ML")]
        TypeMarkerDetectorAprilTagInfoML = 1000138004,
        [Obsolete("Deprecated in favour of \"MarkerDetectorCustomProfileInfoML\"")]
        [NativeName("Name", "XR_TYPE_MARKER_DETECTOR_CUSTOM_PROFILE_INFO_ML")]
        TypeMarkerDetectorCustomProfileInfoML = 1000138005,
        [Obsolete("Deprecated in favour of \"MarkerDetectorSnapshotInfoML\"")]
        [NativeName("Name", "XR_TYPE_MARKER_DETECTOR_SNAPSHOT_INFO_ML")]
        TypeMarkerDetectorSnapshotInfoML = 1000138006,
        [Obsolete("Deprecated in favour of \"MarkerDetectorStateML\"")]
        [NativeName("Name", "XR_TYPE_MARKER_DETECTOR_STATE_ML")]
        TypeMarkerDetectorStateML = 1000138007,
        [Obsolete("Deprecated in favour of \"MarkerSpaceCreateInfoML\"")]
        [NativeName("Name", "XR_TYPE_MARKER_SPACE_CREATE_INFO_ML")]
        TypeMarkerSpaceCreateInfoML = 1000138008,
        [Obsolete("Deprecated in favour of \"LocalizationMapML\"")]
        [NativeName("Name", "XR_TYPE_LOCALIZATION_MAP_ML")]
        TypeLocalizationMapML = 1000139000,
        [Obsolete("Deprecated in favour of \"EventDataLocalizationChangedML\"")]
        [NativeName("Name", "XR_TYPE_EVENT_DATA_LOCALIZATION_CHANGED_ML")]
        TypeEventDataLocalizationChangedML = 1000139001,
        [Obsolete("Deprecated in favour of \"MapLocalizationRequestInfoML\"")]
        [NativeName("Name", "XR_TYPE_MAP_LOCALIZATION_REQUEST_INFO_ML")]
        TypeMapLocalizationRequestInfoML = 1000139002,
        [Obsolete("Deprecated in favour of \"LocalizationMapImportInfoML\"")]
        [NativeName("Name", "XR_TYPE_LOCALIZATION_MAP_IMPORT_INFO_ML")]
        TypeLocalizationMapImportInfoML = 1000139003,
        [Obsolete("Deprecated in favour of \"LocalizationEnableEventsInfoML\"")]
        [NativeName("Name", "XR_TYPE_LOCALIZATION_ENABLE_EVENTS_INFO_ML")]
        TypeLocalizationEnableEventsInfoML = 1000139004,
        [Obsolete("Deprecated in favour of \"SpatialAnchorsCreateInfoFromPoseML\"")]
        [NativeName("Name", "XR_TYPE_SPATIAL_ANCHORS_CREATE_INFO_FROM_POSE_ML")]
        TypeSpatialAnchorsCreateInfoFromPoseML = 1000140000,
        [Obsolete("Deprecated in favour of \"CreateSpatialAnchorsCompletionML\"")]
        [NativeName("Name", "XR_TYPE_CREATE_SPATIAL_ANCHORS_COMPLETION_ML")]
        TypeCreateSpatialAnchorsCompletionML = 1000140001,
        [Obsolete("Deprecated in favour of \"SpatialAnchorStateML\"")]
        [NativeName("Name", "XR_TYPE_SPATIAL_ANCHOR_STATE_ML")]
        TypeSpatialAnchorStateML = 1000140002,
        [Obsolete("Deprecated in favour of \"SpatialAnchorsCreateStorageInfoML\"")]
        [NativeName("Name", "XR_TYPE_SPATIAL_ANCHORS_CREATE_STORAGE_INFO_ML")]
        TypeSpatialAnchorsCreateStorageInfoML = 1000141000,
        [Obsolete("Deprecated in favour of \"SpatialAnchorsQueryInfoRadiusML\"")]
        [NativeName("Name", "XR_TYPE_SPATIAL_ANCHORS_QUERY_INFO_RADIUS_ML")]
        TypeSpatialAnchorsQueryInfoRadiusML = 1000141001,
        [Obsolete("Deprecated in favour of \"SpatialAnchorsQueryCompletionML\"")]
        [NativeName("Name", "XR_TYPE_SPATIAL_ANCHORS_QUERY_COMPLETION_ML")]
        TypeSpatialAnchorsQueryCompletionML = 1000141002,
        [Obsolete("Deprecated in favour of \"SpatialAnchorsCreateInfoFromUuidsML\"")]
        [NativeName("Name", "XR_TYPE_SPATIAL_ANCHORS_CREATE_INFO_FROM_UUIDS_ML")]
        TypeSpatialAnchorsCreateInfoFromUuidsML = 1000141003,
        [Obsolete("Deprecated in favour of \"SpatialAnchorsPublishInfoML\"")]
        [NativeName("Name", "XR_TYPE_SPATIAL_ANCHORS_PUBLISH_INFO_ML")]
        TypeSpatialAnchorsPublishInfoML = 1000141004,
        [Obsolete("Deprecated in favour of \"SpatialAnchorsPublishCompletionML\"")]
        [NativeName("Name", "XR_TYPE_SPATIAL_ANCHORS_PUBLISH_COMPLETION_ML")]
        TypeSpatialAnchorsPublishCompletionML = 1000141005,
        [Obsolete("Deprecated in favour of \"SpatialAnchorsDeleteInfoML\"")]
        [NativeName("Name", "XR_TYPE_SPATIAL_ANCHORS_DELETE_INFO_ML")]
        TypeSpatialAnchorsDeleteInfoML = 1000141006,
        [Obsolete("Deprecated in favour of \"SpatialAnchorsDeleteCompletionML\"")]
        [NativeName("Name", "XR_TYPE_SPATIAL_ANCHORS_DELETE_COMPLETION_ML")]
        TypeSpatialAnchorsDeleteCompletionML = 1000141007,
        [Obsolete("Deprecated in favour of \"SpatialAnchorsUpdateExpirationInfoML\"")]
        [NativeName("Name", "XR_TYPE_SPATIAL_ANCHORS_UPDATE_EXPIRATION_INFO_ML")]
        TypeSpatialAnchorsUpdateExpirationInfoML = 1000141008,
        [Obsolete("Deprecated in favour of \"SpatialAnchorsUpdateExpirationCompletionML\"")]
        [NativeName("Name", "XR_TYPE_SPATIAL_ANCHORS_UPDATE_EXPIRATION_COMPLETION_ML")]
        TypeSpatialAnchorsUpdateExpirationCompletionML = 1000141009,
        [Obsolete("Deprecated in favour of \"SpatialAnchorsPublishCompletionDetailsML\"")]
        [NativeName("Name", "XR_TYPE_SPATIAL_ANCHORS_PUBLISH_COMPLETION_DETAILS_ML")]
        TypeSpatialAnchorsPublishCompletionDetailsML = 1000141010,
        [Obsolete("Deprecated in favour of \"SpatialAnchorsDeleteCompletionDetailsML\"")]
        [NativeName("Name", "XR_TYPE_SPATIAL_ANCHORS_DELETE_COMPLETION_DETAILS_ML")]
        TypeSpatialAnchorsDeleteCompletionDetailsML = 1000141011,
        [Obsolete("Deprecated in favour of \"SpatialAnchorsUpdateExpirationCompletionDetailsML\"")]
        [NativeName("Name", "XR_TYPE_SPATIAL_ANCHORS_UPDATE_EXPIRATION_COMPLETION_DETAILS_ML")]
        TypeSpatialAnchorsUpdateExpirationCompletionDetailsML = 1000141012,
        [Obsolete("Deprecated in favour of \"EventDataHeadsetFitChangedML\"")]
        [NativeName("Name", "XR_TYPE_EVENT_DATA_HEADSET_FIT_CHANGED_ML")]
        TypeEventDataHeadsetFitChangedML = 1000472000,
        [Obsolete("Deprecated in favour of \"EventDataEyeCalibrationChangedML\"")]
        [NativeName("Name", "XR_TYPE_EVENT_DATA_EYE_CALIBRATION_CHANGED_ML")]
        TypeEventDataEyeCalibrationChangedML = 1000472001,
        [Obsolete("Deprecated in favour of \"UserCalibrationEnableEventsInfoML\"")]
        [NativeName("Name", "XR_TYPE_USER_CALIBRATION_ENABLE_EVENTS_INFO_ML")]
        TypeUserCalibrationEnableEventsInfoML = 1000472002,
        [Obsolete("Deprecated in favour of \"SpatialAnchorPersistenceInfoMsft\"")]
        [NativeName("Name", "XR_TYPE_SPATIAL_ANCHOR_PERSISTENCE_INFO_MSFT")]
        TypeSpatialAnchorPersistenceInfoMsft = 1000142000,
        [Obsolete("Deprecated in favour of \"SpatialAnchorFromPersistedAnchorCreateInfoMsft\"")]
        [NativeName("Name", "XR_TYPE_SPATIAL_ANCHOR_FROM_PERSISTED_ANCHOR_CREATE_INFO_MSFT")]
        TypeSpatialAnchorFromPersistedAnchorCreateInfoMsft = 1000142001,
        [Obsolete("Deprecated in favour of \"SceneMarkersMsft\"")]
        [NativeName("Name", "XR_TYPE_SCENE_MARKERS_MSFT")]
        TypeSceneMarkersMsft = 1000147000,
        [Obsolete("Deprecated in favour of \"SceneMarkerTypeFilterMsft\"")]
        [NativeName("Name", "XR_TYPE_SCENE_MARKER_TYPE_FILTER_MSFT")]
        TypeSceneMarkerTypeFilterMsft = 1000147001,
        [Obsolete("Deprecated in favour of \"SceneMarkerQRCodesMsft\"")]
        [NativeName("Name", "XR_TYPE_SCENE_MARKER_QR_CODES_MSFT")]
        TypeSceneMarkerQRCodesMsft = 1000147002,
        [Obsolete("Deprecated in favour of \"SpaceQueryInfoFB\"")]
        [NativeName("Name", "XR_TYPE_SPACE_QUERY_INFO_FB")]
        TypeSpaceQueryInfoFB = 1000156001,
        [Obsolete("Deprecated in favour of \"SpaceQueryResultsFB\"")]
        [NativeName("Name", "XR_TYPE_SPACE_QUERY_RESULTS_FB")]
        TypeSpaceQueryResultsFB = 1000156002,
        [Obsolete("Deprecated in favour of \"SpaceStorageLocationFilterInfoFB\"")]
        [NativeName("Name", "XR_TYPE_SPACE_STORAGE_LOCATION_FILTER_INFO_FB")]
        TypeSpaceStorageLocationFilterInfoFB = 1000156003,
        [Obsolete("Deprecated in favour of \"SpaceUuidFilterInfoFB\"")]
        [NativeName("Name", "XR_TYPE_SPACE_UUID_FILTER_INFO_FB")]
        TypeSpaceUuidFilterInfoFB = 1000156054,
        [Obsolete("Deprecated in favour of \"SpaceComponentFilterInfoFB\"")]
        [NativeName("Name", "XR_TYPE_SPACE_COMPONENT_FILTER_INFO_FB")]
        TypeSpaceComponentFilterInfoFB = 1000156052,
        [Obsolete("Deprecated in favour of \"EventDataSpaceQueryResultsAvailableFB\"")]
        [NativeName("Name", "XR_TYPE_EVENT_DATA_SPACE_QUERY_RESULTS_AVAILABLE_FB")]
        TypeEventDataSpaceQueryResultsAvailableFB = 1000156103,
        [Obsolete("Deprecated in favour of \"EventDataSpaceQueryCompleteFB\"")]
        [NativeName("Name", "XR_TYPE_EVENT_DATA_SPACE_QUERY_COMPLETE_FB")]
        TypeEventDataSpaceQueryCompleteFB = 1000156104,
        [Obsolete("Deprecated in favour of \"SpaceSaveInfoFB\"")]
        [NativeName("Name", "XR_TYPE_SPACE_SAVE_INFO_FB")]
        TypeSpaceSaveInfoFB = 1000158000,
        [Obsolete("Deprecated in favour of \"SpaceEraseInfoFB\"")]
        [NativeName("Name", "XR_TYPE_SPACE_ERASE_INFO_FB")]
        TypeSpaceEraseInfoFB = 1000158001,
        [Obsolete("Deprecated in favour of \"EventDataSpaceSaveCompleteFB\"")]
        [NativeName("Name", "XR_TYPE_EVENT_DATA_SPACE_SAVE_COMPLETE_FB")]
        TypeEventDataSpaceSaveCompleteFB = 1000158106,
        [Obsolete("Deprecated in favour of \"EventDataSpaceEraseCompleteFB\"")]
        [NativeName("Name", "XR_TYPE_EVENT_DATA_SPACE_ERASE_COMPLETE_FB")]
        TypeEventDataSpaceEraseCompleteFB = 1000158107,
        [Obsolete("Deprecated in favour of \"SwapchainImageFoveationVulkanFB\"")]
        [NativeName("Name", "XR_TYPE_SWAPCHAIN_IMAGE_FOVEATION_VULKAN_FB")]
        TypeSwapchainImageFoveationVulkanFB = 1000160000,
        [Obsolete("Deprecated in favour of \"SwapchainStateAndroidSurfaceDimensionsFB\"")]
        [NativeName("Name", "XR_TYPE_SWAPCHAIN_STATE_ANDROID_SURFACE_DIMENSIONS_FB")]
        TypeSwapchainStateAndroidSurfaceDimensionsFB = 1000161000,
        [Obsolete("Deprecated in favour of \"SwapchainStateSamplerOpenglESFB\"")]
        [NativeName("Name", "XR_TYPE_SWAPCHAIN_STATE_SAMPLER_OPENGL_ES_FB")]
        TypeSwapchainStateSamplerOpenglESFB = 1000162000,
        [Obsolete("Deprecated in favour of \"SwapchainStateSamplerVulkanFB\"")]
        [NativeName("Name", "XR_TYPE_SWAPCHAIN_STATE_SAMPLER_VULKAN_FB")]
        TypeSwapchainStateSamplerVulkanFB = 1000163000,
        [Obsolete("Deprecated in favour of \"SpaceShareInfoFB\"")]
        [NativeName("Name", "XR_TYPE_SPACE_SHARE_INFO_FB")]
        TypeSpaceShareInfoFB = 1000169001,
        [Obsolete("Deprecated in favour of \"EventDataSpaceShareCompleteFB\"")]
        [NativeName("Name", "XR_TYPE_EVENT_DATA_SPACE_SHARE_COMPLETE_FB")]
        TypeEventDataSpaceShareCompleteFB = 1000169002,
        [Obsolete("Deprecated in favour of \"CompositionLayerSpaceWarpInfoFB\"")]
        [NativeName("Name", "XR_TYPE_COMPOSITION_LAYER_SPACE_WARP_INFO_FB")]
        TypeCompositionLayerSpaceWarpInfoFB = 1000171000,
        [Obsolete("Deprecated in favour of \"SystemSpaceWarpPropertiesFB\"")]
        [NativeName("Name", "XR_TYPE_SYSTEM_SPACE_WARP_PROPERTIES_FB")]
        TypeSystemSpaceWarpPropertiesFB = 1000171001,
        [Obsolete("Deprecated in favour of \"HapticAmplitudeEnvelopeVibrationFB\"")]
        [NativeName("Name", "XR_TYPE_HAPTIC_AMPLITUDE_ENVELOPE_VIBRATION_FB")]
        TypeHapticAmplitudeEnvelopeVibrationFB = 1000173001,
        [Obsolete("Deprecated in favour of \"SemanticLabelsFB\"")]
        [NativeName("Name", "XR_TYPE_SEMANTIC_LABELS_FB")]
        TypeSemanticLabelsFB = 1000175000,
        [Obsolete("Deprecated in favour of \"RoomLayoutFB\"")]
        [NativeName("Name", "XR_TYPE_ROOM_LAYOUT_FB")]
        TypeRoomLayoutFB = 1000175001,
        [Obsolete("Deprecated in favour of \"Boundary2DFB\"")]
        [NativeName("Name", "XR_TYPE_BOUNDARY_2D_FB")]
        TypeBoundary2DFB = 1000175002,
        [Obsolete("Deprecated in favour of \"SemanticLabelsSupportInfoFB\"")]
        [NativeName("Name", "XR_TYPE_SEMANTIC_LABELS_SUPPORT_INFO_FB")]
        TypeSemanticLabelsSupportInfoFB = 1000175010,
        [Obsolete("Deprecated in favour of \"DigitalLensControlAlmalence\"")]
        [NativeName("Name", "XR_TYPE_DIGITAL_LENS_CONTROL_ALMALENCE")]
        TypeDigitalLensControlAlmalence = 1000196000,
        [Obsolete("Deprecated in favour of \"EventDataSceneCaptureCompleteFB\"")]
        [NativeName("Name", "XR_TYPE_EVENT_DATA_SCENE_CAPTURE_COMPLETE_FB")]
        TypeEventDataSceneCaptureCompleteFB = 1000198001,
        [Obsolete("Deprecated in favour of \"SceneCaptureRequestInfoFB\"")]
        [NativeName("Name", "XR_TYPE_SCENE_CAPTURE_REQUEST_INFO_FB")]
        TypeSceneCaptureRequestInfoFB = 1000198050,
        [Obsolete("Deprecated in favour of \"SpaceContainerFB\"")]
        [NativeName("Name", "XR_TYPE_SPACE_CONTAINER_FB")]
        TypeSpaceContainerFB = 1000199000,
        [Obsolete("Deprecated in favour of \"FoveationEyeTrackedProfileCreateInfoMeta\"")]
        [NativeName("Name", "XR_TYPE_FOVEATION_EYE_TRACKED_PROFILE_CREATE_INFO_META")]
        TypeFoveationEyeTrackedProfileCreateInfoMeta = 1000200000,
        [Obsolete("Deprecated in favour of \"FoveationEyeTrackedStateMeta\"")]
        [NativeName("Name", "XR_TYPE_FOVEATION_EYE_TRACKED_STATE_META")]
        TypeFoveationEyeTrackedStateMeta = 1000200001,
        [Obsolete("Deprecated in favour of \"SystemFoveationEyeTrackedPropertiesMeta\"")]
        [NativeName("Name", "XR_TYPE_SYSTEM_FOVEATION_EYE_TRACKED_PROPERTIES_META")]
        TypeSystemFoveationEyeTrackedPropertiesMeta = 1000200002,
        [Obsolete("Deprecated in favour of \"SystemFaceTrackingPropertiesFB\"")]
        [NativeName("Name", "XR_TYPE_SYSTEM_FACE_TRACKING_PROPERTIES_FB")]
        TypeSystemFaceTrackingPropertiesFB = 1000201004,
        [Obsolete("Deprecated in favour of \"FaceTrackerCreateInfoFB\"")]
        [NativeName("Name", "XR_TYPE_FACE_TRACKER_CREATE_INFO_FB")]
        TypeFaceTrackerCreateInfoFB = 1000201005,
        [Obsolete("Deprecated in favour of \"FaceExpressionInfoFB\"")]
        [NativeName("Name", "XR_TYPE_FACE_EXPRESSION_INFO_FB")]
        TypeFaceExpressionInfoFB = 1000201002,
        [Obsolete("Deprecated in favour of \"FaceExpressionWeightsFB\"")]
        [NativeName("Name", "XR_TYPE_FACE_EXPRESSION_WEIGHTS_FB")]
        TypeFaceExpressionWeightsFB = 1000201006,
        [Obsolete("Deprecated in favour of \"EyeTrackerCreateInfoFB\"")]
        [NativeName("Name", "XR_TYPE_EYE_TRACKER_CREATE_INFO_FB")]
        TypeEyeTrackerCreateInfoFB = 1000202001,
        [Obsolete("Deprecated in favour of \"EyeGazesInfoFB\"")]
        [NativeName("Name", "XR_TYPE_EYE_GAZES_INFO_FB")]
        TypeEyeGazesInfoFB = 1000202002,
        [Obsolete("Deprecated in favour of \"EyeGazesFB\"")]
        [NativeName("Name", "XR_TYPE_EYE_GAZES_FB")]
        TypeEyeGazesFB = 1000202003,
        [Obsolete("Deprecated in favour of \"SystemEyeTrackingPropertiesFB\"")]
        [NativeName("Name", "XR_TYPE_SYSTEM_EYE_TRACKING_PROPERTIES_FB")]
        TypeSystemEyeTrackingPropertiesFB = 1000202004,
        [Obsolete("Deprecated in favour of \"PassthroughKeyboardHandsIntensityFB\"")]
        [NativeName("Name", "XR_TYPE_PASSTHROUGH_KEYBOARD_HANDS_INTENSITY_FB")]
        TypePassthroughKeyboardHandsIntensityFB = 1000203002,
        [Obsolete("Deprecated in favour of \"CompositionLayerSettingsFB\"")]
        [NativeName("Name", "XR_TYPE_COMPOSITION_LAYER_SETTINGS_FB")]
        TypeCompositionLayerSettingsFB = 1000204000,
        [Obsolete("Deprecated in favour of \"HapticPcmVibrationFB\"")]
        [NativeName("Name", "XR_TYPE_HAPTIC_PCM_VIBRATION_FB")]
        TypeHapticPcmVibrationFB = 1000209001,
        [Obsolete("Deprecated in favour of \"DevicePcmSampleRateStateFB\"")]
        [NativeName("Name", "XR_TYPE_DEVICE_PCM_SAMPLE_RATE_STATE_FB")]
        TypeDevicePcmSampleRateStateFB = 1000209002,
        [Obsolete("Deprecated in favour of \"DevicePcmSampleRateGetInfoFB\"")]
        [NativeName("Name", "XR_TYPE_DEVICE_PCM_SAMPLE_RATE_GET_INFO_FB")]
        TypeDevicePcmSampleRateGetInfoFB = 1000209002,
        [Obsolete("Deprecated in favour of \"CompositionLayerDepthTestFB\"")]
        [NativeName("Name", "XR_TYPE_COMPOSITION_LAYER_DEPTH_TEST_FB")]
        TypeCompositionLayerDepthTestFB = 1000212000,
        [Obsolete("Deprecated in favour of \"LocalDimmingFrameEndInfoMeta\"")]
        [NativeName("Name", "XR_TYPE_LOCAL_DIMMING_FRAME_END_INFO_META")]
        TypeLocalDimmingFrameEndInfoMeta = 1000216000,
        [Obsolete("Deprecated in favour of \"PassthroughPreferencesMeta\"")]
        [NativeName("Name", "XR_TYPE_PASSTHROUGH_PREFERENCES_META")]
        TypePassthroughPreferencesMeta = 1000217000,
        [Obsolete("Deprecated in favour of \"SystemVirtualKeyboardPropertiesMeta\"")]
        [NativeName("Name", "XR_TYPE_SYSTEM_VIRTUAL_KEYBOARD_PROPERTIES_META")]
        TypeSystemVirtualKeyboardPropertiesMeta = 1000219001,
        [Obsolete("Deprecated in favour of \"VirtualKeyboardCreateInfoMeta\"")]
        [NativeName("Name", "XR_TYPE_VIRTUAL_KEYBOARD_CREATE_INFO_META")]
        TypeVirtualKeyboardCreateInfoMeta = 1000219002,
        [Obsolete("Deprecated in favour of \"VirtualKeyboardSpaceCreateInfoMeta\"")]
        [NativeName("Name", "XR_TYPE_VIRTUAL_KEYBOARD_SPACE_CREATE_INFO_META")]
        TypeVirtualKeyboardSpaceCreateInfoMeta = 1000219003,
        [Obsolete("Deprecated in favour of \"VirtualKeyboardLocationInfoMeta\"")]
        [NativeName("Name", "XR_TYPE_VIRTUAL_KEYBOARD_LOCATION_INFO_META")]
        TypeVirtualKeyboardLocationInfoMeta = 1000219004,
        [Obsolete("Deprecated in favour of \"VirtualKeyboardModelVisibilitySetInfoMeta\"")]
        [NativeName("Name", "XR_TYPE_VIRTUAL_KEYBOARD_MODEL_VISIBILITY_SET_INFO_META")]
        TypeVirtualKeyboardModelVisibilitySetInfoMeta = 1000219005,
        [Obsolete("Deprecated in favour of \"VirtualKeyboardAnimationStateMeta\"")]
        [NativeName("Name", "XR_TYPE_VIRTUAL_KEYBOARD_ANIMATION_STATE_META")]
        TypeVirtualKeyboardAnimationStateMeta = 1000219006,
        [Obsolete("Deprecated in favour of \"VirtualKeyboardModelAnimationStatesMeta\"")]
        [NativeName("Name", "XR_TYPE_VIRTUAL_KEYBOARD_MODEL_ANIMATION_STATES_META")]
        TypeVirtualKeyboardModelAnimationStatesMeta = 1000219007,
        [Obsolete("Deprecated in favour of \"VirtualKeyboardTextureDataMeta\"")]
        [NativeName("Name", "XR_TYPE_VIRTUAL_KEYBOARD_TEXTURE_DATA_META")]
        TypeVirtualKeyboardTextureDataMeta = 1000219009,
        [Obsolete("Deprecated in favour of \"VirtualKeyboardInputInfoMeta\"")]
        [NativeName("Name", "XR_TYPE_VIRTUAL_KEYBOARD_INPUT_INFO_META")]
        TypeVirtualKeyboardInputInfoMeta = 1000219010,
        [Obsolete("Deprecated in favour of \"VirtualKeyboardTextContextChangeInfoMeta\"")]
        [NativeName("Name", "XR_TYPE_VIRTUAL_KEYBOARD_TEXT_CONTEXT_CHANGE_INFO_META")]
        TypeVirtualKeyboardTextContextChangeInfoMeta = 1000219011,
        [Obsolete("Deprecated in favour of \"EventDataVirtualKeyboardCommitTextMeta\"")]
        [NativeName("Name", "XR_TYPE_EVENT_DATA_VIRTUAL_KEYBOARD_COMMIT_TEXT_META")]
        TypeEventDataVirtualKeyboardCommitTextMeta = 1000219014,
        [Obsolete("Deprecated in favour of \"EventDataVirtualKeyboardBackspaceMeta\"")]
        [NativeName("Name", "XR_TYPE_EVENT_DATA_VIRTUAL_KEYBOARD_BACKSPACE_META")]
        TypeEventDataVirtualKeyboardBackspaceMeta = 1000219015,
        [Obsolete("Deprecated in favour of \"EventDataVirtualKeyboardEnterMeta\"")]
        [NativeName("Name", "XR_TYPE_EVENT_DATA_VIRTUAL_KEYBOARD_ENTER_META")]
        TypeEventDataVirtualKeyboardEnterMeta = 1000219016,
        [Obsolete("Deprecated in favour of \"EventDataVirtualKeyboardShownMeta\"")]
        [NativeName("Name", "XR_TYPE_EVENT_DATA_VIRTUAL_KEYBOARD_SHOWN_META")]
        TypeEventDataVirtualKeyboardShownMeta = 1000219017,
        [Obsolete("Deprecated in favour of \"EventDataVirtualKeyboardHiddenMeta\"")]
        [NativeName("Name", "XR_TYPE_EVENT_DATA_VIRTUAL_KEYBOARD_HIDDEN_META")]
        TypeEventDataVirtualKeyboardHiddenMeta = 1000219018,
        [Obsolete("Deprecated in favour of \"ExternalCameraOculus\"")]
        [NativeName("Name", "XR_TYPE_EXTERNAL_CAMERA_OCULUS")]
        TypeExternalCameraOculus = 1000226000,
        [Obsolete("Deprecated in favour of \"VulkanSwapchainCreateInfoMeta\"")]
        [NativeName("Name", "XR_TYPE_VULKAN_SWAPCHAIN_CREATE_INFO_META")]
        TypeVulkanSwapchainCreateInfoMeta = 1000227000,
        [Obsolete("Deprecated in favour of \"PerformanceMetricsStateMeta\"")]
        [NativeName("Name", "XR_TYPE_PERFORMANCE_METRICS_STATE_META")]
        TypePerformanceMetricsStateMeta = 1000232001,
        [Obsolete("Deprecated in favour of \"PerformanceMetricsCounterMeta\"")]
        [NativeName("Name", "XR_TYPE_PERFORMANCE_METRICS_COUNTER_META")]
        TypePerformanceMetricsCounterMeta = 1000232002,
        [Obsolete("Deprecated in favour of \"SpaceListSaveInfoFB\"")]
        [NativeName("Name", "XR_TYPE_SPACE_LIST_SAVE_INFO_FB")]
        TypeSpaceListSaveInfoFB = 1000238000,
        [Obsolete("Deprecated in favour of \"EventDataSpaceListSaveCompleteFB\"")]
        [NativeName("Name", "XR_TYPE_EVENT_DATA_SPACE_LIST_SAVE_COMPLETE_FB")]
        TypeEventDataSpaceListSaveCompleteFB = 1000238001,
        [Obsolete("Deprecated in favour of \"SpaceUserCreateInfoFB\"")]
        [NativeName("Name", "XR_TYPE_SPACE_USER_CREATE_INFO_FB")]
        TypeSpaceUserCreateInfoFB = 1000241001,
        [Obsolete("Deprecated in favour of \"SystemHeadsetIDPropertiesMeta\"")]
        [NativeName("Name", "XR_TYPE_SYSTEM_HEADSET_ID_PROPERTIES_META")]
        TypeSystemHeadsetIDPropertiesMeta = 1000245000,
        [Obsolete("Deprecated in favour of \"RecommendedLayerResolutionMeta\"")]
        [NativeName("Name", "XR_TYPE_RECOMMENDED_LAYER_RESOLUTION_META")]
        TypeRecommendedLayerResolutionMeta = 1000254000,
        [Obsolete("Deprecated in favour of \"RecommendedLayerResolutionGetInfoMeta\"")]
        [NativeName("Name", "XR_TYPE_RECOMMENDED_LAYER_RESOLUTION_GET_INFO_META")]
        TypeRecommendedLayerResolutionGetInfoMeta = 1000254001,
        [Obsolete("Deprecated in favour of \"SystemPassthroughColorLutPropertiesMeta\"")]
        [NativeName("Name", "XR_TYPE_SYSTEM_PASSTHROUGH_COLOR_LUT_PROPERTIES_META")]
        TypeSystemPassthroughColorLutPropertiesMeta = 1000266000,
        [Obsolete("Deprecated in favour of \"PassthroughColorLutCreateInfoMeta\"")]
        [NativeName("Name", "XR_TYPE_PASSTHROUGH_COLOR_LUT_CREATE_INFO_META")]
        TypePassthroughColorLutCreateInfoMeta = 1000266001,
        [Obsolete("Deprecated in favour of \"PassthroughColorLutUpdateInfoMeta\"")]
        [NativeName("Name", "XR_TYPE_PASSTHROUGH_COLOR_LUT_UPDATE_INFO_META")]
        TypePassthroughColorLutUpdateInfoMeta = 1000266002,
        [Obsolete("Deprecated in favour of \"PassthroughColorMapLutMeta\"")]
        [NativeName("Name", "XR_TYPE_PASSTHROUGH_COLOR_MAP_LUT_META")]
        TypePassthroughColorMapLutMeta = 1000266100,
        [Obsolete("Deprecated in favour of \"PassthroughColorMapInterpolatedLutMeta\"")]
        [NativeName("Name", "XR_TYPE_PASSTHROUGH_COLOR_MAP_INTERPOLATED_LUT_META")]
        TypePassthroughColorMapInterpolatedLutMeta = 1000266101,
        [Obsolete("Deprecated in favour of \"SpaceTriangleMeshGetInfoMeta\"")]
        [NativeName("Name", "XR_TYPE_SPACE_TRIANGLE_MESH_GET_INFO_META")]
        TypeSpaceTriangleMeshGetInfoMeta = 1000269001,
        [Obsolete("Deprecated in favour of \"SpaceTriangleMeshMeta\"")]
        [NativeName("Name", "XR_TYPE_SPACE_TRIANGLE_MESH_META")]
        TypeSpaceTriangleMeshMeta = 1000269002,
        [Obsolete("Deprecated in favour of \"SystemFaceTrackingProperties2FB\"")]
        [NativeName("Name", "XR_TYPE_SYSTEM_FACE_TRACKING_PROPERTIES2_FB")]
        TypeSystemFaceTrackingProperties2FB = 1000287013,
        [Obsolete("Deprecated in favour of \"FaceTrackerCreateInfo2FB\"")]
        [NativeName("Name", "XR_TYPE_FACE_TRACKER_CREATE_INFO2_FB")]
        TypeFaceTrackerCreateInfo2FB = 1000287014,
        [Obsolete("Deprecated in favour of \"FaceExpressionInfo2FB\"")]
        [NativeName("Name", "XR_TYPE_FACE_EXPRESSION_INFO2_FB")]
        TypeFaceExpressionInfo2FB = 1000287015,
        [Obsolete("Deprecated in favour of \"FaceExpressionWeights2FB\"")]
        [NativeName("Name", "XR_TYPE_FACE_EXPRESSION_WEIGHTS2_FB")]
        TypeFaceExpressionWeights2FB = 1000287016,
        [Obsolete("Deprecated in favour of \"EnvironmentDepthProviderCreateInfoMeta\"")]
        [NativeName("Name", "XR_TYPE_ENVIRONMENT_DEPTH_PROVIDER_CREATE_INFO_META")]
        TypeEnvironmentDepthProviderCreateInfoMeta = 1000291000,
        [Obsolete("Deprecated in favour of \"EnvironmentDepthSwapchainCreateInfoMeta\"")]
        [NativeName("Name", "XR_TYPE_ENVIRONMENT_DEPTH_SWAPCHAIN_CREATE_INFO_META")]
        TypeEnvironmentDepthSwapchainCreateInfoMeta = 1000291001,
        [Obsolete("Deprecated in favour of \"EnvironmentDepthSwapchainStateMeta\"")]
        [NativeName("Name", "XR_TYPE_ENVIRONMENT_DEPTH_SWAPCHAIN_STATE_META")]
        TypeEnvironmentDepthSwapchainStateMeta = 1000291002,
        [Obsolete("Deprecated in favour of \"EnvironmentDepthImageAcquireInfoMeta\"")]
        [NativeName("Name", "XR_TYPE_ENVIRONMENT_DEPTH_IMAGE_ACQUIRE_INFO_META")]
        TypeEnvironmentDepthImageAcquireInfoMeta = 1000291003,
        [Obsolete("Deprecated in favour of \"EnvironmentDepthImageViewMeta\"")]
        [NativeName("Name", "XR_TYPE_ENVIRONMENT_DEPTH_IMAGE_VIEW_META")]
        TypeEnvironmentDepthImageViewMeta = 1000291004,
        [Obsolete("Deprecated in favour of \"EnvironmentDepthImageMeta\"")]
        [NativeName("Name", "XR_TYPE_ENVIRONMENT_DEPTH_IMAGE_META")]
        TypeEnvironmentDepthImageMeta = 1000291005,
        [Obsolete("Deprecated in favour of \"EnvironmentDepthHandRemovalSetInfoMeta\"")]
        [NativeName("Name", "XR_TYPE_ENVIRONMENT_DEPTH_HAND_REMOVAL_SET_INFO_META")]
        TypeEnvironmentDepthHandRemovalSetInfoMeta = 1000291006,
        [Obsolete("Deprecated in favour of \"SystemEnvironmentDepthPropertiesMeta\"")]
        [NativeName("Name", "XR_TYPE_SYSTEM_ENVIRONMENT_DEPTH_PROPERTIES_META")]
        TypeSystemEnvironmentDepthPropertiesMeta = 1000291007,
        [Obsolete("Deprecated in favour of \"PassthroughCreateInfoHtc\"")]
        [NativeName("Name", "XR_TYPE_PASSTHROUGH_CREATE_INFO_HTC")]
        TypePassthroughCreateInfoHtc = 1000317001,
        [Obsolete("Deprecated in favour of \"PassthroughColorHtc\"")]
        [NativeName("Name", "XR_TYPE_PASSTHROUGH_COLOR_HTC")]
        TypePassthroughColorHtc = 1000317002,
        [Obsolete("Deprecated in favour of \"PassthroughMeshTransformInfoHtc\"")]
        [NativeName("Name", "XR_TYPE_PASSTHROUGH_MESH_TRANSFORM_INFO_HTC")]
        TypePassthroughMeshTransformInfoHtc = 1000317003,
        [Obsolete("Deprecated in favour of \"CompositionLayerPassthroughHtc\"")]
        [NativeName("Name", "XR_TYPE_COMPOSITION_LAYER_PASSTHROUGH_HTC")]
        TypeCompositionLayerPassthroughHtc = 1000317004,
        [Obsolete("Deprecated in favour of \"FoveationApplyInfoHtc\"")]
        [NativeName("Name", "XR_TYPE_FOVEATION_APPLY_INFO_HTC")]
        TypeFoveationApplyInfoHtc = 1000318000,
        [Obsolete("Deprecated in favour of \"FoveationDynamicModeInfoHtc\"")]
        [NativeName("Name", "XR_TYPE_FOVEATION_DYNAMIC_MODE_INFO_HTC")]
        TypeFoveationDynamicModeInfoHtc = 1000318001,
        [Obsolete("Deprecated in favour of \"FoveationCustomModeInfoHtc\"")]
        [NativeName("Name", "XR_TYPE_FOVEATION_CUSTOM_MODE_INFO_HTC")]
        TypeFoveationCustomModeInfoHtc = 1000318002,
        [Obsolete("Deprecated in favour of \"SystemAnchorPropertiesHtc\"")]
        [NativeName("Name", "XR_TYPE_SYSTEM_ANCHOR_PROPERTIES_HTC")]
        TypeSystemAnchorPropertiesHtc = 1000319000,
        [Obsolete("Deprecated in favour of \"SpatialAnchorCreateInfoHtc\"")]
        [NativeName("Name", "XR_TYPE_SPATIAL_ANCHOR_CREATE_INFO_HTC")]
        TypeSpatialAnchorCreateInfoHtc = 1000319001,
        [Obsolete("Deprecated in favour of \"SystemBodyTrackingPropertiesHtc\"")]
        [NativeName("Name", "XR_TYPE_SYSTEM_BODY_TRACKING_PROPERTIES_HTC")]
        TypeSystemBodyTrackingPropertiesHtc = 1000320000,
        [Obsolete("Deprecated in favour of \"BodyTrackerCreateInfoHtc\"")]
        [NativeName("Name", "XR_TYPE_BODY_TRACKER_CREATE_INFO_HTC")]
        TypeBodyTrackerCreateInfoHtc = 1000320001,
        [Obsolete("Deprecated in favour of \"BodyJointsLocateInfoHtc\"")]
        [NativeName("Name", "XR_TYPE_BODY_JOINTS_LOCATE_INFO_HTC")]
        TypeBodyJointsLocateInfoHtc = 1000320002,
        [Obsolete("Deprecated in favour of \"BodyJointLocationsHtc\"")]
        [NativeName("Name", "XR_TYPE_BODY_JOINT_LOCATIONS_HTC")]
        TypeBodyJointLocationsHtc = 1000320003,
        [Obsolete("Deprecated in favour of \"BodySkeletonHtc\"")]
        [NativeName("Name", "XR_TYPE_BODY_SKELETON_HTC")]
        TypeBodySkeletonHtc = 1000320004,
        [Obsolete("Deprecated in favour of \"ActiveActionSetPrioritiesExt\"")]
        [NativeName("Name", "XR_TYPE_ACTIVE_ACTION_SET_PRIORITIES_EXT")]
        TypeActiveActionSetPrioritiesExt = 1000373000,
        [Obsolete("Deprecated in favour of \"SystemForceFeedbackCurlPropertiesMndx\"")]
        [NativeName("Name", "XR_TYPE_SYSTEM_FORCE_FEEDBACK_CURL_PROPERTIES_MNDX")]
        TypeSystemForceFeedbackCurlPropertiesMndx = 1000375000,
        [Obsolete("Deprecated in favour of \"ForceFeedbackCurlApplyLocationsMndx\"")]
        [NativeName("Name", "XR_TYPE_FORCE_FEEDBACK_CURL_APPLY_LOCATIONS_MNDX")]
        TypeForceFeedbackCurlApplyLocationsMndx = 1000375001,
        [Obsolete("Deprecated in favour of \"HandTrackingDataSourceInfoExt\"")]
        [NativeName("Name", "XR_TYPE_HAND_TRACKING_DATA_SOURCE_INFO_EXT")]
        TypeHandTrackingDataSourceInfoExt = 1000428000,
        [Obsolete("Deprecated in favour of \"HandTrackingDataSourceStateExt\"")]
        [NativeName("Name", "XR_TYPE_HAND_TRACKING_DATA_SOURCE_STATE_EXT")]
        TypeHandTrackingDataSourceStateExt = 1000428001,
        [Obsolete("Deprecated in favour of \"PlaneDetectorCreateInfoExt\"")]
        [NativeName("Name", "XR_TYPE_PLANE_DETECTOR_CREATE_INFO_EXT")]
        TypePlaneDetectorCreateInfoExt = 1000429001,
        [Obsolete("Deprecated in favour of \"PlaneDetectorBeginInfoExt\"")]
        [NativeName("Name", "XR_TYPE_PLANE_DETECTOR_BEGIN_INFO_EXT")]
        TypePlaneDetectorBeginInfoExt = 1000429002,
        [Obsolete("Deprecated in favour of \"PlaneDetectorGetInfoExt\"")]
        [NativeName("Name", "XR_TYPE_PLANE_DETECTOR_GET_INFO_EXT")]
        TypePlaneDetectorGetInfoExt = 1000429003,
        [Obsolete("Deprecated in favour of \"PlaneDetectorLocationsExt\"")]
        [NativeName("Name", "XR_TYPE_PLANE_DETECTOR_LOCATIONS_EXT")]
        TypePlaneDetectorLocationsExt = 1000429004,
        [Obsolete("Deprecated in favour of \"PlaneDetectorLocationExt\"")]
        [NativeName("Name", "XR_TYPE_PLANE_DETECTOR_LOCATION_EXT")]
        TypePlaneDetectorLocationExt = 1000429005,
        [Obsolete("Deprecated in favour of \"PlaneDetectorPolygonBufferExt\"")]
        [NativeName("Name", "XR_TYPE_PLANE_DETECTOR_POLYGON_BUFFER_EXT")]
        TypePlaneDetectorPolygonBufferExt = 1000429006,
        [Obsolete("Deprecated in favour of \"SystemPlaneDetectionPropertiesExt\"")]
        [NativeName("Name", "XR_TYPE_SYSTEM_PLANE_DETECTION_PROPERTIES_EXT")]
        TypeSystemPlaneDetectionPropertiesExt = 1000429007,
        [Obsolete("Deprecated in favour of \"FutureCancelInfoExt\"")]
        [NativeName("Name", "XR_TYPE_FUTURE_CANCEL_INFO_EXT")]
        TypeFutureCancelInfoExt = 1000469000,
        [Obsolete("Deprecated in favour of \"FuturePollInfoExt\"")]
        [NativeName("Name", "XR_TYPE_FUTURE_POLL_INFO_EXT")]
        TypeFuturePollInfoExt = 1000469001,
        [Obsolete("Deprecated in favour of \"FutureCompletionExt\"")]
        [NativeName("Name", "XR_TYPE_FUTURE_COMPLETION_EXT")]
        TypeFutureCompletionExt = 1000469002,
        [Obsolete("Deprecated in favour of \"FuturePollResultExt\"")]
        [NativeName("Name", "XR_TYPE_FUTURE_POLL_RESULT_EXT")]
        TypeFuturePollResultExt = 1000469003,
        [Obsolete("Deprecated in favour of \"EventDataUserPresenceChangedExt\"")]
        [NativeName("Name", "XR_TYPE_EVENT_DATA_USER_PRESENCE_CHANGED_EXT")]
        TypeEventDataUserPresenceChangedExt = 1000470000,
        [Obsolete("Deprecated in favour of \"SystemUserPresencePropertiesExt\"")]
        [NativeName("Name", "XR_TYPE_SYSTEM_USER_PRESENCE_PROPERTIES_EXT")]
        TypeSystemUserPresencePropertiesExt = 1000470001,
        [Obsolete("Deprecated in favour of \"SpacesLocateInfoKhr\"")]
        [NativeName("Name", "XR_TYPE_SPACES_LOCATE_INFO_KHR")]
        TypeSpacesLocateInfoKhr = 1000471000,
        [Obsolete("Deprecated in favour of \"SpaceLocationsKhr\"")]
        [NativeName("Name", "XR_TYPE_SPACE_LOCATIONS_KHR")]
        TypeSpaceLocationsKhr = 1000471001,
        [Obsolete("Deprecated in favour of \"SpaceVelocitiesKhr\"")]
        [NativeName("Name", "XR_TYPE_SPACE_VELOCITIES_KHR")]
        TypeSpaceVelocitiesKhr = 1000471002,
        [Obsolete("Deprecated in favour of \"SystemNotificationsSetInfoML\"")]
        [NativeName("Name", "XR_TYPE_SYSTEM_NOTIFICATIONS_SET_INFO_ML")]
        TypeSystemNotificationsSetInfoML = 1000473000,
        [Obsolete("Deprecated in favour of \"WorldMeshDetectorCreateInfoML\"")]
        [NativeName("Name", "XR_TYPE_WORLD_MESH_DETECTOR_CREATE_INFO_ML")]
        TypeWorldMeshDetectorCreateInfoML = 1000474001,
        [Obsolete("Deprecated in favour of \"WorldMeshStateRequestInfoML\"")]
        [NativeName("Name", "XR_TYPE_WORLD_MESH_STATE_REQUEST_INFO_ML")]
        TypeWorldMeshStateRequestInfoML = 1000474002,
        [Obsolete("Deprecated in favour of \"WorldMeshBlockStateML\"")]
        [NativeName("Name", "XR_TYPE_WORLD_MESH_BLOCK_STATE_ML")]
        TypeWorldMeshBlockStateML = 1000474003,
        [Obsolete("Deprecated in favour of \"WorldMeshStateRequestCompletionML\"")]
        [NativeName("Name", "XR_TYPE_WORLD_MESH_STATE_REQUEST_COMPLETION_ML")]
        TypeWorldMeshStateRequestCompletionML = 1000474004,
        [Obsolete("Deprecated in favour of \"WorldMeshBufferRecommendedSizeInfoML\"")]
        [NativeName("Name", "XR_TYPE_WORLD_MESH_BUFFER_RECOMMENDED_SIZE_INFO_ML")]
        TypeWorldMeshBufferRecommendedSizeInfoML = 1000474005,
        [Obsolete("Deprecated in favour of \"WorldMeshBufferSizeML\"")]
        [NativeName("Name", "XR_TYPE_WORLD_MESH_BUFFER_SIZE_ML")]
        TypeWorldMeshBufferSizeML = 1000474006,
        [Obsolete("Deprecated in favour of \"WorldMeshBufferML\"")]
        [NativeName("Name", "XR_TYPE_WORLD_MESH_BUFFER_ML")]
        TypeWorldMeshBufferML = 1000474007,
        [Obsolete("Deprecated in favour of \"WorldMeshBlockRequestML\"")]
        [NativeName("Name", "XR_TYPE_WORLD_MESH_BLOCK_REQUEST_ML")]
        TypeWorldMeshBlockRequestML = 1000474008,
        [Obsolete("Deprecated in favour of \"WorldMeshGetInfoML\"")]
        [NativeName("Name", "XR_TYPE_WORLD_MESH_GET_INFO_ML")]
        TypeWorldMeshGetInfoML = 1000474009,
        [Obsolete("Deprecated in favour of \"WorldMeshBlockML\"")]
        [NativeName("Name", "XR_TYPE_WORLD_MESH_BLOCK_ML")]
        TypeWorldMeshBlockML = 1000474010,
        [Obsolete("Deprecated in favour of \"WorldMeshRequestCompletionML\"")]
        [NativeName("Name", "XR_TYPE_WORLD_MESH_REQUEST_COMPLETION_ML")]
        TypeWorldMeshRequestCompletionML = 1000474011,
        [Obsolete("Deprecated in favour of \"WorldMeshRequestCompletionInfoML\"")]
        [NativeName("Name", "XR_TYPE_WORLD_MESH_REQUEST_COMPLETION_INFO_ML")]
        TypeWorldMeshRequestCompletionInfoML = 1000474012,
        [Obsolete("Deprecated in favour of \"SpacesLocateInfo\"")]
        [NativeName("Name", "XR_TYPE_SPACES_LOCATE_INFO")]
        TypeSpacesLocateInfo = 1000471000,
        [Obsolete("Deprecated in favour of \"SpaceLocations\"")]
        [NativeName("Name", "XR_TYPE_SPACE_LOCATIONS")]
        TypeSpaceLocations = 1000471001,
        [Obsolete("Deprecated in favour of \"SpaceVelocities\"")]
        [NativeName("Name", "XR_TYPE_SPACE_VELOCITIES")]
        TypeSpaceVelocities = 1000471002,
        [NativeName("Name", "XR_TYPE_UNKNOWN")]
        Unknown = 0,
        [NativeName("Name", "XR_TYPE_API_LAYER_PROPERTIES")]
        ApiLayerProperties = 1,
        [NativeName("Name", "XR_TYPE_EXTENSION_PROPERTIES")]
        ExtensionProperties = 2,
        [NativeName("Name", "XR_TYPE_INSTANCE_CREATE_INFO")]
        InstanceCreateInfo = 3,
        [NativeName("Name", "XR_TYPE_SYSTEM_GET_INFO")]
        SystemGetInfo = 4,
        [NativeName("Name", "XR_TYPE_SYSTEM_PROPERTIES")]
        SystemProperties = 5,
        [NativeName("Name", "XR_TYPE_VIEW_LOCATE_INFO")]
        ViewLocateInfo = 6,
        [NativeName("Name", "XR_TYPE_VIEW")]
        View = 7,
        [NativeName("Name", "XR_TYPE_SESSION_CREATE_INFO")]
        SessionCreateInfo = 8,
        [NativeName("Name", "XR_TYPE_SWAPCHAIN_CREATE_INFO")]
        SwapchainCreateInfo = 9,
        [NativeName("Name", "XR_TYPE_SESSION_BEGIN_INFO")]
        SessionBeginInfo = 10,
        [NativeName("Name", "XR_TYPE_VIEW_STATE")]
        ViewState = 11,
        [NativeName("Name", "XR_TYPE_FRAME_END_INFO")]
        FrameEndInfo = 12,
        [NativeName("Name", "XR_TYPE_HAPTIC_VIBRATION")]
        HapticVibration = 13,
        [NativeName("Name", "XR_TYPE_EVENT_DATA_BUFFER")]
        EventDataBuffer = 16,
        [NativeName("Name", "XR_TYPE_EVENT_DATA_INSTANCE_LOSS_PENDING")]
        EventDataInstanceLossPending = 17,
        [NativeName("Name", "XR_TYPE_EVENT_DATA_SESSION_STATE_CHANGED")]
        EventDataSessionStateChanged = 18,
        [NativeName("Name", "XR_TYPE_ACTION_STATE_BOOLEAN")]
        ActionStateBoolean = 23,
        [NativeName("Name", "XR_TYPE_ACTION_STATE_FLOAT")]
        ActionStateFloat = 24,
        [NativeName("Name", "XR_TYPE_ACTION_STATE_VECTOR2F")]
        ActionStateVector2f = 25,
        [NativeName("Name", "XR_TYPE_ACTION_STATE_POSE")]
        ActionStatePose = 27,
        [NativeName("Name", "XR_TYPE_ACTION_SET_CREATE_INFO")]
        ActionSetCreateInfo = 28,
        [NativeName("Name", "XR_TYPE_ACTION_CREATE_INFO")]
        ActionCreateInfo = 29,
        [NativeName("Name", "XR_TYPE_INSTANCE_PROPERTIES")]
        InstanceProperties = 32,
        [NativeName("Name", "XR_TYPE_FRAME_WAIT_INFO")]
        FrameWaitInfo = 33,
        [NativeName("Name", "XR_TYPE_COMPOSITION_LAYER_PROJECTION")]
        CompositionLayerProjection = 35,
        [NativeName("Name", "XR_TYPE_COMPOSITION_LAYER_QUAD")]
        CompositionLayerQuad = 36,
        [NativeName("Name", "XR_TYPE_REFERENCE_SPACE_CREATE_INFO")]
        ReferenceSpaceCreateInfo = 37,
        [NativeName("Name", "XR_TYPE_ACTION_SPACE_CREATE_INFO")]
        ActionSpaceCreateInfo = 38,
        [NativeName("Name", "XR_TYPE_EVENT_DATA_REFERENCE_SPACE_CHANGE_PENDING")]
        EventDataReferenceSpaceChangePending = 40,
        [NativeName("Name", "XR_TYPE_VIEW_CONFIGURATION_VIEW")]
        ViewConfigurationView = 41,
        [NativeName("Name", "XR_TYPE_SPACE_LOCATION")]
        SpaceLocation = 42,
        [NativeName("Name", "XR_TYPE_SPACE_VELOCITY")]
        SpaceVelocity = 43,
        [NativeName("Name", "XR_TYPE_FRAME_STATE")]
        FrameState = 44,
        [NativeName("Name", "XR_TYPE_VIEW_CONFIGURATION_PROPERTIES")]
        ViewConfigurationProperties = 45,
        [NativeName("Name", "XR_TYPE_FRAME_BEGIN_INFO")]
        FrameBeginInfo = 46,
        [NativeName("Name", "XR_TYPE_COMPOSITION_LAYER_PROJECTION_VIEW")]
        CompositionLayerProjectionView = 48,
        [NativeName("Name", "XR_TYPE_EVENT_DATA_EVENTS_LOST")]
        EventDataEventsLost = 49,
        [NativeName("Name", "XR_TYPE_INTERACTION_PROFILE_SUGGESTED_BINDING")]
        InteractionProfileSuggestedBinding = 51,
        [NativeName("Name", "XR_TYPE_EVENT_DATA_INTERACTION_PROFILE_CHANGED")]
        EventDataInteractionProfileChanged = 52,
        [NativeName("Name", "XR_TYPE_INTERACTION_PROFILE_STATE")]
        InteractionProfileState = 53,
        [NativeName("Name", "XR_TYPE_SWAPCHAIN_IMAGE_ACQUIRE_INFO")]
        SwapchainImageAcquireInfo = 55,
        [NativeName("Name", "XR_TYPE_SWAPCHAIN_IMAGE_WAIT_INFO")]
        SwapchainImageWaitInfo = 56,
        [NativeName("Name", "XR_TYPE_SWAPCHAIN_IMAGE_RELEASE_INFO")]
        SwapchainImageReleaseInfo = 57,
        [NativeName("Name", "XR_TYPE_ACTION_STATE_GET_INFO")]
        ActionStateGetInfo = 58,
        [NativeName("Name", "XR_TYPE_HAPTIC_ACTION_INFO")]
        HapticActionInfo = 59,
        [NativeName("Name", "XR_TYPE_SESSION_ACTION_SETS_ATTACH_INFO")]
        SessionActionSetsAttachInfo = 60,
        [NativeName("Name", "XR_TYPE_ACTIONS_SYNC_INFO")]
        ActionsSyncInfo = 61,
        [NativeName("Name", "XR_TYPE_BOUND_SOURCES_FOR_ACTION_ENUMERATE_INFO")]
        BoundSourcesForActionEnumerateInfo = 62,
        [NativeName("Name", "XR_TYPE_INPUT_SOURCE_LOCALIZED_NAME_GET_INFO")]
        InputSourceLocalizedNameGetInfo = 63,
        [NativeName("Name", "XR_TYPE_COMPOSITION_LAYER_CUBE_KHR")]
        CompositionLayerCubeKhr = 1000006000,
        [NativeName("Name", "XR_TYPE_INSTANCE_CREATE_INFO_ANDROID_KHR")]
        InstanceCreateInfoAndroidKhr = 1000008000,
        [NativeName("Name", "XR_TYPE_COMPOSITION_LAYER_DEPTH_INFO_KHR")]
        CompositionLayerDepthInfoKhr = 1000010000,
        [NativeName("Name", "XR_TYPE_VULKAN_SWAPCHAIN_FORMAT_LIST_CREATE_INFO_KHR")]
        VulkanSwapchainFormatListCreateInfoKhr = 1000014000,
        [NativeName("Name", "XR_TYPE_EVENT_DATA_PERF_SETTINGS_EXT")]
        EventDataPerfSettingsExt = 1000015000,
        [NativeName("Name", "XR_TYPE_COMPOSITION_LAYER_CYLINDER_KHR")]
        CompositionLayerCylinderKhr = 1000017000,
        [NativeName("Name", "XR_TYPE_COMPOSITION_LAYER_EQUIRECT_KHR")]
        CompositionLayerEquirectKhr = 1000018000,
        [NativeName("Name", "XR_TYPE_DEBUG_UTILS_OBJECT_NAME_INFO_EXT")]
        DebugUtilsObjectNameInfoExt = 1000019000,
        [NativeName("Name", "XR_TYPE_DEBUG_UTILS_MESSENGER_CALLBACK_DATA_EXT")]
        DebugUtilsMessengerCallbackDataExt = 1000019001,
        [NativeName("Name", "XR_TYPE_DEBUG_UTILS_MESSENGER_CREATE_INFO_EXT")]
        DebugUtilsMessengerCreateInfoExt = 1000019002,
        [NativeName("Name", "XR_TYPE_DEBUG_UTILS_LABEL_EXT")]
        DebugUtilsLabelExt = 1000019003,
        [NativeName("Name", "XR_TYPE_GRAPHICS_BINDING_OPENGL_WIN32_KHR")]
        GraphicsBindingOpenglWin32Khr = 1000023000,
        [NativeName("Name", "XR_TYPE_GRAPHICS_BINDING_OPENGL_XLIB_KHR")]
        GraphicsBindingOpenglXlibKhr = 1000023001,
        [NativeName("Name", "XR_TYPE_GRAPHICS_BINDING_OPENGL_XCB_KHR")]
        GraphicsBindingOpenglXcbKhr = 1000023002,
        [NativeName("Name", "XR_TYPE_GRAPHICS_BINDING_OPENGL_WAYLAND_KHR")]
        GraphicsBindingOpenglWaylandKhr = 1000023003,
        [NativeName("Name", "XR_TYPE_SWAPCHAIN_IMAGE_OPENGL_KHR")]
        SwapchainImageOpenglKhr = 1000023004,
        [NativeName("Name", "XR_TYPE_GRAPHICS_REQUIREMENTS_OPENGL_KHR")]
        GraphicsRequirementsOpenglKhr = 1000023005,
        [NativeName("Name", "XR_TYPE_GRAPHICS_BINDING_OPENGL_ES_ANDROID_KHR")]
        GraphicsBindingOpenglESAndroidKhr = 1000024001,
        [NativeName("Name", "XR_TYPE_SWAPCHAIN_IMAGE_OPENGL_ES_KHR")]
        SwapchainImageOpenglESKhr = 1000024002,
        [NativeName("Name", "XR_TYPE_GRAPHICS_REQUIREMENTS_OPENGL_ES_KHR")]
        GraphicsRequirementsOpenglESKhr = 1000024003,
        [NativeName("Name", "XR_TYPE_GRAPHICS_BINDING_VULKAN_KHR")]
        GraphicsBindingVulkanKhr = 1000025000,
        [NativeName("Name", "XR_TYPE_SWAPCHAIN_IMAGE_VULKAN_KHR")]
        SwapchainImageVulkanKhr = 1000025001,
        [NativeName("Name", "XR_TYPE_GRAPHICS_REQUIREMENTS_VULKAN_KHR")]
        GraphicsRequirementsVulkanKhr = 1000025002,
        [NativeName("Name", "XR_TYPE_GRAPHICS_BINDING_D3D11_KHR")]
        GraphicsBindingD3D11Khr = 1000027000,
        [NativeName("Name", "XR_TYPE_SWAPCHAIN_IMAGE_D3D11_KHR")]
        SwapchainImageD3D11Khr = 1000027001,
        [NativeName("Name", "XR_TYPE_GRAPHICS_REQUIREMENTS_D3D11_KHR")]
        GraphicsRequirementsD3D11Khr = 1000027002,
        [NativeName("Name", "XR_TYPE_GRAPHICS_BINDING_D3D12_KHR")]
        GraphicsBindingD3D12Khr = 1000028000,
        [NativeName("Name", "XR_TYPE_SWAPCHAIN_IMAGE_D3D12_KHR")]
        SwapchainImageD3D12Khr = 1000028001,
        [NativeName("Name", "XR_TYPE_GRAPHICS_REQUIREMENTS_D3D12_KHR")]
        GraphicsRequirementsD3D12Khr = 1000028002,
        [NativeName("Name", "XR_TYPE_GRAPHICS_BINDING_METAL_KHR")]
        GraphicsBindingMetalKhr = 1000029000,
        [NativeName("Name", "XR_TYPE_SWAPCHAIN_IMAGE_METAL_KHR")]
        SwapchainImageMetalKhr = 1000029001,
        [NativeName("Name", "XR_TYPE_GRAPHICS_REQUIREMENTS_METAL_KHR")]
        GraphicsRequirementsMetalKhr = 1000029002,
        [NativeName("Name", "XR_TYPE_SYSTEM_EYE_GAZE_INTERACTION_PROPERTIES_EXT")]
        SystemEyeGazeInteractionPropertiesExt = 1000030000,
        [NativeName("Name", "XR_TYPE_EYE_GAZE_SAMPLE_TIME_EXT")]
        EyeGazeSampleTimeExt = 1000030001,
        [NativeName("Name", "XR_TYPE_VISIBILITY_MASK_KHR")]
        VisibilityMaskKhr = 1000031000,
        [NativeName("Name", "XR_TYPE_EVENT_DATA_VISIBILITY_MASK_CHANGED_KHR")]
        EventDataVisibilityMaskChangedKhr = 1000031001,
        [NativeName("Name", "XR_TYPE_SESSION_CREATE_INFO_OVERLAY_EXTX")]
        SessionCreateInfoOverlayExtx = 1000033000,
        [NativeName("Name", "XR_TYPE_EVENT_DATA_MAIN_SESSION_VISIBILITY_CHANGED_EXTX")]
        EventDataMainSessionVisibilityChangedExtx = 1000033003,
        [NativeName("Name", "XR_TYPE_COMPOSITION_LAYER_COLOR_SCALE_BIAS_KHR")]
        CompositionLayerColorScaleBiasKhr = 1000034000,
        [NativeName("Name", "XR_TYPE_SPATIAL_ANCHOR_CREATE_INFO_MSFT")]
        SpatialAnchorCreateInfoMsft = 1000039000,
        [NativeName("Name", "XR_TYPE_SPATIAL_ANCHOR_SPACE_CREATE_INFO_MSFT")]
        SpatialAnchorSpaceCreateInfoMsft = 1000039001,
        [NativeName("Name", "XR_TYPE_COMPOSITION_LAYER_IMAGE_LAYOUT_FB")]
        CompositionLayerImageLayoutFB = 1000040000,
        [NativeName("Name", "XR_TYPE_COMPOSITION_LAYER_ALPHA_BLEND_FB")]
        CompositionLayerAlphaBlendFB = 1000041001,
        [NativeName("Name", "XR_TYPE_VIEW_CONFIGURATION_DEPTH_RANGE_EXT")]
        ViewConfigurationDepthRangeExt = 1000046000,
        [NativeName("Name", "XR_TYPE_GRAPHICS_BINDING_EGL_MNDX")]
        GraphicsBindingEglMndx = 1000048004,
        [NativeName("Name", "XR_TYPE_SPATIAL_GRAPH_NODE_SPACE_CREATE_INFO_MSFT")]
        SpatialGraphNodeSpaceCreateInfoMsft = 1000049000,
        [NativeName("Name", "XR_TYPE_SPATIAL_GRAPH_STATIC_NODE_BINDING_CREATE_INFO_MSFT")]
        SpatialGraphStaticNodeBindingCreateInfoMsft = 1000049001,
        [NativeName("Name", "XR_TYPE_SPATIAL_GRAPH_NODE_BINDING_PROPERTIES_GET_INFO_MSFT")]
        SpatialGraphNodeBindingPropertiesGetInfoMsft = 1000049002,
        [NativeName("Name", "XR_TYPE_SPATIAL_GRAPH_NODE_BINDING_PROPERTIES_MSFT")]
        SpatialGraphNodeBindingPropertiesMsft = 1000049003,
        [NativeName("Name", "XR_TYPE_SYSTEM_HAND_TRACKING_PROPERTIES_EXT")]
        SystemHandTrackingPropertiesExt = 1000051000,
        [NativeName("Name", "XR_TYPE_HAND_TRACKER_CREATE_INFO_EXT")]
        HandTrackerCreateInfoExt = 1000051001,
        [NativeName("Name", "XR_TYPE_HAND_JOINTS_LOCATE_INFO_EXT")]
        HandJointsLocateInfoExt = 1000051002,
        [NativeName("Name", "XR_TYPE_HAND_JOINT_LOCATIONS_EXT")]
        HandJointLocationsExt = 1000051003,
        [NativeName("Name", "XR_TYPE_HAND_JOINT_VELOCITIES_EXT")]
        HandJointVelocitiesExt = 1000051004,
        [NativeName("Name", "XR_TYPE_SYSTEM_HAND_TRACKING_MESH_PROPERTIES_MSFT")]
        SystemHandTrackingMeshPropertiesMsft = 1000052000,
        [NativeName("Name", "XR_TYPE_HAND_MESH_SPACE_CREATE_INFO_MSFT")]
        HandMeshSpaceCreateInfoMsft = 1000052001,
        [NativeName("Name", "XR_TYPE_HAND_MESH_UPDATE_INFO_MSFT")]
        HandMeshUpdateInfoMsft = 1000052002,
        [NativeName("Name", "XR_TYPE_HAND_MESH_MSFT")]
        HandMeshMsft = 1000052003,
        [NativeName("Name", "XR_TYPE_HAND_POSE_TYPE_INFO_MSFT")]
        HandPoseTypeInfoMsft = 1000052004,
        [NativeName("Name", "XR_TYPE_SECONDARY_VIEW_CONFIGURATION_SESSION_BEGIN_INFO_MSFT")]
        SecondaryViewConfigurationSessionBeginInfoMsft = 1000053000,
        [NativeName("Name", "XR_TYPE_SECONDARY_VIEW_CONFIGURATION_STATE_MSFT")]
        SecondaryViewConfigurationStateMsft = 1000053001,
        [NativeName("Name", "XR_TYPE_SECONDARY_VIEW_CONFIGURATION_FRAME_STATE_MSFT")]
        SecondaryViewConfigurationFrameStateMsft = 1000053002,
        [NativeName("Name", "XR_TYPE_SECONDARY_VIEW_CONFIGURATION_FRAME_END_INFO_MSFT")]
        SecondaryViewConfigurationFrameEndInfoMsft = 1000053003,
        [NativeName("Name", "XR_TYPE_SECONDARY_VIEW_CONFIGURATION_LAYER_INFO_MSFT")]
        SecondaryViewConfigurationLayerInfoMsft = 1000053004,
        [NativeName("Name", "XR_TYPE_SECONDARY_VIEW_CONFIGURATION_SWAPCHAIN_CREATE_INFO_MSFT")]
        SecondaryViewConfigurationSwapchainCreateInfoMsft = 1000053005,
        [NativeName("Name", "XR_TYPE_CONTROLLER_MODEL_KEY_STATE_MSFT")]
        ControllerModelKeyStateMsft = 1000055000,
        [NativeName("Name", "XR_TYPE_CONTROLLER_MODEL_NODE_PROPERTIES_MSFT")]
        ControllerModelNodePropertiesMsft = 1000055001,
        [NativeName("Name", "XR_TYPE_CONTROLLER_MODEL_PROPERTIES_MSFT")]
        ControllerModelPropertiesMsft = 1000055002,
        [NativeName("Name", "XR_TYPE_CONTROLLER_MODEL_NODE_STATE_MSFT")]
        ControllerModelNodeStateMsft = 1000055003,
        [NativeName("Name", "XR_TYPE_CONTROLLER_MODEL_STATE_MSFT")]
        ControllerModelStateMsft = 1000055004,
        [NativeName("Name", "XR_TYPE_VIEW_CONFIGURATION_VIEW_FOV_EPIC")]
        ViewConfigurationViewFovEpic = 1000059000,
        [NativeName("Name", "XR_TYPE_HOLOGRAPHIC_WINDOW_ATTACHMENT_MSFT")]
        HolographicWindowAttachmentMsft = 1000063000,
        [NativeName("Name", "XR_TYPE_COMPOSITION_LAYER_REPROJECTION_INFO_MSFT")]
        CompositionLayerReprojectionInfoMsft = 1000066000,
        [NativeName("Name", "XR_TYPE_COMPOSITION_LAYER_REPROJECTION_PLANE_OVERRIDE_MSFT")]
        CompositionLayerReprojectionPlaneOverrideMsft = 1000066001,
        [NativeName("Name", "XR_TYPE_ANDROID_SURFACE_SWAPCHAIN_CREATE_INFO_FB")]
        AndroidSurfaceSwapchainCreateInfoFB = 1000070000,
        [NativeName("Name", "XR_TYPE_COMPOSITION_LAYER_SECURE_CONTENT_FB")]
        CompositionLayerSecureContentFB = 1000072000,
        [NativeName("Name", "XR_TYPE_BODY_TRACKER_CREATE_INFO_FB")]
        BodyTrackerCreateInfoFB = 1000076001,
        [NativeName("Name", "XR_TYPE_BODY_JOINTS_LOCATE_INFO_FB")]
        BodyJointsLocateInfoFB = 1000076002,
        [NativeName("Name", "XR_TYPE_SYSTEM_BODY_TRACKING_PROPERTIES_FB")]
        SystemBodyTrackingPropertiesFB = 1000076004,
        [NativeName("Name", "XR_TYPE_BODY_JOINT_LOCATIONS_FB")]
        BodyJointLocationsFB = 1000076005,
        [NativeName("Name", "XR_TYPE_BODY_SKELETON_FB")]
        BodySkeletonFB = 1000076006,
        [NativeName("Name", "XR_TYPE_INTERACTION_PROFILE_DPAD_BINDING_EXT")]
        InteractionProfileDpadBindingExt = 1000078000,
        [NativeName("Name", "XR_TYPE_INTERACTION_PROFILE_ANALOG_THRESHOLD_VALVE")]
        InteractionProfileAnalogThresholdValve = 1000079000,
        [NativeName("Name", "XR_TYPE_HAND_JOINTS_MOTION_RANGE_INFO_EXT")]
        HandJointsMotionRangeInfoExt = 1000080000,
        [NativeName("Name", "XR_TYPE_LOADER_INIT_INFO_ANDROID_KHR")]
        LoaderInitInfoAndroidKhr = 1000089000,
        [NativeName("Name", "XR_TYPE_VULKAN_INSTANCE_CREATE_INFO_KHR")]
        VulkanInstanceCreateInfoKhr = 1000090000,
        [NativeName("Name", "XR_TYPE_VULKAN_DEVICE_CREATE_INFO_KHR")]
        VulkanDeviceCreateInfoKhr = 1000090001,
        [NativeName("Name", "XR_TYPE_VULKAN_GRAPHICS_DEVICE_GET_INFO_KHR")]
        VulkanGraphicsDeviceGetInfoKhr = 1000090003,
        [NativeName("Name", "XR_TYPE_GRAPHICS_BINDING_VULKAN2_KHR")]
        GraphicsBindingVulkan2Khr = 1000090000,
        [NativeName("Name", "XR_TYPE_SWAPCHAIN_IMAGE_VULKAN2_KHR")]
        SwapchainImageVulkan2Khr = 1000090001,
        [NativeName("Name", "XR_TYPE_GRAPHICS_REQUIREMENTS_VULKAN2_KHR")]
        GraphicsRequirementsVulkan2Khr = 1000090002,
        [NativeName("Name", "XR_TYPE_COMPOSITION_LAYER_EQUIRECT2_KHR")]
        CompositionLayerEquirect2Khr = 1000091000,
        [NativeName("Name", "XR_TYPE_SCENE_OBSERVER_CREATE_INFO_MSFT")]
        SceneObserverCreateInfoMsft = 1000097000,
        [NativeName("Name", "XR_TYPE_SCENE_CREATE_INFO_MSFT")]
        SceneCreateInfoMsft = 1000097001,
        [NativeName("Name", "XR_TYPE_NEW_SCENE_COMPUTE_INFO_MSFT")]
        NewSceneComputeInfoMsft = 1000097002,
        [NativeName("Name", "XR_TYPE_VISUAL_MESH_COMPUTE_LOD_INFO_MSFT")]
        VisualMeshComputeLodInfoMsft = 1000097003,
        [NativeName("Name", "XR_TYPE_SCENE_COMPONENTS_MSFT")]
        SceneComponentsMsft = 1000097004,
        [NativeName("Name", "XR_TYPE_SCENE_COMPONENTS_GET_INFO_MSFT")]
        SceneComponentsGetInfoMsft = 1000097005,
        [NativeName("Name", "XR_TYPE_SCENE_COMPONENT_LOCATIONS_MSFT")]
        SceneComponentLocationsMsft = 1000097006,
        [NativeName("Name", "XR_TYPE_SCENE_COMPONENTS_LOCATE_INFO_MSFT")]
        SceneComponentsLocateInfoMsft = 1000097007,
        [NativeName("Name", "XR_TYPE_SCENE_OBJECTS_MSFT")]
        SceneObjectsMsft = 1000097008,
        [NativeName("Name", "XR_TYPE_SCENE_COMPONENT_PARENT_FILTER_INFO_MSFT")]
        SceneComponentParentFilterInfoMsft = 1000097009,
        [NativeName("Name", "XR_TYPE_SCENE_OBJECT_TYPES_FILTER_INFO_MSFT")]
        SceneObjectTypesFilterInfoMsft = 1000097010,
        [NativeName("Name", "XR_TYPE_SCENE_PLANES_MSFT")]
        ScenePlanesMsft = 1000097011,
        [NativeName("Name", "XR_TYPE_SCENE_PLANE_ALIGNMENT_FILTER_INFO_MSFT")]
        ScenePlaneAlignmentFilterInfoMsft = 1000097012,
        [NativeName("Name", "XR_TYPE_SCENE_MESHES_MSFT")]
        SceneMeshesMsft = 1000097013,
        [NativeName("Name", "XR_TYPE_SCENE_MESH_BUFFERS_GET_INFO_MSFT")]
        SceneMeshBuffersGetInfoMsft = 1000097014,
        [NativeName("Name", "XR_TYPE_SCENE_MESH_BUFFERS_MSFT")]
        SceneMeshBuffersMsft = 1000097015,
        [NativeName("Name", "XR_TYPE_SCENE_MESH_VERTEX_BUFFER_MSFT")]
        SceneMeshVertexBufferMsft = 1000097016,
        [NativeName("Name", "XR_TYPE_SCENE_MESH_INDICES_UINT32_MSFT")]
        SceneMeshIndicesUint32Msft = 1000097017,
        [NativeName("Name", "XR_TYPE_SCENE_MESH_INDICES_UINT16_MSFT")]
        SceneMeshIndicesUint16Msft = 1000097018,
        [NativeName("Name", "XR_TYPE_SERIALIZED_SCENE_FRAGMENT_DATA_GET_INFO_MSFT")]
        SerializedSceneFragmentDataGetInfoMsft = 1000098000,
        [NativeName("Name", "XR_TYPE_SCENE_DESERIALIZE_INFO_MSFT")]
        SceneDeserializeInfoMsft = 1000098001,
        [NativeName("Name", "XR_TYPE_EVENT_DATA_DISPLAY_REFRESH_RATE_CHANGED_FB")]
        EventDataDisplayRefreshRateChangedFB = 1000101000,
        [NativeName("Name", "XR_TYPE_VIVE_TRACKER_PATHS_HTCX")]
        ViveTrackerPathsHtcx = 1000103000,
        [NativeName("Name", "XR_TYPE_EVENT_DATA_VIVE_TRACKER_CONNECTED_HTCX")]
        EventDataViveTrackerConnectedHtcx = 1000103001,
        [NativeName("Name", "XR_TYPE_SYSTEM_FACIAL_TRACKING_PROPERTIES_HTC")]
        SystemFacialTrackingPropertiesHtc = 1000104000,
        [NativeName("Name", "XR_TYPE_FACIAL_TRACKER_CREATE_INFO_HTC")]
        FacialTrackerCreateInfoHtc = 1000104001,
        [NativeName("Name", "XR_TYPE_FACIAL_EXPRESSIONS_HTC")]
        FacialExpressionsHtc = 1000104002,
        [NativeName("Name", "XR_TYPE_SYSTEM_COLOR_SPACE_PROPERTIES_FB")]
        SystemColorSpacePropertiesFB = 1000108000,
        [NativeName("Name", "XR_TYPE_HAND_TRACKING_MESH_FB")]
        HandTrackingMeshFB = 1000110001,
        [NativeName("Name", "XR_TYPE_HAND_TRACKING_SCALE_FB")]
        HandTrackingScaleFB = 1000110003,
        [NativeName("Name", "XR_TYPE_HAND_TRACKING_AIM_STATE_FB")]
        HandTrackingAimStateFB = 1000111001,
        [NativeName("Name", "XR_TYPE_HAND_TRACKING_CAPSULES_STATE_FB")]
        HandTrackingCapsulesStateFB = 1000112000,
        [NativeName("Name", "XR_TYPE_SYSTEM_SPATIAL_ENTITY_PROPERTIES_FB")]
        SystemSpatialEntityPropertiesFB = 1000113004,
        [NativeName("Name", "XR_TYPE_SPATIAL_ANCHOR_CREATE_INFO_FB")]
        SpatialAnchorCreateInfoFB = 1000113003,
        [NativeName("Name", "XR_TYPE_SPACE_COMPONENT_STATUS_SET_INFO_FB")]
        SpaceComponentStatusSetInfoFB = 1000113007,
        [NativeName("Name", "XR_TYPE_SPACE_COMPONENT_STATUS_FB")]
        SpaceComponentStatusFB = 1000113001,
        [NativeName("Name", "XR_TYPE_EVENT_DATA_SPATIAL_ANCHOR_CREATE_COMPLETE_FB")]
        EventDataSpatialAnchorCreateCompleteFB = 1000113005,
        [NativeName("Name", "XR_TYPE_EVENT_DATA_SPACE_SET_STATUS_COMPLETE_FB")]
        EventDataSpaceSetStatusCompleteFB = 1000113006,
        [NativeName("Name", "XR_TYPE_FOVEATION_PROFILE_CREATE_INFO_FB")]
        FoveationProfileCreateInfoFB = 1000114000,
        [NativeName("Name", "XR_TYPE_SWAPCHAIN_CREATE_INFO_FOVEATION_FB")]
        SwapchainCreateInfoFoveationFB = 1000114001,
        [NativeName("Name", "XR_TYPE_SWAPCHAIN_STATE_FOVEATION_FB")]
        SwapchainStateFoveationFB = 1000114002,
        [NativeName("Name", "XR_TYPE_FOVEATION_LEVEL_PROFILE_CREATE_INFO_FB")]
        FoveationLevelProfileCreateInfoFB = 1000115000,
        [NativeName("Name", "XR_TYPE_KEYBOARD_SPACE_CREATE_INFO_FB")]
        KeyboardSpaceCreateInfoFB = 1000116009,
        [NativeName("Name", "XR_TYPE_KEYBOARD_TRACKING_QUERY_FB")]
        KeyboardTrackingQueryFB = 1000116004,
        [NativeName("Name", "XR_TYPE_SYSTEM_KEYBOARD_TRACKING_PROPERTIES_FB")]
        SystemKeyboardTrackingPropertiesFB = 1000116002,
        [NativeName("Name", "XR_TYPE_TRIANGLE_MESH_CREATE_INFO_FB")]
        TriangleMeshCreateInfoFB = 1000117001,
        [NativeName("Name", "XR_TYPE_SYSTEM_PASSTHROUGH_PROPERTIES_FB")]
        SystemPassthroughPropertiesFB = 1000118000,
        [NativeName("Name", "XR_TYPE_PASSTHROUGH_CREATE_INFO_FB")]
        PassthroughCreateInfoFB = 1000118001,
        [NativeName("Name", "XR_TYPE_PASSTHROUGH_LAYER_CREATE_INFO_FB")]
        PassthroughLayerCreateInfoFB = 1000118002,
        [NativeName("Name", "XR_TYPE_COMPOSITION_LAYER_PASSTHROUGH_FB")]
        CompositionLayerPassthroughFB = 1000118003,
        [NativeName("Name", "XR_TYPE_GEOMETRY_INSTANCE_CREATE_INFO_FB")]
        GeometryInstanceCreateInfoFB = 1000118004,
        [NativeName("Name", "XR_TYPE_GEOMETRY_INSTANCE_TRANSFORM_FB")]
        GeometryInstanceTransformFB = 1000118005,
        [NativeName("Name", "XR_TYPE_SYSTEM_PASSTHROUGH_PROPERTIES2_FB")]
        SystemPassthroughProperties2FB = 1000118006,
        [NativeName("Name", "XR_TYPE_PASSTHROUGH_STYLE_FB")]
        PassthroughStyleFB = 1000118020,
        [NativeName("Name", "XR_TYPE_PASSTHROUGH_COLOR_MAP_MONO_TO_RGBA_FB")]
        PassthroughColorMapMonoToRgbaFB = 1000118021,
        [NativeName("Name", "XR_TYPE_PASSTHROUGH_COLOR_MAP_MONO_TO_MONO_FB")]
        PassthroughColorMapMonoToMonoFB = 1000118022,
        [NativeName("Name", "XR_TYPE_PASSTHROUGH_BRIGHTNESS_CONTRAST_SATURATION_FB")]
        PassthroughBrightnessContrastSaturationFB = 1000118023,
        [NativeName("Name", "XR_TYPE_EVENT_DATA_PASSTHROUGH_STATE_CHANGED_FB")]
        EventDataPassthroughStateChangedFB = 1000118030,
        [NativeName("Name", "XR_TYPE_RENDER_MODEL_PATH_INFO_FB")]
        RenderModelPathInfoFB = 1000119000,
        [NativeName("Name", "XR_TYPE_RENDER_MODEL_PROPERTIES_FB")]
        RenderModelPropertiesFB = 1000119001,
        [NativeName("Name", "XR_TYPE_RENDER_MODEL_BUFFER_FB")]
        RenderModelBufferFB = 1000119002,
        [NativeName("Name", "XR_TYPE_RENDER_MODEL_LOAD_INFO_FB")]
        RenderModelLoadInfoFB = 1000119003,
        [NativeName("Name", "XR_TYPE_SYSTEM_RENDER_MODEL_PROPERTIES_FB")]
        SystemRenderModelPropertiesFB = 1000119004,
        [NativeName("Name", "XR_TYPE_RENDER_MODEL_CAPABILITIES_REQUEST_FB")]
        RenderModelCapabilitiesRequestFB = 1000119005,
        [NativeName("Name", "XR_TYPE_BINDING_MODIFICATIONS_KHR")]
        BindingModificationsKhr = 1000120000,
        [NativeName("Name", "XR_TYPE_VIEW_LOCATE_FOVEATED_RENDERING_VARJO")]
        ViewLocateFoveatedRenderingVarjo = 1000121000,
        [NativeName("Name", "XR_TYPE_FOVEATED_VIEW_CONFIGURATION_VIEW_VARJO")]
        FoveatedViewConfigurationViewVarjo = 1000121001,
        [NativeName("Name", "XR_TYPE_SYSTEM_FOVEATED_RENDERING_PROPERTIES_VARJO")]
        SystemFoveatedRenderingPropertiesVarjo = 1000121002,
        [NativeName("Name", "XR_TYPE_COMPOSITION_LAYER_DEPTH_TEST_VARJO")]
        CompositionLayerDepthTestVarjo = 1000122000,
        [NativeName("Name", "XR_TYPE_SYSTEM_MARKER_TRACKING_PROPERTIES_VARJO")]
        SystemMarkerTrackingPropertiesVarjo = 1000124000,
        [NativeName("Name", "XR_TYPE_EVENT_DATA_MARKER_TRACKING_UPDATE_VARJO")]
        EventDataMarkerTrackingUpdateVarjo = 1000124001,
        [NativeName("Name", "XR_TYPE_MARKER_SPACE_CREATE_INFO_VARJO")]
        MarkerSpaceCreateInfoVarjo = 1000124002,
        [NativeName("Name", "XR_TYPE_FRAME_END_INFO_ML")]
        FrameEndInfoML = 1000135000,
        [NativeName("Name", "XR_TYPE_GLOBAL_DIMMER_FRAME_END_INFO_ML")]
        GlobalDimmerFrameEndInfoML = 1000136000,
        [NativeName("Name", "XR_TYPE_COORDINATE_SPACE_CREATE_INFO_ML")]
        CoordinateSpaceCreateInfoML = 1000137000,
        [NativeName("Name", "XR_TYPE_SYSTEM_MARKER_UNDERSTANDING_PROPERTIES_ML")]
        SystemMarkerUnderstandingPropertiesML = 1000138000,
        [NativeName("Name", "XR_TYPE_MARKER_DETECTOR_CREATE_INFO_ML")]
        MarkerDetectorCreateInfoML = 1000138001,
        [NativeName("Name", "XR_TYPE_MARKER_DETECTOR_ARUCO_INFO_ML")]
        MarkerDetectorArucoInfoML = 1000138002,
        [NativeName("Name", "XR_TYPE_MARKER_DETECTOR_SIZE_INFO_ML")]
        MarkerDetectorSizeInfoML = 1000138003,
        [NativeName("Name", "XR_TYPE_MARKER_DETECTOR_APRIL_TAG_INFO_ML")]
        MarkerDetectorAprilTagInfoML = 1000138004,
        [NativeName("Name", "XR_TYPE_MARKER_DETECTOR_CUSTOM_PROFILE_INFO_ML")]
        MarkerDetectorCustomProfileInfoML = 1000138005,
        [NativeName("Name", "XR_TYPE_MARKER_DETECTOR_SNAPSHOT_INFO_ML")]
        MarkerDetectorSnapshotInfoML = 1000138006,
        [NativeName("Name", "XR_TYPE_MARKER_DETECTOR_STATE_ML")]
        MarkerDetectorStateML = 1000138007,
        [NativeName("Name", "XR_TYPE_MARKER_SPACE_CREATE_INFO_ML")]
        MarkerSpaceCreateInfoML = 1000138008,
        [NativeName("Name", "XR_TYPE_LOCALIZATION_MAP_ML")]
        LocalizationMapML = 1000139000,
        [NativeName("Name", "XR_TYPE_EVENT_DATA_LOCALIZATION_CHANGED_ML")]
        EventDataLocalizationChangedML = 1000139001,
        [NativeName("Name", "XR_TYPE_MAP_LOCALIZATION_REQUEST_INFO_ML")]
        MapLocalizationRequestInfoML = 1000139002,
        [NativeName("Name", "XR_TYPE_LOCALIZATION_MAP_IMPORT_INFO_ML")]
        LocalizationMapImportInfoML = 1000139003,
        [NativeName("Name", "XR_TYPE_LOCALIZATION_ENABLE_EVENTS_INFO_ML")]
        LocalizationEnableEventsInfoML = 1000139004,
        [NativeName("Name", "XR_TYPE_SPATIAL_ANCHORS_CREATE_INFO_FROM_POSE_ML")]
        SpatialAnchorsCreateInfoFromPoseML = 1000140000,
        [NativeName("Name", "XR_TYPE_CREATE_SPATIAL_ANCHORS_COMPLETION_ML")]
        CreateSpatialAnchorsCompletionML = 1000140001,
        [NativeName("Name", "XR_TYPE_SPATIAL_ANCHOR_STATE_ML")]
        SpatialAnchorStateML = 1000140002,
        [NativeName("Name", "XR_TYPE_SPATIAL_ANCHORS_CREATE_STORAGE_INFO_ML")]
        SpatialAnchorsCreateStorageInfoML = 1000141000,
        [NativeName("Name", "XR_TYPE_SPATIAL_ANCHORS_QUERY_INFO_RADIUS_ML")]
        SpatialAnchorsQueryInfoRadiusML = 1000141001,
        [NativeName("Name", "XR_TYPE_SPATIAL_ANCHORS_QUERY_COMPLETION_ML")]
        SpatialAnchorsQueryCompletionML = 1000141002,
        [NativeName("Name", "XR_TYPE_SPATIAL_ANCHORS_CREATE_INFO_FROM_UUIDS_ML")]
        SpatialAnchorsCreateInfoFromUuidsML = 1000141003,
        [NativeName("Name", "XR_TYPE_SPATIAL_ANCHORS_PUBLISH_INFO_ML")]
        SpatialAnchorsPublishInfoML = 1000141004,
        [NativeName("Name", "XR_TYPE_SPATIAL_ANCHORS_PUBLISH_COMPLETION_ML")]
        SpatialAnchorsPublishCompletionML = 1000141005,
        [NativeName("Name", "XR_TYPE_SPATIAL_ANCHORS_DELETE_INFO_ML")]
        SpatialAnchorsDeleteInfoML = 1000141006,
        [NativeName("Name", "XR_TYPE_SPATIAL_ANCHORS_DELETE_COMPLETION_ML")]
        SpatialAnchorsDeleteCompletionML = 1000141007,
        [NativeName("Name", "XR_TYPE_SPATIAL_ANCHORS_UPDATE_EXPIRATION_INFO_ML")]
        SpatialAnchorsUpdateExpirationInfoML = 1000141008,
        [NativeName("Name", "XR_TYPE_SPATIAL_ANCHORS_UPDATE_EXPIRATION_COMPLETION_ML")]
        SpatialAnchorsUpdateExpirationCompletionML = 1000141009,
        [NativeName("Name", "XR_TYPE_SPATIAL_ANCHORS_PUBLISH_COMPLETION_DETAILS_ML")]
        SpatialAnchorsPublishCompletionDetailsML = 1000141010,
        [NativeName("Name", "XR_TYPE_SPATIAL_ANCHORS_DELETE_COMPLETION_DETAILS_ML")]
        SpatialAnchorsDeleteCompletionDetailsML = 1000141011,
        [NativeName("Name", "XR_TYPE_SPATIAL_ANCHORS_UPDATE_EXPIRATION_COMPLETION_DETAILS_ML")]
        SpatialAnchorsUpdateExpirationCompletionDetailsML = 1000141012,
        [NativeName("Name", "XR_TYPE_EVENT_DATA_HEADSET_FIT_CHANGED_ML")]
        EventDataHeadsetFitChangedML = 1000472000,
        [NativeName("Name", "XR_TYPE_EVENT_DATA_EYE_CALIBRATION_CHANGED_ML")]
        EventDataEyeCalibrationChangedML = 1000472001,
        [NativeName("Name", "XR_TYPE_USER_CALIBRATION_ENABLE_EVENTS_INFO_ML")]
        UserCalibrationEnableEventsInfoML = 1000472002,
        [NativeName("Name", "XR_TYPE_SPATIAL_ANCHOR_PERSISTENCE_INFO_MSFT")]
        SpatialAnchorPersistenceInfoMsft = 1000142000,
        [NativeName("Name", "XR_TYPE_SPATIAL_ANCHOR_FROM_PERSISTED_ANCHOR_CREATE_INFO_MSFT")]
        SpatialAnchorFromPersistedAnchorCreateInfoMsft = 1000142001,
        [NativeName("Name", "XR_TYPE_SCENE_MARKERS_MSFT")]
        SceneMarkersMsft = 1000147000,
        [NativeName("Name", "XR_TYPE_SCENE_MARKER_TYPE_FILTER_MSFT")]
        SceneMarkerTypeFilterMsft = 1000147001,
        [NativeName("Name", "XR_TYPE_SCENE_MARKER_QR_CODES_MSFT")]
        SceneMarkerQRCodesMsft = 1000147002,
        [NativeName("Name", "XR_TYPE_SPACE_QUERY_INFO_FB")]
        SpaceQueryInfoFB = 1000156001,
        [NativeName("Name", "XR_TYPE_SPACE_QUERY_RESULTS_FB")]
        SpaceQueryResultsFB = 1000156002,
        [NativeName("Name", "XR_TYPE_SPACE_STORAGE_LOCATION_FILTER_INFO_FB")]
        SpaceStorageLocationFilterInfoFB = 1000156003,
        [NativeName("Name", "XR_TYPE_SPACE_UUID_FILTER_INFO_FB")]
        SpaceUuidFilterInfoFB = 1000156054,
        [NativeName("Name", "XR_TYPE_SPACE_COMPONENT_FILTER_INFO_FB")]
        SpaceComponentFilterInfoFB = 1000156052,
        [NativeName("Name", "XR_TYPE_EVENT_DATA_SPACE_QUERY_RESULTS_AVAILABLE_FB")]
        EventDataSpaceQueryResultsAvailableFB = 1000156103,
        [NativeName("Name", "XR_TYPE_EVENT_DATA_SPACE_QUERY_COMPLETE_FB")]
        EventDataSpaceQueryCompleteFB = 1000156104,
        [NativeName("Name", "XR_TYPE_SPACE_SAVE_INFO_FB")]
        SpaceSaveInfoFB = 1000158000,
        [NativeName("Name", "XR_TYPE_SPACE_ERASE_INFO_FB")]
        SpaceEraseInfoFB = 1000158001,
        [NativeName("Name", "XR_TYPE_EVENT_DATA_SPACE_SAVE_COMPLETE_FB")]
        EventDataSpaceSaveCompleteFB = 1000158106,
        [NativeName("Name", "XR_TYPE_EVENT_DATA_SPACE_ERASE_COMPLETE_FB")]
        EventDataSpaceEraseCompleteFB = 1000158107,
        [NativeName("Name", "XR_TYPE_SWAPCHAIN_IMAGE_FOVEATION_VULKAN_FB")]
        SwapchainImageFoveationVulkanFB = 1000160000,
        [NativeName("Name", "XR_TYPE_SWAPCHAIN_STATE_ANDROID_SURFACE_DIMENSIONS_FB")]
        SwapchainStateAndroidSurfaceDimensionsFB = 1000161000,
        [NativeName("Name", "XR_TYPE_SWAPCHAIN_STATE_SAMPLER_OPENGL_ES_FB")]
        SwapchainStateSamplerOpenglESFB = 1000162000,
        [NativeName("Name", "XR_TYPE_SWAPCHAIN_STATE_SAMPLER_VULKAN_FB")]
        SwapchainStateSamplerVulkanFB = 1000163000,
        [NativeName("Name", "XR_TYPE_SPACE_SHARE_INFO_FB")]
        SpaceShareInfoFB = 1000169001,
        [NativeName("Name", "XR_TYPE_EVENT_DATA_SPACE_SHARE_COMPLETE_FB")]
        EventDataSpaceShareCompleteFB = 1000169002,
        [NativeName("Name", "XR_TYPE_COMPOSITION_LAYER_SPACE_WARP_INFO_FB")]
        CompositionLayerSpaceWarpInfoFB = 1000171000,
        [NativeName("Name", "XR_TYPE_SYSTEM_SPACE_WARP_PROPERTIES_FB")]
        SystemSpaceWarpPropertiesFB = 1000171001,
        [NativeName("Name", "XR_TYPE_HAPTIC_AMPLITUDE_ENVELOPE_VIBRATION_FB")]
        HapticAmplitudeEnvelopeVibrationFB = 1000173001,
        [NativeName("Name", "XR_TYPE_SEMANTIC_LABELS_FB")]
        SemanticLabelsFB = 1000175000,
        [NativeName("Name", "XR_TYPE_ROOM_LAYOUT_FB")]
        RoomLayoutFB = 1000175001,
        [NativeName("Name", "XR_TYPE_BOUNDARY_2D_FB")]
        Boundary2DFB = 1000175002,
        [NativeName("Name", "XR_TYPE_SEMANTIC_LABELS_SUPPORT_INFO_FB")]
        SemanticLabelsSupportInfoFB = 1000175010,
        [NativeName("Name", "XR_TYPE_DIGITAL_LENS_CONTROL_ALMALENCE")]
        DigitalLensControlAlmalence = 1000196000,
        [NativeName("Name", "XR_TYPE_EVENT_DATA_SCENE_CAPTURE_COMPLETE_FB")]
        EventDataSceneCaptureCompleteFB = 1000198001,
        [NativeName("Name", "XR_TYPE_SCENE_CAPTURE_REQUEST_INFO_FB")]
        SceneCaptureRequestInfoFB = 1000198050,
        [NativeName("Name", "XR_TYPE_SPACE_CONTAINER_FB")]
        SpaceContainerFB = 1000199000,
        [NativeName("Name", "XR_TYPE_FOVEATION_EYE_TRACKED_PROFILE_CREATE_INFO_META")]
        FoveationEyeTrackedProfileCreateInfoMeta = 1000200000,
        [NativeName("Name", "XR_TYPE_FOVEATION_EYE_TRACKED_STATE_META")]
        FoveationEyeTrackedStateMeta = 1000200001,
        [NativeName("Name", "XR_TYPE_SYSTEM_FOVEATION_EYE_TRACKED_PROPERTIES_META")]
        SystemFoveationEyeTrackedPropertiesMeta = 1000200002,
        [NativeName("Name", "XR_TYPE_SYSTEM_FACE_TRACKING_PROPERTIES_FB")]
        SystemFaceTrackingPropertiesFB = 1000201004,
        [NativeName("Name", "XR_TYPE_FACE_TRACKER_CREATE_INFO_FB")]
        FaceTrackerCreateInfoFB = 1000201005,
        [NativeName("Name", "XR_TYPE_FACE_EXPRESSION_INFO_FB")]
        FaceExpressionInfoFB = 1000201002,
        [NativeName("Name", "XR_TYPE_FACE_EXPRESSION_WEIGHTS_FB")]
        FaceExpressionWeightsFB = 1000201006,
        [NativeName("Name", "XR_TYPE_EYE_TRACKER_CREATE_INFO_FB")]
        EyeTrackerCreateInfoFB = 1000202001,
        [NativeName("Name", "XR_TYPE_EYE_GAZES_INFO_FB")]
        EyeGazesInfoFB = 1000202002,
        [NativeName("Name", "XR_TYPE_EYE_GAZES_FB")]
        EyeGazesFB = 1000202003,
        [NativeName("Name", "XR_TYPE_SYSTEM_EYE_TRACKING_PROPERTIES_FB")]
        SystemEyeTrackingPropertiesFB = 1000202004,
        [NativeName("Name", "XR_TYPE_PASSTHROUGH_KEYBOARD_HANDS_INTENSITY_FB")]
        PassthroughKeyboardHandsIntensityFB = 1000203002,
        [NativeName("Name", "XR_TYPE_COMPOSITION_LAYER_SETTINGS_FB")]
        CompositionLayerSettingsFB = 1000204000,
        [NativeName("Name", "XR_TYPE_HAPTIC_PCM_VIBRATION_FB")]
        HapticPcmVibrationFB = 1000209001,
        [NativeName("Name", "XR_TYPE_DEVICE_PCM_SAMPLE_RATE_STATE_FB")]
        DevicePcmSampleRateStateFB = 1000209002,
        [NativeName("Name", "XR_TYPE_DEVICE_PCM_SAMPLE_RATE_GET_INFO_FB")]
        DevicePcmSampleRateGetInfoFB = 1000209002,
        [NativeName("Name", "XR_TYPE_COMPOSITION_LAYER_DEPTH_TEST_FB")]
        CompositionLayerDepthTestFB = 1000212000,
        [NativeName("Name", "XR_TYPE_LOCAL_DIMMING_FRAME_END_INFO_META")]
        LocalDimmingFrameEndInfoMeta = 1000216000,
        [NativeName("Name", "XR_TYPE_PASSTHROUGH_PREFERENCES_META")]
        PassthroughPreferencesMeta = 1000217000,
        [NativeName("Name", "XR_TYPE_SYSTEM_VIRTUAL_KEYBOARD_PROPERTIES_META")]
        SystemVirtualKeyboardPropertiesMeta = 1000219001,
        [NativeName("Name", "XR_TYPE_VIRTUAL_KEYBOARD_CREATE_INFO_META")]
        VirtualKeyboardCreateInfoMeta = 1000219002,
        [NativeName("Name", "XR_TYPE_VIRTUAL_KEYBOARD_SPACE_CREATE_INFO_META")]
        VirtualKeyboardSpaceCreateInfoMeta = 1000219003,
        [NativeName("Name", "XR_TYPE_VIRTUAL_KEYBOARD_LOCATION_INFO_META")]
        VirtualKeyboardLocationInfoMeta = 1000219004,
        [NativeName("Name", "XR_TYPE_VIRTUAL_KEYBOARD_MODEL_VISIBILITY_SET_INFO_META")]
        VirtualKeyboardModelVisibilitySetInfoMeta = 1000219005,
        [NativeName("Name", "XR_TYPE_VIRTUAL_KEYBOARD_ANIMATION_STATE_META")]
        VirtualKeyboardAnimationStateMeta = 1000219006,
        [NativeName("Name", "XR_TYPE_VIRTUAL_KEYBOARD_MODEL_ANIMATION_STATES_META")]
        VirtualKeyboardModelAnimationStatesMeta = 1000219007,
        [NativeName("Name", "XR_TYPE_VIRTUAL_KEYBOARD_TEXTURE_DATA_META")]
        VirtualKeyboardTextureDataMeta = 1000219009,
        [NativeName("Name", "XR_TYPE_VIRTUAL_KEYBOARD_INPUT_INFO_META")]
        VirtualKeyboardInputInfoMeta = 1000219010,
        [NativeName("Name", "XR_TYPE_VIRTUAL_KEYBOARD_TEXT_CONTEXT_CHANGE_INFO_META")]
        VirtualKeyboardTextContextChangeInfoMeta = 1000219011,
        [NativeName("Name", "XR_TYPE_EVENT_DATA_VIRTUAL_KEYBOARD_COMMIT_TEXT_META")]
        EventDataVirtualKeyboardCommitTextMeta = 1000219014,
        [NativeName("Name", "XR_TYPE_EVENT_DATA_VIRTUAL_KEYBOARD_BACKSPACE_META")]
        EventDataVirtualKeyboardBackspaceMeta = 1000219015,
        [NativeName("Name", "XR_TYPE_EVENT_DATA_VIRTUAL_KEYBOARD_ENTER_META")]
        EventDataVirtualKeyboardEnterMeta = 1000219016,
        [NativeName("Name", "XR_TYPE_EVENT_DATA_VIRTUAL_KEYBOARD_SHOWN_META")]
        EventDataVirtualKeyboardShownMeta = 1000219017,
        [NativeName("Name", "XR_TYPE_EVENT_DATA_VIRTUAL_KEYBOARD_HIDDEN_META")]
        EventDataVirtualKeyboardHiddenMeta = 1000219018,
        [NativeName("Name", "XR_TYPE_EXTERNAL_CAMERA_OCULUS")]
        ExternalCameraOculus = 1000226000,
        [NativeName("Name", "XR_TYPE_VULKAN_SWAPCHAIN_CREATE_INFO_META")]
        VulkanSwapchainCreateInfoMeta = 1000227000,
        [NativeName("Name", "XR_TYPE_PERFORMANCE_METRICS_STATE_META")]
        PerformanceMetricsStateMeta = 1000232001,
        [NativeName("Name", "XR_TYPE_PERFORMANCE_METRICS_COUNTER_META")]
        PerformanceMetricsCounterMeta = 1000232002,
        [NativeName("Name", "XR_TYPE_SPACE_LIST_SAVE_INFO_FB")]
        SpaceListSaveInfoFB = 1000238000,
        [NativeName("Name", "XR_TYPE_EVENT_DATA_SPACE_LIST_SAVE_COMPLETE_FB")]
        EventDataSpaceListSaveCompleteFB = 1000238001,
        [NativeName("Name", "XR_TYPE_SPACE_USER_CREATE_INFO_FB")]
        SpaceUserCreateInfoFB = 1000241001,
        [NativeName("Name", "XR_TYPE_SYSTEM_HEADSET_ID_PROPERTIES_META")]
        SystemHeadsetIDPropertiesMeta = 1000245000,
        [NativeName("Name", "XR_TYPE_RECOMMENDED_LAYER_RESOLUTION_META")]
        RecommendedLayerResolutionMeta = 1000254000,
        [NativeName("Name", "XR_TYPE_RECOMMENDED_LAYER_RESOLUTION_GET_INFO_META")]
        RecommendedLayerResolutionGetInfoMeta = 1000254001,
        [NativeName("Name", "XR_TYPE_SYSTEM_PASSTHROUGH_COLOR_LUT_PROPERTIES_META")]
        SystemPassthroughColorLutPropertiesMeta = 1000266000,
        [NativeName("Name", "XR_TYPE_PASSTHROUGH_COLOR_LUT_CREATE_INFO_META")]
        PassthroughColorLutCreateInfoMeta = 1000266001,
        [NativeName("Name", "XR_TYPE_PASSTHROUGH_COLOR_LUT_UPDATE_INFO_META")]
        PassthroughColorLutUpdateInfoMeta = 1000266002,
        [NativeName("Name", "XR_TYPE_PASSTHROUGH_COLOR_MAP_LUT_META")]
        PassthroughColorMapLutMeta = 1000266100,
        [NativeName("Name", "XR_TYPE_PASSTHROUGH_COLOR_MAP_INTERPOLATED_LUT_META")]
        PassthroughColorMapInterpolatedLutMeta = 1000266101,
        [NativeName("Name", "XR_TYPE_SPACE_TRIANGLE_MESH_GET_INFO_META")]
        SpaceTriangleMeshGetInfoMeta = 1000269001,
        [NativeName("Name", "XR_TYPE_SPACE_TRIANGLE_MESH_META")]
        SpaceTriangleMeshMeta = 1000269002,
        [NativeName("Name", "XR_TYPE_SYSTEM_FACE_TRACKING_PROPERTIES2_FB")]
        SystemFaceTrackingProperties2FB = 1000287013,
        [NativeName("Name", "XR_TYPE_FACE_TRACKER_CREATE_INFO2_FB")]
        FaceTrackerCreateInfo2FB = 1000287014,
        [NativeName("Name", "XR_TYPE_FACE_EXPRESSION_INFO2_FB")]
        FaceExpressionInfo2FB = 1000287015,
        [NativeName("Name", "XR_TYPE_FACE_EXPRESSION_WEIGHTS2_FB")]
        FaceExpressionWeights2FB = 1000287016,
        [NativeName("Name", "XR_TYPE_ENVIRONMENT_DEPTH_PROVIDER_CREATE_INFO_META")]
        EnvironmentDepthProviderCreateInfoMeta = 1000291000,
        [NativeName("Name", "XR_TYPE_ENVIRONMENT_DEPTH_SWAPCHAIN_CREATE_INFO_META")]
        EnvironmentDepthSwapchainCreateInfoMeta = 1000291001,
        [NativeName("Name", "XR_TYPE_ENVIRONMENT_DEPTH_SWAPCHAIN_STATE_META")]
        EnvironmentDepthSwapchainStateMeta = 1000291002,
        [NativeName("Name", "XR_TYPE_ENVIRONMENT_DEPTH_IMAGE_ACQUIRE_INFO_META")]
        EnvironmentDepthImageAcquireInfoMeta = 1000291003,
        [NativeName("Name", "XR_TYPE_ENVIRONMENT_DEPTH_IMAGE_VIEW_META")]
        EnvironmentDepthImageViewMeta = 1000291004,
        [NativeName("Name", "XR_TYPE_ENVIRONMENT_DEPTH_IMAGE_META")]
        EnvironmentDepthImageMeta = 1000291005,
        [NativeName("Name", "XR_TYPE_ENVIRONMENT_DEPTH_HAND_REMOVAL_SET_INFO_META")]
        EnvironmentDepthHandRemovalSetInfoMeta = 1000291006,
        [NativeName("Name", "XR_TYPE_SYSTEM_ENVIRONMENT_DEPTH_PROPERTIES_META")]
        SystemEnvironmentDepthPropertiesMeta = 1000291007,
        [NativeName("Name", "XR_TYPE_PASSTHROUGH_CREATE_INFO_HTC")]
        PassthroughCreateInfoHtc = 1000317001,
        [NativeName("Name", "XR_TYPE_PASSTHROUGH_COLOR_HTC")]
        PassthroughColorHtc = 1000317002,
        [NativeName("Name", "XR_TYPE_PASSTHROUGH_MESH_TRANSFORM_INFO_HTC")]
        PassthroughMeshTransformInfoHtc = 1000317003,
        [NativeName("Name", "XR_TYPE_COMPOSITION_LAYER_PASSTHROUGH_HTC")]
        CompositionLayerPassthroughHtc = 1000317004,
        [NativeName("Name", "XR_TYPE_FOVEATION_APPLY_INFO_HTC")]
        FoveationApplyInfoHtc = 1000318000,
        [NativeName("Name", "XR_TYPE_FOVEATION_DYNAMIC_MODE_INFO_HTC")]
        FoveationDynamicModeInfoHtc = 1000318001,
        [NativeName("Name", "XR_TYPE_FOVEATION_CUSTOM_MODE_INFO_HTC")]
        FoveationCustomModeInfoHtc = 1000318002,
        [NativeName("Name", "XR_TYPE_SYSTEM_ANCHOR_PROPERTIES_HTC")]
        SystemAnchorPropertiesHtc = 1000319000,
        [NativeName("Name", "XR_TYPE_SPATIAL_ANCHOR_CREATE_INFO_HTC")]
        SpatialAnchorCreateInfoHtc = 1000319001,
        [NativeName("Name", "XR_TYPE_SYSTEM_BODY_TRACKING_PROPERTIES_HTC")]
        SystemBodyTrackingPropertiesHtc = 1000320000,
        [NativeName("Name", "XR_TYPE_BODY_TRACKER_CREATE_INFO_HTC")]
        BodyTrackerCreateInfoHtc = 1000320001,
        [NativeName("Name", "XR_TYPE_BODY_JOINTS_LOCATE_INFO_HTC")]
        BodyJointsLocateInfoHtc = 1000320002,
        [NativeName("Name", "XR_TYPE_BODY_JOINT_LOCATIONS_HTC")]
        BodyJointLocationsHtc = 1000320003,
        [NativeName("Name", "XR_TYPE_BODY_SKELETON_HTC")]
        BodySkeletonHtc = 1000320004,
        [NativeName("Name", "XR_TYPE_ACTIVE_ACTION_SET_PRIORITIES_EXT")]
        ActiveActionSetPrioritiesExt = 1000373000,
        [NativeName("Name", "XR_TYPE_SYSTEM_FORCE_FEEDBACK_CURL_PROPERTIES_MNDX")]
        SystemForceFeedbackCurlPropertiesMndx = 1000375000,
        [NativeName("Name", "XR_TYPE_FORCE_FEEDBACK_CURL_APPLY_LOCATIONS_MNDX")]
        ForceFeedbackCurlApplyLocationsMndx = 1000375001,
        [NativeName("Name", "XR_TYPE_HAND_TRACKING_DATA_SOURCE_INFO_EXT")]
        HandTrackingDataSourceInfoExt = 1000428000,
        [NativeName("Name", "XR_TYPE_HAND_TRACKING_DATA_SOURCE_STATE_EXT")]
        HandTrackingDataSourceStateExt = 1000428001,
        [NativeName("Name", "XR_TYPE_PLANE_DETECTOR_CREATE_INFO_EXT")]
        PlaneDetectorCreateInfoExt = 1000429001,
        [NativeName("Name", "XR_TYPE_PLANE_DETECTOR_BEGIN_INFO_EXT")]
        PlaneDetectorBeginInfoExt = 1000429002,
        [NativeName("Name", "XR_TYPE_PLANE_DETECTOR_GET_INFO_EXT")]
        PlaneDetectorGetInfoExt = 1000429003,
        [NativeName("Name", "XR_TYPE_PLANE_DETECTOR_LOCATIONS_EXT")]
        PlaneDetectorLocationsExt = 1000429004,
        [NativeName("Name", "XR_TYPE_PLANE_DETECTOR_LOCATION_EXT")]
        PlaneDetectorLocationExt = 1000429005,
        [NativeName("Name", "XR_TYPE_PLANE_DETECTOR_POLYGON_BUFFER_EXT")]
        PlaneDetectorPolygonBufferExt = 1000429006,
        [NativeName("Name", "XR_TYPE_SYSTEM_PLANE_DETECTION_PROPERTIES_EXT")]
        SystemPlaneDetectionPropertiesExt = 1000429007,
        [NativeName("Name", "XR_TYPE_FUTURE_CANCEL_INFO_EXT")]
        FutureCancelInfoExt = 1000469000,
        [NativeName("Name", "XR_TYPE_FUTURE_POLL_INFO_EXT")]
        FuturePollInfoExt = 1000469001,
        [NativeName("Name", "XR_TYPE_FUTURE_COMPLETION_EXT")]
        FutureCompletionExt = 1000469002,
        [NativeName("Name", "XR_TYPE_FUTURE_POLL_RESULT_EXT")]
        FuturePollResultExt = 1000469003,
        [NativeName("Name", "XR_TYPE_EVENT_DATA_USER_PRESENCE_CHANGED_EXT")]
        EventDataUserPresenceChangedExt = 1000470000,
        [NativeName("Name", "XR_TYPE_SYSTEM_USER_PRESENCE_PROPERTIES_EXT")]
        SystemUserPresencePropertiesExt = 1000470001,
        [NativeName("Name", "XR_TYPE_SPACES_LOCATE_INFO_KHR")]
        SpacesLocateInfoKhr = 1000471000,
        [NativeName("Name", "XR_TYPE_SPACE_LOCATIONS_KHR")]
        SpaceLocationsKhr = 1000471001,
        [NativeName("Name", "XR_TYPE_SPACE_VELOCITIES_KHR")]
        SpaceVelocitiesKhr = 1000471002,
        [NativeName("Name", "XR_TYPE_SYSTEM_NOTIFICATIONS_SET_INFO_ML")]
        SystemNotificationsSetInfoML = 1000473000,
        [NativeName("Name", "XR_TYPE_WORLD_MESH_DETECTOR_CREATE_INFO_ML")]
        WorldMeshDetectorCreateInfoML = 1000474001,
        [NativeName("Name", "XR_TYPE_WORLD_MESH_STATE_REQUEST_INFO_ML")]
        WorldMeshStateRequestInfoML = 1000474002,
        [NativeName("Name", "XR_TYPE_WORLD_MESH_BLOCK_STATE_ML")]
        WorldMeshBlockStateML = 1000474003,
        [NativeName("Name", "XR_TYPE_WORLD_MESH_STATE_REQUEST_COMPLETION_ML")]
        WorldMeshStateRequestCompletionML = 1000474004,
        [NativeName("Name", "XR_TYPE_WORLD_MESH_BUFFER_RECOMMENDED_SIZE_INFO_ML")]
        WorldMeshBufferRecommendedSizeInfoML = 1000474005,
        [NativeName("Name", "XR_TYPE_WORLD_MESH_BUFFER_SIZE_ML")]
        WorldMeshBufferSizeML = 1000474006,
        [NativeName("Name", "XR_TYPE_WORLD_MESH_BUFFER_ML")]
        WorldMeshBufferML = 1000474007,
        [NativeName("Name", "XR_TYPE_WORLD_MESH_BLOCK_REQUEST_ML")]
        WorldMeshBlockRequestML = 1000474008,
        [NativeName("Name", "XR_TYPE_WORLD_MESH_GET_INFO_ML")]
        WorldMeshGetInfoML = 1000474009,
        [NativeName("Name", "XR_TYPE_WORLD_MESH_BLOCK_ML")]
        WorldMeshBlockML = 1000474010,
        [NativeName("Name", "XR_TYPE_WORLD_MESH_REQUEST_COMPLETION_ML")]
        WorldMeshRequestCompletionML = 1000474011,
        [NativeName("Name", "XR_TYPE_WORLD_MESH_REQUEST_COMPLETION_INFO_ML")]
        WorldMeshRequestCompletionInfoML = 1000474012,
        [NativeName("Name", "XR_TYPE_SPACES_LOCATE_INFO")]
        SpacesLocateInfo = 1000471000,
        [NativeName("Name", "XR_TYPE_SPACE_LOCATIONS")]
        SpaceLocations = 1000471001,
        [NativeName("Name", "XR_TYPE_SPACE_VELOCITIES")]
        SpaceVelocities = 1000471002,
    }
}
