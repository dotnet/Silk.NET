// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/ws2ipdef.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
public static partial class SIO
{
    [NativeTypeName("#define SIO_GET_INTERFACE_LIST _IOR('t', 127, ULONG)")]
    public const int SIO_GET_INTERFACE_LIST = (0x40000000 | (((int)(4) & 0x7f) << 16) | (('t') << 8) | (127));
    [NativeTypeName("#define SIO_GET_INTERFACE_LIST_EX _IOR('t', 126, ULONG)")]
    public const int SIO_GET_INTERFACE_LIST_EX = (0x40000000 | (((int)(4) & 0x7f) << 16) | (('t') << 8) | (126));
    [NativeTypeName("#define SIO_SET_MULTICAST_FILTER _IOW('t', 125, ULONG)")]
    public const uint SIO_SET_MULTICAST_FILTER = unchecked(0x80000000 | (((int)(4) & 0x7f) << 16) | (('t') << 8) | (125));
    [NativeTypeName("#define SIO_GET_MULTICAST_FILTER _IOW('t', 124 | IOC_IN, ULONG)")]
    public const uint SIO_GET_MULTICAST_FILTER = unchecked(0x80000000 | (((int)(4) & 0x7f) << 16) | (('t') << 8) | (124 | 0x80000000));
    [NativeTypeName("#define SIO_IDEAL_SEND_BACKLOG_QUERY _IOR('t', 123, ULONG)")]
    public const int SIO_IDEAL_SEND_BACKLOG_QUERY = (0x40000000 | (((int)(4) & 0x7f) << 16) | (('t') << 8) | (123));
    [NativeTypeName("#define SIO_IDEAL_SEND_BACKLOG_CHANGE _IO('t', 122)")]
    public const int SIO_IDEAL_SEND_BACKLOG_CHANGE = (0x20000000 | (('t') << 8) | (122));
}