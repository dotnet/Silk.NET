// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d3d10.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public static partial class D3D10
{
    [NativeTypeName("#define D3D10_16BIT_INDEX_STRIP_CUT_VALUE ( 0xffff )")]
    public const int D3D10_16BIT_INDEX_STRIP_CUT_VALUE = (0xffff);

    [NativeTypeName("#define D3D10_32BIT_INDEX_STRIP_CUT_VALUE ( 0xffffffff )")]
    public const uint D3D10_32BIT_INDEX_STRIP_CUT_VALUE = (0xffffffff);

    [NativeTypeName("#define D3D10_8BIT_INDEX_STRIP_CUT_VALUE ( 0xff )")]
    public const int D3D10_8BIT_INDEX_STRIP_CUT_VALUE = (0xff);

    [NativeTypeName("#define D3D10_ARRAY_AXIS_ADDRESS_RANGE_BIT_COUNT ( 9 )")]
    public const int D3D10_ARRAY_AXIS_ADDRESS_RANGE_BIT_COUNT = (9);

    [NativeTypeName("#define D3D10_CLIP_OR_CULL_DISTANCE_COUNT ( 8 )")]
    public const int D3D10_CLIP_OR_CULL_DISTANCE_COUNT = (8);

    [NativeTypeName("#define D3D10_CLIP_OR_CULL_DISTANCE_ELEMENT_COUNT ( 2 )")]
    public const int D3D10_CLIP_OR_CULL_DISTANCE_ELEMENT_COUNT = (2);

    [NativeTypeName("#define D3D10_COMMONSHADER_CONSTANT_BUFFER_API_SLOT_COUNT ( 14 )")]
    public const int D3D10_COMMONSHADER_CONSTANT_BUFFER_API_SLOT_COUNT = (14);

    [NativeTypeName("#define D3D10_COMMONSHADER_CONSTANT_BUFFER_COMPONENTS ( 4 )")]
    public const int D3D10_COMMONSHADER_CONSTANT_BUFFER_COMPONENTS = (4);

    [NativeTypeName("#define D3D10_COMMONSHADER_CONSTANT_BUFFER_COMPONENT_BIT_COUNT ( 32 )")]
    public const int D3D10_COMMONSHADER_CONSTANT_BUFFER_COMPONENT_BIT_COUNT = (32);

    [NativeTypeName("#define D3D10_COMMONSHADER_CONSTANT_BUFFER_HW_SLOT_COUNT ( 15 )")]
    public const int D3D10_COMMONSHADER_CONSTANT_BUFFER_HW_SLOT_COUNT = (15);

    [NativeTypeName("#define D3D10_COMMONSHADER_CONSTANT_BUFFER_REGISTER_COMPONENTS ( 4 )")]
    public const int D3D10_COMMONSHADER_CONSTANT_BUFFER_REGISTER_COMPONENTS = (4);

    [NativeTypeName("#define D3D10_COMMONSHADER_CONSTANT_BUFFER_REGISTER_COUNT ( 15 )")]
    public const int D3D10_COMMONSHADER_CONSTANT_BUFFER_REGISTER_COUNT = (15);

    [NativeTypeName("#define D3D10_COMMONSHADER_CONSTANT_BUFFER_REGISTER_READS_PER_INST ( 1 )")]
    public const int D3D10_COMMONSHADER_CONSTANT_BUFFER_REGISTER_READS_PER_INST = (1);

    [NativeTypeName("#define D3D10_COMMONSHADER_CONSTANT_BUFFER_REGISTER_READ_PORTS ( 1 )")]
    public const int D3D10_COMMONSHADER_CONSTANT_BUFFER_REGISTER_READ_PORTS = (1);

    [NativeTypeName("#define D3D10_COMMONSHADER_FLOWCONTROL_NESTING_LIMIT ( 64 )")]
    public const int D3D10_COMMONSHADER_FLOWCONTROL_NESTING_LIMIT = (64);

    [NativeTypeName(
        "#define D3D10_COMMONSHADER_IMMEDIATE_CONSTANT_BUFFER_REGISTER_COMPONENTS ( 4 )"
    )]
    public const int D3D10_COMMONSHADER_IMMEDIATE_CONSTANT_BUFFER_REGISTER_COMPONENTS = (4);

    [NativeTypeName("#define D3D10_COMMONSHADER_IMMEDIATE_CONSTANT_BUFFER_REGISTER_COUNT ( 1 )")]
    public const int D3D10_COMMONSHADER_IMMEDIATE_CONSTANT_BUFFER_REGISTER_COUNT = (1);

    [NativeTypeName(
        "#define D3D10_COMMONSHADER_IMMEDIATE_CONSTANT_BUFFER_REGISTER_READS_PER_INST ( 1 )"
    )]
    public const int D3D10_COMMONSHADER_IMMEDIATE_CONSTANT_BUFFER_REGISTER_READS_PER_INST = (1);

    [NativeTypeName(
        "#define D3D10_COMMONSHADER_IMMEDIATE_CONSTANT_BUFFER_REGISTER_READ_PORTS ( 1 )"
    )]
    public const int D3D10_COMMONSHADER_IMMEDIATE_CONSTANT_BUFFER_REGISTER_READ_PORTS = (1);

    [NativeTypeName("#define D3D10_COMMONSHADER_IMMEDIATE_VALUE_COMPONENT_BIT_COUNT ( 32 )")]
    public const int D3D10_COMMONSHADER_IMMEDIATE_VALUE_COMPONENT_BIT_COUNT = (32);

    [NativeTypeName("#define D3D10_COMMONSHADER_INPUT_RESOURCE_REGISTER_COMPONENTS ( 1 )")]
    public const int D3D10_COMMONSHADER_INPUT_RESOURCE_REGISTER_COMPONENTS = (1);

    [NativeTypeName("#define D3D10_COMMONSHADER_INPUT_RESOURCE_REGISTER_COUNT ( 128 )")]
    public const int D3D10_COMMONSHADER_INPUT_RESOURCE_REGISTER_COUNT = (128);

    [NativeTypeName("#define D3D10_COMMONSHADER_INPUT_RESOURCE_REGISTER_READS_PER_INST ( 1 )")]
    public const int D3D10_COMMONSHADER_INPUT_RESOURCE_REGISTER_READS_PER_INST = (1);

    [NativeTypeName("#define D3D10_COMMONSHADER_INPUT_RESOURCE_REGISTER_READ_PORTS ( 1 )")]
    public const int D3D10_COMMONSHADER_INPUT_RESOURCE_REGISTER_READ_PORTS = (1);

    [NativeTypeName("#define D3D10_COMMONSHADER_INPUT_RESOURCE_SLOT_COUNT ( 128 )")]
    public const int D3D10_COMMONSHADER_INPUT_RESOURCE_SLOT_COUNT = (128);

    [NativeTypeName("#define D3D10_COMMONSHADER_SAMPLER_REGISTER_COMPONENTS ( 1 )")]
    public const int D3D10_COMMONSHADER_SAMPLER_REGISTER_COMPONENTS = (1);

    [NativeTypeName("#define D3D10_COMMONSHADER_SAMPLER_REGISTER_COUNT ( 16 )")]
    public const int D3D10_COMMONSHADER_SAMPLER_REGISTER_COUNT = (16);

    [NativeTypeName("#define D3D10_COMMONSHADER_SAMPLER_REGISTER_READS_PER_INST ( 1 )")]
    public const int D3D10_COMMONSHADER_SAMPLER_REGISTER_READS_PER_INST = (1);

    [NativeTypeName("#define D3D10_COMMONSHADER_SAMPLER_REGISTER_READ_PORTS ( 1 )")]
    public const int D3D10_COMMONSHADER_SAMPLER_REGISTER_READ_PORTS = (1);

    [NativeTypeName("#define D3D10_COMMONSHADER_SAMPLER_SLOT_COUNT ( 16 )")]
    public const int D3D10_COMMONSHADER_SAMPLER_SLOT_COUNT = (16);

    [NativeTypeName("#define D3D10_COMMONSHADER_SUBROUTINE_NESTING_LIMIT ( 32 )")]
    public const int D3D10_COMMONSHADER_SUBROUTINE_NESTING_LIMIT = (32);

    [NativeTypeName("#define D3D10_COMMONSHADER_TEMP_REGISTER_COMPONENTS ( 4 )")]
    public const int D3D10_COMMONSHADER_TEMP_REGISTER_COMPONENTS = (4);

    [NativeTypeName("#define D3D10_COMMONSHADER_TEMP_REGISTER_COMPONENT_BIT_COUNT ( 32 )")]
    public const int D3D10_COMMONSHADER_TEMP_REGISTER_COMPONENT_BIT_COUNT = (32);

    [NativeTypeName("#define D3D10_COMMONSHADER_TEMP_REGISTER_COUNT ( 4096 )")]
    public const int D3D10_COMMONSHADER_TEMP_REGISTER_COUNT = (4096);

    [NativeTypeName("#define D3D10_COMMONSHADER_TEMP_REGISTER_READS_PER_INST ( 3 )")]
    public const int D3D10_COMMONSHADER_TEMP_REGISTER_READS_PER_INST = (3);

    [NativeTypeName("#define D3D10_COMMONSHADER_TEMP_REGISTER_READ_PORTS ( 3 )")]
    public const int D3D10_COMMONSHADER_TEMP_REGISTER_READ_PORTS = (3);

    [NativeTypeName("#define D3D10_COMMONSHADER_TEXCOORD_RANGE_REDUCTION_MAX ( 10 )")]
    public const int D3D10_COMMONSHADER_TEXCOORD_RANGE_REDUCTION_MAX = (10);

    [NativeTypeName("#define D3D10_COMMONSHADER_TEXCOORD_RANGE_REDUCTION_MIN ( -10 )")]
    public const int D3D10_COMMONSHADER_TEXCOORD_RANGE_REDUCTION_MIN = (-10);

    [NativeTypeName("#define D3D10_COMMONSHADER_TEXEL_OFFSET_MAX_NEGATIVE ( -8 )")]
    public const int D3D10_COMMONSHADER_TEXEL_OFFSET_MAX_NEGATIVE = (-8);

    [NativeTypeName("#define D3D10_COMMONSHADER_TEXEL_OFFSET_MAX_POSITIVE ( 7 )")]
    public const int D3D10_COMMONSHADER_TEXEL_OFFSET_MAX_POSITIVE = (7);

    [NativeTypeName("#define D3D10_DEFAULT_BLEND_FACTOR_ALPHA ( 1.0f )")]
    public const float D3D10_DEFAULT_BLEND_FACTOR_ALPHA = (1.0f);

    [NativeTypeName("#define D3D10_DEFAULT_BLEND_FACTOR_BLUE ( 1.0f )")]
    public const float D3D10_DEFAULT_BLEND_FACTOR_BLUE = (1.0f);

    [NativeTypeName("#define D3D10_DEFAULT_BLEND_FACTOR_GREEN ( 1.0f )")]
    public const float D3D10_DEFAULT_BLEND_FACTOR_GREEN = (1.0f);

    [NativeTypeName("#define D3D10_DEFAULT_BLEND_FACTOR_RED ( 1.0f )")]
    public const float D3D10_DEFAULT_BLEND_FACTOR_RED = (1.0f);

    [NativeTypeName("#define D3D10_DEFAULT_BORDER_COLOR_COMPONENT ( 0.0f )")]
    public const float D3D10_DEFAULT_BORDER_COLOR_COMPONENT = (0.0f);

    [NativeTypeName("#define D3D10_DEFAULT_DEPTH_BIAS ( 0 )")]
    public const int D3D10_DEFAULT_DEPTH_BIAS = (0);

    [NativeTypeName("#define D3D10_DEFAULT_DEPTH_BIAS_CLAMP ( 0.0f )")]
    public const float D3D10_DEFAULT_DEPTH_BIAS_CLAMP = (0.0f);

    [NativeTypeName("#define D3D10_DEFAULT_MAX_ANISOTROPY ( 16.0f )")]
    public const float D3D10_DEFAULT_MAX_ANISOTROPY = (16.0f);

    [NativeTypeName("#define D3D10_DEFAULT_MIP_LOD_BIAS ( 0.0f )")]
    public const float D3D10_DEFAULT_MIP_LOD_BIAS = (0.0f);

    [NativeTypeName("#define D3D10_DEFAULT_RENDER_TARGET_ARRAY_INDEX ( 0 )")]
    public const int D3D10_DEFAULT_RENDER_TARGET_ARRAY_INDEX = (0);

    [NativeTypeName("#define D3D10_DEFAULT_SAMPLE_MASK ( 0xffffffff )")]
    public const uint D3D10_DEFAULT_SAMPLE_MASK = (0xffffffff);

    [NativeTypeName("#define D3D10_DEFAULT_SCISSOR_ENDX ( 0 )")]
    public const int D3D10_DEFAULT_SCISSOR_ENDX = (0);

    [NativeTypeName("#define D3D10_DEFAULT_SCISSOR_ENDY ( 0 )")]
    public const int D3D10_DEFAULT_SCISSOR_ENDY = (0);

    [NativeTypeName("#define D3D10_DEFAULT_SCISSOR_STARTX ( 0 )")]
    public const int D3D10_DEFAULT_SCISSOR_STARTX = (0);

    [NativeTypeName("#define D3D10_DEFAULT_SCISSOR_STARTY ( 0 )")]
    public const int D3D10_DEFAULT_SCISSOR_STARTY = (0);

    [NativeTypeName("#define D3D10_DEFAULT_SLOPE_SCALED_DEPTH_BIAS ( 0.0f )")]
    public const float D3D10_DEFAULT_SLOPE_SCALED_DEPTH_BIAS = (0.0f);

    [NativeTypeName("#define D3D10_DEFAULT_STENCIL_READ_MASK ( 0xff )")]
    public const int D3D10_DEFAULT_STENCIL_READ_MASK = (0xff);

    [NativeTypeName("#define D3D10_DEFAULT_STENCIL_REFERENCE ( 0 )")]
    public const int D3D10_DEFAULT_STENCIL_REFERENCE = (0);

    [NativeTypeName("#define D3D10_DEFAULT_STENCIL_WRITE_MASK ( 0xff )")]
    public const int D3D10_DEFAULT_STENCIL_WRITE_MASK = (0xff);

    [NativeTypeName("#define D3D10_DEFAULT_VIEWPORT_AND_SCISSORRECT_INDEX ( 0 )")]
    public const int D3D10_DEFAULT_VIEWPORT_AND_SCISSORRECT_INDEX = (0);

    [NativeTypeName("#define D3D10_DEFAULT_VIEWPORT_HEIGHT ( 0 )")]
    public const int D3D10_DEFAULT_VIEWPORT_HEIGHT = (0);

    [NativeTypeName("#define D3D10_DEFAULT_VIEWPORT_MAX_DEPTH ( 0.0f )")]
    public const float D3D10_DEFAULT_VIEWPORT_MAX_DEPTH = (0.0f);

    [NativeTypeName("#define D3D10_DEFAULT_VIEWPORT_MIN_DEPTH ( 0.0f )")]
    public const float D3D10_DEFAULT_VIEWPORT_MIN_DEPTH = (0.0f);

    [NativeTypeName("#define D3D10_DEFAULT_VIEWPORT_TOPLEFTX ( 0 )")]
    public const int D3D10_DEFAULT_VIEWPORT_TOPLEFTX = (0);

    [NativeTypeName("#define D3D10_DEFAULT_VIEWPORT_TOPLEFTY ( 0 )")]
    public const int D3D10_DEFAULT_VIEWPORT_TOPLEFTY = (0);

    [NativeTypeName("#define D3D10_DEFAULT_VIEWPORT_WIDTH ( 0 )")]
    public const int D3D10_DEFAULT_VIEWPORT_WIDTH = (0);

    [NativeTypeName("#define D3D10_FLOAT16_FUSED_TOLERANCE_IN_ULP ( 0.6 )")]
    public const double D3D10_FLOAT16_FUSED_TOLERANCE_IN_ULP = (0.6);

    [NativeTypeName("#define D3D10_FLOAT32_MAX ( 3.402823466e+38f )")]
    public const float D3D10_FLOAT32_MAX = (3.402823466e+38f);

    [NativeTypeName("#define D3D10_FLOAT32_TO_INTEGER_TOLERANCE_IN_ULP ( 0.6f )")]
    public const float D3D10_FLOAT32_TO_INTEGER_TOLERANCE_IN_ULP = (0.6f);

    [NativeTypeName("#define D3D10_FLOAT_TO_SRGB_EXPONENT_DENOMINATOR ( 2.4f )")]
    public const float D3D10_FLOAT_TO_SRGB_EXPONENT_DENOMINATOR = (2.4f);

    [NativeTypeName("#define D3D10_FLOAT_TO_SRGB_EXPONENT_NUMERATOR ( 1.0f )")]
    public const float D3D10_FLOAT_TO_SRGB_EXPONENT_NUMERATOR = (1.0f);

    [NativeTypeName("#define D3D10_FLOAT_TO_SRGB_OFFSET ( 0.055f )")]
    public const float D3D10_FLOAT_TO_SRGB_OFFSET = (0.055f);

    [NativeTypeName("#define D3D10_FLOAT_TO_SRGB_SCALE_1 ( 12.92f )")]
    public const float D3D10_FLOAT_TO_SRGB_SCALE_1 = (12.92f);

    [NativeTypeName("#define D3D10_FLOAT_TO_SRGB_SCALE_2 ( 1.055f )")]
    public const float D3D10_FLOAT_TO_SRGB_SCALE_2 = (1.055f);

    [NativeTypeName("#define D3D10_FLOAT_TO_SRGB_THRESHOLD ( 0.0031308f )")]
    public const float D3D10_FLOAT_TO_SRGB_THRESHOLD = (0.0031308f);

    [NativeTypeName("#define D3D10_FTOI_INSTRUCTION_MAX_INPUT ( 2147483647.999f )")]
    public const float D3D10_FTOI_INSTRUCTION_MAX_INPUT = (2147483647.999f);

    [NativeTypeName("#define D3D10_FTOI_INSTRUCTION_MIN_INPUT ( -2147483648.999f )")]
    public const float D3D10_FTOI_INSTRUCTION_MIN_INPUT = (-2147483648.999f);

    [NativeTypeName("#define D3D10_FTOU_INSTRUCTION_MAX_INPUT ( 4294967295.999f )")]
    public const float D3D10_FTOU_INSTRUCTION_MAX_INPUT = (4294967295.999f);

    [NativeTypeName("#define D3D10_FTOU_INSTRUCTION_MIN_INPUT ( 0.0f )")]
    public const float D3D10_FTOU_INSTRUCTION_MIN_INPUT = (0.0f);

    [NativeTypeName("#define D3D10_GS_INPUT_PRIM_CONST_REGISTER_COMPONENTS ( 1 )")]
    public const int D3D10_GS_INPUT_PRIM_CONST_REGISTER_COMPONENTS = (1);

    [NativeTypeName("#define D3D10_GS_INPUT_PRIM_CONST_REGISTER_COMPONENT_BIT_COUNT ( 32 )")]
    public const int D3D10_GS_INPUT_PRIM_CONST_REGISTER_COMPONENT_BIT_COUNT = (32);

    [NativeTypeName("#define D3D10_GS_INPUT_PRIM_CONST_REGISTER_COUNT ( 1 )")]
    public const int D3D10_GS_INPUT_PRIM_CONST_REGISTER_COUNT = (1);

    [NativeTypeName("#define D3D10_GS_INPUT_PRIM_CONST_REGISTER_READS_PER_INST ( 2 )")]
    public const int D3D10_GS_INPUT_PRIM_CONST_REGISTER_READS_PER_INST = (2);

    [NativeTypeName("#define D3D10_GS_INPUT_PRIM_CONST_REGISTER_READ_PORTS ( 1 )")]
    public const int D3D10_GS_INPUT_PRIM_CONST_REGISTER_READ_PORTS = (1);

    [NativeTypeName("#define D3D10_GS_INPUT_REGISTER_COMPONENTS ( 4 )")]
    public const int D3D10_GS_INPUT_REGISTER_COMPONENTS = (4);

    [NativeTypeName("#define D3D10_GS_INPUT_REGISTER_COMPONENT_BIT_COUNT ( 32 )")]
    public const int D3D10_GS_INPUT_REGISTER_COMPONENT_BIT_COUNT = (32);

    [NativeTypeName("#define D3D10_GS_INPUT_REGISTER_COUNT ( 16 )")]
    public const int D3D10_GS_INPUT_REGISTER_COUNT = (16);

    [NativeTypeName("#define D3D10_GS_INPUT_REGISTER_READS_PER_INST ( 2 )")]
    public const int D3D10_GS_INPUT_REGISTER_READS_PER_INST = (2);

    [NativeTypeName("#define D3D10_GS_INPUT_REGISTER_READ_PORTS ( 1 )")]
    public const int D3D10_GS_INPUT_REGISTER_READ_PORTS = (1);

    [NativeTypeName("#define D3D10_GS_INPUT_REGISTER_VERTICES ( 6 )")]
    public const int D3D10_GS_INPUT_REGISTER_VERTICES = (6);

    [NativeTypeName("#define D3D10_GS_OUTPUT_ELEMENTS ( 32 )")]
    public const int D3D10_GS_OUTPUT_ELEMENTS = (32);

    [NativeTypeName("#define D3D10_GS_OUTPUT_REGISTER_COMPONENTS ( 4 )")]
    public const int D3D10_GS_OUTPUT_REGISTER_COMPONENTS = (4);

    [NativeTypeName("#define D3D10_GS_OUTPUT_REGISTER_COMPONENT_BIT_COUNT ( 32 )")]
    public const int D3D10_GS_OUTPUT_REGISTER_COMPONENT_BIT_COUNT = (32);

    [NativeTypeName("#define D3D10_GS_OUTPUT_REGISTER_COUNT ( 32 )")]
    public const int D3D10_GS_OUTPUT_REGISTER_COUNT = (32);

    [NativeTypeName("#define D3D10_IA_DEFAULT_INDEX_BUFFER_OFFSET_IN_BYTES ( 0 )")]
    public const int D3D10_IA_DEFAULT_INDEX_BUFFER_OFFSET_IN_BYTES = (0);

    [NativeTypeName("#define D3D10_IA_DEFAULT_PRIMITIVE_TOPOLOGY ( 0 )")]
    public const int D3D10_IA_DEFAULT_PRIMITIVE_TOPOLOGY = (0);

    [NativeTypeName("#define D3D10_IA_DEFAULT_VERTEX_BUFFER_OFFSET_IN_BYTES ( 0 )")]
    public const int D3D10_IA_DEFAULT_VERTEX_BUFFER_OFFSET_IN_BYTES = (0);

    [NativeTypeName("#define D3D10_IA_INDEX_INPUT_RESOURCE_SLOT_COUNT ( 1 )")]
    public const int D3D10_IA_INDEX_INPUT_RESOURCE_SLOT_COUNT = (1);

    [NativeTypeName("#define D3D10_IA_INSTANCE_ID_BIT_COUNT ( 32 )")]
    public const int D3D10_IA_INSTANCE_ID_BIT_COUNT = (32);

    [NativeTypeName("#define D3D10_IA_INTEGER_ARITHMETIC_BIT_COUNT ( 32 )")]
    public const int D3D10_IA_INTEGER_ARITHMETIC_BIT_COUNT = (32);

    [NativeTypeName("#define D3D10_IA_PRIMITIVE_ID_BIT_COUNT ( 32 )")]
    public const int D3D10_IA_PRIMITIVE_ID_BIT_COUNT = (32);

    [NativeTypeName("#define D3D10_IA_VERTEX_ID_BIT_COUNT ( 32 )")]
    public const int D3D10_IA_VERTEX_ID_BIT_COUNT = (32);

    [NativeTypeName("#define D3D10_IA_VERTEX_INPUT_RESOURCE_SLOT_COUNT ( 16 )")]
    public const int D3D10_IA_VERTEX_INPUT_RESOURCE_SLOT_COUNT = (16);

    [NativeTypeName("#define D3D10_IA_VERTEX_INPUT_STRUCTURE_ELEMENTS_COMPONENTS ( 64 )")]
    public const int D3D10_IA_VERTEX_INPUT_STRUCTURE_ELEMENTS_COMPONENTS = (64);

    [NativeTypeName("#define D3D10_IA_VERTEX_INPUT_STRUCTURE_ELEMENT_COUNT ( 16 )")]
    public const int D3D10_IA_VERTEX_INPUT_STRUCTURE_ELEMENT_COUNT = (16);

    [NativeTypeName("#define D3D10_INTEGER_DIVIDE_BY_ZERO_QUOTIENT ( 0xffffffff )")]
    public const uint D3D10_INTEGER_DIVIDE_BY_ZERO_QUOTIENT = (0xffffffff);

    [NativeTypeName("#define D3D10_INTEGER_DIVIDE_BY_ZERO_REMAINDER ( 0xffffffff )")]
    public const uint D3D10_INTEGER_DIVIDE_BY_ZERO_REMAINDER = (0xffffffff);

    [NativeTypeName("#define D3D10_LINEAR_GAMMA ( 1.0f )")]
    public const float D3D10_LINEAR_GAMMA = (1.0f);

    [NativeTypeName("#define D3D10_MAX_BORDER_COLOR_COMPONENT ( 1.0f )")]
    public const float D3D10_MAX_BORDER_COLOR_COMPONENT = (1.0f);

    [NativeTypeName("#define D3D10_MAX_DEPTH ( 1.0f )")]
    public const float D3D10_MAX_DEPTH = (1.0f);

    [NativeTypeName("#define D3D10_MAX_MAXANISOTROPY ( 16 )")]
    public const int D3D10_MAX_MAXANISOTROPY = (16);

    [NativeTypeName("#define D3D10_MAX_MULTISAMPLE_SAMPLE_COUNT ( 32 )")]
    public const int D3D10_MAX_MULTISAMPLE_SAMPLE_COUNT = (32);

    [NativeTypeName("#define D3D10_MAX_POSITION_VALUE ( 3.402823466e+34f )")]
    public const float D3D10_MAX_POSITION_VALUE = (3.402823466e+34f);

    [NativeTypeName("#define D3D10_MAX_TEXTURE_DIMENSION_2_TO_EXP ( 17 )")]
    public const int D3D10_MAX_TEXTURE_DIMENSION_2_TO_EXP = (17);

    [NativeTypeName("#define D3D10_MIN_BORDER_COLOR_COMPONENT ( 0.0f )")]
    public const float D3D10_MIN_BORDER_COLOR_COMPONENT = (0.0f);

    [NativeTypeName("#define D3D10_MIN_DEPTH ( 0.0f )")]
    public const float D3D10_MIN_DEPTH = (0.0f);

    [NativeTypeName("#define D3D10_MIN_MAXANISOTROPY ( 0 )")]
    public const int D3D10_MIN_MAXANISOTROPY = (0);

    [NativeTypeName("#define D3D10_MIP_LOD_BIAS_MAX ( 15.99f )")]
    public const float D3D10_MIP_LOD_BIAS_MAX = (15.99f);

    [NativeTypeName("#define D3D10_MIP_LOD_BIAS_MIN ( -16.0f )")]
    public const float D3D10_MIP_LOD_BIAS_MIN = (-16.0f);

    [NativeTypeName("#define D3D10_MIP_LOD_FRACTIONAL_BIT_COUNT ( 6 )")]
    public const int D3D10_MIP_LOD_FRACTIONAL_BIT_COUNT = (6);

    [NativeTypeName("#define D3D10_MIP_LOD_RANGE_BIT_COUNT ( 8 )")]
    public const int D3D10_MIP_LOD_RANGE_BIT_COUNT = (8);

    [NativeTypeName("#define D3D10_MULTISAMPLE_ANTIALIAS_LINE_WIDTH ( 1.4f )")]
    public const float D3D10_MULTISAMPLE_ANTIALIAS_LINE_WIDTH = (1.4f);

    [NativeTypeName("#define D3D10_NONSAMPLE_FETCH_OUT_OF_RANGE_ACCESS_RESULT ( 0 )")]
    public const int D3D10_NONSAMPLE_FETCH_OUT_OF_RANGE_ACCESS_RESULT = (0);

    [NativeTypeName("#define D3D10_PIXEL_ADDRESS_RANGE_BIT_COUNT ( 13 )")]
    public const int D3D10_PIXEL_ADDRESS_RANGE_BIT_COUNT = (13);

    [NativeTypeName("#define D3D10_PRE_SCISSOR_PIXEL_ADDRESS_RANGE_BIT_COUNT ( 15 )")]
    public const int D3D10_PRE_SCISSOR_PIXEL_ADDRESS_RANGE_BIT_COUNT = (15);

    [NativeTypeName("#define D3D10_PS_FRONTFACING_DEFAULT_VALUE ( 0xffffffff )")]
    public const uint D3D10_PS_FRONTFACING_DEFAULT_VALUE = (0xffffffff);

    [NativeTypeName("#define D3D10_PS_FRONTFACING_FALSE_VALUE ( 0 )")]
    public const int D3D10_PS_FRONTFACING_FALSE_VALUE = (0);

    [NativeTypeName("#define D3D10_PS_FRONTFACING_TRUE_VALUE ( 0xffffffff )")]
    public const uint D3D10_PS_FRONTFACING_TRUE_VALUE = (0xffffffff);

    [NativeTypeName("#define D3D10_PS_INPUT_REGISTER_COMPONENTS ( 4 )")]
    public const int D3D10_PS_INPUT_REGISTER_COMPONENTS = (4);

    [NativeTypeName("#define D3D10_PS_INPUT_REGISTER_COMPONENT_BIT_COUNT ( 32 )")]
    public const int D3D10_PS_INPUT_REGISTER_COMPONENT_BIT_COUNT = (32);

    [NativeTypeName("#define D3D10_PS_INPUT_REGISTER_COUNT ( 32 )")]
    public const int D3D10_PS_INPUT_REGISTER_COUNT = (32);

    [NativeTypeName("#define D3D10_PS_INPUT_REGISTER_READS_PER_INST ( 2 )")]
    public const int D3D10_PS_INPUT_REGISTER_READS_PER_INST = (2);

    [NativeTypeName("#define D3D10_PS_INPUT_REGISTER_READ_PORTS ( 1 )")]
    public const int D3D10_PS_INPUT_REGISTER_READ_PORTS = (1);

    [NativeTypeName("#define D3D10_PS_LEGACY_PIXEL_CENTER_FRACTIONAL_COMPONENT ( 0.0f )")]
    public const float D3D10_PS_LEGACY_PIXEL_CENTER_FRACTIONAL_COMPONENT = (0.0f);

    [NativeTypeName("#define D3D10_PS_OUTPUT_DEPTH_REGISTER_COMPONENTS ( 1 )")]
    public const int D3D10_PS_OUTPUT_DEPTH_REGISTER_COMPONENTS = (1);

    [NativeTypeName("#define D3D10_PS_OUTPUT_DEPTH_REGISTER_COMPONENT_BIT_COUNT ( 32 )")]
    public const int D3D10_PS_OUTPUT_DEPTH_REGISTER_COMPONENT_BIT_COUNT = (32);

    [NativeTypeName("#define D3D10_PS_OUTPUT_DEPTH_REGISTER_COUNT ( 1 )")]
    public const int D3D10_PS_OUTPUT_DEPTH_REGISTER_COUNT = (1);

    [NativeTypeName("#define D3D10_PS_OUTPUT_REGISTER_COMPONENTS ( 4 )")]
    public const int D3D10_PS_OUTPUT_REGISTER_COMPONENTS = (4);

    [NativeTypeName("#define D3D10_PS_OUTPUT_REGISTER_COMPONENT_BIT_COUNT ( 32 )")]
    public const int D3D10_PS_OUTPUT_REGISTER_COMPONENT_BIT_COUNT = (32);

    [NativeTypeName("#define D3D10_PS_OUTPUT_REGISTER_COUNT ( 8 )")]
    public const int D3D10_PS_OUTPUT_REGISTER_COUNT = (8);

    [NativeTypeName("#define D3D10_PS_PIXEL_CENTER_FRACTIONAL_COMPONENT ( 0.5f )")]
    public const float D3D10_PS_PIXEL_CENTER_FRACTIONAL_COMPONENT = (0.5f);

    [NativeTypeName("#define D3D10_REQ_BLEND_OBJECT_COUNT_PER_CONTEXT ( 4096 )")]
    public const int D3D10_REQ_BLEND_OBJECT_COUNT_PER_CONTEXT = (4096);

    [NativeTypeName("#define D3D10_REQ_BUFFER_RESOURCE_TEXEL_COUNT_2_TO_EXP ( 27 )")]
    public const int D3D10_REQ_BUFFER_RESOURCE_TEXEL_COUNT_2_TO_EXP = (27);

    [NativeTypeName("#define D3D10_REQ_CONSTANT_BUFFER_ELEMENT_COUNT ( 4096 )")]
    public const int D3D10_REQ_CONSTANT_BUFFER_ELEMENT_COUNT = (4096);

    [NativeTypeName("#define D3D10_REQ_DEPTH_STENCIL_OBJECT_COUNT_PER_CONTEXT ( 4096 )")]
    public const int D3D10_REQ_DEPTH_STENCIL_OBJECT_COUNT_PER_CONTEXT = (4096);

    [NativeTypeName("#define D3D10_REQ_DRAWINDEXED_INDEX_COUNT_2_TO_EXP ( 32 )")]
    public const int D3D10_REQ_DRAWINDEXED_INDEX_COUNT_2_TO_EXP = (32);

    [NativeTypeName("#define D3D10_REQ_DRAW_VERTEX_COUNT_2_TO_EXP ( 32 )")]
    public const int D3D10_REQ_DRAW_VERTEX_COUNT_2_TO_EXP = (32);

    [NativeTypeName("#define D3D10_REQ_FILTERING_HW_ADDRESSABLE_RESOURCE_DIMENSION ( 8192 )")]
    public const int D3D10_REQ_FILTERING_HW_ADDRESSABLE_RESOURCE_DIMENSION = (8192);

    [NativeTypeName("#define D3D10_REQ_GS_INVOCATION_32BIT_OUTPUT_COMPONENT_LIMIT ( 1024 )")]
    public const int D3D10_REQ_GS_INVOCATION_32BIT_OUTPUT_COMPONENT_LIMIT = (1024);

    [NativeTypeName("#define D3D10_REQ_IMMEDIATE_CONSTANT_BUFFER_ELEMENT_COUNT ( 4096 )")]
    public const int D3D10_REQ_IMMEDIATE_CONSTANT_BUFFER_ELEMENT_COUNT = (4096);

    [NativeTypeName("#define D3D10_REQ_MAXANISOTROPY ( 16 )")]
    public const int D3D10_REQ_MAXANISOTROPY = (16);

    [NativeTypeName("#define D3D10_REQ_MIP_LEVELS ( 14 )")]
    public const int D3D10_REQ_MIP_LEVELS = (14);

    [NativeTypeName("#define D3D10_REQ_MULTI_ELEMENT_STRUCTURE_SIZE_IN_BYTES ( 2048 )")]
    public const int D3D10_REQ_MULTI_ELEMENT_STRUCTURE_SIZE_IN_BYTES = (2048);

    [NativeTypeName("#define D3D10_REQ_RASTERIZER_OBJECT_COUNT_PER_CONTEXT ( 4096 )")]
    public const int D3D10_REQ_RASTERIZER_OBJECT_COUNT_PER_CONTEXT = (4096);

    [NativeTypeName("#define D3D10_REQ_RENDER_TO_BUFFER_WINDOW_WIDTH ( 8192 )")]
    public const int D3D10_REQ_RENDER_TO_BUFFER_WINDOW_WIDTH = (8192);

    [NativeTypeName("#define D3D10_REQ_RESOURCE_SIZE_IN_MEGABYTES ( 128 )")]
    public const int D3D10_REQ_RESOURCE_SIZE_IN_MEGABYTES = (128);

    [NativeTypeName("#define D3D10_REQ_RESOURCE_VIEW_COUNT_PER_CONTEXT_2_TO_EXP ( 20 )")]
    public const int D3D10_REQ_RESOURCE_VIEW_COUNT_PER_CONTEXT_2_TO_EXP = (20);

    [NativeTypeName("#define D3D10_REQ_SAMPLER_OBJECT_COUNT_PER_CONTEXT ( 4096 )")]
    public const int D3D10_REQ_SAMPLER_OBJECT_COUNT_PER_CONTEXT = (4096);

    [NativeTypeName("#define D3D10_REQ_TEXTURE1D_ARRAY_AXIS_DIMENSION ( 512 )")]
    public const int D3D10_REQ_TEXTURE1D_ARRAY_AXIS_DIMENSION = (512);

    [NativeTypeName("#define D3D10_REQ_TEXTURE1D_U_DIMENSION ( 8192 )")]
    public const int D3D10_REQ_TEXTURE1D_U_DIMENSION = (8192);

    [NativeTypeName("#define D3D10_REQ_TEXTURE2D_ARRAY_AXIS_DIMENSION ( 512 )")]
    public const int D3D10_REQ_TEXTURE2D_ARRAY_AXIS_DIMENSION = (512);

    [NativeTypeName("#define D3D10_REQ_TEXTURE2D_U_OR_V_DIMENSION ( 8192 )")]
    public const int D3D10_REQ_TEXTURE2D_U_OR_V_DIMENSION = (8192);

    [NativeTypeName("#define D3D10_REQ_TEXTURE3D_U_V_OR_W_DIMENSION ( 2048 )")]
    public const int D3D10_REQ_TEXTURE3D_U_V_OR_W_DIMENSION = (2048);

    [NativeTypeName("#define D3D10_REQ_TEXTURECUBE_DIMENSION ( 8192 )")]
    public const int D3D10_REQ_TEXTURECUBE_DIMENSION = (8192);

    [NativeTypeName("#define D3D10_RESINFO_INSTRUCTION_MISSING_COMPONENT_RETVAL ( 0 )")]
    public const int D3D10_RESINFO_INSTRUCTION_MISSING_COMPONENT_RETVAL = (0);

    [NativeTypeName("#define D3D10_SHADER_MAJOR_VERSION ( 4 )")]
    public const int D3D10_SHADER_MAJOR_VERSION = (4);

    [NativeTypeName("#define D3D10_SHADER_MINOR_VERSION ( 0 )")]
    public const int D3D10_SHADER_MINOR_VERSION = (0);

    [NativeTypeName("#define D3D10_SHIFT_INSTRUCTION_PAD_VALUE ( 0 )")]
    public const int D3D10_SHIFT_INSTRUCTION_PAD_VALUE = (0);

    [NativeTypeName("#define D3D10_SHIFT_INSTRUCTION_SHIFT_VALUE_BIT_COUNT ( 5 )")]
    public const int D3D10_SHIFT_INSTRUCTION_SHIFT_VALUE_BIT_COUNT = (5);

    [NativeTypeName("#define D3D10_SIMULTANEOUS_RENDER_TARGET_COUNT ( 8 )")]
    public const int D3D10_SIMULTANEOUS_RENDER_TARGET_COUNT = (8);

    [NativeTypeName("#define D3D10_SO_BUFFER_MAX_STRIDE_IN_BYTES ( 2048 )")]
    public const int D3D10_SO_BUFFER_MAX_STRIDE_IN_BYTES = (2048);

    [NativeTypeName("#define D3D10_SO_BUFFER_MAX_WRITE_WINDOW_IN_BYTES ( 256 )")]
    public const int D3D10_SO_BUFFER_MAX_WRITE_WINDOW_IN_BYTES = (256);

    [NativeTypeName("#define D3D10_SO_BUFFER_SLOT_COUNT ( 4 )")]
    public const int D3D10_SO_BUFFER_SLOT_COUNT = (4);

    [NativeTypeName("#define D3D10_SO_DDI_REGISTER_INDEX_DENOTING_GAP ( 0xffffffff )")]
    public const uint D3D10_SO_DDI_REGISTER_INDEX_DENOTING_GAP = (0xffffffff);

    [NativeTypeName("#define D3D10_SO_MULTIPLE_BUFFER_ELEMENTS_PER_BUFFER ( 1 )")]
    public const int D3D10_SO_MULTIPLE_BUFFER_ELEMENTS_PER_BUFFER = (1);

    [NativeTypeName("#define D3D10_SO_SINGLE_BUFFER_COMPONENT_LIMIT ( 64 )")]
    public const int D3D10_SO_SINGLE_BUFFER_COMPONENT_LIMIT = (64);

    [NativeTypeName("#define D3D10_SRGB_GAMMA ( 2.2f )")]
    public const float D3D10_SRGB_GAMMA = (2.2f);

    [NativeTypeName("#define D3D10_SRGB_TO_FLOAT_DENOMINATOR_1 ( 12.92f )")]
    public const float D3D10_SRGB_TO_FLOAT_DENOMINATOR_1 = (12.92f);

    [NativeTypeName("#define D3D10_SRGB_TO_FLOAT_DENOMINATOR_2 ( 1.055f )")]
    public const float D3D10_SRGB_TO_FLOAT_DENOMINATOR_2 = (1.055f);

    [NativeTypeName("#define D3D10_SRGB_TO_FLOAT_EXPONENT ( 2.4f )")]
    public const float D3D10_SRGB_TO_FLOAT_EXPONENT = (2.4f);

    [NativeTypeName("#define D3D10_SRGB_TO_FLOAT_OFFSET ( 0.055f )")]
    public const float D3D10_SRGB_TO_FLOAT_OFFSET = (0.055f);

    [NativeTypeName("#define D3D10_SRGB_TO_FLOAT_THRESHOLD ( 0.04045f )")]
    public const float D3D10_SRGB_TO_FLOAT_THRESHOLD = (0.04045f);

    [NativeTypeName("#define D3D10_SRGB_TO_FLOAT_TOLERANCE_IN_ULP ( 0.5f )")]
    public const float D3D10_SRGB_TO_FLOAT_TOLERANCE_IN_ULP = (0.5f);

    [NativeTypeName("#define D3D10_STANDARD_COMPONENT_BIT_COUNT ( 32 )")]
    public const int D3D10_STANDARD_COMPONENT_BIT_COUNT = (32);

    [NativeTypeName("#define D3D10_STANDARD_COMPONENT_BIT_COUNT_DOUBLED ( 64 )")]
    public const int D3D10_STANDARD_COMPONENT_BIT_COUNT_DOUBLED = (64);

    [NativeTypeName("#define D3D10_STANDARD_MAXIMUM_ELEMENT_ALIGNMENT_BYTE_MULTIPLE ( 4 )")]
    public const int D3D10_STANDARD_MAXIMUM_ELEMENT_ALIGNMENT_BYTE_MULTIPLE = (4);

    [NativeTypeName("#define D3D10_STANDARD_PIXEL_COMPONENT_COUNT ( 128 )")]
    public const int D3D10_STANDARD_PIXEL_COMPONENT_COUNT = (128);

    [NativeTypeName("#define D3D10_STANDARD_PIXEL_ELEMENT_COUNT ( 32 )")]
    public const int D3D10_STANDARD_PIXEL_ELEMENT_COUNT = (32);

    [NativeTypeName("#define D3D10_STANDARD_VECTOR_SIZE ( 4 )")]
    public const int D3D10_STANDARD_VECTOR_SIZE = (4);

    [NativeTypeName("#define D3D10_STANDARD_VERTEX_ELEMENT_COUNT ( 16 )")]
    public const int D3D10_STANDARD_VERTEX_ELEMENT_COUNT = (16);

    [NativeTypeName("#define D3D10_STANDARD_VERTEX_TOTAL_COMPONENT_COUNT ( 64 )")]
    public const int D3D10_STANDARD_VERTEX_TOTAL_COMPONENT_COUNT = (64);

    [NativeTypeName("#define D3D10_SUBPIXEL_FRACTIONAL_BIT_COUNT ( 8 )")]
    public const int D3D10_SUBPIXEL_FRACTIONAL_BIT_COUNT = (8);

    [NativeTypeName("#define D3D10_SUBTEXEL_FRACTIONAL_BIT_COUNT ( 6 )")]
    public const int D3D10_SUBTEXEL_FRACTIONAL_BIT_COUNT = (6);

    [NativeTypeName("#define D3D10_TEXEL_ADDRESS_RANGE_BIT_COUNT ( 18 )")]
    public const int D3D10_TEXEL_ADDRESS_RANGE_BIT_COUNT = (18);

    [NativeTypeName("#define D3D10_UNBOUND_MEMORY_ACCESS_RESULT ( 0 )")]
    public const int D3D10_UNBOUND_MEMORY_ACCESS_RESULT = (0);

    [NativeTypeName("#define D3D10_VIEWPORT_AND_SCISSORRECT_MAX_INDEX ( 15 )")]
    public const int D3D10_VIEWPORT_AND_SCISSORRECT_MAX_INDEX = (15);

    [NativeTypeName("#define D3D10_VIEWPORT_AND_SCISSORRECT_OBJECT_COUNT_PER_PIPELINE ( 16 )")]
    public const int D3D10_VIEWPORT_AND_SCISSORRECT_OBJECT_COUNT_PER_PIPELINE = (16);

    [NativeTypeName("#define D3D10_VIEWPORT_BOUNDS_MAX ( 16383 )")]
    public const int D3D10_VIEWPORT_BOUNDS_MAX = (16383);

    [NativeTypeName("#define D3D10_VIEWPORT_BOUNDS_MIN ( -16384 )")]
    public const int D3D10_VIEWPORT_BOUNDS_MIN = (-16384);

    [NativeTypeName("#define D3D10_VS_INPUT_REGISTER_COMPONENTS ( 4 )")]
    public const int D3D10_VS_INPUT_REGISTER_COMPONENTS = (4);

    [NativeTypeName("#define D3D10_VS_INPUT_REGISTER_COMPONENT_BIT_COUNT ( 32 )")]
    public const int D3D10_VS_INPUT_REGISTER_COMPONENT_BIT_COUNT = (32);

    [NativeTypeName("#define D3D10_VS_INPUT_REGISTER_COUNT ( 16 )")]
    public const int D3D10_VS_INPUT_REGISTER_COUNT = (16);

    [NativeTypeName("#define D3D10_VS_INPUT_REGISTER_READS_PER_INST ( 2 )")]
    public const int D3D10_VS_INPUT_REGISTER_READS_PER_INST = (2);

    [NativeTypeName("#define D3D10_VS_INPUT_REGISTER_READ_PORTS ( 1 )")]
    public const int D3D10_VS_INPUT_REGISTER_READ_PORTS = (1);

    [NativeTypeName("#define D3D10_VS_OUTPUT_REGISTER_COMPONENTS ( 4 )")]
    public const int D3D10_VS_OUTPUT_REGISTER_COMPONENTS = (4);

    [NativeTypeName("#define D3D10_VS_OUTPUT_REGISTER_COMPONENT_BIT_COUNT ( 32 )")]
    public const int D3D10_VS_OUTPUT_REGISTER_COMPONENT_BIT_COUNT = (32);

    [NativeTypeName("#define D3D10_VS_OUTPUT_REGISTER_COUNT ( 16 )")]
    public const int D3D10_VS_OUTPUT_REGISTER_COUNT = (16);

    [NativeTypeName("#define D3D10_WHQL_CONTEXT_COUNT_FOR_RESOURCE_LIMIT ( 10 )")]
    public const int D3D10_WHQL_CONTEXT_COUNT_FOR_RESOURCE_LIMIT = (10);

    [NativeTypeName("#define D3D10_WHQL_DRAWINDEXED_INDEX_COUNT_2_TO_EXP ( 25 )")]
    public const int D3D10_WHQL_DRAWINDEXED_INDEX_COUNT_2_TO_EXP = (25);

    [NativeTypeName("#define D3D10_WHQL_DRAW_VERTEX_COUNT_2_TO_EXP ( 25 )")]
    public const int D3D10_WHQL_DRAW_VERTEX_COUNT_2_TO_EXP = (25);

    [NativeTypeName("#define D3D10_APPEND_ALIGNED_ELEMENT ( 0xffffffff )")]
    public const uint D3D10_APPEND_ALIGNED_ELEMENT = (0xffffffff);

    [NativeTypeName("#define D3D10_FILTER_TYPE_MASK ( 0x3 )")]
    public const int D3D10_FILTER_TYPE_MASK = (0x3);

    [NativeTypeName("#define D3D10_MIN_FILTER_SHIFT ( 4 )")]
    public const int D3D10_MIN_FILTER_SHIFT = (4);

    [NativeTypeName("#define D3D10_MAG_FILTER_SHIFT ( 2 )")]
    public const int D3D10_MAG_FILTER_SHIFT = (2);

    [NativeTypeName("#define D3D10_MIP_FILTER_SHIFT ( 0 )")]
    public const int D3D10_MIP_FILTER_SHIFT = (0);

    [NativeTypeName("#define D3D10_COMPARISON_FILTERING_BIT ( 0x80 )")]
    public const int D3D10_COMPARISON_FILTERING_BIT = (0x80);

    [NativeTypeName("#define D3D10_ANISOTROPIC_FILTERING_BIT ( 0x40 )")]
    public const int D3D10_ANISOTROPIC_FILTERING_BIT = (0x40);

    [NativeTypeName("#define D3D10_TEXT_1BIT_BIT ( 0x80000000 )")]
    public const uint D3D10_TEXT_1BIT_BIT = (0x80000000);

    [NativeTypeName("#define D3D10_SDK_VERSION ( 29 )")]
    public const int D3D10_SDK_VERSION = (29);
}
