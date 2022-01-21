// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [Flags]
    [NativeName("Name", "VkRenderingFlagsKHR")]
    public enum RenderingFlagsKHR : int
    {
        [NativeName("Name", "VK_RENDERING_CONTENTS_SECONDARY_COMMAND_BUFFERS_BIT_KHR")]
        RenderingContentsSecondaryCommandBuffersBitKhr = 1,
        [NativeName("Name", "VK_RENDERING_SUSPENDING_BIT_KHR")]
        RenderingSuspendingBitKhr = 2,
        [NativeName("Name", "VK_RENDERING_RESUMING_BIT_KHR")]
        RenderingResumingBitKhr = 4,
    }
}
