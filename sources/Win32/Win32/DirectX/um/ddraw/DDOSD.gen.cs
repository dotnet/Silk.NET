// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ddraw.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public static partial class DDOSD
{
    [NativeTypeName("#define DDOSD_GUID 0x00000001l")]
    public const int DDOSD_GUID = 0x00000001;

    [NativeTypeName("#define DDOSD_COMPRESSION_RATIO 0x00000002l")]
    public const int DDOSD_COMPRESSION_RATIO = 0x00000002;

    [NativeTypeName("#define DDOSD_SCAPS 0x00000004l")]
    public const int DDOSD_SCAPS = 0x00000004;

    [NativeTypeName("#define DDOSD_OSCAPS 0x00000008l")]
    public const int DDOSD_OSCAPS = 0x00000008;

    [NativeTypeName("#define DDOSD_ALL 0x0000000fl")]
    public const int DDOSD_ALL = 0x0000000f;
}
