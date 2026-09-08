// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrResult")]
[SupportedApiProfile("openxr")]
public enum Result
{
    [NativeName("XR_SUCCESS")]
    [SupportedApiProfile("openxr")]
    Success = 0,

    [NativeName("XR_TIMEOUT_EXPIRED")]
    [SupportedApiProfile("openxr")]
    TimeoutExpired = 1,

    [NativeName("XR_SESSION_LOSS_PENDING")]
    [SupportedApiProfile("openxr")]
    SessionLossPending = 3,

    [NativeName("XR_EVENT_UNAVAILABLE")]
    [SupportedApiProfile("openxr")]
    EventUnavailable = 4,

    [NativeName("XR_SPACE_BOUNDS_UNAVAILABLE")]
    [SupportedApiProfile("openxr")]
    SpaceBoundsUnavailable = 7,

    [NativeName("XR_SESSION_NOT_FOCUSED")]
    [SupportedApiProfile("openxr")]
    SessionNotFocused = 8,

    [NativeName("XR_FRAME_DISCARDED")]
    [SupportedApiProfile("openxr")]
    FrameDiscarded = 9,

    [NativeName("XR_ERROR_VALIDATION_FAILURE")]
    [SupportedApiProfile("openxr")]
    ErrorValidationFailure = -1,

    [NativeName("XR_ERROR_RUNTIME_FAILURE")]
    [SupportedApiProfile("openxr")]
    ErrorRuntimeFailure = -2,

    [NativeName("XR_ERROR_OUT_OF_MEMORY")]
    [SupportedApiProfile("openxr")]
    ErrorOutOfMemory = -3,

    [NativeName("XR_ERROR_API_VERSION_UNSUPPORTED")]
    [SupportedApiProfile("openxr")]
    ErrorApiVersionUnsupported = -4,

    [NativeName("XR_ERROR_INITIALIZATION_FAILED")]
    [SupportedApiProfile("openxr")]
    ErrorInitializationFailed = -6,

    [NativeName("XR_ERROR_FUNCTION_UNSUPPORTED")]
    [SupportedApiProfile("openxr")]
    ErrorFunctionUnsupported = -7,

    [NativeName("XR_ERROR_FEATURE_UNSUPPORTED")]
    [SupportedApiProfile("openxr")]
    ErrorFeatureUnsupported = -8,

    [NativeName("XR_ERROR_EXTENSION_NOT_PRESENT")]
    [SupportedApiProfile("openxr")]
    ErrorExtensionNotPresent = -9,

    [NativeName("XR_ERROR_LIMIT_REACHED")]
    [SupportedApiProfile("openxr")]
    ErrorLimitReached = -10,

    [NativeName("XR_ERROR_SIZE_INSUFFICIENT")]
    [SupportedApiProfile("openxr")]
    ErrorSizeInsufficient = -11,

    [NativeName("XR_ERROR_HANDLE_INVALID")]
    [SupportedApiProfile("openxr")]
    ErrorHandleInvalid = -12,

    [NativeName("XR_ERROR_INSTANCE_LOST")]
    [SupportedApiProfile("openxr")]
    ErrorInstanceLost = -13,

    [NativeName("XR_ERROR_SESSION_RUNNING")]
    [SupportedApiProfile("openxr")]
    ErrorSessionRunning = -14,

    [NativeName("XR_ERROR_SESSION_NOT_RUNNING")]
    [SupportedApiProfile("openxr")]
    ErrorSessionNotRunning = -16,

    [NativeName("XR_ERROR_SESSION_LOST")]
    [SupportedApiProfile("openxr")]
    ErrorSessionLost = -17,

    [NativeName("XR_ERROR_SYSTEM_INVALID")]
    [SupportedApiProfile("openxr")]
    ErrorSystemInvalid = -18,

    [NativeName("XR_ERROR_PATH_INVALID")]
    [SupportedApiProfile("openxr")]
    ErrorPathInvalid = -19,

    [NativeName("XR_ERROR_PATH_COUNT_EXCEEDED")]
    [SupportedApiProfile("openxr")]
    ErrorPathCountExceeded = -20,

    [NativeName("XR_ERROR_PATH_FORMAT_INVALID")]
    [SupportedApiProfile("openxr")]
    ErrorPathFormatInvalid = -21,

    [NativeName("XR_ERROR_PATH_UNSUPPORTED")]
    [SupportedApiProfile("openxr")]
    ErrorPathUnsupported = -22,

    [NativeName("XR_ERROR_LAYER_INVALID")]
    [SupportedApiProfile("openxr")]
    ErrorLayerInvalid = -23,

    [NativeName("XR_ERROR_LAYER_LIMIT_EXCEEDED")]
    [SupportedApiProfile("openxr")]
    ErrorLayerLimitExceeded = -24,

    [NativeName("XR_ERROR_SWAPCHAIN_RECT_INVALID")]
    [SupportedApiProfile("openxr")]
    ErrorSwapchainRectInvalid = -25,

    [NativeName("XR_ERROR_SWAPCHAIN_FORMAT_UNSUPPORTED")]
    [SupportedApiProfile("openxr")]
    ErrorSwapchainFormatUnsupported = -26,

    [NativeName("XR_ERROR_ACTION_TYPE_MISMATCH")]
    [SupportedApiProfile("openxr")]
    ErrorActionTypeMismatch = -27,

    [NativeName("XR_ERROR_SESSION_NOT_READY")]
    [SupportedApiProfile("openxr")]
    ErrorSessionNotReady = -28,

    [NativeName("XR_ERROR_SESSION_NOT_STOPPING")]
    [SupportedApiProfile("openxr")]
    ErrorSessionNotStopping = -29,

