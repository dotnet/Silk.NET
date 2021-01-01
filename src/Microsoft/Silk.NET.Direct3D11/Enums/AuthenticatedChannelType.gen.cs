// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D11
{
    [NativeName("Name", "D3D11_AUTHENTICATED_CHANNEL_TYPE")]
    public enum AuthenticatedChannelType : int
    {
        [NativeName("Name", "D3D11_AUTHENTICATED_CHANNEL_D3D11")]
        AuthenticatedChannelD3D11 = 0x1,
        [NativeName("Name", "D3D11_AUTHENTICATED_CHANNEL_DRIVER_SOFTWARE")]
        AuthenticatedChannelDriverSoftware = 0x2,
        [NativeName("Name", "D3D11_AUTHENTICATED_CHANNEL_DRIVER_HARDWARE")]
        AuthenticatedChannelDriverHardware = 0x3,
    }
}
