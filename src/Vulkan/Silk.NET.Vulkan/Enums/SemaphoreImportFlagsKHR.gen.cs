// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [Flags]
    [NativeName("Name", "VkSemaphoreImportFlagsKHR")]
    public enum SemaphoreImportFlagsKHR : int
    {
        [NativeName("Name", "VK_SEMAPHORE_IMPORT_TEMPORARY_BIT")]
        SemaphoreImportTemporaryBit = 1,
    }
}
