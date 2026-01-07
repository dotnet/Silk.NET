// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [Flags]
    [NativeName("Name", "VkRenderPassCreateFlags")]
    public enum RenderPassCreateFlags : int
    {
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"TransformBitQCom\"")]
        [NativeName("Name", "VK_RENDER_PASS_CREATE_TRANSFORM_BIT_QCOM")]
        RenderPassCreateTransformBitQCom = 2,
        [Obsolete("Deprecated in favour of \"PerLayerFragmentDensityBitValve\"")]
        [NativeName("Name", "VK_RENDER_PASS_CREATE_PER_LAYER_FRAGMENT_DENSITY_BIT_VALVE")]
        RenderPassCreatePerLayerFragmentDensityBitValve = 4,
        [NativeName("Name", "VK_RENDER_PASS_CREATE_TRANSFORM_BIT_QCOM")]
        TransformBitQCom = 2,
        [NativeName("Name", "VK_RENDER_PASS_CREATE_PER_LAYER_FRAGMENT_DENSITY_BIT_VALVE")]
        PerLayerFragmentDensityBitValve = 4,
    }
}
