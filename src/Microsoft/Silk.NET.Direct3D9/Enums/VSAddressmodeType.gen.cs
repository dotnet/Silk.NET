// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D9
{
    [Flags]
    [NativeName("Name", "_D3DVS_ADDRESSMODE_TYPE")]
    public enum VSAddressmodeType : int
    {
        [Obsolete("Deprecated in favour of \"Absolute\"")]
        [NativeName("Name", "D3DVS_ADDRMODE_ABSOLUTE")]
        VSAddrmodeAbsolute = 0x0,
        [Obsolete("Deprecated in favour of \"Relative\"")]
        [NativeName("Name", "D3DVS_ADDRMODE_RELATIVE")]
        VSAddrmodeRelative = 0x2000,
        [Obsolete("Deprecated in favour of \"ForceDword\"")]
        [NativeName("Name", "D3DVS_ADDRMODE_FORCE_DWORD")]
        VSAddrmodeForceDword = 0x7FFFFFFF,
        [NativeName("Name", "D3DVS_ADDRMODE_ABSOLUTE")]
        Absolute = 0x0,
        [NativeName("Name", "D3DVS_ADDRMODE_RELATIVE")]
        Relative = 0x2000,
        [NativeName("Name", "D3DVS_ADDRMODE_FORCE_DWORD")]
        ForceDword = 0x7FFFFFFF,
    }
}
