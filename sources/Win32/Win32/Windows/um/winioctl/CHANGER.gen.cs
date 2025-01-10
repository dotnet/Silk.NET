// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static partial class CHANGER
{
    [NativeTypeName("#define CHANGER_BAR_CODE_SCANNER_INSTALLED 0x00000001")]
    public const int CHANGER_BAR_CODE_SCANNER_INSTALLED = 0x00000001;

    [NativeTypeName("#define CHANGER_INIT_ELEM_STAT_WITH_RANGE 0x00000002")]
    public const int CHANGER_INIT_ELEM_STAT_WITH_RANGE = 0x00000002;

    [NativeTypeName("#define CHANGER_CLOSE_IEPORT 0x00000004")]
    public const int CHANGER_CLOSE_IEPORT = 0x00000004;

    [NativeTypeName("#define CHANGER_OPEN_IEPORT 0x00000008")]
    public const int CHANGER_OPEN_IEPORT = 0x00000008;

    [NativeTypeName("#define CHANGER_STATUS_NON_VOLATILE 0x00000010")]
    public const int CHANGER_STATUS_NON_VOLATILE = 0x00000010;

    [NativeTypeName("#define CHANGER_EXCHANGE_MEDIA 0x00000020")]
    public const int CHANGER_EXCHANGE_MEDIA = 0x00000020;

    [NativeTypeName("#define CHANGER_CLEANER_SLOT 0x00000040")]
    public const int CHANGER_CLEANER_SLOT = 0x00000040;

    [NativeTypeName("#define CHANGER_LOCK_UNLOCK 0x00000080")]
    public const int CHANGER_LOCK_UNLOCK = 0x00000080;

    [NativeTypeName("#define CHANGER_CARTRIDGE_MAGAZINE 0x00000100")]
    public const int CHANGER_CARTRIDGE_MAGAZINE = 0x00000100;

    [NativeTypeName("#define CHANGER_MEDIUM_FLIP 0x00000200")]
    public const int CHANGER_MEDIUM_FLIP = 0x00000200;

    [NativeTypeName("#define CHANGER_POSITION_TO_ELEMENT 0x00000400")]
    public const int CHANGER_POSITION_TO_ELEMENT = 0x00000400;

    [NativeTypeName("#define CHANGER_REPORT_IEPORT_STATE 0x00000800")]
    public const int CHANGER_REPORT_IEPORT_STATE = 0x00000800;

    [NativeTypeName("#define CHANGER_STORAGE_DRIVE 0x00001000")]
    public const int CHANGER_STORAGE_DRIVE = 0x00001000;

    [NativeTypeName("#define CHANGER_STORAGE_IEPORT 0x00002000")]
    public const int CHANGER_STORAGE_IEPORT = 0x00002000;

    [NativeTypeName("#define CHANGER_STORAGE_SLOT 0x00004000")]
    public const int CHANGER_STORAGE_SLOT = 0x00004000;

    [NativeTypeName("#define CHANGER_STORAGE_TRANSPORT 0x00008000")]
    public const int CHANGER_STORAGE_TRANSPORT = 0x00008000;

    [NativeTypeName("#define CHANGER_DRIVE_CLEANING_REQUIRED 0x00010000")]
    public const int CHANGER_DRIVE_CLEANING_REQUIRED = 0x00010000;

    [NativeTypeName("#define CHANGER_PREDISMOUNT_EJECT_REQUIRED 0x00020000")]
    public const int CHANGER_PREDISMOUNT_EJECT_REQUIRED = 0x00020000;

    [NativeTypeName("#define CHANGER_CLEANER_ACCESS_NOT_VALID 0x00040000")]
    public const int CHANGER_CLEANER_ACCESS_NOT_VALID = 0x00040000;

    [NativeTypeName("#define CHANGER_PREMOUNT_EJECT_REQUIRED 0x00080000")]
    public const int CHANGER_PREMOUNT_EJECT_REQUIRED = 0x00080000;

    [NativeTypeName("#define CHANGER_VOLUME_IDENTIFICATION 0x00100000")]
    public const int CHANGER_VOLUME_IDENTIFICATION = 0x00100000;

    [NativeTypeName("#define CHANGER_VOLUME_SEARCH 0x00200000")]
    public const int CHANGER_VOLUME_SEARCH = 0x00200000;

    [NativeTypeName("#define CHANGER_VOLUME_ASSERT 0x00400000")]
    public const int CHANGER_VOLUME_ASSERT = 0x00400000;

    [NativeTypeName("#define CHANGER_VOLUME_REPLACE 0x00800000")]
    public const int CHANGER_VOLUME_REPLACE = 0x00800000;

    [NativeTypeName("#define CHANGER_VOLUME_UNDEFINE 0x01000000")]
    public const int CHANGER_VOLUME_UNDEFINE = 0x01000000;

    [NativeTypeName("#define CHANGER_SERIAL_NUMBER_VALID 0x04000000")]
    public const int CHANGER_SERIAL_NUMBER_VALID = 0x04000000;

    [NativeTypeName("#define CHANGER_DEVICE_REINITIALIZE_CAPABLE 0x08000000")]
    public const int CHANGER_DEVICE_REINITIALIZE_CAPABLE = 0x08000000;

    [NativeTypeName("#define CHANGER_KEYPAD_ENABLE_DISABLE 0x10000000")]
    public const int CHANGER_KEYPAD_ENABLE_DISABLE = 0x10000000;

    [NativeTypeName("#define CHANGER_DRIVE_EMPTY_ON_DOOR_ACCESS 0x20000000")]
    public const int CHANGER_DRIVE_EMPTY_ON_DOOR_ACCESS = 0x20000000;

    [NativeTypeName("#define CHANGER_RESERVED_BIT 0x80000000")]
    public const uint CHANGER_RESERVED_BIT = 0x80000000;

    [NativeTypeName("#define CHANGER_PREDISMOUNT_ALIGN_TO_SLOT 0x80000001")]
    public const uint CHANGER_PREDISMOUNT_ALIGN_TO_SLOT = 0x80000001;

    [NativeTypeName("#define CHANGER_PREDISMOUNT_ALIGN_TO_DRIVE 0x80000002")]
    public const uint CHANGER_PREDISMOUNT_ALIGN_TO_DRIVE = 0x80000002;

    [NativeTypeName("#define CHANGER_CLEANER_AUTODISMOUNT 0x80000004")]
    public const uint CHANGER_CLEANER_AUTODISMOUNT = 0x80000004;

    [NativeTypeName("#define CHANGER_TRUE_EXCHANGE_CAPABLE 0x80000008")]
    public const uint CHANGER_TRUE_EXCHANGE_CAPABLE = 0x80000008;

    [NativeTypeName("#define CHANGER_SLOTS_USE_TRAYS 0x80000010")]
    public const uint CHANGER_SLOTS_USE_TRAYS = 0x80000010;

    [NativeTypeName("#define CHANGER_RTN_MEDIA_TO_ORIGINAL_ADDR 0x80000020")]
    public const uint CHANGER_RTN_MEDIA_TO_ORIGINAL_ADDR = 0x80000020;

    [NativeTypeName("#define CHANGER_CLEANER_OPS_NOT_SUPPORTED 0x80000040")]
    public const uint CHANGER_CLEANER_OPS_NOT_SUPPORTED = 0x80000040;

    [NativeTypeName("#define CHANGER_IEPORT_USER_CONTROL_OPEN 0x80000080")]
    public const uint CHANGER_IEPORT_USER_CONTROL_OPEN = 0x80000080;

    [NativeTypeName("#define CHANGER_IEPORT_USER_CONTROL_CLOSE 0x80000100")]
    public const uint CHANGER_IEPORT_USER_CONTROL_CLOSE = 0x80000100;

    [NativeTypeName("#define CHANGER_MOVE_EXTENDS_IEPORT 0x80000200")]
    public const uint CHANGER_MOVE_EXTENDS_IEPORT = 0x80000200;

    [NativeTypeName("#define CHANGER_MOVE_RETRACTS_IEPORT 0x80000400")]
    public const uint CHANGER_MOVE_RETRACTS_IEPORT = 0x80000400;

    [NativeTypeName("#define CHANGER_TO_TRANSPORT 0x01")]
    public const int CHANGER_TO_TRANSPORT = 0x01;

    [NativeTypeName("#define CHANGER_TO_SLOT 0x02")]
    public const int CHANGER_TO_SLOT = 0x02;

    [NativeTypeName("#define CHANGER_TO_IEPORT 0x04")]
    public const int CHANGER_TO_IEPORT = 0x04;

    [NativeTypeName("#define CHANGER_TO_DRIVE 0x08")]
    public const int CHANGER_TO_DRIVE = 0x08;
}
