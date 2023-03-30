// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.DirectWrite
{
    [NativeName("Name", "DWRITE_PANOSE_DECORATIVE_CLASS")]
    public enum PanoseDecorativeClass : int
    {
        [NativeName("Name", "DWRITE_PANOSE_DECORATIVE_CLASS_ANY")]
        Any = 0x0,
        [NativeName("Name", "DWRITE_PANOSE_DECORATIVE_CLASS_NO_FIT")]
        NoFit = 0x1,
        [NativeName("Name", "DWRITE_PANOSE_DECORATIVE_CLASS_DERIVATIVE")]
        Derivative = 0x2,
        [NativeName("Name", "DWRITE_PANOSE_DECORATIVE_CLASS_NONSTANDARD_TOPOLOGY")]
        NonstandardTopology = 0x3,
        [NativeName("Name", "DWRITE_PANOSE_DECORATIVE_CLASS_NONSTANDARD_ELEMENTS")]
        NonstandardElements = 0x4,
        [NativeName("Name", "DWRITE_PANOSE_DECORATIVE_CLASS_NONSTANDARD_ASPECT")]
        NonstandardAspect = 0x5,
        [NativeName("Name", "DWRITE_PANOSE_DECORATIVE_CLASS_INITIALS")]
        Initials = 0x6,
        [NativeName("Name", "DWRITE_PANOSE_DECORATIVE_CLASS_CARTOON")]
        Cartoon = 0x7,
        [NativeName("Name", "DWRITE_PANOSE_DECORATIVE_CLASS_PICTURE_STEMS")]
        PictureStems = 0x8,
        [NativeName("Name", "DWRITE_PANOSE_DECORATIVE_CLASS_ORNAMENTED")]
        Ornamented = 0x9,
        [NativeName("Name", "DWRITE_PANOSE_DECORATIVE_CLASS_TEXT_AND_BACKGROUND")]
        TextAndBackground = 0xA,
        [NativeName("Name", "DWRITE_PANOSE_DECORATIVE_CLASS_COLLAGE")]
        Collage = 0xB,
        [NativeName("Name", "DWRITE_PANOSE_DECORATIVE_CLASS_MONTAGE")]
        Montage = 0xC,
    }
}
