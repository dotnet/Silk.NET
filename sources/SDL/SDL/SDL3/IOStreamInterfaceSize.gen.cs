// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from SDL.h and corresponding dependencies of SDL3.
// Original source is Copyright (C) 1997-2024 Sam Lantinga. Licensed under the zlib license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.SDL;

[Transformed]
public readonly unsafe struct IOStreamInterfaceSize : IDisposable
{
    private readonly void* Pointer;
    public delegate* unmanaged<void*, long> Handle => (delegate* unmanaged<void*, long>)Pointer;

    public IOStreamInterfaceSize(delegate* unmanaged<void*, long> ptr) => Pointer = ptr;

    public IOStreamInterfaceSize(IOStreamInterfaceSizeDelegate proc) =>
        Pointer = SilkMarshal.DelegateToPtr(proc);

    public void Dispose() => SilkMarshal.Free(Pointer);

    public static implicit operator IOStreamInterfaceSize(delegate* unmanaged<void*, long> pfn) =>
        new(pfn);

    public static implicit operator delegate* unmanaged<void*, long>(IOStreamInterfaceSize pfn) =>
        (delegate* unmanaged<void*, long>)pfn.Pointer;
}