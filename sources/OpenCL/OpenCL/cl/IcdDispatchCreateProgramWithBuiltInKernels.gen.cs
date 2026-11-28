// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenCL headers and corresponding dependencies.
// Original source is Copyright 2013-2026 The Khronos Group Inc. Licensed under the Apache 2.0 license.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenCL;

[NativeName("_cl_icd_dispatch_clCreateProgramWithBuiltInKernels")]
public readonly unsafe struct IcdDispatchCreateProgramWithBuiltInKernels : IDisposable
{
    private readonly void* Pointer;

    [UnscopedRef]
    public ref delegate* unmanaged<
        ContextHandle,
        uint,
        DeviceIdHandle*,
        sbyte*,
        int*,
        ProgramHandle> Handle =>
        ref *(delegate* unmanaged<
            ContextHandle,
            uint,
            DeviceIdHandle*,
            sbyte*,
            int*,
            ProgramHandle>*)Pointer;

    public IcdDispatchCreateProgramWithBuiltInKernels(
        delegate* unmanaged<ContextHandle, uint, DeviceIdHandle*, sbyte*, int*, ProgramHandle> ptr
    ) => Pointer = ptr;

    public IcdDispatchCreateProgramWithBuiltInKernels(
        IcdDispatchCreateProgramWithBuiltInKernelsDelegate proc
    ) => Pointer = SilkMarshal.DelegateToPtr(proc);

    public void Dispose() => SilkMarshal.Free(Pointer);

    public static implicit operator IcdDispatchCreateProgramWithBuiltInKernels(
        delegate* unmanaged<ContextHandle, uint, DeviceIdHandle*, sbyte*, int*, ProgramHandle> pfn
    ) => new(pfn);

    public static implicit operator delegate* unmanaged<
        ContextHandle,
        uint,
        DeviceIdHandle*,
        sbyte*,
        int*,
        ProgramHandle>(IcdDispatchCreateProgramWithBuiltInKernels pfn) =>
        (delegate* unmanaged<ContextHandle, uint, DeviceIdHandle*, sbyte*, int*, ProgramHandle>)
            pfn.Pointer;
}
