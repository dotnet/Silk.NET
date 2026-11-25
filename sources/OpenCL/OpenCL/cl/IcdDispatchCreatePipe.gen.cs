// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenCL headers and corresponding dependencies.
// Original source is Copyright 2013-2026 The Khronos Group Inc. Licensed under the Apache 2.0 license.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenCL;

[NativeName("_cl_icd_dispatch_clCreatePipe")]
public readonly unsafe struct IcdDispatchCreatePipe : IDisposable
{
    private readonly void* Pointer;
    public delegate* unmanaged<ContextHandle, ulong, uint, uint, nint*, int*, MemHandle> Handle =>
        (delegate* unmanaged<ContextHandle, ulong, uint, uint, nint*, int*, MemHandle>)Pointer;

    public IcdDispatchCreatePipe(
        delegate* unmanaged<ContextHandle, ulong, uint, uint, nint*, int*, MemHandle> ptr
    ) => Pointer = ptr;

    public IcdDispatchCreatePipe(IcdDispatchCreatePipeDelegate proc) =>
        Pointer = SilkMarshal.DelegateToPtr(proc);

    public void Dispose() => SilkMarshal.Free(Pointer);

    public static implicit operator IcdDispatchCreatePipe(
        delegate* unmanaged<ContextHandle, ulong, uint, uint, nint*, int*, MemHandle> pfn
    ) => new(pfn);

    public static implicit operator delegate* unmanaged<
        ContextHandle,
        ulong,
        uint,
        uint,
        nint*,
        int*,
        MemHandle>(IcdDispatchCreatePipe pfn) =>
        (delegate* unmanaged<ContextHandle, ulong, uint, uint, nint*, int*, MemHandle>)pfn.Pointer;
}
