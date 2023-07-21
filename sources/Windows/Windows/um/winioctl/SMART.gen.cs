// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

public static partial class SMART
{
    [NativeTypeName("#define SMART_GET_VERSION CTL_CODE(IOCTL_DISK_BASE, 0x0020, METHOD_BUFFERED, FILE_READ_ACCESS)")]
    public const int SMART_GET_VERSION = (((0x00000007) << 16) | (((0x0001)) << 14) | ((0x0020) << 2) | (0));

    [NativeTypeName("#define SMART_SEND_DRIVE_COMMAND CTL_CODE(IOCTL_DISK_BASE, 0x0021, METHOD_BUFFERED, FILE_READ_ACCESS | FILE_WRITE_ACCESS)")]
    public const int SMART_SEND_DRIVE_COMMAND = (((0x00000007) << 16) | (((0x0001) | (0x0002)) << 14) | ((0x0021) << 2) | (0));

    [NativeTypeName("#define SMART_RCV_DRIVE_DATA CTL_CODE(IOCTL_DISK_BASE, 0x0022, METHOD_BUFFERED, FILE_READ_ACCESS | FILE_WRITE_ACCESS)")]
    public const int SMART_RCV_DRIVE_DATA = (((0x00000007) << 16) | (((0x0001) | (0x0002)) << 14) | ((0x0022) << 2) | (0));

    [NativeTypeName("#define SMART_RCV_DRIVE_DATA_EX CTL_CODE(IOCTL_DISK_BASE, 0x0023, METHOD_BUFFERED, FILE_ANY_ACCESS)")]
    public const int SMART_RCV_DRIVE_DATA_EX = (((0x00000007) << 16) | ((0) << 14) | ((0x0023) << 2) | (0));

    [NativeTypeName("#define SMART_CMD 0xB0")]
    public const int SMART_CMD = 0xB0;

    [NativeTypeName("#define SMART_CYL_LOW 0x4F")]
    public const int SMART_CYL_LOW = 0x4F;

    [NativeTypeName("#define SMART_CYL_HI 0xC2")]
    public const int SMART_CYL_HI = 0xC2;

    [NativeTypeName("#define SMART_NO_ERROR 0")]
    public const int SMART_NO_ERROR = 0;

    [NativeTypeName("#define SMART_IDE_ERROR 1")]
    public const int SMART_IDE_ERROR = 1;

    [NativeTypeName("#define SMART_INVALID_FLAG 2")]
    public const int SMART_INVALID_FLAG = 2;

    [NativeTypeName("#define SMART_INVALID_COMMAND 3")]
    public const int SMART_INVALID_COMMAND = 3;

    [NativeTypeName("#define SMART_INVALID_BUFFER 4")]
    public const int SMART_INVALID_BUFFER = 4;

    [NativeTypeName("#define SMART_INVALID_DRIVE 5")]
    public const int SMART_INVALID_DRIVE = 5;

    [NativeTypeName("#define SMART_INVALID_IOCTL 6")]
    public const int SMART_INVALID_IOCTL = 6;

    [NativeTypeName("#define SMART_ERROR_NO_MEM 7")]
    public const int SMART_ERROR_NO_MEM = 7;

    [NativeTypeName("#define SMART_INVALID_REGISTER 8")]
    public const int SMART_INVALID_REGISTER = 8;

    [NativeTypeName("#define SMART_NOT_SUPPORTED 9")]
    public const int SMART_NOT_SUPPORTED = 9;

    [NativeTypeName("#define SMART_NO_IDE_DEVICE 10")]
    public const int SMART_NO_IDE_DEVICE = 10;

    [NativeTypeName("#define SMART_OFFLINE_ROUTINE_OFFLINE 0")]
    public const int SMART_OFFLINE_ROUTINE_OFFLINE = 0;

    [NativeTypeName("#define SMART_SHORT_SELFTEST_OFFLINE 1")]
    public const int SMART_SHORT_SELFTEST_OFFLINE = 1;

    [NativeTypeName("#define SMART_EXTENDED_SELFTEST_OFFLINE 2")]
    public const int SMART_EXTENDED_SELFTEST_OFFLINE = 2;

    [NativeTypeName("#define SMART_ABORT_OFFLINE_SELFTEST 127")]
    public const int SMART_ABORT_OFFLINE_SELFTEST = 127;

    [NativeTypeName("#define SMART_SHORT_SELFTEST_CAPTIVE 129")]
    public const int SMART_SHORT_SELFTEST_CAPTIVE = 129;

    [NativeTypeName("#define SMART_EXTENDED_SELFTEST_CAPTIVE 130")]
    public const int SMART_EXTENDED_SELFTEST_CAPTIVE = 130;

    [NativeTypeName("#define SMART_LOG_SECTOR_SIZE 512")]
    public const int SMART_LOG_SECTOR_SIZE = 512;

    [NativeTypeName("#define SMART_READ_LOG 0xD5")]
    public const int SMART_READ_LOG = 0xD5;

    [NativeTypeName("#define SMART_WRITE_LOG 0xd6")]
    public const int SMART_WRITE_LOG = 0xd6;
}
