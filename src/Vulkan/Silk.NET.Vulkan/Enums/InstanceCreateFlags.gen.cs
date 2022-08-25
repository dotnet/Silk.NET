// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [Flags]
    [NativeName("Name", "VkInstanceCreateFlags")]
    public enum InstanceCreateFlags : int
    {
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"EnumeratePortabilityBitKhr\"")]
        [NativeName("Name", "VK_INSTANCE_CREATE_ENUMERATE_PORTABILITY_BIT_KHR")]
        InstanceCreateEnumeratePortabilityBitKhr = 1,
        [NativeName("Name", "VK_INSTANCE_CREATE_ENUMERATE_PORTABILITY_BIT_KHR")]
        EnumeratePortabilityBitKhr = 1,
    }
}
