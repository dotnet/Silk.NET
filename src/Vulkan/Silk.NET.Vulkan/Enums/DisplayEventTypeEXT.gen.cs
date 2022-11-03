// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkDisplayEventTypeEXT")]
    public enum DisplayEventTypeEXT : int
    {
        [Obsolete("Deprecated in favour of \"FirstPixelOutExt\"")]
        [NativeName("Name", "VK_DISPLAY_EVENT_TYPE_FIRST_PIXEL_OUT_EXT")]
        DisplayEventTypeFirstPixelOutExt = 0,
        [NativeName("Name", "VK_DISPLAY_EVENT_TYPE_FIRST_PIXEL_OUT_EXT")]
        FirstPixelOutExt = 0,
    }
}
