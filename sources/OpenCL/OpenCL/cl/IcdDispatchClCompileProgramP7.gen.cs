// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenCL headers and corresponding dependencies.
// Original source is Copyright 2013-2026 The Khronos Group Inc. Licensed under the Apache 2.0 license.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenCL;

[NativeName("_cl_icd_dispatch_clCompileProgram_p7")]
public readonly unsafe struct IcdDispatchClCompileProgramP7 : IDisposable
{
    private readonly void* Pointer;
    public delegate* unmanaged<ProgramHandle, void*, void> Handle =>
        (delegate* unmanaged<ProgramHandle, void*, void>)Pointer;

    public IcdDispatchClCompileProgramP7(delegate* unmanaged<ProgramHandle, void*, void> ptr) =>
        Pointer = ptr;

    public IcdDispatchClCompileProgramP7(IcdDispatchClCompileProgramP7Delegate proc) =>
        Pointer = SilkMarshal.DelegateToPtr(proc);

    public void Dispose() => SilkMarshal.Free(Pointer);

    public static implicit operator IcdDispatchClCompileProgramP7(
        delegate* unmanaged<ProgramHandle, void*, void> pfn
    ) => new(pfn);

    public static implicit operator delegate* unmanaged<ProgramHandle, void*, void>(
        IcdDispatchClCompileProgramP7 pfn
    ) => (delegate* unmanaged<ProgramHandle, void*, void>)pfn.Pointer;
}
