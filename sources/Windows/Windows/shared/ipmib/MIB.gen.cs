// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/ipmib.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
public static partial class MIB
{
    [NativeTypeName("#define MIB_IPADDR_PRIMARY 0x0001")]
    public const int MIB_IPADDR_PRIMARY = 0x0001;
    [NativeTypeName("#define MIB_IPADDR_DYNAMIC 0x0004")]
    public const int MIB_IPADDR_DYNAMIC = 0x0004;
    [NativeTypeName("#define MIB_IPADDR_DISCONNECTED 0x0008")]
    public const int MIB_IPADDR_DISCONNECTED = 0x0008;
    [NativeTypeName("#define MIB_IPADDR_DELETED 0x0040")]
    public const int MIB_IPADDR_DELETED = 0x0040;
    [NativeTypeName("#define MIB_IPADDR_TRANSIENT 0x0080")]
    public const int MIB_IPADDR_TRANSIENT = 0x0080;
    [NativeTypeName("#define MIB_IPADDR_DNS_ELIGIBLE 0X0100")]
    public const int MIB_IPADDR_DNS_ELIGIBLE = 0X0100;
    [NativeTypeName("#define MIB_IPROUTE_TYPE_OTHER 1")]
    public const int MIB_IPROUTE_TYPE_OTHER = 1;
    [NativeTypeName("#define MIB_IPROUTE_TYPE_INVALID 2")]
    public const int MIB_IPROUTE_TYPE_INVALID = 2;
    [NativeTypeName("#define MIB_IPROUTE_TYPE_DIRECT 3")]
    public const int MIB_IPROUTE_TYPE_DIRECT = 3;
    [NativeTypeName("#define MIB_IPROUTE_TYPE_INDIRECT 4")]
    public const int MIB_IPROUTE_TYPE_INDIRECT = 4;
    [NativeTypeName("#define MIB_IPROUTE_METRIC_UNUSED (DWORD)-1")]
    public const uint MIB_IPROUTE_METRIC_UNUSED = unchecked((uint)(-1));
    [NativeTypeName("#define MIB_USE_CURRENT_TTL ((DWORD)-1)")]
    public const uint MIB_USE_CURRENT_TTL = unchecked((uint)(-1));
    [NativeTypeName("#define MIB_USE_CURRENT_FORWARDING ((DWORD)-1)")]
    public const uint MIB_USE_CURRENT_FORWARDING = unchecked((uint)(-1));
}