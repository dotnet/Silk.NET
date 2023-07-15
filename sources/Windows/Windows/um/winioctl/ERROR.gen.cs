// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
public static partial class ERROR
{
    [NativeTypeName("#define ERROR_HISTORY_DIRECTORY_ENTRY_DEFAULT_COUNT 8")]
    public const int ERROR_HISTORY_DIRECTORY_ENTRY_DEFAULT_COUNT = 8;
    [NativeTypeName("#define ERROR_LABEL_UNREADABLE 0x00000001")]
    public const int ERROR_LABEL_UNREADABLE = 0x00000001;
    [NativeTypeName("#define ERROR_LABEL_QUESTIONABLE 0x00000002")]
    public const int ERROR_LABEL_QUESTIONABLE = 0x00000002;
    [NativeTypeName("#define ERROR_SLOT_NOT_PRESENT 0x00000004")]
    public const int ERROR_SLOT_NOT_PRESENT = 0x00000004;
    [NativeTypeName("#define ERROR_DRIVE_NOT_INSTALLED 0x00000008")]
    public const int ERROR_DRIVE_NOT_INSTALLED = 0x00000008;
    [NativeTypeName("#define ERROR_TRAY_MALFUNCTION 0x00000010")]
    public const int ERROR_TRAY_MALFUNCTION = 0x00000010;
    [NativeTypeName("#define ERROR_INIT_STATUS_NEEDED 0x00000011")]
    public const int ERROR_INIT_STATUS_NEEDED = 0x00000011;
    [NativeTypeName("#define ERROR_UNHANDLED_ERROR 0xFFFFFFFF")]
    public const uint ERROR_UNHANDLED_ERROR = 0xFFFFFFFF;
}