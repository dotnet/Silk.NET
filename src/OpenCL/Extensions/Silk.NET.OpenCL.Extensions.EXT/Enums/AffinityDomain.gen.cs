// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenCL.Extensions.EXT
{
    [Flags]
    [NativeName("Name", "cl_affinity_domain_ext")]
    public enum AffinityDomain : int
    {
        [NativeName("Name", "")]
        None = 0,
        [NativeName("Name", "CL_AFFINITY_DOMAIN_L1_CACHE_EXT")]
        L1Cache = 0x1,
        [NativeName("Name", "CL_AFFINITY_DOMAIN_L2_CACHE_EXT")]
        L2Cache = 0x2,
        [NativeName("Name", "CL_AFFINITY_DOMAIN_L3_CACHE_EXT")]
        L3Cache = 0x3,
        [NativeName("Name", "CL_AFFINITY_DOMAIN_L4_CACHE_EXT")]
        L4Cache = 0x4,
        [NativeName("Name", "CL_AFFINITY_DOMAIN_NUMA_EXT")]
        Numa = 0x10,
        [NativeName("Name", "CL_AFFINITY_DOMAIN_NEXT_FISSIONABLE_EXT")]
        NextFissionable = 0x100,
    }
}
