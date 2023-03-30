// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.DirectWrite
{
    [NativeName("Name", "DWRITE_FONT_SIMULATIONS")]
    public enum FontSimulations : int
    {
        [NativeName("Name", "DWRITE_FONT_SIMULATIONS_NONE")]
        None = 0x0,
        [NativeName("Name", "DWRITE_FONT_SIMULATIONS_BOLD")]
        Bold = 0x1,
        [NativeName("Name", "DWRITE_FONT_SIMULATIONS_OBLIQUE")]
        Oblique = 0x2,
    }
}
