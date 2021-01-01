// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenXR
{
    [NativeName("Name", "XrStructureType")]
    public enum StructureType : int
    {
        [NativeName("Name", "XR_TYPE_UNKNOWN")]
        TypeUnknown = 0,
        [NativeName("Name", "XR_TYPE_API_LAYER_PROPERTIES")]
        TypeApiLayerProperties = 1,
        [NativeName("Name", "XR_TYPE_EXTENSION_PROPERTIES")]
        TypeExtensionProperties = 2,
        [NativeName("Name", "XR_TYPE_INSTANCE_CREATE_INFO")]
        TypeInstanceCreateInfo = 3,
        [NativeName("Name", "XR_TYPE_SYSTEM_GET_INFO")]
        TypeSystemGetInfo = 4,
        [NativeName("Name", "XR_TYPE_SYSTEM_PROPERTIES")]
        TypeSystemProperties = 5,
        [NativeName("Name", "XR_TYPE_VIEW_LOCATE_INFO")]
        TypeViewLocateInfo = 6,
        [NativeName("Name", "XR_TYPE_VIEW")]
        TypeView = 7,
        [NativeName("Name", "XR_TYPE_SESSION_CREATE_INFO")]
        TypeSessionCreateInfo = 8,
        [NativeName("Name", "XR_TYPE_SWAPCHAIN_CREATE_INFO")]
        TypeSwapchainCreateInfo = 9,
        [NativeName("Name", "XR_TYPE_SESSION_BEGIN_INFO")]
        TypeSessionBeginInfo = 10,
        [NativeName("Name", "XR_TYPE_VIEW_STATE")]
        TypeViewState = 11,
        [NativeName("Name", "XR_TYPE_FRAME_END_INFO")]
        TypeFrameEndInfo = 12,
        [NativeName("Name", "XR_TYPE_HAPTIC_VIBRATION")]
        TypeHapticVibration = 13,
        [NativeName("Name", "XR_TYPE_EVENT_DATA_BUFFER")]
        TypeEventDataBuffer = 16,
        [NativeName("Name", "XR_TYPE_EVENT_DATA_INSTANCE_LOSS_PENDING")]
        TypeEventDataInstanceLossPending = 17,
        [NativeName("Name", "XR_TYPE_EVENT_DATA_SESSION_STATE_CHANGED")]
        TypeEventDataSessionStateChanged = 18,
        [NativeName("Name", "XR_TYPE_ACTION_STATE_BOOLEAN")]
        TypeActionStateBoolean = 23,
        [NativeName("Name", "XR_TYPE_ACTION_STATE_FLOAT")]
        TypeActionStateFloat = 24,
        [NativeName("Name", "XR_TYPE_ACTION_STATE_VECTOR2F")]
        TypeActionStateVector2f = 25,
        [NativeName("Name", "XR_TYPE_ACTION_STATE_POSE")]
        TypeActionStatePose = 27,
        [NativeName("Name", "XR_TYPE_ACTION_SET_CREATE_INFO")]
        TypeActionSetCreateInfo = 28,
        [NativeName("Name", "XR_TYPE_ACTION_CREATE_INFO")]
        TypeActionCreateInfo = 29,
        [NativeName("Name", "XR_TYPE_INSTANCE_PROPERTIES")]
        TypeInstanceProperties = 32,
        [NativeName("Name", "XR_TYPE_FRAME_WAIT_INFO")]
        TypeFrameWaitInfo = 33,
        [NativeName("Name", "XR_TYPE_COMPOSITION_LAYER_PROJECTION")]
        TypeCompositionLayerProjection = 35,
        [NativeName("Name", "XR_TYPE_COMPOSITION_LAYER_QUAD")]
        TypeCompositionLayerQuad = 36,
        [NativeName("Name", "XR_TYPE_REFERENCE_SPACE_CREATE_INFO")]
        TypeReferenceSpaceCreateInfo = 37,
        [NativeName("Name", "XR_TYPE_ACTION_SPACE_CREATE_INFO")]
        TypeActionSpaceCreateInfo = 38,
        [NativeName("Name", "XR_TYPE_EVENT_DATA_REFERENCE_SPACE_CHANGE_PENDING")]
        TypeEventDataReferenceSpaceChangePending = 40,
        [NativeName("Name", "XR_TYPE_VIEW_CONFIGURATION_VIEW")]
        TypeViewConfigurationView = 41,
        [NativeName("Name", "XR_TYPE_SPACE_LOCATION")]
        TypeSpaceLocation = 42,
        [NativeName("Name", "XR_TYPE_SPACE_VELOCITY")]
        TypeSpaceVelocity = 43,
        [NativeName("Name", "XR_TYPE_FRAME_STATE")]
        TypeFrameState = 44,
        [NativeName("Name", "XR_TYPE_VIEW_CONFIGURATION_PROPERTIES")]
        TypeViewConfigurationProperties = 45,
        [NativeName("Name", "XR_TYPE_FRAME_BEGIN_INFO")]
        TypeFrameBeginInfo = 46,
        [NativeName("Name", "XR_TYPE_COMPOSITION_LAYER_PROJECTION_VIEW")]
        TypeCompositionLayerProjectionView = 48,
        [NativeName("Name", "XR_TYPE_EVENT_DATA_EVENTS_LOST")]
        TypeEventDataEventsLost = 49,
        [NativeName("Name", "XR_TYPE_INTERACTION_PROFILE_SUGGESTED_BINDING")]
        TypeInteractionProfileSuggestedBinding = 51,
        [NativeName("Name", "XR_TYPE_EVENT_DATA_INTERACTION_PROFILE_CHANGED")]
        TypeEventDataInteractionProfileChanged = 52,
        [NativeName("Name", "XR_TYPE_INTERACTION_PROFILE_STATE")]
        TypeInteractionProfileState = 53,
        [NativeName("Name", "XR_TYPE_SWAPCHAIN_IMAGE_ACQUIRE_INFO")]
        TypeSwapchainImageAcquireInfo = 55,
        [NativeName("Name", "XR_TYPE_SWAPCHAIN_IMAGE_WAIT_INFO")]
        TypeSwapchainImageWaitInfo = 56,
        [NativeName("Name", "XR_TYPE_SWAPCHAIN_IMAGE_RELEASE_INFO")]
        TypeSwapchainImageReleaseInfo = 57,
        [NativeName("Name", "XR_TYPE_ACTION_STATE_GET_INFO")]
        TypeActionStateGetInfo = 58,
        [NativeName("Name", "XR_TYPE_HAPTIC_ACTION_INFO")]
        TypeHapticActionInfo = 59,
        [NativeName("Name", "XR_TYPE_SESSION_ACTION_SETS_ATTACH_INFO")]
        TypeSessionActionSetsAttachInfo = 60,
        [NativeName("Name", "XR_TYPE_ACTIONS_SYNC_INFO")]
        TypeActionsSyncInfo = 61,
        [NativeName("Name", "XR_TYPE_BOUND_SOURCES_FOR_ACTION_ENUMERATE_INFO")]
        TypeBoundSourcesForActionEnumerateInfo = 62,
        [NativeName("Name", "XR_TYPE_INPUT_SOURCE_LOCALIZED_NAME_GET_INFO")]
        TypeInputSourceLocalizedNameGetInfo = 63,
        [NativeName("Name", "XR_TYPE_COMPOSITION_LAYER_CUBE_KHR")]
        TypeCompositionLayerCubeKhr = 1000006000,
        [NativeName("Name", "XR_TYPE_INSTANCE_CREATE_INFO_ANDROID_KHR")]
        TypeInstanceCreateInfoAndroidKhr = 1000008000,
        [NativeName("Name", "XR_TYPE_COMPOSITION_LAYER_DEPTH_INFO_KHR")]
        TypeCompositionLayerDepthInfoKhr = 1000010000,
        [NativeName("Name", "XR_TYPE_VULKAN_SWAPCHAIN_FORMAT_LIST_CREATE_INFO_KHR")]
        TypeVulkanSwapchainFormatListCreateInfoKhr = 1000014000,
        [NativeName("Name", "XR_TYPE_EVENT_DATA_PERF_SETTINGS_EXT")]
        TypeEventDataPerfSettingsExt = 1000015000,
        [NativeName("Name", "XR_TYPE_COMPOSITION_LAYER_CYLINDER_KHR")]
        TypeCompositionLayerCylinderKhr = 1000017000,
        [NativeName("Name", "XR_TYPE_COMPOSITION_LAYER_EQUIRECT_KHR")]
        TypeCompositionLayerEquirectKhr = 1000018000,
        [NativeName("Name", "XR_TYPE_DEBUG_UTILS_OBJECT_NAME_INFO_EXT")]
        TypeDebugUtilsObjectNameInfoExt = 1000019000,
        [NativeName("Name", "XR_TYPE_DEBUG_UTILS_MESSENGER_CALLBACK_DATA_EXT")]
        TypeDebugUtilsMessengerCallbackDataExt = 1000019001,
        [NativeName("Name", "XR_TYPE_DEBUG_UTILS_MESSENGER_CREATE_INFO_EXT")]
        TypeDebugUtilsMessengerCreateInfoExt = 1000019002,
        [NativeName("Name", "XR_TYPE_DEBUG_UTILS_LABEL_EXT")]
        TypeDebugUtilsLabelExt = 1000019003,
        [NativeName("Name", "XR_TYPE_GRAPHICS_BINDING_OPENGL_WIN32_KHR")]
        TypeGraphicsBindingOpenglWin32Khr = 1000023000,
        [NativeName("Name", "XR_TYPE_GRAPHICS_BINDING_OPENGL_XLIB_KHR")]
        TypeGraphicsBindingOpenglXlibKhr = 1000023001,
        [NativeName("Name", "XR_TYPE_GRAPHICS_BINDING_OPENGL_XCB_KHR")]
        TypeGraphicsBindingOpenglXcbKhr = 1000023002,
        [NativeName("Name", "XR_TYPE_GRAPHICS_BINDING_OPENGL_WAYLAND_KHR")]
        TypeGraphicsBindingOpenglWaylandKhr = 1000023003,
        [NativeName("Name", "XR_TYPE_SWAPCHAIN_IMAGE_OPENGL_KHR")]
        TypeSwapchainImageOpenglKhr = 1000023004,
        [NativeName("Name", "XR_TYPE_GRAPHICS_REQUIREMENTS_OPENGL_KHR")]
        TypeGraphicsRequirementsOpenglKhr = 1000023005,
        [NativeName("Name", "XR_TYPE_GRAPHICS_BINDING_OPENGL_ES_ANDROID_KHR")]
        TypeGraphicsBindingOpenglESAndroidKhr = 1000024001,
        [NativeName("Name", "XR_TYPE_SWAPCHAIN_IMAGE_OPENGL_ES_KHR")]
        TypeSwapchainImageOpenglESKhr = 1000024002,
        [NativeName("Name", "XR_TYPE_GRAPHICS_REQUIREMENTS_OPENGL_ES_KHR")]
        TypeGraphicsRequirementsOpenglESKhr = 1000024003,
        [NativeName("Name", "XR_TYPE_GRAPHICS_BINDING_VULKAN_KHR")]
        TypeGraphicsBindingVulkanKhr = 1000025000,
        [NativeName("Name", "XR_TYPE_SWAPCHAIN_IMAGE_VULKAN_KHR")]
        TypeSwapchainImageVulkanKhr = 1000025001,
        [NativeName("Name", "XR_TYPE_GRAPHICS_REQUIREMENTS_VULKAN_KHR")]
        TypeGraphicsRequirementsVulkanKhr = 1000025002,
        [NativeName("Name", "XR_TYPE_GRAPHICS_BINDING_D3D11_KHR")]
        TypeGraphicsBindingD3D11Khr = 1000027000,
        [NativeName("Name", "XR_TYPE_SWAPCHAIN_IMAGE_D3D11_KHR")]
        TypeSwapchainImageD3D11Khr = 1000027001,
        [NativeName("Name", "XR_TYPE_GRAPHICS_REQUIREMENTS_D3D11_KHR")]
        TypeGraphicsRequirementsD3D11Khr = 1000027002,
        [NativeName("Name", "XR_TYPE_GRAPHICS_BINDING_D3D12_KHR")]
        TypeGraphicsBindingD3D12Khr = 1000028000,
        [NativeName("Name", "XR_TYPE_SWAPCHAIN_IMAGE_D3D12_KHR")]
        TypeSwapchainImageD3D12Khr = 1000028001,
        [NativeName("Name", "XR_TYPE_GRAPHICS_REQUIREMENTS_D3D12_KHR")]
        TypeGraphicsRequirementsD3D12Khr = 1000028002,
        [NativeName("Name", "XR_TYPE_SYSTEM_EYE_GAZE_INTERACTION_PROPERTIES_EXT")]
        TypeSystemEyeGazeInteractionPropertiesExt = 1000030000,
        [NativeName("Name", "XR_TYPE_EYE_GAZE_SAMPLE_TIME_EXT")]
        TypeEyeGazeSampleTimeExt = 1000030001,
        [NativeName("Name", "XR_TYPE_VISIBILITY_MASK_KHR")]
        TypeVisibilityMaskKhr = 1000031000,
        [NativeName("Name", "XR_TYPE_EVENT_DATA_VISIBILITY_MASK_CHANGED_KHR")]
        TypeEventDataVisibilityMaskChangedKhr = 1000031001,
        [NativeName("Name", "XR_TYPE_SESSION_CREATE_INFO_OVERLAY_EXTX")]
        TypeSessionCreateInfoOverlayExtx = 1000033000,
        [NativeName("Name", "XR_TYPE_EVENT_DATA_MAIN_SESSION_VISIBILITY_CHANGED_EXTX")]
        TypeEventDataMainSessionVisibilityChangedExtx = 1000033003,
        [NativeName("Name", "XR_TYPE_COMPOSITION_LAYER_COLOR_SCALE_BIAS_KHR")]
        TypeCompositionLayerColorScaleBiasKhr = 1000034000,
        [NativeName("Name", "XR_TYPE_SPATIAL_ANCHOR_CREATE_INFO_MSFT")]
        TypeSpatialAnchorCreateInfoMsft = 1000039000,
        [NativeName("Name", "XR_TYPE_SPATIAL_ANCHOR_SPACE_CREATE_INFO_MSFT")]
        TypeSpatialAnchorSpaceCreateInfoMsft = 1000039001,
        [NativeName("Name", "XR_TYPE_VIEW_CONFIGURATION_DEPTH_RANGE_EXT")]
        TypeViewConfigurationDepthRangeExt = 1000046000,
        [NativeName("Name", "XR_TYPE_GRAPHICS_BINDING_EGL_MNDX")]
        TypeGraphicsBindingEglMndx = 1000048004,
        [NativeName("Name", "XR_TYPE_SPATIAL_GRAPH_NODE_SPACE_CREATE_INFO_MSFT")]
        TypeSpatialGraphNodeSpaceCreateInfoMsft = 1000049000,
        [NativeName("Name", "XR_TYPE_SYSTEM_HAND_TRACKING_PROPERTIES_EXT")]
        TypeSystemHandTrackingPropertiesExt = 1000051000,
        [NativeName("Name", "XR_TYPE_HAND_TRACKER_CREATE_INFO_EXT")]
        TypeHandTrackerCreateInfoExt = 1000051001,
        [NativeName("Name", "XR_TYPE_HAND_JOINTS_LOCATE_INFO_EXT")]
        TypeHandJointsLocateInfoExt = 1000051002,
        [NativeName("Name", "XR_TYPE_HAND_JOINT_LOCATIONS_EXT")]
        TypeHandJointLocationsExt = 1000051003,
        [NativeName("Name", "XR_TYPE_HAND_JOINT_VELOCITIES_EXT")]
        TypeHandJointVelocitiesExt = 1000051004,
        [NativeName("Name", "XR_TYPE_SYSTEM_HAND_TRACKING_MESH_PROPERTIES_MSFT")]
        TypeSystemHandTrackingMeshPropertiesMsft = 1000052000,
        [NativeName("Name", "XR_TYPE_HAND_MESH_SPACE_CREATE_INFO_MSFT")]
        TypeHandMeshSpaceCreateInfoMsft = 1000052001,
        [NativeName("Name", "XR_TYPE_HAND_MESH_UPDATE_INFO_MSFT")]
        TypeHandMeshUpdateInfoMsft = 1000052002,
        [NativeName("Name", "XR_TYPE_HAND_MESH_MSFT")]
        TypeHandMeshMsft = 1000052003,
        [NativeName("Name", "XR_TYPE_HAND_POSE_TYPE_INFO_MSFT")]
        TypeHandPoseTypeInfoMsft = 1000052004,
        [NativeName("Name", "XR_TYPE_SECONDARY_VIEW_CONFIGURATION_SESSION_BEGIN_INFO_MSFT")]
        TypeSecondaryViewConfigurationSessionBeginInfoMsft = 1000053000,
        [NativeName("Name", "XR_TYPE_SECONDARY_VIEW_CONFIGURATION_STATE_MSFT")]
        TypeSecondaryViewConfigurationStateMsft = 1000053001,
        [NativeName("Name", "XR_TYPE_SECONDARY_VIEW_CONFIGURATION_FRAME_STATE_MSFT")]
        TypeSecondaryViewConfigurationFrameStateMsft = 1000053002,
        [NativeName("Name", "XR_TYPE_SECONDARY_VIEW_CONFIGURATION_FRAME_END_INFO_MSFT")]
        TypeSecondaryViewConfigurationFrameEndInfoMsft = 1000053003,
        [NativeName("Name", "XR_TYPE_SECONDARY_VIEW_CONFIGURATION_LAYER_INFO_MSFT")]
        TypeSecondaryViewConfigurationLayerInfoMsft = 1000053004,
        [NativeName("Name", "XR_TYPE_SECONDARY_VIEW_CONFIGURATION_SWAPCHAIN_CREATE_INFO_MSFT")]
        TypeSecondaryViewConfigurationSwapchainCreateInfoMsft = 1000053005,
        [NativeName("Name", "XR_TYPE_CONTROLLER_MODEL_KEY_STATE_MSFT")]
        TypeControllerModelKeyStateMsft = 1000055000,
        [NativeName("Name", "XR_TYPE_CONTROLLER_MODEL_NODE_PROPERTIES_MSFT")]
        TypeControllerModelNodePropertiesMsft = 1000055001,
        [NativeName("Name", "XR_TYPE_CONTROLLER_MODEL_PROPERTIES_MSFT")]
        TypeControllerModelPropertiesMsft = 1000055002,
        [NativeName("Name", "XR_TYPE_CONTROLLER_MODEL_NODE_STATE_MSFT")]
        TypeControllerModelNodeStateMsft = 1000055003,
        [NativeName("Name", "XR_TYPE_CONTROLLER_MODEL_STATE_MSFT")]
        TypeControllerModelStateMsft = 1000055004,
        [NativeName("Name", "XR_TYPE_VIEW_CONFIGURATION_VIEW_FOV_EPIC")]
        TypeViewConfigurationViewFovEpic = 1000059000,
        [NativeName("Name", "XR_TYPE_HOLOGRAPHIC_WINDOW_ATTACHMENT_MSFT")]
        TypeHolographicWindowAttachmentMsft = 1000063000,
        [NativeName("Name", "XR_TYPE_INTERACTION_PROFILE_ANALOG_THRESHOLD_VALVE")]
        TypeInteractionProfileAnalogThresholdValve = 1000079000,
        [NativeName("Name", "XR_TYPE_LOADER_INIT_INFO_ANDROID_KHR")]
        TypeLoaderInitInfoAndroidKhr = 1000089000,
        [NativeName("Name", "XR_TYPE_VULKAN_INSTANCE_CREATE_INFO_KHR")]
        TypeVulkanInstanceCreateInfoKhr = 1000090000,
        [NativeName("Name", "XR_TYPE_VULKAN_DEVICE_CREATE_INFO_KHR")]
        TypeVulkanDeviceCreateInfoKhr = 1000090001,
        [NativeName("Name", "XR_TYPE_VULKAN_GRAPHICS_DEVICE_GET_INFO_KHR")]
        TypeVulkanGraphicsDeviceGetInfoKhr = 1000090003,
        [NativeName("Name", "XR_TYPE_GRAPHICS_BINDING_VULKAN2_KHR")]
        TypeGraphicsBindingVulkan2Khr = 1000090000,
        [NativeName("Name", "XR_TYPE_SWAPCHAIN_IMAGE_VULKAN2_KHR")]
        TypeSwapchainImageVulkan2Khr = 1000090001,
        [NativeName("Name", "XR_TYPE_GRAPHICS_REQUIREMENTS_VULKAN2_KHR")]
        TypeGraphicsRequirementsVulkan2Khr = 1000090002,
        [NativeName("Name", "XR_TYPE_COMPOSITION_LAYER_EQUIRECT2_KHR")]
        TypeCompositionLayerEquirect2Khr = 1000091000,
        [NativeName("Name", "XR_TYPE_EVENT_DATA_DISPLAY_REFRESH_RATE_CHANGED_FB")]
        TypeEventDataDisplayRefreshRateChangedFB = 1000101000,
        [NativeName("Name", "XR_TYPE_SYSTEM_COLOR_SPACE_PROPERTIES_FB")]
        TypeSystemColorSpacePropertiesFB = 1000108000,
        [NativeName("Name", "XR_TYPE_BINDING_MODIFICATIONS_KHR")]
        TypeBindingModificationsKhr = 1000120000,
    }
}
