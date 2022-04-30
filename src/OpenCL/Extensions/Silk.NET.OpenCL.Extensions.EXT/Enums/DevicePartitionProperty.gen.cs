// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenCL.Extensions.EXT
{
    [NativeName("Name", "cl_device_partition_property_ext")]
    public enum DevicePartitionProperty : ulong
    {
        [NativeName("Name", "CL_DEVICE_PARTITION_EQUALLY_EXT")]
        Equally = 0x4050,
        [NativeName("Name", "CL_DEVICE_PARTITION_BY_COUNTS_EXT")]
        ByCounts = 0x4051,
        [NativeName("Name", "CL_DEVICE_PARTITION_BY_NAMES_EXT")]
        ByNames = 0x4052,
        [NativeName("Name", "CL_DEVICE_PARTITION_BY_AFFINITY_DOMAIN_EXT")]
        ByAffinityDomain = 0x4053,
    }
}
