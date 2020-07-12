// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;

#pragma warning disable 1591

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
        CullModeExt = 1000267000,
        FrontFaceExt = 1000267001,
        PrimitiveTopologyExt = 1000267002,
        ViewportWithCountExt = 1000267003,
        ScissorWithCountExt = 1000267004,
        VertexInputBindingStrideExt = 1000267005,
        DepthTestEnableExt = 1000267006,
        DepthWriteEnableExt = 1000267007,
        DepthCompareOpExt = 1000267008,
        DepthBoundsTestEnableExt = 1000267009,
        StencilTestEnableExt = 1000267010,
        StencilOpExt = 1000267011,
    }
}
