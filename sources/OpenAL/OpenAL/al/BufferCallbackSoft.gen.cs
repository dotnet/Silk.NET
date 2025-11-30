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

public readonly unsafe struct BufferCallbackSoft : IDisposable
{
    private readonly void* Pointer;
    public delegate* unmanaged<void*, void*, int, int> Handle =>
        (delegate* unmanaged<void*, void*, int, int>)Pointer;

    public BufferCallbackSoft(delegate* unmanaged<void*, void*, int, int> ptr) => Pointer = ptr;

    public BufferCallbackSoft(BufferCallbackDelegateSoft proc) =>
        Pointer = SilkMarshal.DelegateToPtr(proc);

    public void Dispose() => SilkMarshal.Free(Pointer);

    public static implicit operator BufferCallbackSoft(
        delegate* unmanaged<void*, void*, int, int> pfn
    ) => new(pfn);

    public static implicit operator delegate* unmanaged<void*, void*, int, int>(
        BufferCallbackSoft pfn
    ) => (delegate* unmanaged<void*, void*, int, int>)pfn.Pointer;
}
