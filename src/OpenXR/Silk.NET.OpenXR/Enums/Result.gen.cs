// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenXR
{
    [NativeName("Name", "XrResult")]
    public enum Result : int
    {
        [NativeName("Name", "XR_SUCCESS")]
        Success = 0,
        [NativeName("Name", "XR_TIMEOUT_EXPIRED")]
        TimeoutExpired = 1,
        [NativeName("Name", "XR_SESSION_LOSS_PENDING")]
        SessionLossPending = 3,
        [NativeName("Name", "XR_EVENT_UNAVAILABLE")]
        EventUnavailable = 4,
        [NativeName("Name", "XR_SPACE_BOUNDS_UNAVAILABLE")]
        SpaceBoundsUnavailable = 7,
        [NativeName("Name", "XR_SESSION_NOT_FOCUSED")]
        SessionNotFocused = 8,
        [NativeName("Name", "XR_FRAME_DISCARDED")]
        FrameDiscarded = 9,
        [NativeName("Name", "XR_ERROR_VALIDATION_FAILURE")]
        ErrorValidationFailure = unchecked((int) -1),
        [NativeName("Name", "XR_ERROR_RUNTIME_FAILURE")]
        ErrorRuntimeFailure = unchecked((int) -2),
        [NativeName("Name", "XR_ERROR_OUT_OF_MEMORY")]
        ErrorOutOfMemory = unchecked((int) -3),
        [NativeName("Name", "XR_ERROR_API_VERSION_UNSUPPORTED")]
        ErrorApiVersionUnsupported = unchecked((int) -4),
        [NativeName("Name", "XR_ERROR_INITIALIZATION_FAILED")]
        ErrorInitializationFailed = unchecked((int) -6),
        [NativeName("Name", "XR_ERROR_FUNCTION_UNSUPPORTED")]
        ErrorFunctionUnsupported = unchecked((int) -7),
        [NativeName("Name", "XR_ERROR_FEATURE_UNSUPPORTED")]
        ErrorFeatureUnsupported = unchecked((int) -8),
        [NativeName("Name", "XR_ERROR_EXTENSION_NOT_PRESENT")]
        ErrorExtensionNotPresent = unchecked((int) -9),
        [NativeName("Name", "XR_ERROR_LIMIT_REACHED")]
        ErrorLimitReached = unchecked((int) -10),
        [NativeName("Name", "XR_ERROR_SIZE_INSUFFICIENT")]
        ErrorSizeInsufficient = unchecked((int) -11),
        [NativeName("Name", "XR_ERROR_HANDLE_INVALID")]
        ErrorHandleInvalid = unchecked((int) -12),
        [NativeName("Name", "XR_ERROR_INSTANCE_LOST")]
        ErrorInstanceLost = unchecked((int) -13),
        [NativeName("Name", "XR_ERROR_SESSION_RUNNING")]
        ErrorSessionRunning = unchecked((int) -14),
        [NativeName("Name", "XR_ERROR_SESSION_NOT_RUNNING")]
        ErrorSessionNotRunning = unchecked((int) -16),
        [NativeName("Name", "XR_ERROR_SESSION_LOST")]
        ErrorSessionLost = unchecked((int) -17),
        [NativeName("Name", "XR_ERROR_SYSTEM_INVALID")]
        ErrorSystemInvalid = unchecked((int) -18),
        [NativeName("Name", "XR_ERROR_PATH_INVALID")]
        ErrorPathInvalid = unchecked((int) -19),
        [NativeName("Name", "XR_ERROR_PATH_COUNT_EXCEEDED")]
        ErrorPathCountExceeded = unchecked((int) -20),
        [NativeName("Name", "XR_ERROR_PATH_FORMAT_INVALID")]
        ErrorPathFormatInvalid = unchecked((int) -21),
        [NativeName("Name", "XR_ERROR_PATH_UNSUPPORTED")]
        ErrorPathUnsupported = unchecked((int) -22),
        [NativeName("Name", "XR_ERROR_LAYER_INVALID")]
        ErrorLayerInvalid = unchecked((int) -23),
        [NativeName("Name", "XR_ERROR_LAYER_LIMIT_EXCEEDED")]
        ErrorLayerLimitExceeded = unchecked((int) -24),
        [NativeName("Name", "XR_ERROR_SWAPCHAIN_RECT_INVALID")]
        ErrorSwapchainRectInvalid = unchecked((int) -25),
        [NativeName("Name", "XR_ERROR_SWAPCHAIN_FORMAT_UNSUPPORTED")]
        ErrorSwapchainFormatUnsupported = unchecked((int) -26),
        [NativeName("Name", "XR_ERROR_ACTION_TYPE_MISMATCH")]
        ErrorActionTypeMismatch = unchecked((int) -27),
        [NativeName("Name", "XR_ERROR_SESSION_NOT_READY")]
        ErrorSessionNotReady = unchecked((int) -28),
        [NativeName("Name", "XR_ERROR_SESSION_NOT_STOPPING")]
        ErrorSessionNotStopping = unchecked((int) -29),
        [NativeName("Name", "XR_ERROR_TIME_INVALID")]
        ErrorTimeInvalid = unchecked((int) -30),
        [NativeName("Name", "XR_ERROR_REFERENCE_SPACE_UNSUPPORTED")]
        ErrorReferenceSpaceUnsupported = unchecked((int) -31),
        [NativeName("Name", "XR_ERROR_FILE_ACCESS_ERROR")]
        ErrorFileAccessError = unchecked((int) -32),
        [NativeName("Name", "XR_ERROR_FILE_CONTENTS_INVALID")]
        ErrorFileContentsInvalid = unchecked((int) -33),
        [NativeName("Name", "XR_ERROR_FORM_FACTOR_UNSUPPORTED")]
        ErrorFormFactorUnsupported = unchecked((int) -34),
        [NativeName("Name", "XR_ERROR_FORM_FACTOR_UNAVAILABLE")]
        ErrorFormFactorUnavailable = unchecked((int) -35),
        [NativeName("Name", "XR_ERROR_API_LAYER_NOT_PRESENT")]
        ErrorApiLayerNotPresent = unchecked((int) -36),
        [NativeName("Name", "XR_ERROR_CALL_ORDER_INVALID")]
        ErrorCallOrderInvalid = unchecked((int) -37),
        [NativeName("Name", "XR_ERROR_GRAPHICS_DEVICE_INVALID")]
        ErrorGraphicsDeviceInvalid = unchecked((int) -38),
        [NativeName("Name", "XR_ERROR_POSE_INVALID")]
        ErrorPoseInvalid = unchecked((int) -39),
        [NativeName("Name", "XR_ERROR_INDEX_OUT_OF_RANGE")]
        ErrorIndexOutOfRange = unchecked((int) -40),
        [NativeName("Name", "XR_ERROR_VIEW_CONFIGURATION_TYPE_UNSUPPORTED")]
        ErrorViewConfigurationTypeUnsupported = unchecked((int) -41),
        [NativeName("Name", "XR_ERROR_ENVIRONMENT_BLEND_MODE_UNSUPPORTED")]
        ErrorEnvironmentBlendModeUnsupported = unchecked((int) -42),
        [NativeName("Name", "XR_ERROR_NAME_DUPLICATED")]
        ErrorNameDuplicated = unchecked((int) -44),
        [NativeName("Name", "XR_ERROR_NAME_INVALID")]
        ErrorNameInvalid = unchecked((int) -45),
        [NativeName("Name", "XR_ERROR_ACTIONSET_NOT_ATTACHED")]
        ErrorActionsetNotAttached = unchecked((int) -46),
        [NativeName("Name", "XR_ERROR_ACTIONSETS_ALREADY_ATTACHED")]
        ErrorActionsetsAlreadyAttached = unchecked((int) -47),
        [NativeName("Name", "XR_ERROR_LOCALIZED_NAME_DUPLICATED")]
        ErrorLocalizedNameDuplicated = unchecked((int) -48),
        [NativeName("Name", "XR_ERROR_LOCALIZED_NAME_INVALID")]
        ErrorLocalizedNameInvalid = unchecked((int) -49),
        [NativeName("Name", "XR_ERROR_GRAPHICS_REQUIREMENTS_CALL_MISSING")]
        ErrorGraphicsRequirementsCallMissing = unchecked((int) -50),
        [NativeName("Name", "XR_ERROR_RUNTIME_UNAVAILABLE")]
        ErrorRuntimeUnavailable = unchecked((int) -51),
        [NativeName("Name", "XR_ERROR_ANDROID_THREAD_SETTINGS_ID_INVALID_KHR")]
        ErrorAndroidThreadSettingsIDInvalidKhr = unchecked((int) -1000003000),
        [NativeName("Name", "XR_ERROR_ANDROID_THREAD_SETTINGS_FAILURE_KHR")]
        ErrorAndroidThreadSettingsFailureKhr = unchecked((int) -1000003001),
        [NativeName("Name", "XR_ERROR_CREATE_SPATIAL_ANCHOR_FAILED_MSFT")]
        ErrorCreateSpatialAnchorFailedMsft = unchecked((int) -1000039001),
        [NativeName("Name", "XR_ERROR_SECONDARY_VIEW_CONFIGURATION_TYPE_NOT_ENABLED_MSFT")]
        ErrorSecondaryViewConfigurationTypeNotEnabledMsft = unchecked((int) -1000053000),
        [NativeName("Name", "XR_ERROR_CONTROLLER_MODEL_KEY_INVALID_MSFT")]
        ErrorControllerModelKeyInvalidMsft = unchecked((int) -1000055000),
        [NativeName("Name", "XR_ERROR_REPROJECTION_MODE_UNSUPPORTED_MSFT")]
        ErrorReprojectionModeUnsupportedMsft = unchecked((int) -1000066000),
        [NativeName("Name", "XR_ERROR_COMPUTE_NEW_SCENE_NOT_COMPLETED_MSFT")]
        ErrorComputeNewSceneNotCompletedMsft = unchecked((int) -1000097000),
        [NativeName("Name", "XR_ERROR_SCENE_COMPONENT_ID_INVALID_MSFT")]
        ErrorSceneComponentIDInvalidMsft = unchecked((int) -1000097001),
        [NativeName("Name", "XR_ERROR_SCENE_COMPONENT_TYPE_MISMATCH_MSFT")]
        ErrorSceneComponentTypeMismatchMsft = unchecked((int) -1000097002),
        [NativeName("Name", "XR_ERROR_SCENE_MESH_BUFFER_ID_INVALID_MSFT")]
        ErrorSceneMeshBufferIDInvalidMsft = unchecked((int) -1000097003),
        [NativeName("Name", "XR_ERROR_SCENE_COMPUTE_FEATURE_INCOMPATIBLE_MSFT")]
        ErrorSceneComputeFeatureIncompatibleMsft = unchecked((int) -1000097004),
        [NativeName("Name", "XR_ERROR_SCENE_COMPUTE_CONSISTENCY_MISMATCH_MSFT")]
        ErrorSceneComputeConsistencyMismatchMsft = unchecked((int) -1000097005),
        [NativeName("Name", "XR_ERROR_DISPLAY_REFRESH_RATE_UNSUPPORTED_FB")]
        ErrorDisplayRefreshRateUnsupportedFB = unchecked((int) -1000101000),
        [NativeName("Name", "XR_ERROR_COLOR_SPACE_UNSUPPORTED_FB")]
        ErrorColorSpaceUnsupportedFB = unchecked((int) -1000108000),
        [NativeName("Name", "XR_ERROR_SPACE_COMPONENT_NOT_SUPPORTED_FB")]
        ErrorSpaceComponentNotSupportedFB = unchecked((int) -1000113000),
        [NativeName("Name", "XR_ERROR_SPACE_COMPONENT_NOT_ENABLED_FB")]
        ErrorSpaceComponentNotEnabledFB = unchecked((int) -1000113001),
        [NativeName("Name", "XR_ERROR_SPACE_COMPONENT_STATUS_PENDING_FB")]
        ErrorSpaceComponentStatusPendingFB = unchecked((int) -1000113002),
        [NativeName("Name", "XR_ERROR_SPACE_COMPONENT_STATUS_ALREADY_SET_FB")]
        ErrorSpaceComponentStatusAlreadySetFB = unchecked((int) -1000113003),
        [NativeName("Name", "XR_ERROR_UNEXPECTED_STATE_PASSTHROUGH_FB")]
        ErrorUnexpectedStatePassthroughFB = unchecked((int) -1000118000),
        [NativeName("Name", "XR_ERROR_FEATURE_ALREADY_CREATED_PASSTHROUGH_FB")]
        ErrorFeatureAlreadyCreatedPassthroughFB = unchecked((int) -1000118001),
        [NativeName("Name", "XR_ERROR_FEATURE_REQUIRED_PASSTHROUGH_FB")]
        ErrorFeatureRequiredPassthroughFB = unchecked((int) -1000118002),
        [NativeName("Name", "XR_ERROR_NOT_PERMITTED_PASSTHROUGH_FB")]
        ErrorNotPermittedPassthroughFB = unchecked((int) -1000118003),
        [NativeName("Name", "XR_ERROR_INSUFFICIENT_RESOURCES_PASSTHROUGH_FB")]
        ErrorInsufficientResourcesPassthroughFB = unchecked((int) -1000118004),
        [NativeName("Name", "XR_ERROR_UNKNOWN_PASSTHROUGH_FB")]
        ErrorUnknownPassthroughFB = unchecked((int) -1000118050),
        [NativeName("Name", "XR_ERROR_RENDER_MODEL_KEY_INVALID_FB")]
        ErrorRenderModelKeyInvalidFB = unchecked((int) -1000119000),
        [NativeName("Name", "XR_RENDER_MODEL_UNAVAILABLE_FB")]
        RenderModelUnavailableFB = 1000119020,
        [NativeName("Name", "XR_ERROR_MARKER_NOT_TRACKED_VARJO")]
        ErrorMarkerNotTrackedVarjo = unchecked((int) -1000124000),
        [NativeName("Name", "XR_ERROR_MARKER_ID_INVALID_VARJO")]
        ErrorMarkerIDInvalidVarjo = unchecked((int) -1000124001),
        [NativeName("Name", "XR_ERROR_MARKER_DETECTOR_PERMISSION_DENIED_ML")]
        ErrorMarkerDetectorPermissionDeniedML = unchecked((int) -1000138000),
        [NativeName("Name", "XR_ERROR_MARKER_DETECTOR_LOCATE_FAILED_ML")]
        ErrorMarkerDetectorLocateFailedML = unchecked((int) -1000138001),
        [NativeName("Name", "XR_ERROR_MARKER_DETECTOR_INVALID_DATA_QUERY_ML")]
        ErrorMarkerDetectorInvalidDataQueryML = unchecked((int) -1000138002),
        [NativeName("Name", "XR_ERROR_MARKER_DETECTOR_INVALID_CREATE_INFO_ML")]
        ErrorMarkerDetectorInvalidCreateInfoML = unchecked((int) -1000138003),
        [NativeName("Name", "XR_ERROR_MARKER_INVALID_ML")]
        ErrorMarkerInvalidML = unchecked((int) -1000138004),
        [NativeName("Name", "XR_ERROR_LOCALIZATION_MAP_INCOMPATIBLE_ML")]
        ErrorLocalizationMapIncompatibleML = unchecked((int) -1000139000),
        [NativeName("Name", "XR_ERROR_LOCALIZATION_MAP_UNAVAILABLE_ML")]
        ErrorLocalizationMapUnavailableML = unchecked((int) -1000139001),
        [NativeName("Name", "XR_ERROR_LOCALIZATION_MAP_FAIL_ML")]
        ErrorLocalizationMapFailML = unchecked((int) -1000139002),
        [NativeName("Name", "XR_ERROR_LOCALIZATION_MAP_IMPORT_EXPORT_PERMISSION_DENIED_ML")]
        ErrorLocalizationMapImportExportPermissionDeniedML = unchecked((int) -1000139003),
        [NativeName("Name", "XR_ERROR_LOCALIZATION_MAP_PERMISSION_DENIED_ML")]
        ErrorLocalizationMapPermissionDeniedML = unchecked((int) -1000139004),
        [NativeName("Name", "XR_ERROR_LOCALIZATION_MAP_ALREADY_EXISTS_ML")]
        ErrorLocalizationMapAlreadyExistsML = unchecked((int) -1000139005),
        [NativeName("Name", "XR_ERROR_LOCALIZATION_MAP_CANNOT_EXPORT_CLOUD_MAP_ML")]
        ErrorLocalizationMapCannotExportCloudMapML = unchecked((int) -1000139006),
        [NativeName("Name", "XR_ERROR_SPATIAL_ANCHORS_PERMISSION_DENIED_ML")]
        ErrorSpatialAnchorsPermissionDeniedML = unchecked((int) -1000140000),
        [NativeName("Name", "XR_ERROR_SPATIAL_ANCHORS_NOT_LOCALIZED_ML")]
        ErrorSpatialAnchorsNotLocalizedML = unchecked((int) -1000140001),
        [NativeName("Name", "XR_ERROR_SPATIAL_ANCHORS_OUT_OF_MAP_BOUNDS_ML")]
        ErrorSpatialAnchorsOutOfMapBoundsML = unchecked((int) -1000140002),
        [NativeName("Name", "XR_ERROR_SPATIAL_ANCHORS_SPACE_NOT_LOCATABLE_ML")]
        ErrorSpatialAnchorsSpaceNotLocatableML = unchecked((int) -1000140003),
        [NativeName("Name", "XR_ERROR_SPATIAL_ANCHORS_ANCHOR_NOT_FOUND_ML")]
        ErrorSpatialAnchorsAnchorNotFoundML = unchecked((int) -1000141000),
        [NativeName("Name", "XR_ERROR_SPATIAL_ANCHOR_NAME_NOT_FOUND_MSFT")]
        ErrorSpatialAnchorNameNotFoundMsft = unchecked((int) -1000142001),
        [NativeName("Name", "XR_ERROR_SPATIAL_ANCHOR_NAME_INVALID_MSFT")]
        ErrorSpatialAnchorNameInvalidMsft = unchecked((int) -1000142002),
        [NativeName("Name", "XR_SCENE_MARKER_DATA_NOT_STRING_MSFT")]
        SceneMarkerDataNotStringMsft = 1000147000,
        [NativeName("Name", "XR_ERROR_SPACE_MAPPING_INSUFFICIENT_FB")]
        ErrorSpaceMappingInsufficientFB = unchecked((int) -1000169000),
        [NativeName("Name", "XR_ERROR_SPACE_LOCALIZATION_FAILED_FB")]
        ErrorSpaceLocalizationFailedFB = unchecked((int) -1000169001),
        [NativeName("Name", "XR_ERROR_SPACE_NETWORK_TIMEOUT_FB")]
        ErrorSpaceNetworkTimeoutFB = unchecked((int) -1000169002),
        [NativeName("Name", "XR_ERROR_SPACE_NETWORK_REQUEST_FAILED_FB")]
        ErrorSpaceNetworkRequestFailedFB = unchecked((int) -1000169003),
        [NativeName("Name", "XR_ERROR_SPACE_CLOUD_STORAGE_DISABLED_FB")]
        ErrorSpaceCloudStorageDisabledFB = unchecked((int) -1000169004),
        [NativeName("Name", "XR_ERROR_PASSTHROUGH_COLOR_LUT_BUFFER_SIZE_MISMATCH_META")]
        ErrorPassthroughColorLutBufferSizeMismatchMeta = unchecked((int) -1000266000),
        [NativeName("Name", "XR_ENVIRONMENT_DEPTH_NOT_AVAILABLE_META")]
        EnvironmentDepthNotAvailableMeta = 1000291000,
        [NativeName("Name", "XR_ERROR_HINT_ALREADY_SET_QCOM")]
        ErrorHintAlreadySetQCom = unchecked((int) -1000306000),
        [NativeName("Name", "XR_ERROR_NOT_AN_ANCHOR_HTC")]
        ErrorNotANAnchorHtc = unchecked((int) -1000319000),
        [NativeName("Name", "XR_ERROR_SPACE_NOT_LOCATABLE_EXT")]
        ErrorSpaceNotLocatableExt = unchecked((int) -1000429000),
        [NativeName("Name", "XR_ERROR_PLANE_DETECTION_PERMISSION_DENIED_EXT")]
        ErrorPlaneDetectionPermissionDeniedExt = unchecked((int) -1000429001),
        [NativeName("Name", "XR_ERROR_FUTURE_PENDING_EXT")]
        ErrorFuturePendingExt = unchecked((int) -1000469001),
        [NativeName("Name", "XR_ERROR_FUTURE_INVALID_EXT")]
        ErrorFutureInvalidExt = unchecked((int) -1000469002),
        [NativeName("Name", "XR_ERROR_SYSTEM_NOTIFICATION_PERMISSION_DENIED_ML")]
        ErrorSystemNotificationPermissionDeniedML = unchecked((int) -1000473000),
        [NativeName("Name", "XR_ERROR_SYSTEM_NOTIFICATION_INCOMPATIBLE_SKU_ML")]
        ErrorSystemNotificationIncompatibleSkuML = unchecked((int) -1000473001),
        [NativeName("Name", "XR_ERROR_WORLD_MESH_DETECTOR_PERMISSION_DENIED_ML")]
        ErrorWorldMeshDetectorPermissionDeniedML = unchecked((int) -1000474000),
        [NativeName("Name", "XR_ERROR_WORLD_MESH_DETECTOR_SPACE_NOT_LOCATABLE_ML")]
        ErrorWorldMeshDetectorSpaceNotLocatableML = unchecked((int) -1000474001),
        [NativeName("Name", "XR_ERROR_EXTENSION_DEPENDENCY_NOT_ENABLED_KHR")]
        ErrorExtensionDependencyNotEnabledKhr = unchecked((int) -1000710001),
        [NativeName("Name", "XR_ERROR_PERMISSION_INSUFFICIENT_KHR")]
        ErrorPermissionInsufficientKhr = unchecked((int) -1000710000),
        [NativeName("Name", "XR_ERROR_EXTENSION_DEPENDENCY_NOT_ENABLED")]
        ErrorExtensionDependencyNotEnabled = unchecked((int) -1000710001),
        [NativeName("Name", "XR_ERROR_PERMISSION_INSUFFICIENT")]
        ErrorPermissionInsufficient = unchecked((int) -1000710000),
    }
}
