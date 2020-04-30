// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;

namespace Silk.NET.Vulkan
{
    public enum Result
    {
        Success = 0,
        NotReady = 1,
        Timeout = 2,
        EventSet = 3,
        EventReset = 4,
        Incomplete = 5,
        ErrorOutOfHostMemory = -1,
        ErrorOutOfDeviceMemory = -2,
        ErrorInitializationFailed = -3,
        ErrorDeviceLost = -4,
        ErrorMemoryMapFailed = -5,
        ErrorLayerNotPresent = -6,
        ErrorExtensionNotPresent = -7,
        ErrorFeatureNotPresent = -8,
        ErrorIncompatibleDriver = -9,
        ErrorTooManyObjects = -10,
        ErrorFormatNotSupported = -11,
        ErrorFragmentedPool = -12,
        ErrorUnknown = -13,
        ErrorSurfaceLostKhr = -1000000000,
        ErrorNativeWindowInUseKhr = -1000000001,
        SuboptimalKhr = 1000001003,
        ErrorOutOfDateKhr = -1000001004,
        ErrorIncompatibleDisplayKhr = -1000003001,
        ErrorValidationFailedExt = -1000011001,
        ErrorInvalidShaderNV = -1000012000,
        ErrorOutOfPoolMemoryKhr = -1000069000,
        ErrorInvalidExternalHandleKhr = -1000072003,
        ErrorIncompatibleVersionKhr = -1000150000,
        ErrorInvalidDrmFormatModifierPlaneLayoutExt = -1000158000,
        ErrorFragmentationExt = -1000161000,
        ErrorNotPermittedExt = -1000174001,
        ErrorInvalidDeviceAddressExt = -1000257000,
        ErrorFullScreenExclusiveModeLostExt = -1000255000,
        ErrorInvalidOpaqueCaptureAddressKhr = -1000257000,
        ThreadIdleKhr = 1000268000,
        ThreadDoneKhr = 1000268001,
        OperationDeferredKhr = 1000268002,
        OperationNotDeferredKhr = 1000268003,
        PipelineCompileRequiredExt = 1000297000,
        ErrorPipelineCompileRequiredExt = 1000297000,
        ErrorOutOfPoolMemory = -1000069000,
        ErrorInvalidExternalHandle = -1000072003,
        ErrorFragmentation = -1000161000,
        ErrorInvalidOpaqueCaptureAddress = -1000257000,
    }
}
