// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShlObj_core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static partial class BIF
{
    [NativeTypeName("#define BIF_RETURNONLYFSDIRS 0x00000001")]
    public const int BIF_RETURNONLYFSDIRS = 0x00000001;

    [NativeTypeName("#define BIF_DONTGOBELOWDOMAIN 0x00000002")]
    public const int BIF_DONTGOBELOWDOMAIN = 0x00000002;

    [NativeTypeName("#define BIF_STATUSTEXT 0x00000004")]
    public const int BIF_STATUSTEXT = 0x00000004;

    [NativeTypeName("#define BIF_RETURNFSANCESTORS 0x00000008")]
    public const int BIF_RETURNFSANCESTORS = 0x00000008;

    [NativeTypeName("#define BIF_EDITBOX 0x00000010")]
    public const int BIF_EDITBOX = 0x00000010;

    [NativeTypeName("#define BIF_VALIDATE 0x00000020")]
    public const int BIF_VALIDATE = 0x00000020;

    [NativeTypeName("#define BIF_NEWDIALOGSTYLE 0x00000040")]
    public const int BIF_NEWDIALOGSTYLE = 0x00000040;

    [NativeTypeName("#define BIF_USENEWUI (BIF_NEWDIALOGSTYLE | BIF_EDITBOX)")]
    public const int BIF_USENEWUI = (0x00000040 | 0x00000010);

    [NativeTypeName("#define BIF_BROWSEINCLUDEURLS 0x00000080")]
    public const int BIF_BROWSEINCLUDEURLS = 0x00000080;

    [NativeTypeName("#define BIF_UAHINT 0x00000100")]
    public const int BIF_UAHINT = 0x00000100;

    [NativeTypeName("#define BIF_NONEWFOLDERBUTTON 0x00000200")]
    public const int BIF_NONEWFOLDERBUTTON = 0x00000200;

    [NativeTypeName("#define BIF_NOTRANSLATETARGETS 0x00000400")]
    public const int BIF_NOTRANSLATETARGETS = 0x00000400;

    [NativeTypeName("#define BIF_BROWSEFORCOMPUTER 0x00001000")]
    public const int BIF_BROWSEFORCOMPUTER = 0x00001000;

    [NativeTypeName("#define BIF_BROWSEFORPRINTER 0x00002000")]
    public const int BIF_BROWSEFORPRINTER = 0x00002000;

    [NativeTypeName("#define BIF_BROWSEINCLUDEFILES 0x00004000")]
    public const int BIF_BROWSEINCLUDEFILES = 0x00004000;

    [NativeTypeName("#define BIF_SHAREABLE 0x00008000")]
    public const int BIF_SHAREABLE = 0x00008000;

    [NativeTypeName("#define BIF_BROWSEFILEJUNCTIONS 0x00010000")]
    public const int BIF_BROWSEFILEJUNCTIONS = 0x00010000;
}
