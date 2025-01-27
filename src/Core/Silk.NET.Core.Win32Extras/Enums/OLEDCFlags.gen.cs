// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Core.Win32Extras
{
    [Flags]
    [NativeName("Name", "tagOLEDCFLAGS")]
    public enum OLEDCFlags : int
    {
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"Nodraw\"")]
        [NativeName("Name", "OLEDC_NODRAW")]
        OledcNodraw = 0x1,
        [Obsolete("Deprecated in favour of \"Paintbkgnd\"")]
        [NativeName("Name", "OLEDC_PAINTBKGND")]
        OledcPaintbkgnd = 0x2,
        [Obsolete("Deprecated in favour of \"Offscreen\"")]
        [NativeName("Name", "OLEDC_OFFSCREEN")]
        OledcOffscreen = 0x4,
        [NativeName("Name", "OLEDC_NODRAW")]
        Nodraw = 0x1,
        [NativeName("Name", "OLEDC_PAINTBKGND")]
        Paintbkgnd = 0x2,
        [NativeName("Name", "OLEDC_OFFSCREEN")]
        Offscreen = 0x4,
    }
}
