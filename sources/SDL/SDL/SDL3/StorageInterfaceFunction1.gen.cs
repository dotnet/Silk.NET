// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from SDL.h and corresponding dependencies of SDL3.
// Original source is Copyright (C) 1997-2024 Sam Lantinga. Licensed under the zlib license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.SDL;

[Transformed]
public readonly unsafe struct StorageInterfaceFunction1 : IDisposable
{
    private readonly void* Pointer;
    public delegate* unmanaged<void*, sbyte*, void*, ulong, int> Handle =>
        (delegate* unmanaged<void*, sbyte*, void*, ulong, int>)Pointer;

    public StorageInterfaceFunction1(delegate* unmanaged<void*, sbyte*, void*, ulong, int> ptr) =>
        Pointer = ptr;

    public StorageInterfaceFunction1(StorageInterfaceFunction1Delegate proc) =>
        Pointer = SilkMarshal.DelegateToPtr(proc);

    public void Dispose() => SilkMarshal.Free(Pointer);

    public static implicit operator StorageInterfaceFunction1(
        delegate* unmanaged<void*, sbyte*, void*, ulong, int> pfn
    ) => new(pfn);

    public static implicit operator delegate* unmanaged<void*, sbyte*, void*, ulong, int>(
        StorageInterfaceFunction1 pfn
    ) => (delegate* unmanaged<void*, sbyte*, void*, ulong, int>)pfn.Pointer;
}
