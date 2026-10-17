// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrResult")]
public enum Result
{
    [NativeName("XR_SUCCESS")]
    Success = 0,

    [NativeName("XR_TIMEOUT_EXPIRED")]
    TimeoutExpired = 1,

    [NativeName("XR_SESSION_LOSS_PENDING")]
    SessionLossPending = 3,

    [NativeName("XR_EVENT_UNAVAILABLE")]
    EventUnavailable = 4,

    [NativeName("XR_SPACE_BOUNDS_UNAVAILABLE")]
    SpaceBoundsUnavailable = 7,

    [NativeName("XR_SESSION_NOT_FOCUSED")]
    SessionNotFocused = 8,

    [NativeName("XR_FRAME_DISCARDED")]
    FrameDiscarded = 9,

    [NativeName("XR_ERROR_VALIDATION_FAILURE")]
    ErrorValidationFailure = -1,

    [NativeName("XR_ERROR_RUNTIME_FAILURE")]
    ErrorRuntimeFailure = -2,

    [NativeName("XR_ERROR_OUT_OF_MEMORY")]
    ErrorOutOfMemory = -3,

    [NativeName("XR_ERROR_API_VERSION_UNSUPPORTED")]
    ErrorApiVersionUnsupported = -4,

    [NativeName("XR_ERROR_INITIALIZATION_FAILED")]
    ErrorInitializationFailed = -6,

    [NativeName("XR_ERROR_FUNCTION_UNSUPPORTED")]
    ErrorFunctionUnsupported = -7,

    [NativeName("XR_ERROR_FEATURE_UNSUPPORTED")]
    ErrorFeatureUnsupported = -8,

    [NativeName("XR_ERROR_EXTENSION_NOT_PRESENT")]
    ErrorExtensionNotPresent = -9,

    [NativeName("XR_ERROR_LIMIT_REACHED")]
    ErrorLimitReached = -10,

    [NativeName("XR_ERROR_SIZE_INSUFFICIENT")]
    ErrorSizeInsufficient = -11,

    [NativeName("XR_ERROR_HANDLE_INVALID")]
    ErrorHandleInvalid = -12,

    [NativeName("XR_ERROR_INSTANCE_LOST")]
    ErrorInstanceLost = -13,

    [NativeName("XR_ERROR_SESSION_RUNNING")]
    ErrorSessionRunning = -14,

    [NativeName("XR_ERROR_SESSION_NOT_RUNNING")]
    ErrorSessionNotRunning = -16,

    [NativeName("XR_ERROR_SESSION_LOST")]
    ErrorSessionLost = -17,

    [NativeName("XR_ERROR_SYSTEM_INVALID")]
    ErrorSystemInvalid = -18,

    [NativeName("XR_ERROR_PATH_INVALID")]
    ErrorPathInvalid = -19,

    [NativeName("XR_ERROR_PATH_COUNT_EXCEEDED")]
    ErrorPathCountExceeded = -20,

    [NativeName("XR_ERROR_PATH_FORMAT_INVALID")]
    ErrorPathFormatInvalid = -21,

    [NativeName("XR_ERROR_PATH_UNSUPPORTED")]
    ErrorPathUnsupported = -22,

    [NativeName("XR_ERROR_LAYER_INVALID")]
    ErrorLayerInvalid = -23,

    [NativeName("XR_ERROR_LAYER_LIMIT_EXCEEDED")]
    ErrorLayerLimitExceeded = -24,

    [NativeName("XR_ERROR_SWAPCHAIN_RECT_INVALID")]
    ErrorSwapchainRectInvalid = -25,

    [NativeName("XR_ERROR_SWAPCHAIN_FORMAT_UNSUPPORTED")]
    ErrorSwapchainFormatUnsupported = -26,

    [NativeName("XR_ERROR_ACTION_TYPE_MISMATCH")]
    ErrorActionTypeMismatch = -27,

    [NativeName("XR_ERROR_SESSION_NOT_READY")]
    ErrorSessionNotReady = -28,

    [NativeName("XR_ERROR_SESSION_NOT_STOPPING")]
    ErrorSessionNotStopping = -29,

