// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
public static partial class PM
{
    [NativeTypeName("#define PM_NOREMOVE 0x0000")]
    public const int PM_NOREMOVE = 0x0000;
    [NativeTypeName("#define PM_REMOVE 0x0001")]
    public const int PM_REMOVE = 0x0001;
    [NativeTypeName("#define PM_NOYIELD 0x0002")]
    public const int PM_NOYIELD = 0x0002;
    [NativeTypeName("#define PM_QS_INPUT (QS_INPUT << 16)")]
    public const int PM_QS_INPUT = (((0x0002 | 0x0004) | 0x0001 | 0x0400 | 0x0800 | 0x1000) << 16);
    [NativeTypeName("#define PM_QS_POSTMESSAGE ((QS_POSTMESSAGE | QS_HOTKEY | QS_TIMER) << 16)")]
    public const int PM_QS_POSTMESSAGE = ((0x0008 | 0x0080 | 0x0010) << 16);
    [NativeTypeName("#define PM_QS_PAINT (QS_PAINT << 16)")]
    public const int PM_QS_PAINT = (0x0020 << 16);
    [NativeTypeName("#define PM_QS_SENDMESSAGE (QS_SENDMESSAGE << 16)")]
    public const int PM_QS_SENDMESSAGE = (0x0040 << 16);
}