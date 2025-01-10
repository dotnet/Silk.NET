// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ddraw.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public static partial class DDSVCAPS
{
    [NativeTypeName("#define DDSVCAPS_RESERVED1 0x00000001l")]
    public const int DDSVCAPS_RESERVED1 = 0x00000001;

    [NativeTypeName("#define DDSVCAPS_RESERVED2 0x00000002l")]
    public const int DDSVCAPS_RESERVED2 = 0x00000002;

    [NativeTypeName("#define DDSVCAPS_RESERVED3 0x00000004l")]
    public const int DDSVCAPS_RESERVED3 = 0x00000004;

    [NativeTypeName("#define DDSVCAPS_RESERVED4 0x00000008l")]
    public const int DDSVCAPS_RESERVED4 = 0x00000008;

    [NativeTypeName("#define DDSVCAPS_STEREOSEQUENTIAL 0x00000010L")]
    public const int DDSVCAPS_STEREOSEQUENTIAL = 0x00000010;
}
