// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenCL.Extensions.EXT
{
    [System.Flags]
    [NativeName("Name", "cl_device_fp_atomic_capabilities_ext")]
    public enum DeviceFpAtomicCapabilitiesExt : ulong
    {
        [NativeName("Name", "CL_DEVICE_GLOBAL_FP_ATOMIC_LOAD_STORE_EXT")]
        DeviceGlobalFPAtomicLoadStoreExt = 0x1,
        [NativeName("Name", "CL_DEVICE_GLOBAL_FP_ATOMIC_ADD_EXT")]
        DeviceGlobalFPAtomicAddExt = 0x2,
        [NativeName("Name", "CL_DEVICE_GLOBAL_FP_ATOMIC_MIN_MAX_EXT")]
        DeviceGlobalFPAtomicMinMaxExt = 0x4,
        [NativeName("Name", "CL_DEVICE_LOCAL_FP_ATOMIC_LOAD_STORE_EXT")]
        DeviceLocalFPAtomicLoadStoreExt = 0x10000,
        [NativeName("Name", "CL_DEVICE_LOCAL_FP_ATOMIC_ADD_EXT")]
        DeviceLocalFPAtomicAddExt = 0x20000,
        [NativeName("Name", "CL_DEVICE_LOCAL_FP_ATOMIC_MIN_MAX_EXT")]
        DeviceLocalFPAtomicMinMaxExt = 0x40000,
    }
}
