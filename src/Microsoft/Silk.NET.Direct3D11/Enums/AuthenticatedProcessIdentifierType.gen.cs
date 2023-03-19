// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D11
{
    [NativeName("Name", "D3D11_AUTHENTICATED_PROCESS_IDENTIFIER_TYPE")]
    public enum AuthenticatedProcessIdentifierType : int
    {
        [Obsolete("Deprecated in favour of \"Unknown\"")]
        [NativeName("Name", "D3D11_PROCESSIDTYPE_UNKNOWN")]
        ProcessidtypeUnknown = 0x0,
        [Obsolete("Deprecated in favour of \"Dwm\"")]
        [NativeName("Name", "D3D11_PROCESSIDTYPE_DWM")]
        ProcessidtypeDwm = 0x1,
        [Obsolete("Deprecated in favour of \"Handle\"")]
        [NativeName("Name", "D3D11_PROCESSIDTYPE_HANDLE")]
        ProcessidtypeHandle = 0x2,
        [NativeName("Name", "D3D11_PROCESSIDTYPE_UNKNOWN")]
        Unknown = 0x0,
        [NativeName("Name", "D3D11_PROCESSIDTYPE_DWM")]
        Dwm = 0x1,
        [NativeName("Name", "D3D11_PROCESSIDTYPE_HANDLE")]
        Handle = 0x2,
    }
}
