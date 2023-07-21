// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/UserEnv.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

public static partial class GPO
{
    [NativeTypeName("#define GPO_FLAG_DISABLE 0x00000001")]
    public const int GPO_FLAG_DISABLE = 0x00000001;

    [NativeTypeName("#define GPO_FLAG_FORCE 0x00000002")]
    public const int GPO_FLAG_FORCE = 0x00000002;

    [NativeTypeName("#define GPO_LIST_FLAG_MACHINE 0x00000001")]
    public const int GPO_LIST_FLAG_MACHINE = 0x00000001;

    [NativeTypeName("#define GPO_LIST_FLAG_SITEONLY 0x00000002")]
    public const int GPO_LIST_FLAG_SITEONLY = 0x00000002;

    [NativeTypeName("#define GPO_LIST_FLAG_NO_WMIFILTERS 0x00000004")]
    public const int GPO_LIST_FLAG_NO_WMIFILTERS = 0x00000004;

    [NativeTypeName("#define GPO_LIST_FLAG_NO_SECURITYFILTERS 0x00000008")]
    public const int GPO_LIST_FLAG_NO_SECURITYFILTERS = 0x00000008;

    [NativeTypeName("#define GPO_INFO_FLAG_MACHINE 0x00000001")]
    public const int GPO_INFO_FLAG_MACHINE = 0x00000001;

    [NativeTypeName("#define GPO_INFO_FLAG_BACKGROUND 0x00000010")]
    public const int GPO_INFO_FLAG_BACKGROUND = 0x00000010;

    [NativeTypeName("#define GPO_INFO_FLAG_SLOWLINK 0x00000020")]
    public const int GPO_INFO_FLAG_SLOWLINK = 0x00000020;

    [NativeTypeName("#define GPO_INFO_FLAG_VERBOSE 0x00000040")]
    public const int GPO_INFO_FLAG_VERBOSE = 0x00000040;

    [NativeTypeName("#define GPO_INFO_FLAG_NOCHANGES 0x00000080")]
    public const int GPO_INFO_FLAG_NOCHANGES = 0x00000080;

    [NativeTypeName("#define GPO_INFO_FLAG_LINKTRANSITION 0x00000100")]
    public const int GPO_INFO_FLAG_LINKTRANSITION = 0x00000100;

    [NativeTypeName("#define GPO_INFO_FLAG_LOGRSOP_TRANSITION 0x00000200")]
    public const int GPO_INFO_FLAG_LOGRSOP_TRANSITION = 0x00000200;

    [NativeTypeName("#define GPO_INFO_FLAG_FORCED_REFRESH 0x00000400")]
    public const int GPO_INFO_FLAG_FORCED_REFRESH = 0x00000400;

    [NativeTypeName("#define GPO_INFO_FLAG_SAFEMODE_BOOT 0x00000800")]
    public const int GPO_INFO_FLAG_SAFEMODE_BOOT = 0x00000800;

    [NativeTypeName("#define GPO_INFO_FLAG_ASYNC_FOREGROUND 0x00001000")]
    public const int GPO_INFO_FLAG_ASYNC_FOREGROUND = 0x00001000;
}
