// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ntsecapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static partial class LSA_TLN
{
    [NativeTypeName("#define LSA_TLN_DISABLED_NEW ( 0x00000001L )")]
    public const int LSA_TLN_DISABLED_NEW = (0x00000001);

    [NativeTypeName("#define LSA_TLN_DISABLED_ADMIN ( 0x00000002L )")]
    public const int LSA_TLN_DISABLED_ADMIN = (0x00000002);

    [NativeTypeName("#define LSA_TLN_DISABLED_CONFLICT ( 0x00000004L )")]
    public const int LSA_TLN_DISABLED_CONFLICT = (0x00000004);
}
