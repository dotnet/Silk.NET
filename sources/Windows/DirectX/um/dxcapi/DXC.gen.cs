// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dxcapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved. Licensed under the University of Illinois Open Source License.

namespace Silk.NET.DirectX;

public static partial class DXC
{
    [NativeTypeName("#define DXC_CP_UTF8 65001")]
    public const int DXC_CP_UTF8 = 65001;

    [NativeTypeName("#define DXC_CP_UTF16 1200")]
    public const int DXC_CP_UTF16 = 1200;

    [NativeTypeName("#define DXC_CP_ACP 0")]
    public const int DXC_CP_ACP = 0;

    [NativeTypeName("#define DXC_HASHFLAG_INCLUDES_SOURCE 1")]
    public const int DXC_HASHFLAG_INCLUDES_SOURCE = 1;

    [NativeTypeName("#define DXC_PART_PDB DXC_FOURCC('I', 'L', 'D', 'B')")]
    public const uint DXC_PART_PDB = ((uint)((byte)('I')) | (uint)((byte)('L')) << 8 | (uint)((byte)('D')) << 16 | (uint)((byte)('B')) << 24);

    [NativeTypeName("#define DXC_PART_PDB_NAME DXC_FOURCC('I', 'L', 'D', 'N')")]
    public const uint DXC_PART_PDB_NAME = ((uint)((byte)('I')) | (uint)((byte)('L')) << 8 | (uint)((byte)('D')) << 16 | (uint)((byte)('N')) << 24);

    [NativeTypeName("#define DXC_PART_PRIVATE_DATA DXC_FOURCC('P', 'R', 'I', 'V')")]
    public const uint DXC_PART_PRIVATE_DATA = ((uint)((byte)('P')) | (uint)((byte)('R')) << 8 | (uint)((byte)('I')) << 16 | (uint)((byte)('V')) << 24);

    [NativeTypeName("#define DXC_PART_ROOT_SIGNATURE DXC_FOURCC('R', 'T', 'S', '0')")]
    public const uint DXC_PART_ROOT_SIGNATURE = ((uint)((byte)('R')) | (uint)((byte)('T')) << 8 | (uint)((byte)('S')) << 16 | (uint)((byte)('0')) << 24);

    [NativeTypeName("#define DXC_PART_DXIL DXC_FOURCC('D', 'X', 'I', 'L')")]
    public const uint DXC_PART_DXIL = ((uint)((byte)('D')) | (uint)((byte)('X')) << 8 | (uint)((byte)('I')) << 16 | (uint)((byte)('L')) << 24);

    [NativeTypeName("#define DXC_PART_REFLECTION_DATA DXC_FOURCC('S', 'T', 'A', 'T')")]
    public const uint DXC_PART_REFLECTION_DATA = ((uint)((byte)('S')) | (uint)((byte)('T')) << 8 | (uint)((byte)('A')) << 16 | (uint)((byte)('T')) << 24);

    [NativeTypeName("#define DXC_PART_SHADER_HASH DXC_FOURCC('H', 'A', 'S', 'H')")]
    public const uint DXC_PART_SHADER_HASH = ((uint)((byte)('H')) | (uint)((byte)('A')) << 8 | (uint)((byte)('S')) << 16 | (uint)((byte)('H')) << 24);

    [NativeTypeName("#define DXC_PART_INPUT_SIGNATURE DXC_FOURCC('I', 'S', 'G', '1')")]
    public const uint DXC_PART_INPUT_SIGNATURE = ((uint)((byte)('I')) | (uint)((byte)('S')) << 8 | (uint)((byte)('G')) << 16 | (uint)((byte)('1')) << 24);

    [NativeTypeName("#define DXC_PART_OUTPUT_SIGNATURE DXC_FOURCC('O', 'S', 'G', '1')")]
    public const uint DXC_PART_OUTPUT_SIGNATURE = ((uint)((byte)('O')) | (uint)((byte)('S')) << 8 | (uint)((byte)('G')) << 16 | (uint)((byte)('1')) << 24);

    [NativeTypeName("#define DXC_PART_PATCH_CONSTANT_SIGNATURE DXC_FOURCC('P', 'S', 'G', '1')")]
    public const uint DXC_PART_PATCH_CONSTANT_SIGNATURE = ((uint)((byte)('P')) | (uint)((byte)('S')) << 8 | (uint)((byte)('G')) << 16 | (uint)((byte)('1')) << 24);

