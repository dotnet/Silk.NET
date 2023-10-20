// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkBlockMatchWindowCompareModeQCOM")]
    public enum BlockMatchWindowCompareModeQCOM : int
    {
        [Obsolete("Deprecated in favour of \"MinQCom\"")]
        [NativeName("Name", "VK_BLOCK_MATCH_WINDOW_COMPARE_MODE_MIN_QCOM")]
        BlockMatchWindowCompareModeMinQCom = 0,
        [Obsolete("Deprecated in favour of \"MaxQCom\"")]
        [NativeName("Name", "VK_BLOCK_MATCH_WINDOW_COMPARE_MODE_MAX_QCOM")]
        BlockMatchWindowCompareModeMaxQCom = 1,
        [NativeName("Name", "VK_BLOCK_MATCH_WINDOW_COMPARE_MODE_MIN_QCOM")]
        MinQCom = 0,
        [NativeName("Name", "VK_BLOCK_MATCH_WINDOW_COMPARE_MODE_MAX_QCOM")]
        MaxQCom = 1,
    }
}
