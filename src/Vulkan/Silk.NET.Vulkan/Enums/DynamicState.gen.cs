// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkDynamicState")]
    public enum DynamicState : int
    {
        [NativeName("Name", "VK_DYNAMIC_STATE_VIEWPORT")]
        Viewport = 0,
        [NativeName("Name", "VK_DYNAMIC_STATE_SCISSOR")]
        Scissor = 1,
        [NativeName("Name", "VK_DYNAMIC_STATE_LINE_WIDTH")]
        LineWidth = 2,
        [NativeName("Name", "VK_DYNAMIC_STATE_DEPTH_BIAS")]
        DepthBias = 3,
        [NativeName("Name", "VK_DYNAMIC_STATE_BLEND_CONSTANTS")]
        BlendConstants = 4,
        [NativeName("Name", "VK_DYNAMIC_STATE_DEPTH_BOUNDS")]
        DepthBounds = 5,
        [NativeName("Name", "VK_DYNAMIC_STATE_STENCIL_COMPARE_MASK")]
        StencilCompareMask = 6,
        [NativeName("Name", "VK_DYNAMIC_STATE_STENCIL_WRITE_MASK")]
        StencilWriteMask = 7,
        [NativeName("Name", "VK_DYNAMIC_STATE_STENCIL_REFERENCE")]
        StencilReference = 8,
        [NativeName("Name", "VK_DYNAMIC_STATE_VIEWPORT_W_SCALING_NV")]
        ViewportWScalingNV = 1000087000,
        [NativeName("Name", "VK_DYNAMIC_STATE_DISCARD_RECTANGLE_EXT")]
        DiscardRectangleExt = 1000099000,
        [NativeName("Name", "VK_DYNAMIC_STATE_SAMPLE_LOCATIONS_EXT")]
        SampleLocationsExt = 1000143000,
        [NativeName("Name", "VK_DYNAMIC_STATE_RAY_TRACING_PIPELINE_STACK_SIZE_KHR")]
        RayTracingPipelineStackSizeKhr = 1000347000,
        [NativeName("Name", "VK_DYNAMIC_STATE_VIEWPORT_SHADING_RATE_PALETTE_NV")]
        ViewportShadingRatePaletteNV = 1000164004,
        [NativeName("Name", "VK_DYNAMIC_STATE_VIEWPORT_COARSE_SAMPLE_ORDER_NV")]
        ViewportCoarseSampleOrderNV = 1000164006,
        [NativeName("Name", "VK_DYNAMIC_STATE_EXCLUSIVE_SCISSOR_NV")]
        ExclusiveScissorNV = 1000205001,
        [NativeName("Name", "VK_DYNAMIC_STATE_FRAGMENT_SHADING_RATE_KHR")]
        FragmentShadingRateKhr = 1000226000,
        [NativeName("Name", "VK_DYNAMIC_STATE_LINE_STIPPLE_EXT")]
        LineStippleExt = 1000259000,
        [NativeName("Name", "VK_DYNAMIC_STATE_CULL_MODE_EXT")]
        CullModeExt = 1000267000,
        [NativeName("Name", "VK_DYNAMIC_STATE_FRONT_FACE_EXT")]
        FrontFaceExt = 1000267001,
        [NativeName("Name", "VK_DYNAMIC_STATE_PRIMITIVE_TOPOLOGY_EXT")]
        PrimitiveTopologyExt = 1000267002,
        [NativeName("Name", "VK_DYNAMIC_STATE_VIEWPORT_WITH_COUNT_EXT")]
        ViewportWithCountExt = 1000267003,
        [NativeName("Name", "VK_DYNAMIC_STATE_SCISSOR_WITH_COUNT_EXT")]
        ScissorWithCountExt = 1000267004,
        [NativeName("Name", "VK_DYNAMIC_STATE_VERTEX_INPUT_BINDING_STRIDE_EXT")]
        VertexInputBindingStrideExt = 1000267005,
        [NativeName("Name", "VK_DYNAMIC_STATE_DEPTH_TEST_ENABLE_EXT")]
        DepthTestEnableExt = 1000267006,
        [NativeName("Name", "VK_DYNAMIC_STATE_DEPTH_WRITE_ENABLE_EXT")]
        DepthWriteEnableExt = 1000267007,
        [NativeName("Name", "VK_DYNAMIC_STATE_DEPTH_COMPARE_OP_EXT")]
        DepthCompareOpExt = 1000267008,
        [NativeName("Name", "VK_DYNAMIC_STATE_DEPTH_BOUNDS_TEST_ENABLE_EXT")]
        DepthBoundsTestEnableExt = 1000267009,
        [NativeName("Name", "VK_DYNAMIC_STATE_STENCIL_TEST_ENABLE_EXT")]
        StencilTestEnableExt = 1000267010,
        [NativeName("Name", "VK_DYNAMIC_STATE_STENCIL_OP_EXT")]
        StencilOpExt = 1000267011,
        [NativeName("Name", "VK_DYNAMIC_STATE_VERTEX_INPUT_EXT")]
        VertexInputExt = 1000352000,
        [NativeName("Name", "VK_DYNAMIC_STATE_PATCH_CONTROL_POINTS_EXT")]
        PatchControlPointsExt = 1000377000,
        [NativeName("Name", "VK_DYNAMIC_STATE_RASTERIZER_DISCARD_ENABLE_EXT")]
        RasterizerDiscardEnableExt = 1000377001,
        [NativeName("Name", "VK_DYNAMIC_STATE_DEPTH_BIAS_ENABLE_EXT")]
        DepthBiasEnableExt = 1000377002,
        [NativeName("Name", "VK_DYNAMIC_STATE_LOGIC_OP_EXT")]
        LogicOpExt = 1000377003,
        [NativeName("Name", "VK_DYNAMIC_STATE_PRIMITIVE_RESTART_ENABLE_EXT")]
        PrimitiveRestartEnableExt = 1000377004,
        [NativeName("Name", "VK_DYNAMIC_STATE_COLOR_WRITE_ENABLE_EXT")]
        ColorWriteEnableExt = 1000381000,
        [NativeName("Name", "VK_DYNAMIC_STATE_CULL_MODE")]
        CullMode = 1000267000,
        [NativeName("Name", "VK_DYNAMIC_STATE_FRONT_FACE")]
        FrontFace = 1000267001,
        [NativeName("Name", "VK_DYNAMIC_STATE_PRIMITIVE_TOPOLOGY")]
        PrimitiveTopology = 1000267002,
        [NativeName("Name", "VK_DYNAMIC_STATE_VIEWPORT_WITH_COUNT")]
        ViewportWithCount = 1000267003,
        [NativeName("Name", "VK_DYNAMIC_STATE_SCISSOR_WITH_COUNT")]
        ScissorWithCount = 1000267004,
        [NativeName("Name", "VK_DYNAMIC_STATE_VERTEX_INPUT_BINDING_STRIDE")]
        VertexInputBindingStride = 1000267005,
        [NativeName("Name", "VK_DYNAMIC_STATE_DEPTH_TEST_ENABLE")]
        DepthTestEnable = 1000267006,
        [NativeName("Name", "VK_DYNAMIC_STATE_DEPTH_WRITE_ENABLE")]
        DepthWriteEnable = 1000267007,
        [NativeName("Name", "VK_DYNAMIC_STATE_DEPTH_COMPARE_OP")]
        DepthCompareOp = 1000267008,
        [NativeName("Name", "VK_DYNAMIC_STATE_DEPTH_BOUNDS_TEST_ENABLE")]
        DepthBoundsTestEnable = 1000267009,
        [NativeName("Name", "VK_DYNAMIC_STATE_STENCIL_TEST_ENABLE")]
        StencilTestEnable = 1000267010,
        [NativeName("Name", "VK_DYNAMIC_STATE_STENCIL_OP")]
        StencilOp = 1000267011,
        [NativeName("Name", "VK_DYNAMIC_STATE_RASTERIZER_DISCARD_ENABLE")]
        RasterizerDiscardEnable = 1000377001,
        [NativeName("Name", "VK_DYNAMIC_STATE_DEPTH_BIAS_ENABLE")]
        DepthBiasEnable = 1000377002,
        [NativeName("Name", "VK_DYNAMIC_STATE_PRIMITIVE_RESTART_ENABLE")]
        PrimitiveRestartEnable = 1000377004,
    }
}
