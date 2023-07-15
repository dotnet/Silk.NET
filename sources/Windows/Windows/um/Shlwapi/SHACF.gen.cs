// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/Shlwapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
public static partial class SHACF
{
    [NativeTypeName("#define SHACF_DEFAULT 0x00000000")]
    public const int SHACF_DEFAULT = 0x00000000;
    [NativeTypeName("#define SHACF_FILESYSTEM 0x00000001")]
    public const int SHACF_FILESYSTEM = 0x00000001;
    [NativeTypeName("#define SHACF_URLALL (SHACF_URLHISTORY | SHACF_URLMRU)")]
    public const int SHACF_URLALL = (0x00000002 | 0x00000004);
    [NativeTypeName("#define SHACF_URLHISTORY 0x00000002")]
    public const int SHACF_URLHISTORY = 0x00000002;
    [NativeTypeName("#define SHACF_URLMRU 0x00000004")]
    public const int SHACF_URLMRU = 0x00000004;
    [NativeTypeName("#define SHACF_USETAB 0x00000008")]
    public const int SHACF_USETAB = 0x00000008;
    [NativeTypeName("#define SHACF_FILESYS_ONLY 0x00000010")]
    public const int SHACF_FILESYS_ONLY = 0x00000010;
    [NativeTypeName("#define SHACF_FILESYS_DIRS 0x00000020")]
    public const int SHACF_FILESYS_DIRS = 0x00000020;
    [NativeTypeName("#define SHACF_VIRTUAL_NAMESPACE 0x00000040")]
    public const int SHACF_VIRTUAL_NAMESPACE = 0x00000040;
    [NativeTypeName("#define SHACF_AUTOSUGGEST_FORCE_ON 0x10000000")]
    public const int SHACF_AUTOSUGGEST_FORCE_ON = 0x10000000;
    [NativeTypeName("#define SHACF_AUTOSUGGEST_FORCE_OFF 0x20000000")]
    public const int SHACF_AUTOSUGGEST_FORCE_OFF = 0x20000000;
    [NativeTypeName("#define SHACF_AUTOAPPEND_FORCE_ON 0x40000000")]
    public const int SHACF_AUTOAPPEND_FORCE_ON = 0x40000000;
    [NativeTypeName("#define SHACF_AUTOAPPEND_FORCE_OFF 0x80000000")]
    public const uint SHACF_AUTOAPPEND_FORCE_OFF = 0x80000000;
}