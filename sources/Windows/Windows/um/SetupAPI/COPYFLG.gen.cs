// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/SetupAPI.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
public static partial class COPYFLG
{
    [NativeTypeName("#define COPYFLG_WARN_IF_SKIP 0x00000001")]
    public const int COPYFLG_WARN_IF_SKIP = 0x00000001;
    [NativeTypeName("#define COPYFLG_NOSKIP 0x00000002")]
    public const int COPYFLG_NOSKIP = 0x00000002;
    [NativeTypeName("#define COPYFLG_NOVERSIONCHECK 0x00000004")]
    public const int COPYFLG_NOVERSIONCHECK = 0x00000004;
    [NativeTypeName("#define COPYFLG_FORCE_FILE_IN_USE 0x00000008")]
    public const int COPYFLG_FORCE_FILE_IN_USE = 0x00000008;
    [NativeTypeName("#define COPYFLG_NO_OVERWRITE 0x00000010")]
    public const int COPYFLG_NO_OVERWRITE = 0x00000010;
    [NativeTypeName("#define COPYFLG_NO_VERSION_DIALOG 0x00000020")]
    public const int COPYFLG_NO_VERSION_DIALOG = 0x00000020;
    [NativeTypeName("#define COPYFLG_OVERWRITE_OLDER_ONLY 0x00000040")]
    public const int COPYFLG_OVERWRITE_OLDER_ONLY = 0x00000040;
    [NativeTypeName("#define COPYFLG_PROTECTED_WINDOWS_DRIVER_FILE 0x00000100")]
    public const int COPYFLG_PROTECTED_WINDOWS_DRIVER_FILE = 0x00000100;
    [NativeTypeName("#define COPYFLG_REPLACEONLY 0x00000400")]
    public const int COPYFLG_REPLACEONLY = 0x00000400;
    [NativeTypeName("#define COPYFLG_NODECOMP 0x00000800")]
    public const int COPYFLG_NODECOMP = 0x00000800;
    [NativeTypeName("#define COPYFLG_REPLACE_BOOT_FILE 0x00001000")]
    public const int COPYFLG_REPLACE_BOOT_FILE = 0x00001000;
    [NativeTypeName("#define COPYFLG_NOPRUNE 0x00002000")]
    public const int COPYFLG_NOPRUNE = 0x00002000;
    [NativeTypeName("#define COPYFLG_IN_USE_TRY_RENAME 0x00004000")]
    public const int COPYFLG_IN_USE_TRY_RENAME = 0x00004000;
}