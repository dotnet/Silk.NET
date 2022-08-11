// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct2D
{
    [Flags]
    [NativeName("Name", "D2D1_HDRTONEMAP_DISPLAY_MODE")]
    public enum HdrtonemapDisplayMode : int
    {
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"Sdr\"")]
        [NativeName("Name", "D2D1_HDRTONEMAP_DISPLAY_MODE_SDR")]
        HdrtonemapDisplayModeSdr = 0x0,
        [Obsolete("Deprecated in favour of \"Hdr\"")]
        [NativeName("Name", "D2D1_HDRTONEMAP_DISPLAY_MODE_HDR")]
        HdrtonemapDisplayModeHdr = 0x1,
        [Obsolete("Deprecated in favour of \"ForceDword\"")]
        [NativeName("Name", "D2D1_HDRTONEMAP_DISPLAY_MODE_FORCE_DWORD")]
        HdrtonemapDisplayModeForceDword = unchecked((int) 0xFFFFFFFFFFFFFFFF),
        [NativeName("Name", "D2D1_HDRTONEMAP_DISPLAY_MODE_SDR")]
        Sdr = 0x0,
        [NativeName("Name", "D2D1_HDRTONEMAP_DISPLAY_MODE_HDR")]
        Hdr = 0x1,
        [NativeName("Name", "D2D1_HDRTONEMAP_DISPLAY_MODE_FORCE_DWORD")]
        ForceDword = unchecked((int) 0xFFFFFFFFFFFFFFFF),
    }
}
