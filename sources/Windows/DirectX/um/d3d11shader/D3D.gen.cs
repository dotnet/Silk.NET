// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11shader.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.DirectX;

public static partial class D3D
{
    [NativeTypeName("#define D3D_RETURN_PARAMETER_INDEX (-1)")]
    public const int D3D_RETURN_PARAMETER_INDEX = (-1);

    [NativeTypeName("#define D3D_SHADER_REQUIRES_DOUBLES 0x00000001")]
    public const int D3D_SHADER_REQUIRES_DOUBLES = 0x00000001;

    [NativeTypeName("#define D3D_SHADER_REQUIRES_EARLY_DEPTH_STENCIL 0x00000002")]
    public const int D3D_SHADER_REQUIRES_EARLY_DEPTH_STENCIL = 0x00000002;

    [NativeTypeName("#define D3D_SHADER_REQUIRES_UAVS_AT_EVERY_STAGE 0x00000004")]
    public const int D3D_SHADER_REQUIRES_UAVS_AT_EVERY_STAGE = 0x00000004;

    [NativeTypeName("#define D3D_SHADER_REQUIRES_64_UAVS 0x00000008")]
    public const int D3D_SHADER_REQUIRES_64_UAVS = 0x00000008;

    [NativeTypeName("#define D3D_SHADER_REQUIRES_MINIMUM_PRECISION 0x00000010")]
    public const int D3D_SHADER_REQUIRES_MINIMUM_PRECISION = 0x00000010;

    [NativeTypeName("#define D3D_SHADER_REQUIRES_11_1_DOUBLE_EXTENSIONS 0x00000020")]
    public const int D3D_SHADER_REQUIRES_11_1_DOUBLE_EXTENSIONS = 0x00000020;

    [NativeTypeName("#define D3D_SHADER_REQUIRES_11_1_SHADER_EXTENSIONS 0x00000040")]
    public const int D3D_SHADER_REQUIRES_11_1_SHADER_EXTENSIONS = 0x00000040;

    [NativeTypeName("#define D3D_SHADER_REQUIRES_LEVEL_9_COMPARISON_FILTERING 0x00000080")]
    public const int D3D_SHADER_REQUIRES_LEVEL_9_COMPARISON_FILTERING = 0x00000080;

    [NativeTypeName("#define D3D_SHADER_REQUIRES_TILED_RESOURCES 0x00000100")]
    public const int D3D_SHADER_REQUIRES_TILED_RESOURCES = 0x00000100;
}
