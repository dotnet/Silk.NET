// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct2D
{
    [Flags]
    [NativeName("Name", "D2D1_SPRITE_OPTIONS")]
    public enum SpriteOptions : int
    {
        [Obsolete("Deprecated in favour of \"None\"")]
        [NativeName("Name", "D2D1_SPRITE_OPTIONS_NONE")]
        SpriteOptionsNone = 0x0,
        [Obsolete("Deprecated in favour of \"ClampToSourceRectangle\"")]
        [NativeName("Name", "D2D1_SPRITE_OPTIONS_CLAMP_TO_SOURCE_RECTANGLE")]
        SpriteOptionsClampToSourceRectangle = 0x1,
        [Obsolete("Deprecated in favour of \"ForceDword\"")]
        [NativeName("Name", "D2D1_SPRITE_OPTIONS_FORCE_DWORD")]
        SpriteOptionsForceDword = unchecked((int) 0xFFFFFFFFFFFFFFFF),
        [NativeName("Name", "D2D1_SPRITE_OPTIONS_NONE")]
        None = 0x0,
        [NativeName("Name", "D2D1_SPRITE_OPTIONS_CLAMP_TO_SOURCE_RECTANGLE")]
        ClampToSourceRectangle = 0x1,
        [NativeName("Name", "D2D1_SPRITE_OPTIONS_FORCE_DWORD")]
        ForceDword = unchecked((int) 0xFFFFFFFFFFFFFFFF),
    }
}
