// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenCL headers and corresponding dependencies.
// Original source is Copyright 2013-2026 The Khronos Group Inc. Licensed under the Apache 2.0 license.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenCL;

[NativeName("_cl_icd_dispatch_clCreateEventFromEGLSyncKHR")]
public readonly unsafe struct IcdDispatchCreateEventFromEglSyncKHR : IDisposable
{
    private readonly void* Pointer;
    public delegate* unmanaged<ContextHandle, void*, void*, int*, EventHandle> Handle =>
        (delegate* unmanaged<ContextHandle, void*, void*, int*, EventHandle>)Pointer;

    public IcdDispatchCreateEventFromEglSyncKHR(
        delegate* unmanaged<ContextHandle, void*, void*, int*, EventHandle> ptr
    ) => Pointer = ptr;

    public IcdDispatchCreateEventFromEglSyncKHR(
        IcdDispatchCreateEventFromEglSyncKHRDelegate proc
    ) => Pointer = SilkMarshal.DelegateToPtr(proc);

    public void Dispose() => SilkMarshal.Free(Pointer);

    public static implicit operator IcdDispatchCreateEventFromEglSyncKHR(
        delegate* unmanaged<ContextHandle, void*, void*, int*, EventHandle> pfn
    ) => new(pfn);

    public static implicit operator delegate* unmanaged<
        ContextHandle,
        void*,
        void*,
        int*,
        EventHandle>(IcdDispatchCreateEventFromEglSyncKHR pfn) =>
        (delegate* unmanaged<ContextHandle, void*, void*, int*, EventHandle>)pfn.Pointer;
}
