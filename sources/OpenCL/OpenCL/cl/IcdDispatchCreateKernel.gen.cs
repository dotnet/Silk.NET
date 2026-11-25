// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenCL headers and corresponding dependencies.
// Original source is Copyright 2013-2026 The Khronos Group Inc. Licensed under the Apache 2.0 license.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenCL;

[NativeName("_cl_icd_dispatch_clCreateKernel")]
public readonly unsafe struct IcdDispatchCreateKernel : IDisposable
{
    private readonly void* Pointer;
    public delegate* unmanaged<ProgramHandle, sbyte*, int*, KernelHandle> Handle =>
        (delegate* unmanaged<ProgramHandle, sbyte*, int*, KernelHandle>)Pointer;

    public IcdDispatchCreateKernel(
        delegate* unmanaged<ProgramHandle, sbyte*, int*, KernelHandle> ptr
    ) => Pointer = ptr;

    public IcdDispatchCreateKernel(IcdDispatchCreateKernelDelegate proc) =>
        Pointer = SilkMarshal.DelegateToPtr(proc);

    public void Dispose() => SilkMarshal.Free(Pointer);

    public static implicit operator IcdDispatchCreateKernel(
        delegate* unmanaged<ProgramHandle, sbyte*, int*, KernelHandle> pfn
    ) => new(pfn);

    public static implicit operator delegate* unmanaged<ProgramHandle, sbyte*, int*, KernelHandle>(
        IcdDispatchCreateKernel pfn
    ) => (delegate* unmanaged<ProgramHandle, sbyte*, int*, KernelHandle>)pfn.Pointer;
}
