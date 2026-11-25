// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenCL headers and corresponding dependencies.
// Original source is Copyright 2013-2026 The Khronos Group Inc. Licensed under the Apache 2.0 license.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenCL;

[NativeName("_cl_icd_dispatch_windows_clGetGLTextureInfo")]
public readonly unsafe struct IcdDispatchWindowsGetGLTextureInfo : IDisposable
{
    private readonly void* Pointer;
    public delegate* unmanaged<MemHandle, uint, nuint, void*, nuint*, int> Handle =>
        (delegate* unmanaged<MemHandle, uint, nuint, void*, nuint*, int>)Pointer;

    public IcdDispatchWindowsGetGLTextureInfo(
        delegate* unmanaged<MemHandle, uint, nuint, void*, nuint*, int> ptr
    ) => Pointer = ptr;

    public IcdDispatchWindowsGetGLTextureInfo(IcdDispatchWindowsGetGLTextureInfoDelegate proc) =>
        Pointer = SilkMarshal.DelegateToPtr(proc);

    public void Dispose() => SilkMarshal.Free(Pointer);

    public static implicit operator IcdDispatchWindowsGetGLTextureInfo(
        delegate* unmanaged<MemHandle, uint, nuint, void*, nuint*, int> pfn
    ) => new(pfn);

    public static implicit operator delegate* unmanaged<MemHandle, uint, nuint, void*, nuint*, int>(
        IcdDispatchWindowsGetGLTextureInfo pfn
    ) => (delegate* unmanaged<MemHandle, uint, nuint, void*, nuint*, int>)pfn.Pointer;
}
