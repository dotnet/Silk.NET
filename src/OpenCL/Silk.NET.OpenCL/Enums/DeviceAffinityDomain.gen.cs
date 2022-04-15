// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenCL
{
    [System.Flags]
    [NativeName("Name", "cl_device_affinity_domain")]
    public enum DeviceAffinityDomain : ulong
    {
        [NativeName("Name", "CL_DEVICE_AFFINITY_DOMAIN_NUMA")]
        DeviceAffinityDomainNuma = 0x1,
        [NativeName("Name", "CL_DEVICE_AFFINITY_DOMAIN_L4_CACHE")]
        DeviceAffinityDomainL4Cache = 0x2,
        [NativeName("Name", "CL_DEVICE_AFFINITY_DOMAIN_L3_CACHE")]
        DeviceAffinityDomainL3Cache = 0x4,
        [NativeName("Name", "CL_DEVICE_AFFINITY_DOMAIN_L2_CACHE")]
        DeviceAffinityDomainL2Cache = 0x8,
        [NativeName("Name", "CL_DEVICE_AFFINITY_DOMAIN_L1_CACHE")]
        DeviceAffinityDomainL1Cache = 0x10,
        [NativeName("Name", "CL_DEVICE_AFFINITY_DOMAIN_NEXT_PARTITIONABLE")]
        DeviceAffinityDomainNextPartitionable = 0x20,
    }
}
