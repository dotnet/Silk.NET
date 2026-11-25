// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenCL headers and corresponding dependencies.
// Original source is Copyright 2013-2026 The Khronos Group Inc. Licensed under the Apache 2.0 license.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenCL;

[NativeName("_cl_icd_dispatch_windows_clCreateSampler")]
public readonly unsafe struct IcdDispatchWindowsCreateSampler : IDisposable
{
    private readonly void* Pointer;
    public delegate* unmanaged<ContextHandle, uint, uint, uint, int*, SamplerHandle> Handle =>
        (delegate* unmanaged<ContextHandle, uint, uint, uint, int*, SamplerHandle>)Pointer;

    public IcdDispatchWindowsCreateSampler(
        delegate* unmanaged<ContextHandle, uint, uint, uint, int*, SamplerHandle> ptr
    ) => Pointer = ptr;

    public IcdDispatchWindowsCreateSampler(IcdDispatchWindowsCreateSamplerDelegate proc) =>
        Pointer = SilkMarshal.DelegateToPtr(proc);

    public void Dispose() => SilkMarshal.Free(Pointer);

    public static implicit operator IcdDispatchWindowsCreateSampler(
        delegate* unmanaged<ContextHandle, uint, uint, uint, int*, SamplerHandle> pfn
    ) => new(pfn);

    public static implicit operator delegate* unmanaged<
        ContextHandle,
        uint,
        uint,
        uint,
        int*,
        SamplerHandle>(IcdDispatchWindowsCreateSampler pfn) =>
        (delegate* unmanaged<ContextHandle, uint, uint, uint, int*, SamplerHandle>)pfn.Pointer;
}
