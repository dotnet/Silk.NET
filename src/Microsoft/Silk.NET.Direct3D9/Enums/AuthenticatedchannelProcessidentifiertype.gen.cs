// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D9
{
    [Flags]
    [NativeName("Name", "_D3DAUTHENTICATEDCHANNEL_PROCESSIDENTIFIERTYPE")]
    public enum AuthenticatedchannelProcessidentifiertype : int
    {
        [NativeName("Name", "PROCESSIDTYPE_UNKNOWN")]
        ProcessidtypeUnknown = 0x0,
        [NativeName("Name", "PROCESSIDTYPE_DWM")]
        ProcessidtypeDwm = 0x1,
        [NativeName("Name", "PROCESSIDTYPE_HANDLE")]
        ProcessidtypeHandle = 0x2,
    }
}
