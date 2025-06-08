// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
namespace Silk.NET.Vulkan;

public unsafe delegate void PFN_vkInternalFreeNotificationDelegate(
    void* arg0,
    nuint arg1,
    VkInternalAllocationType arg2,
    VkSystemAllocationScope arg3
);
