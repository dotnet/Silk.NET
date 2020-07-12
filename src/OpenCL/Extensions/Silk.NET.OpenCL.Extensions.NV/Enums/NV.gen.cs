// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenCL.Extensions.NV
{
    [NativeName("Name", "GLenum")]
    public enum NV
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
