// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

public static partial class MAX
{
    [NativeTypeName("#define MAX_UCSCHAR (0x0010FFFF)")]
    public const int MAX_UCSCHAR = (0x0010FFFF);

    [NativeTypeName("#define MAX_ACL_REVISION ACL_REVISION4")]
    public const int MAX_ACL_REVISION = (4);

    [NativeTypeName("#define MAX_HW_COUNTERS 16")]
    public const int MAX_HW_COUNTERS = 16;
}
