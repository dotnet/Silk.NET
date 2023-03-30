// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.DirectWrite
{
    [NativeName("Name", "DWRITE_FONT_FAMILY_MODEL")]
    public enum FontFamilyModel : int
    {
        [NativeName("Name", "DWRITE_FONT_FAMILY_MODEL_TYPOGRAPHIC")]
        Typographic = 0x0,
        [NativeName("Name", "DWRITE_FONT_FAMILY_MODEL_WEIGHT_STRETCH_STYLE")]
        WeightStretchStyle = 0x1,
    }
}
