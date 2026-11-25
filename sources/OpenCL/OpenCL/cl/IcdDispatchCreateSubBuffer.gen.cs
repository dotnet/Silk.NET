// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenCL headers and corresponding dependencies.
// Original source is Copyright 2013-2026 The Khronos Group Inc. Licensed under the Apache 2.0 license.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenCL;

[NativeName("_cl_icd_dispatch_clCreateSubBuffer")]
public readonly unsafe struct IcdDispatchCreateSubBuffer : IDisposable
{
    private readonly void* Pointer;
    public delegate* unmanaged<MemHandle, ulong, uint, void*, int*, MemHandle> Handle =>
        (delegate* unmanaged<MemHandle, ulong, uint, void*, int*, MemHandle>)Pointer;

    public IcdDispatchCreateSubBuffer(
        delegate* unmanaged<MemHandle, ulong, uint, void*, int*, MemHandle> ptr
    ) => Pointer = ptr;

    public IcdDispatchCreateSubBuffer(IcdDispatchCreateSubBufferDelegate proc) =>
        Pointer = SilkMarshal.DelegateToPtr(proc);

    public void Dispose() => SilkMarshal.Free(Pointer);

    public static implicit operator IcdDispatchCreateSubBuffer(
        delegate* unmanaged<MemHandle, ulong, uint, void*, int*, MemHandle> pfn
    ) => new(pfn);

    public static implicit operator delegate* unmanaged<
        MemHandle,
        ulong,
        uint,
        void*,
        int*,
        MemHandle>(IcdDispatchCreateSubBuffer pfn) =>
        (delegate* unmanaged<MemHandle, ulong, uint, void*, int*, MemHandle>)pfn.Pointer;
}
