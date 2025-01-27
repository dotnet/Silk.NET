// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkResult")]
    public enum Result : int
    {
        [NativeName("Name", "VK_SUCCESS")]
        Success = 0,
        [NativeName("Name", "VK_NOT_READY")]
        NotReady = 1,
        [NativeName("Name", "VK_TIMEOUT")]
        Timeout = 2,
        [NativeName("Name", "VK_EVENT_SET")]
        EventSet = 3,
        [NativeName("Name", "VK_EVENT_RESET")]
        EventReset = 4,
        [NativeName("Name", "VK_INCOMPLETE")]
        Incomplete = 5,
        [NativeName("Name", "VK_ERROR_OUT_OF_HOST_MEMORY")]
        ErrorOutOfHostMemory = unchecked((int) -1),
        [NativeName("Name", "VK_ERROR_OUT_OF_DEVICE_MEMORY")]
        ErrorOutOfDeviceMemory = unchecked((int) -2),
        [NativeName("Name", "VK_ERROR_INITIALIZATION_FAILED")]
        ErrorInitializationFailed = unchecked((int) -3),
        [NativeName("Name", "VK_ERROR_DEVICE_LOST")]
        ErrorDeviceLost = unchecked((int) -4),
        [NativeName("Name", "VK_ERROR_MEMORY_MAP_FAILED")]
        ErrorMemoryMapFailed = unchecked((int) -5),
        [NativeName("Name", "VK_ERROR_LAYER_NOT_PRESENT")]
        ErrorLayerNotPresent = unchecked((int) -6),
        [NativeName("Name", "VK_ERROR_EXTENSION_NOT_PRESENT")]
        ErrorExtensionNotPresent = unchecked((int) -7),
        [NativeName("Name", "VK_ERROR_FEATURE_NOT_PRESENT")]
        ErrorFeatureNotPresent = unchecked((int) -8),
        [NativeName("Name", "VK_ERROR_INCOMPATIBLE_DRIVER")]
        ErrorIncompatibleDriver = unchecked((int) -9),
        [NativeName("Name", "VK_ERROR_TOO_MANY_OBJECTS")]
        ErrorTooManyObjects = unchecked((int) -10),
        [NativeName("Name", "VK_ERROR_FORMAT_NOT_SUPPORTED")]
        ErrorFormatNotSupported = unchecked((int) -11),
        [NativeName("Name", "VK_ERROR_FRAGMENTED_POOL")]
        ErrorFragmentedPool = unchecked((int) -12),
        [NativeName("Name", "VK_ERROR_UNKNOWN")]
        ErrorUnknown = unchecked((int) -13),
        [NativeName("Name", "VK_ERROR_SURFACE_LOST_KHR")]
        ErrorSurfaceLostKhr = unchecked((int) -1000000000),
        [NativeName("Name", "VK_ERROR_NATIVE_WINDOW_IN_USE_KHR")]
        ErrorNativeWindowInUseKhr = unchecked((int) -1000000001),
        [NativeName("Name", "VK_SUBOPTIMAL_KHR")]
        SuboptimalKhr = 1000001003,
        [NativeName("Name", "VK_ERROR_OUT_OF_DATE_KHR")]
        ErrorOutOfDateKhr = unchecked((int) -1000001004),
        [NativeName("Name", "VK_ERROR_INCOMPATIBLE_DISPLAY_KHR")]
        ErrorIncompatibleDisplayKhr = unchecked((int) -1000003001),
        [NativeName("Name", "VK_ERROR_VALIDATION_FAILED_EXT")]
        ErrorValidationFailedExt = unchecked((int) -1000011001),
        [NativeName("Name", "VK_ERROR_INVALID_SHADER_NV")]
        ErrorInvalidShaderNV = unchecked((int) -1000012000),
        [NativeName("Name", "VK_ERROR_IMAGE_USAGE_NOT_SUPPORTED_KHR")]
        ErrorImageUsageNotSupportedKhr = unchecked((int) -1000023000),
        [NativeName("Name", "VK_ERROR_VIDEO_PICTURE_LAYOUT_NOT_SUPPORTED_KHR")]
        ErrorVideoPictureLayoutNotSupportedKhr = unchecked((int) -1000023001),
        [NativeName("Name", "VK_ERROR_VIDEO_PROFILE_OPERATION_NOT_SUPPORTED_KHR")]
        ErrorVideoProfileOperationNotSupportedKhr = unchecked((int) -1000023002),
        [NativeName("Name", "VK_ERROR_VIDEO_PROFILE_FORMAT_NOT_SUPPORTED_KHR")]
        ErrorVideoProfileFormatNotSupportedKhr = unchecked((int) -1000023003),
        [NativeName("Name", "VK_ERROR_VIDEO_PROFILE_CODEC_NOT_SUPPORTED_KHR")]
        ErrorVideoProfileCodecNotSupportedKhr = unchecked((int) -1000023004),
        [NativeName("Name", "VK_ERROR_VIDEO_STD_VERSION_NOT_SUPPORTED_KHR")]
        ErrorVideoStdVersionNotSupportedKhr = unchecked((int) -1000023005),
        [NativeName("Name", "VK_ERROR_OUT_OF_POOL_MEMORY_KHR")]
        ErrorOutOfPoolMemoryKhr = unchecked((int) -1000069000),
        [NativeName("Name", "VK_ERROR_INVALID_EXTERNAL_HANDLE_KHR")]
        ErrorInvalidExternalHandleKhr = unchecked((int) -1000072003),
        [NativeName("Name", "VK_ERROR_INVALID_DRM_FORMAT_MODIFIER_PLANE_LAYOUT_EXT")]
        ErrorInvalidDrmFormatModifierPlaneLayoutExt = unchecked((int) -1000158000),
        [NativeName("Name", "VK_ERROR_FRAGMENTATION_EXT")]
        ErrorFragmentationExt = unchecked((int) -1000161000),
        [NativeName("Name", "VK_ERROR_NOT_PERMITTED_EXT")]
        ErrorNotPermittedExt = unchecked((int) -1000174001),
        [NativeName("Name", "VK_ERROR_NOT_PERMITTED_KHR")]
        ErrorNotPermittedKhr = unchecked((int) -1000174001),
        [NativeName("Name", "VK_ERROR_INVALID_DEVICE_ADDRESS_EXT")]
        ErrorInvalidDeviceAddressExt = unchecked((int) -1000257000),
        [NativeName("Name", "VK_ERROR_FULL_SCREEN_EXCLUSIVE_MODE_LOST_EXT")]
        ErrorFullScreenExclusiveModeLostExt = unchecked((int) -1000255000),
        [NativeName("Name", "VK_ERROR_INVALID_OPAQUE_CAPTURE_ADDRESS_KHR")]
        ErrorInvalidOpaqueCaptureAddressKhr = unchecked((int) -1000257000),
        [NativeName("Name", "VK_THREAD_IDLE_KHR")]
        ThreadIdleKhr = 1000268000,
        [NativeName("Name", "VK_THREAD_DONE_KHR")]
        ThreadDoneKhr = 1000268001,
        [NativeName("Name", "VK_OPERATION_DEFERRED_KHR")]
        OperationDeferredKhr = 1000268002,
        [NativeName("Name", "VK_OPERATION_NOT_DEFERRED_KHR")]
        OperationNotDeferredKhr = 1000268003,
        [NativeName("Name", "VK_PIPELINE_COMPILE_REQUIRED_EXT")]
        PipelineCompileRequiredExt = 1000297000,
        [NativeName("Name", "VK_ERROR_PIPELINE_COMPILE_REQUIRED_EXT")]
        ErrorPipelineCompileRequiredExt = 1000297000,
        [NativeName("Name", "VK_ERROR_INVALID_VIDEO_STD_PARAMETERS_KHR")]
        ErrorInvalidVideoStdParametersKhr = unchecked((int) -1000299000),
        [NativeName("Name", "VK_ERROR_COMPRESSION_EXHAUSTED_EXT")]
        ErrorCompressionExhaustedExt = unchecked((int) -1000338000),
        [NativeName("Name", "VK_INCOMPATIBLE_SHADER_BINARY_EXT")]
        IncompatibleShaderBinaryExt = 1000482000,
        [NativeName("Name", "VK_ERROR_INCOMPATIBLE_SHADER_BINARY_EXT")]
        ErrorIncompatibleShaderBinaryExt = 1000482000,
        [NativeName("Name", "VK_PIPELINE_BINARY_MISSING_KHR")]
        PipelineBinaryMissingKhr = 1000483000,
        [NativeName("Name", "VK_ERROR_NOT_ENOUGH_SPACE_KHR")]
        ErrorNotEnoughSpaceKhr = unchecked((int) -1000483000),
        [NativeName("Name", "VK_ERROR_OUT_OF_POOL_MEMORY")]
        ErrorOutOfPoolMemory = unchecked((int) -1000069000),
        [NativeName("Name", "VK_ERROR_INVALID_EXTERNAL_HANDLE")]
        ErrorInvalidExternalHandle = unchecked((int) -1000072003),
        [NativeName("Name", "VK_ERROR_FRAGMENTATION")]
        ErrorFragmentation = unchecked((int) -1000161000),
        [NativeName("Name", "VK_ERROR_INVALID_OPAQUE_CAPTURE_ADDRESS")]
        ErrorInvalidOpaqueCaptureAddress = unchecked((int) -1000257000),
        [NativeName("Name", "VK_PIPELINE_COMPILE_REQUIRED")]
        PipelineCompileRequired = 1000297000,
        [NativeName("Name", "VK_ERROR_VALIDATION_FAILED")]
        ErrorValidationFailed = unchecked((int) -1000011001),
        [NativeName("Name", "VK_ERROR_INVALID_PIPELINE_CACHE_DATA")]
        ErrorInvalidPipelineCacheData = unchecked((int) -1000298000),
        [NativeName("Name", "VK_ERROR_NO_PIPELINE_MATCH")]
        ErrorNoPipelineMatch = unchecked((int) -1000298001),
    }
}
