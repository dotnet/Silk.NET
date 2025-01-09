// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from ffx-api and corresponding dependencies of FidelityFX.
// Original source is Copyright (C) 2024 Advanced Micro Devices, Inc. Licensed under the MIT license.
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.FidelityFX;

public readonly unsafe struct Alloc : IDisposable
{
    private readonly void* Pointer;
    public delegate* unmanaged<void*, ulong, void*> Handle =>
        (delegate* unmanaged<void*, ulong, void*>)Pointer;

    public Alloc(delegate* unmanaged<void*, ulong, void*> ptr) => Pointer = ptr;

    public Alloc(AllocDelegate proc) => Pointer = SilkMarshal.DelegateToPtr(proc);

    public void Dispose() => SilkMarshal.Free(Pointer);

    public static implicit operator Alloc(delegate* unmanaged<void*, ulong, void*> pfn) => new(pfn);

    public static implicit operator delegate* unmanaged<void*, ulong, void*>(Alloc pfn) =>
        (delegate* unmanaged<void*, ulong, void*>)pfn.Pointer;
}
