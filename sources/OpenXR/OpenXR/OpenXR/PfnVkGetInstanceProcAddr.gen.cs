// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("PFN_vkGetInstanceProcAddr")]
[SupportedApiProfile("openxr")]
public readonly unsafe struct PfnVkGetInstanceProcAddr : IDisposable
{
    [SupportedApiProfile("openxr")]
    private readonly void* Pointer;

    [SupportedApiProfile("openxr")]
    public delegate* unmanaged<VkInstanceHandle, sbyte*, PfnVkGetInstanceProcAddrP2> Handle =>
        (delegate* unmanaged<VkInstanceHandle, sbyte*, PfnVkGetInstanceProcAddrP2>)Pointer;

    [SupportedApiProfile("openxr")]
    public PfnVkGetInstanceProcAddr(
        delegate* unmanaged<VkInstanceHandle, sbyte*, PfnVkGetInstanceProcAddrP2> ptr
    ) => Pointer = ptr;

    [SupportedApiProfile("openxr")]
    public PfnVkGetInstanceProcAddr(PfnVkGetInstanceProcAddrDelegate proc) =>
        Pointer = SilkMarshal.DelegateToPtr(proc);

    [SupportedApiProfile("openxr")]
    public void Dispose() => SilkMarshal.Free(Pointer);

    [SupportedApiProfile("openxr")]
    public static implicit operator PfnVkGetInstanceProcAddr(
        delegate* unmanaged<VkInstanceHandle, sbyte*, PfnVkGetInstanceProcAddrP2> pfn
    ) => new(pfn);

    [SupportedApiProfile("openxr")]
    public static implicit operator delegate* unmanaged<
        VkInstanceHandle,
        sbyte*,
        PfnVkGetInstanceProcAddrP2>(PfnVkGetInstanceProcAddr pfn) =>
        (delegate* unmanaged<VkInstanceHandle, sbyte*, PfnVkGetInstanceProcAddrP2>)pfn.Pointer;
}
