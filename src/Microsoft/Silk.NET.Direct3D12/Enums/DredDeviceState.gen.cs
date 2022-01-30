// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_DRED_DEVICE_STATE")]
    public enum DredDeviceState : int
    {
        [NativeName("Name", "D3D12_DRED_DEVICE_STATE_UNKNOWN")]
        DredDeviceStateUnknown = 0x0,
        [NativeName("Name", "D3D12_DRED_DEVICE_STATE_HUNG")]
        DredDeviceStateHung = 0x3,
        [NativeName("Name", "D3D12_DRED_DEVICE_STATE_FAULT")]
        DredDeviceStateFault = 0x6,
        [NativeName("Name", "D3D12_DRED_DEVICE_STATE_PAGEFAULT")]
        DredDeviceStatePagefault = 0x7,
    }
}
