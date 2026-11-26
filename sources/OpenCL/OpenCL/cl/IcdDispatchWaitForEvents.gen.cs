// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenCL headers and corresponding dependencies.
// Original source is Copyright 2013-2026 The Khronos Group Inc. Licensed under the Apache 2.0 license.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenCL;

[NativeName("_cl_icd_dispatch_clWaitForEvents")]
public readonly unsafe struct IcdDispatchWaitForEvents : IDisposable
{
    private readonly void* Pointer;

    [UnscopedRef]
    public ref delegate* unmanaged<uint, EventHandle*, int> Handle =>
        ref *(delegate* unmanaged<uint, EventHandle*, int>*)Pointer;

    public IcdDispatchWaitForEvents(delegate* unmanaged<uint, EventHandle*, int> ptr) =>
        Pointer = ptr;

    public IcdDispatchWaitForEvents(IcdDispatchWaitForEventsDelegate proc) =>
        Pointer = SilkMarshal.DelegateToPtr(proc);

    public void Dispose() => SilkMarshal.Free(Pointer);

    public static implicit operator IcdDispatchWaitForEvents(
        delegate* unmanaged<uint, EventHandle*, int> pfn
    ) => new(pfn);

    public static implicit operator delegate* unmanaged<uint, EventHandle*, int>(
        IcdDispatchWaitForEvents pfn
    ) => (delegate* unmanaged<uint, EventHandle*, int>)pfn.Pointer;
}
