// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/d3d9types.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public static partial class D3DTS
{
    [NativeTypeName("#define D3DTS_WORLD D3DTS_WORLDMATRIX(0)")]
    public const D3DTRANSFORMSTATETYPE D3DTS_WORLD = (D3DTRANSFORMSTATETYPE)(0 + 256);

    [NativeTypeName("#define D3DTS_WORLD1 D3DTS_WORLDMATRIX(1)")]
    public const D3DTRANSFORMSTATETYPE D3DTS_WORLD1 = (D3DTRANSFORMSTATETYPE)(1 + 256);

    [NativeTypeName("#define D3DTS_WORLD2 D3DTS_WORLDMATRIX(2)")]
    public const D3DTRANSFORMSTATETYPE D3DTS_WORLD2 = (D3DTRANSFORMSTATETYPE)(2 + 256);

    [NativeTypeName("#define D3DTS_WORLD3 D3DTS_WORLDMATRIX(3)")]
    public const D3DTRANSFORMSTATETYPE D3DTS_WORLD3 = (D3DTRANSFORMSTATETYPE)(3 + 256);
}
