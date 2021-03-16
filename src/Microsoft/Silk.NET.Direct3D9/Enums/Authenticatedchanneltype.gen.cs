// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D9
{
    [NativeName("Name", "_D3DAUTHENTICATEDCHANNELTYPE")]
    public enum Authenticatedchanneltype : int
    {
        [NativeName("Name", "D3DAUTHENTICATEDCHANNEL_D3D9")]
        AuthenticatedchannelD3D9 = 0x1,
        [NativeName("Name", "D3DAUTHENTICATEDCHANNEL_DRIVER_SOFTWARE")]
        AuthenticatedchannelDriverSoftware = 0x2,
        [NativeName("Name", "D3DAUTHENTICATEDCHANNEL_DRIVER_HARDWARE")]
        AuthenticatedchannelDriverHardware = 0x3,
    }
}