    [NativeName("XR_ERROR_TIME_INVALID")]
    [SupportedApiProfile("openxr")]
    ErrorTimeInvalid = -30,

    [NativeName("XR_ERROR_REFERENCE_SPACE_UNSUPPORTED")]
    [SupportedApiProfile("openxr")]
    ErrorReferenceSpaceUnsupported = -31,

    [NativeName("XR_ERROR_FILE_ACCESS_ERROR")]
    [SupportedApiProfile("openxr")]
    ErrorFileAccessError = -32,

    [NativeName("XR_ERROR_FILE_CONTENTS_INVALID")]
    [SupportedApiProfile("openxr")]
    ErrorFileContentsInvalid = -33,

    [NativeName("XR_ERROR_FORM_FACTOR_UNSUPPORTED")]
    [SupportedApiProfile("openxr")]
    ErrorFormFactorUnsupported = -34,

    [NativeName("XR_ERROR_FORM_FACTOR_UNAVAILABLE")]
    [SupportedApiProfile("openxr")]
    ErrorFormFactorUnavailable = -35,

    [NativeName("XR_ERROR_API_LAYER_NOT_PRESENT")]
    [SupportedApiProfile("openxr")]
    ErrorApiLayerNotPresent = -36,

    [NativeName("XR_ERROR_CALL_ORDER_INVALID")]
    [SupportedApiProfile("openxr")]
    ErrorCallOrderInvalid = -37,

    [NativeName("XR_ERROR_GRAPHICS_DEVICE_INVALID")]
    [SupportedApiProfile("openxr")]
    ErrorGraphicsDeviceInvalid = -38,

    [NativeName("XR_ERROR_POSE_INVALID")]
    [SupportedApiProfile("openxr")]
    ErrorPoseInvalid = -39,

    [NativeName("XR_ERROR_INDEX_OUT_OF_RANGE")]
    [SupportedApiProfile("openxr")]
    ErrorIndexOutOfRange = -40,

    [NativeName("XR_ERROR_VIEW_CONFIGURATION_TYPE_UNSUPPORTED")]
    [SupportedApiProfile("openxr")]
    ErrorViewConfigurationTypeUnsupported = -41,

    [NativeName("XR_ERROR_ENVIRONMENT_BLEND_MODE_UNSUPPORTED")]
    [SupportedApiProfile("openxr")]
    ErrorEnvironmentBlendModeUnsupported = -42,

    [NativeName("XR_ERROR_NAME_DUPLICATED")]
    [SupportedApiProfile("openxr")]
    ErrorNameDuplicated = -44,

    [NativeName("XR_ERROR_NAME_INVALID")]
    [SupportedApiProfile("openxr")]
    ErrorNameInvalid = -45,

    [NativeName("XR_ERROR_ACTIONSET_NOT_ATTACHED")]
    [SupportedApiProfile("openxr")]
    ErrorActionsetNotAttached = -46,

    [NativeName("XR_ERROR_ACTIONSETS_ALREADY_ATTACHED")]
    [SupportedApiProfile("openxr")]
    ErrorActionsetsAlreadyAttached = -47,

    [NativeName("XR_ERROR_LOCALIZED_NAME_DUPLICATED")]
    [SupportedApiProfile("openxr")]
    ErrorLocalizedNameDuplicated = -48,

    [NativeName("XR_ERROR_LOCALIZED_NAME_INVALID")]
    [SupportedApiProfile("openxr")]
    ErrorLocalizedNameInvalid = -49,

    [NativeName("XR_ERROR_GRAPHICS_REQUIREMENTS_CALL_MISSING")]
    [SupportedApiProfile("openxr")]
    ErrorGraphicsRequirementsCallMissing = -50,

    [NativeName("XR_ERROR_RUNTIME_UNAVAILABLE")]
    [SupportedApiProfile("openxr")]
    ErrorRuntimeUnavailable = -51,

    [NativeName("XR_ERROR_EXTENSION_DEPENDENCY_NOT_ENABLED")]
    [SupportedApiProfile("openxr", ["XR_VERSION_1_1"], MinVersion = "1.1")]
    ErrorExtensionDependencyNotEnabled = -1000710001,

    [NativeName("XR_ERROR_PERMISSION_INSUFFICIENT")]
    [SupportedApiProfile("openxr", ["XR_VERSION_1_1"], MinVersion = "1.1")]
    ErrorPermissionInsufficient = -1000710000,

    [NativeName("XR_ERROR_ANDROID_THREAD_SETTINGS_ID_INVALID_KHR")]
    [SupportedApiProfile("openxr", ["XR_KHR_android_thread_settings"])]
    ErrorAndroidThreadSettingsIdInvalidKHR = -1000003000,

    [NativeName("XR_ERROR_ANDROID_THREAD_SETTINGS_FAILURE_KHR")]
    [SupportedApiProfile("openxr", ["XR_KHR_android_thread_settings"])]
    ErrorAndroidThreadSettingsFailureKHR = -1000003001,

    [NativeName("XR_ERROR_CREATE_SPATIAL_ANCHOR_FAILED_MSFT")]
    [SupportedApiProfile("openxr", ["XR_MSFT_spatial_anchor"])]
    ErrorCreateSpatialAnchorFailedMSFT = -1000039001,

    [NativeName("XR_ERROR_SECONDARY_VIEW_CONFIGURATION_TYPE_NOT_ENABLED_MSFT")]
    [SupportedApiProfile("openxr", ["XR_MSFT_secondary_view_configuration"])]
    ErrorSecondaryViewConfigurationTypeNotEnabledMSFT = -1000053000,

