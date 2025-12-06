// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from SDL.h and corresponding dependencies of SDL3.
// Original source is Copyright (C) 1997-2024 Sam Lantinga. Licensed under the zlib license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.SDL;

public readonly unsafe struct MallocFunc : IDisposable
{
    private readonly void* Pointer;
    public delegate* unmanaged<nuint, void*> Handle => (delegate* unmanaged<nuint, void*>)Pointer;

    public MallocFunc(delegate* unmanaged<nuint, void*> ptr) => Pointer = ptr;

    public MallocFunc(MallocFuncDelegate proc) => Pointer = SilkMarshal.DelegateToPtr(proc);

    public void Dispose() => SilkMarshal.Free(Pointer);

    public static implicit operator MallocFunc(delegate* unmanaged<nuint, void*> pfn) => new(pfn);

    public static implicit operator delegate* unmanaged<nuint, void*>(MallocFunc pfn) =>
        (delegate* unmanaged<nuint, void*>)pfn.Pointer;
}
