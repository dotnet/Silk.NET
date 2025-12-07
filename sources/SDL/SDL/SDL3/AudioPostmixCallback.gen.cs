// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from SDL.h and corresponding dependencies of SDL3.
// Original source is Copyright (C) 1997-2024 Sam Lantinga. Licensed under the zlib license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.SDL;

public readonly unsafe struct AudioPostmixCallback : IDisposable
{
    private readonly void* Pointer;
    public delegate* unmanaged<void*, AudioSpec*, float*, int, void> Handle =>
        (delegate* unmanaged<void*, AudioSpec*, float*, int, void>)Pointer;

    public AudioPostmixCallback(delegate* unmanaged<void*, AudioSpec*, float*, int, void> ptr) =>
        Pointer = ptr;

    public AudioPostmixCallback(AudioPostmixCallbackDelegate proc) =>
        Pointer = SilkMarshal.DelegateToPtr(proc);

    public void Dispose() => SilkMarshal.Free(Pointer);

    public static implicit operator AudioPostmixCallback(
        delegate* unmanaged<void*, AudioSpec*, float*, int, void> pfn
    ) => new(pfn);

    public static implicit operator delegate* unmanaged<void*, AudioSpec*, float*, int, void>(
        AudioPostmixCallback pfn
    ) => (delegate* unmanaged<void*, AudioSpec*, float*, int, void>)pfn.Pointer;
}