    [NativeTypeName("#define DXC_ARG_DEBUG L\"-Zi\"")]
    public const string DXC_ARG_DEBUG = "-Zi";

    [NativeTypeName("#define DXC_ARG_SKIP_VALIDATION L\"-Vd\"")]
    public const string DXC_ARG_SKIP_VALIDATION = "-Vd";

    [NativeTypeName("#define DXC_ARG_SKIP_OPTIMIZATIONS L\"-Od\"")]
    public const string DXC_ARG_SKIP_OPTIMIZATIONS = "-Od";

    [NativeTypeName("#define DXC_ARG_PACK_MATRIX_ROW_MAJOR L\"-Zpr\"")]
    public const string DXC_ARG_PACK_MATRIX_ROW_MAJOR = "-Zpr";

    [NativeTypeName("#define DXC_ARG_PACK_MATRIX_COLUMN_MAJOR L\"-Zpc\"")]
    public const string DXC_ARG_PACK_MATRIX_COLUMN_MAJOR = "-Zpc";

    [NativeTypeName("#define DXC_ARG_AVOID_FLOW_CONTROL L\"-Gfa\"")]
    public const string DXC_ARG_AVOID_FLOW_CONTROL = "-Gfa";

    [NativeTypeName("#define DXC_ARG_PREFER_FLOW_CONTROL L\"-Gfp\"")]
    public const string DXC_ARG_PREFER_FLOW_CONTROL = "-Gfp";

    [NativeTypeName("#define DXC_ARG_ENABLE_STRICTNESS L\"-Ges\"")]
    public const string DXC_ARG_ENABLE_STRICTNESS = "-Ges";

    [NativeTypeName("#define DXC_ARG_ENABLE_BACKWARDS_COMPATIBILITY L\"-Gec\"")]
    public const string DXC_ARG_ENABLE_BACKWARDS_COMPATIBILITY = "-Gec";

    [NativeTypeName("#define DXC_ARG_IEEE_STRICTNESS L\"-Gis\"")]
    public const string DXC_ARG_IEEE_STRICTNESS = "-Gis";

    [NativeTypeName("#define DXC_ARG_OPTIMIZATION_LEVEL0 L\"-O0\"")]
    public const string DXC_ARG_OPTIMIZATION_LEVEL0 = "-O0";

    [NativeTypeName("#define DXC_ARG_OPTIMIZATION_LEVEL1 L\"-O1\"")]
    public const string DXC_ARG_OPTIMIZATION_LEVEL1 = "-O1";

    [NativeTypeName("#define DXC_ARG_OPTIMIZATION_LEVEL2 L\"-O2\"")]
    public const string DXC_ARG_OPTIMIZATION_LEVEL2 = "-O2";

    [NativeTypeName("#define DXC_ARG_OPTIMIZATION_LEVEL3 L\"-O3\"")]
    public const string DXC_ARG_OPTIMIZATION_LEVEL3 = "-O3";

    [NativeTypeName("#define DXC_ARG_WARNINGS_ARE_ERRORS L\"-WX\"")]
    public const string DXC_ARG_WARNINGS_ARE_ERRORS = "-WX";

    [NativeTypeName("#define DXC_ARG_RESOURCES_MAY_ALIAS L\"-res_may_alias\"")]
    public const string DXC_ARG_RESOURCES_MAY_ALIAS = "-res_may_alias";

    [NativeTypeName("#define DXC_ARG_ALL_RESOURCES_BOUND L\"-all_resources_bound\"")]
    public const string DXC_ARG_ALL_RESOURCES_BOUND = "-all_resources_bound";

    [NativeTypeName("#define DXC_ARG_DEBUG_NAME_FOR_SOURCE L\"-Zss\"")]
    public const string DXC_ARG_DEBUG_NAME_FOR_SOURCE = "-Zss";

    [NativeTypeName("#define DXC_ARG_DEBUG_NAME_FOR_BINARY L\"-Zsb\"")]
    public const string DXC_ARG_DEBUG_NAME_FOR_BINARY = "-Zsb";

    [NativeTypeName("#define DXC_EXTRA_OUTPUT_NAME_STDOUT L\"*stdout*\"")]
    public const string DXC_EXTRA_OUTPUT_NAME_STDOUT = "*stdout*";

    [NativeTypeName("#define DXC_EXTRA_OUTPUT_NAME_STDERR L\"*stderr*\"")]
    public const string DXC_EXTRA_OUTPUT_NAME_STDERR = "*stderr*";
}
