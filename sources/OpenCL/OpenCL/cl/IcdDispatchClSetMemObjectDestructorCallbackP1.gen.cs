// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenCL headers and corresponding dependencies.
// Original source is Copyright 2013-2026 The Khronos Group Inc. Licensed under the Apache 2.0 license.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenCL;

[NativeName("_cl_icd_dispatch_clSetMemObjectDestructorCallback_p1")]
public readonly unsafe struct IcdDispatchClSetMemObjectDestructorCallbackP1 : IDisposable
{
    private readonly void* Pointer;
    public delegate* unmanaged<MemHandle, void*, void> Handle =>
        (delegate* unmanaged<MemHandle, void*, void>)Pointer;

    public IcdDispatchClSetMemObjectDestructorCallbackP1(
        delegate* unmanaged<MemHandle, void*, void> ptr
    ) => Pointer = ptr;

    public IcdDispatchClSetMemObjectDestructorCallbackP1(
        IcdDispatchClSetMemObjectDestructorCallbackP1Delegate proc
    ) => Pointer = SilkMarshal.DelegateToPtr(proc);

    public void Dispose() => SilkMarshal.Free(Pointer);

    public static implicit operator IcdDispatchClSetMemObjectDestructorCallbackP1(
        delegate* unmanaged<MemHandle, void*, void> pfn
    ) => new(pfn);

    public static implicit operator delegate* unmanaged<MemHandle, void*, void>(
        IcdDispatchClSetMemObjectDestructorCallbackP1 pfn
    ) => (delegate* unmanaged<MemHandle, void*, void>)pfn.Pointer;
}
