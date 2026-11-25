// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenCL headers and corresponding dependencies.
// Original source is Copyright 2013-2026 The Khronos Group Inc. Licensed under the Apache 2.0 license.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenCL;

[NativeName("cl_svm_capabilities_khr")]
[Flags]
public enum SvmCapabilitiesKHR : ulong
{
    None = 0x0,

    [NativeName("CL_SVM_CAPABILITY_SINGLE_ADDRESS_SPACE_KHR")]
    SingleAddressSpace = 0x1,

    [NativeName("CL_SVM_CAPABILITY_SYSTEM_ALLOCATED_KHR")]
    SystemAllocated = 0x2,

    [NativeName("CL_SVM_CAPABILITY_DEVICE_OWNED_KHR")]
    DeviceOwned = 0x4,

    [NativeName("CL_SVM_CAPABILITY_DEVICE_UNASSOCIATED_KHR")]
    DeviceUnassociated = 0x8,

    [NativeName("CL_SVM_CAPABILITY_CONTEXT_ACCESS_KHR")]
    ContextAccess = 0x10,

    [NativeName("CL_SVM_CAPABILITY_HOST_OWNED_KHR")]
    HostOwned = 0x20,

    [NativeName("CL_SVM_CAPABILITY_HOST_READ_KHR")]
    HostRead = 0x40,

    [NativeName("CL_SVM_CAPABILITY_HOST_WRITE_KHR")]
    HostWrite = 0x80,

    [NativeName("CL_SVM_CAPABILITY_HOST_MAP_KHR")]
    HostMap = 0x100,

    [NativeName("CL_SVM_CAPABILITY_DEVICE_READ_KHR")]
    DeviceRead = 0x200,

    [NativeName("CL_SVM_CAPABILITY_DEVICE_WRITE_KHR")]
    DeviceWrite = 0x400,

    [NativeName("CL_SVM_CAPABILITY_DEVICE_ATOMIC_ACCESS_KHR")]
    DeviceAtomicAccess = 0x800,

    [NativeName("CL_SVM_CAPABILITY_CONCURRENT_ACCESS_KHR")]
    ConcurrentAccess = 0x1000,

    [NativeName("CL_SVM_CAPABILITY_CONCURRENT_ATOMIC_ACCESS_KHR")]
    ConcurrentAtomicAccess = 0x2000,

    [NativeName("CL_SVM_CAPABILITY_INDIRECT_ACCESS_KHR")]
    IndirectAccess = 0x4000,
}
