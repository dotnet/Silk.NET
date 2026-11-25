// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenCL headers and corresponding dependencies.
// Original source is Copyright 2013-2026 The Khronos Group Inc. Licensed under the Apache 2.0 license.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenCL;

[NativeName("_cl_icd_dispatch_clRetainCommandQueue")]
public readonly unsafe struct IcdDispatchRetainCommandQueue : IDisposable
{
    private readonly void* Pointer;
    public delegate* unmanaged<CommandQueueHandle, int> Handle =>
        (delegate* unmanaged<CommandQueueHandle, int>)Pointer;

    public IcdDispatchRetainCommandQueue(delegate* unmanaged<CommandQueueHandle, int> ptr) =>
        Pointer = ptr;

    public IcdDispatchRetainCommandQueue(IcdDispatchRetainCommandQueueDelegate proc) =>
        Pointer = SilkMarshal.DelegateToPtr(proc);

    public void Dispose() => SilkMarshal.Free(Pointer);

    public static implicit operator IcdDispatchRetainCommandQueue(
        delegate* unmanaged<CommandQueueHandle, int> pfn
    ) => new(pfn);

    public static implicit operator delegate* unmanaged<CommandQueueHandle, int>(
        IcdDispatchRetainCommandQueue pfn
    ) => (delegate* unmanaged<CommandQueueHandle, int>)pfn.Pointer;
}
