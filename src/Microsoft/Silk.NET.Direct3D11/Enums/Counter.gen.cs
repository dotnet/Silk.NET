// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D11
{
    [NativeName("Name", "D3D11_COUNTER")]
    public enum Counter : int
    {
        [Obsolete("Deprecated in favour of \"DeviceDependent0\"")]
        [NativeName("Name", "D3D11_COUNTER_DEVICE_DEPENDENT_0")]
        CounterDeviceDependent0 = 0x40000000,
        [NativeName("Name", "D3D11_COUNTER_DEVICE_DEPENDENT_0")]
        DeviceDependent0 = 0x40000000,
    }
}
