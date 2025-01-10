// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/ws2def.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static partial class Windows
{
    [NativeTypeName("#define SOCK_STREAM 1")]
    public const int SOCK_STREAM = 1;

    [NativeTypeName("#define SOCK_DGRAM 2")]
    public const int SOCK_DGRAM = 2;

    [NativeTypeName("#define SOCK_RAW 3")]
    public const int SOCK_RAW = 3;

    [NativeTypeName("#define SOCK_RDM 4")]
    public const int SOCK_RDM = 4;

    [NativeTypeName("#define SOCK_SEQPACKET 5")]
    public const int SOCK_SEQPACKET = 5;

    [NativeTypeName("#define SOL_SOCKET 0xffff")]
    public const int SOL_SOCKET = 0xffff;

    [NativeTypeName("#define SOL_IP (SOL_SOCKET-4)")]
    public const int SOL_IP = (0xffff - 4);

    [NativeTypeName("#define SOL_IPV6 (SOL_SOCKET-5)")]
    public const int SOL_IPV6 = (0xffff - 5);

    [NativeTypeName("#define IP6T_SO_ORIGINAL_DST SO_ORIGINAL_DST")]
    public const int IP6T_SO_ORIGINAL_DST = 0x300F;

    [NativeTypeName("#define WSK_SO_BASE 0x4000")]
    public const int WSK_SO_BASE = 0x4000;

    [NativeTypeName("#define _SS_MAXSIZE 128")]
    public const int _SS_MAXSIZE = 128;

    [NativeTypeName("#define _SS_ALIGNSIZE (sizeof(__int64))")]
    public const uint _SS_ALIGNSIZE = (8);

    [NativeTypeName("#define _SS_PAD1SIZE (_SS_ALIGNSIZE - sizeof(USHORT))")]
    public const uint _SS_PAD1SIZE = ((8) - 2);

    [NativeTypeName(
        "#define _SS_PAD2SIZE (_SS_MAXSIZE - (sizeof(USHORT) + _SS_PAD1SIZE + _SS_ALIGNSIZE))"
    )]
    public const uint _SS_PAD2SIZE = (128 - (2 + ((8) - 2) + (8)));

    [NativeTypeName("#define IOC_UNIX 0x00000000")]
    public const int IOC_UNIX = 0x00000000;

    [NativeTypeName("#define IOC_WS2 0x08000000")]
    public const int IOC_WS2 = 0x08000000;

    [NativeTypeName("#define IOC_PROTOCOL 0x10000000")]
    public const int IOC_PROTOCOL = 0x10000000;

    [NativeTypeName("#define IOC_VENDOR 0x18000000")]
    public const int IOC_VENDOR = 0x18000000;

    [NativeTypeName("#define IOC_WSK (IOC_WS2|0x07000000)")]
    public const int IOC_WSK = (0x08000000 | 0x07000000);

    [NativeTypeName("#define IPPROTO_IP 0")]
    public const int IPPROTO_IP = 0;

    [NativeTypeName("#define INADDR_ANY (ULONG)0x00000000")]
    public const uint INADDR_ANY = (uint)(0x00000000);

    [NativeTypeName("#define INADDR_LOOPBACK 0x7f000001")]
    public const int INADDR_LOOPBACK = 0x7f000001;

    [NativeTypeName("#define INADDR_BROADCAST (ULONG)0xffffffff")]
    public const uint INADDR_BROADCAST = (uint)(0xffffffff);

    [NativeTypeName("#define INADDR_NONE 0xffffffff")]
    public const uint INADDR_NONE = 0xffffffff;

    [NativeTypeName("#define IOCPARM_MASK 0x7f")]
    public const int IOCPARM_MASK = 0x7f;

    [NativeTypeName("#define IOC_VOID 0x20000000")]
    public const int IOC_VOID = 0x20000000;

    [NativeTypeName("#define IOC_OUT 0x40000000")]
    public const int IOC_OUT = 0x40000000;

    [NativeTypeName("#define IOC_IN 0x80000000")]
    public const uint IOC_IN = 0x80000000;

    [NativeTypeName("#define IOC_INOUT (IOC_IN|IOC_OUT)")]
    public const uint IOC_INOUT = (0x80000000 | 0x40000000);

    [NativeTypeName("#define MSG_TRUNC 0x0100")]
    public const int MSG_TRUNC = 0x0100;

    [NativeTypeName("#define MSG_CTRUNC 0x0200")]
    public const int MSG_CTRUNC = 0x0200;

    [NativeTypeName("#define MSG_BCAST 0x0400")]
    public const int MSG_BCAST = 0x0400;

    [NativeTypeName("#define MSG_MCAST 0x0800")]
    public const int MSG_MCAST = 0x0800;

    [NativeTypeName("#define MSG_ERRQUEUE 0x1000")]
    public const int MSG_ERRQUEUE = 0x1000;

    [NativeTypeName("#define ADDRINFOEX_VERSION_2 2")]
    public const int ADDRINFOEX_VERSION_2 = 2;

    [NativeTypeName("#define ADDRINFOEX_VERSION_3 3")]
    public const int ADDRINFOEX_VERSION_3 = 3;

    [NativeTypeName("#define ADDRINFOEX_VERSION_4 4")]
    public const int ADDRINFOEX_VERSION_4 = 4;

    [NativeTypeName("#define ADDRINFOEX_VERSION_5 5")]
    public const int ADDRINFOEX_VERSION_5 = 5;

    [NativeTypeName("#define ADDRINFOEX_VERSION_6 6")]
    public const int ADDRINFOEX_VERSION_6 = 6;

    [NativeTypeName("#define ADDRINFOEX_VERSION_7 7")]
    public const int ADDRINFOEX_VERSION_7 = 7;
}
