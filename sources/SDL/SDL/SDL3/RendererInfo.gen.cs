// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from SDL.h and corresponding dependencies of SDL3.
// Original source is Copyright (C) 1997-2024 Sam Lantinga. Licensed under the zlib license.
using System.Runtime.CompilerServices;

namespace Silk.NET.SDL;

public unsafe partial struct RendererInfo
{
    [NativeTypeName("const char *")]
    public sbyte* Name;

    [NativeTypeName("Uint32")]
    public uint Flags;
    public int NumTextureFormats;

    [NativeTypeName("SDL_PixelFormatEnum[16]")]
    public RendererInfoTextureFormats TextureFormats;
    public int MaxTextureWidth;
    public int MaxTextureHeight;
}
