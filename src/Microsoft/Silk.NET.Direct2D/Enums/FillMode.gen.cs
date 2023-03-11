// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct2D
{
    [Flags]
    [NativeName("Name", "D2D1_FILL_MODE")]
    public enum FillMode : int
    {
        [Obsolete("Deprecated in favour of \"Alternate\"")]
        [NativeName("Name", "D2D1_FILL_MODE_ALTERNATE")]
        FillModeAlternate = 0x0,
        [Obsolete("Deprecated in favour of \"Winding\"")]
        [NativeName("Name", "D2D1_FILL_MODE_WINDING")]
        FillModeWinding = 0x1,
        [Obsolete("Deprecated in favour of \"ForceDword\"")]
        [NativeName("Name", "D2D1_FILL_MODE_FORCE_DWORD")]
        FillModeForceDword = unchecked((int) 0xFFFFFFFFFFFFFFFF),
        [NativeName("Name", "D2D1_FILL_MODE_ALTERNATE")]
        Alternate = 0x0,
        [NativeName("Name", "D2D1_FILL_MODE_WINDING")]
        Winding = 0x1,
        [NativeName("Name", "D2D1_FILL_MODE_FORCE_DWORD")]
        ForceDword = unchecked((int) 0xFFFFFFFFFFFFFFFF),
    }
}
