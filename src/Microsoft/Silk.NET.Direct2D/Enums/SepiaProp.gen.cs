// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct2D
{
    [NativeName("Name", "D2D1_SEPIA_PROP")]
    public enum SepiaProp : int
    {
        [Obsolete("Deprecated in favour of \"Intensity\"")]
        [NativeName("Name", "D2D1_SEPIA_PROP_INTENSITY")]
        SepiaPropIntensity = 0x0,
        [Obsolete("Deprecated in favour of \"AlphaMode\"")]
        [NativeName("Name", "D2D1_SEPIA_PROP_ALPHA_MODE")]
        SepiaPropAlphaMode = 0x1,
        [Obsolete("Deprecated in favour of \"ForceDword\"")]
        [NativeName("Name", "D2D1_SEPIA_PROP_FORCE_DWORD")]
        SepiaPropForceDword = unchecked((int) 0xFFFFFFFFFFFFFFFF),
        [NativeName("Name", "D2D1_SEPIA_PROP_INTENSITY")]
        Intensity = 0x0,
        [NativeName("Name", "D2D1_SEPIA_PROP_ALPHA_MODE")]
        AlphaMode = 0x1,
        [NativeName("Name", "D2D1_SEPIA_PROP_FORCE_DWORD")]
        ForceDword = unchecked((int) 0xFFFFFFFFFFFFFFFF),
    }
}
