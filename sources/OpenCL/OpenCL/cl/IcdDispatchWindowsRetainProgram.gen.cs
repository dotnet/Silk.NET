// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenCL headers and corresponding dependencies.
// Original source is Copyright 2013-2026 The Khronos Group Inc. Licensed under the Apache 2.0 license.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenCL;

[NativeName("_cl_icd_dispatch_windows_clRetainProgram")]
public readonly unsafe struct IcdDispatchWindowsRetainProgram : IDisposable
{
    private readonly void* Pointer;

    [UnscopedRef]
    public ref delegate* unmanaged<ProgramHandle, int> Handle =>
        ref *(delegate* unmanaged<ProgramHandle, int>*)Pointer;

    public IcdDispatchWindowsRetainProgram(delegate* unmanaged<ProgramHandle, int> ptr) =>
        Pointer = ptr;

    public IcdDispatchWindowsRetainProgram(IcdDispatchWindowsRetainProgramDelegate proc) =>
        Pointer = SilkMarshal.DelegateToPtr(proc);

    public void Dispose() => SilkMarshal.Free(Pointer);

    public static implicit operator IcdDispatchWindowsRetainProgram(
        delegate* unmanaged<ProgramHandle, int> pfn
    ) => new(pfn);

    public static implicit operator delegate* unmanaged<ProgramHandle, int>(
        IcdDispatchWindowsRetainProgram pfn
    ) => (delegate* unmanaged<ProgramHandle, int>)pfn.Pointer;
}
