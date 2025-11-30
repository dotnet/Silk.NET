// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Generated using the OpenAL Soft headers and corresponding dependencies.
// Original source is licensed under the LGPL 2.0 license. Please note that while bindings are able to be MIT due to
// being header-derived only, implementations of the headers may have a less permissive license.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenAL;

[NativeName("LPALFOLDBACKCALLBACK")]
public readonly unsafe struct FoldbackCallback : IDisposable
{
    private readonly void* Pointer;
    public delegate* unmanaged<int, int, void> Handle =>
        (delegate* unmanaged<int, int, void>)Pointer;

    public FoldbackCallback(delegate* unmanaged<int, int, void> ptr) => Pointer = ptr;

    public FoldbackCallback(FoldbackCallbackDelegate proc) =>
        Pointer = SilkMarshal.DelegateToPtr(proc);

    public void Dispose() => SilkMarshal.Free(Pointer);

    public static implicit operator FoldbackCallback(delegate* unmanaged<int, int, void> pfn) =>
        new(pfn);

    public static implicit operator delegate* unmanaged<int, int, void>(FoldbackCallback pfn) =>
        (delegate* unmanaged<int, int, void>)pfn.Pointer;
}
