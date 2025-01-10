// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d3d10_1.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public static partial class D3D10
{
    [NativeTypeName("#define D3D10_1_DEFAULT_SAMPLE_MASK ( 0xffffffff )")]
    public const uint D3D10_1_DEFAULT_SAMPLE_MASK = (0xffffffff);

    [NativeTypeName("#define D3D10_1_FLOAT16_FUSED_TOLERANCE_IN_ULP ( 0.6 )")]
    public const double D3D10_1_FLOAT16_FUSED_TOLERANCE_IN_ULP = (0.6);

    [NativeTypeName("#define D3D10_1_FLOAT32_TO_INTEGER_TOLERANCE_IN_ULP ( 0.6f )")]
    public const float D3D10_1_FLOAT32_TO_INTEGER_TOLERANCE_IN_ULP = (0.6f);

    [NativeTypeName("#define D3D10_1_GS_INPUT_REGISTER_COUNT ( 32 )")]
    public const int D3D10_1_GS_INPUT_REGISTER_COUNT = (32);

    [NativeTypeName("#define D3D10_1_IA_VERTEX_INPUT_RESOURCE_SLOT_COUNT ( 32 )")]
    public const int D3D10_1_IA_VERTEX_INPUT_RESOURCE_SLOT_COUNT = (32);

    [NativeTypeName("#define D3D10_1_IA_VERTEX_INPUT_STRUCTURE_ELEMENTS_COMPONENTS ( 128 )")]
    public const int D3D10_1_IA_VERTEX_INPUT_STRUCTURE_ELEMENTS_COMPONENTS = (128);

    [NativeTypeName("#define D3D10_1_IA_VERTEX_INPUT_STRUCTURE_ELEMENT_COUNT ( 32 )")]
    public const int D3D10_1_IA_VERTEX_INPUT_STRUCTURE_ELEMENT_COUNT = (32);

    [NativeTypeName("#define D3D10_1_PS_OUTPUT_MASK_REGISTER_COMPONENTS ( 1 )")]
    public const int D3D10_1_PS_OUTPUT_MASK_REGISTER_COMPONENTS = (1);

    [NativeTypeName("#define D3D10_1_PS_OUTPUT_MASK_REGISTER_COMPONENT_BIT_COUNT ( 32 )")]
    public const int D3D10_1_PS_OUTPUT_MASK_REGISTER_COMPONENT_BIT_COUNT = (32);

    [NativeTypeName("#define D3D10_1_PS_OUTPUT_MASK_REGISTER_COUNT ( 1 )")]
    public const int D3D10_1_PS_OUTPUT_MASK_REGISTER_COUNT = (1);

    [NativeTypeName("#define D3D10_1_SHADER_MAJOR_VERSION ( 4 )")]
    public const int D3D10_1_SHADER_MAJOR_VERSION = (4);

    [NativeTypeName("#define D3D10_1_SHADER_MINOR_VERSION ( 1 )")]
    public const int D3D10_1_SHADER_MINOR_VERSION = (1);

    [NativeTypeName("#define D3D10_1_SO_BUFFER_MAX_STRIDE_IN_BYTES ( 2048 )")]
    public const int D3D10_1_SO_BUFFER_MAX_STRIDE_IN_BYTES = (2048);

    [NativeTypeName("#define D3D10_1_SO_BUFFER_MAX_WRITE_WINDOW_IN_BYTES ( 256 )")]
    public const int D3D10_1_SO_BUFFER_MAX_WRITE_WINDOW_IN_BYTES = (256);

    [NativeTypeName("#define D3D10_1_SO_BUFFER_SLOT_COUNT ( 4 )")]
    public const int D3D10_1_SO_BUFFER_SLOT_COUNT = (4);

    [NativeTypeName("#define D3D10_1_SO_MULTIPLE_BUFFER_ELEMENTS_PER_BUFFER ( 1 )")]
    public const int D3D10_1_SO_MULTIPLE_BUFFER_ELEMENTS_PER_BUFFER = (1);

    [NativeTypeName("#define D3D10_1_SO_SINGLE_BUFFER_COMPONENT_LIMIT ( 64 )")]
    public const int D3D10_1_SO_SINGLE_BUFFER_COMPONENT_LIMIT = (64);

    [NativeTypeName("#define D3D10_1_STANDARD_VERTEX_ELEMENT_COUNT ( 32 )")]
    public const int D3D10_1_STANDARD_VERTEX_ELEMENT_COUNT = (32);

    [NativeTypeName("#define D3D10_1_SUBPIXEL_FRACTIONAL_BIT_COUNT ( 8 )")]
    public const int D3D10_1_SUBPIXEL_FRACTIONAL_BIT_COUNT = (8);

    [NativeTypeName("#define D3D10_1_VS_INPUT_REGISTER_COUNT ( 32 )")]
    public const int D3D10_1_VS_INPUT_REGISTER_COUNT = (32);

    [NativeTypeName("#define D3D10_1_VS_OUTPUT_REGISTER_COUNT ( 32 )")]
    public const int D3D10_1_VS_OUTPUT_REGISTER_COUNT = (32);

    [NativeTypeName("#define D3D10_1_SDK_VERSION ( ( 0 + 0x20 )  )")]
    public const int D3D10_1_SDK_VERSION = ((0 + 0x20));
}
