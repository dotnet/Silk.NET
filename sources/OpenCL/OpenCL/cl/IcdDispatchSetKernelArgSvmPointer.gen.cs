// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenCL headers and corresponding dependencies.
// Original source is Copyright 2013-2026 The Khronos Group Inc. Licensed under the Apache 2.0 license.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenCL;

[NativeName("_cl_icd_dispatch_clSetKernelArgSVMPointer")]
public readonly unsafe struct IcdDispatchSetKernelArgSvmPointer : IDisposable
{
    private readonly void* Pointer;

    [UnscopedRef]
    public ref delegate* unmanaged<KernelHandle, uint, void*, int> Handle =>
        ref *(delegate* unmanaged<KernelHandle, uint, void*, int>*)Pointer;

    public IcdDispatchSetKernelArgSvmPointer(
        delegate* unmanaged<KernelHandle, uint, void*, int> ptr
    ) => Pointer = ptr;

    public IcdDispatchSetKernelArgSvmPointer(IcdDispatchSetKernelArgSvmPointerDelegate proc) =>
        Pointer = SilkMarshal.DelegateToPtr(proc);

    public void Dispose() => SilkMarshal.Free(Pointer);

    public static implicit operator IcdDispatchSetKernelArgSvmPointer(
        delegate* unmanaged<KernelHandle, uint, void*, int> pfn
    ) => new(pfn);

    public static implicit operator delegate* unmanaged<KernelHandle, uint, void*, int>(
        IcdDispatchSetKernelArgSvmPointer pfn
    ) => (delegate* unmanaged<KernelHandle, uint, void*, int>)pfn.Pointer;
}
