// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenCL headers and corresponding dependencies.
// Original source is Copyright 2013-2026 The Khronos Group Inc. Licensed under the Apache 2.0 license.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenCL;

[NativeName("cl_device_partition_property_ext")]
public enum DevicePartitionPropertyEXT : ulong
{
    [NativeName("CL_DEVICE_PARTITION_EQUALLY_EXT")]
    DevicePartitionEqually = 16464,

    [NativeName("CL_DEVICE_PARTITION_BY_COUNTS_EXT")]
    DevicePartitionByCounts = 16465,

    [NativeName("CL_DEVICE_PARTITION_BY_NAMES_EXT")]
    DevicePartitionByNames = 16466,

    [NativeName("CL_DEVICE_PARTITION_BY_AFFINITY_DOMAIN_EXT")]
    DevicePartitionByAffinityDomain = 16467,

    [NativeName("CL_AFFINITY_DOMAIN_L1_CACHE_EXT")]
    AffinityDomainL1Cache = 1,

    [NativeName("CL_AFFINITY_DOMAIN_L2_CACHE_EXT")]
    AffinityDomainL2Cache = 2,

    [NativeName("CL_AFFINITY_DOMAIN_L3_CACHE_EXT")]
    AffinityDomainL3Cache = 3,

    [NativeName("CL_AFFINITY_DOMAIN_L4_CACHE_EXT")]
    AffinityDomainL4Cache = 4,

    [NativeName("CL_AFFINITY_DOMAIN_NUMA_EXT")]
    AffinityDomainNuma = 16,

    [NativeName("CL_AFFINITY_DOMAIN_NEXT_FISSIONABLE_EXT")]
    AffinityDomainNextFissionable = 256,
}
