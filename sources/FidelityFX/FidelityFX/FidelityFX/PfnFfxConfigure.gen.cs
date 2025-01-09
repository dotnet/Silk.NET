// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from ffx-api and corresponding dependencies of FidelityFX.
// Original source is Copyright (C) 2024 Advanced Micro Devices, Inc. Licensed under the MIT license.
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.FidelityFX;

public readonly unsafe struct PfnFfxConfigure : IDisposable
{
    private readonly void* Pointer;
    public delegate* unmanaged<void**, ApiHeader*, uint> Handle =>
        (delegate* unmanaged<void**, ApiHeader*, uint>)Pointer;

    public PfnFfxConfigure(delegate* unmanaged<void**, ApiHeader*, uint> ptr) => Pointer = ptr;

    public PfnFfxConfigure(PfnFfxConfigureDelegate proc) =>
        Pointer = SilkMarshal.DelegateToPtr(proc);

    public void Dispose() => SilkMarshal.Free(Pointer);

    public static implicit operator PfnFfxConfigure(
        delegate* unmanaged<void**, ApiHeader*, uint> pfn
    ) => new(pfn);

    public static implicit operator delegate* unmanaged<void**, ApiHeader*, uint>(
        PfnFfxConfigure pfn
    ) => (delegate* unmanaged<void**, ApiHeader*, uint>)pfn.Pointer;
}
