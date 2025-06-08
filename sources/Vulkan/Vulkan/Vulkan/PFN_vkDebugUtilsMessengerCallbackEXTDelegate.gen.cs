// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
namespace Silk.NET.Vulkan;

public unsafe delegate uint PFN_vkDebugUtilsMessengerCallbackEXTDelegate(
    VkDebugUtilsMessageSeverityFlagsEXT arg0,
    uint arg1,
    VkDebugUtilsMessengerCallbackDataEXT* arg2,
    void* arg3
);
