// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
namespace Silk.NET.Vulkan;

public unsafe delegate uint PFN_vkDebugReportCallbackEXTDelegate(
    uint arg0,
    VkDebugReportObjectTypeEXT arg1,
    ulong arg2,
    nuint arg3,
    int arg4,
    sbyte* arg5,
    sbyte* arg6,
    void* arg7
);
