// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkDirectDriverLoadingModeLUNARG")]
    public enum DirectDriverLoadingModeLUNARG : int
    {
        [Obsolete("Deprecated in favour of \"ExclusiveLunarg\"")]
        [NativeName("Name", "VK_DIRECT_DRIVER_LOADING_MODE_EXCLUSIVE_LUNARG")]
        DirectDriverLoadingModeExclusiveLunarg = 0,
        [Obsolete("Deprecated in favour of \"InclusiveLunarg\"")]
        [NativeName("Name", "VK_DIRECT_DRIVER_LOADING_MODE_INCLUSIVE_LUNARG")]
        DirectDriverLoadingModeInclusiveLunarg = 1,
        [NativeName("Name", "VK_DIRECT_DRIVER_LOADING_MODE_EXCLUSIVE_LUNARG")]
        ExclusiveLunarg = 0,
        [NativeName("Name", "VK_DIRECT_DRIVER_LOADING_MODE_INCLUSIVE_LUNARG")]
        InclusiveLunarg = 1,
    }
}
