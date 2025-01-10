// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static partial class DISPLAY
{
    [NativeTypeName("#define DISPLAY_DEVICE_ATTACHED_TO_DESKTOP 0x00000001")]
    public const int DISPLAY_DEVICE_ATTACHED_TO_DESKTOP = 0x00000001;

    [NativeTypeName("#define DISPLAY_DEVICE_MULTI_DRIVER 0x00000002")]
    public const int DISPLAY_DEVICE_MULTI_DRIVER = 0x00000002;

    [NativeTypeName("#define DISPLAY_DEVICE_PRIMARY_DEVICE 0x00000004")]
    public const int DISPLAY_DEVICE_PRIMARY_DEVICE = 0x00000004;

    [NativeTypeName("#define DISPLAY_DEVICE_MIRRORING_DRIVER 0x00000008")]
    public const int DISPLAY_DEVICE_MIRRORING_DRIVER = 0x00000008;

    [NativeTypeName("#define DISPLAY_DEVICE_VGA_COMPATIBLE 0x00000010")]
    public const int DISPLAY_DEVICE_VGA_COMPATIBLE = 0x00000010;

    [NativeTypeName("#define DISPLAY_DEVICE_REMOVABLE 0x00000020")]
    public const int DISPLAY_DEVICE_REMOVABLE = 0x00000020;

    [NativeTypeName("#define DISPLAY_DEVICE_ACC_DRIVER 0x00000040")]
    public const int DISPLAY_DEVICE_ACC_DRIVER = 0x00000040;

    [NativeTypeName("#define DISPLAY_DEVICE_MODESPRUNED 0x08000000")]
    public const int DISPLAY_DEVICE_MODESPRUNED = 0x08000000;

    [NativeTypeName("#define DISPLAY_DEVICE_RDPUDD 0x01000000")]
    public const int DISPLAY_DEVICE_RDPUDD = 0x01000000;

    [NativeTypeName("#define DISPLAY_DEVICE_REMOTE 0x04000000")]
    public const int DISPLAY_DEVICE_REMOTE = 0x04000000;

    [NativeTypeName("#define DISPLAY_DEVICE_DISCONNECT 0x02000000")]
    public const int DISPLAY_DEVICE_DISCONNECT = 0x02000000;

    [NativeTypeName("#define DISPLAY_DEVICE_TS_COMPATIBLE 0x00200000")]
    public const int DISPLAY_DEVICE_TS_COMPATIBLE = 0x00200000;

    [NativeTypeName("#define DISPLAY_DEVICE_UNSAFE_MODES_ON 0x00080000")]
    public const int DISPLAY_DEVICE_UNSAFE_MODES_ON = 0x00080000;

    [NativeTypeName("#define DISPLAY_DEVICE_ACTIVE 0x00000001")]
    public const int DISPLAY_DEVICE_ACTIVE = 0x00000001;

    [NativeTypeName("#define DISPLAY_DEVICE_ATTACHED 0x00000002")]
    public const int DISPLAY_DEVICE_ATTACHED = 0x00000002;
}
