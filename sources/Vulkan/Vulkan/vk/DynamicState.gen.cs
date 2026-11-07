// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkDynamicState")]
public enum DynamicState : uint
{
    [NativeName("VK_DYNAMIC_STATE_VIEWPORT")]
    Viewport = 0,

    [NativeName("VK_DYNAMIC_STATE_SCISSOR")]
    Scissor = 1,

    [NativeName("VK_DYNAMIC_STATE_LINE_WIDTH")]
    LineWidth = 2,

    [NativeName("VK_DYNAMIC_STATE_DEPTH_BIAS")]
    DepthBias = 3,

    [NativeName("VK_DYNAMIC_STATE_BLEND_CONSTANTS")]
    BlendConstants = 4,

    [NativeName("VK_DYNAMIC_STATE_DEPTH_BOUNDS")]
    DepthBounds = 5,

    [NativeName("VK_DYNAMIC_STATE_STENCIL_COMPARE_MASK")]
    StencilCompareMask = 6,

    [NativeName("VK_DYNAMIC_STATE_STENCIL_WRITE_MASK")]
    StencilWriteMask = 7,

    [NativeName("VK_DYNAMIC_STATE_STENCIL_REFERENCE")]
    StencilReference = 8,

    [NativeName("VK_DYNAMIC_STATE_CULL_MODE")]
    CullMode = 1000267000,

    [NativeName("VK_DYNAMIC_STATE_FRONT_FACE")]
    FrontFace = 1000267001,

    [NativeName("VK_DYNAMIC_STATE_PRIMITIVE_TOPOLOGY")]
    PrimitiveTopology = 1000267002,

    [NativeName("VK_DYNAMIC_STATE_VIEWPORT_WITH_COUNT")]
    ViewportWithCount = 1000267003,

    [NativeName("VK_DYNAMIC_STATE_SCISSOR_WITH_COUNT")]
    ScissorWithCount = 1000267004,

    [NativeName("VK_DYNAMIC_STATE_VERTEX_INPUT_BINDING_STRIDE")]
    VertexInputBindingStride = 1000267005,

    [NativeName("VK_DYNAMIC_STATE_DEPTH_TEST_ENABLE")]
    DepthTestEnable = 1000267006,

    [NativeName("VK_DYNAMIC_STATE_DEPTH_WRITE_ENABLE")]
    DepthWriteEnable = 1000267007,

    [NativeName("VK_DYNAMIC_STATE_DEPTH_COMPARE_OP")]
    DepthCompareOp = 1000267008,

    [NativeName("VK_DYNAMIC_STATE_DEPTH_BOUNDS_TEST_ENABLE")]
    DepthBoundsTestEnable = 1000267009,

    [NativeName("VK_DYNAMIC_STATE_STENCIL_TEST_ENABLE")]
    StencilTestEnable = 1000267010,

    [NativeName("VK_DYNAMIC_STATE_STENCIL_OP")]
    StencilOp = 1000267011,

    [NativeName("VK_DYNAMIC_STATE_RASTERIZER_DISCARD_ENABLE")]
    RasterizerDiscardEnable = 1000377001,

    [NativeName("VK_DYNAMIC_STATE_DEPTH_BIAS_ENABLE")]
    DepthBiasEnable = 1000377002,

    [NativeName("VK_DYNAMIC_STATE_PRIMITIVE_RESTART_ENABLE")]
    PrimitiveRestartEnable = 1000377004,

    [NativeName("VK_DYNAMIC_STATE_LINE_STIPPLE")]
    LineStipple = 1000259000,

    [NativeName("VK_DYNAMIC_STATE_VIEWPORT_W_SCALING_NV")]
    ViewportWScalingNV = 1000087000,

    [NativeName("VK_DYNAMIC_STATE_DISCARD_RECTANGLE_EXT")]
    DiscardRectangleEXT = 1000099000,

    [NativeName("VK_DYNAMIC_STATE_DISCARD_RECTANGLE_ENABLE_EXT")]
    DiscardRectangleEnableEXT = 1000099001,

    [NativeName("VK_DYNAMIC_STATE_DISCARD_RECTANGLE_MODE_EXT")]
    DiscardRectangleModeEXT = 1000099002,

    [NativeName("VK_DYNAMIC_STATE_SAMPLE_LOCATIONS_EXT")]
    SampleLocationsEXT = 1000143000,

    [NativeName("VK_DYNAMIC_STATE_RAY_TRACING_PIPELINE_STACK_SIZE_KHR")]
    RayTracingPipelineStackSizeKHR = 1000347000,

    [NativeName("VK_DYNAMIC_STATE_VIEWPORT_SHADING_RATE_PALETTE_NV")]
    ViewportShadingRatePaletteNV = 1000164004,

    [NativeName("VK_DYNAMIC_STATE_VIEWPORT_COARSE_SAMPLE_ORDER_NV")]
    ViewportCoarseSampleOrderNV = 1000164006,

