// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/d3d9caps.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public static partial class D3DPTFILTERCAPS
{
    [NativeTypeName("#define D3DPTFILTERCAPS_MINFPOINT 0x00000100L")]
    public const int D3DPTFILTERCAPS_MINFPOINT = 0x00000100;

    [NativeTypeName("#define D3DPTFILTERCAPS_MINFLINEAR 0x00000200L")]
    public const int D3DPTFILTERCAPS_MINFLINEAR = 0x00000200;

    [NativeTypeName("#define D3DPTFILTERCAPS_MINFANISOTROPIC 0x00000400L")]
    public const int D3DPTFILTERCAPS_MINFANISOTROPIC = 0x00000400;

    [NativeTypeName("#define D3DPTFILTERCAPS_MINFPYRAMIDALQUAD 0x00000800L")]
    public const int D3DPTFILTERCAPS_MINFPYRAMIDALQUAD = 0x00000800;

    [NativeTypeName("#define D3DPTFILTERCAPS_MINFGAUSSIANQUAD 0x00001000L")]
    public const int D3DPTFILTERCAPS_MINFGAUSSIANQUAD = 0x00001000;

    [NativeTypeName("#define D3DPTFILTERCAPS_MIPFPOINT 0x00010000L")]
    public const int D3DPTFILTERCAPS_MIPFPOINT = 0x00010000;

    [NativeTypeName("#define D3DPTFILTERCAPS_MIPFLINEAR 0x00020000L")]
    public const int D3DPTFILTERCAPS_MIPFLINEAR = 0x00020000;

    [NativeTypeName("#define D3DPTFILTERCAPS_CONVOLUTIONMONO 0x00040000L")]
    public const int D3DPTFILTERCAPS_CONVOLUTIONMONO = 0x00040000;

    [NativeTypeName("#define D3DPTFILTERCAPS_MAGFPOINT 0x01000000L")]
    public const int D3DPTFILTERCAPS_MAGFPOINT = 0x01000000;

    [NativeTypeName("#define D3DPTFILTERCAPS_MAGFLINEAR 0x02000000L")]
    public const int D3DPTFILTERCAPS_MAGFLINEAR = 0x02000000;

    [NativeTypeName("#define D3DPTFILTERCAPS_MAGFANISOTROPIC 0x04000000L")]
    public const int D3DPTFILTERCAPS_MAGFANISOTROPIC = 0x04000000;

    [NativeTypeName("#define D3DPTFILTERCAPS_MAGFPYRAMIDALQUAD 0x08000000L")]
    public const int D3DPTFILTERCAPS_MAGFPYRAMIDALQUAD = 0x08000000;

    [NativeTypeName("#define D3DPTFILTERCAPS_MAGFGAUSSIANQUAD 0x10000000L")]
    public const int D3DPTFILTERCAPS_MAGFGAUSSIANQUAD = 0x10000000;
}
