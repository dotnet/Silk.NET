// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenCL headers and corresponding dependencies.
// Original source is Copyright 2013-2026 The Khronos Group Inc. Licensed under the Apache 2.0 license.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenCL;

[NativeName("clSetEventCallback_pfn_notify")]
public readonly unsafe struct SetEventCallbackPfnNotify : IDisposable
{
    private readonly void* Pointer;
    public delegate* unmanaged<EventHandle, int, void*, void> Handle =>
        (delegate* unmanaged<EventHandle, int, void*, void>)Pointer;

    public SetEventCallbackPfnNotify(delegate* unmanaged<EventHandle, int, void*, void> ptr) =>
        Pointer = ptr;

    public SetEventCallbackPfnNotify(SetEventCallbackPfnNotifyDelegate proc) =>
        Pointer = SilkMarshal.DelegateToPtr(proc);

    public void Dispose() => SilkMarshal.Free(Pointer);

    public static implicit operator SetEventCallbackPfnNotify(
        delegate* unmanaged<EventHandle, int, void*, void> pfn
    ) => new(pfn);

    public static implicit operator delegate* unmanaged<EventHandle, int, void*, void>(
        SetEventCallbackPfnNotify pfn
    ) => (delegate* unmanaged<EventHandle, int, void*, void>)pfn.Pointer;
}
