// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.DirectWrite
{
    [NativeName("Name", "DWRITE_VERTICAL_GLYPH_ORIENTATION")]
    public enum VerticalGlyphOrientation : int
    {
        [NativeName("Name", "DWRITE_VERTICAL_GLYPH_ORIENTATION_DEFAULT")]
        Default = 0x0,
        [NativeName("Name", "DWRITE_VERTICAL_GLYPH_ORIENTATION_STACKED")]
        Stacked = 0x1,
    }
}
