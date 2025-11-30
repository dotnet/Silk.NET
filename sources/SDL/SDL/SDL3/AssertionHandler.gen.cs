// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from SDL.h and corresponding dependencies of SDL3.
// Original source is Copyright (C) 1997-2024 Sam Lantinga. Licensed under the zlib license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.SDL;

[NativeName("SDL_AssertionHandler")]
public readonly unsafe struct AssertionHandler : IDisposable
{
    private readonly void* Pointer;
    public delegate* unmanaged<AssertData*, void*, AssertState> Handle =>
        (delegate* unmanaged<AssertData*, void*, AssertState>)Pointer;

    public AssertionHandler(delegate* unmanaged<AssertData*, void*, AssertState> ptr) =>
        Pointer = ptr;

    public AssertionHandler(AssertionHandlerDelegate proc) =>
        Pointer = SilkMarshal.DelegateToPtr(proc);

    public void Dispose() => SilkMarshal.Free(Pointer);

    public static implicit operator AssertionHandler(
        delegate* unmanaged<AssertData*, void*, AssertState> pfn
    ) => new(pfn);

    public static implicit operator delegate* unmanaged<AssertData*, void*, AssertState>(
        AssertionHandler pfn
    ) => (delegate* unmanaged<AssertData*, void*, AssertState>)pfn.Pointer;
}
