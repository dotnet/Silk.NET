// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static partial class IDD
{
    [NativeTypeName("#define IDD_WIZEXTN_FIRST 0x5000")]
    public const int IDD_WIZEXTN_FIRST = 0x5000;

    [NativeTypeName("#define IDD_WIZEXTN_LAST 0x5100")]
    public const int IDD_WIZEXTN_LAST = 0x5100;
}
