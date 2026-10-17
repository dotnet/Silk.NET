// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("PFN_vkGetInstanceProcAddr")]
public readonly unsafe struct PfnVkGetInstanceProcAddr : IDisposable
{
    private readonly void* Pointer;
    public delegate* unmanaged<VkInstanceHandle, sbyte*, PfnVkGetInstanceProcAddrP2> Handle =>
        (delegate* unmanaged<VkInstanceHandle, sbyte*, PfnVkGetInstanceProcAddrP2>)Pointer;

    public PfnVkGetInstanceProcAddr(
        delegate* unmanaged<VkInstanceHandle, sbyte*, PfnVkGetInstanceProcAddrP2> ptr
    ) => Pointer = ptr;

    public PfnVkGetInstanceProcAddr(PfnVkGetInstanceProcAddrDelegate proc) =>
        Pointer = SilkMarshal.DelegateToPtr(proc);

    public void Dispose() => SilkMarshal.Free(Pointer);

    public static implicit operator PfnVkGetInstanceProcAddr(
        delegate* unmanaged<VkInstanceHandle, sbyte*, PfnVkGetInstanceProcAddrP2> pfn
    ) => new(pfn);

    public static implicit operator delegate* unmanaged<
        VkInstanceHandle,
        sbyte*,
        PfnVkGetInstanceProcAddrP2>(PfnVkGetInstanceProcAddr pfn) =>
        (delegate* unmanaged<VkInstanceHandle, sbyte*, PfnVkGetInstanceProcAddrP2>)pfn.Pointer;
}
