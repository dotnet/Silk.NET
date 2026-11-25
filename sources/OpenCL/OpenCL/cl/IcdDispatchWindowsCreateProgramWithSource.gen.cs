// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenCL headers and corresponding dependencies.
// Original source is Copyright 2013-2026 The Khronos Group Inc. Licensed under the Apache 2.0 license.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenCL;

[NativeName("_cl_icd_dispatch_windows_clCreateProgramWithSource")]
public readonly unsafe struct IcdDispatchWindowsCreateProgramWithSource : IDisposable
{
    private readonly void* Pointer;
    public delegate* unmanaged<ContextHandle, uint, sbyte**, nuint*, int*, ProgramHandle> Handle =>
        (delegate* unmanaged<ContextHandle, uint, sbyte**, nuint*, int*, ProgramHandle>)Pointer;

    public IcdDispatchWindowsCreateProgramWithSource(
        delegate* unmanaged<ContextHandle, uint, sbyte**, nuint*, int*, ProgramHandle> ptr
    ) => Pointer = ptr;

    public IcdDispatchWindowsCreateProgramWithSource(
        IcdDispatchWindowsCreateProgramWithSourceDelegate proc
    ) => Pointer = SilkMarshal.DelegateToPtr(proc);

    public void Dispose() => SilkMarshal.Free(Pointer);

    public static implicit operator IcdDispatchWindowsCreateProgramWithSource(
        delegate* unmanaged<ContextHandle, uint, sbyte**, nuint*, int*, ProgramHandle> pfn
    ) => new(pfn);

    public static implicit operator delegate* unmanaged<
        ContextHandle,
        uint,
        sbyte**,
        nuint*,
        int*,
        ProgramHandle>(IcdDispatchWindowsCreateProgramWithSource pfn) =>
        (delegate* unmanaged<ContextHandle, uint, sbyte**, nuint*, int*, ProgramHandle>)pfn.Pointer;
}
