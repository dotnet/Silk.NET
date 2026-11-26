// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenCL headers and corresponding dependencies.
// Original source is Copyright 2013-2026 The Khronos Group Inc. Licensed under the Apache 2.0 license.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenCL;

[NativeName("_cl_icd_dispatch_clReleaseKernel")]
public readonly unsafe struct IcdDispatchReleaseKernel : IDisposable
{
    private readonly void* Pointer;

    [UnscopedRef]
    public ref delegate* unmanaged<KernelHandle, int> Handle =>
        ref *(delegate* unmanaged<KernelHandle, int>*)Pointer;

    public IcdDispatchReleaseKernel(delegate* unmanaged<KernelHandle, int> ptr) => Pointer = ptr;

    public IcdDispatchReleaseKernel(IcdDispatchReleaseKernelDelegate proc) =>
        Pointer = SilkMarshal.DelegateToPtr(proc);

    public void Dispose() => SilkMarshal.Free(Pointer);

    public static implicit operator IcdDispatchReleaseKernel(
        delegate* unmanaged<KernelHandle, int> pfn
    ) => new(pfn);

    public static implicit operator delegate* unmanaged<KernelHandle, int>(
        IcdDispatchReleaseKernel pfn
    ) => (delegate* unmanaged<KernelHandle, int>)pfn.Pointer;
}
