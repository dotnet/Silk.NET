// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/d3d9types.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public static partial class D3DTA
{
    [NativeTypeName("#define D3DTA_SELECTMASK 0x0000000f")]
    public const int D3DTA_SELECTMASK = 0x0000000f;

    [NativeTypeName("#define D3DTA_DIFFUSE 0x00000000")]
    public const int D3DTA_DIFFUSE = 0x00000000;

    [NativeTypeName("#define D3DTA_CURRENT 0x00000001")]
    public const int D3DTA_CURRENT = 0x00000001;

    [NativeTypeName("#define D3DTA_TEXTURE 0x00000002")]
    public const int D3DTA_TEXTURE = 0x00000002;

    [NativeTypeName("#define D3DTA_TFACTOR 0x00000003")]
    public const int D3DTA_TFACTOR = 0x00000003;

    [NativeTypeName("#define D3DTA_SPECULAR 0x00000004")]
    public const int D3DTA_SPECULAR = 0x00000004;

    [NativeTypeName("#define D3DTA_TEMP 0x00000005")]
    public const int D3DTA_TEMP = 0x00000005;

    [NativeTypeName("#define D3DTA_CONSTANT 0x00000006")]
    public const int D3DTA_CONSTANT = 0x00000006;

    [NativeTypeName("#define D3DTA_COMPLEMENT 0x00000010")]
    public const int D3DTA_COMPLEMENT = 0x00000010;

    [NativeTypeName("#define D3DTA_ALPHAREPLICATE 0x00000020")]
    public const int D3DTA_ALPHAREPLICATE = 0x00000020;
}
