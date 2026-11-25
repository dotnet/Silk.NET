// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenCL headers and corresponding dependencies.
// Original source is Copyright 2013-2026 The Khronos Group Inc. Licensed under the Apache 2.0 license.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenCL;

[NativeName("_cl_icd_dispatch_clSetMemObjectDestructorCallback")]
public readonly unsafe struct IcdDispatchSetMemObjectDestructorCallback : IDisposable
{
    private readonly void* Pointer;
    public delegate* unmanaged<
        MemHandle,
        IcdDispatchClSetMemObjectDestructorCallbackP1,
        void*,
        int> Handle =>
        (delegate* unmanaged<
            MemHandle,
            IcdDispatchClSetMemObjectDestructorCallbackP1,
            void*,
            int>)Pointer;

    public IcdDispatchSetMemObjectDestructorCallback(
        delegate* unmanaged<
            MemHandle,
            IcdDispatchClSetMemObjectDestructorCallbackP1,
            void*,
            int> ptr
    ) => Pointer = ptr;

    public IcdDispatchSetMemObjectDestructorCallback(
        IcdDispatchSetMemObjectDestructorCallbackDelegate proc
    ) => Pointer = SilkMarshal.DelegateToPtr(proc);

    public void Dispose() => SilkMarshal.Free(Pointer);

    public static implicit operator IcdDispatchSetMemObjectDestructorCallback(
        delegate* unmanaged<
            MemHandle,
            IcdDispatchClSetMemObjectDestructorCallbackP1,
            void*,
            int> pfn
    ) => new(pfn);

    public static implicit operator delegate* unmanaged<
        MemHandle,
        IcdDispatchClSetMemObjectDestructorCallbackP1,
        void*,
        int>(IcdDispatchSetMemObjectDestructorCallback pfn) =>
        (delegate* unmanaged<MemHandle, IcdDispatchClSetMemObjectDestructorCallbackP1, void*, int>)
            pfn.Pointer;
}
