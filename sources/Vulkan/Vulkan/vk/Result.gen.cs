// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkResult")]
public enum Result
{
    [NativeName("VK_SUCCESS")]
    Success = 0,

    [NativeName("VK_NOT_READY")]
    NotReady = 1,

    [NativeName("VK_TIMEOUT")]
    Timeout = 2,

    [NativeName("VK_EVENT_SET")]
    EventSet = 3,

    [NativeName("VK_EVENT_RESET")]
    EventReset = 4,

    [NativeName("VK_INCOMPLETE")]
    Incomplete = 5,

    [NativeName("VK_ERROR_OUT_OF_HOST_MEMORY")]
    ErrorOutOfHostMemory = -1,

    [NativeName("VK_ERROR_OUT_OF_DEVICE_MEMORY")]
    ErrorOutOfDeviceMemory = -2,

    [NativeName("VK_ERROR_INITIALIZATION_FAILED")]
    ErrorInitializationFailed = -3,

    [NativeName("VK_ERROR_DEVICE_LOST")]
    ErrorDeviceLost = -4,

    [NativeName("VK_ERROR_MEMORY_MAP_FAILED")]
    ErrorMemoryMapFailed = -5,

    [NativeName("VK_ERROR_LAYER_NOT_PRESENT")]
    ErrorLayerNotPresent = -6,

    [NativeName("VK_ERROR_EXTENSION_NOT_PRESENT")]
    ErrorExtensionNotPresent = -7,

    [NativeName("VK_ERROR_FEATURE_NOT_PRESENT")]
    ErrorFeatureNotPresent = -8,

    [NativeName("VK_ERROR_INCOMPATIBLE_DRIVER")]
    ErrorIncompatibleDriver = -9,

    [NativeName("VK_ERROR_TOO_MANY_OBJECTS")]
    ErrorTooManyObjects = -10,

    [NativeName("VK_ERROR_FORMAT_NOT_SUPPORTED")]
    ErrorFormatNotSupported = -11,

    [NativeName("VK_ERROR_FRAGMENTED_POOL")]
    ErrorFragmentedPool = -12,

    [NativeName("VK_ERROR_UNKNOWN")]
    ErrorUnknown = -13,

    [NativeName("VK_ERROR_VALIDATION_FAILED")]
    ErrorValidationFailed = -1000011001,

    [NativeName("VK_ERROR_OUT_OF_POOL_MEMORY")]
    ErrorOutOfPoolMemory = -1000069000,

    [NativeName("VK_ERROR_INVALID_EXTERNAL_HANDLE")]
    ErrorInvalidExternalHandle = -1000072003,

    [NativeName("VK_ERROR_INVALID_OPAQUE_CAPTURE_ADDRESS")]
    ErrorInvalidOpaqueCaptureAddress = -1000257000,

    [NativeName("VK_ERROR_FRAGMENTATION")]
    ErrorFragmentation = -1000161000,

    [NativeName("VK_PIPELINE_COMPILE_REQUIRED")]
    PipelineCompileRequired = 1000297000,

    [NativeName("VK_ERROR_NOT_PERMITTED")]
    ErrorNotPermitted = -1000174001,

    [NativeName("VK_ERROR_SURFACE_LOST_KHR")]
    ErrorSurfaceLostKHR = -1000000000,

    [NativeName("VK_ERROR_NATIVE_WINDOW_IN_USE_KHR")]
    ErrorNativeWindowInUseKHR = -1000000001,

    [NativeName("VK_SUBOPTIMAL_KHR")]
    SuboptimalKHR = 1000001003,

    [NativeName("VK_ERROR_OUT_OF_DATE_KHR")]
    ErrorOutOfDateKHR = -1000001004,

    [NativeName("VK_ERROR_INCOMPATIBLE_DISPLAY_KHR")]
    ErrorIncompatibleDisplayKHR = -1000003001,

    [NativeName("VK_ERROR_INVALID_SHADER_NV")]
    ErrorInvalidShaderNV = -1000012000,

    [NativeName("VK_ERROR_IMAGE_USAGE_NOT_SUPPORTED_KHR")]
    ErrorImageUsageNotSupportedKHR = -1000023000,

    [NativeName("VK_ERROR_VIDEO_PICTURE_LAYOUT_NOT_SUPPORTED_KHR")]
    ErrorVideoPictureLayoutNotSupportedKHR = -1000023001,

