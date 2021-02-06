// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


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
        ErrorOutOfHostMemory = -1,
        [NativeName("Name", "VK_ERROR_OUT_OF_DEVICE_MEMORY")]
        ErrorOutOfDeviceMemory = -2,
        [NativeName("Name", "VK_ERROR_INITIALIZATION_FAILED")]
        ErrorInitializationFailed = -3,
        [NativeName("Name", "VK_ERROR_DEVICE_LOST")]
        ErrorDeviceLost = -4,
        [NativeName("Name", "VK_ERROR_MEMORY_MAP_FAILED")]
        ErrorMemoryMapFailed = -5,
        [NativeName("Name", "VK_ERROR_LAYER_NOT_PRESENT")]
        ErrorLayerNotPresent = -6,
        [NativeName("Name", "VK_ERROR_EXTENSION_NOT_PRESENT")]
        ErrorExtensionNotPresent = -7,
        [NativeName("Name", "VK_ERROR_FEATURE_NOT_PRESENT")]
        ErrorFeatureNotPresent = -8,
        [NativeName("Name", "VK_ERROR_INCOMPATIBLE_DRIVER")]
        ErrorIncompatibleDriver = -9,
        [NativeName("Name", "VK_ERROR_TOO_MANY_OBJECTS")]
        ErrorTooManyObjects = -10,
        [NativeName("Name", "VK_ERROR_FORMAT_NOT_SUPPORTED")]
        ErrorFormatNotSupported = -11,
        [NativeName("Name", "VK_ERROR_FRAGMENTED_POOL")]
        ErrorFragmentedPool = -12,
        [NativeName("Name", "VK_ERROR_UNKNOWN")]
        ErrorUnknown = -13,
        [NativeName("Name", "VK_ERROR_SURFACE_LOST_KHR")]
        ErrorSurfaceLostKhr = -1000000000,
        [NativeName("Name", "VK_ERROR_NATIVE_WINDOW_IN_USE_KHR")]
        ErrorNativeWindowInUseKhr = -1000000001,
        [NativeName("Name", "VK_SUBOPTIMAL_KHR")]
        SuboptimalKhr = 1000001003,
        [NativeName("Name", "VK_ERROR_OUT_OF_DATE_KHR")]
        ErrorOutOfDateKhr = -1000001004,
        [NativeName("Name", "VK_ERROR_INCOMPATIBLE_DISPLAY_KHR")]
        ErrorIncompatibleDisplayKhr = -1000003001,
        [NativeName("Name", "VK_ERROR_VALIDATION_FAILED_EXT")]
        ErrorValidationFailedExt = -1000011001,
        [NativeName("Name", "VK_ERROR_INVALID_SHADER_NV")]
        ErrorInvalidShaderNV = -1000012000,
        [NativeName("Name", "VK_ERROR_OUT_OF_POOL_MEMORY_KHR")]
        ErrorOutOfPoolMemoryKhr = -1000069000,
        [NativeName("Name", "VK_ERROR_INVALID_EXTERNAL_HANDLE_KHR")]
        ErrorInvalidExternalHandleKhr = -1000072003,
        [NativeName("Name", "VK_ERROR_INVALID_DRM_FORMAT_MODIFIER_PLANE_LAYOUT_EXT")]
        ErrorInvalidDrmFormatModifierPlaneLayoutExt = -1000158000,
        [NativeName("Name", "VK_ERROR_FRAGMENTATION_EXT")]
        ErrorFragmentationExt = -1000161000,
        [NativeName("Name", "VK_ERROR_NOT_PERMITTED_EXT")]
        ErrorNotPermittedExt = -1000174001,
        [NativeName("Name", "VK_ERROR_INVALID_DEVICE_ADDRESS_EXT")]
        ErrorInvalidDeviceAddressExt = -1000257000,
        [NativeName("Name", "VK_ERROR_FULL_SCREEN_EXCLUSIVE_MODE_LOST_EXT")]
        ErrorFullScreenExclusiveModeLostExt = -1000255000,
        [NativeName("Name", "VK_ERROR_INVALID_OPAQUE_CAPTURE_ADDRESS_KHR")]
        ErrorInvalidOpaqueCaptureAddressKhr = -1000257000,
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
        [NativeName("Name", "VK_ERROR_OUT_OF_POOL_MEMORY")]
        ErrorOutOfPoolMemory = -1000069000,
        [NativeName("Name", "VK_ERROR_INVALID_EXTERNAL_HANDLE")]
        ErrorInvalidExternalHandle = -1000072003,
        [NativeName("Name", "VK_ERROR_FRAGMENTATION")]
        ErrorFragmentation = -1000161000,
        [NativeName("Name", "VK_ERROR_INVALID_OPAQUE_CAPTURE_ADDRESS")]
        ErrorInvalidOpaqueCaptureAddress = -1000257000,
    }
}
