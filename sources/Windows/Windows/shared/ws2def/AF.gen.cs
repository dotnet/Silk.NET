// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/ws2def.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
public static partial class AF
{
    [NativeTypeName("#define AF_UNSPEC 0")]
    public const int AF_UNSPEC = 0;
    [NativeTypeName("#define AF_UNIX 1")]
    public const int AF_UNIX = 1;
    [NativeTypeName("#define AF_INET 2")]
    public const int AF_INET = 2;
    [NativeTypeName("#define AF_IMPLINK 3")]
    public const int AF_IMPLINK = 3;
    [NativeTypeName("#define AF_PUP 4")]
    public const int AF_PUP = 4;
    [NativeTypeName("#define AF_CHAOS 5")]
    public const int AF_CHAOS = 5;
    [NativeTypeName("#define AF_NS 6")]
    public const int AF_NS = 6;
    [NativeTypeName("#define AF_IPX AF_NS")]
    public const int AF_IPX = 6;
    [NativeTypeName("#define AF_ISO 7")]
    public const int AF_ISO = 7;
    [NativeTypeName("#define AF_OSI AF_ISO")]
    public const int AF_OSI = 7;
    [NativeTypeName("#define AF_ECMA 8")]
    public const int AF_ECMA = 8;
    [NativeTypeName("#define AF_DATAKIT 9")]
    public const int AF_DATAKIT = 9;
    [NativeTypeName("#define AF_CCITT 10")]
    public const int AF_CCITT = 10;
    [NativeTypeName("#define AF_SNA 11")]
    public const int AF_SNA = 11;
    [NativeTypeName("#define AF_DECnet 12")]
    public const int AF_DECnet = 12;
    [NativeTypeName("#define AF_DLI 13")]
    public const int AF_DLI = 13;
    [NativeTypeName("#define AF_LAT 14")]
    public const int AF_LAT = 14;
    [NativeTypeName("#define AF_HYLINK 15")]
    public const int AF_HYLINK = 15;
    [NativeTypeName("#define AF_APPLETALK 16")]
    public const int AF_APPLETALK = 16;
    [NativeTypeName("#define AF_NETBIOS 17")]
    public const int AF_NETBIOS = 17;
    [NativeTypeName("#define AF_VOICEVIEW 18")]
    public const int AF_VOICEVIEW = 18;
    [NativeTypeName("#define AF_FIREFOX 19")]
    public const int AF_FIREFOX = 19;
    [NativeTypeName("#define AF_UNKNOWN1 20")]
    public const int AF_UNKNOWN1 = 20;
    [NativeTypeName("#define AF_BAN 21")]
    public const int AF_BAN = 21;
    [NativeTypeName("#define AF_ATM 22")]
    public const int AF_ATM = 22;
    [NativeTypeName("#define AF_INET6 23")]
    public const int AF_INET6 = 23;
    [NativeTypeName("#define AF_CLUSTER 24")]
    public const int AF_CLUSTER = 24;
    [NativeTypeName("#define AF_12844 25")]
    public const int AF_12844 = 25;
    [NativeTypeName("#define AF_IRDA 26")]
    public const int AF_IRDA = 26;
    [NativeTypeName("#define AF_NETDES 28")]
    public const int AF_NETDES = 28;
    [NativeTypeName("#define AF_TCNPROCESS 29")]
    public const int AF_TCNPROCESS = 29;
    [NativeTypeName("#define AF_TCNMESSAGE 30")]
    public const int AF_TCNMESSAGE = 30;
    [NativeTypeName("#define AF_ICLFXBM 31")]
    public const int AF_ICLFXBM = 31;
    [NativeTypeName("#define AF_BTH 32")]
    public const int AF_BTH = 32;
    [NativeTypeName("#define AF_LINK 33")]
    public const int AF_LINK = 33;
    [NativeTypeName("#define AF_HYPERV 34")]
    public const int AF_HYPERV = 34;
    [NativeTypeName("#define AF_MAX 35")]
    public const int AF_MAX = 35;
}