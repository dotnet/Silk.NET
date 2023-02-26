// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [Flags]
    [NativeName("Name", "VkSemaphoreType")]
    public enum SemaphoreType : int
    {
        [NativeName("Name", "")]
        None = 0,
        [NativeName("Name", "VK_SEMAPHORE_TYPE_BINARY")]
        Binary = 0,
        [NativeName("Name", "VK_SEMAPHORE_TYPE_TIMELINE")]
        Timeline = 1,
    }
}
