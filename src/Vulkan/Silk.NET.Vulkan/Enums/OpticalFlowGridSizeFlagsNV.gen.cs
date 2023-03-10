// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [Flags]
    [NativeName("Name", "VkOpticalFlowGridSizeFlagsNV")]
    public enum OpticalFlowGridSizeFlagsNV : int
    {
        [Obsolete("Deprecated in favour of \"SizeUnknownNV\"")]
        [NativeName("Name", "VK_OPTICAL_FLOW_GRID_SIZE_UNKNOWN_NV")]
        OpticalFlowGridSizeUnknownNV = 0,
        [Obsolete("Deprecated in favour of \"Size1X1BitNV\"")]
        [NativeName("Name", "VK_OPTICAL_FLOW_GRID_SIZE_1X1_BIT_NV")]
        OpticalFlowGridSize1X1BitNV = 1,
        [Obsolete("Deprecated in favour of \"Size2X2BitNV\"")]
        [NativeName("Name", "VK_OPTICAL_FLOW_GRID_SIZE_2X2_BIT_NV")]
        OpticalFlowGridSize2X2BitNV = 2,
        [Obsolete("Deprecated in favour of \"Size4X4BitNV\"")]
        [NativeName("Name", "VK_OPTICAL_FLOW_GRID_SIZE_4X4_BIT_NV")]
        OpticalFlowGridSize4X4BitNV = 4,
        [Obsolete("Deprecated in favour of \"Size8X8BitNV\"")]
        [NativeName("Name", "VK_OPTICAL_FLOW_GRID_SIZE_8X8_BIT_NV")]
        OpticalFlowGridSize8X8BitNV = 8,
        [NativeName("Name", "VK_OPTICAL_FLOW_GRID_SIZE_UNKNOWN_NV")]
        SizeUnknownNV = 0,
        [NativeName("Name", "VK_OPTICAL_FLOW_GRID_SIZE_1X1_BIT_NV")]
        Size1X1BitNV = 1,
        [NativeName("Name", "VK_OPTICAL_FLOW_GRID_SIZE_2X2_BIT_NV")]
        Size2X2BitNV = 2,
        [NativeName("Name", "VK_OPTICAL_FLOW_GRID_SIZE_4X4_BIT_NV")]
        Size4X4BitNV = 4,
        [NativeName("Name", "VK_OPTICAL_FLOW_GRID_SIZE_8X8_BIT_NV")]
        Size8X8BitNV = 8,
    }
}
