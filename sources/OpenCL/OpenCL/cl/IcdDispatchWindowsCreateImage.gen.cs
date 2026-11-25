// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenCL headers and corresponding dependencies.
// Original source is Copyright 2013-2026 The Khronos Group Inc. Licensed under the Apache 2.0 license.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenCL;

[NativeName("_cl_icd_dispatch_windows_clCreateImage")]
public readonly unsafe struct IcdDispatchWindowsCreateImage : IDisposable
{
    private readonly void* Pointer;
    public delegate* unmanaged<
        ContextHandle,
        ulong,
        ImageFormat*,
        ImageDesc*,
        void*,
        int*,
        MemHandle> Handle =>
        (delegate* unmanaged<
            ContextHandle,
            ulong,
            ImageFormat*,
            ImageDesc*,
            void*,
            int*,
            MemHandle>)Pointer;

    public IcdDispatchWindowsCreateImage(
        delegate* unmanaged<
            ContextHandle,
            ulong,
            ImageFormat*,
            ImageDesc*,
            void*,
            int*,
            MemHandle> ptr
    ) => Pointer = ptr;

    public IcdDispatchWindowsCreateImage(IcdDispatchWindowsCreateImageDelegate proc) =>
        Pointer = SilkMarshal.DelegateToPtr(proc);

    public void Dispose() => SilkMarshal.Free(Pointer);

    public static implicit operator IcdDispatchWindowsCreateImage(
        delegate* unmanaged<
            ContextHandle,
            ulong,
            ImageFormat*,
            ImageDesc*,
            void*,
            int*,
            MemHandle> pfn
    ) => new(pfn);

    public static implicit operator delegate* unmanaged<
        ContextHandle,
        ulong,
        ImageFormat*,
        ImageDesc*,
        void*,
        int*,
        MemHandle>(IcdDispatchWindowsCreateImage pfn) =>
        (delegate* unmanaged<
            ContextHandle,
            ulong,
            ImageFormat*,
            ImageDesc*,
            void*,
            int*,
            MemHandle>)
            pfn.Pointer;
}
