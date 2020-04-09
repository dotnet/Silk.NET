// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;

namespace Silk.NET.Vulkan
{
    public enum DynamicState
    {
        Viewport = 0,
        Scissor = 1,
        LineWidth = 2,
        DepthBias = 3,
        BlendConstants = 4,
        DepthBounds = 5,
        StencilCompareMask = 6,
        StencilWriteMask = 7,
        StencilReference = 8,
        ViewportWScalingNV = 1000087000,
        DiscardRectangleExt = 1000099000,
        SampleLocationsExt = 1000143000,
        ViewportShadingRatePaletteNV = 1000164004,
        ViewportCoarseSampleOrderNV = 1000164006,
        ExclusiveScissorNV = 1000205001,
        LineStippleExt = 1000259000,
    }
}
