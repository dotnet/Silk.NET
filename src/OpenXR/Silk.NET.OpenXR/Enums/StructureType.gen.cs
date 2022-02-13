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
        [NativeName("Name", "XR_TYPE_COMPOSITION_LAYER_IMAGE_LAYOUT_FB")]
        TypeCompositionLayerImageLayoutFB = 1000040000,
        [NativeName("Name", "XR_TYPE_COMPOSITION_LAYER_ALPHA_BLEND_FB")]
        TypeCompositionLayerAlphaBlendFB = 1000041001,
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
        [NativeName("Name", "XR_TYPE_COMPOSITION_LAYER_REPROJECTION_INFO_MSFT")]
        TypeCompositionLayerReprojectionInfoMsft = 1000066000,
        [NativeName("Name", "XR_TYPE_COMPOSITION_LAYER_REPROJECTION_PLANE_OVERRIDE_MSFT")]
        TypeCompositionLayerReprojectionPlaneOverrideMsft = 1000066001,
        [NativeName("Name", "XR_TYPE_ANDROID_SURFACE_SWAPCHAIN_CREATE_INFO_FB")]
        TypeAndroidSurfaceSwapchainCreateInfoFB = 1000070000,
        [NativeName("Name", "XR_TYPE_COMPOSITION_LAYER_SECURE_CONTENT_FB")]
        TypeCompositionLayerSecureContentFB = 1000072000,
        [NativeName("Name", "XR_TYPE_INTERACTION_PROFILE_ANALOG_THRESHOLD_VALVE")]
        TypeInteractionProfileAnalogThresholdValve = 1000079000,
        [NativeName("Name", "XR_TYPE_HAND_JOINTS_MOTION_RANGE_INFO_EXT")]
        TypeHandJointsMotionRangeInfoExt = 1000080000,
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
        [NativeName("Name", "XR_TYPE_SCENE_OBSERVER_CREATE_INFO_MSFT")]
        TypeSceneObserverCreateInfoMsft = 1000097000,
        [NativeName("Name", "XR_TYPE_SCENE_CREATE_INFO_MSFT")]
        TypeSceneCreateInfoMsft = 1000097001,
        [NativeName("Name", "XR_TYPE_NEW_SCENE_COMPUTE_INFO_MSFT")]
        TypeNewSceneComputeInfoMsft = 1000097002,
        [NativeName("Name", "XR_TYPE_VISUAL_MESH_COMPUTE_LOD_INFO_MSFT")]
        TypeVisualMeshComputeLodInfoMsft = 1000097003,
        [NativeName("Name", "XR_TYPE_SCENE_COMPONENTS_MSFT")]
        TypeSceneComponentsMsft = 1000097004,
        [NativeName("Name", "XR_TYPE_SCENE_COMPONENTS_GET_INFO_MSFT")]
        TypeSceneComponentsGetInfoMsft = 1000097005,
        [NativeName("Name", "XR_TYPE_SCENE_COMPONENT_LOCATIONS_MSFT")]
        TypeSceneComponentLocationsMsft = 1000097006,
        [NativeName("Name", "XR_TYPE_SCENE_COMPONENTS_LOCATE_INFO_MSFT")]
        TypeSceneComponentsLocateInfoMsft = 1000097007,
        [NativeName("Name", "XR_TYPE_SCENE_OBJECTS_MSFT")]
        TypeSceneObjectsMsft = 1000097008,
        [NativeName("Name", "XR_TYPE_SCENE_COMPONENT_PARENT_FILTER_INFO_MSFT")]
        TypeSceneComponentParentFilterInfoMsft = 1000097009,
        [NativeName("Name", "XR_TYPE_SCENE_OBJECT_TYPES_FILTER_INFO_MSFT")]
        TypeSceneObjectTypesFilterInfoMsft = 1000097010,
        [NativeName("Name", "XR_TYPE_SCENE_PLANES_MSFT")]
        TypeScenePlanesMsft = 1000097011,
        [NativeName("Name", "XR_TYPE_SCENE_PLANE_ALIGNMENT_FILTER_INFO_MSFT")]
        TypeScenePlaneAlignmentFilterInfoMsft = 1000097012,
        [NativeName("Name", "XR_TYPE_SCENE_MESHES_MSFT")]
        TypeSceneMeshesMsft = 1000097013,
        [NativeName("Name", "XR_TYPE_SCENE_MESH_BUFFERS_GET_INFO_MSFT")]
        TypeSceneMeshBuffersGetInfoMsft = 1000097014,
        [NativeName("Name", "XR_TYPE_SCENE_MESH_BUFFERS_MSFT")]
        TypeSceneMeshBuffersMsft = 1000097015,
        [NativeName("Name", "XR_TYPE_SCENE_MESH_VERTEX_BUFFER_MSFT")]
        TypeSceneMeshVertexBufferMsft = 1000097016,
        [NativeName("Name", "XR_TYPE_SCENE_MESH_INDICES_UINT32_MSFT")]
        TypeSceneMeshIndicesUint32Msft = 1000097017,
        [NativeName("Name", "XR_TYPE_SCENE_MESH_INDICES_UINT16_MSFT")]
        TypeSceneMeshIndicesUint16Msft = 1000097018,
        [NativeName("Name", "XR_TYPE_SERIALIZED_SCENE_FRAGMENT_DATA_GET_INFO_MSFT")]
        TypeSerializedSceneFragmentDataGetInfoMsft = 1000098000,
        [NativeName("Name", "XR_TYPE_SCENE_DESERIALIZE_INFO_MSFT")]
        TypeSceneDeserializeInfoMsft = 1000098001,
        [NativeName("Name", "XR_TYPE_EVENT_DATA_DISPLAY_REFRESH_RATE_CHANGED_FB")]
        TypeEventDataDisplayRefreshRateChangedFB = 1000101000,
        [NativeName("Name", "XR_TYPE_VIVE_TRACKER_PATHS_HTCX")]
        TypeViveTrackerPathsHtcx = 1000103000,
        [NativeName("Name", "XR_TYPE_EVENT_DATA_VIVE_TRACKER_CONNECTED_HTCX")]
        TypeEventDataViveTrackerConnectedHtcx = 1000103001,
        [NativeName("Name", "XR_TYPE_SYSTEM_FACIAL_TRACKING_PROPERTIES_HTC")]
        TypeSystemFacialTrackingPropertiesHtc = 1000104000,
        [NativeName("Name", "XR_TYPE_FACIAL_TRACKER_CREATE_INFO_HTC")]
        TypeFacialTrackerCreateInfoHtc = 1000104001,
        [NativeName("Name", "XR_TYPE_FACIAL_EXPRESSIONS_HTC")]
        TypeFacialExpressionsHtc = 1000104002,
        [NativeName("Name", "XR_TYPE_SYSTEM_COLOR_SPACE_PROPERTIES_FB")]
        TypeSystemColorSpacePropertiesFB = 1000108000,
        [NativeName("Name", "XR_TYPE_HAND_TRACKING_MESH_FB")]
        TypeHandTrackingMeshFB = 1000110001,
        [NativeName("Name", "XR_TYPE_HAND_TRACKING_SCALE_FB")]
        TypeHandTrackingScaleFB = 1000110003,
        [NativeName("Name", "XR_TYPE_HAND_TRACKING_AIM_STATE_FB")]
        TypeHandTrackingAimStateFB = 1000111001,
        [NativeName("Name", "XR_TYPE_HAND_TRACKING_CAPSULES_STATE_FB")]
        TypeHandTrackingCapsulesStateFB = 1000112000,
        [NativeName("Name", "XR_TYPE_FOVEATION_PROFILE_CREATE_INFO_FB")]
        TypeFoveationProfileCreateInfoFB = 1000114000,
        [NativeName("Name", "XR_TYPE_SWAPCHAIN_CREATE_INFO_FOVEATION_FB")]
        TypeSwapchainCreateInfoFoveationFB = 1000114001,
        [NativeName("Name", "XR_TYPE_SWAPCHAIN_STATE_FOVEATION_FB")]
        TypeSwapchainStateFoveationFB = 1000114002,
        [NativeName("Name", "XR_TYPE_FOVEATION_LEVEL_PROFILE_CREATE_INFO_FB")]
        TypeFoveationLevelProfileCreateInfoFB = 1000115000,
        [NativeName("Name", "XR_TYPE_KEYBOARD_SPACE_CREATE_INFO_FB")]
        TypeKeyboardSpaceCreateInfoFB = 1000116009,
        [NativeName("Name", "XR_TYPE_KEYBOARD_TRACKING_QUERY_FB")]
        TypeKeyboardTrackingQueryFB = 1000116004,
        [NativeName("Name", "XR_TYPE_SYSTEM_KEYBOARD_TRACKING_PROPERTIES_FB")]
        TypeSystemKeyboardTrackingPropertiesFB = 1000116002,
        [NativeName("Name", "XR_TYPE_TRIANGLE_MESH_CREATE_INFO_FB")]
        TypeTriangleMeshCreateInfoFB = 1000117001,
        [NativeName("Name", "XR_TYPE_SYSTEM_PASSTHROUGH_PROPERTIES_FB")]
        TypeSystemPassthroughPropertiesFB = 1000118000,
        [NativeName("Name", "XR_TYPE_PASSTHROUGH_CREATE_INFO_FB")]
        TypePassthroughCreateInfoFB = 1000118001,
        [NativeName("Name", "XR_TYPE_PASSTHROUGH_LAYER_CREATE_INFO_FB")]
        TypePassthroughLayerCreateInfoFB = 1000118002,
        [NativeName("Name", "XR_TYPE_COMPOSITION_LAYER_PASSTHROUGH_FB")]
        TypeCompositionLayerPassthroughFB = 1000118003,
        [NativeName("Name", "XR_TYPE_GEOMETRY_INSTANCE_CREATE_INFO_FB")]
        TypeGeometryInstanceCreateInfoFB = 1000118004,
        [NativeName("Name", "XR_TYPE_GEOMETRY_INSTANCE_TRANSFORM_FB")]
        TypeGeometryInstanceTransformFB = 1000118005,
        [NativeName("Name", "XR_TYPE_PASSTHROUGH_STYLE_FB")]
        TypePassthroughStyleFB = 1000118020,
        [NativeName("Name", "XR_TYPE_PASSTHROUGH_COLOR_MAP_MONO_TO_RGBA_FB")]
        TypePassthroughColorMapMonoToRgbaFB = 1000118021,
        [NativeName("Name", "XR_TYPE_PASSTHROUGH_COLOR_MAP_MONO_TO_MONO_FB")]
        TypePassthroughColorMapMonoToMonoFB = 1000118022,
        [NativeName("Name", "XR_TYPE_EVENT_DATA_PASSTHROUGH_STATE_CHANGED_FB")]
        TypeEventDataPassthroughStateChangedFB = 1000118030,
        [NativeName("Name", "XR_TYPE_RENDER_MODEL_PATH_INFO_FB")]
        TypeRenderModelPathInfoFB = 1000119000,
        [NativeName("Name", "XR_TYPE_RENDER_MODEL_PROPERTIES_FB")]
        TypeRenderModelPropertiesFB = 1000119001,
        [NativeName("Name", "XR_TYPE_RENDER_MODEL_BUFFER_FB")]
        TypeRenderModelBufferFB = 1000119002,
        [NativeName("Name", "XR_TYPE_RENDER_MODEL_LOAD_INFO_FB")]
        TypeRenderModelLoadInfoFB = 1000119003,
        [NativeName("Name", "XR_TYPE_SYSTEM_RENDER_MODEL_PROPERTIES_FB")]
        TypeSystemRenderModelPropertiesFB = 1000119004,
        [NativeName("Name", "XR_TYPE_BINDING_MODIFICATIONS_KHR")]
        TypeBindingModificationsKhr = 1000120000,
        [NativeName("Name", "XR_TYPE_VIEW_LOCATE_FOVEATED_RENDERING_VARJO")]
        TypeViewLocateFoveatedRenderingVarjo = 1000121000,
        [NativeName("Name", "XR_TYPE_FOVEATED_VIEW_CONFIGURATION_VIEW_VARJO")]
        TypeFoveatedViewConfigurationViewVarjo = 1000121001,
        [NativeName("Name", "XR_TYPE_SYSTEM_FOVEATED_RENDERING_PROPERTIES_VARJO")]
        TypeSystemFoveatedRenderingPropertiesVarjo = 1000121002,
        [NativeName("Name", "XR_TYPE_COMPOSITION_LAYER_DEPTH_TEST_VARJO")]
        TypeCompositionLayerDepthTestVarjo = 1000122000,
        [NativeName("Name", "XR_TYPE_SYSTEM_MARKER_TRACKING_PROPERTIES_VARJO")]
        TypeSystemMarkerTrackingPropertiesVarjo = 1000124000,
        [NativeName("Name", "XR_TYPE_EVENT_DATA_MARKER_TRACKING_UPDATE_VARJO")]
        TypeEventDataMarkerTrackingUpdateVarjo = 1000124001,
        [NativeName("Name", "XR_TYPE_MARKER_SPACE_CREATE_INFO_VARJO")]
        TypeMarkerSpaceCreateInfoVarjo = 1000124002,
        [NativeName("Name", "XR_TYPE_SPATIAL_ANCHOR_PERSISTENCE_INFO_MSFT")]
        TypeSpatialAnchorPersistenceInfoMsft = 1000142000,
        [NativeName("Name", "XR_TYPE_SPATIAL_ANCHOR_FROM_PERSISTED_ANCHOR_CREATE_INFO_MSFT")]
        TypeSpatialAnchorFromPersistedAnchorCreateInfoMsft = 1000142001,
        [NativeName("Name", "XR_TYPE_SWAPCHAIN_IMAGE_FOVEATION_VULKAN_FB")]
        TypeSwapchainImageFoveationVulkanFB = 1000160000,
        [NativeName("Name", "XR_TYPE_SWAPCHAIN_STATE_ANDROID_SURFACE_DIMENSIONS_FB")]
        TypeSwapchainStateAndroidSurfaceDimensionsFB = 1000161000,
        [NativeName("Name", "XR_TYPE_SWAPCHAIN_STATE_SAMPLER_OPENGL_ES_FB")]
        TypeSwapchainStateSamplerOpenglESFB = 1000162000,
        [NativeName("Name", "XR_TYPE_SWAPCHAIN_STATE_SAMPLER_VULKAN_FB")]
        TypeSwapchainStateSamplerVulkanFB = 1000163000,
        [NativeName("Name", "XR_TYPE_COMPOSITION_LAYER_SPACE_WARP_INFO_FB")]
        TypeCompositionLayerSpaceWarpInfoFB = 1000171000,
        [NativeName("Name", "XR_TYPE_SYSTEM_SPACE_WARP_PROPERTIES_FB")]
        TypeSystemSpaceWarpPropertiesFB = 1000171001,
        [NativeName("Name", "XR_TYPE_DIGITAL_LENS_CONTROL_ALMALENCE")]
        TypeDigitalLensControlAlmalence = 1000196000,
        [NativeName("Name", "XR_TYPE_PASSTHROUGH_KEYBOARD_HANDS_INTENSITY_FB")]
        TypePassthroughKeyboardHandsIntensityFB = 1000203002,
    }
}