    [NativeName("XR_ERROR_TIME_INVALID")]
    ErrorTimeInvalid = -30,

    [NativeName("XR_ERROR_REFERENCE_SPACE_UNSUPPORTED")]
    ErrorReferenceSpaceUnsupported = -31,

    [NativeName("XR_ERROR_FILE_ACCESS_ERROR")]
    ErrorFileAccessError = -32,

    [NativeName("XR_ERROR_FILE_CONTENTS_INVALID")]
    ErrorFileContentsInvalid = -33,

    [NativeName("XR_ERROR_FORM_FACTOR_UNSUPPORTED")]
    ErrorFormFactorUnsupported = -34,

    [NativeName("XR_ERROR_FORM_FACTOR_UNAVAILABLE")]
    ErrorFormFactorUnavailable = -35,

    [NativeName("XR_ERROR_API_LAYER_NOT_PRESENT")]
    ErrorApiLayerNotPresent = -36,

    [NativeName("XR_ERROR_CALL_ORDER_INVALID")]
    ErrorCallOrderInvalid = -37,

    [NativeName("XR_ERROR_GRAPHICS_DEVICE_INVALID")]
    ErrorGraphicsDeviceInvalid = -38,

    [NativeName("XR_ERROR_POSE_INVALID")]
    ErrorPoseInvalid = -39,

    [NativeName("XR_ERROR_INDEX_OUT_OF_RANGE")]
    ErrorIndexOutOfRange = -40,

    [NativeName("XR_ERROR_VIEW_CONFIGURATION_TYPE_UNSUPPORTED")]
    ErrorViewConfigurationTypeUnsupported = -41,

    [NativeName("XR_ERROR_ENVIRONMENT_BLEND_MODE_UNSUPPORTED")]
    ErrorEnvironmentBlendModeUnsupported = -42,

    [NativeName("XR_ERROR_NAME_DUPLICATED")]
    ErrorNameDuplicated = -44,

    [NativeName("XR_ERROR_NAME_INVALID")]
    ErrorNameInvalid = -45,

    [NativeName("XR_ERROR_ACTIONSET_NOT_ATTACHED")]
    ErrorActionsetNotAttached = -46,

    [NativeName("XR_ERROR_ACTIONSETS_ALREADY_ATTACHED")]
    ErrorActionsetsAlreadyAttached = -47,

    [NativeName("XR_ERROR_LOCALIZED_NAME_DUPLICATED")]
    ErrorLocalizedNameDuplicated = -48,

    [NativeName("XR_ERROR_LOCALIZED_NAME_INVALID")]
    ErrorLocalizedNameInvalid = -49,

    [NativeName("XR_ERROR_GRAPHICS_REQUIREMENTS_CALL_MISSING")]
    ErrorGraphicsRequirementsCallMissing = -50,

    [NativeName("XR_ERROR_RUNTIME_UNAVAILABLE")]
    ErrorRuntimeUnavailable = -51,

    [NativeName("XR_ERROR_EXTENSION_DEPENDENCY_NOT_ENABLED")]
    ErrorExtensionDependencyNotEnabled = -1000710001,

    [NativeName("XR_ERROR_PERMISSION_INSUFFICIENT")]
    ErrorPermissionInsufficient = -1000710000,

    [NativeName("XR_ERROR_ANDROID_THREAD_SETTINGS_ID_INVALID_KHR")]
    ErrorAndroidThreadSettingsIdInvalidKHR = -1000003000,

    [NativeName("XR_ERROR_ANDROID_THREAD_SETTINGS_FAILURE_KHR")]
    ErrorAndroidThreadSettingsFailureKHR = -1000003001,

    [NativeName("XR_ERROR_CREATE_SPATIAL_ANCHOR_FAILED_MSFT")]
    ErrorCreateSpatialAnchorFailedMSFT = -1000039001,

    [NativeName("XR_ERROR_SECONDARY_VIEW_CONFIGURATION_TYPE_NOT_ENABLED_MSFT")]
    ErrorSecondaryViewConfigurationTypeNotEnabledMSFT = -1000053000,

