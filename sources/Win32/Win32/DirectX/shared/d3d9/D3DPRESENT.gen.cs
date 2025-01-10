// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/d3d9.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public static partial class D3DPRESENT
{
    [NativeTypeName("#define D3DPRESENT_BACK_BUFFERS_MAX 3L")]
    public const int D3DPRESENT_BACK_BUFFERS_MAX = 3;

    [NativeTypeName("#define D3DPRESENT_BACK_BUFFERS_MAX_EX 30L")]
    public const int D3DPRESENT_BACK_BUFFERS_MAX_EX = 30;

    [NativeTypeName("#define D3DPRESENT_DONOTWAIT 0x00000001L")]
    public const int D3DPRESENT_DONOTWAIT = 0x00000001;

    [NativeTypeName("#define D3DPRESENT_LINEAR_CONTENT 0x00000002L")]
    public const int D3DPRESENT_LINEAR_CONTENT = 0x00000002;

    [NativeTypeName("#define D3DPRESENT_DONOTFLIP 0x00000004L")]
    public const int D3DPRESENT_DONOTFLIP = 0x00000004;

    [NativeTypeName("#define D3DPRESENT_FLIPRESTART 0x00000008L")]
    public const int D3DPRESENT_FLIPRESTART = 0x00000008;

    [NativeTypeName("#define D3DPRESENT_VIDEO_RESTRICT_TO_MONITOR 0x00000010L")]
    public const int D3DPRESENT_VIDEO_RESTRICT_TO_MONITOR = 0x00000010;

    [NativeTypeName("#define D3DPRESENT_UPDATEOVERLAYONLY 0x00000020L")]
    public const int D3DPRESENT_UPDATEOVERLAYONLY = 0x00000020;

    [NativeTypeName("#define D3DPRESENT_HIDEOVERLAY 0x00000040L")]
    public const int D3DPRESENT_HIDEOVERLAY = 0x00000040;

    [NativeTypeName("#define D3DPRESENT_UPDATECOLORKEY 0x00000080L")]
    public const int D3DPRESENT_UPDATECOLORKEY = 0x00000080;

    [NativeTypeName("#define D3DPRESENT_FORCEIMMEDIATE 0x00000100L")]
    public const int D3DPRESENT_FORCEIMMEDIATE = 0x00000100;
}
