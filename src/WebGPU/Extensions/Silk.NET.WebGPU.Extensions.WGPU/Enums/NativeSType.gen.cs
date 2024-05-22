// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.WebGPU.Extensions.WGPU
{
    [NativeName("Name", "WGPUNativeSType")]
    public enum NativeSType : int
    {
        [NativeName("Name", "WGPUSType_DeviceExtras")]
        STypeDeviceExtras = 0x60000001,
        [NativeName("Name", "WGPUSType_AdapterExtras")]
        STypeAdapterExtras = 0x60000002,
        [NativeName("Name", "WGPUNativeSType_Force32")]
        NativeSTypeForce32 = 0x7FFFFFFF,
    }
}
