// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [Flags]
    [NativeName("Name", "VkCullModeFlags")]
    public enum CullModeFlags : int
    {
        [Obsolete("Deprecated in favour of \"None\"")]
        [NativeName("Name", "VK_CULL_MODE_NONE")]
        CullModeNone = 0,
        [Obsolete("Deprecated in favour of \"FrontBit\"")]
        [NativeName("Name", "VK_CULL_MODE_FRONT_BIT")]
        CullModeFrontBit = 1,
        [Obsolete("Deprecated in favour of \"BackBit\"")]
        [NativeName("Name", "VK_CULL_MODE_BACK_BIT")]
        CullModeBackBit = 2,
        [Obsolete("Deprecated in favour of \"FrontAndBack\"")]
        [NativeName("Name", "VK_CULL_MODE_FRONT_AND_BACK")]
        CullModeFrontAndBack = 3,
        [NativeName("Name", "VK_CULL_MODE_NONE")]
        None = 0,
        [NativeName("Name", "VK_CULL_MODE_FRONT_BIT")]
        FrontBit = 1,
        [NativeName("Name", "VK_CULL_MODE_BACK_BIT")]
        BackBit = 2,
        [NativeName("Name", "VK_CULL_MODE_FRONT_AND_BACK")]
        FrontAndBack = 3,
    }
}
