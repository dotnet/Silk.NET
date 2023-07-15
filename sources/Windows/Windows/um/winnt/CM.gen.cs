// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
public static partial class CM
{
    [NativeTypeName("#define CM_SERVICE_NETWORK_BOOT_LOAD 0x00000001")]
    public const int CM_SERVICE_NETWORK_BOOT_LOAD = 0x00000001;
    [NativeTypeName("#define CM_SERVICE_VIRTUAL_DISK_BOOT_LOAD 0x00000002")]
    public const int CM_SERVICE_VIRTUAL_DISK_BOOT_LOAD = 0x00000002;
    [NativeTypeName("#define CM_SERVICE_USB_DISK_BOOT_LOAD 0x00000004")]
    public const int CM_SERVICE_USB_DISK_BOOT_LOAD = 0x00000004;
    [NativeTypeName("#define CM_SERVICE_SD_DISK_BOOT_LOAD 0x00000008")]
    public const int CM_SERVICE_SD_DISK_BOOT_LOAD = 0x00000008;
    [NativeTypeName("#define CM_SERVICE_USB3_DISK_BOOT_LOAD 0x00000010")]
    public const int CM_SERVICE_USB3_DISK_BOOT_LOAD = 0x00000010;
    [NativeTypeName("#define CM_SERVICE_MEASURED_BOOT_LOAD 0x00000020")]
    public const int CM_SERVICE_MEASURED_BOOT_LOAD = 0x00000020;
    [NativeTypeName("#define CM_SERVICE_VERIFIER_BOOT_LOAD 0x00000040")]
    public const int CM_SERVICE_VERIFIER_BOOT_LOAD = 0x00000040;
    [NativeTypeName("#define CM_SERVICE_WINPE_BOOT_LOAD 0x00000080")]
    public const int CM_SERVICE_WINPE_BOOT_LOAD = 0x00000080;
    [NativeTypeName("#define CM_SERVICE_RAM_DISK_BOOT_LOAD 0x00000100")]
    public const int CM_SERVICE_RAM_DISK_BOOT_LOAD = 0x00000100;
    [NativeTypeName("#define CM_SERVICE_VALID_PROMOTION_MASK (CM_SERVICE_NETWORK_BOOT_LOAD |       \\\r\n                                         CM_SERVICE_VIRTUAL_DISK_BOOT_LOAD |  \\\r\n                                         CM_SERVICE_USB_DISK_BOOT_LOAD |      \\\r\n                                         CM_SERVICE_SD_DISK_BOOT_LOAD |       \\\r\n                                         CM_SERVICE_USB3_DISK_BOOT_LOAD |     \\\r\n                                         CM_SERVICE_MEASURED_BOOT_LOAD |      \\\r\n                                         CM_SERVICE_VERIFIER_BOOT_LOAD |      \\\r\n                                         CM_SERVICE_WINPE_BOOT_LOAD |         \\\r\n                                         CM_SERVICE_RAM_DISK_BOOT_LOAD)")]
    public const int CM_SERVICE_VALID_PROMOTION_MASK = (0x00000001 | 0x00000002 | 0x00000004 | 0x00000008 | 0x00000010 | 0x00000020 | 0x00000040 | 0x00000080 | 0x00000100);
}