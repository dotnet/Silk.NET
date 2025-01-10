// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/d3d9types.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public static partial class D3DPRESENTFLAG
{
    [NativeTypeName("#define D3DPRESENTFLAG_LOCKABLE_BACKBUFFER 0x00000001")]
    public const int D3DPRESENTFLAG_LOCKABLE_BACKBUFFER = 0x00000001;

    [NativeTypeName("#define D3DPRESENTFLAG_DISCARD_DEPTHSTENCIL 0x00000002")]
    public const int D3DPRESENTFLAG_DISCARD_DEPTHSTENCIL = 0x00000002;

    [NativeTypeName("#define D3DPRESENTFLAG_DEVICECLIP 0x00000004")]
    public const int D3DPRESENTFLAG_DEVICECLIP = 0x00000004;

    [NativeTypeName("#define D3DPRESENTFLAG_VIDEO 0x00000010")]
    public const int D3DPRESENTFLAG_VIDEO = 0x00000010;

    [NativeTypeName("#define D3DPRESENTFLAG_NOAUTOROTATE 0x00000020")]
    public const int D3DPRESENTFLAG_NOAUTOROTATE = 0x00000020;

    [NativeTypeName("#define D3DPRESENTFLAG_UNPRUNEDMODE 0x00000040")]
    public const int D3DPRESENTFLAG_UNPRUNEDMODE = 0x00000040;

    [NativeTypeName("#define D3DPRESENTFLAG_OVERLAY_LIMITEDRGB 0x00000080")]
    public const int D3DPRESENTFLAG_OVERLAY_LIMITEDRGB = 0x00000080;

    [NativeTypeName("#define D3DPRESENTFLAG_OVERLAY_YCbCr_BT709 0x00000100")]
    public const int D3DPRESENTFLAG_OVERLAY_YCbCr_BT709 = 0x00000100;

    [NativeTypeName("#define D3DPRESENTFLAG_OVERLAY_YCbCr_xvYCC 0x00000200")]
    public const int D3DPRESENTFLAG_OVERLAY_YCbCr_xvYCC = 0x00000200;

    [NativeTypeName("#define D3DPRESENTFLAG_RESTRICTED_CONTENT 0x00000400")]
    public const int D3DPRESENTFLAG_RESTRICTED_CONTENT = 0x00000400;

    [NativeTypeName("#define D3DPRESENTFLAG_RESTRICT_SHARED_RESOURCE_DRIVER 0x00000800")]
    public const int D3DPRESENTFLAG_RESTRICT_SHARED_RESOURCE_DRIVER = 0x00000800;
}
