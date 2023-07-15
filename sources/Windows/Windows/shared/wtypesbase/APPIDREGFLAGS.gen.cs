// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/wtypesbase.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
public static partial class APPIDREGFLAGS
{
    [NativeTypeName("#define APPIDREGFLAGS_ACTIVATE_IUSERVER_INDESKTOP 0x1")]
    public const int APPIDREGFLAGS_ACTIVATE_IUSERVER_INDESKTOP = 0x1;
    [NativeTypeName("#define APPIDREGFLAGS_SECURE_SERVER_PROCESS_SD_AND_BIND 0x2")]
    public const int APPIDREGFLAGS_SECURE_SERVER_PROCESS_SD_AND_BIND = 0x2;
    [NativeTypeName("#define APPIDREGFLAGS_ISSUE_ACTIVATION_RPC_AT_IDENTIFY 0x4")]
    public const int APPIDREGFLAGS_ISSUE_ACTIVATION_RPC_AT_IDENTIFY = 0x4;
    [NativeTypeName("#define APPIDREGFLAGS_IUSERVER_UNMODIFIED_LOGON_TOKEN 0x8")]
    public const int APPIDREGFLAGS_IUSERVER_UNMODIFIED_LOGON_TOKEN = 0x8;
    [NativeTypeName("#define APPIDREGFLAGS_IUSERVER_SELF_SID_IN_LAUNCH_PERMISSION 0x10")]
    public const int APPIDREGFLAGS_IUSERVER_SELF_SID_IN_LAUNCH_PERMISSION = 0x10;
    [NativeTypeName("#define APPIDREGFLAGS_IUSERVER_ACTIVATE_IN_CLIENT_SESSION_ONLY 0x20")]
    public const int APPIDREGFLAGS_IUSERVER_ACTIVATE_IN_CLIENT_SESSION_ONLY = 0x20;
    [NativeTypeName("#define APPIDREGFLAGS_RESERVED1 0x40")]
    public const int APPIDREGFLAGS_RESERVED1 = 0x40;
    [NativeTypeName("#define APPIDREGFLAGS_RESERVED2 0x80")]
    public const int APPIDREGFLAGS_RESERVED2 = 0x80;
    [NativeTypeName("#define APPIDREGFLAGS_RESERVED3 0x100")]
    public const int APPIDREGFLAGS_RESERVED3 = 0x100;
    [NativeTypeName("#define APPIDREGFLAGS_RESERVED4 0x200")]
    public const int APPIDREGFLAGS_RESERVED4 = 0x200;
    [NativeTypeName("#define APPIDREGFLAGS_RESERVED5 0x400")]
    public const int APPIDREGFLAGS_RESERVED5 = 0x400;
    [NativeTypeName("#define APPIDREGFLAGS_AAA_NO_IMPLICIT_ACTIVATE_AS_IU 0x800")]
    public const int APPIDREGFLAGS_AAA_NO_IMPLICIT_ACTIVATE_AS_IU = 0x800;
    [NativeTypeName("#define APPIDREGFLAGS_RESERVED7 0x1000")]
    public const int APPIDREGFLAGS_RESERVED7 = 0x1000;
    [NativeTypeName("#define APPIDREGFLAGS_RESERVED8 0x2000")]
    public const int APPIDREGFLAGS_RESERVED8 = 0x2000;
    [NativeTypeName("#define APPIDREGFLAGS_RESERVED9 0x4000")]
    public const int APPIDREGFLAGS_RESERVED9 = 0x4000;
}