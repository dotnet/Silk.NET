// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenCL headers and corresponding dependencies.
// Original source is Copyright 2013-2026 The Khronos Group Inc. Licensed under the Apache 2.0 license.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenCL;

[NativeName("_cl_icd_dispatch_windows_clCreateContextFromType_p2")]
public readonly unsafe struct IcdDispatchWindowsClCreateContextFromTypeP2 : IDisposable
{
    private readonly void* Pointer;
    public delegate* unmanaged<sbyte*, void*, nuint, void*, void> Handle =>
        (delegate* unmanaged<sbyte*, void*, nuint, void*, void>)Pointer;

    public IcdDispatchWindowsClCreateContextFromTypeP2(
        delegate* unmanaged<sbyte*, void*, nuint, void*, void> ptr
    ) => Pointer = ptr;

    public IcdDispatchWindowsClCreateContextFromTypeP2(
        IcdDispatchWindowsClCreateContextFromTypeP2Delegate proc
    ) => Pointer = SilkMarshal.DelegateToPtr(proc);

    public void Dispose() => SilkMarshal.Free(Pointer);

    public static implicit operator IcdDispatchWindowsClCreateContextFromTypeP2(
        delegate* unmanaged<sbyte*, void*, nuint, void*, void> pfn
    ) => new(pfn);

    public static implicit operator delegate* unmanaged<sbyte*, void*, nuint, void*, void>(
        IcdDispatchWindowsClCreateContextFromTypeP2 pfn
    ) => (delegate* unmanaged<sbyte*, void*, nuint, void*, void>)pfn.Pointer;
}
