// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

public static partial class ENABLE
{
    [NativeTypeName("#define ENABLE_DISABLE_AUTOSAVE 0xD2")]
    public const int ENABLE_DISABLE_AUTOSAVE = 0xD2;

    [NativeTypeName("#define ENABLE_SMART 0xD8")]
    public const int ENABLE_SMART = 0xD8;

    [NativeTypeName("#define ENABLE_DISABLE_AUTO_OFFLINE 0xDB")]
    public const int ENABLE_DISABLE_AUTO_OFFLINE = 0xDB;
}
