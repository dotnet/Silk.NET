// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenCL headers and corresponding dependencies.
// Original source is Copyright 2013-2026 The Khronos Group Inc. Licensed under the Apache 2.0 license.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenCL;

[NativeName("_cl_icd_dispatch_clSetCommandQueueProperty")]
public readonly unsafe struct IcdDispatchSetCommandQueueProperty : IDisposable
{
    private readonly void* Pointer;
    public delegate* unmanaged<CommandQueueHandle, ulong, uint, ulong*, int> Handle =>
        (delegate* unmanaged<CommandQueueHandle, ulong, uint, ulong*, int>)Pointer;

    public IcdDispatchSetCommandQueueProperty(
        delegate* unmanaged<CommandQueueHandle, ulong, uint, ulong*, int> ptr
    ) => Pointer = ptr;

    public IcdDispatchSetCommandQueueProperty(IcdDispatchSetCommandQueuePropertyDelegate proc) =>
        Pointer = SilkMarshal.DelegateToPtr(proc);

    public void Dispose() => SilkMarshal.Free(Pointer);

    public static implicit operator IcdDispatchSetCommandQueueProperty(
        delegate* unmanaged<CommandQueueHandle, ulong, uint, ulong*, int> pfn
    ) => new(pfn);

    public static implicit operator delegate* unmanaged<
        CommandQueueHandle,
        ulong,
        uint,
        ulong*,
        int>(IcdDispatchSetCommandQueueProperty pfn) =>
        (delegate* unmanaged<CommandQueueHandle, ulong, uint, ulong*, int>)pfn.Pointer;
}
