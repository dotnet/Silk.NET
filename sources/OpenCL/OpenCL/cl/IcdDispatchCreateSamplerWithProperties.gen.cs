// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenCL headers and corresponding dependencies.
// Original source is Copyright 2013-2026 The Khronos Group Inc. Licensed under the Apache 2.0 license.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenCL;

[NativeName("_cl_icd_dispatch_clCreateSamplerWithProperties")]
public readonly unsafe struct IcdDispatchCreateSamplerWithProperties : IDisposable
{
    private readonly void* Pointer;

    [UnscopedRef]
    public ref delegate* unmanaged<ContextHandle, ulong*, int*, SamplerHandle> Handle =>
        ref *(delegate* unmanaged<ContextHandle, ulong*, int*, SamplerHandle>*)Pointer;

    public IcdDispatchCreateSamplerWithProperties(
        delegate* unmanaged<ContextHandle, ulong*, int*, SamplerHandle> ptr
    ) => Pointer = ptr;

    public IcdDispatchCreateSamplerWithProperties(
        IcdDispatchCreateSamplerWithPropertiesDelegate proc
    ) => Pointer = SilkMarshal.DelegateToPtr(proc);

    public void Dispose() => SilkMarshal.Free(Pointer);

    public static implicit operator IcdDispatchCreateSamplerWithProperties(
        delegate* unmanaged<ContextHandle, ulong*, int*, SamplerHandle> pfn
    ) => new(pfn);

    public static implicit operator delegate* unmanaged<ContextHandle, ulong*, int*, SamplerHandle>(
        IcdDispatchCreateSamplerWithProperties pfn
    ) => (delegate* unmanaged<ContextHandle, ulong*, int*, SamplerHandle>)pfn.Pointer;
}
