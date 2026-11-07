// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkAllocationCallbacks")]
public unsafe partial struct AllocationCallbacks
{
    [NativeName("pUserData")]
    public void* PUserData;

    [NativeName("pfnAllocation")]
    public AllocationFunction PfnAllocation;

    [NativeName("pfnReallocation")]
    public ReallocationFunction PfnReallocation;

    [NativeName("pfnFree")]
    public FreeFunction PfnFree;

    [NativeName("pfnInternalAllocation")]
    public InternalAllocationNotification PfnInternalAllocation;

    [NativeName("pfnInternalFree")]
    public InternalFreeNotification PfnInternalFree;
}
