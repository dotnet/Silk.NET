// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenCL.Extensions.NV
{
    [Obsolete("The \"ungrouped\" enums (CLEnum, KHR, etc...) are deprecated in favour of the \"grouped\" enums (ErrorCodes, DeviceType, etc...). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ")]
    [NativeName("Name", "CLenum")]
    public enum NV : int
    {
        [NativeName("Name", "CL_DEVICE_COMPUTE_CAPABILITY_MAJOR_NV")]
        DeviceComputeCapabilityMajorNV = 0x4000,
        [NativeName("Name", "CL_DEVICE_COMPUTE_CAPABILITY_MINOR_NV")]
        DeviceComputeCapabilityMinorNV = 0x4001,
        [NativeName("Name", "CL_DEVICE_REGISTERS_PER_BLOCK_NV")]
        DeviceRegistersPerBlockNV = 0x4002,
        [NativeName("Name", "CL_DEVICE_WARP_SIZE_NV")]
        DeviceWarpSizeNV = 0x4003,
        [NativeName("Name", "CL_DEVICE_GPU_OVERLAP_NV")]
        DeviceGpuOverlapNV = 0x4004,
        [NativeName("Name", "CL_DEVICE_KERNEL_EXEC_TIMEOUT_NV")]
        DeviceKernelExecTimeoutNV = 0x4005,
        [NativeName("Name", "CL_DEVICE_INTEGRATED_MEMORY_NV")]
        DeviceIntegratedMemoryNV = 0x4006,
    }
}
