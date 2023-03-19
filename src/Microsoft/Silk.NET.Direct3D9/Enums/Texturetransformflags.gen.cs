// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D9
{
    [Flags]
    [NativeName("Name", "_D3DTEXTURETRANSFORMFLAGS")]
    public enum Texturetransformflags : int
    {
        [Obsolete("Deprecated in favour of \"Disable\"")]
        [NativeName("Name", "D3DTTFF_DISABLE")]
        TtffDisable = 0x0,
        [Obsolete("Deprecated in favour of \"Count1\"")]
        [NativeName("Name", "D3DTTFF_COUNT1")]
        TtffCount1 = 0x1,
        [Obsolete("Deprecated in favour of \"Count2\"")]
        [NativeName("Name", "D3DTTFF_COUNT2")]
        TtffCount2 = 0x2,
        [Obsolete("Deprecated in favour of \"Count3\"")]
        [NativeName("Name", "D3DTTFF_COUNT3")]
        TtffCount3 = 0x3,
        [Obsolete("Deprecated in favour of \"Count4\"")]
        [NativeName("Name", "D3DTTFF_COUNT4")]
        TtffCount4 = 0x4,
        [Obsolete("Deprecated in favour of \"Projected\"")]
        [NativeName("Name", "D3DTTFF_PROJECTED")]
        TtffProjected = 0x100,
        [Obsolete("Deprecated in favour of \"ForceDword\"")]
        [NativeName("Name", "D3DTTFF_FORCE_DWORD")]
        TtffForceDword = 0x7FFFFFFF,
        [NativeName("Name", "D3DTTFF_DISABLE")]
        Disable = 0x0,
        [NativeName("Name", "D3DTTFF_COUNT1")]
        Count1 = 0x1,
        [NativeName("Name", "D3DTTFF_COUNT2")]
        Count2 = 0x2,
        [NativeName("Name", "D3DTTFF_COUNT3")]
        Count3 = 0x3,
        [NativeName("Name", "D3DTTFF_COUNT4")]
        Count4 = 0x4,
        [NativeName("Name", "D3DTTFF_PROJECTED")]
        Projected = 0x100,
        [NativeName("Name", "D3DTTFF_FORCE_DWORD")]
        ForceDword = 0x7FFFFFFF,
    }
}
