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

public readonly unsafe struct EventProcSOFT : IDisposable
{
    private readonly void* Pointer;
    public delegate* unmanaged<int, uint, uint, int, sbyte*, void*, void> Handle =>
        (delegate* unmanaged<int, uint, uint, int, sbyte*, void*, void>)Pointer;

    public EventProcSOFT(delegate* unmanaged<int, uint, uint, int, sbyte*, void*, void> ptr) =>
        Pointer = ptr;

    public EventProcSOFT(EventProcDelegateSOFT proc) => Pointer = SilkMarshal.DelegateToPtr(proc);

    public void Dispose() => SilkMarshal.Free(Pointer);

    public static implicit operator EventProcSOFT(
        delegate* unmanaged<int, uint, uint, int, sbyte*, void*, void> pfn
    ) => new(pfn);

    public static implicit operator delegate* unmanaged<int, uint, uint, int, sbyte*, void*, void>(
        EventProcSOFT pfn
    ) => (delegate* unmanaged<int, uint, uint, int, sbyte*, void*, void>)pfn.Pointer;
}
