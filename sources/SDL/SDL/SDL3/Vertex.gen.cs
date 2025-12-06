// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from SDL.h and corresponding dependencies of SDL3.
// Original source is Copyright (C) 1997-2024 Sam Lantinga. Licensed under the zlib license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.SDL;

[NativeName("SDL_Vertex")]
public partial struct Vertex
{
    [NativeName("position")]
    public FPoint Position;

    [NativeName("color")]
    public FColor Color;

    [NativeName("tex_coord")]
    public FPoint TexCoord;
}
