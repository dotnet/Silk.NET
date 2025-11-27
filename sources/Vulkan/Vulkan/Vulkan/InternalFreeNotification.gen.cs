// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

public readonly unsafe struct InternalFreeNotification : IDisposable
{
    private readonly void* Pointer;
    public delegate* unmanaged<
        void*,
        nuint,
        InternalAllocationType,
        SystemAllocationScope,
        void> Handle =>
        (delegate* unmanaged<
            void*,
            nuint,
            InternalAllocationType,
            SystemAllocationScope,
            void>)Pointer;

    public InternalFreeNotification(
        delegate* unmanaged<void*, nuint, InternalAllocationType, SystemAllocationScope, void> ptr
    ) => Pointer = ptr;

    public InternalFreeNotification(InternalFreeNotificationDelegate proc) =>
        Pointer = SilkMarshal.DelegateToPtr(proc);

    public void Dispose() => SilkMarshal.Free(Pointer);

    public static implicit operator InternalFreeNotification(
        delegate* unmanaged<void*, nuint, InternalAllocationType, SystemAllocationScope, void> pfn
    ) => new(pfn);

    public static implicit operator delegate* unmanaged<
        void*,
        nuint,
        InternalAllocationType,
        SystemAllocationScope,
        void>(InternalFreeNotification pfn) =>
        (delegate* unmanaged<void*, nuint, InternalAllocationType, SystemAllocationScope, void>)
            pfn.Pointer;
}
