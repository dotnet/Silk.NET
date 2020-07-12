// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;

#pragma warning disable 1591

namespace Silk.NET.OpenXR
{
    public enum Result
    {
        Success = 0,
        TimeoutExpired = 1,
        SessionLossPending = 3,
        EventUnavailable = 4,
        SpaceBoundsUnavailable = 7,
        SessionNotFocused = 8,
        FrameDiscarded = 9,
        ErrorValidationFailure = -1,
        ErrorRuntimeFailure = -2,
        ErrorOutOfMemory = -3,
        ErrorApiVersionUnsupported = -4,
        ErrorInitializationFailed = -6,
        ErrorFunctionUnsupported = -7,
        ErrorFeatureUnsupported = -8,
        ErrorExtensionNotPresent = -9,
        ErrorLimitReached = -10,
        ErrorSizeInsufficient = -11,
        ErrorHandleInvalid = -12,
        ErrorInstanceLost = -13,
        ErrorSessionRunning = -14,
        ErrorSessionNotRunning = -16,
        ErrorSessionLost = -17,
        ErrorSystemInvalid = -18,
        ErrorPathInvalid = -19,
        ErrorPathCountExceeded = -20,
        ErrorPathFormatInvalid = -21,
        ErrorPathUnsupported = -22,
        ErrorLayerInvalid = -23,
        ErrorLayerLimitExceeded = -24,
        ErrorSwapchainRectInvalid = -25,
        ErrorSwapchainFormatUnsupported = -26,
        ErrorActionTypeMismatch = -27,
        ErrorSessionNotReady = -28,
        ErrorSessionNotStopping = -29,
        ErrorTimeInvalid = -30,
        ErrorReferenceSpaceUnsupported = -31,
        ErrorFileAccessError = -32,
        ErrorFileContentsInvalid = -33,
        ErrorFormFactorUnsupported = -34,
        ErrorFormFactorUnavailable = -35,
        ErrorApiLayerNotPresent = -36,
        ErrorCallOrderInvalid = -37,
        ErrorGraphicsDeviceInvalid = -38,
        ErrorPoseInvalid = -39,
        ErrorIndexOutOfRange = -40,
        ErrorViewConfigurationTypeUnsupported = -41,
        ErrorEnvironmentBlendModeUnsupported = -42,
        ErrorNameDuplicated = -44,
        ErrorNameInvalid = -45,
        ErrorActionsetNotAttached = -46,
        ErrorActionsetsAlreadyAttached = -47,
        ErrorLocalizedNameDuplicated = -48,
        ErrorLocalizedNameInvalid = -49,
        ErrorAndroidThreadSettingsIDInvalidKhr = -1000003000,
        ErrorAndroidThreadSettingsFailureKhr = -1000003001,
        ErrorCreateSpatialAnchorFailedMsft = -1000039001,
        ErrorSecondaryViewConfigurationTypeNotEnabledMsft = -1000053000,
    }
}
