// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.DirectWrite
{
    [NativeName("Name", "DWRITE_PANOSE_DECORATIVE_TOPOLOGY")]
    public enum PanoseDecorativeTopology : int
    {
        [NativeName("Name", "DWRITE_PANOSE_DECORATIVE_TOPOLOGY_ANY")]
        Any = 0x0,
        [NativeName("Name", "DWRITE_PANOSE_DECORATIVE_TOPOLOGY_NO_FIT")]
        NoFit = 0x1,
        [NativeName("Name", "DWRITE_PANOSE_DECORATIVE_TOPOLOGY_STANDARD")]
        Standard = 0x2,
        [NativeName("Name", "DWRITE_PANOSE_DECORATIVE_TOPOLOGY_SQUARE")]
        Square = 0x3,
        [NativeName("Name", "DWRITE_PANOSE_DECORATIVE_TOPOLOGY_MULTIPLE_SEGMENT")]
        MultipleSegment = 0x4,
        [NativeName("Name", "DWRITE_PANOSE_DECORATIVE_TOPOLOGY_ART_DECO")]
        ArtDeco = 0x5,
        [NativeName("Name", "DWRITE_PANOSE_DECORATIVE_TOPOLOGY_UNEVEN_WEIGHTING")]
        UnevenWeighting = 0x6,
        [NativeName("Name", "DWRITE_PANOSE_DECORATIVE_TOPOLOGY_DIVERSE_ARMS")]
        DiverseArms = 0x7,
        [NativeName("Name", "DWRITE_PANOSE_DECORATIVE_TOPOLOGY_DIVERSE_FORMS")]
        DiverseForms = 0x8,
        [NativeName("Name", "DWRITE_PANOSE_DECORATIVE_TOPOLOGY_LOMBARDIC_FORMS")]
        LombardicForms = 0x9,
        [NativeName("Name", "DWRITE_PANOSE_DECORATIVE_TOPOLOGY_UPPER_CASE_IN_LOWER_CASE")]
        UpperCaseInLowerCase = 0xA,
        [NativeName("Name", "DWRITE_PANOSE_DECORATIVE_TOPOLOGY_IMPLIED_TOPOLOGY")]
        ImpliedTopology = 0xB,
        [NativeName("Name", "DWRITE_PANOSE_DECORATIVE_TOPOLOGY_HORSESHOE_E_AND_A")]
        HorseshoeEAndA = 0xC,
        [NativeName("Name", "DWRITE_PANOSE_DECORATIVE_TOPOLOGY_CURSIVE")]
        Cursive = 0xD,
        [NativeName("Name", "DWRITE_PANOSE_DECORATIVE_TOPOLOGY_BLACKLETTER")]
        Blackletter = 0xE,
        [NativeName("Name", "DWRITE_PANOSE_DECORATIVE_TOPOLOGY_SWASH_VARIANCE")]
        SwashVariance = 0xF,
    }
}
