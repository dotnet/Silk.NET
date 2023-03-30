// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.DirectWrite
{
    [NativeName("Name", "DWRITE_AUTOMATIC_FONT_AXES")]
    public enum AutomaticFontAxes : int
    {
        [NativeName("Name", "DWRITE_AUTOMATIC_FONT_AXES_NONE")]
        None = 0x0,
        [NativeName("Name", "DWRITE_AUTOMATIC_FONT_AXES_OPTICAL_SIZE")]
        OpticalSize = 0x1,
    }
}
