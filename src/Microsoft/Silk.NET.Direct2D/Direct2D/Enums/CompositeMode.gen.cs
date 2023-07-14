// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct2D
{
    [NativeName("Name", "D2D1_COMPOSITE_MODE")]
    public enum CompositeMode : int
    {
        [NativeName("Name", "D2D1_COMPOSITE_MODE_SOURCE_OVER")]
        SourceOver = 0x0,
        [NativeName("Name", "D2D1_COMPOSITE_MODE_DESTINATION_OVER")]
        DestinationOver = 0x1,
        [NativeName("Name", "D2D1_COMPOSITE_MODE_SOURCE_IN")]
        SourceIn = 0x2,
        [NativeName("Name", "D2D1_COMPOSITE_MODE_DESTINATION_IN")]
        DestinationIn = 0x3,
        [NativeName("Name", "D2D1_COMPOSITE_MODE_SOURCE_OUT")]
        SourceOut = 0x4,
        [NativeName("Name", "D2D1_COMPOSITE_MODE_DESTINATION_OUT")]
        DestinationOut = 0x5,
        [NativeName("Name", "D2D1_COMPOSITE_MODE_SOURCE_ATOP")]
        SourceAtop = 0x6,
        [NativeName("Name", "D2D1_COMPOSITE_MODE_DESTINATION_ATOP")]
        DestinationAtop = 0x7,
        [NativeName("Name", "D2D1_COMPOSITE_MODE_XOR")]
        Xor = 0x8,
        [NativeName("Name", "D2D1_COMPOSITE_MODE_PLUS")]
        Plus = 0x9,
        [NativeName("Name", "D2D1_COMPOSITE_MODE_SOURCE_COPY")]
        SourceCopy = 0xA,
        [NativeName("Name", "D2D1_COMPOSITE_MODE_BOUNDED_SOURCE_COPY")]
        BoundedSourceCopy = 0xB,
        [NativeName("Name", "D2D1_COMPOSITE_MODE_MASK_INVERT")]
        MaskInvert = 0xC,
        [NativeName("Name", "D2D1_COMPOSITE_MODE_FORCE_DWORD")]
        ForceDword = unchecked((int) 0xFFFFFFFFFFFFFFFF),
    }
}
