// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenCL headers and corresponding dependencies.
// Original source is Copyright 2013-2026 The Khronos Group Inc. Licensed under the Apache 2.0 license.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenCL;

[NativeName("_cl_icd_dispatch_clSetUserEventStatus")]
public readonly unsafe struct IcdDispatchSetUserEventStatus : IDisposable
{
    private readonly void* Pointer;

    [UnscopedRef]
    public ref delegate* unmanaged<EventHandle, int, int> Handle =>
        ref *(delegate* unmanaged<EventHandle, int, int>*)Pointer;

    public IcdDispatchSetUserEventStatus(delegate* unmanaged<EventHandle, int, int> ptr) =>
        Pointer = ptr;

    public IcdDispatchSetUserEventStatus(IcdDispatchSetUserEventStatusDelegate proc) =>
        Pointer = SilkMarshal.DelegateToPtr(proc);

    public void Dispose() => SilkMarshal.Free(Pointer);

    public static implicit operator IcdDispatchSetUserEventStatus(
        delegate* unmanaged<EventHandle, int, int> pfn
    ) => new(pfn);

    public static implicit operator delegate* unmanaged<EventHandle, int, int>(
        IcdDispatchSetUserEventStatus pfn
    ) => (delegate* unmanaged<EventHandle, int, int>)pfn.Pointer;
}
