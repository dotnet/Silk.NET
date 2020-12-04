// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D9
{
    [NativeName("Name", "_D3DTEXTURETRANSFORMFLAGS")]
    public enum Texturetransformflags
    {
        [NativeName("Name", "D3DTTFF_DISABLE")]
        TtffDisable = 0x0,
        [NativeName("Name", "D3DTTFF_COUNT1")]
        TtffCount1 = 0x1,
        [NativeName("Name", "D3DTTFF_COUNT2")]
        TtffCount2 = 0x2,
        [NativeName("Name", "D3DTTFF_COUNT3")]
        TtffCount3 = 0x3,
        [NativeName("Name", "D3DTTFF_COUNT4")]
        TtffCount4 = 0x4,
        [NativeName("Name", "D3DTTFF_PROJECTED")]
        TtffProjected = 0x100,
        [NativeName("Name", "D3DTTFF_FORCE_DWORD")]
        TtffForceDword = 0x7FFFFFFF,
    }
}
