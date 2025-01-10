// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/d3d9caps.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public static partial class D3DCPCAPS
{
    [NativeTypeName("#define D3DCPCAPS_SOFTWARE 0x00000001")]
    public const int D3DCPCAPS_SOFTWARE = 0x00000001;

    [NativeTypeName("#define D3DCPCAPS_HARDWARE 0x00000002")]
    public const int D3DCPCAPS_HARDWARE = 0x00000002;

    [NativeTypeName("#define D3DCPCAPS_PROTECTIONALWAYSON 0x00000004")]
    public const int D3DCPCAPS_PROTECTIONALWAYSON = 0x00000004;

    [NativeTypeName("#define D3DCPCAPS_PARTIALDECRYPTION 0x00000008")]
    public const int D3DCPCAPS_PARTIALDECRYPTION = 0x00000008;

    [NativeTypeName("#define D3DCPCAPS_CONTENTKEY 0x00000010")]
    public const int D3DCPCAPS_CONTENTKEY = 0x00000010;

    [NativeTypeName("#define D3DCPCAPS_FRESHENSESSIONKEY 0x00000020")]
    public const int D3DCPCAPS_FRESHENSESSIONKEY = 0x00000020;

    [NativeTypeName("#define D3DCPCAPS_ENCRYPTEDREADBACK 0x00000040")]
    public const int D3DCPCAPS_ENCRYPTEDREADBACK = 0x00000040;

    [NativeTypeName("#define D3DCPCAPS_ENCRYPTEDREADBACKKEY 0x00000080")]
    public const int D3DCPCAPS_ENCRYPTEDREADBACKKEY = 0x00000080;

    [NativeTypeName("#define D3DCPCAPS_SEQUENTIAL_CTR_IV 0x00000100")]
    public const int D3DCPCAPS_SEQUENTIAL_CTR_IV = 0x00000100;

    [NativeTypeName("#define D3DCPCAPS_ENCRYPTSLICEDATAONLY 0x00000200")]
    public const int D3DCPCAPS_ENCRYPTSLICEDATAONLY = 0x00000200;
}
