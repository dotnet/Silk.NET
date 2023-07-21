// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/Iprtrmib.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

public static partial class IF
{
    [NativeTypeName("#define IF_NUMBER 0")]
    public const int IF_NUMBER = 0;

    [NativeTypeName("#define IF_TABLE (IF_NUMBER          + 1)")]
    public const int IF_TABLE = (0 + 1);

    [NativeTypeName("#define IF_ROW (IF_TABLE           + 1)")]
    public const int IF_ROW = ((0 + 1) + 1);

    [NativeTypeName("#define IF_STATUS (MCAST_GLOBAL       + 1)")]
    public const int IF_STATUS = (((((((((((((((((((((((((0 + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1);
}
