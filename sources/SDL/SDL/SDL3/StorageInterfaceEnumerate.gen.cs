// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from SDL.h and corresponding dependencies of SDL3.
// Original source is Copyright (C) 1997-2024 Sam Lantinga. Licensed under the zlib license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.SDL;

public readonly unsafe struct StorageInterfaceEnumerate : IDisposable
{
    private readonly void* Pointer;
    public delegate* unmanaged<void*, sbyte*, EnumerateDirectoryCallback, void*, int> Handle =>
        (delegate* unmanaged<void*, sbyte*, EnumerateDirectoryCallback, void*, int>)Pointer;

    public StorageInterfaceEnumerate(
        delegate* unmanaged<void*, sbyte*, EnumerateDirectoryCallback, void*, int> ptr
    ) => Pointer = ptr;

    public StorageInterfaceEnumerate(StorageInterfaceEnumerateDelegate proc) =>
        Pointer = SilkMarshal.DelegateToPtr(proc);

    public void Dispose() => SilkMarshal.Free(Pointer);

    public static implicit operator StorageInterfaceEnumerate(
        delegate* unmanaged<void*, sbyte*, EnumerateDirectoryCallback, void*, int> pfn
    ) => new(pfn);

    public static implicit operator delegate* unmanaged<
        void*,
        sbyte*,
        EnumerateDirectoryCallback,
        void*,
        int>(StorageInterfaceEnumerate pfn) =>
        (delegate* unmanaged<void*, sbyte*, EnumerateDirectoryCallback, void*, int>)pfn.Pointer;
}