// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenCL headers and corresponding dependencies.
// Original source is Copyright 2013-2026 The Khronos Group Inc. Licensed under the Apache 2.0 license.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenCL;

[NativeName("_cl_icd_dispatch_clCreateContextFromType")]
public readonly unsafe struct IcdDispatchCreateContextFromType : IDisposable
{
    private readonly void* Pointer;

    [UnscopedRef]
    public ref delegate* unmanaged<
        nint*,
        ulong,
        IcdDispatchClCreateContextFromTypeP2,
        void*,
        int*,
        ContextHandle> Handle =>
        ref *(delegate* unmanaged<
            nint*,
            ulong,
            IcdDispatchClCreateContextFromTypeP2,
            void*,
            int*,
            ContextHandle>*)Pointer;

    public IcdDispatchCreateContextFromType(
        delegate* unmanaged<
            nint*,
            ulong,
            IcdDispatchClCreateContextFromTypeP2,
            void*,
            int*,
            ContextHandle> ptr
    ) => Pointer = ptr;

    public IcdDispatchCreateContextFromType(IcdDispatchCreateContextFromTypeDelegate proc) =>
        Pointer = SilkMarshal.DelegateToPtr(proc);

    public void Dispose() => SilkMarshal.Free(Pointer);

    public static implicit operator IcdDispatchCreateContextFromType(
        delegate* unmanaged<
            nint*,
            ulong,
            IcdDispatchClCreateContextFromTypeP2,
            void*,
            int*,
            ContextHandle> pfn
    ) => new(pfn);

    public static implicit operator delegate* unmanaged<
        nint*,
        ulong,
        IcdDispatchClCreateContextFromTypeP2,
        void*,
        int*,
        ContextHandle>(IcdDispatchCreateContextFromType pfn) =>
        (delegate* unmanaged<
            nint*,
            ulong,
            IcdDispatchClCreateContextFromTypeP2,
            void*,
            int*,
            ContextHandle>)
            pfn.Pointer;
}
