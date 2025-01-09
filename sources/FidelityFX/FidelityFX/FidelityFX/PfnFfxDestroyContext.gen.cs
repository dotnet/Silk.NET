// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from ffx-api and corresponding dependencies of FidelityFX.
// Original source is Copyright (C) 2024 Advanced Micro Devices, Inc. Licensed under the MIT license.
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.FidelityFX;

public readonly unsafe struct PfnFfxDestroyContext : IDisposable
{
    private readonly void* Pointer;
    public delegate* unmanaged<void**, AllocationCallbacks*, uint> Handle =>
        (delegate* unmanaged<void**, AllocationCallbacks*, uint>)Pointer;

    public PfnFfxDestroyContext(delegate* unmanaged<void**, AllocationCallbacks*, uint> ptr) =>
        Pointer = ptr;

    public PfnFfxDestroyContext(PfnFfxDestroyContextDelegate proc) =>
        Pointer = SilkMarshal.DelegateToPtr(proc);

    public void Dispose() => SilkMarshal.Free(Pointer);

    public static implicit operator PfnFfxDestroyContext(
        delegate* unmanaged<void**, AllocationCallbacks*, uint> pfn
    ) => new(pfn);

    public static implicit operator delegate* unmanaged<void**, AllocationCallbacks*, uint>(
        PfnFfxDestroyContext pfn
    ) => (delegate* unmanaged<void**, AllocationCallbacks*, uint>)pfn.Pointer;
}
