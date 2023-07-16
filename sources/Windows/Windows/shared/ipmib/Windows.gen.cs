// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/ipmib.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;
public static partial class Windows
{
    [NativeTypeName("#define ICMP6_INFOMSG_MASK 0x80")]
    public const int ICMP6_INFOMSG_MASK = 0x80;
    [NativeTypeName("#define SIZEOF_BASIC_MIB_MFE (ULONG)(FIELD_OFFSET(MIB_IPMCAST_MFE, rgmioOutInfo[0]))")]
    public static uint SIZEOF_BASIC_MIB_MFE => unchecked((uint)(((int)(Marshal.OffsetOf<MIB_IPMCAST_MFE>("rgmioOutInfo")))));

    [NativeTypeName("#define SIZEOF_BASIC_MIB_MFE_STATS (ULONG)(FIELD_OFFSET(MIB_IPMCAST_MFE_STATS, rgmiosOutStats[0]))")]
    public static uint SIZEOF_BASIC_MIB_MFE_STATS => unchecked((uint)(((int)(Marshal.OffsetOf<MIB_IPMCAST_MFE_STATS>("rgmiosOutStats")))));

    [NativeTypeName("#define SIZEOF_BASIC_MIB_MFE_STATS_EX (ULONG)(FIELD_OFFSET(MIB_IPMCAST_MFE_STATS_EX, rgmiosOutStats[0]))")]
    public static uint SIZEOF_BASIC_MIB_MFE_STATS_EX => unchecked((uint)(((int)(Marshal.OffsetOf<MIB_IPMCAST_MFE_STATS_EX_XP>("rgmiosOutStats")))));
}