    [NativeName("VK_ERROR_VIDEO_PROFILE_OPERATION_NOT_SUPPORTED_KHR")]
    ErrorVideoProfileOperationNotSupportedKHR = -1000023002,

    [NativeName("VK_ERROR_VIDEO_PROFILE_FORMAT_NOT_SUPPORTED_KHR")]
    ErrorVideoProfileFormatNotSupportedKHR = -1000023003,

    [NativeName("VK_ERROR_VIDEO_PROFILE_CODEC_NOT_SUPPORTED_KHR")]
    ErrorVideoProfileCodecNotSupportedKHR = -1000023004,

    [NativeName("VK_ERROR_VIDEO_STD_VERSION_NOT_SUPPORTED_KHR")]
    ErrorVideoStdVersionNotSupportedKHR = -1000023005,

    [NativeName("VK_ERROR_INVALID_DRM_FORMAT_MODIFIER_PLANE_LAYOUT_EXT")]
    ErrorInvalidDrmFormatModifierPlaneLayoutEXT = -1000158000,

    [NativeName("VK_ERROR_PRESENT_TIMING_QUEUE_FULL_EXT")]
    ErrorPresentTimingQueueFullEXT = -1000208000,

    [NativeName("VK_ERROR_FULL_SCREEN_EXCLUSIVE_MODE_LOST_EXT")]
    ErrorFullScreenExclusiveModeLostEXT = -1000255000,

    [NativeName("VK_THREAD_IDLE_KHR")]
    ThreadIdleKHR = 1000268000,

    [NativeName("VK_THREAD_DONE_KHR")]
    ThreadDoneKHR = 1000268001,

    [NativeName("VK_OPERATION_DEFERRED_KHR")]
    OperationDeferredKHR = 1000268002,

    [NativeName("VK_OPERATION_NOT_DEFERRED_KHR")]
    OperationNotDeferredKHR = 1000268003,

    [NativeName("VK_ERROR_INVALID_VIDEO_STD_PARAMETERS_KHR")]
    ErrorInvalidVideoStdParametersKHR = -1000299000,

    [NativeName("VK_ERROR_COMPRESSION_EXHAUSTED_EXT")]
    ErrorCompressionExhaustedEXT = -1000338000,

    [NativeName("VK_INCOMPATIBLE_SHADER_BINARY_EXT")]
    IncompatibleShaderBinaryEXT = 1000482000,

    [NativeName("VK_PIPELINE_BINARY_MISSING_KHR")]
    PipelineBinaryMissingKHR = 1000483000,

    [NativeName("VK_ERROR_NOT_ENOUGH_SPACE_KHR")]
    ErrorNotEnoughSpaceKHR = -1000483000,

    [NativeName("VK_ERROR_VALIDATION_FAILED_EXT")]
    ErrorValidationFailedEXT = ErrorValidationFailed,

    [NativeName("VK_ERROR_OUT_OF_POOL_MEMORY_KHR")]
    ErrorOutOfPoolMemoryKHR = ErrorOutOfPoolMemory,

    [NativeName("VK_ERROR_INVALID_EXTERNAL_HANDLE_KHR")]
    ErrorInvalidExternalHandleKHR = ErrorInvalidExternalHandle,

    [NativeName("VK_ERROR_FRAGMENTATION_EXT")]
    ErrorFragmentationEXT = ErrorFragmentation,

    [NativeName("VK_ERROR_NOT_PERMITTED_EXT")]
    ErrorNotPermittedEXT = ErrorNotPermitted,

    [NativeName("VK_ERROR_NOT_PERMITTED_KHR")]
    ErrorNotPermittedKHR = ErrorNotPermitted,

    [NativeName("VK_ERROR_INVALID_DEVICE_ADDRESS_EXT")]
    ErrorInvalidDeviceAddressEXT = ErrorInvalidOpaqueCaptureAddress,

    [NativeName("VK_ERROR_INVALID_OPAQUE_CAPTURE_ADDRESS_KHR")]
    ErrorInvalidOpaqueCaptureAddressKHR = ErrorInvalidOpaqueCaptureAddress,

    [NativeName("VK_PIPELINE_COMPILE_REQUIRED_EXT")]
    PipelineCompileRequiredEXT = PipelineCompileRequired,

    [NativeName("VK_ERROR_PIPELINE_COMPILE_REQUIRED_EXT")]
    ErrorPipelineCompileRequiredEXT = PipelineCompileRequired,
}
