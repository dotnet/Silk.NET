// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenCL headers and corresponding dependencies.
// Original source is Copyright 2013-2026 The Khronos Group Inc. Licensed under the Apache 2.0 license.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenCL;

[NativeName("clEnqueueNativeKernel_user_func")]
public readonly unsafe struct EnqueueNativeKernelUserFunc : IDisposable
{
    private readonly void* Pointer;
    public delegate* unmanaged<void*, void> Handle => (delegate* unmanaged<void*, void>)Pointer;

    public EnqueueNativeKernelUserFunc(delegate* unmanaged<void*, void> ptr) => Pointer = ptr;

    public EnqueueNativeKernelUserFunc(EnqueueNativeKernelUserFuncDelegate proc) =>
        Pointer = SilkMarshal.DelegateToPtr(proc);

    public void Dispose() => SilkMarshal.Free(Pointer);

    public static implicit operator EnqueueNativeKernelUserFunc(
        delegate* unmanaged<void*, void> pfn
    ) => new(pfn);

    public static implicit operator delegate* unmanaged<void*, void>(
        EnqueueNativeKernelUserFunc pfn
    ) => (delegate* unmanaged<void*, void>)pfn.Pointer;
}
