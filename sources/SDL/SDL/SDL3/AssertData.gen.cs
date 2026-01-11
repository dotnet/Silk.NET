// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from SDL.h and corresponding dependencies of SDL3.
// Original source is Copyright (C) 1997-2024 Sam Lantinga. Licensed under the zlib license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.SDL;

[NativeName("SDL_AssertData")]
public unsafe partial struct AssertData
{
    [NativeName("always_ignore")]
    public byte AlwaysIgnore;

    [NativeName("trigger_count")]
    public uint TriggerCount;

    [NativeName("condition")]
    public sbyte* Condition;

    [NativeName("filename")]
    public sbyte* Filename;

    [NativeName("linenum")]
    public int Linenum;

    [NativeName("function")]
    public sbyte* Function;

    [NativeName("next")]
    public AssertData* Next;
}
