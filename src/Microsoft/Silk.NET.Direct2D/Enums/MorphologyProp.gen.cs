// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct2D
{
    [NativeName("Name", "D2D1_MORPHOLOGY_PROP")]
    public enum MorphologyProp : int
    {
        [Obsolete("Deprecated in favour of \"Mode\"")]
        [NativeName("Name", "D2D1_MORPHOLOGY_PROP_MODE")]
        MorphologyPropMode = 0x0,
        [Obsolete("Deprecated in favour of \"Width\"")]
        [NativeName("Name", "D2D1_MORPHOLOGY_PROP_WIDTH")]
        MorphologyPropWidth = 0x1,
        [Obsolete("Deprecated in favour of \"Height\"")]
        [NativeName("Name", "D2D1_MORPHOLOGY_PROP_HEIGHT")]
        MorphologyPropHeight = 0x2,
        [Obsolete("Deprecated in favour of \"ForceDword\"")]
        [NativeName("Name", "D2D1_MORPHOLOGY_PROP_FORCE_DWORD")]
        MorphologyPropForceDword = unchecked((int) 0xFFFFFFFFFFFFFFFF),
        [NativeName("Name", "D2D1_MORPHOLOGY_PROP_MODE")]
        Mode = 0x0,
        [NativeName("Name", "D2D1_MORPHOLOGY_PROP_WIDTH")]
        Width = 0x1,
        [NativeName("Name", "D2D1_MORPHOLOGY_PROP_HEIGHT")]
        Height = 0x2,
        [NativeName("Name", "D2D1_MORPHOLOGY_PROP_FORCE_DWORD")]
        ForceDword = unchecked((int) 0xFFFFFFFFFFFFFFFF),
    }
}
