// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenCL headers and corresponding dependencies.
// Original source is Copyright 2013-2026 The Khronos Group Inc. Licensed under the Apache 2.0 license.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenCL;

[NativeName("_cl_icd_dispatch_clGetSupportedImageFormats")]
public readonly unsafe struct IcdDispatchGetSupportedImageFormats : IDisposable
{
    private readonly void* Pointer;

    [UnscopedRef]
    public ref delegate* unmanaged<
        ContextHandle,
        ulong,
        uint,
        uint,
        ImageFormat*,
        uint*,
        int> Handle =>
        ref *(delegate* unmanaged<
            ContextHandle,
            ulong,
            uint,
            uint,
            ImageFormat*,
            uint*,
            int>*)Pointer;

    public IcdDispatchGetSupportedImageFormats(
        delegate* unmanaged<ContextHandle, ulong, uint, uint, ImageFormat*, uint*, int> ptr
    ) => Pointer = ptr;

    public IcdDispatchGetSupportedImageFormats(IcdDispatchGetSupportedImageFormatsDelegate proc) =>
        Pointer = SilkMarshal.DelegateToPtr(proc);

    public void Dispose() => SilkMarshal.Free(Pointer);

    public static implicit operator IcdDispatchGetSupportedImageFormats(
        delegate* unmanaged<ContextHandle, ulong, uint, uint, ImageFormat*, uint*, int> pfn
    ) => new(pfn);

    public static implicit operator delegate* unmanaged<
        ContextHandle,
        ulong,
        uint,
        uint,
        ImageFormat*,
        uint*,
        int>(IcdDispatchGetSupportedImageFormats pfn) =>
        (delegate* unmanaged<ContextHandle, ulong, uint, uint, ImageFormat*, uint*, int>)
            pfn.Pointer;
}
