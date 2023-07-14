// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.DXGI
{
    [NativeName("Name", "DXGI_ADAPTER_FLAG")]
    public enum AdapterFlag : int
    {
        [Obsolete("Deprecated in favour of \"None\"")]
        [NativeName("Name", "DXGI_ADAPTER_FLAG_NONE")]
        AdapterFlagNone = 0x0,
        [Obsolete("Deprecated in favour of \"Remote\"")]
        [NativeName("Name", "DXGI_ADAPTER_FLAG_REMOTE")]
        AdapterFlagRemote = 0x1,
        [Obsolete("Deprecated in favour of \"Software\"")]
        [NativeName("Name", "DXGI_ADAPTER_FLAG_SOFTWARE")]
        AdapterFlagSoftware = 0x2,
        [Obsolete("Deprecated in favour of \"ForceDword\"")]
        [NativeName("Name", "DXGI_ADAPTER_FLAG_FORCE_DWORD")]
        AdapterFlagForceDword = unchecked((int) 0xFFFFFFFFFFFFFFFF),
        [NativeName("Name", "DXGI_ADAPTER_FLAG_NONE")]
        None = 0x0,
        [NativeName("Name", "DXGI_ADAPTER_FLAG_REMOTE")]
        Remote = 0x1,
        [NativeName("Name", "DXGI_ADAPTER_FLAG_SOFTWARE")]
        Software = 0x2,
        [NativeName("Name", "DXGI_ADAPTER_FLAG_FORCE_DWORD")]
        ForceDword = unchecked((int) 0xFFFFFFFFFFFFFFFF),
    }
}
