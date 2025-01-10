// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/d3d9types.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public static partial class D3DUSAGE
{
    [NativeTypeName("#define D3DUSAGE_RENDERTARGET (0x00000001L)")]
    public const int D3DUSAGE_RENDERTARGET = (0x00000001);

    [NativeTypeName("#define D3DUSAGE_DEPTHSTENCIL (0x00000002L)")]
    public const int D3DUSAGE_DEPTHSTENCIL = (0x00000002);

    [NativeTypeName("#define D3DUSAGE_DYNAMIC (0x00000200L)")]
    public const int D3DUSAGE_DYNAMIC = (0x00000200);

    [NativeTypeName("#define D3DUSAGE_NONSECURE (0x00800000L)")]
    public const int D3DUSAGE_NONSECURE = (0x00800000);

    [NativeTypeName("#define D3DUSAGE_AUTOGENMIPMAP (0x00000400L)")]
    public const int D3DUSAGE_AUTOGENMIPMAP = (0x00000400);

    [NativeTypeName("#define D3DUSAGE_DMAP (0x00004000L)")]
    public const int D3DUSAGE_DMAP = (0x00004000);

    [NativeTypeName("#define D3DUSAGE_QUERY_LEGACYBUMPMAP (0x00008000L)")]
    public const int D3DUSAGE_QUERY_LEGACYBUMPMAP = (0x00008000);

    [NativeTypeName("#define D3DUSAGE_QUERY_SRGBREAD (0x00010000L)")]
    public const int D3DUSAGE_QUERY_SRGBREAD = (0x00010000);

    [NativeTypeName("#define D3DUSAGE_QUERY_FILTER (0x00020000L)")]
    public const int D3DUSAGE_QUERY_FILTER = (0x00020000);

    [NativeTypeName("#define D3DUSAGE_QUERY_SRGBWRITE (0x00040000L)")]
    public const int D3DUSAGE_QUERY_SRGBWRITE = (0x00040000);

    [NativeTypeName("#define D3DUSAGE_QUERY_POSTPIXELSHADER_BLENDING (0x00080000L)")]
    public const int D3DUSAGE_QUERY_POSTPIXELSHADER_BLENDING = (0x00080000);

    [NativeTypeName("#define D3DUSAGE_QUERY_VERTEXTEXTURE (0x00100000L)")]
    public const int D3DUSAGE_QUERY_VERTEXTEXTURE = (0x00100000);

    [NativeTypeName("#define D3DUSAGE_QUERY_WRAPANDMIP (0x00200000L)")]
    public const int D3DUSAGE_QUERY_WRAPANDMIP = (0x00200000);

    [NativeTypeName("#define D3DUSAGE_WRITEONLY (0x00000008L)")]
    public const int D3DUSAGE_WRITEONLY = (0x00000008);

    [NativeTypeName("#define D3DUSAGE_SOFTWAREPROCESSING (0x00000010L)")]
    public const int D3DUSAGE_SOFTWAREPROCESSING = (0x00000010);

    [NativeTypeName("#define D3DUSAGE_DONOTCLIP (0x00000020L)")]
    public const int D3DUSAGE_DONOTCLIP = (0x00000020);

    [NativeTypeName("#define D3DUSAGE_POINTS (0x00000040L)")]
    public const int D3DUSAGE_POINTS = (0x00000040);

    [NativeTypeName("#define D3DUSAGE_RTPATCHES (0x00000080L)")]
    public const int D3DUSAGE_RTPATCHES = (0x00000080);

    [NativeTypeName("#define D3DUSAGE_NPATCHES (0x00000100L)")]
    public const int D3DUSAGE_NPATCHES = (0x00000100);

    [NativeTypeName("#define D3DUSAGE_TEXTAPI (0x10000000L)")]
    public const int D3DUSAGE_TEXTAPI = (0x10000000);

    [NativeTypeName("#define D3DUSAGE_RESTRICTED_CONTENT (0x00000800L)")]
    public const int D3DUSAGE_RESTRICTED_CONTENT = (0x00000800);

    [NativeTypeName("#define D3DUSAGE_RESTRICT_SHARED_RESOURCE (0x00002000L)")]
    public const int D3DUSAGE_RESTRICT_SHARED_RESOURCE = (0x00002000);

    [NativeTypeName("#define D3DUSAGE_RESTRICT_SHARED_RESOURCE_DRIVER (0x00001000L)")]
    public const int D3DUSAGE_RESTRICT_SHARED_RESOURCE_DRIVER = (0x00001000);
}
