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
        [NativeName("Name", "VK_DYNAMIC_STATE_DISCARD_RECTANGLE_ENABLE_EXT")]
        DiscardRectangleEnableExt = 1000099001,
        [NativeName("Name", "VK_DYNAMIC_STATE_DISCARD_RECTANGLE_MODE_EXT")]
        DiscardRectangleModeExt = 1000099002,
        [NativeName("Name", "VK_DYNAMIC_STATE_SAMPLE_LOCATIONS_EXT")]
        SampleLocationsExt = 1000143000,
        [NativeName("Name", "VK_DYNAMIC_STATE_RAY_TRACING_PIPELINE_STACK_SIZE_KHR")]
        RayTracingPipelineStackSizeKhr = 1000347000,
        [NativeName("Name", "VK_DYNAMIC_STATE_VIEWPORT_SHADING_RATE_PALETTE_NV")]
        ViewportShadingRatePaletteNV = 1000164004,
        [NativeName("Name", "VK_DYNAMIC_STATE_VIEWPORT_COARSE_SAMPLE_ORDER_NV")]
        ViewportCoarseSampleOrderNV = 1000164006,
        [NativeName("Name", "VK_DYNAMIC_STATE_EXCLUSIVE_SCISSOR_ENABLE_NV")]
        ExclusiveScissorEnableNV = 1000205000,
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
        [NativeName("Name", "VK_DYNAMIC_STATE_DEPTH_CLAMP_ENABLE_EXT")]
        DepthClampEnableExt = 1000455003,
        [NativeName("Name", "VK_DYNAMIC_STATE_POLYGON_MODE_EXT")]
        PolygonModeExt = 1000455004,
        [NativeName("Name", "VK_DYNAMIC_STATE_RASTERIZATION_SAMPLES_EXT")]
        RasterizationSamplesExt = 1000455005,
        [NativeName("Name", "VK_DYNAMIC_STATE_SAMPLE_MASK_EXT")]
        SampleMaskExt = 1000455006,
        [NativeName("Name", "VK_DYNAMIC_STATE_ALPHA_TO_COVERAGE_ENABLE_EXT")]
        AlphaToCoverageEnableExt = 1000455007,
        [NativeName("Name", "VK_DYNAMIC_STATE_ALPHA_TO_ONE_ENABLE_EXT")]
        AlphaToOneEnableExt = 1000455008,
        [NativeName("Name", "VK_DYNAMIC_STATE_LOGIC_OP_ENABLE_EXT")]
        LogicOpEnableExt = 1000455009,
        [NativeName("Name", "VK_DYNAMIC_STATE_COLOR_BLEND_ENABLE_EXT")]
        ColorBlendEnableExt = 1000455010,
        [NativeName("Name", "VK_DYNAMIC_STATE_COLOR_BLEND_EQUATION_EXT")]
        ColorBlendEquationExt = 1000455011,
        [NativeName("Name", "VK_DYNAMIC_STATE_COLOR_WRITE_MASK_EXT")]
        ColorWriteMaskExt = 1000455012,
        [NativeName("Name", "VK_DYNAMIC_STATE_TESSELLATION_DOMAIN_ORIGIN_EXT")]
        TessellationDomainOriginExt = 1000455002,
        [NativeName("Name", "VK_DYNAMIC_STATE_RASTERIZATION_STREAM_EXT")]
        RasterizationStreamExt = 1000455013,
        [NativeName("Name", "VK_DYNAMIC_STATE_CONSERVATIVE_RASTERIZATION_MODE_EXT")]
        ConservativeRasterizationModeExt = 1000455014,
        [NativeName("Name", "VK_DYNAMIC_STATE_EXTRA_PRIMITIVE_OVERESTIMATION_SIZE_EXT")]
        ExtraPrimitiveOverestimationSizeExt = 1000455015,
        [NativeName("Name", "VK_DYNAMIC_STATE_DEPTH_CLIP_ENABLE_EXT")]
        DepthClipEnableExt = 1000455016,
        [NativeName("Name", "VK_DYNAMIC_STATE_SAMPLE_LOCATIONS_ENABLE_EXT")]
        SampleLocationsEnableExt = 1000455017,
        [NativeName("Name", "VK_DYNAMIC_STATE_COLOR_BLEND_ADVANCED_EXT")]
        ColorBlendAdvancedExt = 1000455018,
        [NativeName("Name", "VK_DYNAMIC_STATE_PROVOKING_VERTEX_MODE_EXT")]
        ProvokingVertexModeExt = 1000455019,
        [NativeName("Name", "VK_DYNAMIC_STATE_LINE_RASTERIZATION_MODE_EXT")]
        LineRasterizationModeExt = 1000455020,
        [NativeName("Name", "VK_DYNAMIC_STATE_LINE_STIPPLE_ENABLE_EXT")]
        LineStippleEnableExt = 1000455021,
        [NativeName("Name", "VK_DYNAMIC_STATE_DEPTH_CLIP_NEGATIVE_ONE_TO_ONE_EXT")]
        DepthClipNegativeOneToOneExt = 1000455022,
        [NativeName("Name", "VK_DYNAMIC_STATE_VIEWPORT_W_SCALING_ENABLE_NV")]
        ViewportWScalingEnableNV = 1000455023,
        [NativeName("Name", "VK_DYNAMIC_STATE_VIEWPORT_SWIZZLE_NV")]
        ViewportSwizzleNV = 1000455024,
        [NativeName("Name", "VK_DYNAMIC_STATE_COVERAGE_TO_COLOR_ENABLE_NV")]
        CoverageToColorEnableNV = 1000455025,
        [NativeName("Name", "VK_DYNAMIC_STATE_COVERAGE_TO_COLOR_LOCATION_NV")]
        CoverageToColorLocationNV = 1000455026,
        [NativeName("Name", "VK_DYNAMIC_STATE_COVERAGE_MODULATION_MODE_NV")]
        CoverageModulationModeNV = 1000455027,
        [NativeName("Name", "VK_DYNAMIC_STATE_COVERAGE_MODULATION_TABLE_ENABLE_NV")]
        CoverageModulationTableEnableNV = 1000455028,
        [NativeName("Name", "VK_DYNAMIC_STATE_COVERAGE_MODULATION_TABLE_NV")]
        CoverageModulationTableNV = 1000455029,
        [NativeName("Name", "VK_DYNAMIC_STATE_SHADING_RATE_IMAGE_ENABLE_NV")]
        ShadingRateImageEnableNV = 1000455030,
        [NativeName("Name", "VK_DYNAMIC_STATE_REPRESENTATIVE_FRAGMENT_TEST_ENABLE_NV")]
        RepresentativeFragmentTestEnableNV = 1000455031,
        [NativeName("Name", "VK_DYNAMIC_STATE_COVERAGE_REDUCTION_MODE_NV")]
        CoverageReductionModeNV = 1000455032,
        [NativeName("Name", "VK_DYNAMIC_STATE_ATTACHMENT_FEEDBACK_LOOP_ENABLE_EXT")]
        AttachmentFeedbackLoopEnableExt = 1000524000,
        [NativeName("Name", "VK_DYNAMIC_STATE_LINE_STIPPLE_KHR")]
        LineStippleKhr = 1000259000,
        [NativeName("Name", "VK_DYNAMIC_STATE_DEPTH_CLAMP_RANGE_EXT")]
        DepthClampRangeExt = 1000582000,
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
