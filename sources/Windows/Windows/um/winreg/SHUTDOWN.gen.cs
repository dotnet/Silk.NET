// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winreg.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

public static partial class SHUTDOWN
{
    [NativeTypeName("#define SHUTDOWN_FORCE_OTHERS 0x00000001")]
    public const int SHUTDOWN_FORCE_OTHERS = 0x00000001;

    [NativeTypeName("#define SHUTDOWN_FORCE_SELF 0x00000002")]
    public const int SHUTDOWN_FORCE_SELF = 0x00000002;

    [NativeTypeName("#define SHUTDOWN_RESTART 0x00000004")]
    public const int SHUTDOWN_RESTART = 0x00000004;

    [NativeTypeName("#define SHUTDOWN_POWEROFF 0x00000008")]
    public const int SHUTDOWN_POWEROFF = 0x00000008;

    [NativeTypeName("#define SHUTDOWN_NOREBOOT 0x00000010")]
    public const int SHUTDOWN_NOREBOOT = 0x00000010;

    [NativeTypeName("#define SHUTDOWN_GRACE_OVERRIDE 0x00000020")]
    public const int SHUTDOWN_GRACE_OVERRIDE = 0x00000020;

    [NativeTypeName("#define SHUTDOWN_INSTALL_UPDATES 0x00000040")]
    public const int SHUTDOWN_INSTALL_UPDATES = 0x00000040;

    [NativeTypeName("#define SHUTDOWN_RESTARTAPPS 0x00000080")]
    public const int SHUTDOWN_RESTARTAPPS = 0x00000080;

    [NativeTypeName("#define SHUTDOWN_SKIP_SVC_PRESHUTDOWN 0x00000100")]
    public const int SHUTDOWN_SKIP_SVC_PRESHUTDOWN = 0x00000100;

    [NativeTypeName("#define SHUTDOWN_HYBRID 0x00000200")]
    public const int SHUTDOWN_HYBRID = 0x00000200;

    [NativeTypeName("#define SHUTDOWN_RESTART_BOOTOPTIONS 0x00000400")]
    public const int SHUTDOWN_RESTART_BOOTOPTIONS = 0x00000400;

    [NativeTypeName("#define SHUTDOWN_SOFT_REBOOT 0x00000800")]
    public const int SHUTDOWN_SOFT_REBOOT = 0x00000800;

    [NativeTypeName("#define SHUTDOWN_MOBILE_UI 0x00001000")]
    public const int SHUTDOWN_MOBILE_UI = 0x00001000;

    [NativeTypeName("#define SHUTDOWN_ARSO 0x00002000")]
    public const int SHUTDOWN_ARSO = 0x00002000;

    [NativeTypeName("#define SHUTDOWN_CHECK_SAFE_FOR_SERVER 0x00004000")]
    public const int SHUTDOWN_CHECK_SAFE_FOR_SERVER = 0x00004000;

    [NativeTypeName("#define SHUTDOWN_VAIL_CONTAINER 0x00008000")]
    public const int SHUTDOWN_VAIL_CONTAINER = 0x00008000;

    [NativeTypeName("#define SHUTDOWN_SYSTEM_INITIATED 0x00010000")]
    public const int SHUTDOWN_SYSTEM_INITIATED = 0x00010000;
}
