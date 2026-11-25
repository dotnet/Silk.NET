// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenCL headers and corresponding dependencies.
// Original source is Copyright 2013-2026 The Khronos Group Inc. Licensed under the Apache 2.0 license.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenCL;

[NativeName("_cl_icd_dispatch_clGetCommandQueueInfo")]
public readonly unsafe struct IcdDispatchGetCommandQueueInfo : IDisposable
{
    private readonly void* Pointer;
    public delegate* unmanaged<CommandQueueHandle, uint, nuint, void*, nuint*, int> Handle =>
        (delegate* unmanaged<CommandQueueHandle, uint, nuint, void*, nuint*, int>)Pointer;

    public IcdDispatchGetCommandQueueInfo(
        delegate* unmanaged<CommandQueueHandle, uint, nuint, void*, nuint*, int> ptr
    ) => Pointer = ptr;

    public IcdDispatchGetCommandQueueInfo(IcdDispatchGetCommandQueueInfoDelegate proc) =>
        Pointer = SilkMarshal.DelegateToPtr(proc);

    public void Dispose() => SilkMarshal.Free(Pointer);

    public static implicit operator IcdDispatchGetCommandQueueInfo(
        delegate* unmanaged<CommandQueueHandle, uint, nuint, void*, nuint*, int> pfn
    ) => new(pfn);

    public static implicit operator delegate* unmanaged<
        CommandQueueHandle,
        uint,
        nuint,
        void*,
        nuint*,
        int>(IcdDispatchGetCommandQueueInfo pfn) =>
        (delegate* unmanaged<CommandQueueHandle, uint, nuint, void*, nuint*, int>)pfn.Pointer;
}
