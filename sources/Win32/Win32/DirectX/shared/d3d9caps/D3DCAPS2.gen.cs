// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/d3d9caps.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public static partial class D3DCAPS2
{
    [NativeTypeName("#define D3DCAPS2_FULLSCREENGAMMA 0x00020000L")]
    public const int D3DCAPS2_FULLSCREENGAMMA = 0x00020000;

    [NativeTypeName("#define D3DCAPS2_CANCALIBRATEGAMMA 0x00100000L")]
    public const int D3DCAPS2_CANCALIBRATEGAMMA = 0x00100000;

    [NativeTypeName("#define D3DCAPS2_RESERVED 0x02000000L")]
    public const int D3DCAPS2_RESERVED = 0x02000000;

    [NativeTypeName("#define D3DCAPS2_CANMANAGERESOURCE 0x10000000L")]
    public const int D3DCAPS2_CANMANAGERESOURCE = 0x10000000;

    [NativeTypeName("#define D3DCAPS2_DYNAMICTEXTURES 0x20000000L")]
    public const int D3DCAPS2_DYNAMICTEXTURES = 0x20000000;

    [NativeTypeName("#define D3DCAPS2_CANAUTOGENMIPMAP 0x40000000L")]
    public const int D3DCAPS2_CANAUTOGENMIPMAP = 0x40000000;

    [NativeTypeName("#define D3DCAPS2_CANSHARERESOURCE 0x80000000L")]
    public const uint D3DCAPS2_CANSHARERESOURCE = 0x80000000;
}
