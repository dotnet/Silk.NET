// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from ffx-api and corresponding dependencies of FidelityFX.
// Original source is Copyright (C) 2024 Advanced Micro Devices, Inc. Licensed under the MIT license.
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.FidelityFX;

public readonly unsafe struct PfnFfxCreateContext : IDisposable
{
    private readonly void* Pointer;
    public delegate* unmanaged<void**, ApiHeader*, AllocationCallbacks*, uint> Handle =>
        (delegate* unmanaged<void**, ApiHeader*, AllocationCallbacks*, uint>)Pointer;

    public PfnFfxCreateContext(
        delegate* unmanaged<void**, ApiHeader*, AllocationCallbacks*, uint> ptr
    ) => Pointer = ptr;

    public PfnFfxCreateContext(PfnFfxCreateContextDelegate proc) =>
        Pointer = SilkMarshal.DelegateToPtr(proc);

    public void Dispose() => SilkMarshal.Free(Pointer);

    public static implicit operator PfnFfxCreateContext(
        delegate* unmanaged<void**, ApiHeader*, AllocationCallbacks*, uint> pfn
    ) => new(pfn);

    public static implicit operator delegate* unmanaged<
        void**,
        ApiHeader*,
        AllocationCallbacks*,
        uint>(PfnFfxCreateContext pfn) =>
        (delegate* unmanaged<void**, ApiHeader*, AllocationCallbacks*, uint>)pfn.Pointer;
}
