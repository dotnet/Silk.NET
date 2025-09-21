// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [Flags]
    [NativeName("Name", "VkAccessFlags3KHR")]
    public enum AccessFlags3KHR : long
    {
        [NativeName("Name", "VK_ACCESS_3_NONE_KHR")]
        Access3NoneKhr = 0,
    }
}
