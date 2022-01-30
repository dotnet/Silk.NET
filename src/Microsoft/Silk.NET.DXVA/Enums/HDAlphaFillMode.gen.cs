// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.DXVA
{
    [Flags]
    [NativeName("Name", "_DXVAHD_ALPHA_FILL_MODE")]
    public enum HDAlphaFillMode : int
    {
        [NativeName("Name", "DXVAHD_ALPHA_FILL_MODE_OPAQUE")]
        HDAlphaFillModeOpaque = 0x0,
        [NativeName("Name", "DXVAHD_ALPHA_FILL_MODE_BACKGROUND")]
        HDAlphaFillModeBackground = 0x1,
        [NativeName("Name", "DXVAHD_ALPHA_FILL_MODE_DESTINATION")]
        HDAlphaFillModeDestination = 0x2,
        [NativeName("Name", "DXVAHD_ALPHA_FILL_MODE_SOURCE_STREAM")]
        HDAlphaFillModeSourceStream = 0x3,
    }
}
