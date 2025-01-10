// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/d3d9types.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public static partial class D3DSPDM
{
    [NativeTypeName("#define D3DSPDM_NONE (0<<D3DSP_DSTMOD_SHIFT)")]
    public const int D3DSPDM_NONE = (0 << 20);

    [NativeTypeName("#define D3DSPDM_SATURATE (1<<D3DSP_DSTMOD_SHIFT)")]
    public const int D3DSPDM_SATURATE = (1 << 20);

    [NativeTypeName("#define D3DSPDM_PARTIALPRECISION (2<<D3DSP_DSTMOD_SHIFT)")]
    public const int D3DSPDM_PARTIALPRECISION = (2 << 20);

    [NativeTypeName("#define D3DSPDM_MSAMPCENTROID (4<<D3DSP_DSTMOD_SHIFT)")]
    public const int D3DSPDM_MSAMPCENTROID = (4 << 20);
}
