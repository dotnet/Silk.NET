// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from SDL.h and corresponding dependencies of SDL3.
// Original source is Copyright (C) 1997-2024 Sam Lantinga. Licensed under the zlib license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.SDL;

public readonly unsafe struct EnumerateDirectoryCallback : IDisposable
{
    private readonly void* Pointer;
    public delegate* unmanaged<void*, sbyte*, sbyte*, EnumerationResult> Handle =>
        (delegate* unmanaged<void*, sbyte*, sbyte*, EnumerationResult>)Pointer;

    public EnumerateDirectoryCallback(
        delegate* unmanaged<void*, sbyte*, sbyte*, EnumerationResult> ptr
    ) => Pointer = ptr;

    public EnumerateDirectoryCallback(EnumerateDirectoryCallbackDelegate proc) =>
        Pointer = SilkMarshal.DelegateToPtr(proc);

    public void Dispose() => SilkMarshal.Free(Pointer);

    public static implicit operator EnumerateDirectoryCallback(
        delegate* unmanaged<void*, sbyte*, sbyte*, EnumerationResult> pfn
    ) => new(pfn);

    public static implicit operator delegate* unmanaged<void*, sbyte*, sbyte*, EnumerationResult>(
        EnumerateDirectoryCallback pfn
    ) => (delegate* unmanaged<void*, sbyte*, sbyte*, EnumerationResult>)pfn.Pointer;
}
