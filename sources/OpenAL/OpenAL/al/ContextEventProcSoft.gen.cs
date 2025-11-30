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

[NativeName("ALCEVENTPROCTYPESOFT")]
public readonly unsafe struct ContextEventProcSoft : IDisposable
{
    private readonly void* Pointer;
    public delegate* unmanaged<int, int, DeviceHandle, int, sbyte*, void*, void> Handle =>
        (delegate* unmanaged<int, int, DeviceHandle, int, sbyte*, void*, void>)Pointer;

    public ContextEventProcSoft(
        delegate* unmanaged<int, int, DeviceHandle, int, sbyte*, void*, void> ptr
    ) => Pointer = ptr;

    public ContextEventProcSoft(ContextEventProcDelegateSoft proc) =>
        Pointer = SilkMarshal.DelegateToPtr(proc);

    public void Dispose() => SilkMarshal.Free(Pointer);

    public static implicit operator ContextEventProcSoft(
        delegate* unmanaged<int, int, DeviceHandle, int, sbyte*, void*, void> pfn
    ) => new(pfn);

    public static implicit operator delegate* unmanaged<
        int,
        int,
        DeviceHandle,
        int,
        sbyte*,
        void*,
        void>(ContextEventProcSoft pfn) =>
        (delegate* unmanaged<int, int, DeviceHandle, int, sbyte*, void*, void>)pfn.Pointer;
}
