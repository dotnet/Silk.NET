// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.DirectWrite
{
    [NativeName("Name", "DWRITE_GLYPH_ORIENTATION_ANGLE")]
    public enum GlyphOrientationAngle : int
    {
        [NativeName("Name", "DWRITE_GLYPH_ORIENTATION_ANGLE_0_DEGREES")]
        Angle0Degrees = 0x0,
        [NativeName("Name", "DWRITE_GLYPH_ORIENTATION_ANGLE_90_DEGREES")]
        Angle90Degrees = 0x1,
        [NativeName("Name", "DWRITE_GLYPH_ORIENTATION_ANGLE_180_DEGREES")]
        Angle180Degrees = 0x2,
        [NativeName("Name", "DWRITE_GLYPH_ORIENTATION_ANGLE_270_DEGREES")]
        Angle270Degrees = 0x3,
    }
}
