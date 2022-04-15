// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenCL
{
    [NativeName("Name", "cl_device_partition_property")]
    public enum DevicePartitionProperty : int
    {
        [NativeName("Name", "CL_DEVICE_PARTITION_EQUALLY")]
        DevicePartitionEqually = 0x1086,
        [NativeName("Name", "CL_DEVICE_PARTITION_BY_COUNTS")]
        DevicePartitionByCounts = 0x1087,
        [NativeName("Name", "CL_DEVICE_PARTITION_BY_AFFINITY_DOMAIN")]
        DevicePartitionByAffinityDomain = 0x1088,
        [NativeName("Name", "CL_DEVICE_PARTITION_BY_NAMES_INTEL")]
        DevicePartitionByNamesIntel = 0x4052,
    }
}
