// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public enum VkDynamicState
{
    [SupportedApiProfile(
        "vulkan",
        ["VK_VERSION_1_0", "VK_VERSION_1_1", "VK_VERSION_1_2", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.0"
    )]
    VK_DYNAMIC_STATE_VIEWPORT = 0,

    [SupportedApiProfile(
        "vulkan",
        ["VK_VERSION_1_0", "VK_VERSION_1_1", "VK_VERSION_1_2", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.0"
    )]
    VK_DYNAMIC_STATE_SCISSOR = 1,

    [SupportedApiProfile(
        "vulkan",
        ["VK_VERSION_1_0", "VK_VERSION_1_1", "VK_VERSION_1_2", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.0"
    )]
    VK_DYNAMIC_STATE_LINE_WIDTH = 2,

    [SupportedApiProfile(
        "vulkan",
        ["VK_VERSION_1_0", "VK_VERSION_1_1", "VK_VERSION_1_2", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.0"
    )]
    VK_DYNAMIC_STATE_DEPTH_BIAS = 3,

    [SupportedApiProfile(
        "vulkan",
        ["VK_VERSION_1_0", "VK_VERSION_1_1", "VK_VERSION_1_2", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.0"
    )]
    VK_DYNAMIC_STATE_BLEND_CONSTANTS = 4,

    [SupportedApiProfile(
        "vulkan",
        ["VK_VERSION_1_0", "VK_VERSION_1_1", "VK_VERSION_1_2", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.0"
    )]
    VK_DYNAMIC_STATE_DEPTH_BOUNDS = 5,

    [SupportedApiProfile(
        "vulkan",
        ["VK_VERSION_1_0", "VK_VERSION_1_1", "VK_VERSION_1_2", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.0"
    )]
    VK_DYNAMIC_STATE_STENCIL_COMPARE_MASK = 6,

    [SupportedApiProfile(
        "vulkan",
        ["VK_VERSION_1_0", "VK_VERSION_1_1", "VK_VERSION_1_2", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.0"
    )]
    VK_DYNAMIC_STATE_STENCIL_WRITE_MASK = 7,

    [SupportedApiProfile(
        "vulkan",
        ["VK_VERSION_1_0", "VK_VERSION_1_1", "VK_VERSION_1_2", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.0"
    )]
    VK_DYNAMIC_STATE_STENCIL_REFERENCE = 8,

    [SupportedApiProfile("vulkan", ["VK_VERSION_1_3", "VK_VERSION_1_4"], MinVersion = "1.3")]
    VK_DYNAMIC_STATE_CULL_MODE = 1000267000,

    [SupportedApiProfile("vulkan", ["VK_VERSION_1_3", "VK_VERSION_1_4"], MinVersion = "1.3")]
    VK_DYNAMIC_STATE_FRONT_FACE = 1000267001,

    [SupportedApiProfile("vulkan", ["VK_VERSION_1_3", "VK_VERSION_1_4"], MinVersion = "1.3")]
    VK_DYNAMIC_STATE_PRIMITIVE_TOPOLOGY = 1000267002,

    [SupportedApiProfile("vulkan", ["VK_VERSION_1_3", "VK_VERSION_1_4"], MinVersion = "1.3")]
    VK_DYNAMIC_STATE_VIEWPORT_WITH_COUNT = 1000267003,

    [SupportedApiProfile("vulkan", ["VK_VERSION_1_3", "VK_VERSION_1_4"], MinVersion = "1.3")]
    VK_DYNAMIC_STATE_SCISSOR_WITH_COUNT = 1000267004,

    [SupportedApiProfile("vulkan", ["VK_VERSION_1_3", "VK_VERSION_1_4"], MinVersion = "1.3")]
    VK_DYNAMIC_STATE_VERTEX_INPUT_BINDING_STRIDE = 1000267005,

    [SupportedApiProfile("vulkan", ["VK_VERSION_1_3", "VK_VERSION_1_4"], MinVersion = "1.3")]
    VK_DYNAMIC_STATE_DEPTH_TEST_ENABLE = 1000267006,

    [SupportedApiProfile("vulkan", ["VK_VERSION_1_3", "VK_VERSION_1_4"], MinVersion = "1.3")]
    VK_DYNAMIC_STATE_DEPTH_WRITE_ENABLE = 1000267007,

    [SupportedApiProfile("vulkan", ["VK_VERSION_1_3", "VK_VERSION_1_4"], MinVersion = "1.3")]
    VK_DYNAMIC_STATE_DEPTH_COMPARE_OP = 1000267008,

    [SupportedApiProfile("vulkan", ["VK_VERSION_1_3", "VK_VERSION_1_4"], MinVersion = "1.3")]
    VK_DYNAMIC_STATE_DEPTH_BOUNDS_TEST_ENABLE = 1000267009,

    [SupportedApiProfile("vulkan", ["VK_VERSION_1_3", "VK_VERSION_1_4"], MinVersion = "1.3")]
    VK_DYNAMIC_STATE_STENCIL_TEST_ENABLE = 1000267010,

    [SupportedApiProfile("vulkan", ["VK_VERSION_1_3", "VK_VERSION_1_4"], MinVersion = "1.3")]
    VK_DYNAMIC_STATE_STENCIL_OP = 1000267011,

    [SupportedApiProfile("vulkan", ["VK_VERSION_1_3", "VK_VERSION_1_4"], MinVersion = "1.3")]
    VK_DYNAMIC_STATE_RASTERIZER_DISCARD_ENABLE = 1000377001,

    [SupportedApiProfile("vulkan", ["VK_VERSION_1_3", "VK_VERSION_1_4"], MinVersion = "1.3")]
    VK_DYNAMIC_STATE_DEPTH_BIAS_ENABLE = 1000377002,

    [SupportedApiProfile("vulkan", ["VK_VERSION_1_3", "VK_VERSION_1_4"], MinVersion = "1.3")]
    VK_DYNAMIC_STATE_PRIMITIVE_RESTART_ENABLE = 1000377004,

    [SupportedApiProfile("vulkan", ["VK_VERSION_1_4"], MinVersion = "1.4")]
    VK_DYNAMIC_STATE_LINE_STIPPLE = 1000259000,

    [SupportedApiProfile("vulkan", ["VK_NV_clip_space_w_scaling"])]
    VK_DYNAMIC_STATE_VIEWPORT_W_SCALING_NV = 1000087000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_discard_rectangles"],
        ImpliesSets = [
            "VK_EXT_discard_rectangles+VK_KHR_get_physical_device_properties2",
            "VK_EXT_discard_rectangles+VK_VERSION_1_1",
        ]
    )]
    VK_DYNAMIC_STATE_DISCARD_RECTANGLE_EXT = 1000099000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_discard_rectangles"],
        ImpliesSets = [
            "VK_EXT_discard_rectangles+VK_KHR_get_physical_device_properties2",
            "VK_EXT_discard_rectangles+VK_VERSION_1_1",
        ]
    )]
    VK_DYNAMIC_STATE_DISCARD_RECTANGLE_ENABLE_EXT = 1000099001,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_discard_rectangles"],
        ImpliesSets = [
            "VK_EXT_discard_rectangles+VK_KHR_get_physical_device_properties2",
            "VK_EXT_discard_rectangles+VK_VERSION_1_1",
        ]
    )]
    VK_DYNAMIC_STATE_DISCARD_RECTANGLE_MODE_EXT = 1000099002,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_sample_locations"],
        ImpliesSets = [
            "VK_EXT_sample_locations+VK_KHR_get_physical_device_properties2",
            "VK_EXT_sample_locations+VK_VERSION_1_1",
        ]
    )]
    VK_DYNAMIC_STATE_SAMPLE_LOCATIONS_EXT = 1000143000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_ray_tracing_pipeline"],
        ImpliesSets = [
            "VK_KHR_acceleration_structure+VK_KHR_spirv_1_4",
            "VK_KHR_acceleration_structure+VK_VERSION_1_2",
        ]
    )]
    VK_DYNAMIC_STATE_RAY_TRACING_PIPELINE_STACK_SIZE_KHR = 1000347000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_shading_rate_image"],
        ImpliesSets = [
            "VK_NV_shading_rate_image+VK_KHR_get_physical_device_properties2",
            "VK_NV_shading_rate_image+VK_VERSION_1_1",
        ]
    )]
    VK_DYNAMIC_STATE_VIEWPORT_SHADING_RATE_PALETTE_NV = 1000164004,

    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_shading_rate_image"],
        ImpliesSets = [
            "VK_NV_shading_rate_image+VK_KHR_get_physical_device_properties2",
            "VK_NV_shading_rate_image+VK_VERSION_1_1",
        ]
    )]
    VK_DYNAMIC_STATE_VIEWPORT_COARSE_SAMPLE_ORDER_NV = 1000164006,

    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_scissor_exclusive"],
        ImpliesSets = [
            "VK_NV_scissor_exclusive+VK_KHR_get_physical_device_properties2",
            "VK_NV_scissor_exclusive+VK_VERSION_1_1",
        ]
    )]
    VK_DYNAMIC_STATE_EXCLUSIVE_SCISSOR_ENABLE_NV = 1000205000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_scissor_exclusive"],
        ImpliesSets = [
            "VK_NV_scissor_exclusive+VK_KHR_get_physical_device_properties2",
            "VK_NV_scissor_exclusive+VK_VERSION_1_1",
        ]
    )]
    VK_DYNAMIC_STATE_EXCLUSIVE_SCISSOR_NV = 1000205001,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_fragment_shading_rate"],
        ImpliesSets = [
            "VK_KHR_create_renderpass2+VK_KHR_get_physical_device_properties2",
            "VK_KHR_create_renderpass2+VK_VERSION_1_1",
            "VK_VERSION_1_2",
        ]
    )]
    VK_DYNAMIC_STATE_FRAGMENT_SHADING_RATE_KHR = 1000226000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_vertex_input_dynamic_state"],
        ImpliesSets = [
            "VK_EXT_vertex_input_dynamic_state+VK_KHR_get_physical_device_properties2",
            "VK_EXT_vertex_input_dynamic_state+VK_VERSION_1_1",
        ]
    )]
    VK_DYNAMIC_STATE_VERTEX_INPUT_EXT = 1000352000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_extended_dynamic_state2"],
        ImpliesSets = [
            "VK_EXT_extended_dynamic_state2+VK_KHR_get_physical_device_properties2",
            "VK_EXT_extended_dynamic_state2+VK_VERSION_1_1",
        ]
    )]
    VK_DYNAMIC_STATE_PATCH_CONTROL_POINTS_EXT = 1000377000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_extended_dynamic_state2"],
        ImpliesSets = [
            "VK_EXT_extended_dynamic_state2+VK_KHR_get_physical_device_properties2",
            "VK_EXT_extended_dynamic_state2+VK_VERSION_1_1",
        ]
    )]
    VK_DYNAMIC_STATE_LOGIC_OP_EXT = 1000377003,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_color_write_enable"],
        ImpliesSets = [
            "VK_EXT_color_write_enable+VK_KHR_get_physical_device_properties2",
            "VK_EXT_color_write_enable+VK_VERSION_1_1",
        ]
    )]
    VK_DYNAMIC_STATE_COLOR_WRITE_ENABLE_EXT = 1000381000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_extended_dynamic_state3"],
        ImpliesSets = [
            "VK_EXT_extended_dynamic_state3+VK_KHR_get_physical_device_properties2",
            "VK_EXT_extended_dynamic_state3+VK_VERSION_1_1",
        ]
    )]
    VK_DYNAMIC_STATE_DEPTH_CLAMP_ENABLE_EXT = 1000455003,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_extended_dynamic_state3"],
        ImpliesSets = [
            "VK_EXT_extended_dynamic_state3+VK_KHR_get_physical_device_properties2",
            "VK_EXT_extended_dynamic_state3+VK_VERSION_1_1",
        ]
    )]
    VK_DYNAMIC_STATE_POLYGON_MODE_EXT = 1000455004,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_extended_dynamic_state3"],
        ImpliesSets = [
            "VK_EXT_extended_dynamic_state3+VK_KHR_get_physical_device_properties2",
            "VK_EXT_extended_dynamic_state3+VK_VERSION_1_1",
        ]
    )]
    VK_DYNAMIC_STATE_RASTERIZATION_SAMPLES_EXT = 1000455005,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_extended_dynamic_state3"],
        ImpliesSets = [
            "VK_EXT_extended_dynamic_state3+VK_KHR_get_physical_device_properties2",
            "VK_EXT_extended_dynamic_state3+VK_VERSION_1_1",
        ]
    )]
    VK_DYNAMIC_STATE_SAMPLE_MASK_EXT = 1000455006,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_extended_dynamic_state3"],
        ImpliesSets = [
            "VK_EXT_extended_dynamic_state3+VK_KHR_get_physical_device_properties2",
            "VK_EXT_extended_dynamic_state3+VK_VERSION_1_1",
        ]
    )]
    VK_DYNAMIC_STATE_ALPHA_TO_COVERAGE_ENABLE_EXT = 1000455007,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_extended_dynamic_state3"],
        ImpliesSets = [
            "VK_EXT_extended_dynamic_state3+VK_KHR_get_physical_device_properties2",
            "VK_EXT_extended_dynamic_state3+VK_VERSION_1_1",
        ]
    )]
    VK_DYNAMIC_STATE_ALPHA_TO_ONE_ENABLE_EXT = 1000455008,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_extended_dynamic_state3"],
        ImpliesSets = [
            "VK_EXT_extended_dynamic_state3+VK_KHR_get_physical_device_properties2",
            "VK_EXT_extended_dynamic_state3+VK_VERSION_1_1",
        ]
    )]
    VK_DYNAMIC_STATE_LOGIC_OP_ENABLE_EXT = 1000455009,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_extended_dynamic_state3"],
        ImpliesSets = [
            "VK_EXT_extended_dynamic_state3+VK_KHR_get_physical_device_properties2",
            "VK_EXT_extended_dynamic_state3+VK_VERSION_1_1",
        ]
    )]
    VK_DYNAMIC_STATE_COLOR_BLEND_ENABLE_EXT = 1000455010,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_extended_dynamic_state3"],
        ImpliesSets = [
            "VK_EXT_extended_dynamic_state3+VK_KHR_get_physical_device_properties2",
            "VK_EXT_extended_dynamic_state3+VK_VERSION_1_1",
        ]
    )]
    VK_DYNAMIC_STATE_COLOR_BLEND_EQUATION_EXT = 1000455011,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_extended_dynamic_state3"],
        ImpliesSets = [
            "VK_EXT_extended_dynamic_state3+VK_KHR_get_physical_device_properties2",
            "VK_EXT_extended_dynamic_state3+VK_VERSION_1_1",
        ]
    )]
    VK_DYNAMIC_STATE_COLOR_WRITE_MASK_EXT = 1000455012,

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
    VK_DYNAMIC_STATE_TESSELLATION_DOMAIN_ORIGIN_EXT = 1000455002,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_extended_dynamic_state3", "VK_EXT_transform_feedback"],
        ImpliesSets = [
            "VK_EXT_extended_dynamic_state3+VK_KHR_get_physical_device_properties2",
            "VK_EXT_extended_dynamic_state3+VK_VERSION_1_1",
        ],
        RequireAll = true
    )]
    VK_DYNAMIC_STATE_RASTERIZATION_STREAM_EXT = 1000455013,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_conservative_rasterization", "VK_EXT_extended_dynamic_state3"],
        ImpliesSets = [
            "VK_EXT_extended_dynamic_state3+VK_KHR_get_physical_device_properties2",
            "VK_EXT_extended_dynamic_state3+VK_VERSION_1_1",
        ],
        RequireAll = true
    )]
    VK_DYNAMIC_STATE_CONSERVATIVE_RASTERIZATION_MODE_EXT = 1000455014,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_conservative_rasterization", "VK_EXT_extended_dynamic_state3"],
        ImpliesSets = [
            "VK_EXT_extended_dynamic_state3+VK_KHR_get_physical_device_properties2",
            "VK_EXT_extended_dynamic_state3+VK_VERSION_1_1",
        ],
        RequireAll = true
    )]
    VK_DYNAMIC_STATE_EXTRA_PRIMITIVE_OVERESTIMATION_SIZE_EXT = 1000455015,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_depth_clip_enable", "VK_EXT_extended_dynamic_state3"],
        ImpliesSets = [
            "VK_EXT_extended_dynamic_state3+VK_KHR_get_physical_device_properties2",
            "VK_EXT_extended_dynamic_state3+VK_VERSION_1_1",
        ],
        RequireAll = true
    )]
    VK_DYNAMIC_STATE_DEPTH_CLIP_ENABLE_EXT = 1000455016,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_extended_dynamic_state3", "VK_EXT_sample_locations"],
        ImpliesSets = [
            "VK_EXT_extended_dynamic_state3+VK_KHR_get_physical_device_properties2",
            "VK_EXT_extended_dynamic_state3+VK_VERSION_1_1",
        ],
        RequireAll = true
    )]
    VK_DYNAMIC_STATE_SAMPLE_LOCATIONS_ENABLE_EXT = 1000455017,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_blend_operation_advanced", "VK_EXT_extended_dynamic_state3"],
        ImpliesSets = [
            "VK_EXT_extended_dynamic_state3+VK_KHR_get_physical_device_properties2",
            "VK_EXT_extended_dynamic_state3+VK_VERSION_1_1",
        ],
        RequireAll = true
    )]
    VK_DYNAMIC_STATE_COLOR_BLEND_ADVANCED_EXT = 1000455018,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_extended_dynamic_state3", "VK_EXT_provoking_vertex"],
        ImpliesSets = [
            "VK_EXT_extended_dynamic_state3+VK_KHR_get_physical_device_properties2",
            "VK_EXT_extended_dynamic_state3+VK_VERSION_1_1",
        ],
        RequireAll = true
    )]
    VK_DYNAMIC_STATE_PROVOKING_VERTEX_MODE_EXT = 1000455019,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_extended_dynamic_state3", "VK_EXT_line_rasterization"],
        ImpliesSets = [
            "VK_EXT_extended_dynamic_state3+VK_KHR_get_physical_device_properties2",
            "VK_EXT_extended_dynamic_state3+VK_VERSION_1_1",
        ],
        RequireAll = true
    )]
    VK_DYNAMIC_STATE_LINE_RASTERIZATION_MODE_EXT = 1000455020,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_extended_dynamic_state3", "VK_EXT_line_rasterization"],
        ImpliesSets = [
            "VK_EXT_extended_dynamic_state3+VK_KHR_get_physical_device_properties2",
            "VK_EXT_extended_dynamic_state3+VK_VERSION_1_1",
        ],
        RequireAll = true
    )]
    VK_DYNAMIC_STATE_LINE_STIPPLE_ENABLE_EXT = 1000455021,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_depth_clip_control", "VK_EXT_extended_dynamic_state3"],
        ImpliesSets = [
            "VK_EXT_extended_dynamic_state3+VK_KHR_get_physical_device_properties2",
            "VK_EXT_extended_dynamic_state3+VK_VERSION_1_1",
        ],
        RequireAll = true
    )]
    VK_DYNAMIC_STATE_DEPTH_CLIP_NEGATIVE_ONE_TO_ONE_EXT = 1000455022,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_extended_dynamic_state3", "VK_NV_clip_space_w_scaling"],
        ImpliesSets = [
            "VK_EXT_extended_dynamic_state3+VK_KHR_get_physical_device_properties2",
            "VK_EXT_extended_dynamic_state3+VK_VERSION_1_1",
        ],
        RequireAll = true
    )]
    VK_DYNAMIC_STATE_VIEWPORT_W_SCALING_ENABLE_NV = 1000455023,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_extended_dynamic_state3", "VK_NV_viewport_swizzle"],
        ImpliesSets = [
            "VK_EXT_extended_dynamic_state3+VK_KHR_get_physical_device_properties2",
            "VK_EXT_extended_dynamic_state3+VK_VERSION_1_1",
        ],
        RequireAll = true
    )]
    VK_DYNAMIC_STATE_VIEWPORT_SWIZZLE_NV = 1000455024,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_extended_dynamic_state3", "VK_NV_fragment_coverage_to_color"],
        ImpliesSets = [
            "VK_EXT_extended_dynamic_state3+VK_KHR_get_physical_device_properties2",
            "VK_EXT_extended_dynamic_state3+VK_VERSION_1_1",
        ],
        RequireAll = true
    )]
    VK_DYNAMIC_STATE_COVERAGE_TO_COLOR_ENABLE_NV = 1000455025,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_extended_dynamic_state3", "VK_NV_fragment_coverage_to_color"],
        ImpliesSets = [
            "VK_EXT_extended_dynamic_state3+VK_KHR_get_physical_device_properties2",
            "VK_EXT_extended_dynamic_state3+VK_VERSION_1_1",
        ],
        RequireAll = true
    )]
    VK_DYNAMIC_STATE_COVERAGE_TO_COLOR_LOCATION_NV = 1000455026,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_extended_dynamic_state3", "VK_NV_framebuffer_mixed_samples"],
        ImpliesSets = [
            "VK_EXT_extended_dynamic_state3+VK_KHR_get_physical_device_properties2",
            "VK_EXT_extended_dynamic_state3+VK_VERSION_1_1",
        ],
        RequireAll = true
    )]
    VK_DYNAMIC_STATE_COVERAGE_MODULATION_MODE_NV = 1000455027,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_extended_dynamic_state3", "VK_NV_framebuffer_mixed_samples"],
        ImpliesSets = [
            "VK_EXT_extended_dynamic_state3+VK_KHR_get_physical_device_properties2",
            "VK_EXT_extended_dynamic_state3+VK_VERSION_1_1",
        ],
        RequireAll = true
    )]
    VK_DYNAMIC_STATE_COVERAGE_MODULATION_TABLE_ENABLE_NV = 1000455028,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_extended_dynamic_state3", "VK_NV_framebuffer_mixed_samples"],
        ImpliesSets = [
            "VK_EXT_extended_dynamic_state3+VK_KHR_get_physical_device_properties2",
            "VK_EXT_extended_dynamic_state3+VK_VERSION_1_1",
        ],
        RequireAll = true
    )]
    VK_DYNAMIC_STATE_COVERAGE_MODULATION_TABLE_NV = 1000455029,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_extended_dynamic_state3", "VK_NV_shading_rate_image"],
        ImpliesSets = [
            "VK_EXT_extended_dynamic_state3+VK_KHR_get_physical_device_properties2",
            "VK_EXT_extended_dynamic_state3+VK_VERSION_1_1",
        ],
        RequireAll = true
    )]
    VK_DYNAMIC_STATE_SHADING_RATE_IMAGE_ENABLE_NV = 1000455030,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_extended_dynamic_state3", "VK_NV_representative_fragment_test"],
        ImpliesSets = [
            "VK_EXT_extended_dynamic_state3+VK_KHR_get_physical_device_properties2",
            "VK_EXT_extended_dynamic_state3+VK_VERSION_1_1",
        ],
        RequireAll = true
    )]
    VK_DYNAMIC_STATE_REPRESENTATIVE_FRAGMENT_TEST_ENABLE_NV = 1000455031,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_extended_dynamic_state3", "VK_NV_coverage_reduction_mode"],
        ImpliesSets = [
            "VK_EXT_extended_dynamic_state3+VK_KHR_get_physical_device_properties2",
            "VK_EXT_extended_dynamic_state3+VK_VERSION_1_1",
        ],
        RequireAll = true
    )]
    VK_DYNAMIC_STATE_COVERAGE_REDUCTION_MODE_NV = 1000455032,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_attachment_feedback_loop_dynamic_state"],
        ImpliesSets = [
            "VK_EXT_attachment_feedback_loop_layout+VK_KHR_get_physical_device_properties2",
            "VK_EXT_attachment_feedback_loop_layout+VK_VERSION_1_1",
        ]
    )]
    VK_DYNAMIC_STATE_ATTACHMENT_FEEDBACK_LOOP_ENABLE_EXT = 1000524000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_depth_clamp_control"],
        ImpliesSets = [
            "VK_EXT_depth_clamp_control+VK_KHR_get_physical_device_properties2",
            "VK_EXT_depth_clamp_control+VK_VERSION_1_1",
        ]
    )]
    VK_DYNAMIC_STATE_DEPTH_CLAMP_RANGE_EXT = 1000582000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_line_rasterization"],
        ImpliesSets = [
            "VK_EXT_line_rasterization+VK_KHR_get_physical_device_properties2",
            "VK_EXT_line_rasterization+VK_VERSION_1_1",
        ]
    )]
    VK_DYNAMIC_STATE_LINE_STIPPLE_EXT = VK_DYNAMIC_STATE_LINE_STIPPLE,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_extended_dynamic_state"],
        ImpliesSets = [
            "VK_EXT_extended_dynamic_state+VK_KHR_get_physical_device_properties2",
            "VK_EXT_extended_dynamic_state+VK_VERSION_1_1",
        ]
    )]
    VK_DYNAMIC_STATE_CULL_MODE_EXT = VK_DYNAMIC_STATE_CULL_MODE,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_extended_dynamic_state"],
        ImpliesSets = [
            "VK_EXT_extended_dynamic_state+VK_KHR_get_physical_device_properties2",
            "VK_EXT_extended_dynamic_state+VK_VERSION_1_1",
        ]
    )]
    VK_DYNAMIC_STATE_FRONT_FACE_EXT = VK_DYNAMIC_STATE_FRONT_FACE,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_extended_dynamic_state"],
        ImpliesSets = [
            "VK_EXT_extended_dynamic_state+VK_KHR_get_physical_device_properties2",
            "VK_EXT_extended_dynamic_state+VK_VERSION_1_1",
        ]
    )]
    VK_DYNAMIC_STATE_PRIMITIVE_TOPOLOGY_EXT = VK_DYNAMIC_STATE_PRIMITIVE_TOPOLOGY,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_extended_dynamic_state"],
        ImpliesSets = [
            "VK_EXT_extended_dynamic_state+VK_KHR_get_physical_device_properties2",
            "VK_EXT_extended_dynamic_state+VK_VERSION_1_1",
        ]
    )]
    VK_DYNAMIC_STATE_VIEWPORT_WITH_COUNT_EXT = VK_DYNAMIC_STATE_VIEWPORT_WITH_COUNT,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_extended_dynamic_state"],
        ImpliesSets = [
            "VK_EXT_extended_dynamic_state+VK_KHR_get_physical_device_properties2",
            "VK_EXT_extended_dynamic_state+VK_VERSION_1_1",
        ]
    )]
    VK_DYNAMIC_STATE_SCISSOR_WITH_COUNT_EXT = VK_DYNAMIC_STATE_SCISSOR_WITH_COUNT,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_extended_dynamic_state"],
        ImpliesSets = [
            "VK_EXT_extended_dynamic_state+VK_KHR_get_physical_device_properties2",
            "VK_EXT_extended_dynamic_state+VK_VERSION_1_1",
        ]
    )]
    VK_DYNAMIC_STATE_VERTEX_INPUT_BINDING_STRIDE_EXT = VK_DYNAMIC_STATE_VERTEX_INPUT_BINDING_STRIDE,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_extended_dynamic_state"],
        ImpliesSets = [
            "VK_EXT_extended_dynamic_state+VK_KHR_get_physical_device_properties2",
            "VK_EXT_extended_dynamic_state+VK_VERSION_1_1",
        ]
    )]
    VK_DYNAMIC_STATE_DEPTH_TEST_ENABLE_EXT = VK_DYNAMIC_STATE_DEPTH_TEST_ENABLE,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_extended_dynamic_state"],
        ImpliesSets = [
            "VK_EXT_extended_dynamic_state+VK_KHR_get_physical_device_properties2",
            "VK_EXT_extended_dynamic_state+VK_VERSION_1_1",
        ]
    )]
    VK_DYNAMIC_STATE_DEPTH_WRITE_ENABLE_EXT = VK_DYNAMIC_STATE_DEPTH_WRITE_ENABLE,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_extended_dynamic_state"],
        ImpliesSets = [
            "VK_EXT_extended_dynamic_state+VK_KHR_get_physical_device_properties2",
            "VK_EXT_extended_dynamic_state+VK_VERSION_1_1",
        ]
    )]
    VK_DYNAMIC_STATE_DEPTH_COMPARE_OP_EXT = VK_DYNAMIC_STATE_DEPTH_COMPARE_OP,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_extended_dynamic_state"],
        ImpliesSets = [
            "VK_EXT_extended_dynamic_state+VK_KHR_get_physical_device_properties2",
            "VK_EXT_extended_dynamic_state+VK_VERSION_1_1",
        ]
    )]
    VK_DYNAMIC_STATE_DEPTH_BOUNDS_TEST_ENABLE_EXT = VK_DYNAMIC_STATE_DEPTH_BOUNDS_TEST_ENABLE,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_extended_dynamic_state"],
        ImpliesSets = [
            "VK_EXT_extended_dynamic_state+VK_KHR_get_physical_device_properties2",
            "VK_EXT_extended_dynamic_state+VK_VERSION_1_1",
        ]
    )]
    VK_DYNAMIC_STATE_STENCIL_TEST_ENABLE_EXT = VK_DYNAMIC_STATE_STENCIL_TEST_ENABLE,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_extended_dynamic_state"],
        ImpliesSets = [
            "VK_EXT_extended_dynamic_state+VK_KHR_get_physical_device_properties2",
            "VK_EXT_extended_dynamic_state+VK_VERSION_1_1",
        ]
    )]
    VK_DYNAMIC_STATE_STENCIL_OP_EXT = VK_DYNAMIC_STATE_STENCIL_OP,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_extended_dynamic_state2"],
        ImpliesSets = [
            "VK_EXT_extended_dynamic_state2+VK_KHR_get_physical_device_properties2",
            "VK_EXT_extended_dynamic_state2+VK_VERSION_1_1",
        ]
    )]
    VK_DYNAMIC_STATE_RASTERIZER_DISCARD_ENABLE_EXT = VK_DYNAMIC_STATE_RASTERIZER_DISCARD_ENABLE,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_extended_dynamic_state2"],
        ImpliesSets = [
            "VK_EXT_extended_dynamic_state2+VK_KHR_get_physical_device_properties2",
            "VK_EXT_extended_dynamic_state2+VK_VERSION_1_1",
        ]
    )]
    VK_DYNAMIC_STATE_DEPTH_BIAS_ENABLE_EXT = VK_DYNAMIC_STATE_DEPTH_BIAS_ENABLE,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_extended_dynamic_state2"],
        ImpliesSets = [
            "VK_EXT_extended_dynamic_state2+VK_KHR_get_physical_device_properties2",
            "VK_EXT_extended_dynamic_state2+VK_VERSION_1_1",
        ]
    )]
    VK_DYNAMIC_STATE_PRIMITIVE_RESTART_ENABLE_EXT = VK_DYNAMIC_STATE_PRIMITIVE_RESTART_ENABLE,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_line_rasterization"],
        ImpliesSets = [
            "VK_KHR_line_rasterization+VK_KHR_get_physical_device_properties2",
            "VK_KHR_line_rasterization+VK_VERSION_1_1",
        ]
    )]
    VK_DYNAMIC_STATE_LINE_STIPPLE_KHR = VK_DYNAMIC_STATE_LINE_STIPPLE,

    [SupportedApiProfile(
        "vulkan",
        ["VK_VERSION_1_0", "VK_VERSION_1_1", "VK_VERSION_1_2", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.0"
    )]
    VK_DYNAMIC_STATE_MAX_ENUM = 0x7FFFFFFF,
}