    [NativeName("XR_ERROR_CONTROLLER_MODEL_KEY_INVALID_MSFT")]
    ErrorControllerModelKeyInvalidMSFT = -1000055000,

    [NativeName("XR_ERROR_REPROJECTION_MODE_UNSUPPORTED_MSFT")]
    ErrorReprojectionModeUnsupportedMSFT = -1000066000,

    [NativeName("XR_ERROR_COMPUTE_NEW_SCENE_NOT_COMPLETED_MSFT")]
    ErrorComputeNewSceneNotCompletedMSFT = -1000097000,

    [NativeName("XR_ERROR_SCENE_COMPONENT_ID_INVALID_MSFT")]
    ErrorSceneComponentIdInvalidMSFT = -1000097001,

    [NativeName("XR_ERROR_SCENE_COMPONENT_TYPE_MISMATCH_MSFT")]
    ErrorSceneComponentTypeMismatchMSFT = -1000097002,

    [NativeName("XR_ERROR_SCENE_MESH_BUFFER_ID_INVALID_MSFT")]
    ErrorSceneMeshBufferIdInvalidMSFT = -1000097003,

    [NativeName("XR_ERROR_SCENE_COMPUTE_FEATURE_INCOMPATIBLE_MSFT")]
    ErrorSceneComputeFeatureIncompatibleMSFT = -1000097004,

    [NativeName("XR_ERROR_SCENE_COMPUTE_CONSISTENCY_MISMATCH_MSFT")]
    ErrorSceneComputeConsistencyMismatchMSFT = -1000097005,

    [NativeName("XR_ERROR_DISPLAY_REFRESH_RATE_UNSUPPORTED_FB")]
    ErrorDisplayRefreshRateUnsupportedFB = -1000101000,

    [NativeName("XR_ERROR_COLOR_SPACE_UNSUPPORTED_FB")]
    ErrorColorSpaceUnsupportedFB = -1000108000,

    [NativeName("XR_ERROR_SPACE_COMPONENT_NOT_SUPPORTED_FB")]
    ErrorSpaceComponentNotSupportedFB = -1000113000,

    [NativeName("XR_ERROR_SPACE_COMPONENT_NOT_ENABLED_FB")]
    ErrorSpaceComponentNotEnabledFB = -1000113001,

    [NativeName("XR_ERROR_SPACE_COMPONENT_STATUS_PENDING_FB")]
    ErrorSpaceComponentStatusPendingFB = -1000113002,

    [NativeName("XR_ERROR_SPACE_COMPONENT_STATUS_ALREADY_SET_FB")]
    ErrorSpaceComponentStatusAlreadySetFB = -1000113003,

    [NativeName("XR_ERROR_UNEXPECTED_STATE_PASSTHROUGH_FB")]
    ErrorUnexpectedStatePassthroughFB = -1000118000,

    [NativeName("XR_ERROR_FEATURE_ALREADY_CREATED_PASSTHROUGH_FB")]
    ErrorFeatureAlreadyCreatedPassthroughFB = -1000118001,

    [NativeName("XR_ERROR_FEATURE_REQUIRED_PASSTHROUGH_FB")]
    ErrorFeatureRequiredPassthroughFB = -1000118002,

    [NativeName("XR_ERROR_NOT_PERMITTED_PASSTHROUGH_FB")]
    ErrorNotPermittedPassthroughFB = -1000118003,

    [NativeName("XR_ERROR_INSUFFICIENT_RESOURCES_PASSTHROUGH_FB")]
    ErrorInsufficientResourcesPassthroughFB = -1000118004,

    [NativeName("XR_ERROR_UNKNOWN_PASSTHROUGH_FB")]
    ErrorUnknownPassthroughFB = -1000118050,

    [NativeName("XR_ERROR_RENDER_MODEL_KEY_INVALID_FB")]
    ErrorRenderModelKeyInvalidFB = -1000119000,

    [NativeName("XR_RENDER_MODEL_UNAVAILABLE_FB")]
    RenderModelUnavailableFB = 1000119020,

    [NativeName("XR_ERROR_MARKER_NOT_TRACKED_VARJO")]
    ErrorMarkerNotTrackedVARJO = -1000124000,

