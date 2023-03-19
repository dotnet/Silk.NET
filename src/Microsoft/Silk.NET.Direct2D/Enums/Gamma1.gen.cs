// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct2D
{
    [NativeName("Name", "D2D1_GAMMA1")]
    public enum Gamma1 : int
    {
        [Obsolete("Deprecated in favour of \"G22\"")]
        [NativeName("Name", "D2D1_GAMMA1_G22")]
        Gamma1G22 = 0x0,
        [Obsolete("Deprecated in favour of \"G10\"")]
        [NativeName("Name", "D2D1_GAMMA1_G10")]
        Gamma1G10 = 0x1,
        [Obsolete("Deprecated in favour of \"G2084\"")]
        [NativeName("Name", "D2D1_GAMMA1_G2084")]
        Gamma1G2084 = 0x2,
        [Obsolete("Deprecated in favour of \"ForceDword\"")]
        [NativeName("Name", "D2D1_GAMMA1_FORCE_DWORD")]
        Gamma1ForceDword = unchecked((int) 0xFFFFFFFFFFFFFFFF),
        [NativeName("Name", "D2D1_GAMMA1_G22")]
        G22 = 0x0,
        [NativeName("Name", "D2D1_GAMMA1_G10")]
        G10 = 0x1,
        [NativeName("Name", "D2D1_GAMMA1_G2084")]
        G2084 = 0x2,
        [NativeName("Name", "D2D1_GAMMA1_FORCE_DWORD")]
        ForceDword = unchecked((int) 0xFFFFFFFFFFFFFFFF),
    }
}