    [NativeName("XR_ERROR_CONTROLLER_MODEL_KEY_INVALID_MSFT")]
    [SupportedApiProfile("openxr", ["XR_MSFT_controller_model"])]
    ErrorControllerModelKeyInvalidMSFT = -1000055000,

    [NativeName("XR_ERROR_REPROJECTION_MODE_UNSUPPORTED_MSFT")]
    [SupportedApiProfile("openxr", ["XR_MSFT_composition_layer_reprojection"])]
    ErrorReprojectionModeUnsupportedMSFT = -1000066000,

    [NativeName("XR_ERROR_COMPUTE_NEW_SCENE_NOT_COMPLETED_MSFT")]
    [SupportedApiProfile("openxr", ["XR_MSFT_scene_understanding"])]
    ErrorComputeNewSceneNotCompletedMSFT = -1000097000,

    [NativeName("XR_ERROR_SCENE_COMPONENT_ID_INVALID_MSFT")]
    [SupportedApiProfile("openxr", ["XR_MSFT_scene_understanding"])]
    ErrorSceneComponentIdInvalidMSFT = -1000097001,

    [NativeName("XR_ERROR_SCENE_COMPONENT_TYPE_MISMATCH_MSFT")]
    [SupportedApiProfile("openxr", ["XR_MSFT_scene_understanding"])]
    ErrorSceneComponentTypeMismatchMSFT = -1000097002,

    [NativeName("XR_ERROR_SCENE_MESH_BUFFER_ID_INVALID_MSFT")]
    [SupportedApiProfile("openxr", ["XR_MSFT_scene_understanding"])]
    ErrorSceneMeshBufferIdInvalidMSFT = -1000097003,

    [NativeName("XR_ERROR_SCENE_COMPUTE_FEATURE_INCOMPATIBLE_MSFT")]
    [SupportedApiProfile("openxr", ["XR_MSFT_scene_understanding"])]
    ErrorSceneComputeFeatureIncompatibleMSFT = -1000097004,

    [NativeName("XR_ERROR_SCENE_COMPUTE_CONSISTENCY_MISMATCH_MSFT")]
    [SupportedApiProfile("openxr", ["XR_MSFT_scene_understanding"])]
    ErrorSceneComputeConsistencyMismatchMSFT = -1000097005,

