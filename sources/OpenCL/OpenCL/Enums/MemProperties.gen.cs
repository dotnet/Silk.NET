// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenCL headers and corresponding dependencies.
// Original source is Copyright 2013-2026 The Khronos Group Inc. Licensed under the Apache 2.0 license.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenCL;

[NativeName("cl_mem_properties")]
public enum MemProperties : ulong
{
    [NativeName("CL_MEM_ALLOC_FLAGS_IMG")]
    AllocFlagsIMG = 16599,

    [NativeName("CL_MEM_DEVICE_HANDLE_LIST_KHR")]
    DeviceHandleListKHR = 8273,

    [NativeName("CL_MEM_LOCALLY_UNCACHED_RESOURCE_INTEL")]
    LocallyUncachedResourceINTEL = 16920,

    [NativeName("CL_MEM_DEVICE_ID_INTEL")]
    DeviceIdINTEL = 16921,

    [NativeName("CL_MEM_DEVICE_PRIVATE_ADDRESS_EXT")]
    DevicePrivateAddressEXT = 20480,
}
