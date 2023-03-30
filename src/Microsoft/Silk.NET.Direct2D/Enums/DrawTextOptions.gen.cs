// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct2D
{
    [Flags]
    [NativeName("Name", "D2D1_DRAW_TEXT_OPTIONS")]
    public enum DrawTextOptions : int
    {
        [NativeName("Name", "D2D1_DRAW_TEXT_OPTIONS_NO_SNAP")]
        NoSnap = 0x1,
        [NativeName("Name", "D2D1_DRAW_TEXT_OPTIONS_CLIP")]
        Clip = 0x2,
        [NativeName("Name", "D2D1_DRAW_TEXT_OPTIONS_ENABLE_COLOR_FONT")]
        EnableColorFont = 0x4,
        [NativeName("Name", "D2D1_DRAW_TEXT_OPTIONS_DISABLE_COLOR_BITMAP_SNAPPING")]
        DisableColorBitmapSnapping = 0x8,
        [NativeName("Name", "D2D1_DRAW_TEXT_OPTIONS_NONE")]
        None = 0x0,
        [NativeName("Name", "D2D1_DRAW_TEXT_OPTIONS_FORCE_DWORD")]
        ForceDword = unchecked((int) 0xFFFFFFFFFFFFFFFF),
    }
}
