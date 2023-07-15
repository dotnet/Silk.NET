// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/ws2def.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
public static partial class NI
{
    [NativeTypeName("#define NI_NOFQDN 0x01")]
    public const int NI_NOFQDN = 0x01;
    [NativeTypeName("#define NI_NUMERICHOST 0x02")]
    public const int NI_NUMERICHOST = 0x02;
    [NativeTypeName("#define NI_NAMEREQD 0x04")]
    public const int NI_NAMEREQD = 0x04;
    [NativeTypeName("#define NI_NUMERICSERV 0x08")]
    public const int NI_NUMERICSERV = 0x08;
    [NativeTypeName("#define NI_DGRAM 0x10")]
    public const int NI_DGRAM = 0x10;
    [NativeTypeName("#define NI_MAXHOST 1025")]
    public const int NI_MAXHOST = 1025;
    [NativeTypeName("#define NI_MAXSERV 32")]
    public const int NI_MAXSERV = 32;
}