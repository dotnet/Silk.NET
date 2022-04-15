// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenCL.Extensions.EXT
{
    [NativeName("Name", "cl_affinity_domain_ext")]
    public enum AffinityDomainExt : int
    {
        [NativeName("Name", "CL_AFFINITY_DOMAIN_L1_CACHE_EXT")]
        AffinityDomainL1CacheExt = 0x1,
        [NativeName("Name", "CL_AFFINITY_DOMAIN_L2_CACHE_EXT")]
        AffinityDomainL2CacheExt = 0x2,
        [NativeName("Name", "CL_AFFINITY_DOMAIN_L3_CACHE_EXT")]
        AffinityDomainL3CacheExt = 0x3,
        [NativeName("Name", "CL_AFFINITY_DOMAIN_L4_CACHE_EXT")]
        AffinityDomainL4CacheExt = 0x4,
        [NativeName("Name", "CL_AFFINITY_DOMAIN_NUMA_EXT")]
        AffinityDomainNumaExt = 0x10,
        [NativeName("Name", "CL_AFFINITY_DOMAIN_NEXT_FISSIONABLE_EXT")]
        AffinityDomainNextFissionableExt = 0x100,
    }
}
