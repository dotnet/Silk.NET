// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenCL headers and corresponding dependencies.
// Original source is Copyright 2013-2026 The Khronos Group Inc. Licensed under the Apache 2.0 license.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenCL;

[NativeName("_cl_icd_dispatch_clCreateContextFromType_p2")]
public readonly unsafe struct IcdDispatchClCreateContextFromTypeP2 : IDisposable
{
    private readonly void* Pointer;

    [UnscopedRef]
    public ref delegate* unmanaged<sbyte*, void*, nuint, void*, void> Handle =>
        ref *(delegate* unmanaged<sbyte*, void*, nuint, void*, void>*)Pointer;

    public IcdDispatchClCreateContextFromTypeP2(
        delegate* unmanaged<sbyte*, void*, nuint, void*, void> ptr
    ) => Pointer = ptr;

    public IcdDispatchClCreateContextFromTypeP2(
        IcdDispatchClCreateContextFromTypeP2Delegate proc
    ) => Pointer = SilkMarshal.DelegateToPtr(proc);

    public void Dispose() => SilkMarshal.Free(Pointer);

    public static implicit operator IcdDispatchClCreateContextFromTypeP2(
        delegate* unmanaged<sbyte*, void*, nuint, void*, void> pfn
    ) => new(pfn);

    public static implicit operator delegate* unmanaged<sbyte*, void*, nuint, void*, void>(
        IcdDispatchClCreateContextFromTypeP2 pfn
    ) => (delegate* unmanaged<sbyte*, void*, nuint, void*, void>)pfn.Pointer;
}
