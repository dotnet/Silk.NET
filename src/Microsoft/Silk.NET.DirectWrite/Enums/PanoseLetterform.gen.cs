// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.DirectWrite
{
    [NativeName("Name", "DWRITE_PANOSE_LETTERFORM")]
    public enum PanoseLetterform : int
    {
        [NativeName("Name", "DWRITE_PANOSE_LETTERFORM_ANY")]
        Any = 0x0,
        [NativeName("Name", "DWRITE_PANOSE_LETTERFORM_NO_FIT")]
        NoFit = 0x1,
        [NativeName("Name", "DWRITE_PANOSE_LETTERFORM_NORMAL_CONTACT")]
        NormalContact = 0x2,
        [NativeName("Name", "DWRITE_PANOSE_LETTERFORM_NORMAL_WEIGHTED")]
        NormalWeighted = 0x3,
        [NativeName("Name", "DWRITE_PANOSE_LETTERFORM_NORMAL_BOXED")]
        NormalBoxed = 0x4,
        [NativeName("Name", "DWRITE_PANOSE_LETTERFORM_NORMAL_FLATTENED")]
        NormalFlattened = 0x5,
        [NativeName("Name", "DWRITE_PANOSE_LETTERFORM_NORMAL_ROUNDED")]
        NormalRounded = 0x6,
        [NativeName("Name", "DWRITE_PANOSE_LETTERFORM_NORMAL_OFF_CENTER")]
        NormalOffCenter = 0x7,
        [NativeName("Name", "DWRITE_PANOSE_LETTERFORM_NORMAL_SQUARE")]
        NormalSquare = 0x8,
        [NativeName("Name", "DWRITE_PANOSE_LETTERFORM_OBLIQUE_CONTACT")]
        ObliqueContact = 0x9,
        [NativeName("Name", "DWRITE_PANOSE_LETTERFORM_OBLIQUE_WEIGHTED")]
        ObliqueWeighted = 0xA,
        [NativeName("Name", "DWRITE_PANOSE_LETTERFORM_OBLIQUE_BOXED")]
        ObliqueBoxed = 0xB,
        [NativeName("Name", "DWRITE_PANOSE_LETTERFORM_OBLIQUE_FLATTENED")]
        ObliqueFlattened = 0xC,
        [NativeName("Name", "DWRITE_PANOSE_LETTERFORM_OBLIQUE_ROUNDED")]
        ObliqueRounded = 0xD,
        [NativeName("Name", "DWRITE_PANOSE_LETTERFORM_OBLIQUE_OFF_CENTER")]
        ObliqueOffCenter = 0xE,
        [NativeName("Name", "DWRITE_PANOSE_LETTERFORM_OBLIQUE_SQUARE")]
        ObliqueSquare = 0xF,
    }
}
