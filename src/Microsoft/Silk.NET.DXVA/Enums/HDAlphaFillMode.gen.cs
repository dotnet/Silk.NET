// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.DXVA
{
    [NativeName("Name", "_DXVAHD_ALPHA_FILL_MODE")]
    public enum HDAlphaFillMode : int
    {
        [Obsolete("Deprecated in favour of \"Opaque\"")]
        [NativeName("Name", "DXVAHD_ALPHA_FILL_MODE_OPAQUE")]
        HDAlphaFillModeOpaque = 0x0,
        [Obsolete("Deprecated in favour of \"Background\"")]
        [NativeName("Name", "DXVAHD_ALPHA_FILL_MODE_BACKGROUND")]
        HDAlphaFillModeBackground = 0x1,
        [Obsolete("Deprecated in favour of \"Destination\"")]
        [NativeName("Name", "DXVAHD_ALPHA_FILL_MODE_DESTINATION")]
        HDAlphaFillModeDestination = 0x2,
        [Obsolete("Deprecated in favour of \"SourceStream\"")]
        [NativeName("Name", "DXVAHD_ALPHA_FILL_MODE_SOURCE_STREAM")]
        HDAlphaFillModeSourceStream = 0x3,
        [NativeName("Name", "DXVAHD_ALPHA_FILL_MODE_OPAQUE")]
        Opaque = 0x0,
        [NativeName("Name", "DXVAHD_ALPHA_FILL_MODE_BACKGROUND")]
        Background = 0x1,
        [NativeName("Name", "DXVAHD_ALPHA_FILL_MODE_DESTINATION")]
        Destination = 0x2,
        [NativeName("Name", "DXVAHD_ALPHA_FILL_MODE_SOURCE_STREAM")]
        SourceStream = 0x3,
    }
}
