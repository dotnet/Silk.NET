// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[Transformed]
public readonly unsafe struct PFNVkGetInstanceProcAddrLunargP2 : IDisposable
{
    private readonly void* Pointer;
    public delegate* unmanaged<void> Handle => (delegate* unmanaged<void>)Pointer;

    public PFNVkGetInstanceProcAddrLunargP2(delegate* unmanaged<void> ptr) => Pointer = ptr;

    public PFNVkGetInstanceProcAddrLunargP2(PFNVkGetInstanceProcAddrLunargP2Delegate proc) =>
        Pointer = SilkMarshal.DelegateToPtr(proc);

    public void Dispose() => SilkMarshal.Free(Pointer);

    public static implicit operator PFNVkGetInstanceProcAddrLunargP2(
        delegate* unmanaged<void> pfn
    ) => new(pfn);

    public static implicit operator delegate* unmanaged<void>(
        PFNVkGetInstanceProcAddrLunargP2 pfn
    ) => (delegate* unmanaged<void>)pfn.Pointer;
}
