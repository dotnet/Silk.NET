// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenCL.Extensions.KHR
{
    [NativeName("Name", "cl_d3d11_device_set_khr")]
    public enum D3d11DeviceSet : int
    {
        [NativeName("Name", "CL_PREFERRED_DEVICES_FOR_D3D11_KHR")]
        PreferredDevicesForD3D11 = 0x401B,
        [NativeName("Name", "CL_ALL_DEVICES_FOR_D3D11_KHR")]
        AllDevicesForD3D11 = 0x401C,
    }
}