    [NativeName("XR_ERROR_MARKER_ID_INVALID_VARJO")]
    ErrorMarkerIdInvalidVARJO = -1000124001,

    [NativeName("XR_ERROR_MARKER_DETECTOR_PERMISSION_DENIED_ML")]
    ErrorMarkerDetectorPermissionDeniedML = -1000138000,

    [NativeName("XR_ERROR_MARKER_DETECTOR_LOCATE_FAILED_ML")]
    ErrorMarkerDetectorLocateFailedML = -1000138001,

    [NativeName("XR_ERROR_MARKER_DETECTOR_INVALID_DATA_QUERY_ML")]
    ErrorMarkerDetectorInvalidDataQueryML = -1000138002,

    [NativeName("XR_ERROR_MARKER_DETECTOR_INVALID_CREATE_INFO_ML")]
    ErrorMarkerDetectorInvalidCreateInfoML = -1000138003,

    [NativeName("XR_ERROR_MARKER_INVALID_ML")]
    ErrorMarkerInvalidML = -1000138004,

    [NativeName("XR_ERROR_LOCALIZATION_MAP_INCOMPATIBLE_ML")]
    ErrorLocalizationMapIncompatibleML = -1000139000,

    [NativeName("XR_ERROR_LOCALIZATION_MAP_UNAVAILABLE_ML")]
    ErrorLocalizationMapUnavailableML = -1000139001,

    [NativeName("XR_ERROR_LOCALIZATION_MAP_FAIL_ML")]
    ErrorLocalizationMapFailML = -1000139002,

    [NativeName("XR_ERROR_LOCALIZATION_MAP_IMPORT_EXPORT_PERMISSION_DENIED_ML")]
    ErrorLocalizationMapImportExportPermissionDeniedML = -1000139003,

    [NativeName("XR_ERROR_LOCALIZATION_MAP_PERMISSION_DENIED_ML")]
    ErrorLocalizationMapPermissionDeniedML = -1000139004,

    [NativeName("XR_ERROR_LOCALIZATION_MAP_ALREADY_EXISTS_ML")]
    ErrorLocalizationMapAlreadyExistsML = -1000139005,

    [NativeName("XR_ERROR_LOCALIZATION_MAP_CANNOT_EXPORT_CLOUD_MAP_ML")]
    ErrorLocalizationMapCannotExportCloudMapML = -1000139006,

    [NativeName("XR_ERROR_SPATIAL_ANCHORS_PERMISSION_DENIED_ML")]
    ErrorSpatialAnchorsPermissionDeniedML = -1000140000,

    [NativeName("XR_ERROR_SPATIAL_ANCHORS_NOT_LOCALIZED_ML")]
    ErrorSpatialAnchorsNotLocalizedML = -1000140001,

    [NativeName("XR_ERROR_SPATIAL_ANCHORS_OUT_OF_MAP_BOUNDS_ML")]
    ErrorSpatialAnchorsOutOfMapBoundsML = -1000140002,

    [NativeName("XR_ERROR_SPATIAL_ANCHORS_SPACE_NOT_LOCATABLE_ML")]
    ErrorSpatialAnchorsSpaceNotLocatableML = -1000140003,

    [NativeName("XR_ERROR_SPATIAL_ANCHORS_ANCHOR_NOT_FOUND_ML")]
    ErrorSpatialAnchorsAnchorNotFoundML = -1000141000,

    [NativeName("XR_ERROR_SPATIAL_ANCHOR_NAME_NOT_FOUND_MSFT")]
    ErrorSpatialAnchorNameNotFoundMSFT = -1000142001,

    [NativeName("XR_ERROR_SPATIAL_ANCHOR_NAME_INVALID_MSFT")]
    ErrorSpatialAnchorNameInvalidMSFT = -1000142002,

    [NativeName("XR_SCENE_MARKER_DATA_NOT_STRING_MSFT")]
    SceneMarkerDataNotStringMSFT = 1000147000,

    [NativeName("XR_ERROR_SPACE_MAPPING_INSUFFICIENT_FB")]
    ErrorSpaceMappingInsufficientFB = -1000169000,

