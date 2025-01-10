// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/ws2def.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static partial class SO
{
    [NativeTypeName("#define SO_DEBUG 0x0001")]
    public const int SO_DEBUG = 0x0001;

    [NativeTypeName("#define SO_ACCEPTCONN 0x0002")]
    public const int SO_ACCEPTCONN = 0x0002;

    [NativeTypeName("#define SO_REUSEADDR 0x0004")]
    public const int SO_REUSEADDR = 0x0004;

    [NativeTypeName("#define SO_KEEPALIVE 0x0008")]
    public const int SO_KEEPALIVE = 0x0008;

    [NativeTypeName("#define SO_DONTROUTE 0x0010")]
    public const int SO_DONTROUTE = 0x0010;

    [NativeTypeName("#define SO_BROADCAST 0x0020")]
    public const int SO_BROADCAST = 0x0020;

    [NativeTypeName("#define SO_USELOOPBACK 0x0040")]
    public const int SO_USELOOPBACK = 0x0040;

    [NativeTypeName("#define SO_LINGER 0x0080")]
    public const int SO_LINGER = 0x0080;

    [NativeTypeName("#define SO_OOBINLINE 0x0100")]
    public const int SO_OOBINLINE = 0x0100;

    [NativeTypeName("#define SO_DONTLINGER (int)(~SO_LINGER)")]
    public const int SO_DONTLINGER = (int)(~0x0080);

    [NativeTypeName("#define SO_EXCLUSIVEADDRUSE ((int)(~SO_REUSEADDR))")]
    public const int SO_EXCLUSIVEADDRUSE = ((int)(~0x0004));

    [NativeTypeName("#define SO_SNDBUF 0x1001")]
    public const int SO_SNDBUF = 0x1001;

    [NativeTypeName("#define SO_RCVBUF 0x1002")]
    public const int SO_RCVBUF = 0x1002;

    [NativeTypeName("#define SO_SNDLOWAT 0x1003")]
    public const int SO_SNDLOWAT = 0x1003;

    [NativeTypeName("#define SO_RCVLOWAT 0x1004")]
    public const int SO_RCVLOWAT = 0x1004;

    [NativeTypeName("#define SO_SNDTIMEO 0x1005")]
    public const int SO_SNDTIMEO = 0x1005;

    [NativeTypeName("#define SO_RCVTIMEO 0x1006")]
    public const int SO_RCVTIMEO = 0x1006;

    [NativeTypeName("#define SO_ERROR 0x1007")]
    public const int SO_ERROR = 0x1007;

    [NativeTypeName("#define SO_TYPE 0x1008")]
    public const int SO_TYPE = 0x1008;

    [NativeTypeName("#define SO_BSP_STATE 0x1009")]
    public const int SO_BSP_STATE = 0x1009;

    [NativeTypeName("#define SO_GROUP_ID 0x2001")]
    public const int SO_GROUP_ID = 0x2001;

    [NativeTypeName("#define SO_GROUP_PRIORITY 0x2002")]
    public const int SO_GROUP_PRIORITY = 0x2002;

    [NativeTypeName("#define SO_MAX_MSG_SIZE 0x2003")]
    public const int SO_MAX_MSG_SIZE = 0x2003;

    [NativeTypeName("#define SO_CONDITIONAL_ACCEPT 0x3002")]
    public const int SO_CONDITIONAL_ACCEPT = 0x3002;

    [NativeTypeName("#define SO_PAUSE_ACCEPT 0x3003")]
    public const int SO_PAUSE_ACCEPT = 0x3003;

    [NativeTypeName("#define SO_COMPARTMENT_ID 0x3004")]
    public const int SO_COMPARTMENT_ID = 0x3004;

    [NativeTypeName("#define SO_RANDOMIZE_PORT 0x3005")]
    public const int SO_RANDOMIZE_PORT = 0x3005;

    [NativeTypeName("#define SO_PORT_SCALABILITY 0x3006")]
    public const int SO_PORT_SCALABILITY = 0x3006;

    [NativeTypeName("#define SO_REUSE_UNICASTPORT 0x3007")]
    public const int SO_REUSE_UNICASTPORT = 0x3007;

    [NativeTypeName("#define SO_REUSE_MULTICASTPORT 0x3008")]
    public const int SO_REUSE_MULTICASTPORT = 0x3008;

    [NativeTypeName("#define SO_ORIGINAL_DST 0x300F")]
    public const int SO_ORIGINAL_DST = 0x300F;
}
