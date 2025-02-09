// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from SDL.h and corresponding dependencies of SDL3.
// Original source is Copyright (C) 1997-2024 Sam Lantinga. Licensed under the zlib license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.SDL;

public readonly unsafe struct ReallocFunc : IDisposable
{
    private readonly void* Pointer;
    public delegate* unmanaged<void*, nuint, void*> Handle =>
        (delegate* unmanaged<void*, nuint, void*>)Pointer;

    public ReallocFunc(delegate* unmanaged<void*, nuint, void*> ptr) => Pointer = ptr;

    public ReallocFunc(ReallocFuncDelegate proc) => Pointer = SilkMarshal.DelegateToPtr(proc);

    public void Dispose() => SilkMarshal.Free(Pointer);

    public static implicit operator ReallocFunc(delegate* unmanaged<void*, nuint, void*> pfn) =>
        new(pfn);

    public static implicit operator delegate* unmanaged<void*, nuint, void*>(ReallocFunc pfn) =>
        (delegate* unmanaged<void*, nuint, void*>)pfn.Pointer;
}
