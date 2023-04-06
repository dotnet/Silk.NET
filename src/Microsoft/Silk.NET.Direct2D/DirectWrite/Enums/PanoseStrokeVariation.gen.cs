// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.DirectWrite
{
    [NativeName("Name", "DWRITE_PANOSE_STROKE_VARIATION")]
    public enum PanoseStrokeVariation : int
    {
        [NativeName("Name", "DWRITE_PANOSE_STROKE_VARIATION_ANY")]
        Any = 0x0,
        [NativeName("Name", "DWRITE_PANOSE_STROKE_VARIATION_NO_FIT")]
        NoFit = 0x1,
        [NativeName("Name", "DWRITE_PANOSE_STROKE_VARIATION_NO_VARIATION")]
        NoVariation = 0x2,
        [NativeName("Name", "DWRITE_PANOSE_STROKE_VARIATION_GRADUAL_DIAGONAL")]
        GradualDiagonal = 0x3,
        [NativeName("Name", "DWRITE_PANOSE_STROKE_VARIATION_GRADUAL_TRANSITIONAL")]
        GradualTransitional = 0x4,
        [NativeName("Name", "DWRITE_PANOSE_STROKE_VARIATION_GRADUAL_VERTICAL")]
        GradualVertical = 0x5,
        [NativeName("Name", "DWRITE_PANOSE_STROKE_VARIATION_GRADUAL_HORIZONTAL")]
        GradualHorizontal = 0x6,
        [NativeName("Name", "DWRITE_PANOSE_STROKE_VARIATION_RAPID_VERTICAL")]
        RapidVertical = 0x7,
        [NativeName("Name", "DWRITE_PANOSE_STROKE_VARIATION_RAPID_HORIZONTAL")]
        RapidHorizontal = 0x8,
        [NativeName("Name", "DWRITE_PANOSE_STROKE_VARIATION_INSTANT_VERTICAL")]
        InstantVertical = 0x9,
        [NativeName("Name", "DWRITE_PANOSE_STROKE_VARIATION_INSTANT_HORIZONTAL")]
        InstantHorizontal = 0xA,
    }
}
