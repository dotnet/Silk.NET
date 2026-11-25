// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenCL headers and corresponding dependencies.
// Original source is Copyright 2013-2026 The Khronos Group Inc. Licensed under the Apache 2.0 license.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenCL;

[NativeName("_cl_icd_dispatch_windows_clGetProgramInfo")]
public readonly unsafe struct IcdDispatchWindowsGetProgramInfo : IDisposable
{
    private readonly void* Pointer;
    public delegate* unmanaged<ProgramHandle, uint, nuint, void*, nuint*, int> Handle =>
        (delegate* unmanaged<ProgramHandle, uint, nuint, void*, nuint*, int>)Pointer;

    public IcdDispatchWindowsGetProgramInfo(
        delegate* unmanaged<ProgramHandle, uint, nuint, void*, nuint*, int> ptr
    ) => Pointer = ptr;

    public IcdDispatchWindowsGetProgramInfo(IcdDispatchWindowsGetProgramInfoDelegate proc) =>
        Pointer = SilkMarshal.DelegateToPtr(proc);

    public void Dispose() => SilkMarshal.Free(Pointer);

    public static implicit operator IcdDispatchWindowsGetProgramInfo(
        delegate* unmanaged<ProgramHandle, uint, nuint, void*, nuint*, int> pfn
    ) => new(pfn);

    public static implicit operator delegate* unmanaged<
        ProgramHandle,
        uint,
        nuint,
        void*,
        nuint*,
        int>(IcdDispatchWindowsGetProgramInfo pfn) =>
        (delegate* unmanaged<ProgramHandle, uint, nuint, void*, nuint*, int>)pfn.Pointer;
}
