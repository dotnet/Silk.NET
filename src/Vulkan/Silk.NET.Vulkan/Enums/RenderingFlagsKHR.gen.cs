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
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"ContentsSecondaryCommandBuffersBit\"")]
        [NativeName("Name", "VK_RENDERING_CONTENTS_SECONDARY_COMMAND_BUFFERS_BIT")]
        RenderingContentsSecondaryCommandBuffersBit = 1,
        [Obsolete("Deprecated in favour of \"SuspendingBit\"")]
        [NativeName("Name", "VK_RENDERING_SUSPENDING_BIT")]
        RenderingSuspendingBit = 2,
        [Obsolete("Deprecated in favour of \"ResumingBit\"")]
        [NativeName("Name", "VK_RENDERING_RESUMING_BIT")]
        RenderingResumingBit = 4,
        [NativeName("Name", "VK_RENDERING_CONTENTS_SECONDARY_COMMAND_BUFFERS_BIT")]
        ContentsSecondaryCommandBuffersBit = 1,
        [NativeName("Name", "VK_RENDERING_SUSPENDING_BIT")]
        SuspendingBit = 2,
        [NativeName("Name", "VK_RENDERING_RESUMING_BIT")]
        ResumingBit = 4,
    }
}
