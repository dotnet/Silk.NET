// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenCL headers and corresponding dependencies.
// Original source is Copyright 2013-2026 The Khronos Group Inc. Licensed under the Apache 2.0 license.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenCL;

[NativeName("_cl_icd_dispatch_windows_clCreateUserEvent")]
public readonly unsafe struct IcdDispatchWindowsCreateUserEvent : IDisposable
{
    private readonly void* Pointer;
    public delegate* unmanaged<ContextHandle, int*, EventHandle> Handle =>
        (delegate* unmanaged<ContextHandle, int*, EventHandle>)Pointer;

    public IcdDispatchWindowsCreateUserEvent(
        delegate* unmanaged<ContextHandle, int*, EventHandle> ptr
    ) => Pointer = ptr;

    public IcdDispatchWindowsCreateUserEvent(IcdDispatchWindowsCreateUserEventDelegate proc) =>
        Pointer = SilkMarshal.DelegateToPtr(proc);

    public void Dispose() => SilkMarshal.Free(Pointer);

    public static implicit operator IcdDispatchWindowsCreateUserEvent(
        delegate* unmanaged<ContextHandle, int*, EventHandle> pfn
    ) => new(pfn);

    public static implicit operator delegate* unmanaged<ContextHandle, int*, EventHandle>(
        IcdDispatchWindowsCreateUserEvent pfn
    ) => (delegate* unmanaged<ContextHandle, int*, EventHandle>)pfn.Pointer;
}
