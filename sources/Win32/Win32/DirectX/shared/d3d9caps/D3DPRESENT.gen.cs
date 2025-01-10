// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/d3d9caps.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public static partial class D3DPRESENT
{
    [NativeTypeName("#define D3DPRESENT_INTERVAL_DEFAULT 0x00000000L")]
    public const int D3DPRESENT_INTERVAL_DEFAULT = 0x00000000;

    [NativeTypeName("#define D3DPRESENT_INTERVAL_ONE 0x00000001L")]
    public const int D3DPRESENT_INTERVAL_ONE = 0x00000001;

    [NativeTypeName("#define D3DPRESENT_INTERVAL_TWO 0x00000002L")]
    public const int D3DPRESENT_INTERVAL_TWO = 0x00000002;

    [NativeTypeName("#define D3DPRESENT_INTERVAL_THREE 0x00000004L")]
    public const int D3DPRESENT_INTERVAL_THREE = 0x00000004;

    [NativeTypeName("#define D3DPRESENT_INTERVAL_FOUR 0x00000008L")]
    public const int D3DPRESENT_INTERVAL_FOUR = 0x00000008;

    [NativeTypeName("#define D3DPRESENT_INTERVAL_IMMEDIATE 0x80000000L")]
    public const uint D3DPRESENT_INTERVAL_IMMEDIATE = 0x80000000;
}
