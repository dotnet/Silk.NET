// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D11
{
    [NativeName("Name", "D3D11_AUTHENTICATED_PROCESS_IDENTIFIER_TYPE")]
    public enum AuthenticatedProcessIdentifierType
    {
        [NativeName("Name", "D3D11_PROCESSIDTYPE_UNKNOWN")]
        ProcessidtypeUnknown = 0x0,
        [NativeName("Name", "D3D11_PROCESSIDTYPE_DWM")]
        ProcessidtypeDwm = 0x1,
        [NativeName("Name", "D3D11_PROCESSIDTYPE_HANDLE")]
        ProcessidtypeHandle = 0x2,
    }
}
