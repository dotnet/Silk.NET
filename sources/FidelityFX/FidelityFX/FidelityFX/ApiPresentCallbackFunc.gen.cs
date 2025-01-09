// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from ffx-api and corresponding dependencies of FidelityFX.
// Original source is Copyright (C) 2024 Advanced Micro Devices, Inc. Licensed under the MIT license.
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.FidelityFX;

public readonly unsafe struct ApiPresentCallbackFunc : IDisposable
{
    private readonly void* Pointer;
    public delegate* unmanaged<CallbackDescFrameGenerationPresent*, void*, uint> Handle =>
        (delegate* unmanaged<CallbackDescFrameGenerationPresent*, void*, uint>)Pointer;

    public ApiPresentCallbackFunc(
        delegate* unmanaged<CallbackDescFrameGenerationPresent*, void*, uint> ptr
    ) => Pointer = ptr;

    public ApiPresentCallbackFunc(ApiPresentCallbackFuncDelegate proc) =>
        Pointer = SilkMarshal.DelegateToPtr(proc);

    public void Dispose() => SilkMarshal.Free(Pointer);

    public static implicit operator ApiPresentCallbackFunc(
        delegate* unmanaged<CallbackDescFrameGenerationPresent*, void*, uint> pfn
    ) => new(pfn);

    public static implicit operator delegate* unmanaged<
        CallbackDescFrameGenerationPresent*,
        void*,
        uint>(ApiPresentCallbackFunc pfn) =>
        (delegate* unmanaged<CallbackDescFrameGenerationPresent*, void*, uint>)pfn.Pointer;
}
