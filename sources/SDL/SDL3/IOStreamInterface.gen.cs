// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from SDL.h and corresponding dependencies of SDL3.
// Original source is Copyright (C) 1997-2024 Sam Lantinga. Licensed under the zlib license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.SDL.ChromaLocation;
using static Silk.NET.SDL.ColorPrimaries;
using static Silk.NET.SDL.ColorRange;
using static Silk.NET.SDL.ColorType;
using static Silk.NET.SDL.MatrixCoefficients;
using static Silk.NET.SDL.TransferCharacteristics;

namespace Silk.NET.SDL;

public unsafe partial struct IOStreamInterface
{
    [NativeTypeName("Sint64 (*)(void *)")]
    public PfnVvI64 Size;

    [NativeTypeName("Sint64 (*)(void *, Sint64, int)")]
    public PfnVvI64II64 Seek;

    [NativeTypeName("size_t (*)(void *, void *, size_t, SDL_IOStatus *)")]
    public PfnVvVvNuintSdlioStatusvNuint Read;

    [NativeTypeName("size_t (*)(void *, const void *, size_t, SDL_IOStatus *)")]
    public PfnVvVvNuintSdlioStatusvNuint Write;

    [NativeTypeName("int (*)(void *)")]
    public ThreadFunction Close;
}
