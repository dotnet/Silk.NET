// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
namespace Silk.NET.Vulkan;

public unsafe delegate void* PFN_vkReallocationFunctionDelegate(
    void* arg0,
    void* arg1,
    nuint arg2,
    nuint arg3,
    VkSystemAllocationScope arg4
);
