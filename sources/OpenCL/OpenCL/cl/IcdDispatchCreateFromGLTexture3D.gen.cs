// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenCL headers and corresponding dependencies.
// Original source is Copyright 2013-2026 The Khronos Group Inc. Licensed under the Apache 2.0 license.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenCL;

[NativeName("_cl_icd_dispatch_clCreateFromGLTexture3D")]
public readonly unsafe struct IcdDispatchCreateFromGLTexture3D : IDisposable
{
    private readonly void* Pointer;

    [UnscopedRef]
    public ref delegate* unmanaged<ContextHandle, ulong, uint, int, uint, int*, MemHandle> Handle =>
        ref *(delegate* unmanaged<ContextHandle, ulong, uint, int, uint, int*, MemHandle>*)Pointer;

    public IcdDispatchCreateFromGLTexture3D(
        delegate* unmanaged<ContextHandle, ulong, uint, int, uint, int*, MemHandle> ptr
    ) => Pointer = ptr;

    public IcdDispatchCreateFromGLTexture3D(IcdDispatchCreateFromGLTexture3DDelegate proc) =>
        Pointer = SilkMarshal.DelegateToPtr(proc);

    public void Dispose() => SilkMarshal.Free(Pointer);

    public static implicit operator IcdDispatchCreateFromGLTexture3D(
        delegate* unmanaged<ContextHandle, ulong, uint, int, uint, int*, MemHandle> pfn
    ) => new(pfn);

    public static implicit operator delegate* unmanaged<
        ContextHandle,
        ulong,
        uint,
        int,
        uint,
        int*,
        MemHandle>(IcdDispatchCreateFromGLTexture3D pfn) =>
        (delegate* unmanaged<ContextHandle, ulong, uint, int, uint, int*, MemHandle>)pfn.Pointer;
}