    [NativeName("VK_DYNAMIC_STATE_EXCLUSIVE_SCISSOR_ENABLE_NV")]
    ExclusiveScissorEnableNV = 1000205000,

    [NativeName("VK_DYNAMIC_STATE_EXCLUSIVE_SCISSOR_NV")]
    ExclusiveScissorNV = 1000205001,

    [NativeName("VK_DYNAMIC_STATE_FRAGMENT_SHADING_RATE_KHR")]
    FragmentShadingRateKHR = 1000226000,

    [NativeName("VK_DYNAMIC_STATE_VERTEX_INPUT_EXT")]
    VertexInputEXT = 1000352000,

    [NativeName("VK_DYNAMIC_STATE_PATCH_CONTROL_POINTS_EXT")]
    PatchControlPointsEXT = 1000377000,

    [NativeName("VK_DYNAMIC_STATE_LOGIC_OP_EXT")]
    LogicOpEXT = 1000377003,

    [NativeName("VK_DYNAMIC_STATE_COLOR_WRITE_ENABLE_EXT")]
    ColorWriteEnableEXT = 1000381000,

    [NativeName("VK_DYNAMIC_STATE_DEPTH_CLAMP_ENABLE_EXT")]
    DepthClampEnableEXT = 1000455003,

    [NativeName("VK_DYNAMIC_STATE_POLYGON_MODE_EXT")]
    PolygonModeEXT = 1000455004,

    [NativeName("VK_DYNAMIC_STATE_RASTERIZATION_SAMPLES_EXT")]
    RasterizationSamplesEXT = 1000455005,

    [NativeName("VK_DYNAMIC_STATE_SAMPLE_MASK_EXT")]
    SampleMaskEXT = 1000455006,

    [NativeName("VK_DYNAMIC_STATE_ALPHA_TO_COVERAGE_ENABLE_EXT")]
    AlphaToCoverageEnableEXT = 1000455007,

    [NativeName("VK_DYNAMIC_STATE_ALPHA_TO_ONE_ENABLE_EXT")]
    AlphaToOneEnableEXT = 1000455008,

    [NativeName("VK_DYNAMIC_STATE_LOGIC_OP_ENABLE_EXT")]
    LogicOpEnableEXT = 1000455009,

    [NativeName("VK_DYNAMIC_STATE_COLOR_BLEND_ENABLE_EXT")]
    ColorBlendEnableEXT = 1000455010,

    [NativeName("VK_DYNAMIC_STATE_COLOR_BLEND_EQUATION_EXT")]
    ColorBlendEquationEXT = 1000455011,

    [NativeName("VK_DYNAMIC_STATE_COLOR_WRITE_MASK_EXT")]
    ColorWriteMaskEXT = 1000455012,

    [NativeName("VK_DYNAMIC_STATE_TESSELLATION_DOMAIN_ORIGIN_EXT")]
    TessellationDomainOriginEXT = 1000455002,

    [NativeName("VK_DYNAMIC_STATE_RASTERIZATION_STREAM_EXT")]
    RasterizationStreamEXT = 1000455013,

    [NativeName("VK_DYNAMIC_STATE_CONSERVATIVE_RASTERIZATION_MODE_EXT")]
    ConservativeRasterizationModeEXT = 1000455014,

    [NativeName("VK_DYNAMIC_STATE_EXTRA_PRIMITIVE_OVERESTIMATION_SIZE_EXT")]
    ExtraPrimitiveOverestimationSizeEXT = 1000455015,

    [NativeName("VK_DYNAMIC_STATE_DEPTH_CLIP_ENABLE_EXT")]
    DepthClipEnableEXT = 1000455016,

    [NativeName("VK_DYNAMIC_STATE_SAMPLE_LOCATIONS_ENABLE_EXT")]
    SampleLocationsEnableEXT = 1000455017,

    [NativeName("VK_DYNAMIC_STATE_COLOR_BLEND_ADVANCED_EXT")]
    ColorBlendAdvancedEXT = 1000455018,

    [NativeName("VK_DYNAMIC_STATE_PROVOKING_VERTEX_MODE_EXT")]
    ProvokingVertexModeEXT = 1000455019,

    [NativeName("VK_DYNAMIC_STATE_LINE_RASTERIZATION_MODE_EXT")]
    LineRasterizationModeEXT = 1000455020,

    [NativeName("VK_DYNAMIC_STATE_LINE_STIPPLE_ENABLE_EXT")]
    LineStippleEnableEXT = 1000455021,

    [NativeName("VK_DYNAMIC_STATE_DEPTH_CLIP_NEGATIVE_ONE_TO_ONE_EXT")]
    DepthClipNegativeOneToOneEXT = 1000455022,

    [NativeName("VK_DYNAMIC_STATE_VIEWPORT_W_SCALING_ENABLE_NV")]
    ViewportWScalingEnableNV = 1000455023,

