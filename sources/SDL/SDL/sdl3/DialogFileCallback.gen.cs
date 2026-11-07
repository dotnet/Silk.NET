// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from SDL.h and corresponding dependencies of SDL3.
// Original source is Copyright (C) 1997-2024 Sam Lantinga. Licensed under the zlib license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.SDL;

[NativeName("SDL_DialogFileCallback")]
public readonly unsafe struct DialogFileCallback : IDisposable
{
    private readonly void* Pointer;
    public delegate* unmanaged<void*, sbyte**, int, void> Handle =>
        (delegate* unmanaged<void*, sbyte**, int, void>)Pointer;

    public DialogFileCallback(delegate* unmanaged<void*, sbyte**, int, void> ptr) => Pointer = ptr;

    public DialogFileCallback(DialogFileCallbackDelegate proc) =>
        Pointer = SilkMarshal.DelegateToPtr(proc);

    public void Dispose() => SilkMarshal.Free(Pointer);

    public static implicit operator DialogFileCallback(
        delegate* unmanaged<void*, sbyte**, int, void> pfn
    ) => new(pfn);

    public static implicit operator delegate* unmanaged<void*, sbyte**, int, void>(
        DialogFileCallback pfn
    ) => (delegate* unmanaged<void*, sbyte**, int, void>)pfn.Pointer;
}
