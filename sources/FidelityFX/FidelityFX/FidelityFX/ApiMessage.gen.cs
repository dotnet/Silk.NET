// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from ffx-api and corresponding dependencies of FidelityFX.
// Original source is Copyright (C) 2024 Advanced Micro Devices, Inc. Licensed under the MIT license.
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.FidelityFX;

public readonly unsafe struct ApiMessage : IDisposable
{
    private readonly void* Pointer;
    public delegate* unmanaged<uint, ushort*, void> Handle =>
        (delegate* unmanaged<uint, ushort*, void>)Pointer;

    public ApiMessage(delegate* unmanaged<uint, ushort*, void> ptr) => Pointer = ptr;

    public ApiMessage(ApiMessageDelegate proc) => Pointer = SilkMarshal.DelegateToPtr(proc);

    public void Dispose() => SilkMarshal.Free(Pointer);

    public static implicit operator ApiMessage(delegate* unmanaged<uint, ushort*, void> pfn) =>
        new(pfn);

    public static implicit operator delegate* unmanaged<uint, ushort*, void>(ApiMessage pfn) =>
        (delegate* unmanaged<uint, ushort*, void>)pfn.Pointer;
}
