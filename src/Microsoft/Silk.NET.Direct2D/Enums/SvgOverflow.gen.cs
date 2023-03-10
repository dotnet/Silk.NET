// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct2D
{
    [NativeName("Name", "D2D1_SVG_OVERFLOW")]
    public enum SvgOverflow : int
    {
        [Obsolete("Deprecated in favour of \"Visible\"")]
        [NativeName("Name", "D2D1_SVG_OVERFLOW_VISIBLE")]
        SvgOverflowVisible = 0x0,
        [Obsolete("Deprecated in favour of \"Hidden\"")]
        [NativeName("Name", "D2D1_SVG_OVERFLOW_HIDDEN")]
        SvgOverflowHidden = 0x1,
        [Obsolete("Deprecated in favour of \"ForceDword\"")]
        [NativeName("Name", "D2D1_SVG_OVERFLOW_FORCE_DWORD")]
        SvgOverflowForceDword = unchecked((int) 0xFFFFFFFFFFFFFFFF),
        [NativeName("Name", "D2D1_SVG_OVERFLOW_VISIBLE")]
        Visible = 0x0,
        [NativeName("Name", "D2D1_SVG_OVERFLOW_HIDDEN")]
        Hidden = 0x1,
        [NativeName("Name", "D2D1_SVG_OVERFLOW_FORCE_DWORD")]
        ForceDword = unchecked((int) 0xFFFFFFFFFFFFFFFF),
    }
}
