// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenCL headers and corresponding dependencies.
// Original source is Copyright 2013-2026 The Khronos Group Inc. Licensed under the Apache 2.0 license.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenCL;

[NativeName("_cl_icd_dispatch_windows_clSetKernelExecInfo")]
public readonly unsafe struct IcdDispatchWindowsSetKernelExecInfo : IDisposable
{
    private readonly void* Pointer;
    public delegate* unmanaged<KernelHandle, uint, nuint, void*, int> Handle =>
        (delegate* unmanaged<KernelHandle, uint, nuint, void*, int>)Pointer;

    public IcdDispatchWindowsSetKernelExecInfo(
        delegate* unmanaged<KernelHandle, uint, nuint, void*, int> ptr
    ) => Pointer = ptr;

    public IcdDispatchWindowsSetKernelExecInfo(IcdDispatchWindowsSetKernelExecInfoDelegate proc) =>
        Pointer = SilkMarshal.DelegateToPtr(proc);

    public void Dispose() => SilkMarshal.Free(Pointer);

    public static implicit operator IcdDispatchWindowsSetKernelExecInfo(
        delegate* unmanaged<KernelHandle, uint, nuint, void*, int> pfn
    ) => new(pfn);

    public static implicit operator delegate* unmanaged<KernelHandle, uint, nuint, void*, int>(
        IcdDispatchWindowsSetKernelExecInfo pfn
    ) => (delegate* unmanaged<KernelHandle, uint, nuint, void*, int>)pfn.Pointer;
}
