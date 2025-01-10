// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/d3d9caps.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public static partial class D3DPRASTERCAPS
{
    [NativeTypeName("#define D3DPRASTERCAPS_DITHER 0x00000001L")]
    public const int D3DPRASTERCAPS_DITHER = 0x00000001;

    [NativeTypeName("#define D3DPRASTERCAPS_ZTEST 0x00000010L")]
    public const int D3DPRASTERCAPS_ZTEST = 0x00000010;

    [NativeTypeName("#define D3DPRASTERCAPS_FOGVERTEX 0x00000080L")]
    public const int D3DPRASTERCAPS_FOGVERTEX = 0x00000080;

    [NativeTypeName("#define D3DPRASTERCAPS_FOGTABLE 0x00000100L")]
    public const int D3DPRASTERCAPS_FOGTABLE = 0x00000100;

    [NativeTypeName("#define D3DPRASTERCAPS_MIPMAPLODBIAS 0x00002000L")]
    public const int D3DPRASTERCAPS_MIPMAPLODBIAS = 0x00002000;

    [NativeTypeName("#define D3DPRASTERCAPS_ZBUFFERLESSHSR 0x00008000L")]
    public const int D3DPRASTERCAPS_ZBUFFERLESSHSR = 0x00008000;

    [NativeTypeName("#define D3DPRASTERCAPS_FOGRANGE 0x00010000L")]
    public const int D3DPRASTERCAPS_FOGRANGE = 0x00010000;

    [NativeTypeName("#define D3DPRASTERCAPS_ANISOTROPY 0x00020000L")]
    public const int D3DPRASTERCAPS_ANISOTROPY = 0x00020000;

    [NativeTypeName("#define D3DPRASTERCAPS_WBUFFER 0x00040000L")]
    public const int D3DPRASTERCAPS_WBUFFER = 0x00040000;

    [NativeTypeName("#define D3DPRASTERCAPS_WFOG 0x00100000L")]
    public const int D3DPRASTERCAPS_WFOG = 0x00100000;

    [NativeTypeName("#define D3DPRASTERCAPS_ZFOG 0x00200000L")]
    public const int D3DPRASTERCAPS_ZFOG = 0x00200000;

    [NativeTypeName("#define D3DPRASTERCAPS_COLORPERSPECTIVE 0x00400000L")]
    public const int D3DPRASTERCAPS_COLORPERSPECTIVE = 0x00400000;

    [NativeTypeName("#define D3DPRASTERCAPS_SCISSORTEST 0x01000000L")]
    public const int D3DPRASTERCAPS_SCISSORTEST = 0x01000000;

    [NativeTypeName("#define D3DPRASTERCAPS_SLOPESCALEDEPTHBIAS 0x02000000L")]
    public const int D3DPRASTERCAPS_SLOPESCALEDEPTHBIAS = 0x02000000;

    [NativeTypeName("#define D3DPRASTERCAPS_DEPTHBIAS 0x04000000L")]
    public const int D3DPRASTERCAPS_DEPTHBIAS = 0x04000000;

    [NativeTypeName("#define D3DPRASTERCAPS_MULTISAMPLE_TOGGLE 0x08000000L")]
    public const int D3DPRASTERCAPS_MULTISAMPLE_TOGGLE = 0x08000000;
}
