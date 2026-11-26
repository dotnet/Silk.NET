// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("PFN_vkSetInstanceLoaderData")]
[SupportedApiProfile("vulkan")]
public readonly unsafe struct SetInstanceLoaderData : IDisposable
{
    [SupportedApiProfile("vulkan")]
    private readonly void* Pointer;

    [UnscopedRef]
    [SupportedApiProfile("vulkan")]
    public ref delegate* unmanaged<InstanceHandle, void*, Result> Handle =>
        ref *(delegate* unmanaged<InstanceHandle, void*, Result>*)Pointer;

    [SupportedApiProfile("vulkan")]
    public SetInstanceLoaderData(delegate* unmanaged<InstanceHandle, void*, Result> ptr) =>
        Pointer = ptr;

    [SupportedApiProfile("vulkan")]
    public SetInstanceLoaderData(SetInstanceLoaderDataDelegate proc) =>
        Pointer = SilkMarshal.DelegateToPtr(proc);

    [SupportedApiProfile("vulkan")]
    public void Dispose() => SilkMarshal.Free(Pointer);

    [SupportedApiProfile("vulkan")]
    public static implicit operator SetInstanceLoaderData(
        delegate* unmanaged<InstanceHandle, void*, Result> pfn
    ) => new(pfn);

    [SupportedApiProfile("vulkan")]
    public static implicit operator delegate* unmanaged<InstanceHandle, void*, Result>(
        SetInstanceLoaderData pfn
    ) => (delegate* unmanaged<InstanceHandle, void*, Result>)pfn.Pointer;
}
