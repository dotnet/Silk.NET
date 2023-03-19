// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D9
{
    [NativeName("Name", "_D3DDEVTYPE")]
    public enum Devtype : int
    {
        [Obsolete("Deprecated in favour of \"Hal\"")]
        [NativeName("Name", "D3DDEVTYPE_HAL")]
        DevtypeHal = 0x1,
        [Obsolete("Deprecated in favour of \"Ref\"")]
        [NativeName("Name", "D3DDEVTYPE_REF")]
        DevtypeRef = 0x2,
        [Obsolete("Deprecated in favour of \"SW\"")]
        [NativeName("Name", "D3DDEVTYPE_SW")]
        DevtypeSW = 0x3,
        [Obsolete("Deprecated in favour of \"Nullref\"")]
        [NativeName("Name", "D3DDEVTYPE_NULLREF")]
        DevtypeNullref = 0x4,
        [Obsolete("Deprecated in favour of \"ForceDword\"")]
        [NativeName("Name", "D3DDEVTYPE_FORCE_DWORD")]
        DevtypeForceDword = 0x7FFFFFFF,
        [NativeName("Name", "D3DDEVTYPE_HAL")]
        Hal = 0x1,
        [NativeName("Name", "D3DDEVTYPE_REF")]
        Ref = 0x2,
        [NativeName("Name", "D3DDEVTYPE_SW")]
        SW = 0x3,
        [NativeName("Name", "D3DDEVTYPE_NULLREF")]
        Nullref = 0x4,
        [NativeName("Name", "D3DDEVTYPE_FORCE_DWORD")]
        ForceDword = 0x7FFFFFFF,
    }
}
