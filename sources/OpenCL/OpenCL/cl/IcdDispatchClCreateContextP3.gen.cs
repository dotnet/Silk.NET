// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenCL headers and corresponding dependencies.
// Original source is Copyright 2013-2026 The Khronos Group Inc. Licensed under the Apache 2.0 license.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenCL;

[NativeName("_cl_icd_dispatch_clCreateContext_p3")]
public readonly unsafe struct IcdDispatchClCreateContextP3 : IDisposable
{
    private readonly void* Pointer;

    [UnscopedRef]
    public ref delegate* unmanaged<sbyte*, void*, nuint, void*, void> Handle =>
        ref *(delegate* unmanaged<sbyte*, void*, nuint, void*, void>*)Pointer;

    public IcdDispatchClCreateContextP3(
        delegate* unmanaged<sbyte*, void*, nuint, void*, void> ptr
    ) => Pointer = ptr;

    public IcdDispatchClCreateContextP3(IcdDispatchClCreateContextP3Delegate proc) =>
        Pointer = SilkMarshal.DelegateToPtr(proc);

    public void Dispose() => SilkMarshal.Free(Pointer);

    public static implicit operator IcdDispatchClCreateContextP3(
        delegate* unmanaged<sbyte*, void*, nuint, void*, void> pfn
    ) => new(pfn);

    public static implicit operator delegate* unmanaged<sbyte*, void*, nuint, void*, void>(
        IcdDispatchClCreateContextP3 pfn
    ) => (delegate* unmanaged<sbyte*, void*, nuint, void*, void>)pfn.Pointer;
}
