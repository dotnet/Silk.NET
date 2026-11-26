// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenCL headers and corresponding dependencies.
// Original source is Copyright 2013-2026 The Khronos Group Inc. Licensed under the Apache 2.0 license.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenCL;

[NativeName("_cl_icd_dispatch_clEnqueueNativeKernel")]
public readonly unsafe struct IcdDispatchEnqueueNativeKernel : IDisposable
{
    private readonly void* Pointer;

    [UnscopedRef]
    public ref delegate* unmanaged<
        CommandQueueHandle,
        IcdDispatchClEnqueueNativeKernelP1,
        void*,
        nuint,
        uint,
        MemHandle*,
        void**,
        uint,
        EventHandle*,
        EventHandle*,
        int> Handle =>
        ref *(delegate* unmanaged<
            CommandQueueHandle,
            IcdDispatchClEnqueueNativeKernelP1,
            void*,
            nuint,
            uint,
            MemHandle*,
            void**,
            uint,
            EventHandle*,
            EventHandle*,
            int>*)Pointer;

    public IcdDispatchEnqueueNativeKernel(
        delegate* unmanaged<
            CommandQueueHandle,
            IcdDispatchClEnqueueNativeKernelP1,
            void*,
            nuint,
            uint,
            MemHandle*,
            void**,
            uint,
            EventHandle*,
            EventHandle*,
            int> ptr
    ) => Pointer = ptr;

    public IcdDispatchEnqueueNativeKernel(IcdDispatchEnqueueNativeKernelDelegate proc) =>
        Pointer = SilkMarshal.DelegateToPtr(proc);

    public void Dispose() => SilkMarshal.Free(Pointer);

    public static implicit operator IcdDispatchEnqueueNativeKernel(
        delegate* unmanaged<
            CommandQueueHandle,
            IcdDispatchClEnqueueNativeKernelP1,
            void*,
            nuint,
            uint,
            MemHandle*,
            void**,
            uint,
            EventHandle*,
            EventHandle*,
            int> pfn
    ) => new(pfn);

    public static implicit operator delegate* unmanaged<
        CommandQueueHandle,
        IcdDispatchClEnqueueNativeKernelP1,
        void*,
        nuint,
        uint,
        MemHandle*,
        void**,
        uint,
        EventHandle*,
        EventHandle*,
        int>(IcdDispatchEnqueueNativeKernel pfn) =>
        (delegate* unmanaged<
            CommandQueueHandle,
            IcdDispatchClEnqueueNativeKernelP1,
            void*,
            nuint,
            uint,
            MemHandle*,
            void**,
            uint,
            EventHandle*,
            EventHandle*,
            int>)
            pfn.Pointer;
}
