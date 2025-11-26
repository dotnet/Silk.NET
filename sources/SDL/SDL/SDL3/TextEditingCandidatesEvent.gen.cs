// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from SDL.h and corresponding dependencies of SDL3.
// Original source is Copyright (C) 1997-2024 Sam Lantinga. Licensed under the zlib license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.SDL;

public unsafe partial struct TextEditingCandidatesEvent
{
    public EventType Type;

    [NativeTypeName("Uint32")]
    public uint Reserved;

    [NativeTypeName("Uint64")]
    public nuint Timestamp;

    [NativeTypeName("SDL_WindowID")]
    public uint WindowID;

    [NativeTypeName("const char *const *")]
    public sbyte** Candidates;

    [NativeTypeName("Sint32")]
    public int NumCandidates;

    [NativeTypeName("Sint32")]
    public int SelectedCandidate;

    [NativeTypeName("bool")]
    public byte Horizontal;

    [NativeTypeName("Uint8")]
    public byte Padding1;

    [NativeTypeName("Uint8")]
    public byte Padding2;

    [NativeTypeName("Uint8")]
    public byte Padding3;
}
