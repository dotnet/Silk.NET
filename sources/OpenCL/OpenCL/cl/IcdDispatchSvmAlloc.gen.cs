// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenCL headers and corresponding dependencies.
// Original source is Copyright 2013-2026 The Khronos Group Inc. Licensed under the Apache 2.0 license.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenCL;

[NativeName("_cl_icd_dispatch_clSVMAlloc")]
public readonly unsafe struct IcdDispatchSvmAlloc : IDisposable
{
    private readonly void* Pointer;

    [UnscopedRef]
    public ref delegate* unmanaged<ContextHandle, ulong, nuint, uint, void*> Handle =>
        ref *(delegate* unmanaged<ContextHandle, ulong, nuint, uint, void*>*)Pointer;

    public IcdDispatchSvmAlloc(delegate* unmanaged<ContextHandle, ulong, nuint, uint, void*> ptr) =>
        Pointer = ptr;

    public IcdDispatchSvmAlloc(IcdDispatchSvmAllocDelegate proc) =>
        Pointer = SilkMarshal.DelegateToPtr(proc);

    public void Dispose() => SilkMarshal.Free(Pointer);

    public static implicit operator IcdDispatchSvmAlloc(
        delegate* unmanaged<ContextHandle, ulong, nuint, uint, void*> pfn
    ) => new(pfn);

    public static implicit operator delegate* unmanaged<ContextHandle, ulong, nuint, uint, void*>(
        IcdDispatchSvmAlloc pfn
    ) => (delegate* unmanaged<ContextHandle, ulong, nuint, uint, void*>)pfn.Pointer;
}
