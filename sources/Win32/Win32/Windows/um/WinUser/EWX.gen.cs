// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static partial class EWX
{
    [NativeTypeName("#define EWX_LOGOFF 0x00000000")]
    public const int EWX_LOGOFF = 0x00000000;

    [NativeTypeName("#define EWX_SHUTDOWN 0x00000001")]
    public const int EWX_SHUTDOWN = 0x00000001;

    [NativeTypeName("#define EWX_REBOOT 0x00000002")]
    public const int EWX_REBOOT = 0x00000002;

    [NativeTypeName("#define EWX_FORCE 0x00000004")]
    public const int EWX_FORCE = 0x00000004;

    [NativeTypeName("#define EWX_POWEROFF 0x00000008")]
    public const int EWX_POWEROFF = 0x00000008;

    [NativeTypeName("#define EWX_FORCEIFHUNG 0x00000010")]
    public const int EWX_FORCEIFHUNG = 0x00000010;

    [NativeTypeName("#define EWX_QUICKRESOLVE 0x00000020")]
    public const int EWX_QUICKRESOLVE = 0x00000020;

    [NativeTypeName("#define EWX_RESTARTAPPS 0x00000040")]
    public const int EWX_RESTARTAPPS = 0x00000040;

    [NativeTypeName("#define EWX_HYBRID_SHUTDOWN 0x00400000")]
    public const int EWX_HYBRID_SHUTDOWN = 0x00400000;

    [NativeTypeName("#define EWX_BOOTOPTIONS 0x01000000")]
    public const int EWX_BOOTOPTIONS = 0x01000000;

    [NativeTypeName("#define EWX_ARSO 0x04000000")]
    public const int EWX_ARSO = 0x04000000;

    [NativeTypeName("#define EWX_CHECK_SAFE_FOR_SERVER 0x08000000")]
    public const int EWX_CHECK_SAFE_FOR_SERVER = 0x08000000;

    [NativeTypeName("#define EWX_SYSTEM_INITIATED 0x10000000")]
    public const int EWX_SYSTEM_INITIATED = 0x10000000;
}
