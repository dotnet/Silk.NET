// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
public static partial class SERVICE
{
    [NativeTypeName("#define SERVICE_KERNEL_DRIVER 0x00000001")]
    public const int SERVICE_KERNEL_DRIVER = 0x00000001;
    [NativeTypeName("#define SERVICE_FILE_SYSTEM_DRIVER 0x00000002")]
    public const int SERVICE_FILE_SYSTEM_DRIVER = 0x00000002;
    [NativeTypeName("#define SERVICE_ADAPTER 0x00000004")]
    public const int SERVICE_ADAPTER = 0x00000004;
    [NativeTypeName("#define SERVICE_RECOGNIZER_DRIVER 0x00000008")]
    public const int SERVICE_RECOGNIZER_DRIVER = 0x00000008;
    [NativeTypeName("#define SERVICE_DRIVER (SERVICE_KERNEL_DRIVER | \\\r\n                                        SERVICE_FILE_SYSTEM_DRIVER | \\\r\n                                        SERVICE_RECOGNIZER_DRIVER)")]
    public const int SERVICE_DRIVER = (0x00000001 | 0x00000002 | 0x00000008);
    [NativeTypeName("#define SERVICE_WIN32_OWN_PROCESS 0x00000010")]
    public const int SERVICE_WIN32_OWN_PROCESS = 0x00000010;
    [NativeTypeName("#define SERVICE_WIN32_SHARE_PROCESS 0x00000020")]
    public const int SERVICE_WIN32_SHARE_PROCESS = 0x00000020;
    [NativeTypeName("#define SERVICE_WIN32 (SERVICE_WIN32_OWN_PROCESS | \\\r\n                                        SERVICE_WIN32_SHARE_PROCESS)")]
    public const int SERVICE_WIN32 = (0x00000010 | 0x00000020);
    [NativeTypeName("#define SERVICE_USER_SERVICE 0x00000040")]
    public const int SERVICE_USER_SERVICE = 0x00000040;
    [NativeTypeName("#define SERVICE_USERSERVICE_INSTANCE 0x00000080")]
    public const int SERVICE_USERSERVICE_INSTANCE = 0x00000080;
    [NativeTypeName("#define SERVICE_USER_SHARE_PROCESS (SERVICE_USER_SERVICE | \\\r\n                                        SERVICE_WIN32_SHARE_PROCESS)")]
    public const int SERVICE_USER_SHARE_PROCESS = (0x00000040 | 0x00000020);
    [NativeTypeName("#define SERVICE_USER_OWN_PROCESS (SERVICE_USER_SERVICE | \\\r\n                                        SERVICE_WIN32_OWN_PROCESS)")]
    public const int SERVICE_USER_OWN_PROCESS = (0x00000040 | 0x00000010);
    [NativeTypeName("#define SERVICE_INTERACTIVE_PROCESS 0x00000100")]
    public const int SERVICE_INTERACTIVE_PROCESS = 0x00000100;
    [NativeTypeName("#define SERVICE_PKG_SERVICE 0x00000200")]
    public const int SERVICE_PKG_SERVICE = 0x00000200;
    [NativeTypeName("#define SERVICE_TYPE_ALL (SERVICE_WIN32  | \\\r\n                                        SERVICE_ADAPTER | \\\r\n                                        SERVICE_DRIVER  | \\\r\n                                        SERVICE_INTERACTIVE_PROCESS | \\\r\n                                        SERVICE_USER_SERVICE | \\\r\n                                        SERVICE_USERSERVICE_INSTANCE | \\\r\n                                        SERVICE_PKG_SERVICE)")]
    public const int SERVICE_TYPE_ALL = ((0x00000010 | 0x00000020) | 0x00000004 | (0x00000001 | 0x00000002 | 0x00000008) | 0x00000100 | 0x00000040 | 0x00000080 | 0x00000200);
    [NativeTypeName("#define SERVICE_BOOT_START 0x00000000")]
    public const int SERVICE_BOOT_START = 0x00000000;
    [NativeTypeName("#define SERVICE_SYSTEM_START 0x00000001")]
    public const int SERVICE_SYSTEM_START = 0x00000001;
    [NativeTypeName("#define SERVICE_AUTO_START 0x00000002")]
    public const int SERVICE_AUTO_START = 0x00000002;
    [NativeTypeName("#define SERVICE_DEMAND_START 0x00000003")]
    public const int SERVICE_DEMAND_START = 0x00000003;
    [NativeTypeName("#define SERVICE_DISABLED 0x00000004")]
    public const int SERVICE_DISABLED = 0x00000004;
    [NativeTypeName("#define SERVICE_ERROR_IGNORE 0x00000000")]
    public const int SERVICE_ERROR_IGNORE = 0x00000000;
    [NativeTypeName("#define SERVICE_ERROR_NORMAL 0x00000001")]
    public const int SERVICE_ERROR_NORMAL = 0x00000001;
    [NativeTypeName("#define SERVICE_ERROR_SEVERE 0x00000002")]
    public const int SERVICE_ERROR_SEVERE = 0x00000002;
    [NativeTypeName("#define SERVICE_ERROR_CRITICAL 0x00000003")]
    public const int SERVICE_ERROR_CRITICAL = 0x00000003;
}