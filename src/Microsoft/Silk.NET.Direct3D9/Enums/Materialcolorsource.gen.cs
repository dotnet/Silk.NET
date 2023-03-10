// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D9
{
    [NativeName("Name", "_D3DMATERIALCOLORSOURCE")]
    public enum Materialcolorsource : int
    {
        [Obsolete("Deprecated in favour of \"Material\"")]
        [NativeName("Name", "D3DMCS_MATERIAL")]
        McsMaterial = 0x0,
        [Obsolete("Deprecated in favour of \"Color1\"")]
        [NativeName("Name", "D3DMCS_COLOR1")]
        McsColor1 = 0x1,
        [Obsolete("Deprecated in favour of \"Color2\"")]
        [NativeName("Name", "D3DMCS_COLOR2")]
        McsColor2 = 0x2,
        [Obsolete("Deprecated in favour of \"ForceDword\"")]
        [NativeName("Name", "D3DMCS_FORCE_DWORD")]
        McsForceDword = 0x7FFFFFFF,
        [NativeName("Name", "D3DMCS_MATERIAL")]
        Material = 0x0,
        [NativeName("Name", "D3DMCS_COLOR1")]
        Color1 = 0x1,
        [NativeName("Name", "D3DMCS_COLOR2")]
        Color2 = 0x2,
        [NativeName("Name", "D3DMCS_FORCE_DWORD")]
        ForceDword = 0x7FFFFFFF,
    }
}
