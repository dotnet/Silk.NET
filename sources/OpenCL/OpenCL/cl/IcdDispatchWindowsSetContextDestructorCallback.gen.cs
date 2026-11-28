// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenCL headers and corresponding dependencies.
// Original source is Copyright 2013-2026 The Khronos Group Inc. Licensed under the Apache 2.0 license.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenCL;

[NativeName("_cl_icd_dispatch_windows_clSetContextDestructorCallback")]
public readonly unsafe struct IcdDispatchWindowsSetContextDestructorCallback : IDisposable
{
    private readonly void* Pointer;

    [UnscopedRef]
    public ref delegate* unmanaged<
        ContextHandle,
        IcdDispatchWindowsClSetContextDestructorCallbackP1,
        void*,
        int> Handle =>
        ref *(delegate* unmanaged<
            ContextHandle,
            IcdDispatchWindowsClSetContextDestructorCallbackP1,
            void*,
            int>*)Pointer;

    public IcdDispatchWindowsSetContextDestructorCallback(
        delegate* unmanaged<
            ContextHandle,
            IcdDispatchWindowsClSetContextDestructorCallbackP1,
            void*,
            int> ptr
    ) => Pointer = ptr;

    public IcdDispatchWindowsSetContextDestructorCallback(
        IcdDispatchWindowsSetContextDestructorCallbackDelegate proc
    ) => Pointer = SilkMarshal.DelegateToPtr(proc);

    public void Dispose() => SilkMarshal.Free(Pointer);

    public static implicit operator IcdDispatchWindowsSetContextDestructorCallback(
        delegate* unmanaged<
            ContextHandle,
            IcdDispatchWindowsClSetContextDestructorCallbackP1,
            void*,
            int> pfn
    ) => new(pfn);

    public static implicit operator delegate* unmanaged<
        ContextHandle,
        IcdDispatchWindowsClSetContextDestructorCallbackP1,
        void*,
        int>(IcdDispatchWindowsSetContextDestructorCallback pfn) =>
        (delegate* unmanaged<
            ContextHandle,
            IcdDispatchWindowsClSetContextDestructorCallbackP1,
            void*,
            int>)
            pfn.Pointer;
}
