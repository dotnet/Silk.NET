// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/prsht.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

public static partial class ID
{
    [NativeTypeName("#define ID_PSRESTARTWINDOWS 0x2")]
    public const int ID_PSRESTARTWINDOWS = 0x2;

    [NativeTypeName("#define ID_PSREBOOTSYSTEM (ID_PSRESTARTWINDOWS | 0x1)")]
    public const int ID_PSREBOOTSYSTEM = (0x2 | 0x1);
}
