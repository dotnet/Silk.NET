// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenCL.Extensions.INTEL
{
    [System.Flags]
    [NativeName("Name", "cl_device_feature_capabilities_intel")]
    public enum DeviceFeatureCapabilitiesIntel : ulong
    {
        [NativeName("Name", "CL_DEVICE_FEATURE_FLAG_DP4A_INTEL")]
        DeviceFeatureFlagDP4AIntel = 0x1,
        [NativeName("Name", "CL_DEVICE_FEATURE_FLAG_DPAS_INTEL")]
        DeviceFeatureFlagDpasIntel = 0x2,
    }
}
