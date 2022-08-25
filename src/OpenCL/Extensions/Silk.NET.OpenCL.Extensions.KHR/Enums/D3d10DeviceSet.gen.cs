// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenCL.Extensions.KHR
{
    [NativeName("Name", "cl_d3d10_device_set_khr")]
    public enum D3d10DeviceSet : int
    {
        [NativeName("Name", "CL_PREFERRED_DEVICES_FOR_D3D10_KHR")]
        PreferredDevicesForD3D10 = 0x4012,
        [NativeName("Name", "CL_ALL_DEVICES_FOR_D3D10_KHR")]
        AllDevicesForD3D10 = 0x4013,
    }
}
