// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [Flags]
    [NativeName("Name", "VkIndirectStateFlagsNV")]
    public enum IndirectStateFlagsNV : int
    {
        [NativeName("Name", "VK_INDIRECT_STATE_FLAG_FRONTFACE_BIT_NV")]
        IndirectStateFlagFrontfaceBitNV = 1,
    }
}