    [NativeName("XR_ERROR_SPACE_LOCALIZATION_FAILED_FB")]
    ErrorSpaceLocalizationFailedFB = -1000169001,

    [NativeName("XR_ERROR_SPACE_NETWORK_TIMEOUT_FB")]
    ErrorSpaceNetworkTimeoutFB = -1000169002,

    [NativeName("XR_ERROR_SPACE_NETWORK_REQUEST_FAILED_FB")]
    ErrorSpaceNetworkRequestFailedFB = -1000169003,

    [NativeName("XR_ERROR_SPACE_CLOUD_STORAGE_DISABLED_FB")]
    ErrorSpaceCloudStorageDisabledFB = -1000169004,

    [NativeName("XR_ERROR_SPACE_INSUFFICIENT_RESOURCES_META")]
    ErrorSpaceInsufficientResourcesMETA = -1000259000,

    [NativeName("XR_ERROR_SPACE_STORAGE_AT_CAPACITY_META")]
    ErrorSpaceStorageAtCapacityMETA = -1000259001,

    [NativeName("XR_ERROR_SPACE_INSUFFICIENT_VIEW_META")]
    ErrorSpaceInsufficientViewMETA = -1000259002,

    [NativeName("XR_ERROR_SPACE_PERMISSION_INSUFFICIENT_META")]
    ErrorSpacePermissionInsufficientMETA = -1000259003,

    [NativeName("XR_ERROR_SPACE_RATE_LIMITED_META")]
    ErrorSpaceRateLimitedMETA = -1000259004,

    [NativeName("XR_ERROR_SPACE_TOO_DARK_META")]
    ErrorSpaceTooDarkMETA = -1000259005,

    [NativeName("XR_ERROR_SPACE_TOO_BRIGHT_META")]
    ErrorSpaceTooBrightMETA = -1000259006,

    [NativeName("XR_ERROR_PASSTHROUGH_COLOR_LUT_BUFFER_SIZE_MISMATCH_META")]
    ErrorPassthroughColorLutBufferSizeMismatchMETA = -1000266000,

    [NativeName("XR_ENVIRONMENT_DEPTH_NOT_AVAILABLE_META")]
    EnvironmentDepthNotAvailableMETA = 1000291000,

    [NativeName("XR_ERROR_RENDER_MODEL_ID_INVALID_EXT")]
    ErrorRenderModelIdInvalidEXT = -1000300000,

    [NativeName("XR_ERROR_RENDER_MODEL_ASSET_UNAVAILABLE_EXT")]
    ErrorRenderModelAssetUnavailableEXT = -1000300001,

    [NativeName("XR_ERROR_RENDER_MODEL_GLTF_EXTENSION_REQUIRED_EXT")]
    ErrorRenderModelGltfExtensionRequiredEXT = -1000300002,

    [NativeName("XR_ERROR_NOT_INTERACTION_RENDER_MODEL_EXT")]
    ErrorNotInteractionRenderModelEXT = -1000301000,

    [NativeName("XR_ERROR_HINT_ALREADY_SET_QCOM")]
    ErrorHintAlreadySetQCOM = -1000306000,

    [NativeName("XR_ERROR_NOT_AN_ANCHOR_HTC")]
    ErrorNotAnAnchorHTC = -1000319000,

    [NativeName("XR_ERROR_SPATIAL_ENTITY_ID_INVALID_BD")]
    ErrorSpatialEntityIdInvalidBD = -1000389000,

    [NativeName("XR_ERROR_SPATIAL_SENSING_SERVICE_UNAVAILABLE_BD")]
    ErrorSpatialSensingServiceUnavailableBD = -1000389001,

    [NativeName("XR_ERROR_ANCHOR_NOT_SUPPORTED_FOR_ENTITY_BD")]
    ErrorAnchorNotSupportedForEntityBD = -1000389002,

    [NativeName("XR_ERROR_SPATIAL_ANCHOR_NOT_FOUND_BD")]
    ErrorSpatialAnchorNotFoundBD = -1000390000,

