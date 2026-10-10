// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenCL headers and corresponding dependencies.
// Original source is Copyright 2013-2026 The Khronos Group Inc. Licensed under the Apache 2.0 license.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenCL;

[NativeName("cl_device_fp_atomic_capabilities_ext")]
[Flags]
public enum DeviceFpAtomicCapabilitiesEXT : ulong
{
    None = 0x0,

    [NativeName("CL_DEVICE_GLOBAL_FP_ATOMIC_LOAD_STORE_EXT")]
    GlobalFpAtomicLoadStore = 0x1,

    [NativeName("CL_DEVICE_GLOBAL_FP_ATOMIC_ADD_EXT")]
    GlobalFpAtomicAdd = 0x2,

    [NativeName("CL_DEVICE_GLOBAL_FP_ATOMIC_MIN_MAX_EXT")]
    GlobalFpAtomicMinMax = 0x4,

    [NativeName("CL_DEVICE_LOCAL_FP_ATOMIC_LOAD_STORE_EXT")]
    LocalFpAtomicLoadStore = 0x10000,

    [NativeName("CL_DEVICE_LOCAL_FP_ATOMIC_ADD_EXT")]
    LocalFpAtomicAdd = 0x20000,

    [NativeName("CL_DEVICE_LOCAL_FP_ATOMIC_MIN_MAX_EXT")]
    LocalFpAtomicMinMax = 0x40000,
}
