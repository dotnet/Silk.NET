// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/Iprtrmib.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

public static partial class IP
{
    [NativeTypeName("#define IP_STATS (IF_ROW             + 1)")]
    public const int IP_STATS = (((0 + 1) + 1) + 1);

    [NativeTypeName("#define IP_ADDRTABLE (IP_STATS           + 1)")]
    public const int IP_ADDRTABLE = ((((0 + 1) + 1) + 1) + 1);

    [NativeTypeName("#define IP_ADDRROW (IP_ADDRTABLE       + 1)")]
    public const int IP_ADDRROW = (((((0 + 1) + 1) + 1) + 1) + 1);

    [NativeTypeName("#define IP_FORWARDNUMBER (IP_ADDRROW         + 1)")]
    public const int IP_FORWARDNUMBER = ((((((0 + 1) + 1) + 1) + 1) + 1) + 1);

    [NativeTypeName("#define IP_FORWARDTABLE (IP_FORWARDNUMBER   + 1)")]
    public const int IP_FORWARDTABLE = (((((((0 + 1) + 1) + 1) + 1) + 1) + 1) + 1);

    [NativeTypeName("#define IP_FORWARDROW (IP_FORWARDTABLE    + 1)")]
    public const int IP_FORWARDROW = ((((((((0 + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1);

    [NativeTypeName("#define IP_NETTABLE (IP_FORWARDROW      + 1)")]
    public const int IP_NETTABLE = (((((((((0 + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1);

    [NativeTypeName("#define IP_NETROW (IP_NETTABLE        + 1)")]
    public const int IP_NETROW = ((((((((((0 + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1);
}
