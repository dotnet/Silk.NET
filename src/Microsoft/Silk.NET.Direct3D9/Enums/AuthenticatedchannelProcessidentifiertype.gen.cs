// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D9
{
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
