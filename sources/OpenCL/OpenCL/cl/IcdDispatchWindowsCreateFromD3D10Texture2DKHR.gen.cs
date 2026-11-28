// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenCL headers and corresponding dependencies.
// Original source is Copyright 2013-2026 The Khronos Group Inc. Licensed under the Apache 2.0 license.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenCL;

[NativeName("_cl_icd_dispatch_windows_clCreateFromD3D10Texture2DKHR")]
public readonly unsafe struct IcdDispatchWindowsCreateFromD3D10Texture2DKHR : IDisposable
{
    private readonly void* Pointer;

    [UnscopedRef]
    public ref delegate* unmanaged<ContextHandle, ulong, void*, uint, int*, MemHandle> Handle =>
        ref *(delegate* unmanaged<ContextHandle, ulong, void*, uint, int*, MemHandle>*)Pointer;

    public IcdDispatchWindowsCreateFromD3D10Texture2DKHR(
        delegate* unmanaged<ContextHandle, ulong, void*, uint, int*, MemHandle> ptr
    ) => Pointer = ptr;

    public IcdDispatchWindowsCreateFromD3D10Texture2DKHR(
        IcdDispatchWindowsCreateFromD3D10Texture2DKHRDelegate proc
    ) => Pointer = SilkMarshal.DelegateToPtr(proc);

    public void Dispose() => SilkMarshal.Free(Pointer);

    public static implicit operator IcdDispatchWindowsCreateFromD3D10Texture2DKHR(
        delegate* unmanaged<ContextHandle, ulong, void*, uint, int*, MemHandle> pfn
    ) => new(pfn);

    public static implicit operator delegate* unmanaged<
        ContextHandle,
        ulong,
        void*,
        uint,
        int*,
        MemHandle>(IcdDispatchWindowsCreateFromD3D10Texture2DKHR pfn) =>
        (delegate* unmanaged<ContextHandle, ulong, void*, uint, int*, MemHandle>)pfn.Pointer;
}
