// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.DirectWrite
{
    [NativeName("Name", "DWRITE_PAINT_ATTRIBUTES")]
    public enum PaintAttributes : int
    {
        [NativeName("Name", "DWRITE_PAINT_ATTRIBUTES_NONE")]
        None = 0x0,
        [NativeName("Name", "DWRITE_PAINT_ATTRIBUTES_USES_PALETTE")]
        UsesPalette = 0x1,
        [NativeName("Name", "DWRITE_PAINT_ATTRIBUTES_USES_TEXT_COLOR")]
        UsesTextColor = 0x2,
    }
}
