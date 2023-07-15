// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/CommDlg.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
public static partial class FR
{
    [NativeTypeName("#define FR_DOWN 0x00000001")]
    public const int FR_DOWN = 0x00000001;
    [NativeTypeName("#define FR_WHOLEWORD 0x00000002")]
    public const int FR_WHOLEWORD = 0x00000002;
    [NativeTypeName("#define FR_MATCHCASE 0x00000004")]
    public const int FR_MATCHCASE = 0x00000004;
    [NativeTypeName("#define FR_FINDNEXT 0x00000008")]
    public const int FR_FINDNEXT = 0x00000008;
    [NativeTypeName("#define FR_REPLACE 0x00000010")]
    public const int FR_REPLACE = 0x00000010;
    [NativeTypeName("#define FR_REPLACEALL 0x00000020")]
    public const int FR_REPLACEALL = 0x00000020;
    [NativeTypeName("#define FR_DIALOGTERM 0x00000040")]
    public const int FR_DIALOGTERM = 0x00000040;
    [NativeTypeName("#define FR_SHOWHELP 0x00000080")]
    public const int FR_SHOWHELP = 0x00000080;
    [NativeTypeName("#define FR_ENABLEHOOK 0x00000100")]
    public const int FR_ENABLEHOOK = 0x00000100;
    [NativeTypeName("#define FR_ENABLETEMPLATE 0x00000200")]
    public const int FR_ENABLETEMPLATE = 0x00000200;
    [NativeTypeName("#define FR_NOUPDOWN 0x00000400")]
    public const int FR_NOUPDOWN = 0x00000400;
    [NativeTypeName("#define FR_NOMATCHCASE 0x00000800")]
    public const int FR_NOMATCHCASE = 0x00000800;
    [NativeTypeName("#define FR_NOWHOLEWORD 0x00001000")]
    public const int FR_NOWHOLEWORD = 0x00001000;
    [NativeTypeName("#define FR_ENABLETEMPLATEHANDLE 0x00002000")]
    public const int FR_ENABLETEMPLATEHANDLE = 0x00002000;
    [NativeTypeName("#define FR_HIDEUPDOWN 0x00004000")]
    public const int FR_HIDEUPDOWN = 0x00004000;
    [NativeTypeName("#define FR_HIDEMATCHCASE 0x00008000")]
    public const int FR_HIDEMATCHCASE = 0x00008000;
    [NativeTypeName("#define FR_HIDEWHOLEWORD 0x00010000")]
    public const int FR_HIDEWHOLEWORD = 0x00010000;
    [NativeTypeName("#define FR_RAW 0x00020000")]
    public const int FR_RAW = 0x00020000;
    [NativeTypeName("#define FR_SHOWWRAPAROUND 0x00040000")]
    public const int FR_SHOWWRAPAROUND = 0x00040000;
    [NativeTypeName("#define FR_NOWRAPAROUND 0x00080000")]
    public const int FR_NOWRAPAROUND = 0x00080000;
    [NativeTypeName("#define FR_WRAPAROUND 0x00100000")]
    public const int FR_WRAPAROUND = 0x00100000;
    [NativeTypeName("#define FR_MATCHDIAC 0x20000000")]
    public const int FR_MATCHDIAC = 0x20000000;
    [NativeTypeName("#define FR_MATCHKASHIDA 0x40000000")]
    public const int FR_MATCHKASHIDA = 0x40000000;
    [NativeTypeName("#define FR_MATCHALEFHAMZA 0x80000000")]
    public const uint FR_MATCHALEFHAMZA = 0x80000000;
}