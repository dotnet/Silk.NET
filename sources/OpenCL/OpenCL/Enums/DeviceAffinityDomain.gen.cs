// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenCL headers and corresponding dependencies.
// Original source is Copyright 2013-2026 The Khronos Group Inc. Licensed under the Apache 2.0 license.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenCL;

[NativeName("cl_device_affinity_domain")]
[Flags]
public enum DeviceAffinityDomain : ulong
{
    None = 0x0,

    [NativeName("CL_DEVICE_AFFINITY_DOMAIN_NUMA")]
    Numa = 0x1,

    [NativeName("CL_DEVICE_AFFINITY_DOMAIN_L4_CACHE")]
    L4Cache = 0x2,

    [NativeName("CL_DEVICE_AFFINITY_DOMAIN_L3_CACHE")]
    L3Cache = 0x4,

    [NativeName("CL_DEVICE_AFFINITY_DOMAIN_L2_CACHE")]
    L2Cache = 0x8,

    [NativeName("CL_DEVICE_AFFINITY_DOMAIN_L1_CACHE")]
    L1Cache = 0x10,

    [NativeName("CL_DEVICE_AFFINITY_DOMAIN_NEXT_PARTITIONABLE")]
    NextPartitionable = 0x20,
}
