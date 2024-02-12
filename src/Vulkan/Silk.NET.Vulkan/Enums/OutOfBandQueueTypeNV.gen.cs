// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkOutOfBandQueueTypeNV")]
    public enum OutOfBandQueueTypeNV : int
    {
        [Obsolete("Deprecated in favour of \"RenderNV\"")]
        [NativeName("Name", "VK_OUT_OF_BAND_QUEUE_TYPE_RENDER_NV")]
        OutOfBandQueueTypeRenderNV = 0,
        [Obsolete("Deprecated in favour of \"PresentNV\"")]
        [NativeName("Name", "VK_OUT_OF_BAND_QUEUE_TYPE_PRESENT_NV")]
        OutOfBandQueueTypePresentNV = 1,
        [NativeName("Name", "VK_OUT_OF_BAND_QUEUE_TYPE_RENDER_NV")]
        RenderNV = 0,
        [NativeName("Name", "VK_OUT_OF_BAND_QUEUE_TYPE_PRESENT_NV")]
        PresentNV = 1,
    }
}
