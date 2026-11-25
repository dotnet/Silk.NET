// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenCL headers and corresponding dependencies.
// Original source is Copyright 2013-2026 The Khronos Group Inc. Licensed under the Apache 2.0 license.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenCL;

[NativeName("_cl_icd_dispatch_windows_clCreateEventFromGLsyncKHR")]
public readonly unsafe struct IcdDispatchWindowsCreateEventFromGLsyncKHR : IDisposable
{
    private readonly void* Pointer;
    public delegate* unmanaged<ContextHandle, GLsyncHandle, int*, EventHandle> Handle =>
        (delegate* unmanaged<ContextHandle, GLsyncHandle, int*, EventHandle>)Pointer;

    public IcdDispatchWindowsCreateEventFromGLsyncKHR(
        delegate* unmanaged<ContextHandle, GLsyncHandle, int*, EventHandle> ptr
    ) => Pointer = ptr;

    public IcdDispatchWindowsCreateEventFromGLsyncKHR(
        IcdDispatchWindowsCreateEventFromGLsyncKHRDelegate proc
    ) => Pointer = SilkMarshal.DelegateToPtr(proc);

    public void Dispose() => SilkMarshal.Free(Pointer);

    public static implicit operator IcdDispatchWindowsCreateEventFromGLsyncKHR(
        delegate* unmanaged<ContextHandle, GLsyncHandle, int*, EventHandle> pfn
    ) => new(pfn);

    public static implicit operator delegate* unmanaged<
        ContextHandle,
        GLsyncHandle,
        int*,
        EventHandle>(IcdDispatchWindowsCreateEventFromGLsyncKHR pfn) =>
        (delegate* unmanaged<ContextHandle, GLsyncHandle, int*, EventHandle>)pfn.Pointer;
}
