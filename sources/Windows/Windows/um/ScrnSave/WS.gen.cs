// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ScrnSave.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

public static partial class WS
{
    [NativeTypeName("#define WS_GT (WS_GROUP | WS_TABSTOP)")]
    public const int WS_GT = (0x00020000 | 0x00010000);
}
