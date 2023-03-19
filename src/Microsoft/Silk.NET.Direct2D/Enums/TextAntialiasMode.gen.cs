// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct2D
{
    [NativeName("Name", "D2D1_TEXT_ANTIALIAS_MODE")]
    public enum TextAntialiasMode : int
    {
        [Obsolete("Deprecated in favour of \"Default\"")]
        [NativeName("Name", "D2D1_TEXT_ANTIALIAS_MODE_DEFAULT")]
        TextAntialiasModeDefault = 0x0,
        [Obsolete("Deprecated in favour of \"Cleartype\"")]
        [NativeName("Name", "D2D1_TEXT_ANTIALIAS_MODE_CLEARTYPE")]
        TextAntialiasModeCleartype = 0x1,
        [Obsolete("Deprecated in favour of \"Grayscale\"")]
        [NativeName("Name", "D2D1_TEXT_ANTIALIAS_MODE_GRAYSCALE")]
        TextAntialiasModeGrayscale = 0x2,
        [Obsolete("Deprecated in favour of \"Aliased\"")]
        [NativeName("Name", "D2D1_TEXT_ANTIALIAS_MODE_ALIASED")]
        TextAntialiasModeAliased = 0x3,
        [Obsolete("Deprecated in favour of \"ForceDword\"")]
        [NativeName("Name", "D2D1_TEXT_ANTIALIAS_MODE_FORCE_DWORD")]
        TextAntialiasModeForceDword = unchecked((int) 0xFFFFFFFFFFFFFFFF),
        [NativeName("Name", "D2D1_TEXT_ANTIALIAS_MODE_DEFAULT")]
        Default = 0x0,
        [NativeName("Name", "D2D1_TEXT_ANTIALIAS_MODE_CLEARTYPE")]
        Cleartype = 0x1,
        [NativeName("Name", "D2D1_TEXT_ANTIALIAS_MODE_GRAYSCALE")]
        Grayscale = 0x2,
        [NativeName("Name", "D2D1_TEXT_ANTIALIAS_MODE_ALIASED")]
        Aliased = 0x3,
        [NativeName("Name", "D2D1_TEXT_ANTIALIAS_MODE_FORCE_DWORD")]
        ForceDword = unchecked((int) 0xFFFFFFFFFFFFFFFF),
    }
}
