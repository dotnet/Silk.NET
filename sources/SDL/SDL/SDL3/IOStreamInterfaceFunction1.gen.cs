// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from SDL.h and corresponding dependencies of SDL3.
// Original source is Copyright (C) 1997-2024 Sam Lantinga. Licensed under the zlib license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.SDL;

[Transformed]
public readonly unsafe struct IOStreamInterfaceFunction1 : IDisposable
{
    private readonly void* Pointer;
    public delegate* unmanaged<void*, void*, nuint, IOStatus*, nuint> Handle =>
        (delegate* unmanaged<void*, void*, nuint, IOStatus*, nuint>)Pointer;

    public IOStreamInterfaceFunction1(
        delegate* unmanaged<void*, void*, nuint, IOStatus*, nuint> ptr
    ) => Pointer = ptr;

    public IOStreamInterfaceFunction1(IOStreamInterfaceFunction1Delegate proc) =>
        Pointer = SilkMarshal.DelegateToPtr(proc);

    public void Dispose() => SilkMarshal.Free(Pointer);

    public static implicit operator IOStreamInterfaceFunction1(
        delegate* unmanaged<void*, void*, nuint, IOStatus*, nuint> pfn
    ) => new(pfn);

    public static implicit operator delegate* unmanaged<void*, void*, nuint, IOStatus*, nuint>(
        IOStreamInterfaceFunction1 pfn
    ) => (delegate* unmanaged<void*, void*, nuint, IOStatus*, nuint>)pfn.Pointer;
}