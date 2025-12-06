// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from SDL.h and corresponding dependencies of SDL3.
// Original source is Copyright (C) 1997-2024 Sam Lantinga. Licensed under the zlib license.
using System.Runtime.CompilerServices;

namespace Silk.NET.SDL;

[NativeName("SDL_PathInfo")]
public partial struct PathInfo
{
    [NativeName("type")]
    public PathType Type;

    [NativeName("size")]
    public nuint Size;

    [NativeName("create_time")]
    public nint CreateTime;

    [NativeName("modify_time")]
    public nint ModifyTime;

    [NativeName("access_time")]
    public nint AccessTime;
}
