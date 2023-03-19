// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct2D
{
    [NativeName("Name", "D2D1_MAP_OPTIONS")]
    public enum MapOptions : int
    {
        [Obsolete("Deprecated in favour of \"None\"")]
        [NativeName("Name", "D2D1_MAP_OPTIONS_NONE")]
        MapOptionsNone = 0x0,
        [Obsolete("Deprecated in favour of \"Read\"")]
        [NativeName("Name", "D2D1_MAP_OPTIONS_READ")]
        MapOptionsRead = 0x1,
        [Obsolete("Deprecated in favour of \"Write\"")]
        [NativeName("Name", "D2D1_MAP_OPTIONS_WRITE")]
        MapOptionsWrite = 0x2,
        [Obsolete("Deprecated in favour of \"Discard\"")]
        [NativeName("Name", "D2D1_MAP_OPTIONS_DISCARD")]
        MapOptionsDiscard = 0x4,
        [Obsolete("Deprecated in favour of \"ForceDword\"")]
        [NativeName("Name", "D2D1_MAP_OPTIONS_FORCE_DWORD")]
        MapOptionsForceDword = unchecked((int) 0xFFFFFFFFFFFFFFFF),
        [NativeName("Name", "D2D1_MAP_OPTIONS_NONE")]
        None = 0x0,
        [NativeName("Name", "D2D1_MAP_OPTIONS_READ")]
        Read = 0x1,
        [NativeName("Name", "D2D1_MAP_OPTIONS_WRITE")]
        Write = 0x2,
        [NativeName("Name", "D2D1_MAP_OPTIONS_DISCARD")]
        Discard = 0x4,
        [NativeName("Name", "D2D1_MAP_OPTIONS_FORCE_DWORD")]
        ForceDword = unchecked((int) 0xFFFFFFFFFFFFFFFF),
    }
}
