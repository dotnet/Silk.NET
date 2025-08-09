// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.MediaFoundation
{
    [NativeName("Name", "MF_TIMED_TEXT_FONT_STYLE")]
    public enum TimedTextFontStyle : int
    {
        [NativeName("Name", "MF_TIMED_TEXT_FONT_STYLE_NORMAL")]
        Normal = 0x0,
        [NativeName("Name", "MF_TIMED_TEXT_FONT_STYLE_OBLIQUE")]
        Oblique = 0x1,
        [NativeName("Name", "MF_TIMED_TEXT_FONT_STYLE_ITALIC")]
        Italic = 0x2,
    }
}
