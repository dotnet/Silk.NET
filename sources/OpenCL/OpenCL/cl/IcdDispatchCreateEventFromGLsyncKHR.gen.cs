// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenCL headers and corresponding dependencies.
// Original source is Copyright 2013-2026 The Khronos Group Inc. Licensed under the Apache 2.0 license.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenCL;

[NativeName("_cl_icd_dispatch_clCreateEventFromGLsyncKHR")]
public readonly unsafe struct IcdDispatchCreateEventFromGLsyncKHR : IDisposable
{
    private readonly void* Pointer;

    [UnscopedRef]
    public ref delegate* unmanaged<ContextHandle, void*, int*, EventHandle> Handle =>
        ref *(delegate* unmanaged<ContextHandle, void*, int*, EventHandle>*)Pointer;

    public IcdDispatchCreateEventFromGLsyncKHR(
        delegate* unmanaged<ContextHandle, void*, int*, EventHandle> ptr
    ) => Pointer = ptr;

    public IcdDispatchCreateEventFromGLsyncKHR(IcdDispatchCreateEventFromGLsyncKHRDelegate proc) =>
        Pointer = SilkMarshal.DelegateToPtr(proc);

    public void Dispose() => SilkMarshal.Free(Pointer);

    public static implicit operator IcdDispatchCreateEventFromGLsyncKHR(
        delegate* unmanaged<ContextHandle, void*, int*, EventHandle> pfn
    ) => new(pfn);

    public static implicit operator delegate* unmanaged<ContextHandle, void*, int*, EventHandle>(
        IcdDispatchCreateEventFromGLsyncKHR pfn
    ) => (delegate* unmanaged<ContextHandle, void*, int*, EventHandle>)pfn.Pointer;
}
