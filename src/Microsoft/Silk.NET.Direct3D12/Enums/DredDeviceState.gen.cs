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
        [Obsolete("Deprecated in favour of \"Unknown\"")]
        [NativeName("Name", "D3D12_DRED_DEVICE_STATE_UNKNOWN")]
        DredDeviceStateUnknown = 0x0,
        [Obsolete("Deprecated in favour of \"Hung\"")]
        [NativeName("Name", "D3D12_DRED_DEVICE_STATE_HUNG")]
        DredDeviceStateHung = 0x3,
        [Obsolete("Deprecated in favour of \"Fault\"")]
        [NativeName("Name", "D3D12_DRED_DEVICE_STATE_FAULT")]
        DredDeviceStateFault = 0x6,
        [Obsolete("Deprecated in favour of \"Pagefault\"")]
        [NativeName("Name", "D3D12_DRED_DEVICE_STATE_PAGEFAULT")]
        DredDeviceStatePagefault = 0x7,
        [NativeName("Name", "D3D12_DRED_DEVICE_STATE_UNKNOWN")]
        Unknown = 0x0,
        [NativeName("Name", "D3D12_DRED_DEVICE_STATE_HUNG")]
        Hung = 0x3,
        [NativeName("Name", "D3D12_DRED_DEVICE_STATE_FAULT")]
        Fault = 0x6,
        [NativeName("Name", "D3D12_DRED_DEVICE_STATE_PAGEFAULT")]
        Pagefault = 0x7,
    }
}
