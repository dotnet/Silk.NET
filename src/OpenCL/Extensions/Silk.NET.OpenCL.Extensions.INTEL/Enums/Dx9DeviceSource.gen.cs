// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenCL.Extensions.INTEL
{
    [NativeName("Name", "cl_dx9_device_source_intel")]
    public enum Dx9DeviceSource : int
    {
        [NativeName("Name", "CL_D3D9_DEVICE_INTEL")]
        D3D9Device = 0x4022,
        [NativeName("Name", "CL_D3D9EX_DEVICE_INTEL")]
        D3D9EXDevice = 0x4070,
        [NativeName("Name", "CL_DXVA_DEVICE_INTEL")]
        DxvaDevice = 0x4071,
    }
}
