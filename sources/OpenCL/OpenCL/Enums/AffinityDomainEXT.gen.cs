// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenCL headers and corresponding dependencies.
// Original source is Copyright 2013-2026 The Khronos Group Inc. Licensed under the Apache 2.0 license.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenCL;

[NativeName("cl_affinity_domain_ext")]
public enum AffinityDomainEXT : uint
{
    [NativeName("CL_AFFINITY_DOMAIN_L1_CACHE_EXT")]
    L1Cache = 1,

    [NativeName("CL_AFFINITY_DOMAIN_L2_CACHE_EXT")]
    L2Cache = 2,

    [NativeName("CL_AFFINITY_DOMAIN_L3_CACHE_EXT")]
    L3Cache = 3,

    [NativeName("CL_AFFINITY_DOMAIN_L4_CACHE_EXT")]
    L4Cache = 4,

    [NativeName("CL_AFFINITY_DOMAIN_NUMA_EXT")]
    Numa = 16,

    [NativeName("CL_AFFINITY_DOMAIN_NEXT_FISSIONABLE_EXT")]
    NextFissionable = 256,
}
