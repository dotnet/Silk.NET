// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenCL headers and corresponding dependencies.
// Original source is Copyright 2013-2026 The Khronos Group Inc. Licensed under the Apache 2.0 license.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenCL;

[NativeName("_cl_icd_dispatch_windows_clCreateKernel")]
public readonly unsafe struct IcdDispatchWindowsCreateKernel : IDisposable
{
    private readonly void* Pointer;

    [UnscopedRef]
    public ref delegate* unmanaged<ProgramHandle, sbyte*, int*, KernelHandle> Handle =>
        ref *(delegate* unmanaged<ProgramHandle, sbyte*, int*, KernelHandle>*)Pointer;

    public IcdDispatchWindowsCreateKernel(
        delegate* unmanaged<ProgramHandle, sbyte*, int*, KernelHandle> ptr
    ) => Pointer = ptr;

    public IcdDispatchWindowsCreateKernel(IcdDispatchWindowsCreateKernelDelegate proc) =>
        Pointer = SilkMarshal.DelegateToPtr(proc);

    public void Dispose() => SilkMarshal.Free(Pointer);

    public static implicit operator IcdDispatchWindowsCreateKernel(
        delegate* unmanaged<ProgramHandle, sbyte*, int*, KernelHandle> pfn
    ) => new(pfn);

    public static implicit operator delegate* unmanaged<ProgramHandle, sbyte*, int*, KernelHandle>(
        IcdDispatchWindowsCreateKernel pfn
    ) => (delegate* unmanaged<ProgramHandle, sbyte*, int*, KernelHandle>)pfn.Pointer;
}
