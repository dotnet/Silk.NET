// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from ffx-api and corresponding dependencies of FidelityFX.
// Original source is Copyright (C) 2024 Advanced Micro Devices, Inc. Licensed under the MIT license.
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.FidelityFX;

public readonly unsafe struct ApiFrameGenerationDispatchFunc : IDisposable
{
    private readonly void* Pointer;
    public delegate* unmanaged<DispatchDescFrameGeneration*, void*, uint> Handle =>
        (delegate* unmanaged<DispatchDescFrameGeneration*, void*, uint>)Pointer;

    public ApiFrameGenerationDispatchFunc(
        delegate* unmanaged<DispatchDescFrameGeneration*, void*, uint> ptr
    ) => Pointer = ptr;

    public ApiFrameGenerationDispatchFunc(ApiFrameGenerationDispatchFuncDelegate proc) =>
        Pointer = SilkMarshal.DelegateToPtr(proc);

    public void Dispose() => SilkMarshal.Free(Pointer);

    public static implicit operator ApiFrameGenerationDispatchFunc(
        delegate* unmanaged<DispatchDescFrameGeneration*, void*, uint> pfn
    ) => new(pfn);

    public static implicit operator delegate* unmanaged<DispatchDescFrameGeneration*, void*, uint>(
        ApiFrameGenerationDispatchFunc pfn
    ) => (delegate* unmanaged<DispatchDescFrameGeneration*, void*, uint>)pfn.Pointer;
}
