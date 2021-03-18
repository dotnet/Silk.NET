// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkSemaphoreTypeKHR")]
    public enum SemaphoreTypeKHR : int
    {
        [NativeName("Name", "VK_SEMAPHORE_TYPE_BINARY")]
        SemaphoreTypeBinary = 0,
        [NativeName("Name", "VK_SEMAPHORE_TYPE_TIMELINE")]
        SemaphoreTypeTimeline = 1,
    }
}
