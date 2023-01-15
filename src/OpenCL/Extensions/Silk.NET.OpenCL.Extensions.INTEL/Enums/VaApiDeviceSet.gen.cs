// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenCL.Extensions.INTEL
{
    [NativeName("Name", "cl_va_api_device_set_intel")]
    public enum VaApiDeviceSet : int
    {
        [NativeName("Name", "CL_PREFERRED_DEVICES_FOR_VA_API_INTEL")]
        PreferredDevicesForVAApi = 0x4095,
        [NativeName("Name", "CL_ALL_DEVICES_FOR_VA_API_INTEL")]
        AllDevicesForVAApi = 0x4096,
    }
}
