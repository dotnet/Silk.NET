// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("PFN_vkGetInstanceProcAddrLUNARG")]
public readonly unsafe struct GetInstanceProcAddrLUNARG : IDisposable
{
    private readonly void* Pointer;
    public delegate* unmanaged<InstanceHandle, sbyte*, GetInstanceProcAddrLunargP2> Handle =>
        (delegate* unmanaged<InstanceHandle, sbyte*, GetInstanceProcAddrLunargP2>)Pointer;

    public GetInstanceProcAddrLUNARG(
        delegate* unmanaged<InstanceHandle, sbyte*, GetInstanceProcAddrLunargP2> ptr
    ) => Pointer = ptr;

    public GetInstanceProcAddrLUNARG(GetInstanceProcAddrLUNARGDelegate proc) =>
        Pointer = SilkMarshal.DelegateToPtr(proc);

    public void Dispose() => SilkMarshal.Free(Pointer);

    public static implicit operator GetInstanceProcAddrLUNARG(
        delegate* unmanaged<InstanceHandle, sbyte*, GetInstanceProcAddrLunargP2> pfn
    ) => new(pfn);

    public static implicit operator delegate* unmanaged<
        InstanceHandle,
        sbyte*,
        GetInstanceProcAddrLunargP2>(GetInstanceProcAddrLUNARG pfn) =>
        (delegate* unmanaged<InstanceHandle, sbyte*, GetInstanceProcAddrLunargP2>)pfn.Pointer;
}
