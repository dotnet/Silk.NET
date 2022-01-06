// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D9
{
    [Flags]
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
