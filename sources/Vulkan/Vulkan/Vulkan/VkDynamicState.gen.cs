// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkDynamicState")]
[NativeTypeName("unsigned int")]
[SupportedApiProfile("vulkan")]
public enum VkDynamicState : uint
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
    VkDynamicStateViewport = 0,

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
    VkDynamicStateScissor = 1,

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
    VkDynamicStateLineWidth = 2,

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
    VkDynamicStateDepthBias = 3,

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
    VkDynamicStateBlendConstants = 4,

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
    VkDynamicStateDepthBounds = 5,

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
    VkDynamicStateStencilCompareMask = 6,

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
    VkDynamicStateStencilWriteMask = 7,

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
    VkDynamicStateStencilReference = 8,

    [NativeName("VK_DYNAMIC_STATE_CULL_MODE")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_GRAPHICS_VERSION_1_3", "VK_GRAPHICS_VERSION_1_4", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.3"
    )]
    VkDynamicStateCullMode = 1000267000,

    [NativeName("VK_DYNAMIC_STATE_FRONT_FACE")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_GRAPHICS_VERSION_1_3", "VK_GRAPHICS_VERSION_1_4", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.3"
    )]
    VkDynamicStateFrontFace = 1000267001,

    [NativeName("VK_DYNAMIC_STATE_PRIMITIVE_TOPOLOGY")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_GRAPHICS_VERSION_1_3", "VK_GRAPHICS_VERSION_1_4", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.3"
    )]
    VkDynamicStatePrimitiveTopology = 1000267002,

    [NativeName("VK_DYNAMIC_STATE_VIEWPORT_WITH_COUNT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_GRAPHICS_VERSION_1_3", "VK_GRAPHICS_VERSION_1_4", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.3"
    )]
    VkDynamicStateViewportWithCount = 1000267003,

    [NativeName("VK_DYNAMIC_STATE_SCISSOR_WITH_COUNT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_GRAPHICS_VERSION_1_3", "VK_GRAPHICS_VERSION_1_4", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.3"
    )]
    VkDynamicStateScissorWithCount = 1000267004,

    [NativeName("VK_DYNAMIC_STATE_VERTEX_INPUT_BINDING_STRIDE")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_GRAPHICS_VERSION_1_3", "VK_GRAPHICS_VERSION_1_4", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.3"
    )]
    VkDynamicStateVertexInputBindingStride = 1000267005,

    [NativeName("VK_DYNAMIC_STATE_DEPTH_TEST_ENABLE")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_GRAPHICS_VERSION_1_3", "VK_GRAPHICS_VERSION_1_4", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.3"
    )]
    VkDynamicStateDepthTestEnable = 1000267006,

    [NativeName("VK_DYNAMIC_STATE_DEPTH_WRITE_ENABLE")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_GRAPHICS_VERSION_1_3", "VK_GRAPHICS_VERSION_1_4", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.3"
    )]
    VkDynamicStateDepthWriteEnable = 1000267007,

    [NativeName("VK_DYNAMIC_STATE_DEPTH_COMPARE_OP")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_GRAPHICS_VERSION_1_3", "VK_GRAPHICS_VERSION_1_4", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.3"
    )]
    VkDynamicStateDepthCompareOp = 1000267008,

    [NativeName("VK_DYNAMIC_STATE_DEPTH_BOUNDS_TEST_ENABLE")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_GRAPHICS_VERSION_1_3", "VK_GRAPHICS_VERSION_1_4", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.3"
    )]
    VkDynamicStateDepthBoundsTestEnable = 1000267009,

    [NativeName("VK_DYNAMIC_STATE_STENCIL_TEST_ENABLE")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_GRAPHICS_VERSION_1_3", "VK_GRAPHICS_VERSION_1_4", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.3"
    )]
    VkDynamicStateStencilTestEnable = 1000267010,

    [NativeName("VK_DYNAMIC_STATE_STENCIL_OP")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_GRAPHICS_VERSION_1_3", "VK_GRAPHICS_VERSION_1_4", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.3"
    )]
    VkDynamicStateStencilOp = 1000267011,

    [NativeName("VK_DYNAMIC_STATE_RASTERIZER_DISCARD_ENABLE")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_GRAPHICS_VERSION_1_3", "VK_GRAPHICS_VERSION_1_4", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.3"
    )]
    VkDynamicStateRasterizerDiscardEnable = 1000377001,

    [NativeName("VK_DYNAMIC_STATE_DEPTH_BIAS_ENABLE")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_GRAPHICS_VERSION_1_3", "VK_GRAPHICS_VERSION_1_4", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.3"
    )]
    VkDynamicStateDepthBiasEnable = 1000377002,

    [NativeName("VK_DYNAMIC_STATE_PRIMITIVE_RESTART_ENABLE")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_GRAPHICS_VERSION_1_3", "VK_GRAPHICS_VERSION_1_4", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.3"
    )]
    VkDynamicStatePrimitiveRestartEnable = 1000377004,

    [NativeName("VK_DYNAMIC_STATE_LINE_STIPPLE")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_GRAPHICS_VERSION_1_4", "VK_VERSION_1_4"],
        MinVersion = "1.4"
    )]
    VkDynamicStateLineStipple = 1000259000,

    [NativeName("VK_DYNAMIC_STATE_VIEWPORT_W_SCALING_NV")]
    [NameAffix("Suffix", "KhronosVendor", "NV")]
    [SupportedApiProfile("vulkan", ["VK_NV_clip_space_w_scaling"])]
    VkDynamicStateViewportWScalingNV = 1000087000,

    [NativeName("VK_DYNAMIC_STATE_DISCARD_RECTANGLE_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_discard_rectangles"],
        ImpliesSets = [
            "VK_EXT_discard_rectangles+VK_KHR_get_physical_device_properties2",
            "VK_EXT_discard_rectangles+VK_VERSION_1_1",
        ]
    )]
    VkDynamicStateDiscardRectangleEXT = 1000099000,

    [NativeName("VK_DYNAMIC_STATE_DISCARD_RECTANGLE_ENABLE_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_discard_rectangles"],
        ImpliesSets = [
            "VK_EXT_discard_rectangles+VK_KHR_get_physical_device_properties2",
            "VK_EXT_discard_rectangles+VK_VERSION_1_1",
        ]
    )]
    VkDynamicStateDiscardRectangleEnableEXT = 1000099001,

    [NativeName("VK_DYNAMIC_STATE_DISCARD_RECTANGLE_MODE_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_discard_rectangles"],
        ImpliesSets = [
            "VK_EXT_discard_rectangles+VK_KHR_get_physical_device_properties2",
            "VK_EXT_discard_rectangles+VK_VERSION_1_1",
        ]
    )]
    VkDynamicStateDiscardRectangleModeEXT = 1000099002,

    [NativeName("VK_DYNAMIC_STATE_SAMPLE_LOCATIONS_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_sample_locations"],
        ImpliesSets = [
            "VK_EXT_sample_locations+VK_KHR_get_physical_device_properties2",
            "VK_EXT_sample_locations+VK_VERSION_1_1",
        ]
    )]
    VkDynamicStateSampleLocationsEXT = 1000143000,

    [NativeName("VK_DYNAMIC_STATE_RAY_TRACING_PIPELINE_STACK_SIZE_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_ray_tracing_pipeline"],
        ImpliesSets = [
            "VK_KHR_acceleration_structure+VK_KHR_spirv_1_4",
            "VK_KHR_acceleration_structure+VK_VERSION_1_2",
        ]
    )]
    VkDynamicStateRayTracingPipelineStackSizeKHR = 1000347000,

    [NativeName("VK_DYNAMIC_STATE_VIEWPORT_SHADING_RATE_PALETTE_NV")]
    [NameAffix("Suffix", "KhronosVendor", "NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_shading_rate_image"],
        ImpliesSets = [
            "VK_NV_shading_rate_image+VK_KHR_get_physical_device_properties2",
            "VK_NV_shading_rate_image+VK_VERSION_1_1",
        ]
    )]
    VkDynamicStateViewportShadingRatePaletteNV = 1000164004,

    [NativeName("VK_DYNAMIC_STATE_VIEWPORT_COARSE_SAMPLE_ORDER_NV")]
    [NameAffix("Suffix", "KhronosVendor", "NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_shading_rate_image"],
        ImpliesSets = [
            "VK_NV_shading_rate_image+VK_KHR_get_physical_device_properties2",
            "VK_NV_shading_rate_image+VK_VERSION_1_1",
        ]
    )]
    VkDynamicStateViewportCoarseSampleOrderNV = 1000164006,

    [NativeName("VK_DYNAMIC_STATE_EXCLUSIVE_SCISSOR_ENABLE_NV")]
    [NameAffix("Suffix", "KhronosVendor", "NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_scissor_exclusive"],
        ImpliesSets = [
            "VK_NV_scissor_exclusive+VK_KHR_get_physical_device_properties2",
            "VK_NV_scissor_exclusive+VK_VERSION_1_1",
        ]
    )]
    VkDynamicStateExclusiveScissorEnableNV = 1000205000,

    [NativeName("VK_DYNAMIC_STATE_EXCLUSIVE_SCISSOR_NV")]
    [NameAffix("Suffix", "KhronosVendor", "NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_scissor_exclusive"],
        ImpliesSets = [
            "VK_NV_scissor_exclusive+VK_KHR_get_physical_device_properties2",
            "VK_NV_scissor_exclusive+VK_VERSION_1_1",
        ]
    )]
    VkDynamicStateExclusiveScissorNV = 1000205001,

    [NativeName("VK_DYNAMIC_STATE_FRAGMENT_SHADING_RATE_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_fragment_shading_rate"],
        ImpliesSets = [
            "VK_KHR_create_renderpass2+VK_KHR_get_physical_device_properties2",
            "VK_KHR_create_renderpass2+VK_VERSION_1_1",
            "VK_VERSION_1_2",
        ]
    )]
    VkDynamicStateFragmentShadingRateKHR = 1000226000,

    [NativeName("VK_DYNAMIC_STATE_VERTEX_INPUT_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_vertex_input_dynamic_state"],
        ImpliesSets = [
            "VK_EXT_vertex_input_dynamic_state+VK_KHR_get_physical_device_properties2",
            "VK_EXT_vertex_input_dynamic_state+VK_VERSION_1_1",
        ]
    )]
    VkDynamicStateVertexInputEXT = 1000352000,

    [NativeName("VK_DYNAMIC_STATE_PATCH_CONTROL_POINTS_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_extended_dynamic_state2"],
        ImpliesSets = [
            "VK_EXT_extended_dynamic_state2+VK_KHR_get_physical_device_properties2",
            "VK_EXT_extended_dynamic_state2+VK_VERSION_1_1",
        ]
    )]
    VkDynamicStatePatchControlPointsEXT = 1000377000,

    [NativeName("VK_DYNAMIC_STATE_LOGIC_OP_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_extended_dynamic_state2"],
        ImpliesSets = [
            "VK_EXT_extended_dynamic_state2+VK_KHR_get_physical_device_properties2",
            "VK_EXT_extended_dynamic_state2+VK_VERSION_1_1",
        ]
    )]
    VkDynamicStateLogicOpEXT = 1000377003,

    [NativeName("VK_DYNAMIC_STATE_COLOR_WRITE_ENABLE_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_color_write_enable"],
        ImpliesSets = [
            "VK_EXT_color_write_enable+VK_KHR_get_physical_device_properties2",
            "VK_EXT_color_write_enable+VK_VERSION_1_1",
        ]
    )]
    VkDynamicStateColorWriteEnableEXT = 1000381000,

    [NativeName("VK_DYNAMIC_STATE_DEPTH_CLAMP_ENABLE_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_extended_dynamic_state3"],
        ImpliesSets = [
            "VK_EXT_extended_dynamic_state3+VK_KHR_get_physical_device_properties2",
            "VK_EXT_extended_dynamic_state3+VK_VERSION_1_1",
        ]
    )]
    VkDynamicStateDepthClampEnableEXT = 1000455003,

    [NativeName("VK_DYNAMIC_STATE_POLYGON_MODE_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_extended_dynamic_state3"],
        ImpliesSets = [
            "VK_EXT_extended_dynamic_state3+VK_KHR_get_physical_device_properties2",
            "VK_EXT_extended_dynamic_state3+VK_VERSION_1_1",
        ]
    )]
    VkDynamicStatePolygonModeEXT = 1000455004,

    [NativeName("VK_DYNAMIC_STATE_RASTERIZATION_SAMPLES_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_extended_dynamic_state3"],
        ImpliesSets = [
            "VK_EXT_extended_dynamic_state3+VK_KHR_get_physical_device_properties2",
            "VK_EXT_extended_dynamic_state3+VK_VERSION_1_1",
        ]
    )]
    VkDynamicStateRasterizationSamplesEXT = 1000455005,

    [NativeName("VK_DYNAMIC_STATE_SAMPLE_MASK_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_extended_dynamic_state3"],
        ImpliesSets = [
            "VK_EXT_extended_dynamic_state3+VK_KHR_get_physical_device_properties2",
            "VK_EXT_extended_dynamic_state3+VK_VERSION_1_1",
        ]
    )]
    VkDynamicStateSampleMaskEXT = 1000455006,

    [NativeName("VK_DYNAMIC_STATE_ALPHA_TO_COVERAGE_ENABLE_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_extended_dynamic_state3"],
        ImpliesSets = [
            "VK_EXT_extended_dynamic_state3+VK_KHR_get_physical_device_properties2",
            "VK_EXT_extended_dynamic_state3+VK_VERSION_1_1",
        ]
    )]
    VkDynamicStateAlphaToCoverageEnableEXT = 1000455007,

    [NativeName("VK_DYNAMIC_STATE_ALPHA_TO_ONE_ENABLE_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_extended_dynamic_state3"],
        ImpliesSets = [
            "VK_EXT_extended_dynamic_state3+VK_KHR_get_physical_device_properties2",
            "VK_EXT_extended_dynamic_state3+VK_VERSION_1_1",
        ]
    )]
    VkDynamicStateAlphaToOneEnableEXT = 1000455008,

    [NativeName("VK_DYNAMIC_STATE_LOGIC_OP_ENABLE_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_extended_dynamic_state3"],
        ImpliesSets = [
            "VK_EXT_extended_dynamic_state3+VK_KHR_get_physical_device_properties2",
            "VK_EXT_extended_dynamic_state3+VK_VERSION_1_1",
        ]
    )]
    VkDynamicStateLogicOpEnableEXT = 1000455009,

    [NativeName("VK_DYNAMIC_STATE_COLOR_BLEND_ENABLE_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_extended_dynamic_state3"],
        ImpliesSets = [
            "VK_EXT_extended_dynamic_state3+VK_KHR_get_physical_device_properties2",
            "VK_EXT_extended_dynamic_state3+VK_VERSION_1_1",
        ]
    )]
    VkDynamicStateColorBlendEnableEXT = 1000455010,

    [NativeName("VK_DYNAMIC_STATE_COLOR_BLEND_EQUATION_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_extended_dynamic_state3"],
        ImpliesSets = [
            "VK_EXT_extended_dynamic_state3+VK_KHR_get_physical_device_properties2",
            "VK_EXT_extended_dynamic_state3+VK_VERSION_1_1",
        ]
    )]
    VkDynamicStateColorBlendEquationEXT = 1000455011,

    [NativeName("VK_DYNAMIC_STATE_COLOR_WRITE_MASK_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_extended_dynamic_state3"],
        ImpliesSets = [
            "VK_EXT_extended_dynamic_state3+VK_KHR_get_physical_device_properties2",
            "VK_EXT_extended_dynamic_state3+VK_VERSION_1_1",
        ]
    )]
    VkDynamicStateColorWriteMaskEXT = 1000455012,

    [NativeName("VK_DYNAMIC_STATE_TESSELLATION_DOMAIN_ORIGIN_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
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
    VkDynamicStateTessellationDomainOriginEXT = 1000455002,

    [NativeName("VK_DYNAMIC_STATE_RASTERIZATION_STREAM_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_extended_dynamic_state3", "VK_EXT_transform_feedback"],
        ImpliesSets = [
            "VK_EXT_extended_dynamic_state3+VK_KHR_get_physical_device_properties2",
            "VK_EXT_extended_dynamic_state3+VK_VERSION_1_1",
        ],
        RequireAll = true
    )]
    VkDynamicStateRasterizationStreamEXT = 1000455013,

    [NativeName("VK_DYNAMIC_STATE_CONSERVATIVE_RASTERIZATION_MODE_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_conservative_rasterization", "VK_EXT_extended_dynamic_state3"],
        ImpliesSets = [
            "VK_EXT_extended_dynamic_state3+VK_KHR_get_physical_device_properties2",
            "VK_EXT_extended_dynamic_state3+VK_VERSION_1_1",
        ],
        RequireAll = true
    )]
    VkDynamicStateConservativeRasterizationModeEXT = 1000455014,

    [NativeName("VK_DYNAMIC_STATE_EXTRA_PRIMITIVE_OVERESTIMATION_SIZE_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_conservative_rasterization", "VK_EXT_extended_dynamic_state3"],
        ImpliesSets = [
            "VK_EXT_extended_dynamic_state3+VK_KHR_get_physical_device_properties2",
            "VK_EXT_extended_dynamic_state3+VK_VERSION_1_1",
        ],
        RequireAll = true
    )]
    VkDynamicStateExtraPrimitiveOverestimationSizeEXT = 1000455015,

    [NativeName("VK_DYNAMIC_STATE_DEPTH_CLIP_ENABLE_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_depth_clip_enable", "VK_EXT_extended_dynamic_state3"],
        ImpliesSets = [
            "VK_EXT_extended_dynamic_state3+VK_KHR_get_physical_device_properties2",
            "VK_EXT_extended_dynamic_state3+VK_VERSION_1_1",
        ],
        RequireAll = true
    )]
    VkDynamicStateDepthClipEnableEXT = 1000455016,

    [NativeName("VK_DYNAMIC_STATE_SAMPLE_LOCATIONS_ENABLE_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_extended_dynamic_state3", "VK_EXT_sample_locations"],
        ImpliesSets = [
            "VK_EXT_extended_dynamic_state3+VK_KHR_get_physical_device_properties2",
            "VK_EXT_extended_dynamic_state3+VK_VERSION_1_1",
        ],
        RequireAll = true
    )]
    VkDynamicStateSampleLocationsEnableEXT = 1000455017,

    [NativeName("VK_DYNAMIC_STATE_COLOR_BLEND_ADVANCED_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_blend_operation_advanced", "VK_EXT_extended_dynamic_state3"],
        ImpliesSets = [
            "VK_EXT_extended_dynamic_state3+VK_KHR_get_physical_device_properties2",
            "VK_EXT_extended_dynamic_state3+VK_VERSION_1_1",
        ],
        RequireAll = true
    )]
    VkDynamicStateColorBlendAdvancedEXT = 1000455018,

    [NativeName("VK_DYNAMIC_STATE_PROVOKING_VERTEX_MODE_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_extended_dynamic_state3", "VK_EXT_provoking_vertex"],
        ImpliesSets = [
            "VK_EXT_extended_dynamic_state3+VK_KHR_get_physical_device_properties2",
            "VK_EXT_extended_dynamic_state3+VK_VERSION_1_1",
        ],
        RequireAll = true
    )]
    VkDynamicStateProvokingVertexModeEXT = 1000455019,

    [NativeName("VK_DYNAMIC_STATE_LINE_RASTERIZATION_MODE_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_extended_dynamic_state3", "VK_EXT_line_rasterization"],
        ImpliesSets = [
            "VK_EXT_extended_dynamic_state3+VK_KHR_get_physical_device_properties2",
            "VK_EXT_extended_dynamic_state3+VK_VERSION_1_1",
        ],
        RequireAll = true
    )]
    VkDynamicStateLineRasterizationModeEXT = 1000455020,

    [NativeName("VK_DYNAMIC_STATE_LINE_STIPPLE_ENABLE_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_extended_dynamic_state3", "VK_EXT_line_rasterization"],
        ImpliesSets = [
            "VK_EXT_extended_dynamic_state3+VK_KHR_get_physical_device_properties2",
            "VK_EXT_extended_dynamic_state3+VK_VERSION_1_1",
        ],
        RequireAll = true
    )]
    VkDynamicStateLineStippleEnableEXT = 1000455021,

    [NativeName("VK_DYNAMIC_STATE_DEPTH_CLIP_NEGATIVE_ONE_TO_ONE_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_depth_clip_control", "VK_EXT_extended_dynamic_state3"],
        ImpliesSets = [
            "VK_EXT_extended_dynamic_state3+VK_KHR_get_physical_device_properties2",
            "VK_EXT_extended_dynamic_state3+VK_VERSION_1_1",
        ],
        RequireAll = true
    )]
    VkDynamicStateDepthClipNegativeOneToOneEXT = 1000455022,

    [NativeName("VK_DYNAMIC_STATE_VIEWPORT_W_SCALING_ENABLE_NV")]
    [NameAffix("Suffix", "KhronosVendor", "NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_extended_dynamic_state3", "VK_NV_clip_space_w_scaling"],
        ImpliesSets = [
            "VK_EXT_extended_dynamic_state3+VK_KHR_get_physical_device_properties2",
            "VK_EXT_extended_dynamic_state3+VK_VERSION_1_1",
        ],
        RequireAll = true
    )]
    VkDynamicStateViewportWScalingEnableNV = 1000455023,

    [NativeName("VK_DYNAMIC_STATE_VIEWPORT_SWIZZLE_NV")]
    [NameAffix("Suffix", "KhronosVendor", "NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_extended_dynamic_state3", "VK_NV_viewport_swizzle"],
        ImpliesSets = [
            "VK_EXT_extended_dynamic_state3+VK_KHR_get_physical_device_properties2",
            "VK_EXT_extended_dynamic_state3+VK_VERSION_1_1",
        ],
        RequireAll = true
    )]
    VkDynamicStateViewportSwizzleNV = 1000455024,

    [NativeName("VK_DYNAMIC_STATE_COVERAGE_TO_COLOR_ENABLE_NV")]
    [NameAffix("Suffix", "KhronosVendor", "NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_extended_dynamic_state3", "VK_NV_fragment_coverage_to_color"],
        ImpliesSets = [
            "VK_EXT_extended_dynamic_state3+VK_KHR_get_physical_device_properties2",
            "VK_EXT_extended_dynamic_state3+VK_VERSION_1_1",
        ],
        RequireAll = true
    )]
    VkDynamicStateCoverageToColorEnableNV = 1000455025,

    [NativeName("VK_DYNAMIC_STATE_COVERAGE_TO_COLOR_LOCATION_NV")]
    [NameAffix("Suffix", "KhronosVendor", "NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_extended_dynamic_state3", "VK_NV_fragment_coverage_to_color"],
        ImpliesSets = [
            "VK_EXT_extended_dynamic_state3+VK_KHR_get_physical_device_properties2",
            "VK_EXT_extended_dynamic_state3+VK_VERSION_1_1",
        ],
        RequireAll = true
    )]
    VkDynamicStateCoverageToColorLocationNV = 1000455026,

    [NativeName("VK_DYNAMIC_STATE_COVERAGE_MODULATION_MODE_NV")]
    [NameAffix("Suffix", "KhronosVendor", "NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_extended_dynamic_state3", "VK_NV_framebuffer_mixed_samples"],
        ImpliesSets = [
            "VK_EXT_extended_dynamic_state3+VK_KHR_get_physical_device_properties2",
            "VK_EXT_extended_dynamic_state3+VK_VERSION_1_1",
        ],
        RequireAll = true
    )]
    VkDynamicStateCoverageModulationModeNV = 1000455027,

    [NativeName("VK_DYNAMIC_STATE_COVERAGE_MODULATION_TABLE_ENABLE_NV")]
    [NameAffix("Suffix", "KhronosVendor", "NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_extended_dynamic_state3", "VK_NV_framebuffer_mixed_samples"],
        ImpliesSets = [
            "VK_EXT_extended_dynamic_state3+VK_KHR_get_physical_device_properties2",
            "VK_EXT_extended_dynamic_state3+VK_VERSION_1_1",
        ],
        RequireAll = true
    )]
    VkDynamicStateCoverageModulationTableEnableNV = 1000455028,

    [NativeName("VK_DYNAMIC_STATE_COVERAGE_MODULATION_TABLE_NV")]
    [NameAffix("Suffix", "KhronosVendor", "NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_extended_dynamic_state3", "VK_NV_framebuffer_mixed_samples"],
        ImpliesSets = [
            "VK_EXT_extended_dynamic_state3+VK_KHR_get_physical_device_properties2",
            "VK_EXT_extended_dynamic_state3+VK_VERSION_1_1",
        ],
        RequireAll = true
    )]
    VkDynamicStateCoverageModulationTableNV = 1000455029,

    [NativeName("VK_DYNAMIC_STATE_SHADING_RATE_IMAGE_ENABLE_NV")]
    [NameAffix("Suffix", "KhronosVendor", "NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_extended_dynamic_state3", "VK_NV_shading_rate_image"],
        ImpliesSets = [
            "VK_EXT_extended_dynamic_state3+VK_KHR_get_physical_device_properties2",
            "VK_EXT_extended_dynamic_state3+VK_VERSION_1_1",
        ],
        RequireAll = true
    )]
    VkDynamicStateShadingRateImageEnableNV = 1000455030,

    [NativeName("VK_DYNAMIC_STATE_REPRESENTATIVE_FRAGMENT_TEST_ENABLE_NV")]
    [NameAffix("Suffix", "KhronosVendor", "NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_extended_dynamic_state3", "VK_NV_representative_fragment_test"],
        ImpliesSets = [
            "VK_EXT_extended_dynamic_state3+VK_KHR_get_physical_device_properties2",
            "VK_EXT_extended_dynamic_state3+VK_VERSION_1_1",
        ],
        RequireAll = true
    )]
    VkDynamicStateRepresentativeFragmentTestEnableNV = 1000455031,

    [NativeName("VK_DYNAMIC_STATE_COVERAGE_REDUCTION_MODE_NV")]
    [NameAffix("Suffix", "KhronosVendor", "NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_extended_dynamic_state3", "VK_NV_coverage_reduction_mode"],
        ImpliesSets = [
            "VK_EXT_extended_dynamic_state3+VK_KHR_get_physical_device_properties2",
            "VK_EXT_extended_dynamic_state3+VK_VERSION_1_1",
        ],
        RequireAll = true
    )]
    VkDynamicStateCoverageReductionModeNV = 1000455032,

    [NativeName("VK_DYNAMIC_STATE_ATTACHMENT_FEEDBACK_LOOP_ENABLE_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_attachment_feedback_loop_dynamic_state"],
        ImpliesSets = [
            "VK_EXT_attachment_feedback_loop_layout+VK_KHR_get_physical_device_properties2",
            "VK_EXT_attachment_feedback_loop_layout+VK_VERSION_1_1",
        ]
    )]
    VkDynamicStateAttachmentFeedbackLoopEnableEXT = 1000524000,

    [NativeName("VK_DYNAMIC_STATE_DEPTH_CLAMP_RANGE_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_depth_clamp_control"],
        ImpliesSets = [
            "VK_EXT_depth_clamp_control+VK_KHR_get_physical_device_properties2",
            "VK_EXT_depth_clamp_control+VK_VERSION_1_1",
        ]
    )]
    VkDynamicStateDepthClampRangeEXT = 1000582000,

    [NativeName("VK_DYNAMIC_STATE_LINE_STIPPLE_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_line_rasterization"],
        ImpliesSets = [
            "VK_EXT_line_rasterization+VK_KHR_get_physical_device_properties2",
            "VK_EXT_line_rasterization+VK_VERSION_1_1",
        ]
    )]
    VkDynamicStateLineStippleEXT = VkDynamicStateLineStipple,

    [NativeName("VK_DYNAMIC_STATE_CULL_MODE_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_extended_dynamic_state"],
        ImpliesSets = [
            "VK_EXT_extended_dynamic_state+VK_KHR_get_physical_device_properties2",
            "VK_EXT_extended_dynamic_state+VK_VERSION_1_1",
        ]
    )]
    VkDynamicStateCullModeEXT = VkDynamicStateCullMode,

    [NativeName("VK_DYNAMIC_STATE_FRONT_FACE_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_extended_dynamic_state"],
        ImpliesSets = [
            "VK_EXT_extended_dynamic_state+VK_KHR_get_physical_device_properties2",
            "VK_EXT_extended_dynamic_state+VK_VERSION_1_1",
        ]
    )]
    VkDynamicStateFrontFaceEXT = VkDynamicStateFrontFace,

    [NativeName("VK_DYNAMIC_STATE_PRIMITIVE_TOPOLOGY_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_extended_dynamic_state"],
        ImpliesSets = [
            "VK_EXT_extended_dynamic_state+VK_KHR_get_physical_device_properties2",
            "VK_EXT_extended_dynamic_state+VK_VERSION_1_1",
        ]
    )]
    VkDynamicStatePrimitiveTopologyEXT = VkDynamicStatePrimitiveTopology,

    [NativeName("VK_DYNAMIC_STATE_VIEWPORT_WITH_COUNT_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_extended_dynamic_state"],
        ImpliesSets = [
            "VK_EXT_extended_dynamic_state+VK_KHR_get_physical_device_properties2",
            "VK_EXT_extended_dynamic_state+VK_VERSION_1_1",
        ]
    )]
    VkDynamicStateViewportWithCountEXT = VkDynamicStateViewportWithCount,

    [NativeName("VK_DYNAMIC_STATE_SCISSOR_WITH_COUNT_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_extended_dynamic_state"],
        ImpliesSets = [
            "VK_EXT_extended_dynamic_state+VK_KHR_get_physical_device_properties2",
            "VK_EXT_extended_dynamic_state+VK_VERSION_1_1",
        ]
    )]
    VkDynamicStateScissorWithCountEXT = VkDynamicStateScissorWithCount,

    [NativeName("VK_DYNAMIC_STATE_VERTEX_INPUT_BINDING_STRIDE_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_extended_dynamic_state"],
        ImpliesSets = [
            "VK_EXT_extended_dynamic_state+VK_KHR_get_physical_device_properties2",
            "VK_EXT_extended_dynamic_state+VK_VERSION_1_1",
        ]
    )]
    VkDynamicStateVertexInputBindingStrideEXT = VkDynamicStateVertexInputBindingStride,

    [NativeName("VK_DYNAMIC_STATE_DEPTH_TEST_ENABLE_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_extended_dynamic_state"],
        ImpliesSets = [
            "VK_EXT_extended_dynamic_state+VK_KHR_get_physical_device_properties2",
            "VK_EXT_extended_dynamic_state+VK_VERSION_1_1",
        ]
    )]
    VkDynamicStateDepthTestEnableEXT = VkDynamicStateDepthTestEnable,

    [NativeName("VK_DYNAMIC_STATE_DEPTH_WRITE_ENABLE_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_extended_dynamic_state"],
        ImpliesSets = [
            "VK_EXT_extended_dynamic_state+VK_KHR_get_physical_device_properties2",
            "VK_EXT_extended_dynamic_state+VK_VERSION_1_1",
        ]
    )]
    VkDynamicStateDepthWriteEnableEXT = VkDynamicStateDepthWriteEnable,

    [NativeName("VK_DYNAMIC_STATE_DEPTH_COMPARE_OP_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_extended_dynamic_state"],
        ImpliesSets = [
            "VK_EXT_extended_dynamic_state+VK_KHR_get_physical_device_properties2",
            "VK_EXT_extended_dynamic_state+VK_VERSION_1_1",
        ]
    )]
    VkDynamicStateDepthCompareOpEXT = VkDynamicStateDepthCompareOp,

    [NativeName("VK_DYNAMIC_STATE_DEPTH_BOUNDS_TEST_ENABLE_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_extended_dynamic_state"],
        ImpliesSets = [
            "VK_EXT_extended_dynamic_state+VK_KHR_get_physical_device_properties2",
            "VK_EXT_extended_dynamic_state+VK_VERSION_1_1",
        ]
    )]
    VkDynamicStateDepthBoundsTestEnableEXT = VkDynamicStateDepthBoundsTestEnable,

    [NativeName("VK_DYNAMIC_STATE_STENCIL_TEST_ENABLE_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_extended_dynamic_state"],
        ImpliesSets = [
            "VK_EXT_extended_dynamic_state+VK_KHR_get_physical_device_properties2",
            "VK_EXT_extended_dynamic_state+VK_VERSION_1_1",
        ]
    )]
    VkDynamicStateStencilTestEnableEXT = VkDynamicStateStencilTestEnable,

    [NativeName("VK_DYNAMIC_STATE_STENCIL_OP_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_extended_dynamic_state"],
        ImpliesSets = [
            "VK_EXT_extended_dynamic_state+VK_KHR_get_physical_device_properties2",
            "VK_EXT_extended_dynamic_state+VK_VERSION_1_1",
        ]
    )]
    VkDynamicStateStencilOpEXT = VkDynamicStateStencilOp,

    [NativeName("VK_DYNAMIC_STATE_RASTERIZER_DISCARD_ENABLE_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_extended_dynamic_state2"],
        ImpliesSets = [
            "VK_EXT_extended_dynamic_state2+VK_KHR_get_physical_device_properties2",
            "VK_EXT_extended_dynamic_state2+VK_VERSION_1_1",
        ]
    )]
    VkDynamicStateRasterizerDiscardEnableEXT = VkDynamicStateRasterizerDiscardEnable,

    [NativeName("VK_DYNAMIC_STATE_DEPTH_BIAS_ENABLE_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_extended_dynamic_state2"],
        ImpliesSets = [
            "VK_EXT_extended_dynamic_state2+VK_KHR_get_physical_device_properties2",
            "VK_EXT_extended_dynamic_state2+VK_VERSION_1_1",
        ]
    )]
    VkDynamicStateDepthBiasEnableEXT = VkDynamicStateDepthBiasEnable,

    [NativeName("VK_DYNAMIC_STATE_PRIMITIVE_RESTART_ENABLE_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_extended_dynamic_state2"],
        ImpliesSets = [
            "VK_EXT_extended_dynamic_state2+VK_KHR_get_physical_device_properties2",
            "VK_EXT_extended_dynamic_state2+VK_VERSION_1_1",
        ]
    )]
    VkDynamicStatePrimitiveRestartEnableEXT = VkDynamicStatePrimitiveRestartEnable,

    [NativeName("VK_DYNAMIC_STATE_LINE_STIPPLE_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_line_rasterization"],
        ImpliesSets = [
            "VK_KHR_line_rasterization+VK_KHR_get_physical_device_properties2",
            "VK_KHR_line_rasterization+VK_VERSION_1_1",
        ]
    )]
    VkDynamicStateLineStippleKHR = VkDynamicStateLineStipple,

    [NativeName("VK_DYNAMIC_STATE_MAX_ENUM")]
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
    VkDynamicStateMaxEnum = 0x7FFFFFFF,
}
