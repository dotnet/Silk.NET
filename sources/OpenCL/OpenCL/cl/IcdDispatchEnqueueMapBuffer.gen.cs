// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenCL headers and corresponding dependencies.
// Original source is Copyright 2013-2026 The Khronos Group Inc. Licensed under the Apache 2.0 license.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenCL;

[NativeName("_cl_icd_dispatch_clEnqueueMapBuffer")]
public readonly unsafe struct IcdDispatchEnqueueMapBuffer : IDisposable
{
    private readonly void* Pointer;
    public delegate* unmanaged<
        CommandQueueHandle,
        MemHandle,
        uint,
        ulong,
        nuint,
        nuint,
        uint,
        EventHandle*,
        EventHandle*,
        int*,
        void*> Handle =>
        (delegate* unmanaged<
            CommandQueueHandle,
            MemHandle,
            uint,
            ulong,
            nuint,
            nuint,
            uint,
            EventHandle*,
            EventHandle*,
            int*,
            void*>)Pointer;

    public IcdDispatchEnqueueMapBuffer(
        delegate* unmanaged<
            CommandQueueHandle,
            MemHandle,
            uint,
            ulong,
            nuint,
            nuint,
            uint,
            EventHandle*,
            EventHandle*,
            int*,
            void*> ptr
    ) => Pointer = ptr;

    public IcdDispatchEnqueueMapBuffer(IcdDispatchEnqueueMapBufferDelegate proc) =>
        Pointer = SilkMarshal.DelegateToPtr(proc);

    public void Dispose() => SilkMarshal.Free(Pointer);

    public static implicit operator IcdDispatchEnqueueMapBuffer(
        delegate* unmanaged<
            CommandQueueHandle,
            MemHandle,
            uint,
            ulong,
            nuint,
            nuint,
            uint,
            EventHandle*,
            EventHandle*,
            int*,
            void*> pfn
    ) => new(pfn);

    public static implicit operator delegate* unmanaged<
        CommandQueueHandle,
        MemHandle,
        uint,
        ulong,
        nuint,
        nuint,
        uint,
        EventHandle*,
        EventHandle*,
        int*,
        void*>(IcdDispatchEnqueueMapBuffer pfn) =>
        (delegate* unmanaged<
            CommandQueueHandle,
            MemHandle,
            uint,
            ulong,
            nuint,
            nuint,
            uint,
            EventHandle*,
            EventHandle*,
            int*,
            void*>)
            pfn.Pointer;
}
