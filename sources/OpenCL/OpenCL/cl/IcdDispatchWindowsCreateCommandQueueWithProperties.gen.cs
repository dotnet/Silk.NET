// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenCL headers and corresponding dependencies.
// Original source is Copyright 2013-2026 The Khronos Group Inc. Licensed under the Apache 2.0 license.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenCL;

[NativeName("_cl_icd_dispatch_windows_clCreateCommandQueueWithProperties")]
public readonly unsafe struct IcdDispatchWindowsCreateCommandQueueWithProperties : IDisposable
{
    private readonly void* Pointer;

    [UnscopedRef]
    public ref delegate* unmanaged<
        ContextHandle,
        DeviceIdHandle,
        ulong*,
        int*,
        CommandQueueHandle> Handle =>
        ref *(delegate* unmanaged<
            ContextHandle,
            DeviceIdHandle,
            ulong*,
            int*,
            CommandQueueHandle>*)Pointer;

    public IcdDispatchWindowsCreateCommandQueueWithProperties(
        delegate* unmanaged<ContextHandle, DeviceIdHandle, ulong*, int*, CommandQueueHandle> ptr
    ) => Pointer = ptr;

    public IcdDispatchWindowsCreateCommandQueueWithProperties(
        IcdDispatchWindowsCreateCommandQueueWithPropertiesDelegate proc
    ) => Pointer = SilkMarshal.DelegateToPtr(proc);

    public void Dispose() => SilkMarshal.Free(Pointer);

    public static implicit operator IcdDispatchWindowsCreateCommandQueueWithProperties(
        delegate* unmanaged<ContextHandle, DeviceIdHandle, ulong*, int*, CommandQueueHandle> pfn
    ) => new(pfn);

    public static implicit operator delegate* unmanaged<
        ContextHandle,
        DeviceIdHandle,
        ulong*,
        int*,
        CommandQueueHandle>(IcdDispatchWindowsCreateCommandQueueWithProperties pfn) =>
        (delegate* unmanaged<ContextHandle, DeviceIdHandle, ulong*, int*, CommandQueueHandle>)
            pfn.Pointer;
}
