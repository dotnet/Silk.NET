// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d3dcompiler.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public static partial class D3DCOMPILE
{
    [NativeTypeName("#define D3DCOMPILE_DEBUG (1 << 0)")]
    public const int D3DCOMPILE_DEBUG = (1 << 0);

    [NativeTypeName("#define D3DCOMPILE_SKIP_VALIDATION (1 << 1)")]
    public const int D3DCOMPILE_SKIP_VALIDATION = (1 << 1);

    [NativeTypeName("#define D3DCOMPILE_SKIP_OPTIMIZATION (1 << 2)")]
    public const int D3DCOMPILE_SKIP_OPTIMIZATION = (1 << 2);

    [NativeTypeName("#define D3DCOMPILE_PACK_MATRIX_ROW_MAJOR (1 << 3)")]
    public const int D3DCOMPILE_PACK_MATRIX_ROW_MAJOR = (1 << 3);

    [NativeTypeName("#define D3DCOMPILE_PACK_MATRIX_COLUMN_MAJOR (1 << 4)")]
    public const int D3DCOMPILE_PACK_MATRIX_COLUMN_MAJOR = (1 << 4);

    [NativeTypeName("#define D3DCOMPILE_PARTIAL_PRECISION (1 << 5)")]
    public const int D3DCOMPILE_PARTIAL_PRECISION = (1 << 5);

    [NativeTypeName("#define D3DCOMPILE_FORCE_VS_SOFTWARE_NO_OPT (1 << 6)")]
    public const int D3DCOMPILE_FORCE_VS_SOFTWARE_NO_OPT = (1 << 6);

    [NativeTypeName("#define D3DCOMPILE_FORCE_PS_SOFTWARE_NO_OPT (1 << 7)")]
    public const int D3DCOMPILE_FORCE_PS_SOFTWARE_NO_OPT = (1 << 7);

    [NativeTypeName("#define D3DCOMPILE_NO_PRESHADER (1 << 8)")]
    public const int D3DCOMPILE_NO_PRESHADER = (1 << 8);

    [NativeTypeName("#define D3DCOMPILE_AVOID_FLOW_CONTROL (1 << 9)")]
    public const int D3DCOMPILE_AVOID_FLOW_CONTROL = (1 << 9);

    [NativeTypeName("#define D3DCOMPILE_PREFER_FLOW_CONTROL (1 << 10)")]
    public const int D3DCOMPILE_PREFER_FLOW_CONTROL = (1 << 10);

    [NativeTypeName("#define D3DCOMPILE_ENABLE_STRICTNESS (1 << 11)")]
    public const int D3DCOMPILE_ENABLE_STRICTNESS = (1 << 11);

    [NativeTypeName("#define D3DCOMPILE_ENABLE_BACKWARDS_COMPATIBILITY (1 << 12)")]
    public const int D3DCOMPILE_ENABLE_BACKWARDS_COMPATIBILITY = (1 << 12);

    [NativeTypeName("#define D3DCOMPILE_IEEE_STRICTNESS (1 << 13)")]
    public const int D3DCOMPILE_IEEE_STRICTNESS = (1 << 13);

    [NativeTypeName("#define D3DCOMPILE_OPTIMIZATION_LEVEL0 (1 << 14)")]
    public const int D3DCOMPILE_OPTIMIZATION_LEVEL0 = (1 << 14);

    [NativeTypeName("#define D3DCOMPILE_OPTIMIZATION_LEVEL1 0")]
    public const int D3DCOMPILE_OPTIMIZATION_LEVEL1 = 0;

    [NativeTypeName("#define D3DCOMPILE_OPTIMIZATION_LEVEL2 ((1 << 14) | (1 << 15))")]
    public const int D3DCOMPILE_OPTIMIZATION_LEVEL2 = ((1 << 14) | (1 << 15));

    [NativeTypeName("#define D3DCOMPILE_OPTIMIZATION_LEVEL3 (1 << 15)")]
    public const int D3DCOMPILE_OPTIMIZATION_LEVEL3 = (1 << 15);

    [NativeTypeName("#define D3DCOMPILE_RESERVED16 (1 << 16)")]
    public const int D3DCOMPILE_RESERVED16 = (1 << 16);

    [NativeTypeName("#define D3DCOMPILE_RESERVED17 (1 << 17)")]
    public const int D3DCOMPILE_RESERVED17 = (1 << 17);

    [NativeTypeName("#define D3DCOMPILE_WARNINGS_ARE_ERRORS (1 << 18)")]
    public const int D3DCOMPILE_WARNINGS_ARE_ERRORS = (1 << 18);

    [NativeTypeName("#define D3DCOMPILE_RESOURCES_MAY_ALIAS (1 << 19)")]
    public const int D3DCOMPILE_RESOURCES_MAY_ALIAS = (1 << 19);

    [NativeTypeName("#define D3DCOMPILE_ENABLE_UNBOUNDED_DESCRIPTOR_TABLES (1 << 20)")]
    public const int D3DCOMPILE_ENABLE_UNBOUNDED_DESCRIPTOR_TABLES = (1 << 20);

    [NativeTypeName("#define D3DCOMPILE_ALL_RESOURCES_BOUND (1 << 21)")]
    public const int D3DCOMPILE_ALL_RESOURCES_BOUND = (1 << 21);

    [NativeTypeName("#define D3DCOMPILE_DEBUG_NAME_FOR_SOURCE (1 << 22)")]
    public const int D3DCOMPILE_DEBUG_NAME_FOR_SOURCE = (1 << 22);

    [NativeTypeName("#define D3DCOMPILE_DEBUG_NAME_FOR_BINARY (1 << 23)")]
    public const int D3DCOMPILE_DEBUG_NAME_FOR_BINARY = (1 << 23);

    [NativeTypeName("#define D3DCOMPILE_EFFECT_CHILD_EFFECT (1 << 0)")]
    public const int D3DCOMPILE_EFFECT_CHILD_EFFECT = (1 << 0);

    [NativeTypeName("#define D3DCOMPILE_EFFECT_ALLOW_SLOW_OPS (1 << 1)")]
    public const int D3DCOMPILE_EFFECT_ALLOW_SLOW_OPS = (1 << 1);

    [NativeTypeName("#define D3DCOMPILE_FLAGS2_FORCE_ROOT_SIGNATURE_LATEST 0")]
    public const int D3DCOMPILE_FLAGS2_FORCE_ROOT_SIGNATURE_LATEST = 0;

    [NativeTypeName("#define D3DCOMPILE_FLAGS2_FORCE_ROOT_SIGNATURE_1_0 (1 << 4)")]
    public const int D3DCOMPILE_FLAGS2_FORCE_ROOT_SIGNATURE_1_0 = (1 << 4);

    [NativeTypeName("#define D3DCOMPILE_FLAGS2_FORCE_ROOT_SIGNATURE_1_1 (1 << 5)")]
    public const int D3DCOMPILE_FLAGS2_FORCE_ROOT_SIGNATURE_1_1 = (1 << 5);

    [NativeTypeName("#define D3DCOMPILE_SECDATA_MERGE_UAV_SLOTS 0x00000001")]
    public const int D3DCOMPILE_SECDATA_MERGE_UAV_SLOTS = 0x00000001;

    [NativeTypeName("#define D3DCOMPILE_SECDATA_PRESERVE_TEMPLATE_SLOTS 0x00000002")]
    public const int D3DCOMPILE_SECDATA_PRESERVE_TEMPLATE_SLOTS = 0x00000002;

    [NativeTypeName("#define D3DCOMPILE_SECDATA_REQUIRE_TEMPLATE_MATCH 0x00000004")]
    public const int D3DCOMPILE_SECDATA_REQUIRE_TEMPLATE_MATCH = 0x00000004;
}
