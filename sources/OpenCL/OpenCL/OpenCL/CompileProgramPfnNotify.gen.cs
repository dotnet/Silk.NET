// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenCL headers and corresponding dependencies.
// Original source is Copyright 2013-2026 The Khronos Group Inc. Licensed under the Apache 2.0 license.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenCL;

[NativeName("clCompileProgram_pfn_notify")]
public readonly unsafe struct CompileProgramPfnNotify : IDisposable
{
    private readonly void* Pointer;
    public delegate* unmanaged<ProgramHandle, void*, void> Handle =>
        (delegate* unmanaged<ProgramHandle, void*, void>)Pointer;

    public CompileProgramPfnNotify(delegate* unmanaged<ProgramHandle, void*, void> ptr) =>
        Pointer = ptr;

    public CompileProgramPfnNotify(CompileProgramPfnNotifyDelegate proc) =>
        Pointer = SilkMarshal.DelegateToPtr(proc);

    public void Dispose() => SilkMarshal.Free(Pointer);

    public static implicit operator CompileProgramPfnNotify(
        delegate* unmanaged<ProgramHandle, void*, void> pfn
    ) => new(pfn);

    public static implicit operator delegate* unmanaged<ProgramHandle, void*, void>(
        CompileProgramPfnNotify pfn
    ) => (delegate* unmanaged<ProgramHandle, void*, void>)pfn.Pointer;
}
