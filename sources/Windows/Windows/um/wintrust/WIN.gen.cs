// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinTrust.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
public static partial class WIN
{
    [NativeTypeName("#define WIN_CERT_REVISION_1_0 (0x0100)")]
    public const int WIN_CERT_REVISION_1_0 = (0x0100);
    [NativeTypeName("#define WIN_CERT_REVISION_2_0 (0x0200)")]
    public const int WIN_CERT_REVISION_2_0 = (0x0200);
    [NativeTypeName("#define WIN_CERT_TYPE_X509 (0x0001)")]
    public const int WIN_CERT_TYPE_X509 = (0x0001);
    [NativeTypeName("#define WIN_CERT_TYPE_PKCS_SIGNED_DATA (0x0002)")]
    public const int WIN_CERT_TYPE_PKCS_SIGNED_DATA = (0x0002);
    [NativeTypeName("#define WIN_CERT_TYPE_RESERVED_1 (0x0003)")]
    public const int WIN_CERT_TYPE_RESERVED_1 = (0x0003);
    [NativeTypeName("#define WIN_CERT_TYPE_TS_STACK_SIGNED (0x0004)")]
    public const int WIN_CERT_TYPE_TS_STACK_SIGNED = (0x0004);
}