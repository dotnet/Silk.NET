// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

public readonly unsafe struct FreeFunction : IDisposable
{
    private readonly void* Pointer;
    public delegate* unmanaged<void*, void*, void> Handle =>
        (delegate* unmanaged<void*, void*, void>)Pointer;

    public FreeFunction(delegate* unmanaged<void*, void*, void> ptr) => Pointer = ptr;

    public FreeFunction(FreeFunctionDelegate proc) => Pointer = SilkMarshal.DelegateToPtr(proc);

    public void Dispose() => SilkMarshal.Free(Pointer);

    public static implicit operator FreeFunction(delegate* unmanaged<void*, void*, void> pfn) =>
        new(pfn);

    public static implicit operator delegate* unmanaged<void*, void*, void>(FreeFunction pfn) =>
        (delegate* unmanaged<void*, void*, void>)pfn.Pointer;
}
