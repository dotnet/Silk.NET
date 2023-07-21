// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

public static unsafe partial class TD
{
    [NativeTypeName("#define TD_WARNING_ICON MAKEINTRESOURCEW(-1)")]
    public static ushort* TD_WARNING_ICON => unchecked((ushort*)((nuint)((ushort)(-1))));

    [NativeTypeName("#define TD_ERROR_ICON MAKEINTRESOURCEW(-2)")]
    public static ushort* TD_ERROR_ICON => unchecked((ushort*)((nuint)((ushort)(-2))));

    [NativeTypeName("#define TD_INFORMATION_ICON MAKEINTRESOURCEW(-3)")]
    public static ushort* TD_INFORMATION_ICON => unchecked((ushort*)((nuint)((ushort)(-3))));

    [NativeTypeName("#define TD_SHIELD_ICON MAKEINTRESOURCEW(-4)")]
    public static ushort* TD_SHIELD_ICON => unchecked((ushort*)((nuint)((ushort)(-4))));
}
