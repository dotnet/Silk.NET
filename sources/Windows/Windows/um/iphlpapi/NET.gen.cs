// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/iphlpapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
public static partial class NET
{
    [NativeTypeName("#define NET_STRING_IPV4_ADDRESS 0x00000001")]
    public const int NET_STRING_IPV4_ADDRESS = 0x00000001;
    [NativeTypeName("#define NET_STRING_IPV4_SERVICE 0x00000002")]
    public const int NET_STRING_IPV4_SERVICE = 0x00000002;
    [NativeTypeName("#define NET_STRING_IPV4_NETWORK 0x00000004")]
    public const int NET_STRING_IPV4_NETWORK = 0x00000004;
    [NativeTypeName("#define NET_STRING_IPV6_ADDRESS 0x00000008")]
    public const int NET_STRING_IPV6_ADDRESS = 0x00000008;
    [NativeTypeName("#define NET_STRING_IPV6_ADDRESS_NO_SCOPE 0x00000010")]
    public const int NET_STRING_IPV6_ADDRESS_NO_SCOPE = 0x00000010;
    [NativeTypeName("#define NET_STRING_IPV6_SERVICE 0x00000020")]
    public const int NET_STRING_IPV6_SERVICE = 0x00000020;
    [NativeTypeName("#define NET_STRING_IPV6_SERVICE_NO_SCOPE 0x00000040")]
    public const int NET_STRING_IPV6_SERVICE_NO_SCOPE = 0x00000040;
    [NativeTypeName("#define NET_STRING_IPV6_NETWORK 0x00000080")]
    public const int NET_STRING_IPV6_NETWORK = 0x00000080;
    [NativeTypeName("#define NET_STRING_NAMED_ADDRESS 0x00000100")]
    public const int NET_STRING_NAMED_ADDRESS = 0x00000100;
    [NativeTypeName("#define NET_STRING_NAMED_SERVICE 0x00000200")]
    public const int NET_STRING_NAMED_SERVICE = 0x00000200;
    [NativeTypeName("#define NET_STRING_IP_ADDRESS (NET_STRING_IPV4_ADDRESS   | \\\r\n                                           NET_STRING_IPV6_ADDRESS)")]
    public const int NET_STRING_IP_ADDRESS = (0x00000001 | 0x00000008);
    [NativeTypeName("#define NET_STRING_IP_ADDRESS_NO_SCOPE (NET_STRING_IPV4_ADDRESS   | \\\r\n                                           NET_STRING_IPV6_ADDRESS_NO_SCOPE)")]
    public const int NET_STRING_IP_ADDRESS_NO_SCOPE = (0x00000001 | 0x00000010);
    [NativeTypeName("#define NET_STRING_IP_SERVICE (NET_STRING_IPV4_SERVICE   | \\\r\n                                           NET_STRING_IPV6_SERVICE)")]
    public const int NET_STRING_IP_SERVICE = (0x00000002 | 0x00000020);
    [NativeTypeName("#define NET_STRING_IP_SERVICE_NO_SCOPE (NET_STRING_IPV4_SERVICE   | \\\r\n                                           NET_STRING_IPV6_SERVICE_NO_SCOPE)")]
    public const int NET_STRING_IP_SERVICE_NO_SCOPE = (0x00000002 | 0x00000040);
    [NativeTypeName("#define NET_STRING_IP_NETWORK (NET_STRING_IPV4_NETWORK   | \\\r\n                                           NET_STRING_IPV6_NETWORK)")]
    public const int NET_STRING_IP_NETWORK = (0x00000004 | 0x00000080);
    [NativeTypeName("#define NET_STRING_ANY_ADDRESS (NET_STRING_NAMED_ADDRESS  | \\\r\n                                           NET_STRING_IP_ADDRESS)")]
    public const int NET_STRING_ANY_ADDRESS = (0x00000100 | (0x00000001 | 0x00000008));
    [NativeTypeName("#define NET_STRING_ANY_ADDRESS_NO_SCOPE (NET_STRING_NAMED_ADDRESS  | \\\r\n                                           NET_STRING_IP_ADDRESS_NO_SCOPE)")]
    public const int NET_STRING_ANY_ADDRESS_NO_SCOPE = (0x00000100 | (0x00000001 | 0x00000010));
    [NativeTypeName("#define NET_STRING_ANY_SERVICE (NET_STRING_NAMED_SERVICE  | \\\r\n                                           NET_STRING_IP_SERVICE)")]
    public const int NET_STRING_ANY_SERVICE = (0x00000200 | (0x00000002 | 0x00000020));
    [NativeTypeName("#define NET_STRING_ANY_SERVICE_NO_SCOPE (NET_STRING_NAMED_SERVICE  | \\\r\n                                           NET_STRING_IP_SERVICE_NO_SCOPE)")]
    public const int NET_STRING_ANY_SERVICE_NO_SCOPE = (0x00000200 | (0x00000002 | 0x00000040));
}