// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenCL headers and corresponding dependencies.
// Original source is Copyright 2013-2026 The Khronos Group Inc. Licensed under the Apache 2.0 license.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenCL;

[NativeName("cl_device_partition_property")]
public enum DevicePartitionProperty : long
{
    [NativeName("CL_DEVICE_PARTITION_EQUALLY")]
    Equally = 4230,

    [NativeName("CL_DEVICE_PARTITION_BY_COUNTS")]
    ByCounts = 4231,

    [NativeName("CL_DEVICE_PARTITION_BY_AFFINITY_DOMAIN")]
    ByAffinityDomain = 4232,
}