    [NativeName("VK_DYNAMIC_STATE_VIEWPORT_SWIZZLE_NV")]
    ViewportSwizzleNV = 1000455024,

    [NativeName("VK_DYNAMIC_STATE_COVERAGE_TO_COLOR_ENABLE_NV")]
    CoverageToColorEnableNV = 1000455025,

    [NativeName("VK_DYNAMIC_STATE_COVERAGE_TO_COLOR_LOCATION_NV")]
    CoverageToColorLocationNV = 1000455026,

    [NativeName("VK_DYNAMIC_STATE_COVERAGE_MODULATION_MODE_NV")]
    CoverageModulationModeNV = 1000455027,

    [NativeName("VK_DYNAMIC_STATE_COVERAGE_MODULATION_TABLE_ENABLE_NV")]
    CoverageModulationTableEnableNV = 1000455028,

    [NativeName("VK_DYNAMIC_STATE_COVERAGE_MODULATION_TABLE_NV")]
    CoverageModulationTableNV = 1000455029,

    [NativeName("VK_DYNAMIC_STATE_SHADING_RATE_IMAGE_ENABLE_NV")]
    ShadingRateImageEnableNV = 1000455030,

    [NativeName("VK_DYNAMIC_STATE_REPRESENTATIVE_FRAGMENT_TEST_ENABLE_NV")]
    RepresentativeFragmentTestEnableNV = 1000455031,

    [NativeName("VK_DYNAMIC_STATE_COVERAGE_REDUCTION_MODE_NV")]
    CoverageReductionModeNV = 1000455032,

    [NativeName("VK_DYNAMIC_STATE_ATTACHMENT_FEEDBACK_LOOP_ENABLE_EXT")]
    AttachmentFeedbackLoopEnableEXT = 1000524000,

    [NativeName("VK_DYNAMIC_STATE_DEPTH_CLAMP_RANGE_EXT")]
    DepthClampRangeEXT = 1000582000,

    [NativeName("VK_DYNAMIC_STATE_LINE_STIPPLE_EXT")]
    LineStippleEXT = LineStipple,

    [NativeName("VK_DYNAMIC_STATE_CULL_MODE_EXT")]
    CullModeEXT = CullMode,

    [NativeName("VK_DYNAMIC_STATE_FRONT_FACE_EXT")]
    FrontFaceEXT = FrontFace,

    [NativeName("VK_DYNAMIC_STATE_PRIMITIVE_TOPOLOGY_EXT")]
    PrimitiveTopologyEXT = PrimitiveTopology,

    [NativeName("VK_DYNAMIC_STATE_VIEWPORT_WITH_COUNT_EXT")]
    ViewportWithCountEXT = ViewportWithCount,

    [NativeName("VK_DYNAMIC_STATE_SCISSOR_WITH_COUNT_EXT")]
    ScissorWithCountEXT = ScissorWithCount,

    [NativeName("VK_DYNAMIC_STATE_VERTEX_INPUT_BINDING_STRIDE_EXT")]
    VertexInputBindingStrideEXT = VertexInputBindingStride,

    [NativeName("VK_DYNAMIC_STATE_DEPTH_TEST_ENABLE_EXT")]
    DepthTestEnableEXT = DepthTestEnable,

    [NativeName("VK_DYNAMIC_STATE_DEPTH_WRITE_ENABLE_EXT")]
    DepthWriteEnableEXT = DepthWriteEnable,

    [NativeName("VK_DYNAMIC_STATE_DEPTH_COMPARE_OP_EXT")]
    DepthCompareOpEXT = DepthCompareOp,

    [NativeName("VK_DYNAMIC_STATE_DEPTH_BOUNDS_TEST_ENABLE_EXT")]
    DepthBoundsTestEnableEXT = DepthBoundsTestEnable,

    [NativeName("VK_DYNAMIC_STATE_STENCIL_TEST_ENABLE_EXT")]
    StencilTestEnableEXT = StencilTestEnable,

    [NativeName("VK_DYNAMIC_STATE_STENCIL_OP_EXT")]
    StencilOpEXT = StencilOp,

    [NativeName("VK_DYNAMIC_STATE_RASTERIZER_DISCARD_ENABLE_EXT")]
    RasterizerDiscardEnableEXT = RasterizerDiscardEnable,

    [NativeName("VK_DYNAMIC_STATE_DEPTH_BIAS_ENABLE_EXT")]
    DepthBiasEnableEXT = DepthBiasEnable,

    [NativeName("VK_DYNAMIC_STATE_PRIMITIVE_RESTART_ENABLE_EXT")]
    PrimitiveRestartEnableEXT = PrimitiveRestartEnable,

    [NativeName("VK_DYNAMIC_STATE_LINE_STIPPLE_KHR")]
    LineStippleKHR = LineStipple,
}
