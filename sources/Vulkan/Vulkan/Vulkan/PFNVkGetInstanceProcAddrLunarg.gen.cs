// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

public readonly unsafe struct PFNVkGetInstanceProcAddrLunarg : IDisposable
{
    private readonly void* Pointer;
    public delegate* unmanaged<InstanceTHandle, sbyte*, PFNVkGetInstanceProcAddrLunargP2> Handle =>
        (delegate* unmanaged<InstanceTHandle, sbyte*, PFNVkGetInstanceProcAddrLunargP2>)Pointer;

    public PFNVkGetInstanceProcAddrLunarg(
        delegate* unmanaged<InstanceTHandle, sbyte*, PFNVkGetInstanceProcAddrLunargP2> ptr
    ) => Pointer = ptr;

    public PFNVkGetInstanceProcAddrLunarg(PFNVkGetInstanceProcAddrLunargDelegate proc) =>
        Pointer = SilkMarshal.DelegateToPtr(proc);

    public void Dispose() => SilkMarshal.Free(Pointer);

    public static implicit operator PFNVkGetInstanceProcAddrLunarg(
        delegate* unmanaged<InstanceTHandle, sbyte*, PFNVkGetInstanceProcAddrLunargP2> pfn
    ) => new(pfn);

    public static implicit operator delegate* unmanaged<
        InstanceTHandle,
        sbyte*,
        PFNVkGetInstanceProcAddrLunargP2>(PFNVkGetInstanceProcAddrLunarg pfn) =>
        (delegate* unmanaged<InstanceTHandle, sbyte*, PFNVkGetInstanceProcAddrLunargP2>)pfn.Pointer;
}
