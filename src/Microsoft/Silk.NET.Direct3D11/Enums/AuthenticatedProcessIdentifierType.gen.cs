// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D11
{
    [Flags]
    [NativeName("Name", "D3D11_AUTHENTICATED_PROCESS_IDENTIFIER_TYPE")]
    public enum AuthenticatedProcessIdentifierType : int
    {
        [NativeName("Name", "D3D11_PROCESSIDTYPE_UNKNOWN")]
        ProcessidtypeUnknown = 0x0,
        [NativeName("Name", "D3D11_PROCESSIDTYPE_DWM")]
        ProcessidtypeDwm = 0x1,
        [NativeName("Name", "D3D11_PROCESSIDTYPE_HANDLE")]
        ProcessidtypeHandle = 0x2,
    }
}
