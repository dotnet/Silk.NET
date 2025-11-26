// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from SDL.h and corresponding dependencies of SDL3.
// Original source is Copyright (C) 1997-2024 Sam Lantinga. Licensed under the zlib license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.SDL;

[Transformed]
public readonly unsafe struct StorageInterfaceSpaceRemaining : IDisposable
{
    private readonly void* Pointer;
    public delegate* unmanaged<void*, nuint> Handle => (delegate* unmanaged<void*, nuint>)Pointer;

    public StorageInterfaceSpaceRemaining(delegate* unmanaged<void*, nuint> ptr) => Pointer = ptr;

    public StorageInterfaceSpaceRemaining(StorageInterfaceSpaceRemainingDelegate proc) =>
        Pointer = SilkMarshal.DelegateToPtr(proc);

    public void Dispose() => SilkMarshal.Free(Pointer);

    public static implicit operator StorageInterfaceSpaceRemaining(
        delegate* unmanaged<void*, nuint> pfn
    ) => new(pfn);

    public static implicit operator delegate* unmanaged<void*, nuint>(
        StorageInterfaceSpaceRemaining pfn
    ) => (delegate* unmanaged<void*, nuint>)pfn.Pointer;
}