    [NativeName("XR_ERROR_SPATIAL_ANCHOR_SHARING_NETWORK_TIMEOUT_BD")]
    ErrorSpatialAnchorSharingNetworkTimeoutBD = -1000391000,

    [NativeName("XR_ERROR_SPATIAL_ANCHOR_SHARING_AUTHENTICATION_FAILURE_BD")]
    ErrorSpatialAnchorSharingAuthenticationFailureBD = -1000391001,

    [NativeName("XR_ERROR_SPATIAL_ANCHOR_SHARING_NETWORK_FAILURE_BD")]
    ErrorSpatialAnchorSharingNetworkFailureBD = -1000391002,

    [NativeName("XR_ERROR_SPATIAL_ANCHOR_SHARING_LOCALIZATION_FAIL_BD")]
    ErrorSpatialAnchorSharingLocalizationFailBD = -1000391003,

    [NativeName("XR_ERROR_SPATIAL_ANCHOR_SHARING_MAP_INSUFFICIENT_BD")]
    ErrorSpatialAnchorSharingMapInsufficientBD = -1000391004,

    [NativeName("XR_ERROR_SCENE_CAPTURE_FAILURE_BD")]
    ErrorSceneCaptureFailureBD = -1000392000,

    [NativeName("XR_ERROR_SPACE_NOT_LOCATABLE_EXT")]
    ErrorSpaceNotLocatableEXT = -1000429000,

    [NativeName("XR_ERROR_PLANE_DETECTION_PERMISSION_DENIED_EXT")]
    ErrorPlaneDetectionPermissionDeniedEXT = -1000429001,

    [NativeName("XR_ERROR_MISMATCHING_TRACKABLE_TYPE_ANDROID")]
    ErrorMismatchingTrackableTypeANDROID = -1000455000,

    [NativeName("XR_ERROR_TRACKABLE_TYPE_NOT_SUPPORTED_ANDROID")]
    ErrorTrackableTypeNotSupportedANDROID = -1000455001,

    [NativeName("XR_ERROR_ANCHOR_ID_NOT_FOUND_ANDROID")]
    ErrorAnchorIdNotFoundANDROID = -1000457000,

    [NativeName("XR_ERROR_ANCHOR_ALREADY_PERSISTED_ANDROID")]
    ErrorAnchorAlreadyPersistedANDROID = -1000457001,

    [NativeName("XR_ERROR_ANCHOR_NOT_TRACKING_ANDROID")]
    ErrorAnchorNotTrackingANDROID = -1000457002,

    [NativeName("XR_ERROR_PERSISTED_DATA_NOT_READY_ANDROID")]
    ErrorPersistedDataNotReadyANDROID = -1000457003,

    [NativeName("XR_ERROR_SERVICE_NOT_READY_ANDROID")]
    ErrorServiceNotReadyANDROID = -1000458000,

    [NativeName("XR_ERROR_MESH_DATA_LIMIT_EXCEEDED_ANDROID")]
    ErrorMeshDataLimitExceededANDROID = -1000462000,

    [NativeName("XR_ERROR_FUTURE_PENDING_EXT")]
    ErrorFuturePendingEXT = -1000469001,

    [NativeName("XR_ERROR_FUTURE_INVALID_EXT")]
    ErrorFutureInvalidEXT = -1000469002,

    [NativeName("XR_ERROR_SYSTEM_NOTIFICATION_PERMISSION_DENIED_ML")]
    ErrorSystemNotificationPermissionDeniedML = -1000473000,

    [NativeName("XR_ERROR_SYSTEM_NOTIFICATION_INCOMPATIBLE_SKU_ML")]
    ErrorSystemNotificationIncompatibleSkuML = -1000473001,

    [NativeName("XR_ERROR_WORLD_MESH_DETECTOR_PERMISSION_DENIED_ML")]
    ErrorWorldMeshDetectorPermissionDeniedML = -1000474000,

    [NativeName("XR_ERROR_WORLD_MESH_DETECTOR_SPACE_NOT_LOCATABLE_ML")]
    ErrorWorldMeshDetectorSpaceNotLocatableML = -1000474001,

    [NativeName("XR_ERROR_FACIAL_EXPRESSION_PERMISSION_DENIED_ML")]
    ErrorFacialExpressionPermissionDeniedML = 1000482000,

