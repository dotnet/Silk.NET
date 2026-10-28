// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkSemaphoreType")]
public enum SemaphoreType : uint
{
    [NativeName("VK_SEMAPHORE_TYPE_BINARY")]
    Binary = 0,

    [NativeName("VK_SEMAPHORE_TYPE_TIMELINE")]
    Timeline = 1,

    [NativeName("VK_SEMAPHORE_TYPE_BINARY_KHR")]
    BinaryKHR = Binary,

    [NativeName("VK_SEMAPHORE_TYPE_TIMELINE_KHR")]
    TimelineKHR = Timeline,
}
