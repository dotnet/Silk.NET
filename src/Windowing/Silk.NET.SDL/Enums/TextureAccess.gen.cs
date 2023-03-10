// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.SDL
{
    [NativeName("AnonymousName", "__AnonymousEnum_SDL_render_L111_C9")]
    [NativeName("Name", "SDL_TextureAccess")]
    public enum TextureAccess : int
    {
        [Obsolete("Deprecated in favour of \"Static\"")]
        [NativeName("Name", "SDL_TEXTUREACCESS_STATIC")]
        TextureaccessStatic = 0x0,
        [Obsolete("Deprecated in favour of \"Streaming\"")]
        [NativeName("Name", "SDL_TEXTUREACCESS_STREAMING")]
        TextureaccessStreaming = 0x1,
        [Obsolete("Deprecated in favour of \"Target\"")]
        [NativeName("Name", "SDL_TEXTUREACCESS_TARGET")]
        TextureaccessTarget = 0x2,
        [NativeName("Name", "SDL_TEXTUREACCESS_STATIC")]
        Static = 0x0,
        [NativeName("Name", "SDL_TEXTUREACCESS_STREAMING")]
        Streaming = 0x1,
        [NativeName("Name", "SDL_TEXTUREACCESS_TARGET")]
        Target = 0x2,
    }
}
