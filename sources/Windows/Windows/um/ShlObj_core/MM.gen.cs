// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShlObj_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

public static partial class MM
{
    [NativeTypeName("#define MM_ADDSEPARATOR 0x00000001L")]
    public const int MM_ADDSEPARATOR = 0x00000001;

    [NativeTypeName("#define MM_SUBMENUSHAVEIDS 0x00000002L")]
    public const int MM_SUBMENUSHAVEIDS = 0x00000002;

    [NativeTypeName("#define MM_DONTREMOVESEPS 0x00000004L")]
    public const int MM_DONTREMOVESEPS = 0x00000004;
}
