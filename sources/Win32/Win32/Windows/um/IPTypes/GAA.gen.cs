// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/IPTypes.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static partial class GAA
{
    [NativeTypeName("#define GAA_FLAG_SKIP_UNICAST 0x0001")]
    public const int GAA_FLAG_SKIP_UNICAST = 0x0001;

    [NativeTypeName("#define GAA_FLAG_SKIP_ANYCAST 0x0002")]
    public const int GAA_FLAG_SKIP_ANYCAST = 0x0002;

    [NativeTypeName("#define GAA_FLAG_SKIP_MULTICAST 0x0004")]
    public const int GAA_FLAG_SKIP_MULTICAST = 0x0004;

    [NativeTypeName("#define GAA_FLAG_SKIP_DNS_SERVER 0x0008")]
    public const int GAA_FLAG_SKIP_DNS_SERVER = 0x0008;

    [NativeTypeName("#define GAA_FLAG_INCLUDE_PREFIX 0x0010")]
    public const int GAA_FLAG_INCLUDE_PREFIX = 0x0010;

    [NativeTypeName("#define GAA_FLAG_SKIP_FRIENDLY_NAME 0x0020")]
    public const int GAA_FLAG_SKIP_FRIENDLY_NAME = 0x0020;

    [NativeTypeName("#define GAA_FLAG_INCLUDE_WINS_INFO 0x0040")]
    public const int GAA_FLAG_INCLUDE_WINS_INFO = 0x0040;

    [NativeTypeName("#define GAA_FLAG_INCLUDE_GATEWAYS 0x0080")]
    public const int GAA_FLAG_INCLUDE_GATEWAYS = 0x0080;

    [NativeTypeName("#define GAA_FLAG_INCLUDE_ALL_INTERFACES 0x0100")]
    public const int GAA_FLAG_INCLUDE_ALL_INTERFACES = 0x0100;

    [NativeTypeName("#define GAA_FLAG_INCLUDE_ALL_COMPARTMENTS 0x0200")]
    public const int GAA_FLAG_INCLUDE_ALL_COMPARTMENTS = 0x0200;

    [NativeTypeName("#define GAA_FLAG_INCLUDE_TUNNEL_BINDINGORDER 0x0400")]
    public const int GAA_FLAG_INCLUDE_TUNNEL_BINDINGORDER = 0x0400;

    [NativeTypeName("#define GAA_FLAG_SKIP_DNS_INFO 0x0800")]
    public const int GAA_FLAG_SKIP_DNS_INFO = 0x0800;
}
