// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

public static partial class EVENT
{
    [NativeTypeName("#define EVENT_MODIFY_STATE 0x0002")]
    public const int EVENT_MODIFY_STATE = 0x0002;

    [NativeTypeName("#define EVENT_ALL_ACCESS (STANDARD_RIGHTS_REQUIRED|SYNCHRONIZE|0x3)")]
    public const int EVENT_ALL_ACCESS = ((0x000F0000) | (0x00100000) | 0x3);
}
