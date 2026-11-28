// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenCL headers and corresponding dependencies.
// Original source is Copyright 2013-2026 The Khronos Group Inc. Licensed under the Apache 2.0 license.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenCL;

[NativeName("_cl_icd_dispatch_windows_clRetainCommandQueue")]
public readonly unsafe struct IcdDispatchWindowsRetainCommandQueue : IDisposable
{
    private readonly void* Pointer;

    [UnscopedRef]
    public ref delegate* unmanaged<CommandQueueHandle, int> Handle =>
        ref *(delegate* unmanaged<CommandQueueHandle, int>*)Pointer;

    public IcdDispatchWindowsRetainCommandQueue(delegate* unmanaged<CommandQueueHandle, int> ptr) =>
        Pointer = ptr;

    public IcdDispatchWindowsRetainCommandQueue(
        IcdDispatchWindowsRetainCommandQueueDelegate proc
    ) => Pointer = SilkMarshal.DelegateToPtr(proc);

    public void Dispose() => SilkMarshal.Free(Pointer);

    public static implicit operator IcdDispatchWindowsRetainCommandQueue(
        delegate* unmanaged<CommandQueueHandle, int> pfn
    ) => new(pfn);

    public static implicit operator delegate* unmanaged<CommandQueueHandle, int>(
        IcdDispatchWindowsRetainCommandQueue pfn
    ) => (delegate* unmanaged<CommandQueueHandle, int>)pfn.Pointer;
}
