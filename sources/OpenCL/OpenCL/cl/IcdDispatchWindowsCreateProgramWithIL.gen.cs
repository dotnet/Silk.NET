// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenCL headers and corresponding dependencies.
// Original source is Copyright 2013-2026 The Khronos Group Inc. Licensed under the Apache 2.0 license.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenCL;

[NativeName("_cl_icd_dispatch_windows_clCreateProgramWithIL")]
public readonly unsafe struct IcdDispatchWindowsCreateProgramWithIL : IDisposable
{
    private readonly void* Pointer;

    [UnscopedRef]
    public ref delegate* unmanaged<ContextHandle, void*, nuint, int*, ProgramHandle> Handle =>
        ref *(delegate* unmanaged<ContextHandle, void*, nuint, int*, ProgramHandle>*)Pointer;

    public IcdDispatchWindowsCreateProgramWithIL(
        delegate* unmanaged<ContextHandle, void*, nuint, int*, ProgramHandle> ptr
    ) => Pointer = ptr;

    public IcdDispatchWindowsCreateProgramWithIL(
        IcdDispatchWindowsCreateProgramWithILDelegate proc
    ) => Pointer = SilkMarshal.DelegateToPtr(proc);

    public void Dispose() => SilkMarshal.Free(Pointer);

    public static implicit operator IcdDispatchWindowsCreateProgramWithIL(
        delegate* unmanaged<ContextHandle, void*, nuint, int*, ProgramHandle> pfn
    ) => new(pfn);

    public static implicit operator delegate* unmanaged<
        ContextHandle,
        void*,
        nuint,
        int*,
        ProgramHandle>(IcdDispatchWindowsCreateProgramWithIL pfn) =>
        (delegate* unmanaged<ContextHandle, void*, nuint, int*, ProgramHandle>)pfn.Pointer;
}
