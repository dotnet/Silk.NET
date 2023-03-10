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
        [Obsolete("Deprecated in favour of \"NoSnap\"")]
        [NativeName("Name", "D2D1_DRAW_TEXT_OPTIONS_NO_SNAP")]
        DrawTextOptionsNoSnap = 0x1,
        [Obsolete("Deprecated in favour of \"Clip\"")]
        [NativeName("Name", "D2D1_DRAW_TEXT_OPTIONS_CLIP")]
        DrawTextOptionsClip = 0x2,
        [Obsolete("Deprecated in favour of \"EnableColorFont\"")]
        [NativeName("Name", "D2D1_DRAW_TEXT_OPTIONS_ENABLE_COLOR_FONT")]
        DrawTextOptionsEnableColorFont = 0x4,
        [Obsolete("Deprecated in favour of \"DisableColorBitmapSnapping\"")]
        [NativeName("Name", "D2D1_DRAW_TEXT_OPTIONS_DISABLE_COLOR_BITMAP_SNAPPING")]
        DrawTextOptionsDisableColorBitmapSnapping = 0x8,
        [Obsolete("Deprecated in favour of \"None\"")]
        [NativeName("Name", "D2D1_DRAW_TEXT_OPTIONS_NONE")]
        DrawTextOptionsNone = 0x0,
        [Obsolete("Deprecated in favour of \"ForceDword\"")]
        [NativeName("Name", "D2D1_DRAW_TEXT_OPTIONS_FORCE_DWORD")]
        DrawTextOptionsForceDword = unchecked((int) 0xFFFFFFFFFFFFFFFF),
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
