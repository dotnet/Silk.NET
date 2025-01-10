// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/d3d9caps.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public static partial class D3DPS20CAPS
{
    [NativeTypeName("#define D3DPS20CAPS_ARBITRARYSWIZZLE (1<<0)")]
    public const int D3DPS20CAPS_ARBITRARYSWIZZLE = (1 << 0);

    [NativeTypeName("#define D3DPS20CAPS_GRADIENTINSTRUCTIONS (1<<1)")]
    public const int D3DPS20CAPS_GRADIENTINSTRUCTIONS = (1 << 1);

    [NativeTypeName("#define D3DPS20CAPS_PREDICATION (1<<2)")]
    public const int D3DPS20CAPS_PREDICATION = (1 << 2);

    [NativeTypeName("#define D3DPS20CAPS_NODEPENDENTREADLIMIT (1<<3)")]
    public const int D3DPS20CAPS_NODEPENDENTREADLIMIT = (1 << 3);

    [NativeTypeName("#define D3DPS20CAPS_NOTEXINSTRUCTIONLIMIT (1<<4)")]
    public const int D3DPS20CAPS_NOTEXINSTRUCTIONLIMIT = (1 << 4);
}
