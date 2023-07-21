// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

public static partial class ENUM
{
    [NativeTypeName("#define ENUM_CURRENT_SETTINGS ((DWORD)-1)")]
    public const uint ENUM_CURRENT_SETTINGS = unchecked((uint)(-1));

    [NativeTypeName("#define ENUM_REGISTRY_SETTINGS ((DWORD)-2)")]
    public const uint ENUM_REGISTRY_SETTINGS = unchecked((uint)(-2));
}
