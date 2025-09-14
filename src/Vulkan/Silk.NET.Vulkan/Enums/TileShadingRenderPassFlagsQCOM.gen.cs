// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [Flags]
    [NativeName("Name", "VkTileShadingRenderPassFlagsQCOM")]
    public enum TileShadingRenderPassFlagsQCOM : int
    {
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"EnableBitQCom\"")]
        [NativeName("Name", "VK_TILE_SHADING_RENDER_PASS_ENABLE_BIT_QCOM")]
        TileShadingRenderPassEnableBitQCom = 1,
        [Obsolete("Deprecated in favour of \"PerTileExecutionBitQCom\"")]
        [NativeName("Name", "VK_TILE_SHADING_RENDER_PASS_PER_TILE_EXECUTION_BIT_QCOM")]
        TileShadingRenderPassPerTileExecutionBitQCom = 2,
        [NativeName("Name", "VK_TILE_SHADING_RENDER_PASS_ENABLE_BIT_QCOM")]
        EnableBitQCom = 1,
        [NativeName("Name", "VK_TILE_SHADING_RENDER_PASS_PER_TILE_EXECUTION_BIT_QCOM")]
        PerTileExecutionBitQCom = 2,
    }
}
