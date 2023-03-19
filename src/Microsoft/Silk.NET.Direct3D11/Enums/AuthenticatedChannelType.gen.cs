// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D11
{
    [NativeName("Name", "D3D11_AUTHENTICATED_CHANNEL_TYPE")]
    public enum AuthenticatedChannelType : int
    {
        [Obsolete("Deprecated in favour of \"D3D11\"")]
        [NativeName("Name", "D3D11_AUTHENTICATED_CHANNEL_D3D11")]
        AuthenticatedChannelD3D11 = 0x1,
        [Obsolete("Deprecated in favour of \"DriverSoftware\"")]
        [NativeName("Name", "D3D11_AUTHENTICATED_CHANNEL_DRIVER_SOFTWARE")]
        AuthenticatedChannelDriverSoftware = 0x2,
        [Obsolete("Deprecated in favour of \"DriverHardware\"")]
        [NativeName("Name", "D3D11_AUTHENTICATED_CHANNEL_DRIVER_HARDWARE")]
        AuthenticatedChannelDriverHardware = 0x3,
        [NativeName("Name", "D3D11_AUTHENTICATED_CHANNEL_D3D11")]
        D3D11 = 0x1,
        [NativeName("Name", "D3D11_AUTHENTICATED_CHANNEL_DRIVER_SOFTWARE")]
        DriverSoftware = 0x2,
        [NativeName("Name", "D3D11_AUTHENTICATED_CHANNEL_DRIVER_HARDWARE")]
        DriverHardware = 0x3,
    }
}
