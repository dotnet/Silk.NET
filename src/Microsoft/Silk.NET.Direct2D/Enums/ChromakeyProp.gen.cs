// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct2D
{
    [NativeName("Name", "D2D1_CHROMAKEY_PROP")]
    public enum ChromakeyProp : int
    {
        [Obsolete("Deprecated in favour of \"Color\"")]
        [NativeName("Name", "D2D1_CHROMAKEY_PROP_COLOR")]
        ChromakeyPropColor = 0x0,
        [Obsolete("Deprecated in favour of \"Tolerance\"")]
        [NativeName("Name", "D2D1_CHROMAKEY_PROP_TOLERANCE")]
        ChromakeyPropTolerance = 0x1,
        [Obsolete("Deprecated in favour of \"InvertAlpha\"")]
        [NativeName("Name", "D2D1_CHROMAKEY_PROP_INVERT_ALPHA")]
        ChromakeyPropInvertAlpha = 0x2,
        [Obsolete("Deprecated in favour of \"Feather\"")]
        [NativeName("Name", "D2D1_CHROMAKEY_PROP_FEATHER")]
        ChromakeyPropFeather = 0x3,
        [Obsolete("Deprecated in favour of \"ForceDword\"")]
        [NativeName("Name", "D2D1_CHROMAKEY_PROP_FORCE_DWORD")]
        ChromakeyPropForceDword = unchecked((int) 0xFFFFFFFFFFFFFFFF),
        [NativeName("Name", "D2D1_CHROMAKEY_PROP_COLOR")]
        Color = 0x0,
        [NativeName("Name", "D2D1_CHROMAKEY_PROP_TOLERANCE")]
        Tolerance = 0x1,
        [NativeName("Name", "D2D1_CHROMAKEY_PROP_INVERT_ALPHA")]
        InvertAlpha = 0x2,
        [NativeName("Name", "D2D1_CHROMAKEY_PROP_FEATHER")]
        Feather = 0x3,
        [NativeName("Name", "D2D1_CHROMAKEY_PROP_FORCE_DWORD")]
        ForceDword = unchecked((int) 0xFFFFFFFFFFFFFFFF),
    }
}
