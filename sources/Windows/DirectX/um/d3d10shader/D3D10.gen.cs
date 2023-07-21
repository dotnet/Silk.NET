// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d10shader.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.DirectX;

public static partial class D3D10
{
    [NativeTypeName("#define D3D10_SHADER_DEBUG (1 << 0)")]
    public const int D3D10_SHADER_DEBUG = (1 << 0);

    [NativeTypeName("#define D3D10_SHADER_SKIP_VALIDATION (1 << 1)")]
    public const int D3D10_SHADER_SKIP_VALIDATION = (1 << 1);

    [NativeTypeName("#define D3D10_SHADER_SKIP_OPTIMIZATION (1 << 2)")]
    public const int D3D10_SHADER_SKIP_OPTIMIZATION = (1 << 2);

    [NativeTypeName("#define D3D10_SHADER_PACK_MATRIX_ROW_MAJOR (1 << 3)")]
    public const int D3D10_SHADER_PACK_MATRIX_ROW_MAJOR = (1 << 3);

    [NativeTypeName("#define D3D10_SHADER_PACK_MATRIX_COLUMN_MAJOR (1 << 4)")]
    public const int D3D10_SHADER_PACK_MATRIX_COLUMN_MAJOR = (1 << 4);

    [NativeTypeName("#define D3D10_SHADER_PARTIAL_PRECISION (1 << 5)")]
    public const int D3D10_SHADER_PARTIAL_PRECISION = (1 << 5);

    [NativeTypeName("#define D3D10_SHADER_FORCE_VS_SOFTWARE_NO_OPT (1 << 6)")]
    public const int D3D10_SHADER_FORCE_VS_SOFTWARE_NO_OPT = (1 << 6);

    [NativeTypeName("#define D3D10_SHADER_FORCE_PS_SOFTWARE_NO_OPT (1 << 7)")]
    public const int D3D10_SHADER_FORCE_PS_SOFTWARE_NO_OPT = (1 << 7);

    [NativeTypeName("#define D3D10_SHADER_NO_PRESHADER (1 << 8)")]
    public const int D3D10_SHADER_NO_PRESHADER = (1 << 8);

    [NativeTypeName("#define D3D10_SHADER_AVOID_FLOW_CONTROL (1 << 9)")]
    public const int D3D10_SHADER_AVOID_FLOW_CONTROL = (1 << 9);

    [NativeTypeName("#define D3D10_SHADER_PREFER_FLOW_CONTROL (1 << 10)")]
    public const int D3D10_SHADER_PREFER_FLOW_CONTROL = (1 << 10);

    [NativeTypeName("#define D3D10_SHADER_ENABLE_STRICTNESS (1 << 11)")]
    public const int D3D10_SHADER_ENABLE_STRICTNESS = (1 << 11);

    [NativeTypeName("#define D3D10_SHADER_ENABLE_BACKWARDS_COMPATIBILITY (1 << 12)")]
    public const int D3D10_SHADER_ENABLE_BACKWARDS_COMPATIBILITY = (1 << 12);

    [NativeTypeName("#define D3D10_SHADER_IEEE_STRICTNESS (1 << 13)")]
    public const int D3D10_SHADER_IEEE_STRICTNESS = (1 << 13);

    [NativeTypeName("#define D3D10_SHADER_WARNINGS_ARE_ERRORS (1 << 18)")]
    public const int D3D10_SHADER_WARNINGS_ARE_ERRORS = (1 << 18);

    [NativeTypeName("#define D3D10_SHADER_RESOURCES_MAY_ALIAS (1 << 19)")]
    public const int D3D10_SHADER_RESOURCES_MAY_ALIAS = (1 << 19);

    [NativeTypeName("#define D3D10_ENABLE_UNBOUNDED_DESCRIPTOR_TABLES (1 << 20)")]
    public const int D3D10_ENABLE_UNBOUNDED_DESCRIPTOR_TABLES = (1 << 20);

    [NativeTypeName("#define D3D10_ALL_RESOURCES_BOUND (1 << 21)")]
    public const int D3D10_ALL_RESOURCES_BOUND = (1 << 21);

    [NativeTypeName("#define D3D10_SHADER_DEBUG_NAME_FOR_SOURCE (1 << 22)")]
    public const int D3D10_SHADER_DEBUG_NAME_FOR_SOURCE = (1 << 22);

    [NativeTypeName("#define D3D10_SHADER_DEBUG_NAME_FOR_BINARY (1 << 23)")]
    public const int D3D10_SHADER_DEBUG_NAME_FOR_BINARY = (1 << 23);

    [NativeTypeName("#define D3D10_SHADER_OPTIMIZATION_LEVEL0 (1 << 14)")]
    public const int D3D10_SHADER_OPTIMIZATION_LEVEL0 = (1 << 14);

    [NativeTypeName("#define D3D10_SHADER_OPTIMIZATION_LEVEL1 0")]
    public const int D3D10_SHADER_OPTIMIZATION_LEVEL1 = 0;

    [NativeTypeName("#define D3D10_SHADER_OPTIMIZATION_LEVEL2 ((1 << 14) | (1 << 15))")]
    public const int D3D10_SHADER_OPTIMIZATION_LEVEL2 = ((1 << 14) | (1 << 15));

    [NativeTypeName("#define D3D10_SHADER_OPTIMIZATION_LEVEL3 (1 << 15)")]
    public const int D3D10_SHADER_OPTIMIZATION_LEVEL3 = (1 << 15);

    [NativeTypeName("#define D3D10_SHADER_FLAGS2_FORCE_ROOT_SIGNATURE_LATEST 0")]
    public const int D3D10_SHADER_FLAGS2_FORCE_ROOT_SIGNATURE_LATEST = 0;

    [NativeTypeName("#define D3D10_SHADER_FLAGS2_FORCE_ROOT_SIGNATURE_1_0 (1 << 4)")]
    public const int D3D10_SHADER_FLAGS2_FORCE_ROOT_SIGNATURE_1_0 = (1 << 4);

    [NativeTypeName("#define D3D10_SHADER_FLAGS2_FORCE_ROOT_SIGNATURE_1_1 (1 << 5)")]
    public const int D3D10_SHADER_FLAGS2_FORCE_ROOT_SIGNATURE_1_1 = (1 << 5);
}
