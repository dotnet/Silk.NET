// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenCL.Extensions.KHR
{
    [NativeName("Name", "cl_d3d11_device_source_khr")]
    public enum D3d11DeviceSource : int
    {
        [NativeName("Name", "CL_D3D11_DEVICE_KHR")]
        Device = 0x4019,
        [NativeName("Name", "CL_D3D11_DXGI_ADAPTER_KHR")]
        DxgiAdapter = 0x401A,
    }
}