    [NativeName("XR_ERROR_DISPLAY_REFRESH_RATE_UNSUPPORTED_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_display_refresh_rate"])]
    ErrorDisplayRefreshRateUnsupportedFB = -1000101000,

    [NativeName("XR_ERROR_COLOR_SPACE_UNSUPPORTED_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_color_space"])]
    ErrorColorSpaceUnsupportedFB = -1000108000,

    [NativeName("XR_ERROR_SPACE_COMPONENT_NOT_SUPPORTED_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_spatial_entity"])]
    ErrorSpaceComponentNotSupportedFB = -1000113000,

    [NativeName("XR_ERROR_SPACE_COMPONENT_NOT_ENABLED_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_spatial_entity"])]
    ErrorSpaceComponentNotEnabledFB = -1000113001,

    [NativeName("XR_ERROR_SPACE_COMPONENT_STATUS_PENDING_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_spatial_entity"])]
    ErrorSpaceComponentStatusPendingFB = -1000113002,

    [NativeName("XR_ERROR_SPACE_COMPONENT_STATUS_ALREADY_SET_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_spatial_entity"])]
    ErrorSpaceComponentStatusAlreadySetFB = -1000113003,

    [NativeName("XR_ERROR_UNEXPECTED_STATE_PASSTHROUGH_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_passthrough"])]
    ErrorUnexpectedStatePassthroughFB = -1000118000,

    [NativeName("XR_ERROR_FEATURE_ALREADY_CREATED_PASSTHROUGH_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_passthrough"])]
    ErrorFeatureAlreadyCreatedPassthroughFB = -1000118001,

    [NativeName("XR_ERROR_FEATURE_REQUIRED_PASSTHROUGH_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_passthrough"])]
    ErrorFeatureRequiredPassthroughFB = -1000118002,

    [NativeName("XR_ERROR_NOT_PERMITTED_PASSTHROUGH_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_passthrough"])]
    ErrorNotPermittedPassthroughFB = -1000118003,

    [NativeName("XR_ERROR_INSUFFICIENT_RESOURCES_PASSTHROUGH_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_passthrough"])]
    ErrorInsufficientResourcesPassthroughFB = -1000118004,

    [NativeName("XR_ERROR_UNKNOWN_PASSTHROUGH_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_passthrough"])]
    ErrorUnknownPassthroughFB = -1000118050,

    [NativeName("XR_ERROR_RENDER_MODEL_KEY_INVALID_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_render_model"])]
    ErrorRenderModelKeyInvalidFB = -1000119000,

    [NativeName("XR_RENDER_MODEL_UNAVAILABLE_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_render_model"])]
    RenderModelUnavailableFB = 1000119020,

    [NativeName("XR_ERROR_MARKER_NOT_TRACKED_VARJO")]
    [SupportedApiProfile("openxr", ["XR_VARJO_marker_tracking"])]
    ErrorMarkerNotTrackedVARJO = -1000124000,

    [NativeName("XR_ERROR_MARKER_ID_INVALID_VARJO")]
    [SupportedApiProfile("openxr", ["XR_VARJO_marker_tracking"])]
    ErrorMarkerIdInvalidVARJO = -1000124001,

    [NativeName("XR_ERROR_MARKER_DETECTOR_PERMISSION_DENIED_ML")]
    [SupportedApiProfile("openxr", ["XR_ML_marker_understanding"])]
    ErrorMarkerDetectorPermissionDeniedML = -1000138000,

    [NativeName("XR_ERROR_MARKER_DETECTOR_LOCATE_FAILED_ML")]
    [SupportedApiProfile("openxr", ["XR_ML_marker_understanding"])]
    ErrorMarkerDetectorLocateFailedML = -1000138001,

    [NativeName("XR_ERROR_MARKER_DETECTOR_INVALID_DATA_QUERY_ML")]
    [SupportedApiProfile("openxr", ["XR_ML_marker_understanding"])]
    ErrorMarkerDetectorInvalidDataQueryML = -1000138002,

    [NativeName("XR_ERROR_MARKER_DETECTOR_INVALID_CREATE_INFO_ML")]
    [SupportedApiProfile("openxr", ["XR_ML_marker_understanding"])]
    ErrorMarkerDetectorInvalidCreateInfoML = -1000138003,

    [NativeName("XR_ERROR_MARKER_INVALID_ML")]
    [SupportedApiProfile("openxr", ["XR_ML_marker_understanding"])]
    ErrorMarkerInvalidML = -1000138004,

    [NativeName("XR_ERROR_LOCALIZATION_MAP_INCOMPATIBLE_ML")]
    [SupportedApiProfile(
        "openxr",
        ["XR_ML_localization_map"],
        ImpliesSets = ["XR_EXT_uuid", "XR_VERSION_1_0"]
    )]
    ErrorLocalizationMapIncompatibleML = -1000139000,

    [NativeName("XR_ERROR_LOCALIZATION_MAP_UNAVAILABLE_ML")]
    [SupportedApiProfile(
        "openxr",
        ["XR_ML_localization_map"],
        ImpliesSets = ["XR_EXT_uuid", "XR_VERSION_1_0"]
    )]
    ErrorLocalizationMapUnavailableML = -1000139001,

    [NativeName("XR_ERROR_LOCALIZATION_MAP_FAIL_ML")]
    [SupportedApiProfile(
        "openxr",
        ["XR_ML_localization_map"],
        ImpliesSets = ["XR_EXT_uuid", "XR_VERSION_1_0"]
    )]
    ErrorLocalizationMapFailML = -1000139002,

    [NativeName("XR_ERROR_LOCALIZATION_MAP_IMPORT_EXPORT_PERMISSION_DENIED_ML")]
    [SupportedApiProfile(
        "openxr",
        ["XR_ML_localization_map"],
        ImpliesSets = ["XR_EXT_uuid", "XR_VERSION_1_0"]
    )]
    ErrorLocalizationMapImportExportPermissionDeniedML = -1000139003,

    [NativeName("XR_ERROR_LOCALIZATION_MAP_PERMISSION_DENIED_ML")]
    [SupportedApiProfile(
        "openxr",
        ["XR_ML_localization_map"],
        ImpliesSets = ["XR_EXT_uuid", "XR_VERSION_1_0"]
    )]
    ErrorLocalizationMapPermissionDeniedML = -1000139004,

    [NativeName("XR_ERROR_LOCALIZATION_MAP_ALREADY_EXISTS_ML")]
    [SupportedApiProfile(
        "openxr",
        ["XR_ML_localization_map"],
        ImpliesSets = ["XR_EXT_uuid", "XR_VERSION_1_0"]
    )]
    ErrorLocalizationMapAlreadyExistsML = -1000139005,

    [NativeName("XR_ERROR_LOCALIZATION_MAP_CANNOT_EXPORT_CLOUD_MAP_ML")]
    [SupportedApiProfile(
        "openxr",
        ["XR_ML_localization_map"],
        ImpliesSets = ["XR_EXT_uuid", "XR_VERSION_1_0"]
    )]
    ErrorLocalizationMapCannotExportCloudMapML = -1000139006,

    [NativeName("XR_ERROR_SPATIAL_ANCHORS_PERMISSION_DENIED_ML")]
    [SupportedApiProfile("openxr", ["XR_ML_spatial_anchors"], ImpliesSets = ["XR_EXT_future"])]
    ErrorSpatialAnchorsPermissionDeniedML = -1000140000,

    [NativeName("XR_ERROR_SPATIAL_ANCHORS_NOT_LOCALIZED_ML")]
    [SupportedApiProfile("openxr", ["XR_ML_spatial_anchors"], ImpliesSets = ["XR_EXT_future"])]
    ErrorSpatialAnchorsNotLocalizedML = -1000140001,

    [NativeName("XR_ERROR_SPATIAL_ANCHORS_OUT_OF_MAP_BOUNDS_ML")]
    [SupportedApiProfile("openxr", ["XR_ML_spatial_anchors"], ImpliesSets = ["XR_EXT_future"])]
    ErrorSpatialAnchorsOutOfMapBoundsML = -1000140002,

    [NativeName("XR_ERROR_SPATIAL_ANCHORS_SPACE_NOT_LOCATABLE_ML")]
    [SupportedApiProfile("openxr", ["XR_ML_spatial_anchors"], ImpliesSets = ["XR_EXT_future"])]
    ErrorSpatialAnchorsSpaceNotLocatableML = -1000140003,

    [NativeName("XR_ERROR_SPATIAL_ANCHORS_ANCHOR_NOT_FOUND_ML")]
    [SupportedApiProfile(
        "openxr",
        ["XR_ML_spatial_anchors_storage"],
        ImpliesSets = ["XR_EXT_future", "XR_ML_spatial_anchors"]
    )]
    ErrorSpatialAnchorsAnchorNotFoundML = -1000141000,

    [NativeName("XR_ERROR_SPATIAL_ANCHOR_NAME_NOT_FOUND_MSFT")]
    [SupportedApiProfile(
        "openxr",
        ["XR_MSFT_spatial_anchor_persistence"],
        ImpliesSets = ["XR_MSFT_spatial_anchor", "XR_VERSION_1_0"]
    )]
    ErrorSpatialAnchorNameNotFoundMSFT = -1000142001,

    [NativeName("XR_ERROR_SPATIAL_ANCHOR_NAME_INVALID_MSFT")]
    [SupportedApiProfile(
        "openxr",
        ["XR_MSFT_spatial_anchor_persistence"],
        ImpliesSets = ["XR_MSFT_spatial_anchor", "XR_VERSION_1_0"]
    )]
    ErrorSpatialAnchorNameInvalidMSFT = -1000142002,

    [NativeName("XR_SCENE_MARKER_DATA_NOT_STRING_MSFT")]
    [SupportedApiProfile(
        "openxr",
        ["XR_MSFT_scene_marker"],
        ImpliesSets = ["XR_MSFT_scene_understanding", "XR_VERSION_1_0"]
    )]
    SceneMarkerDataNotStringMSFT = 1000147000,

    [NativeName("XR_ERROR_SPACE_MAPPING_INSUFFICIENT_FB")]
    [SupportedApiProfile(
        "openxr",
        ["XR_FB_spatial_entity_sharing"],
        ImpliesSets = ["XR_FB_spatial_entity", "XR_VERSION_1_0"]
    )]
    ErrorSpaceMappingInsufficientFB = -1000169000,

    [NativeName("XR_ERROR_SPACE_LOCALIZATION_FAILED_FB")]
    [SupportedApiProfile(
        "openxr",
        ["XR_FB_spatial_entity_sharing"],
        ImpliesSets = ["XR_FB_spatial_entity", "XR_VERSION_1_0"]
    )]
    ErrorSpaceLocalizationFailedFB = -1000169001,

    [NativeName("XR_ERROR_SPACE_NETWORK_TIMEOUT_FB")]
    [SupportedApiProfile(
        "openxr",
        ["XR_FB_spatial_entity_sharing"],
        ImpliesSets = ["XR_FB_spatial_entity", "XR_VERSION_1_0"]
    )]
    ErrorSpaceNetworkTimeoutFB = -1000169002,

    [NativeName("XR_ERROR_SPACE_NETWORK_REQUEST_FAILED_FB")]
    [SupportedApiProfile(
        "openxr",
        ["XR_FB_spatial_entity_sharing"],
        ImpliesSets = ["XR_FB_spatial_entity", "XR_VERSION_1_0"]
    )]
    ErrorSpaceNetworkRequestFailedFB = -1000169003,

    [NativeName("XR_ERROR_SPACE_CLOUD_STORAGE_DISABLED_FB")]
    [SupportedApiProfile(
        "openxr",
        ["XR_FB_spatial_entity_sharing"],
        ImpliesSets = ["XR_FB_spatial_entity", "XR_VERSION_1_0"]
    )]
    ErrorSpaceCloudStorageDisabledFB = -1000169004,

    [NativeName("XR_ERROR_SPACE_INSUFFICIENT_RESOURCES_META")]
    [SupportedApiProfile("openxr", ["XR_META_spatial_entity_persistence"])]
    ErrorSpaceInsufficientResourcesMETA = -1000259000,

    [NativeName("XR_ERROR_SPACE_STORAGE_AT_CAPACITY_META")]
    [SupportedApiProfile("openxr", ["XR_META_spatial_entity_persistence"])]
    ErrorSpaceStorageAtCapacityMETA = -1000259001,

    [NativeName("XR_ERROR_SPACE_INSUFFICIENT_VIEW_META")]
    [SupportedApiProfile("openxr", ["XR_META_spatial_entity_persistence"])]
    ErrorSpaceInsufficientViewMETA = -1000259002,

    [NativeName("XR_ERROR_SPACE_PERMISSION_INSUFFICIENT_META")]
    [SupportedApiProfile("openxr", ["XR_META_spatial_entity_persistence"])]
    ErrorSpacePermissionInsufficientMETA = -1000259003,

    [NativeName("XR_ERROR_SPACE_RATE_LIMITED_META")]
    [SupportedApiProfile("openxr", ["XR_META_spatial_entity_persistence"])]
    ErrorSpaceRateLimitedMETA = -1000259004,

    [NativeName("XR_ERROR_SPACE_TOO_DARK_META")]
    [SupportedApiProfile("openxr", ["XR_META_spatial_entity_persistence"])]
    ErrorSpaceTooDarkMETA = -1000259005,

    [NativeName("XR_ERROR_SPACE_TOO_BRIGHT_META")]
    [SupportedApiProfile("openxr", ["XR_META_spatial_entity_persistence"])]
    ErrorSpaceTooBrightMETA = -1000259006,

    [NativeName("XR_ERROR_PASSTHROUGH_COLOR_LUT_BUFFER_SIZE_MISMATCH_META")]
    [SupportedApiProfile(
        "openxr",
        ["XR_META_passthrough_color_lut"],
        ImpliesSets = ["XR_FB_passthrough", "XR_VERSION_1_0"]
    )]
    ErrorPassthroughColorLutBufferSizeMismatchMETA = -1000266000,

    [NativeName("XR_ENVIRONMENT_DEPTH_NOT_AVAILABLE_META")]
    [SupportedApiProfile("openxr", ["XR_META_environment_depth"])]
    EnvironmentDepthNotAvailableMETA = 1000291000,

    [NativeName("XR_ERROR_RENDER_MODEL_ID_INVALID_EXT")]
    [SupportedApiProfile(
        "openxr",
        ["XR_EXT_render_model"],
        ImpliesSets = ["XR_EXT_render_model+XR_EXT_uuid", "XR_EXT_render_model+XR_VERSION_1_1"]
    )]
    ErrorRenderModelIdInvalidEXT = -1000300000,

    [NativeName("XR_ERROR_RENDER_MODEL_ASSET_UNAVAILABLE_EXT")]
    [SupportedApiProfile(
        "openxr",
        ["XR_EXT_render_model"],
        ImpliesSets = ["XR_EXT_render_model+XR_EXT_uuid", "XR_EXT_render_model+XR_VERSION_1_1"]
    )]
    ErrorRenderModelAssetUnavailableEXT = -1000300001,

    [NativeName("XR_ERROR_RENDER_MODEL_GLTF_EXTENSION_REQUIRED_EXT")]
    [SupportedApiProfile(
        "openxr",
        ["XR_EXT_render_model"],
        ImpliesSets = ["XR_EXT_render_model+XR_EXT_uuid", "XR_EXT_render_model+XR_VERSION_1_1"]
    )]
    ErrorRenderModelGltfExtensionRequiredEXT = -1000300002,

    [NativeName("XR_ERROR_NOT_INTERACTION_RENDER_MODEL_EXT")]
    [SupportedApiProfile(
        "openxr",
        ["XR_EXT_interaction_render_model"],
        ImpliesSets = ["XR_EXT_render_model"]
    )]
    ErrorNotInteractionRenderModelEXT = -1000301000,

    [NativeName("XR_ERROR_HINT_ALREADY_SET_QCOM")]
    [SupportedApiProfile("openxr", ["XR_QCOM_tracking_optimization_settings"])]
    ErrorHintAlreadySetQCOM = -1000306000,

    [NativeName("XR_ERROR_NOT_AN_ANCHOR_HTC")]
    [SupportedApiProfile("openxr", ["XR_HTC_anchor"])]
    ErrorNotAnAnchorHTC = -1000319000,

    [NativeName("XR_ERROR_SPATIAL_ENTITY_ID_INVALID_BD")]
    [SupportedApiProfile(
        "openxr",
        ["XR_BD_spatial_sensing"],
        ImpliesSets = ["XR_EXT_future", "XR_VERSION_1_0"]
    )]
    ErrorSpatialEntityIdInvalidBD = -1000389000,

    [NativeName("XR_ERROR_SPATIAL_SENSING_SERVICE_UNAVAILABLE_BD")]
    [SupportedApiProfile(
        "openxr",
        ["XR_BD_spatial_sensing"],
        ImpliesSets = ["XR_EXT_future", "XR_VERSION_1_0"]
    )]
    ErrorSpatialSensingServiceUnavailableBD = -1000389001,

    [NativeName("XR_ERROR_ANCHOR_NOT_SUPPORTED_FOR_ENTITY_BD")]
    [SupportedApiProfile(
        "openxr",
        ["XR_BD_spatial_sensing"],
        ImpliesSets = ["XR_EXT_future", "XR_VERSION_1_0"]
    )]
    ErrorAnchorNotSupportedForEntityBD = -1000389002,

    [NativeName("XR_ERROR_SPATIAL_ANCHOR_NOT_FOUND_BD")]
    [SupportedApiProfile(
        "openxr",
        ["XR_BD_spatial_anchor"],
        ImpliesSets = ["XR_BD_spatial_sensing"]
    )]
    ErrorSpatialAnchorNotFoundBD = -1000390000,

    [NativeName("XR_ERROR_SPATIAL_ANCHOR_SHARING_NETWORK_TIMEOUT_BD")]
    [SupportedApiProfile(
        "openxr",
        ["XR_BD_spatial_anchor_sharing"],
        ImpliesSets = ["XR_BD_spatial_anchor"]
    )]
    ErrorSpatialAnchorSharingNetworkTimeoutBD = -1000391000,

    [NativeName("XR_ERROR_SPATIAL_ANCHOR_SHARING_AUTHENTICATION_FAILURE_BD")]
    [SupportedApiProfile(
        "openxr",
        ["XR_BD_spatial_anchor_sharing"],
        ImpliesSets = ["XR_BD_spatial_anchor"]
    )]
    ErrorSpatialAnchorSharingAuthenticationFailureBD = -1000391001,

    [NativeName("XR_ERROR_SPATIAL_ANCHOR_SHARING_NETWORK_FAILURE_BD")]
    [SupportedApiProfile(
        "openxr",
        ["XR_BD_spatial_anchor_sharing"],
        ImpliesSets = ["XR_BD_spatial_anchor"]
    )]
    ErrorSpatialAnchorSharingNetworkFailureBD = -1000391002,

    [NativeName("XR_ERROR_SPATIAL_ANCHOR_SHARING_LOCALIZATION_FAIL_BD")]
    [SupportedApiProfile(
        "openxr",
        ["XR_BD_spatial_anchor_sharing"],
        ImpliesSets = ["XR_BD_spatial_anchor"]
    )]
    ErrorSpatialAnchorSharingLocalizationFailBD = -1000391003,

    [NativeName("XR_ERROR_SPATIAL_ANCHOR_SHARING_MAP_INSUFFICIENT_BD")]
    [SupportedApiProfile(
        "openxr",
        ["XR_BD_spatial_anchor_sharing"],
        ImpliesSets = ["XR_BD_spatial_anchor"]
    )]
    ErrorSpatialAnchorSharingMapInsufficientBD = -1000391004,

    [NativeName("XR_ERROR_SCENE_CAPTURE_FAILURE_BD")]
    [SupportedApiProfile(
        "openxr",
        ["XR_BD_spatial_scene"],
        ImpliesSets = ["XR_BD_spatial_sensing"]
    )]
    ErrorSceneCaptureFailureBD = -1000392000,

    [NativeName("XR_ERROR_SPACE_NOT_LOCATABLE_EXT")]
    [SupportedApiProfile("openxr", ["XR_EXT_plane_detection"])]
    ErrorSpaceNotLocatableEXT = -1000429000,

    [NativeName("XR_ERROR_PLANE_DETECTION_PERMISSION_DENIED_EXT")]
    [SupportedApiProfile("openxr", ["XR_EXT_plane_detection"])]
    ErrorPlaneDetectionPermissionDeniedEXT = -1000429001,

    [NativeName("XR_ERROR_MISMATCHING_TRACKABLE_TYPE_ANDROID")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_trackables"])]
    ErrorMismatchingTrackableTypeANDROID = -1000455000,

    [NativeName("XR_ERROR_TRACKABLE_TYPE_NOT_SUPPORTED_ANDROID")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_trackables"])]
    ErrorTrackableTypeNotSupportedANDROID = -1000455001,

    [NativeName("XR_ERROR_ANCHOR_ID_NOT_FOUND_ANDROID")]
    [SupportedApiProfile(
        "openxr",
        ["XR_ANDROID_device_anchor_persistence"],
        ImpliesSets = ["XR_ANDROID_trackables", "XR_EXT_uuid"]
    )]
    ErrorAnchorIdNotFoundANDROID = -1000457000,

    [NativeName("XR_ERROR_ANCHOR_ALREADY_PERSISTED_ANDROID")]
    [SupportedApiProfile(
        "openxr",
        ["XR_ANDROID_device_anchor_persistence"],
        ImpliesSets = ["XR_ANDROID_trackables", "XR_EXT_uuid"]
    )]
    ErrorAnchorAlreadyPersistedANDROID = -1000457001,

    [NativeName("XR_ERROR_ANCHOR_NOT_TRACKING_ANDROID")]
    [SupportedApiProfile(
        "openxr",
        ["XR_ANDROID_device_anchor_persistence"],
        ImpliesSets = ["XR_ANDROID_trackables", "XR_EXT_uuid"]
    )]
    ErrorAnchorNotTrackingANDROID = -1000457002,

    [NativeName("XR_ERROR_PERSISTED_DATA_NOT_READY_ANDROID")]
    [SupportedApiProfile(
        "openxr",
        ["XR_ANDROID_device_anchor_persistence"],
        ImpliesSets = ["XR_ANDROID_trackables", "XR_EXT_uuid"]
    )]
    ErrorPersistedDataNotReadyANDROID = -1000457003,

    [NativeName("XR_ERROR_SERVICE_NOT_READY_ANDROID")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_face_tracking"])]
    ErrorServiceNotReadyANDROID = -1000458000,

    [NativeName("XR_ERROR_MESH_DATA_LIMIT_EXCEEDED_ANDROID")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_composition_layer_passthrough_mesh"])]
    ErrorMeshDataLimitExceededANDROID = -1000462000,

    [NativeName("XR_ERROR_FUTURE_PENDING_EXT")]
    [SupportedApiProfile("openxr", ["XR_EXT_future"])]
    ErrorFuturePendingEXT = -1000469001,

    [NativeName("XR_ERROR_FUTURE_INVALID_EXT")]
    [SupportedApiProfile("openxr", ["XR_EXT_future"])]
    ErrorFutureInvalidEXT = -1000469002,

    [NativeName("XR_ERROR_SYSTEM_NOTIFICATION_PERMISSION_DENIED_ML")]
    [SupportedApiProfile("openxr", ["XR_ML_system_notifications"])]
    ErrorSystemNotificationPermissionDeniedML = -1000473000,

    [NativeName("XR_ERROR_SYSTEM_NOTIFICATION_INCOMPATIBLE_SKU_ML")]
    [SupportedApiProfile("openxr", ["XR_ML_system_notifications"])]
    ErrorSystemNotificationIncompatibleSkuML = -1000473001,

    [NativeName("XR_ERROR_WORLD_MESH_DETECTOR_PERMISSION_DENIED_ML")]
    [SupportedApiProfile("openxr", ["XR_ML_world_mesh_detection"], ImpliesSets = ["XR_EXT_future"])]
    ErrorWorldMeshDetectorPermissionDeniedML = -1000474000,

    [NativeName("XR_ERROR_WORLD_MESH_DETECTOR_SPACE_NOT_LOCATABLE_ML")]
    [SupportedApiProfile("openxr", ["XR_ML_world_mesh_detection"], ImpliesSets = ["XR_EXT_future"])]
    ErrorWorldMeshDetectorSpaceNotLocatableML = -1000474001,

    [NativeName("XR_ERROR_FACIAL_EXPRESSION_PERMISSION_DENIED_ML")]
    [SupportedApiProfile("openxr", ["XR_ML_facial_expression"])]
    ErrorFacialExpressionPermissionDeniedML = 1000482000,

    [NativeName("XR_BOUNDARY_VISIBILITY_SUPPRESSION_NOT_ALLOWED_META")]
    [SupportedApiProfile("openxr", ["XR_META_boundary_visibility"])]
    BoundaryVisibilitySuppressionNotAllowedMETA = 1000528000,

    [NativeName("XR_ERROR_COLOCATION_DISCOVERY_NETWORK_FAILED_META")]
    [SupportedApiProfile("openxr", ["XR_META_colocation_discovery"])]
    ErrorColocationDiscoveryNetworkFailedMETA = -1000571001,

    [NativeName("XR_ERROR_COLOCATION_DISCOVERY_NO_DISCOVERY_METHOD_META")]
    [SupportedApiProfile("openxr", ["XR_META_colocation_discovery"])]
    ErrorColocationDiscoveryNoDiscoveryMethodMETA = -1000571002,

    [NativeName("XR_COLOCATION_DISCOVERY_ALREADY_ADVERTISING_META")]
    [SupportedApiProfile("openxr", ["XR_META_colocation_discovery"])]
    ColocationDiscoveryAlreadyAdvertisingMETA = 1000571003,

    [NativeName("XR_COLOCATION_DISCOVERY_ALREADY_DISCOVERING_META")]
    [SupportedApiProfile("openxr", ["XR_META_colocation_discovery"])]
    ColocationDiscoveryAlreadyDiscoveringMETA = 1000571004,

    [NativeName("XR_ERROR_SPACE_GROUP_NOT_FOUND_META")]
    [SupportedApiProfile("openxr", ["XR_META_spatial_entity_group_sharing"])]
    ErrorSpaceGroupNotFoundMETA = -1000572002,

    [NativeName("XR_ERROR_ANCHOR_NOT_OWNED_BY_CALLER_ANDROID")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_anchor_sharing_export"])]
    ErrorAnchorNotOwnedByCallerANDROID = -1000701000,

    [NativeName("XR_ERROR_IMAGE_FORMAT_UNSUPPORTED_ANDROID")]
    [SupportedApiProfile(
        "openxr",
        ["XR_ANDROID_trackables_image"],
        ImpliesSets = ["XR_ANDROID_trackables", "XR_EXT_future"]
    )]
    ErrorImageFormatUnsupportedANDROID = -1000709000,

    [NativeName("XR_ERROR_SPATIAL_CAPABILITY_UNSUPPORTED_EXT")]
    [SupportedApiProfile("openxr", ["XR_EXT_spatial_entity"], ImpliesSets = ["XR_EXT_future"])]
    ErrorSpatialCapabilityUnsupportedEXT = -1000740001,

    [NativeName("XR_ERROR_SPATIAL_ENTITY_ID_INVALID_EXT")]
    [SupportedApiProfile("openxr", ["XR_EXT_spatial_entity"], ImpliesSets = ["XR_EXT_future"])]
    ErrorSpatialEntityIdInvalidEXT = -1000740002,

    [NativeName("XR_ERROR_SPATIAL_BUFFER_ID_INVALID_EXT")]
    [SupportedApiProfile("openxr", ["XR_EXT_spatial_entity"], ImpliesSets = ["XR_EXT_future"])]
    ErrorSpatialBufferIdInvalidEXT = -1000740003,

    [NativeName("XR_ERROR_SPATIAL_COMPONENT_UNSUPPORTED_FOR_CAPABILITY_EXT")]
    [SupportedApiProfile("openxr", ["XR_EXT_spatial_entity"], ImpliesSets = ["XR_EXT_future"])]
    ErrorSpatialComponentUnsupportedForCapabilityEXT = -1000740004,

    [NativeName("XR_ERROR_SPATIAL_CAPABILITY_CONFIGURATION_INVALID_EXT")]
    [SupportedApiProfile("openxr", ["XR_EXT_spatial_entity"], ImpliesSets = ["XR_EXT_future"])]
    ErrorSpatialCapabilityConfigurationInvalidEXT = -1000740005,

    [NativeName("XR_ERROR_SPATIAL_COMPONENT_NOT_ENABLED_EXT")]
    [SupportedApiProfile("openxr", ["XR_EXT_spatial_entity"], ImpliesSets = ["XR_EXT_future"])]
    ErrorSpatialComponentNotEnabledEXT = -1000740006,

    [NativeName("XR_ERROR_SPATIAL_PERSISTENCE_SCOPE_UNSUPPORTED_EXT")]
    [SupportedApiProfile(
        "openxr",
        ["XR_EXT_spatial_persistence"],
        ImpliesSets = ["XR_EXT_future", "XR_EXT_spatial_entity"]
    )]
    ErrorSpatialPersistenceScopeUnsupportedEXT = -1000763001,

    [NativeName("XR_ERROR_SPATIAL_PERSISTENCE_SCOPE_INCOMPATIBLE_EXT")]
    [SupportedApiProfile(
        "openxr",
        ["XR_EXT_spatial_persistence_operations"],
        ImpliesSets = ["XR_EXT_future", "XR_EXT_spatial_persistence"]
    )]
    ErrorSpatialPersistenceScopeIncompatibleEXT = -1000781001,

    [NativeName("XR_ERROR_SPATIAL_ANCHOR_ATTACHABLE_COMPONENT_NOT_FOUND_ANDROID")]
    [SupportedApiProfile(
        "openxr",
        ["XR_ANDROID_spatial_entity_bound_anchor"],
        ImpliesSets = ["XR_EXT_spatial_anchor"]
    )]
    ErrorSpatialAnchorAttachableComponentNotFoundANDROID = -1000790001,

    [NativeName("XR_ERROR_SPATIAL_ANCHOR_ENTITY_ID_INVALID_ANDROID")]
    [SupportedApiProfile(
        "openxr",
        ["XR_ANDROID_spatial_anchor_space"],
        ImpliesSets = ["XR_EXT_spatial_anchor"]
    )]
    ErrorSpatialAnchorEntityIdInvalidANDROID = -1000795001,

    [NativeName("XR_ERROR_EXTENSION_DEPENDENCY_NOT_ENABLED_KHR")]
    [SupportedApiProfile("openxr", ["XR_KHR_maintenance1"])]
    ErrorExtensionDependencyNotEnabledKHR = ErrorExtensionDependencyNotEnabled,

    [NativeName("XR_ERROR_PERMISSION_INSUFFICIENT_KHR")]
    [SupportedApiProfile("openxr", ["XR_KHR_maintenance1"])]
    ErrorPermissionInsufficientKHR = ErrorPermissionInsufficient,
}
