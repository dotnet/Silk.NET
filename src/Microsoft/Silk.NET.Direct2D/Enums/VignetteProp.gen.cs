// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct2D
{
    [NativeName("Name", "D2D1_VIGNETTE_PROP")]
    public enum VignetteProp : int
    {
        [Obsolete("Deprecated in favour of \"Color\"")]
        [NativeName("Name", "D2D1_VIGNETTE_PROP_COLOR")]
        VignettePropColor = 0x0,
        [Obsolete("Deprecated in favour of \"TransitionSize\"")]
        [NativeName("Name", "D2D1_VIGNETTE_PROP_TRANSITION_SIZE")]
        VignettePropTransitionSize = 0x1,
        [Obsolete("Deprecated in favour of \"Strength\"")]
        [NativeName("Name", "D2D1_VIGNETTE_PROP_STRENGTH")]
        VignettePropStrength = 0x2,
        [Obsolete("Deprecated in favour of \"ForceDword\"")]
        [NativeName("Name", "D2D1_VIGNETTE_PROP_FORCE_DWORD")]
        VignettePropForceDword = unchecked((int) 0xFFFFFFFFFFFFFFFF),
        [NativeName("Name", "D2D1_VIGNETTE_PROP_COLOR")]
        Color = 0x0,
        [NativeName("Name", "D2D1_VIGNETTE_PROP_TRANSITION_SIZE")]
        TransitionSize = 0x1,
        [NativeName("Name", "D2D1_VIGNETTE_PROP_STRENGTH")]
        Strength = 0x2,
        [NativeName("Name", "D2D1_VIGNETTE_PROP_FORCE_DWORD")]
        ForceDword = unchecked((int) 0xFFFFFFFFFFFFFFFF),
    }
}
