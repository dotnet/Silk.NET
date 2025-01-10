// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/d3d9types.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public static partial class D3DFVF
{
    [NativeTypeName("#define D3DFVF_RESERVED0 0x001")]
    public const int D3DFVF_RESERVED0 = 0x001;

    [NativeTypeName("#define D3DFVF_POSITION_MASK 0x400E")]
    public const int D3DFVF_POSITION_MASK = 0x400E;

    [NativeTypeName("#define D3DFVF_XYZ 0x002")]
    public const int D3DFVF_XYZ = 0x002;

    [NativeTypeName("#define D3DFVF_XYZRHW 0x004")]
    public const int D3DFVF_XYZRHW = 0x004;

    [NativeTypeName("#define D3DFVF_XYZB1 0x006")]
    public const int D3DFVF_XYZB1 = 0x006;

    [NativeTypeName("#define D3DFVF_XYZB2 0x008")]
    public const int D3DFVF_XYZB2 = 0x008;

    [NativeTypeName("#define D3DFVF_XYZB3 0x00a")]
    public const int D3DFVF_XYZB3 = 0x00a;

    [NativeTypeName("#define D3DFVF_XYZB4 0x00c")]
    public const int D3DFVF_XYZB4 = 0x00c;

    [NativeTypeName("#define D3DFVF_XYZB5 0x00e")]
    public const int D3DFVF_XYZB5 = 0x00e;

    [NativeTypeName("#define D3DFVF_XYZW 0x4002")]
    public const int D3DFVF_XYZW = 0x4002;

    [NativeTypeName("#define D3DFVF_NORMAL 0x010")]
    public const int D3DFVF_NORMAL = 0x010;

    [NativeTypeName("#define D3DFVF_PSIZE 0x020")]
    public const int D3DFVF_PSIZE = 0x020;

    [NativeTypeName("#define D3DFVF_DIFFUSE 0x040")]
    public const int D3DFVF_DIFFUSE = 0x040;

    [NativeTypeName("#define D3DFVF_SPECULAR 0x080")]
    public const int D3DFVF_SPECULAR = 0x080;

    [NativeTypeName("#define D3DFVF_TEXCOUNT_MASK 0xf00")]
    public const int D3DFVF_TEXCOUNT_MASK = 0xf00;

    [NativeTypeName("#define D3DFVF_TEXCOUNT_SHIFT 8")]
    public const int D3DFVF_TEXCOUNT_SHIFT = 8;

    [NativeTypeName("#define D3DFVF_TEX0 0x000")]
    public const int D3DFVF_TEX0 = 0x000;

    [NativeTypeName("#define D3DFVF_TEX1 0x100")]
    public const int D3DFVF_TEX1 = 0x100;

    [NativeTypeName("#define D3DFVF_TEX2 0x200")]
    public const int D3DFVF_TEX2 = 0x200;

    [NativeTypeName("#define D3DFVF_TEX3 0x300")]
    public const int D3DFVF_TEX3 = 0x300;

    [NativeTypeName("#define D3DFVF_TEX4 0x400")]
    public const int D3DFVF_TEX4 = 0x400;

    [NativeTypeName("#define D3DFVF_TEX5 0x500")]
    public const int D3DFVF_TEX5 = 0x500;

    [NativeTypeName("#define D3DFVF_TEX6 0x600")]
    public const int D3DFVF_TEX6 = 0x600;

    [NativeTypeName("#define D3DFVF_TEX7 0x700")]
    public const int D3DFVF_TEX7 = 0x700;

    [NativeTypeName("#define D3DFVF_TEX8 0x800")]
    public const int D3DFVF_TEX8 = 0x800;

    [NativeTypeName("#define D3DFVF_LASTBETA_UBYTE4 0x1000")]
    public const int D3DFVF_LASTBETA_UBYTE4 = 0x1000;

    [NativeTypeName("#define D3DFVF_LASTBETA_D3DCOLOR 0x8000")]
    public const int D3DFVF_LASTBETA_D3DCOLOR = 0x8000;

    [NativeTypeName("#define D3DFVF_RESERVED2 0x6000")]
    public const int D3DFVF_RESERVED2 = 0x6000;

    [NativeTypeName("#define D3DFVF_TEXTUREFORMAT2 0")]
    public const int D3DFVF_TEXTUREFORMAT2 = 0;

    [NativeTypeName("#define D3DFVF_TEXTUREFORMAT1 3")]
    public const int D3DFVF_TEXTUREFORMAT1 = 3;

    [NativeTypeName("#define D3DFVF_TEXTUREFORMAT3 1")]
    public const int D3DFVF_TEXTUREFORMAT3 = 1;

    [NativeTypeName("#define D3DFVF_TEXTUREFORMAT4 2")]
    public const int D3DFVF_TEXTUREFORMAT4 = 2;
}
