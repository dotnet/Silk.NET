// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenCL headers and corresponding dependencies.
// Original source is Copyright 2013-2026 The Khronos Group Inc. Licensed under the Apache 2.0 license.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenCL;

[NativeName("_cl_icd_dispatch_clCloneKernel")]
public readonly unsafe struct IcdDispatchCloneKernel : IDisposable
{
    private readonly void* Pointer;

    [UnscopedRef]
    public ref delegate* unmanaged<KernelHandle, int*, KernelHandle> Handle =>
        ref *(delegate* unmanaged<KernelHandle, int*, KernelHandle>*)Pointer;

    public IcdDispatchCloneKernel(delegate* unmanaged<KernelHandle, int*, KernelHandle> ptr) =>
        Pointer = ptr;

    public IcdDispatchCloneKernel(IcdDispatchCloneKernelDelegate proc) =>
        Pointer = SilkMarshal.DelegateToPtr(proc);

    public void Dispose() => SilkMarshal.Free(Pointer);

    public static implicit operator IcdDispatchCloneKernel(
        delegate* unmanaged<KernelHandle, int*, KernelHandle> pfn
    ) => new(pfn);

    public static implicit operator delegate* unmanaged<KernelHandle, int*, KernelHandle>(
        IcdDispatchCloneKernel pfn
    ) => (delegate* unmanaged<KernelHandle, int*, KernelHandle>)pfn.Pointer;
}
