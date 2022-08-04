// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.DirectComposition
{
    [Flags]
    [NativeName("Name", "DCOMPOSITION_COMPOSITE_MODE")]
    public enum CompositeMode : int
    {
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"SourceOver\"")]
        [NativeName("Name", "DCOMPOSITION_COMPOSITE_MODE_SOURCE_OVER")]
        CompositeModeSourceOver = 0x0,
        [Obsolete("Deprecated in favour of \"DestinationInvert\"")]
        [NativeName("Name", "DCOMPOSITION_COMPOSITE_MODE_DESTINATION_INVERT")]
        CompositeModeDestinationInvert = 0x1,
        [Obsolete("Deprecated in favour of \"MinBlend\"")]
        [NativeName("Name", "DCOMPOSITION_COMPOSITE_MODE_MIN_BLEND")]
        CompositeModeMinBlend = 0x2,
        [Obsolete("Deprecated in favour of \"Inherit\"")]
        [NativeName("Name", "DCOMPOSITION_COMPOSITE_MODE_INHERIT")]
        CompositeModeInherit = unchecked((int) 0xFFFFFFFFFFFFFFFF),
        [NativeName("Name", "DCOMPOSITION_COMPOSITE_MODE_SOURCE_OVER")]
        SourceOver = 0x0,
        [NativeName("Name", "DCOMPOSITION_COMPOSITE_MODE_DESTINATION_INVERT")]
        DestinationInvert = 0x1,
        [NativeName("Name", "DCOMPOSITION_COMPOSITE_MODE_MIN_BLEND")]
        MinBlend = 0x2,
        [NativeName("Name", "DCOMPOSITION_COMPOSITE_MODE_INHERIT")]
        Inherit = unchecked((int) 0xFFFFFFFFFFFFFFFF),
    }
}
