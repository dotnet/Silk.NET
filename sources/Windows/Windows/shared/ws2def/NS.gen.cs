// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/ws2def.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

public static partial class NS
{
    [NativeTypeName("#define NS_ALL (0)")]
    public const int NS_ALL = (0);

    [NativeTypeName("#define NS_SAP (1)")]
    public const int NS_SAP = (1);

    [NativeTypeName("#define NS_NDS (2)")]
    public const int NS_NDS = (2);

    [NativeTypeName("#define NS_PEER_BROWSE (3)")]
    public const int NS_PEER_BROWSE = (3);

    [NativeTypeName("#define NS_SLP (5)")]
    public const int NS_SLP = (5);

    [NativeTypeName("#define NS_DHCP (6)")]
    public const int NS_DHCP = (6);

    [NativeTypeName("#define NS_TCPIP_LOCAL (10)")]
    public const int NS_TCPIP_LOCAL = (10);

    [NativeTypeName("#define NS_TCPIP_HOSTS (11)")]
    public const int NS_TCPIP_HOSTS = (11);

    [NativeTypeName("#define NS_DNS (12)")]
    public const int NS_DNS = (12);

    [NativeTypeName("#define NS_NETBT (13)")]
    public const int NS_NETBT = (13);

    [NativeTypeName("#define NS_WINS (14)")]
    public const int NS_WINS = (14);

    [NativeTypeName("#define NS_NLA (15)")]
    public const int NS_NLA = (15);

    [NativeTypeName("#define NS_BTH (16)")]
    public const int NS_BTH = (16);

    [NativeTypeName("#define NS_NBP (20)")]
    public const int NS_NBP = (20);

    [NativeTypeName("#define NS_MS (30)")]
    public const int NS_MS = (30);

    [NativeTypeName("#define NS_STDA (31)")]
    public const int NS_STDA = (31);

    [NativeTypeName("#define NS_NTDS (32)")]
    public const int NS_NTDS = (32);

    [NativeTypeName("#define NS_EMAIL (37)")]
    public const int NS_EMAIL = (37);

    [NativeTypeName("#define NS_PNRPNAME (38)")]
    public const int NS_PNRPNAME = (38);

    [NativeTypeName("#define NS_PNRPCLOUD (39)")]
    public const int NS_PNRPCLOUD = (39);

    [NativeTypeName("#define NS_X500 (40)")]
    public const int NS_X500 = (40);

    [NativeTypeName("#define NS_NIS (41)")]
    public const int NS_NIS = (41);

    [NativeTypeName("#define NS_NISPLUS (42)")]
    public const int NS_NISPLUS = (42);

    [NativeTypeName("#define NS_WRQ (50)")]
    public const int NS_WRQ = (50);

    [NativeTypeName("#define NS_NETDES (60)")]
    public const int NS_NETDES = (60);
}
