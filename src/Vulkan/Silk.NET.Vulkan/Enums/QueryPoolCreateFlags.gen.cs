// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [Flags]
    [NativeName("Name", "VkQueryPoolCreateFlags")]
    public enum QueryPoolCreateFlags : int
    {
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"ResetBitKhr\"")]
        [NativeName("Name", "VK_QUERY_POOL_CREATE_RESET_BIT_KHR")]
        QueryPoolCreateResetBitKhr = 1,
        [NativeName("Name", "VK_QUERY_POOL_CREATE_RESET_BIT_KHR")]
        ResetBitKhr = 1,
    }
}
