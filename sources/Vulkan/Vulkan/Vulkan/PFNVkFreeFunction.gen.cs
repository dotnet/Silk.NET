// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

public readonly unsafe struct PFNVkFreeFunction : IDisposable
{
    private readonly void* Pointer;
    public delegate* unmanaged<void*, void*, void> Handle =>
        (delegate* unmanaged<void*, void*, void>)Pointer;

    public PFNVkFreeFunction(delegate* unmanaged<void*, void*, void> ptr) => Pointer = ptr;

    public PFNVkFreeFunction(PFNVkFreeFunctionDelegate proc) =>
        Pointer = SilkMarshal.DelegateToPtr(proc);

    public void Dispose() => SilkMarshal.Free(Pointer);

    public static implicit operator PFNVkFreeFunction(
        delegate* unmanaged<void*, void*, void> pfn
    ) => new(pfn);

    public static implicit operator delegate* unmanaged<void*, void*, void>(
        PFNVkFreeFunction pfn
    ) => (delegate* unmanaged<void*, void*, void>)pfn.Pointer;
}
