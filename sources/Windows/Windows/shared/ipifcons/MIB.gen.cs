// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/ipifcons.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using static TerraFX.Interop.Windows.INTERNAL_IF_OPER_STATUS;

namespace TerraFX.Interop.Windows;
public static partial class MIB
{
    [NativeTypeName("#define MIB_IF_TYPE_OTHER 1")]
    public const int MIB_IF_TYPE_OTHER = 1;
    [NativeTypeName("#define MIB_IF_TYPE_ETHERNET 6")]
    public const int MIB_IF_TYPE_ETHERNET = 6;
    [NativeTypeName("#define MIB_IF_TYPE_TOKENRING 9")]
    public const int MIB_IF_TYPE_TOKENRING = 9;
    [NativeTypeName("#define MIB_IF_TYPE_FDDI 15")]
    public const int MIB_IF_TYPE_FDDI = 15;
    [NativeTypeName("#define MIB_IF_TYPE_PPP 23")]
    public const int MIB_IF_TYPE_PPP = 23;
    [NativeTypeName("#define MIB_IF_TYPE_LOOPBACK 24")]
    public const int MIB_IF_TYPE_LOOPBACK = 24;
    [NativeTypeName("#define MIB_IF_TYPE_SLIP 28")]
    public const int MIB_IF_TYPE_SLIP = 28;
    [NativeTypeName("#define MIB_IF_ADMIN_STATUS_UP 1")]
    public const int MIB_IF_ADMIN_STATUS_UP = 1;
    [NativeTypeName("#define MIB_IF_ADMIN_STATUS_DOWN 2")]
    public const int MIB_IF_ADMIN_STATUS_DOWN = 2;
    [NativeTypeName("#define MIB_IF_ADMIN_STATUS_TESTING 3")]
    public const int MIB_IF_ADMIN_STATUS_TESTING = 3;
    [NativeTypeName("#define MIB_IF_OPER_STATUS_NON_OPERATIONAL IF_OPER_STATUS_NON_OPERATIONAL")]
    public const INTERNAL_IF_OPER_STATUS MIB_IF_OPER_STATUS_NON_OPERATIONAL = IF_OPER_STATUS_NON_OPERATIONAL;
    [NativeTypeName("#define MIB_IF_OPER_STATUS_UNREACHABLE IF_OPER_STATUS_UNREACHABLE")]
    public const INTERNAL_IF_OPER_STATUS MIB_IF_OPER_STATUS_UNREACHABLE = IF_OPER_STATUS_UNREACHABLE;
    [NativeTypeName("#define MIB_IF_OPER_STATUS_DISCONNECTED IF_OPER_STATUS_DISCONNECTED")]
    public const INTERNAL_IF_OPER_STATUS MIB_IF_OPER_STATUS_DISCONNECTED = IF_OPER_STATUS_DISCONNECTED;
    [NativeTypeName("#define MIB_IF_OPER_STATUS_CONNECTING IF_OPER_STATUS_CONNECTING")]
    public const INTERNAL_IF_OPER_STATUS MIB_IF_OPER_STATUS_CONNECTING = IF_OPER_STATUS_CONNECTING;
    [NativeTypeName("#define MIB_IF_OPER_STATUS_CONNECTED IF_OPER_STATUS_CONNECTED")]
    public const INTERNAL_IF_OPER_STATUS MIB_IF_OPER_STATUS_CONNECTED = IF_OPER_STATUS_CONNECTED;
    [NativeTypeName("#define MIB_IF_OPER_STATUS_OPERATIONAL IF_OPER_STATUS_OPERATIONAL")]
    public const INTERNAL_IF_OPER_STATUS MIB_IF_OPER_STATUS_OPERATIONAL = IF_OPER_STATUS_OPERATIONAL;
}