// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkDynamicState")]
[SupportedApiProfile("vulkan")]
public enum DynamicState : uint
{
    [NativeName("VK_DYNAMIC_STATE_VIEWPORT")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_GRAPHICS_VERSION_1_0",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_0",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.0"
    )]
    Viewport = 0,

    [NativeName("VK_DYNAMIC_STATE_SCISSOR")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_GRAPHICS_VERSION_1_0",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_0",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.0"
    )]
    Scissor = 1,

    [NativeName("VK_DYNAMIC_STATE_LINE_WIDTH")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_GRAPHICS_VERSION_1_0",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_0",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.0"
    )]
    LineWidth = 2,

    [NativeName("VK_DYNAMIC_STATE_DEPTH_BIAS")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_GRAPHICS_VERSION_1_0",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_0",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.0"
    )]
    DepthBias = 3,

    [NativeName("VK_DYNAMIC_STATE_BLEND_CONSTANTS")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_GRAPHICS_VERSION_1_0",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_0",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.0"
    )]
    BlendConstants = 4,

    [NativeName("VK_DYNAMIC_STATE_DEPTH_BOUNDS")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_GRAPHICS_VERSION_1_0",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_0",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.0"
    )]
    DepthBounds = 5,

    [NativeName("VK_DYNAMIC_STATE_STENCIL_COMPARE_MASK")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_GRAPHICS_VERSION_1_0",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_0",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.0"
    )]
    StencilCompareMask = 6,

    [NativeName("VK_DYNAMIC_STATE_STENCIL_WRITE_MASK")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_GRAPHICS_VERSION_1_0",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_0",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.0"
    )]
    StencilWriteMask = 7,

    [NativeName("VK_DYNAMIC_STATE_STENCIL_REFERENCE")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_GRAPHICS_VERSION_1_0",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_0",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.0"
    )]
    StencilReference = 8,

    [NativeName("VK_DYNAMIC_STATE_CULL_MODE")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_GRAPHICS_VERSION_1_3", "VK_GRAPHICS_VERSION_1_4", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.3"
    )]
    CullMode = 1000267000,

    [NativeName("VK_DYNAMIC_STATE_FRONT_FACE")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_GRAPHICS_VERSION_1_3", "VK_GRAPHICS_VERSION_1_4", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.3"
    )]
    FrontFace = 1000267001,

    [NativeName("VK_DYNAMIC_STATE_PRIMITIVE_TOPOLOGY")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_GRAPHICS_VERSION_1_3", "VK_GRAPHICS_VERSION_1_4", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.3"
    )]
    PrimitiveTopology = 1000267002,

    [NativeName("VK_DYNAMIC_STATE_VIEWPORT_WITH_COUNT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_GRAPHICS_VERSION_1_3", "VK_GRAPHICS_VERSION_1_4", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.3"
    )]
    ViewportWithCount = 1000267003,

    [NativeName("VK_DYNAMIC_STATE_SCISSOR_WITH_COUNT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_GRAPHICS_VERSION_1_3", "VK_GRAPHICS_VERSION_1_4", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.3"
    )]
    ScissorWithCount = 1000267004,

    [NativeName("VK_DYNAMIC_STATE_VERTEX_INPUT_BINDING_STRIDE")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_GRAPHICS_VERSION_1_3", "VK_GRAPHICS_VERSION_1_4", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.3"
    )]
    VertexInputBindingStride = 1000267005,

    [NativeName("VK_DYNAMIC_STATE_DEPTH_TEST_ENABLE")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_GRAPHICS_VERSION_1_3", "VK_GRAPHICS_VERSION_1_4", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.3"
    )]
    DepthTestEnable = 1000267006,

    [NativeName("VK_DYNAMIC_STATE_DEPTH_WRITE_ENABLE")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_GRAPHICS_VERSION_1_3", "VK_GRAPHICS_VERSION_1_4", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.3"
    )]
    DepthWriteEnable = 1000267007,

    [NativeName("VK_DYNAMIC_STATE_DEPTH_COMPARE_OP")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_GRAPHICS_VERSION_1_3", "VK_GRAPHICS_VERSION_1_4", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.3"
    )]
    DepthCompareOp = 1000267008,

    [NativeName("VK_DYNAMIC_STATE_DEPTH_BOUNDS_TEST_ENABLE")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_GRAPHICS_VERSION_1_3", "VK_GRAPHICS_VERSION_1_4", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.3"
    )]
    DepthBoundsTestEnable = 1000267009,

    [NativeName("VK_DYNAMIC_STATE_STENCIL_TEST_ENABLE")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_GRAPHICS_VERSION_1_3", "VK_GRAPHICS_VERSION_1_4", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.3"
    )]
    StencilTestEnable = 1000267010,

    [NativeName("VK_DYNAMIC_STATE_STENCIL_OP")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_GRAPHICS_VERSION_1_3", "VK_GRAPHICS_VERSION_1_4", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.3"
    )]
    StencilOp = 1000267011,

    [NativeName("VK_DYNAMIC_STATE_RASTERIZER_DISCARD_ENABLE")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_GRAPHICS_VERSION_1_3", "VK_GRAPHICS_VERSION_1_4", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.3"
    )]
    RasterizerDiscardEnable = 1000377001,

    [NativeName("VK_DYNAMIC_STATE_DEPTH_BIAS_ENABLE")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_GRAPHICS_VERSION_1_3", "VK_GRAPHICS_VERSION_1_4", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.3"
    )]
    DepthBiasEnable = 1000377002,

    [NativeName("VK_DYNAMIC_STATE_PRIMITIVE_RESTART_ENABLE")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_GRAPHICS_VERSION_1_3", "VK_GRAPHICS_VERSION_1_4", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.3"
    )]
    PrimitiveRestartEnable = 1000377004,

    [NativeName("VK_DYNAMIC_STATE_LINE_STIPPLE")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_GRAPHICS_VERSION_1_4", "VK_VERSION_1_4"],
        MinVersion = "1.4"
    )]
    LineStipple = 1000259000,

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("VK_DYNAMIC_STATE_VIEWPORT_W_SCALING_NV")]
    [SupportedApiProfile("vulkan", ["VK_NV_clip_space_w_scaling"])]
    ViewportWScalingnv = 1000087000,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_DYNAMIC_STATE_DISCARD_RECTANGLE_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_discard_rectangles"],
        ImpliesSets = [
            "VK_EXT_discard_rectangles+VK_KHR_get_physical_device_properties2",
            "VK_EXT_discard_rectangles+VK_VERSION_1_1",
        ]
    )]
    DiscardRectangleext = 1000099000,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_DYNAMIC_STATE_DISCARD_RECTANGLE_ENABLE_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_discard_rectangles"],
        ImpliesSets = [
            "VK_EXT_discard_rectangles+VK_KHR_get_physical_device_properties2",
            "VK_EXT_discard_rectangles+VK_VERSION_1_1",
        ]
    )]
    DiscardRectangleEnableext = 1000099001,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_DYNAMIC_STATE_DISCARD_RECTANGLE_MODE_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_discard_rectangles"],
        ImpliesSets = [
            "VK_EXT_discard_rectangles+VK_KHR_get_physical_device_properties2",
            "VK_EXT_discard_rectangles+VK_VERSION_1_1",
        ]
    )]
    DiscardRectangleModeext = 1000099002,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_DYNAMIC_STATE_SAMPLE_LOCATIONS_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_sample_locations"],
        ImpliesSets = [
            "VK_EXT_sample_locations+VK_KHR_get_physical_device_properties2",
            "VK_EXT_sample_locations+VK_VERSION_1_1",
        ]
    )]
    SampleLocationsext = 1000143000,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_DYNAMIC_STATE_RAY_TRACING_PIPELINE_STACK_SIZE_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_ray_tracing_pipeline"],
        ImpliesSets = [
            "VK_KHR_acceleration_structure+VK_KHR_spirv_1_4",
            "VK_KHR_acceleration_structure+VK_VERSION_1_2",
        ]
    )]
    RayTracingPipelineStackSizekhr = 1000347000,

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("VK_DYNAMIC_STATE_VIEWPORT_SHADING_RATE_PALETTE_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_shading_rate_image"],
        ImpliesSets = [
            "VK_NV_shading_rate_image+VK_KHR_get_physical_device_properties2",
            "VK_NV_shading_rate_image+VK_VERSION_1_1",
        ]
    )]
    ViewportShadingRatePalettenv = 1000164004,

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("VK_DYNAMIC_STATE_VIEWPORT_COARSE_SAMPLE_ORDER_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_shading_rate_image"],
        ImpliesSets = [
            "VK_NV_shading_rate_image+VK_KHR_get_physical_device_properties2",
            "VK_NV_shading_rate_image+VK_VERSION_1_1",
        ]
    )]
    ViewportCoarseSampleOrdernv = 1000164006,

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("VK_DYNAMIC_STATE_EXCLUSIVE_SCISSOR_ENABLE_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_scissor_exclusive"],
        ImpliesSets = [
            "VK_NV_scissor_exclusive+VK_KHR_get_physical_device_properties2",
            "VK_NV_scissor_exclusive+VK_VERSION_1_1",
        ]
    )]
    ExclusiveScissorEnablenv = 1000205000,

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("VK_DYNAMIC_STATE_EXCLUSIVE_SCISSOR_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_scissor_exclusive"],
        ImpliesSets = [
            "VK_NV_scissor_exclusive+VK_KHR_get_physical_device_properties2",
            "VK_NV_scissor_exclusive+VK_VERSION_1_1",
        ]
    )]
    ExclusiveScissornv = 1000205001,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_DYNAMIC_STATE_FRAGMENT_SHADING_RATE_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_fragment_shading_rate"],
        ImpliesSets = [
            "VK_KHR_create_renderpass2+VK_KHR_get_physical_device_properties2",
            "VK_KHR_create_renderpass2+VK_VERSION_1_1",
            "VK_VERSION_1_2",
        ]
    )]
    FragmentShadingRatekhr = 1000226000,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_DYNAMIC_STATE_VERTEX_INPUT_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_vertex_input_dynamic_state"],
        ImpliesSets = [
            "VK_EXT_vertex_input_dynamic_state+VK_KHR_get_physical_device_properties2",
            "VK_EXT_vertex_input_dynamic_state+VK_VERSION_1_1",
        ]
    )]
    VertexInputext = 1000352000,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_DYNAMIC_STATE_PATCH_CONTROL_POINTS_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_extended_dynamic_state2"],
        ImpliesSets = [
            "VK_EXT_extended_dynamic_state2+VK_KHR_get_physical_device_properties2",
            "VK_EXT_extended_dynamic_state2+VK_VERSION_1_1",
        ]
    )]
    PatchControlPointsext = 1000377000,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_DYNAMIC_STATE_LOGIC_OP_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_extended_dynamic_state2"],
        ImpliesSets = [
            "VK_EXT_extended_dynamic_state2+VK_KHR_get_physical_device_properties2",
            "VK_EXT_extended_dynamic_state2+VK_VERSION_1_1",
        ]
    )]
    LogicOpext = 1000377003,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_DYNAMIC_STATE_COLOR_WRITE_ENABLE_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_color_write_enable"],
        ImpliesSets = [
            "VK_EXT_color_write_enable+VK_KHR_get_physical_device_properties2",
            "VK_EXT_color_write_enable+VK_VERSION_1_1",
        ]
    )]
    ColorWriteEnableext = 1000381000,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_DYNAMIC_STATE_DEPTH_CLAMP_ENABLE_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_extended_dynamic_state3"],
        ImpliesSets = [
            "VK_EXT_extended_dynamic_state3+VK_KHR_get_physical_device_properties2",
            "VK_EXT_extended_dynamic_state3+VK_VERSION_1_1",
        ]
    )]
    DepthClampEnableext = 1000455003,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_DYNAMIC_STATE_POLYGON_MODE_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_extended_dynamic_state3"],
        ImpliesSets = [
            "VK_EXT_extended_dynamic_state3+VK_KHR_get_physical_device_properties2",
            "VK_EXT_extended_dynamic_state3+VK_VERSION_1_1",
        ]
    )]
    PolygonModeext = 1000455004,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_DYNAMIC_STATE_RASTERIZATION_SAMPLES_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_extended_dynamic_state3"],
        ImpliesSets = [
            "VK_EXT_extended_dynamic_state3+VK_KHR_get_physical_device_properties2",
            "VK_EXT_extended_dynamic_state3+VK_VERSION_1_1",
        ]
    )]
    RasterizationSamplesext = 1000455005,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_DYNAMIC_STATE_SAMPLE_MASK_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_extended_dynamic_state3"],
        ImpliesSets = [
            "VK_EXT_extended_dynamic_state3+VK_KHR_get_physical_device_properties2",
            "VK_EXT_extended_dynamic_state3+VK_VERSION_1_1",
        ]
    )]
    SampleMaskext = 1000455006,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_DYNAMIC_STATE_ALPHA_TO_COVERAGE_ENABLE_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_extended_dynamic_state3"],
        ImpliesSets = [
            "VK_EXT_extended_dynamic_state3+VK_KHR_get_physical_device_properties2",
            "VK_EXT_extended_dynamic_state3+VK_VERSION_1_1",
        ]
    )]
    AlphaToCoverageEnableext = 1000455007,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_DYNAMIC_STATE_ALPHA_TO_ONE_ENABLE_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_extended_dynamic_state3"],
        ImpliesSets = [
            "VK_EXT_extended_dynamic_state3+VK_KHR_get_physical_device_properties2",
            "VK_EXT_extended_dynamic_state3+VK_VERSION_1_1",
        ]
    )]
    AlphaToOneEnableext = 1000455008,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_DYNAMIC_STATE_LOGIC_OP_ENABLE_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_extended_dynamic_state3"],
        ImpliesSets = [
            "VK_EXT_extended_dynamic_state3+VK_KHR_get_physical_device_properties2",
            "VK_EXT_extended_dynamic_state3+VK_VERSION_1_1",
        ]
    )]
    LogicOpEnableext = 1000455009,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_DYNAMIC_STATE_COLOR_BLEND_ENABLE_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_extended_dynamic_state3"],
        ImpliesSets = [
            "VK_EXT_extended_dynamic_state3+VK_KHR_get_physical_device_properties2",
            "VK_EXT_extended_dynamic_state3+VK_VERSION_1_1",
        ]
    )]
    ColorBlendEnableext = 1000455010,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_DYNAMIC_STATE_COLOR_BLEND_EQUATION_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_extended_dynamic_state3"],
        ImpliesSets = [
            "VK_EXT_extended_dynamic_state3+VK_KHR_get_physical_device_properties2",
            "VK_EXT_extended_dynamic_state3+VK_VERSION_1_1",
        ]
    )]
    ColorBlendEquationext = 1000455011,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_DYNAMIC_STATE_COLOR_WRITE_MASK_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_extended_dynamic_state3"],
        ImpliesSets = [
            "VK_EXT_extended_dynamic_state3+VK_KHR_get_physical_device_properties2",
            "VK_EXT_extended_dynamic_state3+VK_VERSION_1_1",
        ]
    )]
    ColorWriteMaskext = 1000455012,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_DYNAMIC_STATE_TESSELLATION_DOMAIN_ORIGIN_EXT")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_EXT_extended_dynamic_state3+VK_KHR_maintenance2",
            "VK_EXT_extended_dynamic_state3+VK_VERSION_1_1",
        ],
        ImpliesSets = [
            "VK_EXT_extended_dynamic_state3+VK_KHR_get_physical_device_properties2",
            "VK_EXT_extended_dynamic_state3+VK_VERSION_1_1",
        ]
    )]
    TessellationDomainOriginext = 1000455002,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_DYNAMIC_STATE_RASTERIZATION_STREAM_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_extended_dynamic_state3", "VK_EXT_transform_feedback"],
        ImpliesSets = [
            "VK_EXT_extended_dynamic_state3+VK_KHR_get_physical_device_properties2",
            "VK_EXT_extended_dynamic_state3+VK_VERSION_1_1",
        ],
        RequireAll = true
    )]
    RasterizationStreamext = 1000455013,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_DYNAMIC_STATE_CONSERVATIVE_RASTERIZATION_MODE_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_conservative_rasterization", "VK_EXT_extended_dynamic_state3"],
        ImpliesSets = [
            "VK_EXT_extended_dynamic_state3+VK_KHR_get_physical_device_properties2",
            "VK_EXT_extended_dynamic_state3+VK_VERSION_1_1",
        ],
        RequireAll = true
    )]
    ConservativeRasterizationModeext = 1000455014,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_DYNAMIC_STATE_EXTRA_PRIMITIVE_OVERESTIMATION_SIZE_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_conservative_rasterization", "VK_EXT_extended_dynamic_state3"],
        ImpliesSets = [
            "VK_EXT_extended_dynamic_state3+VK_KHR_get_physical_device_properties2",
            "VK_EXT_extended_dynamic_state3+VK_VERSION_1_1",
        ],
        RequireAll = true
    )]
    ExtraPrimitiveOverestimationSizeext = 1000455015,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_DYNAMIC_STATE_DEPTH_CLIP_ENABLE_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_depth_clip_enable", "VK_EXT_extended_dynamic_state3"],
        ImpliesSets = [
            "VK_EXT_extended_dynamic_state3+VK_KHR_get_physical_device_properties2",
            "VK_EXT_extended_dynamic_state3+VK_VERSION_1_1",
        ],
        RequireAll = true
    )]
    DepthClipEnableext = 1000455016,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_DYNAMIC_STATE_SAMPLE_LOCATIONS_ENABLE_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_extended_dynamic_state3", "VK_EXT_sample_locations"],
        ImpliesSets = [
            "VK_EXT_extended_dynamic_state3+VK_KHR_get_physical_device_properties2",
            "VK_EXT_extended_dynamic_state3+VK_VERSION_1_1",
        ],
        RequireAll = true
    )]
    SampleLocationsEnableext = 1000455017,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_DYNAMIC_STATE_COLOR_BLEND_ADVANCED_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_blend_operation_advanced", "VK_EXT_extended_dynamic_state3"],
        ImpliesSets = [
            "VK_EXT_extended_dynamic_state3+VK_KHR_get_physical_device_properties2",
            "VK_EXT_extended_dynamic_state3+VK_VERSION_1_1",
        ],
        RequireAll = true
    )]
    ColorBlendAdvancedext = 1000455018,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_DYNAMIC_STATE_PROVOKING_VERTEX_MODE_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_extended_dynamic_state3", "VK_EXT_provoking_vertex"],
        ImpliesSets = [
            "VK_EXT_extended_dynamic_state3+VK_KHR_get_physical_device_properties2",
            "VK_EXT_extended_dynamic_state3+VK_VERSION_1_1",
        ],
        RequireAll = true
    )]
    ProvokingVertexModeext = 1000455019,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_DYNAMIC_STATE_LINE_RASTERIZATION_MODE_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_extended_dynamic_state3", "VK_EXT_line_rasterization"],
        ImpliesSets = [
            "VK_EXT_extended_dynamic_state3+VK_KHR_get_physical_device_properties2",
            "VK_EXT_extended_dynamic_state3+VK_VERSION_1_1",
        ],
        RequireAll = true
    )]
    LineRasterizationModeext = 1000455020,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_DYNAMIC_STATE_LINE_STIPPLE_ENABLE_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_extended_dynamic_state3", "VK_EXT_line_rasterization"],
        ImpliesSets = [
            "VK_EXT_extended_dynamic_state3+VK_KHR_get_physical_device_properties2",
            "VK_EXT_extended_dynamic_state3+VK_VERSION_1_1",
        ],
        RequireAll = true
    )]
    LineStippleEnableext = 1000455021,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_DYNAMIC_STATE_DEPTH_CLIP_NEGATIVE_ONE_TO_ONE_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_depth_clip_control", "VK_EXT_extended_dynamic_state3"],
        ImpliesSets = [
            "VK_EXT_extended_dynamic_state3+VK_KHR_get_physical_device_properties2",
            "VK_EXT_extended_dynamic_state3+VK_VERSION_1_1",
        ],
        RequireAll = true
    )]
    DepthClipNegativeOneToOneext = 1000455022,

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("VK_DYNAMIC_STATE_VIEWPORT_W_SCALING_ENABLE_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_extended_dynamic_state3", "VK_NV_clip_space_w_scaling"],
        ImpliesSets = [
            "VK_EXT_extended_dynamic_state3+VK_KHR_get_physical_device_properties2",
            "VK_EXT_extended_dynamic_state3+VK_VERSION_1_1",
        ],
        RequireAll = true
    )]
    ViewportWScalingEnablenv = 1000455023,

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("VK_DYNAMIC_STATE_VIEWPORT_SWIZZLE_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_extended_dynamic_state3", "VK_NV_viewport_swizzle"],
        ImpliesSets = [
            "VK_EXT_extended_dynamic_state3+VK_KHR_get_physical_device_properties2",
            "VK_EXT_extended_dynamic_state3+VK_VERSION_1_1",
        ],
        RequireAll = true
    )]
    ViewportSwizzlenv = 1000455024,

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("VK_DYNAMIC_STATE_COVERAGE_TO_COLOR_ENABLE_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_extended_dynamic_state3", "VK_NV_fragment_coverage_to_color"],
        ImpliesSets = [
            "VK_EXT_extended_dynamic_state3+VK_KHR_get_physical_device_properties2",
            "VK_EXT_extended_dynamic_state3+VK_VERSION_1_1",
        ],
        RequireAll = true
    )]
    CoverageToColorEnablenv = 1000455025,

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("VK_DYNAMIC_STATE_COVERAGE_TO_COLOR_LOCATION_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_extended_dynamic_state3", "VK_NV_fragment_coverage_to_color"],
        ImpliesSets = [
            "VK_EXT_extended_dynamic_state3+VK_KHR_get_physical_device_properties2",
            "VK_EXT_extended_dynamic_state3+VK_VERSION_1_1",
        ],
        RequireAll = true
    )]
    CoverageToColorLocationnv = 1000455026,

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("VK_DYNAMIC_STATE_COVERAGE_MODULATION_MODE_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_extended_dynamic_state3", "VK_NV_framebuffer_mixed_samples"],
        ImpliesSets = [
            "VK_EXT_extended_dynamic_state3+VK_KHR_get_physical_device_properties2",
            "VK_EXT_extended_dynamic_state3+VK_VERSION_1_1",
        ],
        RequireAll = true
    )]
    CoverageModulationModenv = 1000455027,

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("VK_DYNAMIC_STATE_COVERAGE_MODULATION_TABLE_ENABLE_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_extended_dynamic_state3", "VK_NV_framebuffer_mixed_samples"],
        ImpliesSets = [
            "VK_EXT_extended_dynamic_state3+VK_KHR_get_physical_device_properties2",
            "VK_EXT_extended_dynamic_state3+VK_VERSION_1_1",
        ],
        RequireAll = true
    )]
    CoverageModulationTableEnablenv = 1000455028,

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("VK_DYNAMIC_STATE_COVERAGE_MODULATION_TABLE_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_extended_dynamic_state3", "VK_NV_framebuffer_mixed_samples"],
        ImpliesSets = [
            "VK_EXT_extended_dynamic_state3+VK_KHR_get_physical_device_properties2",
            "VK_EXT_extended_dynamic_state3+VK_VERSION_1_1",
        ],
        RequireAll = true
    )]
    CoverageModulationTablenv = 1000455029,

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("VK_DYNAMIC_STATE_SHADING_RATE_IMAGE_ENABLE_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_extended_dynamic_state3", "VK_NV_shading_rate_image"],
        ImpliesSets = [
            "VK_EXT_extended_dynamic_state3+VK_KHR_get_physical_device_properties2",
            "VK_EXT_extended_dynamic_state3+VK_VERSION_1_1",
        ],
        RequireAll = true
    )]
    ShadingRateImageEnablenv = 1000455030,

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("VK_DYNAMIC_STATE_REPRESENTATIVE_FRAGMENT_TEST_ENABLE_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_extended_dynamic_state3", "VK_NV_representative_fragment_test"],
        ImpliesSets = [
            "VK_EXT_extended_dynamic_state3+VK_KHR_get_physical_device_properties2",
            "VK_EXT_extended_dynamic_state3+VK_VERSION_1_1",
        ],
        RequireAll = true
    )]
    RepresentativeFragmentTestEnablenv = 1000455031,

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("VK_DYNAMIC_STATE_COVERAGE_REDUCTION_MODE_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_extended_dynamic_state3", "VK_NV_coverage_reduction_mode"],
        ImpliesSets = [
            "VK_EXT_extended_dynamic_state3+VK_KHR_get_physical_device_properties2",
            "VK_EXT_extended_dynamic_state3+VK_VERSION_1_1",
        ],
        RequireAll = true
    )]
    CoverageReductionModenv = 1000455032,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_DYNAMIC_STATE_ATTACHMENT_FEEDBACK_LOOP_ENABLE_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_attachment_feedback_loop_dynamic_state"],
        ImpliesSets = [
            "VK_EXT_attachment_feedback_loop_layout+VK_KHR_get_physical_device_properties2",
            "VK_EXT_attachment_feedback_loop_layout+VK_VERSION_1_1",
        ]
    )]
    AttachmentFeedbackLoopEnableext = 1000524000,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_DYNAMIC_STATE_DEPTH_CLAMP_RANGE_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_depth_clamp_control"],
        ImpliesSets = [
            "VK_EXT_depth_clamp_control+VK_KHR_get_physical_device_properties2",
            "VK_EXT_depth_clamp_control+VK_VERSION_1_1",
        ]
    )]
    DepthClampRangeext = 1000582000,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_DYNAMIC_STATE_LINE_STIPPLE_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_line_rasterization"],
        ImpliesSets = [
            "VK_EXT_line_rasterization+VK_KHR_get_physical_device_properties2",
            "VK_EXT_line_rasterization+VK_VERSION_1_1",
        ]
    )]
    LineStippleext = LineStipple,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_DYNAMIC_STATE_CULL_MODE_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_extended_dynamic_state"],
        ImpliesSets = [
            "VK_EXT_extended_dynamic_state+VK_KHR_get_physical_device_properties2",
            "VK_EXT_extended_dynamic_state+VK_VERSION_1_1",
        ]
    )]
    CullModeext = CullMode,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_DYNAMIC_STATE_FRONT_FACE_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_extended_dynamic_state"],
        ImpliesSets = [
            "VK_EXT_extended_dynamic_state+VK_KHR_get_physical_device_properties2",
            "VK_EXT_extended_dynamic_state+VK_VERSION_1_1",
        ]
    )]
    FrontFaceext = FrontFace,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_DYNAMIC_STATE_PRIMITIVE_TOPOLOGY_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_extended_dynamic_state"],
        ImpliesSets = [
            "VK_EXT_extended_dynamic_state+VK_KHR_get_physical_device_properties2",
            "VK_EXT_extended_dynamic_state+VK_VERSION_1_1",
        ]
    )]
    PrimitiveTopologyext = PrimitiveTopology,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_DYNAMIC_STATE_VIEWPORT_WITH_COUNT_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_extended_dynamic_state"],
        ImpliesSets = [
            "VK_EXT_extended_dynamic_state+VK_KHR_get_physical_device_properties2",
            "VK_EXT_extended_dynamic_state+VK_VERSION_1_1",
        ]
    )]
    ViewportWithCountext = ViewportWithCount,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_DYNAMIC_STATE_SCISSOR_WITH_COUNT_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_extended_dynamic_state"],
        ImpliesSets = [
            "VK_EXT_extended_dynamic_state+VK_KHR_get_physical_device_properties2",
            "VK_EXT_extended_dynamic_state+VK_VERSION_1_1",
        ]
    )]
    ScissorWithCountext = ScissorWithCount,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_DYNAMIC_STATE_VERTEX_INPUT_BINDING_STRIDE_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_extended_dynamic_state"],
        ImpliesSets = [
            "VK_EXT_extended_dynamic_state+VK_KHR_get_physical_device_properties2",
            "VK_EXT_extended_dynamic_state+VK_VERSION_1_1",
        ]
    )]
    VertexInputBindingStrideext = VertexInputBindingStride,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_DYNAMIC_STATE_DEPTH_TEST_ENABLE_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_extended_dynamic_state"],
        ImpliesSets = [
            "VK_EXT_extended_dynamic_state+VK_KHR_get_physical_device_properties2",
            "VK_EXT_extended_dynamic_state+VK_VERSION_1_1",
        ]
    )]
    DepthTestEnableext = DepthTestEnable,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_DYNAMIC_STATE_DEPTH_WRITE_ENABLE_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_extended_dynamic_state"],
        ImpliesSets = [
            "VK_EXT_extended_dynamic_state+VK_KHR_get_physical_device_properties2",
            "VK_EXT_extended_dynamic_state+VK_VERSION_1_1",
        ]
    )]
    DepthWriteEnableext = DepthWriteEnable,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_DYNAMIC_STATE_DEPTH_COMPARE_OP_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_extended_dynamic_state"],
        ImpliesSets = [
            "VK_EXT_extended_dynamic_state+VK_KHR_get_physical_device_properties2",
            "VK_EXT_extended_dynamic_state+VK_VERSION_1_1",
        ]
    )]
    DepthCompareOpext = DepthCompareOp,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_DYNAMIC_STATE_DEPTH_BOUNDS_TEST_ENABLE_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_extended_dynamic_state"],
        ImpliesSets = [
            "VK_EXT_extended_dynamic_state+VK_KHR_get_physical_device_properties2",
            "VK_EXT_extended_dynamic_state+VK_VERSION_1_1",
        ]
    )]
    DepthBoundsTestEnableext = DepthBoundsTestEnable,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_DYNAMIC_STATE_STENCIL_TEST_ENABLE_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_extended_dynamic_state"],
        ImpliesSets = [
            "VK_EXT_extended_dynamic_state+VK_KHR_get_physical_device_properties2",
            "VK_EXT_extended_dynamic_state+VK_VERSION_1_1",
        ]
    )]
    StencilTestEnableext = StencilTestEnable,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_DYNAMIC_STATE_STENCIL_OP_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_extended_dynamic_state"],
        ImpliesSets = [
            "VK_EXT_extended_dynamic_state+VK_KHR_get_physical_device_properties2",
            "VK_EXT_extended_dynamic_state+VK_VERSION_1_1",
        ]
    )]
    StencilOpext = StencilOp,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_DYNAMIC_STATE_RASTERIZER_DISCARD_ENABLE_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_extended_dynamic_state2"],
        ImpliesSets = [
            "VK_EXT_extended_dynamic_state2+VK_KHR_get_physical_device_properties2",
            "VK_EXT_extended_dynamic_state2+VK_VERSION_1_1",
        ]
    )]
    RasterizerDiscardEnableext = RasterizerDiscardEnable,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_DYNAMIC_STATE_DEPTH_BIAS_ENABLE_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_extended_dynamic_state2"],
        ImpliesSets = [
            "VK_EXT_extended_dynamic_state2+VK_KHR_get_physical_device_properties2",
            "VK_EXT_extended_dynamic_state2+VK_VERSION_1_1",
        ]
    )]
    DepthBiasEnableext = DepthBiasEnable,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_DYNAMIC_STATE_PRIMITIVE_RESTART_ENABLE_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_extended_dynamic_state2"],
        ImpliesSets = [
            "VK_EXT_extended_dynamic_state2+VK_KHR_get_physical_device_properties2",
            "VK_EXT_extended_dynamic_state2+VK_VERSION_1_1",
        ]
    )]
    PrimitiveRestartEnableext = PrimitiveRestartEnable,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_DYNAMIC_STATE_LINE_STIPPLE_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_line_rasterization"],
        ImpliesSets = [
            "VK_KHR_line_rasterization+VK_KHR_get_physical_device_properties2",
            "VK_KHR_line_rasterization+VK_VERSION_1_1",
        ]
    )]
    LineStipplekhr = LineStipple,
}
