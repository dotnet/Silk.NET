// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from SDL.h and corresponding dependencies of SDL3.
// Original source is Copyright (C) 1997-2024 Sam Lantinga. Licensed under the zlib license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.SDL;

[NativeName("SDL_TextEditingCandidatesEvent")]
public unsafe partial struct TextEditingCandidatesEvent
{
    [NativeName("type")]
    public EventType Type;

    [NativeName("reserved")]
    public uint Reserved;

    [NativeName("timestamp")]
    public ulong Timestamp;

    [NativeName("windowID")]
    public uint WindowId;

    [NativeName("candidates")]
    public sbyte** Candidates;

    [NativeName("num_candidates")]
    public int NumCandidates;

    [NativeName("selected_candidate")]
    public int SelectedCandidate;

    [NativeName("horizontal")]
    public byte Horizontal;

    [NativeName("padding1")]
    public byte Padding1;

    [NativeName("padding2")]
    public byte Padding2;

    [NativeName("padding3")]
    public byte Padding3;
}
