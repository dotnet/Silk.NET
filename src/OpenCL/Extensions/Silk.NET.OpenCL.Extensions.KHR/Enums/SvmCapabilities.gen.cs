// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenCL.Extensions.KHR
{
    [System.Flags]
    [NativeName("Name", "cl_svm_capabilities_khr")]
    public enum SvmCapabilities : ulong
    {
        [NativeName("Name", "")]
        None = 0,
        [NativeName("Name", "CL_SVM_CAPABILITY_SINGLE_ADDRESS_SPACE_KHR")]
        SingleAddressSpace = 0x1,
        [NativeName("Name", "CL_SVM_CAPABILITY_SYSTEM_ALLOCATED_KHR")]
        SystemAllocated = 0x2,
        [NativeName("Name", "CL_SVM_CAPABILITY_DEVICE_OWNED_KHR")]
        DeviceOwned = 0x4,
        [NativeName("Name", "CL_SVM_CAPABILITY_DEVICE_UNASSOCIATED_KHR")]
        DeviceUnassociated = 0x8,
        [NativeName("Name", "CL_SVM_CAPABILITY_CONTEXT_ACCESS_KHR")]
        ContextAccess = 0x10,
        [NativeName("Name", "CL_SVM_CAPABILITY_HOST_OWNED_KHR")]
        HostOwned = 0x20,
        [NativeName("Name", "CL_SVM_CAPABILITY_HOST_READ_KHR")]
        HostRead = 0x40,
        [NativeName("Name", "CL_SVM_CAPABILITY_HOST_WRITE_KHR")]
        HostWrite = 0x80,
        [NativeName("Name", "CL_SVM_CAPABILITY_HOST_MAP_KHR")]
        HostMap = 0x100,
        [NativeName("Name", "CL_SVM_CAPABILITY_DEVICE_READ_KHR")]
        DeviceRead = 0x200,
        [NativeName("Name", "CL_SVM_CAPABILITY_DEVICE_WRITE_KHR")]
        DeviceWrite = 0x400,
        [NativeName("Name", "CL_SVM_CAPABILITY_DEVICE_ATOMIC_ACCESS_KHR")]
        DeviceAtomicAccess = 0x800,
        [NativeName("Name", "CL_SVM_CAPABILITY_CONCURRENT_ACCESS_KHR")]
        ConcurrentAccess = 0x1000,
        [NativeName("Name", "CL_SVM_CAPABILITY_CONCURRENT_ATOMIC_ACCESS_KHR")]
        ConcurrentAtomicAccess = 0x2000,
        [NativeName("Name", "CL_SVM_CAPABILITY_INDIRECT_ACCESS_KHR")]
        IndirectAccess = 0x4000,
    }
}
