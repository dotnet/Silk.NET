// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenCL headers and corresponding dependencies.
// Original source is Copyright 2013-2026 The Khronos Group Inc. Licensed under the Apache 2.0 license.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenCL;

[NativeName("_cl_icd_dispatch_clCreateBuffer")]
public readonly unsafe struct IcdDispatchCreateBuffer : IDisposable
{
    private readonly void* Pointer;

    [UnscopedRef]
    public ref delegate* unmanaged<ContextHandle, ulong, nuint, void*, int*, MemHandle> Handle =>
        ref *(delegate* unmanaged<ContextHandle, ulong, nuint, void*, int*, MemHandle>*)Pointer;

    public IcdDispatchCreateBuffer(
        delegate* unmanaged<ContextHandle, ulong, nuint, void*, int*, MemHandle> ptr
    ) => Pointer = ptr;

    public IcdDispatchCreateBuffer(IcdDispatchCreateBufferDelegate proc) =>
        Pointer = SilkMarshal.DelegateToPtr(proc);

    public void Dispose() => SilkMarshal.Free(Pointer);

    public static implicit operator IcdDispatchCreateBuffer(
        delegate* unmanaged<ContextHandle, ulong, nuint, void*, int*, MemHandle> pfn
    ) => new(pfn);

    public static implicit operator delegate* unmanaged<
        ContextHandle,
        ulong,
        nuint,
        void*,
        int*,
        MemHandle>(IcdDispatchCreateBuffer pfn) =>
        (delegate* unmanaged<ContextHandle, ulong, nuint, void*, int*, MemHandle>)pfn.Pointer;
}
