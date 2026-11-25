// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenCL headers and corresponding dependencies.
// Original source is Copyright 2013-2026 The Khronos Group Inc. Licensed under the Apache 2.0 license.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenCL;

[NativeName("_cl_icd_dispatch_clReleaseSampler")]
public readonly unsafe struct IcdDispatchReleaseSampler : IDisposable
{
    private readonly void* Pointer;
    public delegate* unmanaged<SamplerHandle, int> Handle =>
        (delegate* unmanaged<SamplerHandle, int>)Pointer;

    public IcdDispatchReleaseSampler(delegate* unmanaged<SamplerHandle, int> ptr) => Pointer = ptr;

    public IcdDispatchReleaseSampler(IcdDispatchReleaseSamplerDelegate proc) =>
        Pointer = SilkMarshal.DelegateToPtr(proc);

    public void Dispose() => SilkMarshal.Free(Pointer);

    public static implicit operator IcdDispatchReleaseSampler(
        delegate* unmanaged<SamplerHandle, int> pfn
    ) => new(pfn);

    public static implicit operator delegate* unmanaged<SamplerHandle, int>(
        IcdDispatchReleaseSampler pfn
    ) => (delegate* unmanaged<SamplerHandle, int>)pfn.Pointer;
}
