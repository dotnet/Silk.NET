// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenCL headers and corresponding dependencies.
// Original source is Copyright 2013-2026 The Khronos Group Inc. Licensed under the Apache 2.0 license.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenCL;

[NativeName("_cl_icd_dispatch_windows_clRetainContext")]
public readonly unsafe struct IcdDispatchWindowsRetainContext : IDisposable
{
    private readonly void* Pointer;

    [UnscopedRef]
    public ref delegate* unmanaged<ContextHandle, int> Handle =>
        ref *(delegate* unmanaged<ContextHandle, int>*)Pointer;

    public IcdDispatchWindowsRetainContext(delegate* unmanaged<ContextHandle, int> ptr) =>
        Pointer = ptr;

    public IcdDispatchWindowsRetainContext(IcdDispatchWindowsRetainContextDelegate proc) =>
        Pointer = SilkMarshal.DelegateToPtr(proc);

    public void Dispose() => SilkMarshal.Free(Pointer);

    public static implicit operator IcdDispatchWindowsRetainContext(
        delegate* unmanaged<ContextHandle, int> pfn
    ) => new(pfn);

    public static implicit operator delegate* unmanaged<ContextHandle, int>(
        IcdDispatchWindowsRetainContext pfn
    ) => (delegate* unmanaged<ContextHandle, int>)pfn.Pointer;
}
