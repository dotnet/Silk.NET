// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.DirectComposition
{
    [NativeName("Name", "DCOMPOSITION_COMPOSITE_MODE")]
    public enum CompositeMode : int
    {
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
