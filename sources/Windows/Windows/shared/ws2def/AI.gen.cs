// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/ws2def.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
public static partial class AI
{
    [NativeTypeName("#define AI_PASSIVE 0x00000001")]
    public const int AI_PASSIVE = 0x00000001;
    [NativeTypeName("#define AI_CANONNAME 0x00000002")]
    public const int AI_CANONNAME = 0x00000002;
    [NativeTypeName("#define AI_NUMERICHOST 0x00000004")]
    public const int AI_NUMERICHOST = 0x00000004;
    [NativeTypeName("#define AI_NUMERICSERV 0x00000008")]
    public const int AI_NUMERICSERV = 0x00000008;
    [NativeTypeName("#define AI_DNS_ONLY 0x00000010")]
    public const int AI_DNS_ONLY = 0x00000010;
    [NativeTypeName("#define AI_FORCE_CLEAR_TEXT 0x00000020")]
    public const int AI_FORCE_CLEAR_TEXT = 0x00000020;
    [NativeTypeName("#define AI_BYPASS_DNS_CACHE 0x00000040")]
    public const int AI_BYPASS_DNS_CACHE = 0x00000040;
    [NativeTypeName("#define AI_RETURN_TTL 0x00000080")]
    public const int AI_RETURN_TTL = 0x00000080;
    [NativeTypeName("#define AI_ALL 0x00000100")]
    public const int AI_ALL = 0x00000100;
    [NativeTypeName("#define AI_ADDRCONFIG 0x00000400")]
    public const int AI_ADDRCONFIG = 0x00000400;
    [NativeTypeName("#define AI_V4MAPPED 0x00000800")]
    public const int AI_V4MAPPED = 0x00000800;
    [NativeTypeName("#define AI_NON_AUTHORITATIVE 0x00004000")]
    public const int AI_NON_AUTHORITATIVE = 0x00004000;
    [NativeTypeName("#define AI_SECURE 0x00008000")]
    public const int AI_SECURE = 0x00008000;
    [NativeTypeName("#define AI_RETURN_PREFERRED_NAMES 0x00010000")]
    public const int AI_RETURN_PREFERRED_NAMES = 0x00010000;
    [NativeTypeName("#define AI_FQDN 0x00020000")]
    public const int AI_FQDN = 0x00020000;
    [NativeTypeName("#define AI_FILESERVER 0x00040000")]
    public const int AI_FILESERVER = 0x00040000;
    [NativeTypeName("#define AI_DISABLE_IDN_ENCODING 0x00080000")]
    public const int AI_DISABLE_IDN_ENCODING = 0x00080000;
    [NativeTypeName("#define AI_SECURE_WITH_FALLBACK 0x00100000")]
    public const int AI_SECURE_WITH_FALLBACK = 0x00100000;
    [NativeTypeName("#define AI_EXCLUSIVE_CUSTOM_SERVERS 0x00200000")]
    public const int AI_EXCLUSIVE_CUSTOM_SERVERS = 0x00200000;
    [NativeTypeName("#define AI_RETURN_RESPONSE_FLAGS 0x10000000")]
    public const int AI_RETURN_RESPONSE_FLAGS = 0x10000000;
    [NativeTypeName("#define AI_REQUIRE_SECURE 0x20000000")]
    public const int AI_REQUIRE_SECURE = 0x20000000;
    [NativeTypeName("#define AI_RESOLUTION_HANDLE 0x40000000")]
    public const int AI_RESOLUTION_HANDLE = 0x40000000;
    [NativeTypeName("#define AI_EXTENDED 0x80000000")]
    public const uint AI_EXTENDED = 0x80000000;
    [NativeTypeName("#define AI_DNS_SERVER_TYPE_UDP 0x1")]
    public const int AI_DNS_SERVER_TYPE_UDP = 0x1;
    [NativeTypeName("#define AI_DNS_SERVER_TYPE_DOH 0x2")]
    public const int AI_DNS_SERVER_TYPE_DOH = 0x2;
    [NativeTypeName("#define AI_DNS_SERVER_UDP_FALLBACK 0x1")]
    public const int AI_DNS_SERVER_UDP_FALLBACK = 0x1;
    [NativeTypeName("#define AI_DNS_RESPONSE_SECURE 0x1")]
    public const int AI_DNS_RESPONSE_SECURE = 0x1;
    [NativeTypeName("#define AI_DNS_RESPONSE_HOSTFILE 0x2")]
    public const int AI_DNS_RESPONSE_HOSTFILE = 0x2;
}