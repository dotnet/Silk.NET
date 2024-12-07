// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from SDL.h and corresponding dependencies of SDL3.
// Original source is Copyright (C) 1997-2024 Sam Lantinga. Licensed under the zlib license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.SDL;

public unsafe partial struct AssertData
{
    [NativeTypeName("bool")]
    public byte AlwaysIgnore;

    [NativeTypeName("unsigned int")]
    public uint TriggerCount;

    [NativeTypeName("const char *")]
    public sbyte* Condition;

    [NativeTypeName("const char *")]
    public sbyte* Filename;
    public int Linenum;

    [NativeTypeName("const char *")]
    public sbyte* Function;

    [NativeTypeName("const struct SDL_AssertData *")]
    public AssertData* Next;
}
