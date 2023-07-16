// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
public static partial class PARTITION
{
    [NativeTypeName("#define PARTITION_ENTRY_UNUSED 0x00")]
    public const int PARTITION_ENTRY_UNUSED = 0x00;
    [NativeTypeName("#define PARTITION_FAT_12 0x01")]
    public const int PARTITION_FAT_12 = 0x01;
    [NativeTypeName("#define PARTITION_XENIX_1 0x02")]
    public const int PARTITION_XENIX_1 = 0x02;
    [NativeTypeName("#define PARTITION_XENIX_2 0x03")]
    public const int PARTITION_XENIX_2 = 0x03;
    [NativeTypeName("#define PARTITION_FAT_16 0x04")]
    public const int PARTITION_FAT_16 = 0x04;
    [NativeTypeName("#define PARTITION_EXTENDED 0x05")]
    public const int PARTITION_EXTENDED = 0x05;
    [NativeTypeName("#define PARTITION_HUGE 0x06")]
    public const int PARTITION_HUGE = 0x06;
    [NativeTypeName("#define PARTITION_IFS 0x07")]
    public const int PARTITION_IFS = 0x07;
    [NativeTypeName("#define PARTITION_OS2BOOTMGR 0x0A")]
    public const int PARTITION_OS2BOOTMGR = 0x0A;
    [NativeTypeName("#define PARTITION_FAT32 0x0B")]
    public const int PARTITION_FAT32 = 0x0B;
    [NativeTypeName("#define PARTITION_FAT32_XINT13 0x0C")]
    public const int PARTITION_FAT32_XINT13 = 0x0C;
    [NativeTypeName("#define PARTITION_XINT13 0x0E")]
    public const int PARTITION_XINT13 = 0x0E;
    [NativeTypeName("#define PARTITION_XINT13_EXTENDED 0x0F")]
    public const int PARTITION_XINT13_EXTENDED = 0x0F;
    [NativeTypeName("#define PARTITION_MSFT_RECOVERY 0x27")]
    public const int PARTITION_MSFT_RECOVERY = 0x27;
    [NativeTypeName("#define PARTITION_MAIN_OS 0x28")]
    public const int PARTITION_MAIN_OS = 0x28;
    [NativeTypeName("#define PARTITION_PRE_INSTALLED 0x2a")]
    public const int PARTITION_PRE_INSTALLED = 0x2a;
    [NativeTypeName("#define PARTITION_BSP 0x2b")]
    public const int PARTITION_BSP = 0x2b;
    [NativeTypeName("#define PARTITION_DPP 0x2c")]
    public const int PARTITION_DPP = 0x2c;
    [NativeTypeName("#define PARTITION_WINDOWS_SYSTEM 0x2d")]
    public const int PARTITION_WINDOWS_SYSTEM = 0x2d;
    [NativeTypeName("#define PARTITION_PREP 0x41")]
    public const int PARTITION_PREP = 0x41;
    [NativeTypeName("#define PARTITION_LDM 0x42")]
    public const int PARTITION_LDM = 0x42;
    [NativeTypeName("#define PARTITION_DM 0x54")]
    public const int PARTITION_DM = 0x54;
    [NativeTypeName("#define PARTITION_EZDRIVE 0x55")]
    public const int PARTITION_EZDRIVE = 0x55;
    [NativeTypeName("#define PARTITION_UNIX 0x63")]
    public const int PARTITION_UNIX = 0x63;
    [NativeTypeName("#define PARTITION_SPACES_DATA 0xD7")]
    public const int PARTITION_SPACES_DATA = 0xD7;
    [NativeTypeName("#define PARTITION_SPACES 0xE7")]
    public const int PARTITION_SPACES = 0xE7;
    [NativeTypeName("#define PARTITION_GPT 0xEE")]
    public const int PARTITION_GPT = 0xEE;
    [NativeTypeName("#define PARTITION_SYSTEM 0xEF")]
    public const int PARTITION_SYSTEM = 0xEF;
    [NativeTypeName("#define PARTITION_NTFT 0x80")]
    public const int PARTITION_NTFT = 0x80;
}