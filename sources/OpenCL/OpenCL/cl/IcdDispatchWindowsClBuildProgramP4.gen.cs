// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenCL headers and corresponding dependencies.
// Original source is Copyright 2013-2026 The Khronos Group Inc. Licensed under the Apache 2.0 license.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenCL;

[NativeName("_cl_icd_dispatch_windows_clBuildProgram_p4")]
public readonly unsafe struct IcdDispatchWindowsClBuildProgramP4 : IDisposable
{
    private readonly void* Pointer;

    [UnscopedRef]
    public ref delegate* unmanaged<ProgramHandle, void*, void> Handle =>
        ref *(delegate* unmanaged<ProgramHandle, void*, void>*)Pointer;

    public IcdDispatchWindowsClBuildProgramP4(
        delegate* unmanaged<ProgramHandle, void*, void> ptr
    ) => Pointer = ptr;

    public IcdDispatchWindowsClBuildProgramP4(IcdDispatchWindowsClBuildProgramP4Delegate proc) =>
        Pointer = SilkMarshal.DelegateToPtr(proc);

    public void Dispose() => SilkMarshal.Free(Pointer);

    public static implicit operator IcdDispatchWindowsClBuildProgramP4(
        delegate* unmanaged<ProgramHandle, void*, void> pfn
    ) => new(pfn);

    public static implicit operator delegate* unmanaged<ProgramHandle, void*, void>(
        IcdDispatchWindowsClBuildProgramP4 pfn
    ) => (delegate* unmanaged<ProgramHandle, void*, void>)pfn.Pointer;
}
