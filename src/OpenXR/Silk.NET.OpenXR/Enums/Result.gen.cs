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
        ErrorValidationFailure = -1,
        [NativeName("Name", "XR_ERROR_RUNTIME_FAILURE")]
        ErrorRuntimeFailure = -2,
        [NativeName("Name", "XR_ERROR_OUT_OF_MEMORY")]
        ErrorOutOfMemory = -3,
        [NativeName("Name", "XR_ERROR_API_VERSION_UNSUPPORTED")]
        ErrorApiVersionUnsupported = -4,
        [NativeName("Name", "XR_ERROR_INITIALIZATION_FAILED")]
        ErrorInitializationFailed = -6,
        [NativeName("Name", "XR_ERROR_FUNCTION_UNSUPPORTED")]
        ErrorFunctionUnsupported = -7,
        [NativeName("Name", "XR_ERROR_FEATURE_UNSUPPORTED")]
        ErrorFeatureUnsupported = -8,
        [NativeName("Name", "XR_ERROR_EXTENSION_NOT_PRESENT")]
        ErrorExtensionNotPresent = -9,
        [NativeName("Name", "XR_ERROR_LIMIT_REACHED")]
        ErrorLimitReached = -10,
        [NativeName("Name", "XR_ERROR_SIZE_INSUFFICIENT")]
        ErrorSizeInsufficient = -11,
        [NativeName("Name", "XR_ERROR_HANDLE_INVALID")]
        ErrorHandleInvalid = -12,
        [NativeName("Name", "XR_ERROR_INSTANCE_LOST")]
        ErrorInstanceLost = -13,
        [NativeName("Name", "XR_ERROR_SESSION_RUNNING")]
        ErrorSessionRunning = -14,
        [NativeName("Name", "XR_ERROR_SESSION_NOT_RUNNING")]
        ErrorSessionNotRunning = -16,
        [NativeName("Name", "XR_ERROR_SESSION_LOST")]
        ErrorSessionLost = -17,
        [NativeName("Name", "XR_ERROR_SYSTEM_INVALID")]
        ErrorSystemInvalid = -18,
        [NativeName("Name", "XR_ERROR_PATH_INVALID")]
        ErrorPathInvalid = -19,
        [NativeName("Name", "XR_ERROR_PATH_COUNT_EXCEEDED")]
        ErrorPathCountExceeded = -20,
        [NativeName("Name", "XR_ERROR_PATH_FORMAT_INVALID")]
        ErrorPathFormatInvalid = -21,
        [NativeName("Name", "XR_ERROR_PATH_UNSUPPORTED")]
        ErrorPathUnsupported = -22,
        [NativeName("Name", "XR_ERROR_LAYER_INVALID")]
        ErrorLayerInvalid = -23,
        [NativeName("Name", "XR_ERROR_LAYER_LIMIT_EXCEEDED")]
        ErrorLayerLimitExceeded = -24,
        [NativeName("Name", "XR_ERROR_SWAPCHAIN_RECT_INVALID")]
        ErrorSwapchainRectInvalid = -25,
        [NativeName("Name", "XR_ERROR_SWAPCHAIN_FORMAT_UNSUPPORTED")]
        ErrorSwapchainFormatUnsupported = -26,
        [NativeName("Name", "XR_ERROR_ACTION_TYPE_MISMATCH")]
        ErrorActionTypeMismatch = -27,
        [NativeName("Name", "XR_ERROR_SESSION_NOT_READY")]
        ErrorSessionNotReady = -28,
        [NativeName("Name", "XR_ERROR_SESSION_NOT_STOPPING")]
        ErrorSessionNotStopping = -29,
        [NativeName("Name", "XR_ERROR_TIME_INVALID")]
        ErrorTimeInvalid = -30,
        [NativeName("Name", "XR_ERROR_REFERENCE_SPACE_UNSUPPORTED")]
        ErrorReferenceSpaceUnsupported = -31,
        [NativeName("Name", "XR_ERROR_FILE_ACCESS_ERROR")]
        ErrorFileAccessError = -32,
        [NativeName("Name", "XR_ERROR_FILE_CONTENTS_INVALID")]
        ErrorFileContentsInvalid = -33,
        [NativeName("Name", "XR_ERROR_FORM_FACTOR_UNSUPPORTED")]
        ErrorFormFactorUnsupported = -34,
        [NativeName("Name", "XR_ERROR_FORM_FACTOR_UNAVAILABLE")]
        ErrorFormFactorUnavailable = -35,
        [NativeName("Name", "XR_ERROR_API_LAYER_NOT_PRESENT")]
        ErrorApiLayerNotPresent = -36,
        [NativeName("Name", "XR_ERROR_CALL_ORDER_INVALID")]
        ErrorCallOrderInvalid = -37,
        [NativeName("Name", "XR_ERROR_GRAPHICS_DEVICE_INVALID")]
        ErrorGraphicsDeviceInvalid = -38,
        [NativeName("Name", "XR_ERROR_POSE_INVALID")]
        ErrorPoseInvalid = -39,
        [NativeName("Name", "XR_ERROR_INDEX_OUT_OF_RANGE")]
        ErrorIndexOutOfRange = -40,
        [NativeName("Name", "XR_ERROR_VIEW_CONFIGURATION_TYPE_UNSUPPORTED")]
        ErrorViewConfigurationTypeUnsupported = -41,
        [NativeName("Name", "XR_ERROR_ENVIRONMENT_BLEND_MODE_UNSUPPORTED")]
        ErrorEnvironmentBlendModeUnsupported = -42,
        [NativeName("Name", "XR_ERROR_NAME_DUPLICATED")]
        ErrorNameDuplicated = -44,
        [NativeName("Name", "XR_ERROR_NAME_INVALID")]
        ErrorNameInvalid = -45,
        [NativeName("Name", "XR_ERROR_ACTIONSET_NOT_ATTACHED")]
        ErrorActionsetNotAttached = -46,
        [NativeName("Name", "XR_ERROR_ACTIONSETS_ALREADY_ATTACHED")]
        ErrorActionsetsAlreadyAttached = -47,
        [NativeName("Name", "XR_ERROR_LOCALIZED_NAME_DUPLICATED")]
        ErrorLocalizedNameDuplicated = -48,
        [NativeName("Name", "XR_ERROR_LOCALIZED_NAME_INVALID")]
        ErrorLocalizedNameInvalid = -49,
        [NativeName("Name", "XR_ERROR_GRAPHICS_REQUIREMENTS_CALL_MISSING")]
        ErrorGraphicsRequirementsCallMissing = -50,
        [NativeName("Name", "XR_ERROR_RUNTIME_UNAVAILABLE")]
        ErrorRuntimeUnavailable = -51,
        [NativeName("Name", "XR_ERROR_ANDROID_THREAD_SETTINGS_ID_INVALID_KHR")]
        ErrorAndroidThreadSettingsIDInvalidKhr = -1000003000,
        [NativeName("Name", "XR_ERROR_ANDROID_THREAD_SETTINGS_FAILURE_KHR")]
        ErrorAndroidThreadSettingsFailureKhr = -1000003001,
        [NativeName("Name", "XR_ERROR_CREATE_SPATIAL_ANCHOR_FAILED_MSFT")]
        ErrorCreateSpatialAnchorFailedMsft = -1000039001,
        [NativeName("Name", "XR_ERROR_SECONDARY_VIEW_CONFIGURATION_TYPE_NOT_ENABLED_MSFT")]
        ErrorSecondaryViewConfigurationTypeNotEnabledMsft = -1000053000,
        [NativeName("Name", "XR_ERROR_CONTROLLER_MODEL_KEY_INVALID_MSFT")]
        ErrorControllerModelKeyInvalidMsft = -1000055000,
        [NativeName("Name", "XR_ERROR_REPROJECTION_MODE_UNSUPPORTED_MSFT")]
        ErrorReprojectionModeUnsupportedMsft = -1000066000,
        [NativeName("Name", "XR_ERROR_COMPUTE_NEW_SCENE_NOT_COMPLETED_MSFT")]
        ErrorComputeNewSceneNotCompletedMsft = -1000097000,
        [NativeName("Name", "XR_ERROR_SCENE_COMPONENT_ID_INVALID_MSFT")]
        ErrorSceneComponentIDInvalidMsft = -1000097001,
        [NativeName("Name", "XR_ERROR_SCENE_COMPONENT_TYPE_MISMATCH_MSFT")]
        ErrorSceneComponentTypeMismatchMsft = -1000097002,
        [NativeName("Name", "XR_ERROR_SCENE_MESH_BUFFER_ID_INVALID_MSFT")]
        ErrorSceneMeshBufferIDInvalidMsft = -1000097003,
        [NativeName("Name", "XR_ERROR_SCENE_COMPUTE_FEATURE_INCOMPATIBLE_MSFT")]
        ErrorSceneComputeFeatureIncompatibleMsft = -1000097004,
        [NativeName("Name", "XR_ERROR_SCENE_COMPUTE_CONSISTENCY_MISMATCH_MSFT")]
        ErrorSceneComputeConsistencyMismatchMsft = -1000097005,
        [NativeName("Name", "XR_ERROR_DISPLAY_REFRESH_RATE_UNSUPPORTED_FB")]
        ErrorDisplayRefreshRateUnsupportedFB = -1000101000,
        [NativeName("Name", "XR_ERROR_COLOR_SPACE_UNSUPPORTED_FB")]
        ErrorColorSpaceUnsupportedFB = -1000108000,
        [NativeName("Name", "XR_ERROR_UNEXPECTED_STATE_PASSTHROUGH_FB")]
        ErrorUnexpectedStatePassthroughFB = -1000118000,
        [NativeName("Name", "XR_ERROR_FEATURE_ALREADY_CREATED_PASSTHROUGH_FB")]
        ErrorFeatureAlreadyCreatedPassthroughFB = -1000118001,
        [NativeName("Name", "XR_ERROR_FEATURE_REQUIRED_PASSTHROUGH_FB")]
        ErrorFeatureRequiredPassthroughFB = -1000118002,
        [NativeName("Name", "XR_ERROR_NOT_PERMITTED_PASSTHROUGH_FB")]
        ErrorNotPermittedPassthroughFB = -1000118003,
        [NativeName("Name", "XR_ERROR_INSUFFICIENT_RESOURCES_PASSTHROUGH_FB")]
        ErrorInsufficientResourcesPassthroughFB = -1000118004,
        [NativeName("Name", "XR_ERROR_UNKNOWN_PASSTHROUGH_FB")]
        ErrorUnknownPassthroughFB = -1000118050,
        [NativeName("Name", "XR_ERROR_RENDER_MODEL_KEY_INVALID_FB")]
        ErrorRenderModelKeyInvalidFB = -1000119000,
        [NativeName("Name", "XR_RENDER_MODEL_UNAVAILABLE_FB")]
        RenderModelUnavailableFB = 1000119020,
        [NativeName("Name", "XR_ERROR_MARKER_NOT_TRACKED_VARJO")]
        ErrorMarkerNotTrackedVarjo = -1000124000,
        [NativeName("Name", "XR_ERROR_MARKER_ID_INVALID_VARJO")]
        ErrorMarkerIDInvalidVarjo = -1000124001,
        [NativeName("Name", "XR_ERROR_SPATIAL_ANCHOR_NAME_NOT_FOUND_MSFT")]
        ErrorSpatialAnchorNameNotFoundMsft = -1000142001,
        [NativeName("Name", "XR_ERROR_SPATIAL_ANCHOR_NAME_INVALID_MSFT")]
        ErrorSpatialAnchorNameInvalidMsft = -1000142002,
    }
}
