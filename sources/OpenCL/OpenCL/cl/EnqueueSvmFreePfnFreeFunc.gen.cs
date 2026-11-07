// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenCL headers and corresponding dependencies.
// Original source is Copyright 2013-2026 The Khronos Group Inc. Licensed under the Apache 2.0 license.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenCL;

[NativeName("clEnqueueSVMFree_pfn_free_func")]
public readonly unsafe struct EnqueueSvmFreePfnFreeFunc : IDisposable
{
    private readonly void* Pointer;
    public delegate* unmanaged<CommandQueueHandle, uint, void**, void*, void> Handle =>
        (delegate* unmanaged<CommandQueueHandle, uint, void**, void*, void>)Pointer;

    public EnqueueSvmFreePfnFreeFunc(
        delegate* unmanaged<CommandQueueHandle, uint, void**, void*, void> ptr
    ) => Pointer = ptr;

    public EnqueueSvmFreePfnFreeFunc(EnqueueSvmFreePfnFreeFuncDelegate proc) =>
        Pointer = SilkMarshal.DelegateToPtr(proc);

    public void Dispose() => SilkMarshal.Free(Pointer);

    public static implicit operator EnqueueSvmFreePfnFreeFunc(
        delegate* unmanaged<CommandQueueHandle, uint, void**, void*, void> pfn
    ) => new(pfn);

    public static implicit operator delegate* unmanaged<
        CommandQueueHandle,
        uint,
        void**,
        void*,
        void>(EnqueueSvmFreePfnFreeFunc pfn) =>
        (delegate* unmanaged<CommandQueueHandle, uint, void**, void*, void>)pfn.Pointer;
}
