// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from SDL.h and corresponding dependencies of SDL3.
// Original source is Copyright (C) 1997-2024 Sam Lantinga. Licensed under the zlib license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.SDL;

[NativeName("SDL_WindowsMessageHook")]
public readonly unsafe struct WindowsMessageHook : IDisposable
{
    private readonly void* Pointer;
    public delegate* unmanaged<void*, tagMSG*, byte> Handle =>
        (delegate* unmanaged<void*, tagMSG*, byte>)Pointer;

    public WindowsMessageHook(delegate* unmanaged<void*, tagMSG*, byte> ptr) => Pointer = ptr;

    public WindowsMessageHook(WindowsMessageHookDelegate proc) =>
        Pointer = SilkMarshal.DelegateToPtr(proc);

    public void Dispose() => SilkMarshal.Free(Pointer);

    public static implicit operator WindowsMessageHook(
        delegate* unmanaged<void*, tagMSG*, byte> pfn
    ) => new(pfn);

    public static implicit operator delegate* unmanaged<void*, tagMSG*, byte>(
        WindowsMessageHook pfn
    ) => (delegate* unmanaged<void*, tagMSG*, byte>)pfn.Pointer;
}
