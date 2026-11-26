// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenCL headers and corresponding dependencies.
// Original source is Copyright 2013-2026 The Khronos Group Inc. Licensed under the Apache 2.0 license.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenCL;

[NativeName("_cl_icd_dispatch_windows_clEnqueueNativeKernel_p1")]
public readonly unsafe struct IcdDispatchWindowsClEnqueueNativeKernelP1 : IDisposable
{
    private readonly void* Pointer;

    [UnscopedRef]
    public ref delegate* unmanaged<void*, void> Handle =>
        ref *(delegate* unmanaged<void*, void>*)Pointer;

    public IcdDispatchWindowsClEnqueueNativeKernelP1(delegate* unmanaged<void*, void> ptr) =>
        Pointer = ptr;

    public IcdDispatchWindowsClEnqueueNativeKernelP1(
        IcdDispatchWindowsClEnqueueNativeKernelP1Delegate proc
    ) => Pointer = SilkMarshal.DelegateToPtr(proc);

    public void Dispose() => SilkMarshal.Free(Pointer);

    public static implicit operator IcdDispatchWindowsClEnqueueNativeKernelP1(
        delegate* unmanaged<void*, void> pfn
    ) => new(pfn);

    public static implicit operator delegate* unmanaged<void*, void>(
        IcdDispatchWindowsClEnqueueNativeKernelP1 pfn
    ) => (delegate* unmanaged<void*, void>)pfn.Pointer;
}
