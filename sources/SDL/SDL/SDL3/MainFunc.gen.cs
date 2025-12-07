// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from SDL.h and corresponding dependencies of SDL3.
// Original source is Copyright (C) 1997-2024 Sam Lantinga. Licensed under the zlib license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.SDL;

public readonly unsafe struct MainFunc : IDisposable
{
    private readonly void* Pointer;
    public delegate* unmanaged<int, sbyte**, int> Handle =>
        (delegate* unmanaged<int, sbyte**, int>)Pointer;

    public MainFunc(delegate* unmanaged<int, sbyte**, int> ptr) => Pointer = ptr;

    public MainFunc(MainFuncDelegate proc) => Pointer = SilkMarshal.DelegateToPtr(proc);

    public void Dispose() => SilkMarshal.Free(Pointer);

    public static implicit operator MainFunc(delegate* unmanaged<int, sbyte**, int> pfn) =>
        new(pfn);

    public static implicit operator delegate* unmanaged<int, sbyte**, int>(MainFunc pfn) =>
        (delegate* unmanaged<int, sbyte**, int>)pfn.Pointer;
}
