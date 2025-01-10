// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/d3d9caps.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public static partial class D3DFVFCAPS
{
    [NativeTypeName("#define D3DFVFCAPS_TEXCOORDCOUNTMASK 0x0000ffffL")]
    public const int D3DFVFCAPS_TEXCOORDCOUNTMASK = 0x0000ffff;

    [NativeTypeName("#define D3DFVFCAPS_DONOTSTRIPELEMENTS 0x00080000L")]
    public const int D3DFVFCAPS_DONOTSTRIPELEMENTS = 0x00080000;

    [NativeTypeName("#define D3DFVFCAPS_PSIZE 0x00100000L")]
    public const int D3DFVFCAPS_PSIZE = 0x00100000;
}
