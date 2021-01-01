// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D9
{
    [NativeName("Name", "_D3DMATERIALCOLORSOURCE")]
    public enum Materialcolorsource : int
    {
        [NativeName("Name", "D3DMCS_MATERIAL")]
        McsMaterial = 0x0,
        [NativeName("Name", "D3DMCS_COLOR1")]
        McsColor1 = 0x1,
        [NativeName("Name", "D3DMCS_COLOR2")]
        McsColor2 = 0x2,
        [NativeName("Name", "D3DMCS_FORCE_DWORD")]
        McsForceDword = 0x7FFFFFFF,
    }
}