    [NativeName("XR_BOUNDARY_VISIBILITY_SUPPRESSION_NOT_ALLOWED_META")]
    BoundaryVisibilitySuppressionNotAllowedMETA = 1000528000,

    [NativeName("XR_ERROR_COLOCATION_DISCOVERY_NETWORK_FAILED_META")]
    ErrorColocationDiscoveryNetworkFailedMETA = -1000571001,

    [NativeName("XR_ERROR_COLOCATION_DISCOVERY_NO_DISCOVERY_METHOD_META")]
    ErrorColocationDiscoveryNoDiscoveryMethodMETA = -1000571002,

    [NativeName("XR_COLOCATION_DISCOVERY_ALREADY_ADVERTISING_META")]
    ColocationDiscoveryAlreadyAdvertisingMETA = 1000571003,

    [NativeName("XR_COLOCATION_DISCOVERY_ALREADY_DISCOVERING_META")]
    ColocationDiscoveryAlreadyDiscoveringMETA = 1000571004,

    [NativeName("XR_ERROR_SPACE_GROUP_NOT_FOUND_META")]
    ErrorSpaceGroupNotFoundMETA = -1000572002,

    [NativeName("XR_ERROR_ANCHOR_NOT_OWNED_BY_CALLER_ANDROID")]
    ErrorAnchorNotOwnedByCallerANDROID = -1000701000,

    [NativeName("XR_ERROR_IMAGE_FORMAT_UNSUPPORTED_ANDROID")]
    ErrorImageFormatUnsupportedANDROID = -1000709000,

    [NativeName("XR_ERROR_SPATIAL_CAPABILITY_UNSUPPORTED_EXT")]
    ErrorSpatialCapabilityUnsupportedEXT = -1000740001,

    [NativeName("XR_ERROR_SPATIAL_ENTITY_ID_INVALID_EXT")]
    ErrorSpatialEntityIdInvalidEXT = -1000740002,

    [NativeName("XR_ERROR_SPATIAL_BUFFER_ID_INVALID_EXT")]
    ErrorSpatialBufferIdInvalidEXT = -1000740003,

    [NativeName("XR_ERROR_SPATIAL_COMPONENT_UNSUPPORTED_FOR_CAPABILITY_EXT")]
    ErrorSpatialComponentUnsupportedForCapabilityEXT = -1000740004,

    [NativeName("XR_ERROR_SPATIAL_CAPABILITY_CONFIGURATION_INVALID_EXT")]
    ErrorSpatialCapabilityConfigurationInvalidEXT = -1000740005,

    [NativeName("XR_ERROR_SPATIAL_COMPONENT_NOT_ENABLED_EXT")]
    ErrorSpatialComponentNotEnabledEXT = -1000740006,

    [NativeName("XR_ERROR_SPATIAL_PERSISTENCE_SCOPE_UNSUPPORTED_EXT")]
    ErrorSpatialPersistenceScopeUnsupportedEXT = -1000763001,

    [NativeName("XR_ERROR_SPATIAL_PERSISTENCE_SCOPE_INCOMPATIBLE_EXT")]
    ErrorSpatialPersistenceScopeIncompatibleEXT = -1000781001,

    [NativeName("XR_ERROR_SPATIAL_ANCHOR_ATTACHABLE_COMPONENT_NOT_FOUND_ANDROID")]
    ErrorSpatialAnchorAttachableComponentNotFoundANDROID = -1000790001,

    [NativeName("XR_ERROR_SPATIAL_ANCHOR_ENTITY_ID_INVALID_ANDROID")]
    ErrorSpatialAnchorEntityIdInvalidANDROID = -1000795001,

    [NativeName("XR_ERROR_EXTENSION_DEPENDENCY_NOT_ENABLED_KHR")]
    ErrorExtensionDependencyNotEnabledKHR = ErrorExtensionDependencyNotEnabled,

    [NativeName("XR_ERROR_PERMISSION_INSUFFICIENT_KHR")]
    ErrorPermissionInsufficientKHR = ErrorPermissionInsufficient,
}
