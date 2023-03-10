// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [Flags]
    [NativeName("Name", "VkSubpassContents")]
    public enum SubpassContents : int
    {
        [NativeName("Name", "VK_SUBPASS_CONTENTS_INLINE")]
        Inline = 0,
        [NativeName("Name", "VK_SUBPASS_CONTENTS_SECONDARY_COMMAND_BUFFERS")]
        SecondaryCommandBuffers = 1,
    }
}
